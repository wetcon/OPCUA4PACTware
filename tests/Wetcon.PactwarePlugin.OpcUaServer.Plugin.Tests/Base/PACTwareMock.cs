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
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Jigfdt.Fdt100;
using NSubstitute;
using PWID.EventArgs;
using PWID.Interfaces;

namespace Wetcon.PactwarePlugin.OpcUaServer.Plugin.Tests
{
    /// <summary>
    /// Creates a mock for IPACTwareUIKernel with the ability to add projects / devices
    /// </summary>
    public class PACTwareMock
    {
        /// <summary>
        /// Mocks the DTM interfaces
        /// </summary>
        class DtmMock : IDtmSingleInstanceDataAccess, IDtmSingleDeviceDataAccess, IDtmChannel, IFdtCommunication, IFdtChannel,
            IDtmOnlineParameter
        {
            public List<object> CallbackObjects { get; } = new List<object>();

            private object CommunicationCallbackObject { get; set; }

            private DtmMock() { }

            public static DtmMock Create(bool empty)
            {
                return empty ? null : new DtmMock();
            }

            string IDtmSingleInstanceDataAccess.GetItemList()
            {
                var response = ResponseFileAccess.ReadAllText("GetItemListResponse.xml");

                return response;
            }

            string IDtmSingleInstanceDataAccess.Read(string itemSelectionList)
            {
                var response = ResponseFileAccess.ReadAllText("ReadResponse.xml");

                return response;
            }

            string IDtmSingleInstanceDataAccess.Write(string itemList)
            {
                var response = ResponseFileAccess.ReadAllText("WriteResponse.xml");

                return response;
            }

            bool IDtmSingleDeviceDataAccess.CancelRequest(string invokeId)
            {
                throw new NotImplementedException();
            }

            void IDtmSingleDeviceDataAccess.ItemListRequest(string invokeId)
            {
                var response = ResponseFileAccess.ReadAllText("ItemListRequestResponse.xml");

                InvokeCallbacks<IDtmSingleDeviceDataAccessEvents>(e => e.OnItemListResponse(invokeId, response));
            }

            void IDtmSingleDeviceDataAccess.ReadRequest(string invokeId, string itemSelectionList)
            {
                var response = ResponseFileAccess.ReadAllText("ReadRequestResponse.xml");

                InvokeCallbacks<IDtmSingleDeviceDataAccessEvents>(e => e.OnReadResponse(invokeId, response));
            }

            void IDtmSingleDeviceDataAccess.WriteRequest(string invokeId, string itemList)
            {
                var response = ResponseFileAccess.ReadAllText("WriteRequestResponse.xml");

                InvokeCallbacks<IDtmSingleDeviceDataAccessEvents>(e => e.OnWriteResponse(invokeId, response));
            }

            IFdtChannelCollection IDtmChannel.GetChannels()
            {
                var channelCollection = Substitute.For<IFdtChannelCollection>();
                channelCollection.Count.Returns(1);
                channelCollection.get_Item(Arg.Any<object>()).Returns(this);

                return channelCollection;
            }

            void IFdtCommunication.Abort(string fieldbusFrame)
            {

            }

            bool IFdtCommunication.ConnectRequest(IFdtCommunicationEvents callBack, string invokeId, string protocolId,
                string fieldbusFrame)
            {
                CommunicationCallbackObject = callBack;
                var response = ResponseFileAccess.ReadAllText("ConnectResponse.xml");
                ((IFdtCommunicationEvents2)CommunicationCallbackObject).OnConnectResponse2(invokeId, string.Empty, response);

                return true;
            }

            bool IFdtCommunication.DisconnectRequest(string invokeId, string fieldbusFrame)
            {
                var response = ResponseFileAccess.ReadAllText("DisconnectResponse.xml");
                ((IFdtCommunicationEvents)CommunicationCallbackObject).OnDisconnectResponse(invokeId, response);

                return true;
            }

            bool IFdtCommunication.TransactionRequest(string invokeId, string fieldbusFrame)
            {
                var response = ResponseFileAccess.ReadAllText("TransactionResponse.xml");
                ((IFdtCommunicationEvents)CommunicationCallbackObject).OnTransactionResponse(invokeId, response);

                return true;
            }

            string IFdtCommunication.GetSupportedProtocols()
            {
                return ResponseFileAccess.ReadAllText("GetSupportedProtocolsResponse.xml");
            }

            bool IFdtCommunication.SequenceBegin(string fieldbusFrame)
            {
                return false;
            }

            bool IFdtCommunication.SequenceStart(string fieldbusFrame)
            {
                return false;
            }

            bool IFdtCommunication.SequenceEnd(string fieldbusFrame)
            {
                return false;
            }

            string IFdtChannel.GetChannelPath()
            {
                return "any path";
            }

            string IFdtChannel.GetChannelParameters(string parameterPath, string protocolId)
            {
                return string.Empty;
            }

            bool IFdtChannel.SetChannelParameters(string parameterPath, string protocolId, string XmlDocument)
            {
                return false;
            }

            bool IDtmOnlineParameter.CancelAction(string invokeId)
            {
                throw new NotImplementedException();
            }

            bool IDtmOnlineParameter.DownloadRequest(string invokeId, string parameterPath)
            {
                InvokeCallbacks<IDtmEvents>(e => e.OnDownloadFinished(invokeId, true));
                return true;
            }

            bool IDtmOnlineParameter.UploadRequest(string invokeId, string parameterPath)
            {
                InvokeCallbacks<IDtmEvents>(e => e.OnUploadFinished(invokeId, true));
                return true;
            }

            private void InvokeCallbacks<T>(Action<T> fn)
            {
                CallbackObjects.OfType<T>()
                    .ToList()
                    .ForEach(fn);
            }
        }

        public IPACTwareUIKernel PACTwareUIKernel { get; }
        public List<IPACTwareProjectNode> Devices { get; }

        private PACTwareMock()
        {
            Devices = new List<IPACTwareProjectNode>();
            PACTwareUIKernel = Substitute.For<IPACTwareUIKernel>();
            PACTwareUIKernel.PACTwareKernel.Project.Collection
                .Returns(a => new ReadOnlyCollection<IPACTwareProjectNode>(Devices));
        }

        public static PACTwareMock Create()
        {
            return new PACTwareMock();
        }

        public PACTwareMock AddDevice(string deviceName, string deviceId, bool emptyDevice, bool isIoLink = false,
            bool isOnline = false)
        {
            var device = CreateDevice(deviceName, deviceId, emptyDevice, isIoLink, isOnline);
            Devices.Add(device);

            PACTwareUIKernel.PACTwareKernel.Project.AddProjectNodeEvent += Raise.EventWith(new object(),
                new PACTwareEventActionProjectNodeArgs("", true, null, device));

            return this;
        }

        private IPACTwareProjectNode CreateDevice(string deviceName, string deviceId, bool emptyDevice,
            bool isIoLink = false, bool isOnline = false)
        {
            var device = Substitute.For<IPACTwareProjectNode>();
            device.CatalogueObject.Id.Returns(deviceId);

            device.OnlineState.Returns(isOnline ? PWID.Enumerations.PACTwareEnumNodeOnlineState.ID_OSTATE_CONNECTEDONLINE
                : PWID.Enumerations.PACTwareEnumNodeOnlineState.ID_OSTATE_UNKNOWN);

            device.Id.Returns(deviceId);
            device.Tagname.Returns(deviceName);

            device.BeginGetObjectPointer(Arg.Any<string>(), Arg.Any<AsyncCallback>(), Arg.Any<object>())
                .Returns(Task.CompletedTask);

            var dtmMock = DtmMock.Create(emptyDevice);

            device.EndGetObjectPointer(Arg.Any<IAsyncResult>())
                .Returns(dtmMock);

            device.BeginReleaseObjectPointer(Arg.Any<string>(), Arg.Any<AsyncCallback>(), Arg.Any<object>())
                .Returns(Task.CompletedTask);

            device.EndReleaseObjectPointer(Arg.Any<IAsyncResult>())
                .Returns(true);

            device.BeginAddObjectCallbackObserver(Arg.Any<string>(), Arg.Any<object>(), Arg.Any<AsyncCallback>(),
                Arg.Any<object>())
                .Returns(Task.CompletedTask)
                .AndDoes(c =>
                {
                    dtmMock?.CallbackObjects.Add(c[1]);
                });

            device.EndAddObjectCallbackObserver(Arg.Any<IAsyncResult>())
                .Returns(true);


            device.BeginRemoveObjectCallbackObserver(Arg.Any<string>(), Arg.Any<object>(), Arg.Any<AsyncCallback>(),
                Arg.Any<object>())
                .Returns(Task.CompletedTask)
                .AndDoes(c =>
                {
                    dtmMock?.CallbackObjects.Remove(c[1]);
                });

            device.EndRemoveObjectCallbackObserver(Arg.Any<IAsyncResult>())
                .Returns(true);

            if (isIoLink)
            {
                var iOLinkDtmDeviceTypeXml = ResponseFileAccess.ReadAllText("PWIOLinkDtmDeviceType.xml");
                device.CatalogueObject.DeviceTypeId.Returns(iOLinkDtmDeviceTypeXml);

                var parent = Substitute.For<IPACTwareProjectNode>();
                var parentParent = CreateDevice("channel", "channelId", false);

                parent.Parents.Returns(new ReadOnlyCollection<IPACTwareProjectNode>(new List<IPACTwareProjectNode>()
                {
                    parentParent
                }));

                device.Parents.Returns(new ReadOnlyCollection<IPACTwareProjectNode>(new List<IPACTwareProjectNode>()
                {
                    parent
                }));
            }

            return device;
        }
    }
}
