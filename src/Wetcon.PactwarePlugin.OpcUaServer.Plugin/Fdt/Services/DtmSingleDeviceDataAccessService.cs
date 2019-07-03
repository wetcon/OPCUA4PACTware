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
using System.Collections.Generic;
using Jigfdt.Fdt100;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt.Models;

namespace Wetcon.PactwarePlugin.OpcUaServer.Fdt
{
    /// <summary>
    /// Provides methods to get, read and write online device parameters (using IDtmSingleDeviceDataAccess).
    /// </summary>
    public class DtmSingleDeviceDataAccessService : AsyncFdtService<IDtmSingleDeviceDataAccess>, IDtmSingleDeviceDataAccessEvents
    {
        private readonly InvokeResponseSubject _onWriteRespSubj = new InvokeResponseSubject(Constants.Timeouts.WriteOnlineDeviceParametersTimeout);
        private readonly InvokeResponseSubject _onReadRespSubj = new InvokeResponseSubject(Constants.Timeouts.ReadOnlineDeviceParametersTimeout);
        private readonly InvokeResponseSubject _onItemListRespSubj = new InvokeResponseSubject(Constants.Timeouts.GetOnlineDeviceParametersTimeout);

        public virtual List<DtmParameter> GetOnlineDeviceParameters()
        {
            return InvokeAsync(_onItemListRespSubj, context =>
            {
                if (DtmInterface.ObjectPointer == null)
                {
                    return null;
                }

                DtmInterface.ObjectPointer.ItemListRequest(context.InvokeId);

                var response = WaitFor(context.InvocationTask);
                if (response == null)
                {
                    throw new TimeoutException("GetOnlineDeviceParameters timeout.");
                }
                LogDtmCall("ItemListRequest", response.Response);
                var dtmItemList = FdtXmlSerializer.Deserialize<DtmItemListFdtDoc>(response.Response);

                return DtmParameterMerger.Flatten(ParameterDataSourceKind.DtmSingleDeviceDataAccess, dtmItemList.ItemInfoList);
            });
        }

        public virtual DtmItemList ReadOnlineDeviceParameters(DtmItemSelectionList dtmItemSelectionList)
        {
            return InvokeAsync(_onReadRespSubj, context =>
            {
                if (DtmInterface.ObjectPointer == null)
                {
                    return null;
                }

                var fdtDoc = new DtmItemListFdtDoc { ItemSelectionList = dtmItemSelectionList };
                var fdtDocXml = FdtXmlSerializer.Serialize(fdtDoc);

                DtmInterface.ObjectPointer.ReadRequest(context.InvokeId, fdtDocXml);

                var readResponse = WaitFor(context.InvocationTask);
                if (readResponse == null)
                {
                    throw new TimeoutException("GetOnlineDeviceParameters timeout.");
                }

                LogDtmCall("ReadRequest", readResponse.Response);
                var responseFdtDocXml = FdtXmlSerializer.Deserialize<DtmItemListFdtDoc>(readResponse.Response);

                return responseFdtDocXml.ItemList;
            });
        }

        public virtual DtmItemList WriteOnlineDeviceParameters(DtmItemList dtmItemList)
        {
            return InvokeAsync(_onWriteRespSubj, context =>
            {
                if (DtmInterface.ObjectPointer == null)
                {
                    return null;
                }

                var fdtDoc = new DtmItemListFdtDoc { ItemList = dtmItemList };
                var fdtDocXml = FdtXmlSerializer.Serialize(fdtDoc);

                DtmInterface.ObjectPointer.WriteRequest(context.InvokeId, fdtDocXml);

                var writeResponse = WaitFor(context.InvocationTask);
                if (writeResponse == null)
                {
                    throw new TimeoutException("GetOnlineDeviceParameters timeout.");
                }

                LogDtmCall("WriteRequest", writeResponse.Response);
                var responseFdtDocXml = FdtXmlSerializer.Deserialize<DtmItemListFdtDoc>(writeResponse.Response);

                return responseFdtDocXml.ItemList;
            });
        }

        void IDtmSingleDeviceDataAccessEvents.OnItemListResponse(string invokeId, string response)
        {
            _onItemListRespSubj.OnNext(invokeId, response);
        }

        void IDtmSingleDeviceDataAccessEvents.OnReadResponse(string invokeId, string response)
        {
            _onReadRespSubj.OnNext(invokeId, response);
        }

        void IDtmSingleDeviceDataAccessEvents.OnWriteResponse(string invokeId, string response)
        {
            _onWriteRespSubj.OnNext(invokeId, response);
        }

        void IDtmSingleDeviceDataAccessEvents.OnDeviceItemListChanged(string systemTag) { }
    }
}
