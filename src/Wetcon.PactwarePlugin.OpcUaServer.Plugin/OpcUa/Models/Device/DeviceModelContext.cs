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
using PWID.Interfaces;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt;

namespace Wetcon.PactwarePlugin.OpcUaServer.OpcUa.Models
{
    /// <summary>
    /// Represents the Offline Device model
    /// </summary>
    public struct DeviceModelContext
    {
        public DeviceModelContext(ushort serverNamespaceIndex, IPACTwareProjectNode projectNode,
            IFdtServiceProvider fdtServiceProvider, NodeState parent, List<NodeId> existingNodeIds = null)
        {
            ServerNamespaceIndex = serverNamespaceIndex;
            PactwareProjectNode = projectNode;
            FdtServiceProvider = fdtServiceProvider;
            Parent = parent;
            ExistingNodeIds = existingNodeIds ?? new List<NodeId>();
        }

        public ushort ServerNamespaceIndex { get; private set; }
        public IPACTwareProjectNode PactwareProjectNode { get; private set; }
        public IFdtServiceProvider FdtServiceProvider { get; private set; }
        public NodeState Parent { get; private set; }
        public List<NodeId> ExistingNodeIds { get; private set; }

        public DeviceModelContext WithNewParent(NodeState parent)
        {
            return new DeviceModelContext
            {
                ServerNamespaceIndex = ServerNamespaceIndex,
                PactwareProjectNode = PactwareProjectNode,
                FdtServiceProvider = FdtServiceProvider,
                Parent = parent,
                ExistingNodeIds = ExistingNodeIds
            };
        }
    }
}
