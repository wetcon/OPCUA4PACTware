// Copyright (c) 2019-2025 wetcon gmbh. All rights reserved.
//
// Wetcon provides this source code under a dual license model 
// designed to meet the development and distribution needs of both 
// commercial distributors (such as OEMs, ISVs and VARs) and open 
// source projects.
//
// For open source projects the source code in this file is covered 
// under GPL V2. 
// See https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html
//
// OEMs (Original Equipment Manufacturers), ISVs (Independent Software 
// Vendors), VARs (Value Added Resellers) and other distributors that 
// combine and distribute commercially licensed software with this 
// source code and do not wish to distribute the source code for the 
// commercially licensed software under version 2 of the GNU General 
// Public License (the "GPL") must enter into a commercial license 
// agreement with wetcon.
//
// This source code is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY, without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

using NSubstitute;
using Opc.Ua;
using PWID.Interfaces;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt;
using Wetcon.PactwarePlugin.OpcUaServer.OpcUa.Models;

namespace Wetcon.PactwarePlugin.OpcUaServer.Plugin.Tests
{
    public class TestFdtServices
    {
        public IPACTwareProjectNode PACTwareProjectNode { get; }
        public IFdtServiceProvider FdtServiceProvider { get; }
        public DtmSingleInstanceDataAccessService DtmSingleInstanceDataAccessService { get; }
        public DtmParameterService DtmParameterService { get; }
        public DtmSingleDeviceDataAccessService DtmSingleDeviceDataAccessService { get; }
        public FdtContainerService FdtContainerService { get; }

        public TestFdtServices()
        {
            PACTwareProjectNode = Substitute.For<IPACTwareProjectNode>();
            var iOLinkDtmDeviceTypeXml = ResponseFileAccess.ReadAllText("PWIOLinkDtmDeviceType.xml");
            PACTwareProjectNode.CatalogueObject.DeviceTypeId.Returns(iOLinkDtmDeviceTypeXml);

            FdtServiceProvider = Substitute.For<IFdtServiceProvider>();
            DtmSingleInstanceDataAccessService = Substitute.For<DtmSingleInstanceDataAccessService>();
            DtmParameterService = Substitute.For<DtmParameterService>();
            DtmSingleDeviceDataAccessService = Substitute.For<DtmSingleDeviceDataAccessService>();
            FdtContainerService = Substitute.For<FdtContainerService>();

            RegisterService(DtmSingleInstanceDataAccessService);
            RegisterService(DtmParameterService);
            RegisterService(DtmSingleDeviceDataAccessService);
            RegisterService(FdtContainerService);
        }

        public OfflineDeviceModel CreateOfflineDevice()
        {
            var deviceSetNode = new BaseObjectState(null)
            {
                NodeId = new NodeId("")
            };
            var deviceModelContext = new DeviceModelContext(1, PACTwareProjectNode,
                FdtServiceProvider, deviceSetNode);

            return new OfflineDeviceModel(deviceModelContext);
        }

        public OnlineDeviceModel CreateOnlineDevice(bool readProcessData)
        {
            var deviceSetNode = new BaseObjectState(null)
            {
                NodeId = new NodeId("")
            };
            var deviceModelContext = new DeviceModelContext(1, PACTwareProjectNode,
                FdtServiceProvider, deviceSetNode);

            return new OnlineDeviceModel(deviceModelContext, readProcessData);
        }

        private void RegisterService<T>(T service) where T : IBaseFdtService
        {
            FdtServiceProvider.GetService<T>()
                .Returns(service);
        }
    }
}
