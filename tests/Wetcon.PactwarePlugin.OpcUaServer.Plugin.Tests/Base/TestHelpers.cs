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
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using NSubstitute;
using Opc.Ua;
using PWID.Interfaces;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt;
using Wetcon.PactwarePlugin.OpcUaServer.Infrastructure;
using Wetcon.PactwarePlugin.OpcUaServer.OpcUa.Models;

namespace Wetcon.PactwarePlugin.OpcUaServer.Plugin.Tests
{
    public static class FileAccess
    {
        public const string FILES_FOLDER = "Files";

        public static string ReadAllText(string fileName)
        {
            var filePath = GetPath(fileName);

            return File.ReadAllText(filePath);
        }

        public static string GetPath(string fileName)
        {
            return Path.Combine(FILES_FOLDER, fileName);
        }
    }

    public static class ResponseFileAccess
    {
        const string FDT_RESPONSE_XML_FOLDER = "Responses";

        public static string ReadAllText(string fileName)
        {
            var filePath = Path.Combine(FileAccess.FILES_FOLDER, FDT_RESPONSE_XML_FOLDER, fileName);

            return File.ReadAllText(filePath);
        }
    }

    public class TestContext
    {
        public OpcUaClient.Base.OpcUaClient Client { get; }
        public OpcUaServer Server { get; }

        public NodeId DeviceSetNodeId => Opc.Ua.Di.ObjectIds.DeviceSet.ToNodeId(Server.CurrentInstance.NamespaceUris);

        public NodeId GetNodeIdByDisplayName(ReferenceDescriptionCollection referenceDescriptionCollection, string displayName)
        {
            var expandedNodeId = referenceDescriptionCollection.First(rd => rd.DisplayName.Text.Equals(displayName)).NodeId;

            return expandedNodeId.ToNodeId(Server.CurrentInstance.NamespaceUris);
        }

        public TestContext(OpcUaServer server, OpcUaClient.Base.OpcUaClient client)
        {
            Server = server;
            Client = client;
        }
    }

    public class TestHelper
    {
        static readonly IPluginSettings s_pluginSettings = PluginSettings.LoadSettings();

        public static OpcUaApplicationManager CreateApplicationManager(IPACTwareUIKernel pactwareUIKernel)
        {
            return new OpcUaApplicationManager(pactwareUIKernel, s_pluginSettings);
        }

        public static Task ExecuteAsync(PACTwareMock pwMock, Action<TestContext> fn)
        {
            return ExecuteAsync(pwMock.PACTwareUIKernel, fn);
        }

        private async static Task ExecuteAsync(IPACTwareUIKernel pactwareUIKernel, Action<TestContext> fn)
        {
            var appManager = CreateApplicationManager(pactwareUIKernel);

            await appManager.StartApplicationAsync();

            using (var client = new OpcUaClient.Base.OpcUaClient())
            {
                await client.Initialize(appManager.Server);
                fn(new TestContext(appManager.Server, client));
            }

            await appManager.StopApplicationAsync();
        }
    }

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

            return new OfflineDeviceModel(1, PACTwareProjectNode, FdtServiceProvider, deviceSetNode);
        }

        public OnlineDeviceModel CreateOnlineDevice(bool readProcessData)
        {
            var deviceSetNode = new BaseObjectState(null)
            {
                NodeId = new NodeId("")
            };

            return new OnlineDeviceModel(1, PACTwareProjectNode, FdtServiceProvider, deviceSetNode, readProcessData);
        }

        private void RegisterService<T>(T service) where T : IBaseFdtService
        {
            FdtServiceProvider.GetService<T>().Returns(service);
        }
    }
}
