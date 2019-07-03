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
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opc.Ua;
using Wetcon.PactwarePlugin.OpcUaServer.Infrastructure;

namespace Wetcon.PactwarePlugin.OpcUaServer.Plugin.Tests
{
    public static class TestCategories
    {
        public const string Integrated = "Integrated";
    }

    [TestClass]
    public class OpcUaPluginIntegrationTests
    {
        const string IO_LINK_DEVICENAME = "IO-Link Communication (E30396)";
        const string IO_LINK_GUID = "5b940775-4912-4f76-82ff-f524df6392a5";
        const string OPTICAL_SENSOR_DEVICENAME = "O5D100..O5D152 IODD1.0.1";
        const string OPTICAL_SENSOR_GUID = "2aad1c63-3bab-4492-92c0-b2494edfa031";

        /// <summary>
        /// Simulates a default setup
        /// </summary>
        /// <returns></returns>
        private PACTwareMock CreatePWMockWithDefaultDevices(bool isIoLink = false, bool isOnline = false)
        {
            return PACTwareMock.Create()
                    .AddDevice(IO_LINK_DEVICENAME, IO_LINK_GUID, true, false, isOnline)
                    .AddDevice(OPTICAL_SENSOR_DEVICENAME, OPTICAL_SENSOR_GUID, false, isIoLink, isOnline);
        }

        /// <summary>
        /// Basic sanity checks that the server implements Device Integration Model
        /// </summary>
        [TestMethod, TestCategory(TestCategories.Integrated)]
        public async Task DIModelImplementedAsync()
        {
            await TestHelper.ExecuteAsync(PACTwareMock.Create(), context =>
            {
                AssertIsObjectAvailable(Opc.Ua.Di.ObjectIds.DeviceSet, context);
                AssertIsObjectAvailable(Opc.Ua.Di.ObjectIds.DeviceTopology, context);
                AssertIsObjectAvailable(Opc.Ua.Di.ObjectIds.NetworkSet, context);
            });
        }

        /// <summary>
        /// If PW project collection is empty, there shouldn't be any devices.
        /// </summary>
        [TestMethod, TestCategory(TestCategories.Integrated)]
        public async Task EmptyProjectCollectionAsync()
        {
            await TestHelper.ExecuteAsync(PACTwareMock.Create(), context =>
            {
                context.Client.Browse(context.DeviceSetNodeId, out var refs);

                Assert.AreEqual(0, refs.Count);
            });
        }

        [TestMethod, TestCategory(TestCategories.Integrated)]
        public async Task DefaultProjectCollectionAsync()
        {
            var pwMock = CreatePWMockWithDefaultDevices();

            await TestHelper.ExecuteAsync(pwMock, context =>
            {
                context.Client.Browse(context.DeviceSetNodeId, out var refs);

                Assert.AreEqual(pwMock.Devices.Count, refs.Count);

                refs.ForEach(r =>
                {
                    Assert.IsTrue(pwMock.Devices.Any(p => p.Tagname.Equals(r.DisplayName.Text)));
                });
            });
        }

        /// <summary>
        /// Browse offline parameter on a device not implementing any dtm interface
        /// </summary>
        [TestMethod, TestCategory(TestCategories.Integrated)]
        public async Task BrowseEmptyOfflineParameterAsync()
        {
            await TestHelper.ExecuteAsync(CreatePWMockWithDefaultDevices(), context =>
            {
                context.Client.Browse(context.DeviceSetNodeId, out var refs);
                var nodeId = context.GetNodeIdByDisplayName(refs, IO_LINK_DEVICENAME);
                context.Client.Browse(nodeId, out var deviceRefs);

                var offlineParameterNodeId = context.GetNodeIdByDisplayName(deviceRefs, Opc.Ua.Di.BrowseNames.ParameterSet);

                context.Client.Browse(offlineParameterNodeId, out var parameterRefs);

                Assert.AreEqual(0, parameterRefs.Count);
            });
        }

        /// <summary>
        /// Browse online parameter on a device not implementing any dtm interface
        /// </summary>
        [TestMethod, TestCategory(TestCategories.Integrated)]
        public async Task BrowseEmptyOnlineParameterAsync()
        {
            await TestHelper.ExecuteAsync(CreatePWMockWithDefaultDevices(), context =>
            {
                context.Client.Browse(context.DeviceSetNodeId, out var refs);
                var offlineNodeId = context.GetNodeIdByDisplayName(refs, IO_LINK_DEVICENAME);
                context.Client.Browse(offlineNodeId, out var offlineDeviceRefs);

                var onlineNodeId = context.GetNodeIdByDisplayName(offlineDeviceRefs, "Online");

                context.Client.Browse(onlineNodeId, out var onlineDeviceRefs);

                var offlineParameterNodeId = context.GetNodeIdByDisplayName(onlineDeviceRefs, Opc.Ua.Di.BrowseNames.ParameterSet);

                context.Client.Browse(offlineParameterNodeId, out var parameterRefs);

                Assert.AreEqual(0, parameterRefs.Count);
            });
        }

        [TestMethod, TestCategory(TestCategories.Integrated)]
        public async Task BrowseOfflineParameterAsync()
        {
            await TestHelper.ExecuteAsync(CreatePWMockWithDefaultDevices(), context =>
            {
                context.Client.Browse(context.DeviceSetNodeId, out var refs);
                var nodeId = context.GetNodeIdByDisplayName(refs, OPTICAL_SENSOR_DEVICENAME);
                context.Client.Browse(nodeId, out var deviceRefs);

                var offlineParameterNodeId = context.GetNodeIdByDisplayName(deviceRefs, Opc.Ua.Di.BrowseNames.ParameterSet);

                context.Client.Browse(offlineParameterNodeId, out var parameterRefs);

                Assert.AreEqual(23, parameterRefs.Count);
            });
        }

        [TestMethod, TestCategory(TestCategories.Integrated)]
        public async Task BrowseOnlineParameterAsync()
        {
            await TestHelper.ExecuteAsync(CreatePWMockWithDefaultDevices(), context =>
            {
                context.Client.Browse(context.DeviceSetNodeId, out var refs);
                var nodeId = context.GetNodeIdByDisplayName(refs, OPTICAL_SENSOR_DEVICENAME);
                context.Client.Browse(nodeId, out var offlineDeviceRefs);

                var onlineNodeId = context.GetNodeIdByDisplayName(offlineDeviceRefs, "Online");

                context.Client.Browse(onlineNodeId, out var onlineDeviceRefs);

                var offlineParameterNodeId = context.GetNodeIdByDisplayName(onlineDeviceRefs, Opc.Ua.Di.BrowseNames.ParameterSet);

                context.Client.Browse(offlineParameterNodeId, out var parameterRefs);

                Assert.AreEqual(23, parameterRefs.Count);
            });
        }

        [TestMethod, TestCategory(TestCategories.Integrated)]
        public async Task ReadOfflineParameterAsync()
        {
            await TestHelper.ExecuteAsync(CreatePWMockWithDefaultDevices(), context =>
            {
                context.Client.Browse(context.DeviceSetNodeId, out var refs);
                var nodeId = context.GetNodeIdByDisplayName(refs, OPTICAL_SENSOR_DEVICENAME);
                context.Client.Browse(nodeId, out var deviceRefs);

                var offlineParameterNodeId = context.GetNodeIdByDisplayName(deviceRefs, Opc.Ua.Di.BrowseNames.ParameterSet);

                context.Client.Browse(offlineParameterNodeId, out var parameterRefs);

                var variableNodeId = context.GetNodeIdByDisplayName(parameterRefs, "V_Align");
                var result = context.Client.ReadVariable(variableNodeId);

                Assert.AreEqual((UInt32)17, result);
            });
        }

        [TestMethod, TestCategory(TestCategories.Integrated)]
        public async Task ReadOnlineParameterAsync()
        {
            await TestHelper.ExecuteAsync(CreatePWMockWithDefaultDevices(), context =>
            {
                context.Client.Browse(context.DeviceSetNodeId, out var refs);
                var nodeId = context.GetNodeIdByDisplayName(refs, OPTICAL_SENSOR_DEVICENAME);
                context.Client.Browse(nodeId, out var offlineDeviceRefs);

                var onlineNodeId = context.GetNodeIdByDisplayName(offlineDeviceRefs, "Online");

                context.Client.Browse(onlineNodeId, out var onlineDeviceRefs);

                var onlineParameterNodeId = context.GetNodeIdByDisplayName(onlineDeviceRefs, Opc.Ua.Di.BrowseNames.ParameterSet);

                context.Client.Browse(onlineParameterNodeId, out var parameterRefs);

                var variableNodeId = context.GetNodeIdByDisplayName(parameterRefs, "V_Align");
                var result = context.Client.ReadVariable(variableNodeId);

                Assert.AreEqual((UInt32)17, result);
            });
        }

        [TestMethod, TestCategory(TestCategories.Integrated)]
        public async Task WriteNonWritableOfflineParameterAsync()
        {
            await TestHelper.ExecuteAsync(CreatePWMockWithDefaultDevices(), context =>
            {
                context.Client.Browse(context.DeviceSetNodeId, out var refs);
                var nodeId = context.GetNodeIdByDisplayName(refs, OPTICAL_SENSOR_DEVICENAME);
                context.Client.Browse(nodeId, out var deviceRefs);

                var offlineParameterNodeId = context.GetNodeIdByDisplayName(deviceRefs, Opc.Ua.Di.BrowseNames.ParameterSet);

                context.Client.Browse(offlineParameterNodeId, out var parameterRefs);

                var variableNodeId = context.GetNodeIdByDisplayName(parameterRefs, "V_Align");

                var result = context.Client.WriteVariable(variableNodeId, 18);

                Assert.AreEqual(StatusCodes.BadNotWritable, result.Code);
            });
        }

        [TestMethod, TestCategory(TestCategories.Integrated)]
        public async Task WriteOfflineParameterAsync()
        {
            await TestHelper.ExecuteAsync(CreatePWMockWithDefaultDevices(), context =>
            {
                context.Client.Browse(context.DeviceSetNodeId, out var refs);
                var nodeId = context.GetNodeIdByDisplayName(refs, OPTICAL_SENSOR_DEVICENAME);
                context.Client.Browse(nodeId, out var deviceRefs);

                var offlineParameterNodeId = context.GetNodeIdByDisplayName(deviceRefs, Opc.Ua.Di.BrowseNames.ParameterSet);

                context.Client.Browse(offlineParameterNodeId, out var parameterRefs);

                var variableNodeId = context.GetNodeIdByDisplayName(parameterRefs, "V_BDC1_SP_1");

                var result = context.Client.WriteVariable(variableNodeId, 18);

                Assert.IsTrue(StatusCode.IsNotBad(result));
            });
        }

        [TestMethod, TestCategory(TestCategories.Integrated)]
        public async Task WriteNonWriteableOnlineParameterAsync()
        {
            await TestHelper.ExecuteAsync(CreatePWMockWithDefaultDevices(), context =>
            {
                context.Client.Browse(context.DeviceSetNodeId, out var refs);
                var nodeId = context.GetNodeIdByDisplayName(refs, OPTICAL_SENSOR_DEVICENAME);
                context.Client.Browse(nodeId, out var offlineDeviceRefs);

                var onlineNodeId = context.GetNodeIdByDisplayName(offlineDeviceRefs, "Online");

                context.Client.Browse(onlineNodeId, out var onlineDeviceRefs);

                var offlineParameterNodeId = context.GetNodeIdByDisplayName(onlineDeviceRefs, Opc.Ua.Di.BrowseNames.ParameterSet);

                context.Client.Browse(offlineParameterNodeId, out var parameterRefs);

                var variableNodeId = context.GetNodeIdByDisplayName(parameterRefs, "V_Align");
                var result = context.Client.WriteVariable(variableNodeId, 18);

                Assert.AreEqual(StatusCodes.BadNotWritable, result.Code);
            });
        }

        [TestMethod, TestCategory(TestCategories.Integrated)]
        public async Task WriteOnlineParameterAsync()
        {
            await TestHelper.ExecuteAsync(CreatePWMockWithDefaultDevices(), context =>
            {
                context.Client.Browse(context.DeviceSetNodeId, out var refs);
                var nodeId = context.GetNodeIdByDisplayName(refs, OPTICAL_SENSOR_DEVICENAME);
                context.Client.Browse(nodeId, out var offlineDeviceRefs);

                var onlineNodeId = context.GetNodeIdByDisplayName(offlineDeviceRefs, "Online");

                context.Client.Browse(onlineNodeId, out var onlineDeviceRefs);

                var offlineParameterNodeId = context.GetNodeIdByDisplayName(onlineDeviceRefs, Opc.Ua.Di.BrowseNames.ParameterSet);

                context.Client.Browse(offlineParameterNodeId, out var parameterRefs);

                var variableNodeId = context.GetNodeIdByDisplayName(parameterRefs, "V_BDC1_SP_1");
                var result = context.Client.WriteVariable(variableNodeId, 18);

                Assert.IsTrue(StatusCode.IsNotBad(result));
            });
        }

        [TestMethod, TestCategory(TestCategories.Integrated)]
        public async Task GetIOProcessParameterAsync()
        {
            await TestHelper.ExecuteAsync(CreatePWMockWithDefaultDevices(true), context =>
            {
                context.Client.Browse(context.DeviceSetNodeId, out var refs);
                var nodeId = context.GetNodeIdByDisplayName(refs, OPTICAL_SENSOR_DEVICENAME);
                context.Client.Browse(nodeId, out var offlineDeviceRefs);

                var onlineNodeId = context.GetNodeIdByDisplayName(offlineDeviceRefs, "Online");

                context.Client.Browse(onlineNodeId, out var onlineDeviceRefs);

                var onlineParameterNodeId = context.GetNodeIdByDisplayName(onlineDeviceRefs, Opc.Ua.Di.BrowseNames.ParameterSet);

                context.Client.Browse(onlineParameterNodeId, out var parameterRefs);

                Assert.AreEqual(25, parameterRefs.Count);
            });
        }

        [TestMethod, TestCategory(TestCategories.Integrated)]
        public async Task ReadIOProcessParameterAsync()
        {
            await TestHelper.ExecuteAsync(CreatePWMockWithDefaultDevices(true, true), context =>
            {
                context.Client.Browse(context.DeviceSetNodeId, out var refs);
                var nodeId = context.GetNodeIdByDisplayName(refs, OPTICAL_SENSOR_DEVICENAME);
                context.Client.Browse(nodeId, out var offlineDeviceRefs);

                var onlineNodeId = context.GetNodeIdByDisplayName(offlineDeviceRefs, "Online");

                context.Client.Browse(onlineNodeId, out var onlineDeviceRefs);

                var onlineParameterNodeId = context.GetNodeIdByDisplayName(onlineDeviceRefs, Opc.Ua.Di.BrowseNames.ParameterSet);

                context.Client.Browse(onlineParameterNodeId, out var parameterRefs);

                var variableNodeId = context.GetNodeIdByDisplayName(parameterRefs, "TN_PDV1");
                var result = context.Client.ReadVariable(variableNodeId);

                Assert.AreEqual(21, result);
            });
        }

        private void AssertIsObjectAvailable(ExpandedNodeId expandedNodeId, TestContext context)
        {
            var deviceSetNodeId = expandedNodeId.ToNodeId(context.Server.CurrentInstance.NamespaceUris);
            var deviceSetNode = context.Client.ReadNode(deviceSetNodeId);

            Assert.IsNotNull(deviceSetNode);
        }
    }
}
