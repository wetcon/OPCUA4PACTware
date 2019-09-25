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

using System.Collections.Generic;
using Opc.Ua;
using Opc.Ua.Di;
using Opc.Ua.Server;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt;

namespace Wetcon.PactwarePlugin.OpcUaServer.OpcUa.Models
{
    /// <summary>
    /// Represents the Online Device model with TransferService functionality.
    /// </summary>
    public class OfflineDeviceModel : BaseDeviceModel
    {
        public OfflineDeviceModel(DeviceModelContext deviceModelContext) :
            base(deviceModelContext, false)
        {
            TransferService = new TransferServicesState(this);
        }

        public TransferServicesState TransferService
        {
            get => m_transferService;

            set
            {
                if (!object.ReferenceEquals(m_transferService, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_transferService = value;
            }
        }

        protected override DeviceModelType DeviceModelType => DeviceModelType.Offline;

        public override void GetChildren(ISystemContext context, IList<BaseInstanceState> children)
        {
            if (m_transferService != null)
            {
                children.Add(m_transferService);
            }

            base.GetChildren(context, children);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            TransferService.Initialize(context, TransferService_InitializationString);
            TransferService.BrowseName = new QualifiedName("Transfer");
            TransferService.DisplayName = new LocalizedText("Transfer");
            TransferService.TransferToDevice.OnCall = TransferToDevice;
            TransferService.TransferFromDevice.OnCall = TransferFromDevice;
            TransferService.FetchTransferResultData.OnCall = FetchTransferResultData;

            base.InitializeOptionalChildren(context);
        }

        private ServiceResult FetchTransferResultData(ISystemContext context, MethodState method, NodeId objectId, int transferId,
            int sequenceNumber, int maxParameterResultsToReturn, bool omitGoodResults, ref FetchResultDataType fetchResult)
        {
            var result = FdtService.GetService<DtmOnlineParameterService>()
                .FetchTransferResultData(transferId);

            switch (result.Status)
            {
                case TransferStatus.Completed:

                    if (true.ToString().Equals(result.Response))
                    {
                        return new ServiceResult(StatusCodes.BadNothingToDo);
                    }

                    return new ServiceResult(StatusCodes.Bad);
                case TransferStatus.NoResultsForDevice:
                case TransferStatus.NoResultsForTransferId:
                    return new ServiceResult(StatusCodes.BadResourceUnavailable);
                case TransferStatus.Timeout:
                    return new ServiceResult(StatusCodes.BadRequestTimeout);
            }

            return new ServiceResult(StatusCodes.Bad);
        }

        private ServiceResult TransferFromDevice(ISystemContext context, MethodState method, NodeId objectId,
            ref int transferId, ref int initTransferStatus)
        {
            var result = FdtService.GetService<DtmOnlineParameterService>()
                .StartDownloadRequest();

            transferId = result.TransferId;
            initTransferStatus = (int)result.InitTransferStatus;

            return ServiceResult.Good;
        }

        private ServiceResult TransferToDevice(ISystemContext context, MethodState method, NodeId objectId,
            ref int transferId, ref int initTransferStatus)
        {
            var result = FdtService.GetService<DtmOnlineParameterService>()
                .StartUploadRequest();

            transferId = result.TransferId;
            initTransferStatus = (int)result.InitTransferStatus;

            return ServiceResult.Good;
        }

        private const string TransferService_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAABAAAAAQAcAAAAVHJh" +
           "bnNmZXJTZXJ2aWNlc1R5cGVJbnN0YW5jZQEBfhkBAX4Z/////wMAAAAEYYIKBAAAAAEAEAAAAFRyYW5z" +
           "ZmVyVG9EZXZpY2UBAX8ZAC8BAX8ZfxkAAAEB/////wEAAAAVYKkKAgAAAAAADwAAAE91dHB1dEFyZ3Vt" +
           "ZW50cwEBgBkALgBEgBkAAJYCAAAAAQAqAQEZAAAACgAAAFRyYW5zZmVySUQABv////8AAAAAAAEAKgEB" +
           "IQAAABIAAABJbml0VHJhbnNmZXJTdGF0dXMABv////8AAAAAAAEAKAEBAAAAAQH/////AAAAAARhggoE" +
           "AAAAAQASAAAAVHJhbnNmZXJGcm9tRGV2aWNlAQGBGQAvAQGBGYEZAAABAf////8BAAAAFWCpCgIAAAAA" +
           "AA8AAABPdXRwdXRBcmd1bWVudHMBAYIZAC4ARIIZAACWAgAAAAEAKgEBGQAAAAoAAABUcmFuc2ZlcklE" +
           "AAb/////AAAAAAABACoBASEAAAASAAAASW5pdFRyYW5zZmVyU3RhdHVzAAb/////AAAAAAABACgBAQAA" +
           "AAEB/////wAAAAAEYYIKBAAAAAEAFwAAAEZldGNoVHJhbnNmZXJSZXN1bHREYXRhAQGDGQAvAQGDGYMZ" +
           "AAABAf////8CAAAAFWCpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBhBkALgBEhBkAAJYEAAAAAQAq" +
           "AQEZAAAACgAAAFRyYW5zZmVySUQABv////8AAAAAAAEAKgEBHQAAAA4AAABTZXF1ZW5jZU51bWJlcgAG" +
           "/////wAAAAAAAQAqAQEqAAAAGwAAAE1heFBhcmFtZXRlclJlc3VsdHNUb1JldHVybgAG/////wAAAAAA" +
           "AQAqAQEeAAAADwAAAE9taXRHb29kUmVzdWx0cwAB/////wAAAAAAAQAoAQEAAAABAf////8AAAAAFWCp" +
           "CgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAYUZAC4ARIUZAACWAQAAAAEAKgEBHAAAAAsAAABGZXRj" +
           "aFJlc3VsdAEBehn/////AAAAAAABACgBAQAAAAEB/////wAAAAA=";

        private TransferServicesState m_transferService;

        internal static List<NodeState> Add(DeviceModelContext deviceModelContext, ServerSystemContext systemContext,
            bool readIOProcessData)
        {
            // Add the offline device node.
            var offlineDeviceModel = new OfflineDeviceModel(deviceModelContext);
            var browseName = new QualifiedName(offlineDeviceModel.DeviceName + "." + offlineDeviceModel.DeviceId,
                deviceModelContext.ServerNamespaceIndex);
            var displayName = new LocalizedText(offlineDeviceModel.DeviceName);
            var uniqueNodeId = MakeUniqueNodeId(offlineDeviceModel.NodeId, deviceModelContext.ExistingNodeIds);

            deviceModelContext.ExistingNodeIds.Add(uniqueNodeId);
            deviceModelContext.Parent.AddChild(offlineDeviceModel);

            offlineDeviceModel.Create(
                systemContext,
                uniqueNodeId,
                browseName,
                displayName,
                true);

            var onlineDeviceModel = OnlineDeviceModel.Add(deviceModelContext.WithNewParent(offlineDeviceModel),
                systemContext, readIOProcessData);

            return new List<NodeState>()
            {
                offlineDeviceModel,
                onlineDeviceModel
            };
        }

        /// <summary>
        /// Makes sure an OPC UA NodeId is unique, considering the existing node ids.
        /// </summary>
        /// <param name="nodeId"></param>
        /// <param name="existingNodeIds"></param>
        /// <returns></returns>
        internal static NodeId MakeUniqueNodeId(NodeId nodeId, List<NodeId> existingNodeIds)
        {
            if (null == existingNodeIds || 0 == existingNodeIds.Count)
            {
                return nodeId;
            }

            var i = 0;
            var result = new NodeId(nodeId);
            var initialString = nodeId.Identifier.ToString();

            while (existingNodeIds.Contains(result))
            {
                result = new NodeId($"{initialString}.{++i}", nodeId.NamespaceIndex);
            }

            return result;
        }
    }
}
