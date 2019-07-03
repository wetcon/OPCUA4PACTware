/* Copyright (c) 2019 wetcon gmbh. All rights reserved.

   Wetcon provides this source code under a dual license model 
   designed to meet the development and distribution needs of both 
   commercial distributors (such as OEMs, ISVs and VARs) and open 
   source projects.

   For open source projects the source code in this file is covered 
   under GPL V2. 
   See https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html

   OEMs (Original Equipment Manufacturers), ISVs (Independent Software 
   Vendors), VARs (Value Added Resellers) and other distributors that 
   combine and distribute commercially licensed software with this 
   source code and do not wish to distribute the source code for the 
   commercially licensed software under version 2 of the GNU General 
   Public License (the "GPL") must enter into a commercial license 
   agreement with wetcon.

   This source code is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
*/

using System;
using Jigfdt.Fdt100;
using PWID.Enumerations;

namespace Wetcon.PactwarePlugin.OpcUaServer.Fdt
{
    /// <summary>
    /// Performs IDtmOnlineParameter Upload / Download requests. Also keeps track of the last request for
    /// each device to be queried later by FetchTransferResultData method.
    /// </summary>
    public class DtmOnlineParameterService : AsyncFdtService<IDtmOnlineParameter>, IDtmEvents
    {
        private readonly InvokeResponseSubject _transferRequestRespSubj = new InvokeResponseSubject(Constants.Timeouts.TransferRequestTimeout);
        private readonly TransferResultsCache _transferResultsCache = new TransferResultsCache();

        public TransferResult FetchTransferResultData(int transferId)
        {
            return _transferResultsCache.GetResult(PactwareProjectNode.Id, transferId);
        }

        public InitTransferResponse StartUploadRequest()
        {
            return InvokeAsync(_transferRequestRespSubj, DoStartTransfer(isUpload: true));
        }

        public InitTransferResponse StartDownloadRequest()
        {
            return InvokeAsync(_transferRequestRespSubj, DoStartTransfer(isUpload: false));
        }

        private Func<InvokeResponseContext, InitTransferResponse> DoStartTransfer(bool isUpload)
        {
            return context =>
            {
                if (PactwareProjectNode.OnlineState != PACTwareEnumNodeOnlineState.ID_OSTATE_CONNECTEDONLINE)
                {
                    return InitTransferResponse.NotOnline(0);
                }

                _transferResultsCache.Add(PactwareProjectNode.Id, context.InvocationTask);

                if (DtmInterface.ObjectPointer == null)
                {
                    return InitTransferResponse.NotOnline(context.InvokeIdHash);
                }

                var result = isUpload ? DtmInterface.ObjectPointer.UploadRequest(context.InvokeId, "FDT") :
                    DtmInterface.ObjectPointer.DownloadRequest(context.InvokeId, "FDT");

                LogDtmCall("TransferRequest", result);

                if (result)
                {
                    return InitTransferResponse.Ok(context.InvokeIdHash);
                }

                return InitTransferResponse.NotOnline(context.InvokeIdHash);
            };
        }

        void IDtmEvents.OnErrorMessage(string systemTag, string errorMessage)
        {
            _transferRequestRespSubj.OnError(errorMessage);
        }

        void IDtmEvents.OnUploadFinished(string invokeId, bool success)
        {
            _transferRequestRespSubj.OnNext(invokeId, success.ToString());
        }

        void IDtmEvents.OnDownloadFinished(string invokeId, bool success)
        {
            _transferRequestRespSubj.OnNext(invokeId, success.ToString());
        }

        void IDtmEvents.OnParameterChanged(string systemTag, string parameter) { }
        void IDtmEvents.OnProgress(string systemTag, string title, short percent, bool show) { }
        void IDtmEvents.OnApplicationClosed(string invokeId) { }
        void IDtmEvents.OnFunctionChanged(string systemTag) { }
        void IDtmEvents.OnChannelFunctionChanged(string systemTag, string channelPath) { }
        void IDtmEvents.OnPrint(string systemTag, string functionCall) { }
        void IDtmEvents.OnNavigation(string systemTag) { }
        void IDtmEvents.OnOnlineStateChanged(string systemTag, bool onlineState) { }
        void IDtmEvents.OnPreparedToRelease(string systemTag) { }
        void IDtmEvents.OnPreparedToReleaseCommunication(string systemTag) { }
        void IDtmEvents.OnInvokedFunctionFinished(string invokeId, bool success) { }
        void IDtmEvents.OnScanResponse(string invokeId, string response) { }
    }
}
