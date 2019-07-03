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
using PWID.Interfaces;

namespace Wetcon.PactwarePlugin.OpcUaServer.Fdt
{
    /// <summary>
    /// Provides methods to make connect, transaction and disconnect requests on an IFdtCommunication interface
    /// in order to read process values from an IO link device.
    /// </summary>
    public class IOProcessParametersService : BaseFdtService<IDtmChannel>, IFdtCommunicationEvents, IFdtCommunicationEvents2
    {
        public class NotConnectedException : Exception
        {

        }

        private class CommunicationContext
        {
            public string BusCategoryId { get; }
            public IFdtCommunication FdtCommunication { get; }

            public CommunicationContext(string busCategoryId, IFdtCommunication fdtCommunication)
            {
                BusCategoryId = busCategoryId;
                FdtCommunication = fdtCommunication;
            }

            public bool CommunicationAvailable => null != FdtCommunication;

            public static CommunicationContext Unavailable => new CommunicationContext(null, null);
        }
        private CommunicationContext _context;
        private readonly IOCommunicationXml _communicationXml = new IOCommunicationXml();
        private readonly InvokeResponseSubject _fdtCommunicationOnConnectRespSubj = new InvokeResponseSubject(Constants.Timeouts.CommunicationConnectTimeout);
        private readonly InvokeResponseSubject _fdtCommunicationOnDisconnectRespSubj = new InvokeResponseSubject(Constants.Timeouts.CommunicationDisconnectTimeout);
        private readonly InvokeResponseSubject _fdtCommunicationOnTransactionRespSubj = new InvokeResponseSubject(Constants.Timeouts.CommunicationTransactionTimeout);

        protected override IPACTwareProjectNode DtmProjectNode
        {
            get
            {
                if (PactwareProjectNode.Parents?.Count > 0 &&
                    PactwareProjectNode.Parents[0].Parents?.Count > 0)
                {
                    return PactwareProjectNode.Parents?[0].Parents?[0];
                }

                return null;
            }
        }

        /// <summary>
        /// Returns process data information as hexadecimal string.
        /// </summary>
        /// <returns></returns>
        public string ReadIOProcessParameter(IPACTwareProjectNode pactwareProjectNode)
        {
            if (pactwareProjectNode.OnlineState != PACTwareEnumNodeOnlineState.ID_OSTATE_CONNECTEDONLINE)
            {
                throw new NotConnectedException();
            }

            _context = _context ?? Initialize(pactwareProjectNode);

            if (!_context.CommunicationAvailable)
            {
                return null;
            }

            var connectResponse = ConnectRequest(_context);

            if (null == connectResponse || IOCommunicationXml.HasError(connectResponse.Response))
            {
                return null;
            }

            var communicationReference = IOCommunicationXml.ParseCommunicationReference(connectResponse.Response);
            var transactionResponse = TransactionRequest(_context, communicationReference);
            var processData = IOCommunicationXml.ParseCommunicationByteArray(transactionResponse.Response);

            DisconnectRequest(_context, communicationReference);

            return processData;
        }

        public override void OnLoadProjectNode(IPACTwareProjectNode pactwareProjectNode)
        {
            base.OnLoadProjectNode(pactwareProjectNode);
            _context = null;
        }

        public override void OnUnloadProjectNode()
        {
            base.OnUnloadProjectNode();
            _context = null;
        }

        private CommunicationContext Initialize(IPACTwareProjectNode pactwareProjectNode)
        {
            if (pactwareProjectNode.Parents.Count == 0 ||
                pactwareProjectNode.Parents[0].Parents.Count == 0 ||
                DtmInterface.ObjectPointer == null)
            {
                return CommunicationContext.Unavailable;
            }

            var channelCollection = DtmInterface.ObjectPointer.GetChannels();

            if (channelCollection.Count == 0)
            {
                return CommunicationContext.Unavailable;
            }

            object pVarIndex = 1;
            var firstChannel = channelCollection.get_Item(ref pVarIndex);
            if (firstChannel == null)
            {
                return CommunicationContext.Unavailable;
            }

            var fdtCommunication = firstChannel as IFdtCommunication;
            var protocols = fdtCommunication?.GetSupportedProtocols();
            var busCategoryId = IOCommunicationXml.ParseBusCategoryId(protocols);

            return new CommunicationContext(busCategoryId, fdtCommunication);
        }

        private InvokeResponseInfo ConnectRequest(CommunicationContext context)
        {
            var invokeContext = _fdtCommunicationOnConnectRespSubj.CreateNewContext();

            context.FdtCommunication.ConnectRequest(this, invokeContext.InvokeId, context.BusCategoryId, _communicationXml.GetConnectRequestXml(""));

            return WaitFor(invokeContext.InvocationTask);
        }

        private InvokeResponseInfo TransactionRequest(CommunicationContext context, string communicationReference)
        {
            var invokeContext = _fdtCommunicationOnTransactionRespSubj.CreateNewContext();

            context.FdtCommunication.TransactionRequest(invokeContext.InvokeId, _communicationXml.GetTransactionRequestXml(communicationReference));

            return WaitFor(invokeContext.InvocationTask);
        }

        private InvokeResponseInfo DisconnectRequest(CommunicationContext context, string communicationReference)
        {
            var invokeContext = _fdtCommunicationOnDisconnectRespSubj.CreateNewContext();

            context.FdtCommunication.DisconnectRequest(invokeContext.InvokeId, _communicationXml.GetDisconnectRequest(communicationReference));

            return WaitFor(invokeContext.InvocationTask);
        }

        void IFdtCommunicationEvents.OnConnectResponse(string invokeId, string response)
        {
            _fdtCommunicationOnConnectRespSubj.OnNext(invokeId, response);
        }

        void IFdtCommunicationEvents.OnDisconnectResponse(string invokeId, string response)
        {
            _fdtCommunicationOnDisconnectRespSubj.OnNext(invokeId, response);
        }

        void IFdtCommunicationEvents.OnTransactionResponse(string invokeId, string response)
        {
            _fdtCommunicationOnTransactionRespSubj.OnNext(invokeId, response);
        }

        void IFdtCommunicationEvents2.OnConnectResponse2(string invokeId, string parentInformation, string response)
        {
            _fdtCommunicationOnConnectRespSubj.OnNext(invokeId, response);
        }

        void IFdtCommunicationEvents.OnAbort(string communicationReference) { }
    }
}
