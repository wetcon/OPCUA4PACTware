// Copyright (c) 2019-2023 wetcon gmbh. All rights reserved.
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

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opc.Ua;
using Wetcon.PactwarePlugin.OpcUaServer.OpcUa.Models;

namespace Wetcon.PactwarePlugin.OpcUaServer.Plugin.Tests
{
    [TestClass]
    public class OfflineDeviceModelTests
    {
        private const string NodeIdText = "a";

        [TestMethod]
        public void KeepsUniqueId()
        {
            var nodeId = new NodeId(NodeIdText);
            var existingNodes = new List<NodeId>();

            var result = OfflineDeviceModel.MakeUniqueNodeId(nodeId, existingNodes);

            Assert.AreEqual(new NodeId(NodeIdText), result);
        }

        [TestMethod]
        public void CreatesUniqueId()
        {
            var nodeId = new NodeId(NodeIdText);
            var existingNodes = new List<NodeId> { nodeId };

            var result = OfflineDeviceModel.MakeUniqueNodeId(nodeId, existingNodes);

            Assert.AreEqual(new NodeId($"{NodeIdText}.1"), result);
        }

        [TestMethod]
        public void CreatesUniqueIdKeepsNamespaceIndex()
        {
            var nodeId = new NodeId(NodeIdText, 7);
            var existingNodes = new List<NodeId> { nodeId };

            var result = OfflineDeviceModel.MakeUniqueNodeId(nodeId, existingNodes);

            Assert.AreEqual(new NodeId($"{NodeIdText}.1", 7), result);
        }

        [TestMethod]
        public void CreatesUniqueIdMultipleExisting()
        {
            var nodeId = new NodeId(NodeIdText);
            var existingNodes = new List<NodeId>
            {
                nodeId,
                new NodeId($"{NodeIdText}.1"),
                new NodeId($"{NodeIdText}.2")
            };

            var result = OfflineDeviceModel.MakeUniqueNodeId(nodeId, existingNodes);

            Assert.AreEqual(new NodeId($"{NodeIdText}.3"), result);
        }
    }
}
