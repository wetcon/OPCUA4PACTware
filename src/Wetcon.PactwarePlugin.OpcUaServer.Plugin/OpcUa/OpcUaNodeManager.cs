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
using System.Linq;
using System.Reflection;
using log4net;
using Opc.Ua;
using Opc.Ua.Server;
using PWID.EventArgs;
using PWID.Interfaces;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt;
using Wetcon.PactwarePlugin.OpcUaServer.Infrastructure;
using Wetcon.PactwarePlugin.OpcUaServer.OpcUa.Models;

namespace Wetcon.PactwarePlugin.OpcUaServer
{

    public class OpcUaNodeManager : CustomNodeManager2
    {
        public ushort DiNamespaceIndex { get; }
        public ushort ServerNamespaceIndex { get; }
        private NodeState DeviceSetNode { get; set; }
        private static readonly ILog s_log = LogManager.GetLogger(typeof(OpcUaNodeManager));
        private uint _nodeIdCounter;
        private readonly IPACTwareUIKernel _pactwareUIKernel;
        private readonly IPluginSettings _pluginSettings;

        /// <summary>
        /// Initializes the node manager.
        /// </summary>
        public OpcUaNodeManager(IServerInternal server, ApplicationConfiguration configuration,
            IPACTwareUIKernel pactwareUIKernel, IPluginSettings pluginSettings)
            : base(server, configuration, Opc.Ua.Di.Namespaces.OpcUaDi, Constants.ServerNamespaceUri)
        {
            s_log.Info("Creating OpcUaNodeManager...");
            DiNamespaceIndex = (ushort)Server.NamespaceUris.GetIndex(Opc.Ua.Di.Namespaces.OpcUaDi);
            ServerNamespaceIndex = (ushort)Server.NamespaceUris.GetIndex(Constants.ServerNamespaceUri);
            _pactwareUIKernel = pactwareUIKernel;
            _pluginSettings = pluginSettings;
        }

        /// <summary>
        /// Assigns Ids to nodes for the server.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        public override NodeId New(ISystemContext context, NodeState node)
        {
            if (node is BaseDeviceModel ||
                node is BaseParameterModel)
            {
                return node.NodeId;
            }

            return new NodeId(++_nodeIdCounter, ServerNamespaceIndex);
        }

        public override void Browse(OperationContext context, ref ContinuationPoint continuationPoint, IList<ReferenceDescription> references)
        {
            if (continuationPoint.NodeToBrowse is NodeHandle nodeHandle)
            {
                var nodeToBrowseInst = Find(nodeHandle.NodeId);
                if (nodeToBrowseInst != null)
                {
                    ParameterSetModel parameterSet = null;

                    switch (nodeToBrowseInst)
                    {
                        // if a device parameter id is read without the device parameters being initialized,
                        // a browse on the device is triggered. load the parameters in this case only if they
                        // are empty.
                        case BaseDeviceModel deviceModel:
                            parameterSet = (ParameterSetModel)deviceModel.ParameterSet;
                            if (parameterSet.Parameters.Count > 0)
                            {
                                parameterSet = null;
                            }
                            break;
                        case ParameterSetModel parameterSetInstance:
                            parameterSet = parameterSetInstance;
                            break;
                    }

                    if (parameterSet != null)
                    {
                        lock (Lock)
                        {
                            var existingParameterIds = parameterSet.Parameters
                                .Select(p => p.NodeId)
                                .ToList();

                            parameterSet.ReloadParameters();

                            var obsoleteNodes = existingParameterIds
                                .Where(p => parameterSet.Parameters.All(n => n.NodeId != p))
                                .ToList();

                            obsoleteNodes.ForEach(p => DeleteNode(SystemContext, p));

                            var newNodes = parameterSet.Parameters
                                .Where(p => !existingParameterIds.Contains(p.NodeId))
                                .ToList();

                            newNodes.ForEach(p => AddPredefinedNode(SystemContext, p));
                        }
                    }
                }
            }

            base.Browse(context, ref continuationPoint, references);
        }

        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            s_log.Info("Loading DI Node set...");
            var assembly = Assembly.GetAssembly(typeof(OpcUaNodeManager));
            var resourceStream = assembly.GetManifestResourceStream(Constants.OpcUaDiXmlResourcePath);
            var nodeSet = Opc.Ua.Export.UANodeSet.Read(resourceStream);
            var nodes = new NodeStateCollection();

            nodeSet.Import(context, nodes);

            return nodes;
        }

        protected override void AddPredefinedNode(ISystemContext context, NodeState node)
        {
            node.Description = node.Description ?? new LocalizedText(string.Empty);
            node.RolePermissions = node.RolePermissions ?? new RolePermissionTypeCollection();
            node.UserRolePermissions = node.UserRolePermissions ?? new RolePermissionTypeCollection();

            base.AddPredefinedNode(context, node);
        }

        /// <summary>
        /// Does any initialization required before the address space can be used.
        /// </summary>
        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            base.CreateAddressSpace(externalReferences);

            var deviceSetNodeId = Opc.Ua.Di.ObjectIds.DeviceSet.ToNodeId(Server.NamespaceUris);
            DeviceSetNode = Find(deviceSetNodeId);

            if (_pactwareUIKernel?.PACTwareKernel?.Action != null)
            {
                _pactwareUIKernel.PACTwareKernel.Action.OpenProjectEvent += OnOpenProject;
                _pactwareUIKernel.PACTwareKernel.Action.NewProjectEvent += OnOpenProject;
            }

            if (_pactwareUIKernel?.PACTwareKernel?.Project != null)
            {
                _pactwareUIKernel.PACTwareKernel.Project.AddProjectNodeEvent += OnAddProjectNode;
                _pactwareUIKernel.PACTwareKernel.Project.RemoveProjectNodeEvent += OnRemoveProjectNode;
            }

            UpdateDeviceSet();
        }

        public override void DeleteAddressSpace()
        {
            UnloadDeviceSet();
            base.DeleteAddressSpace();
            if (_pactwareUIKernel?.PACTwareKernel?.Action != null)
            {
                _pactwareUIKernel.PACTwareKernel.Action.OpenProjectEvent -= OnOpenProject;
                _pactwareUIKernel.PACTwareKernel.Action.NewProjectEvent -= OnOpenProject;
            }

            if (_pactwareUIKernel?.PACTwareKernel?.Project != null)
            {
                _pactwareUIKernel.PACTwareKernel.Project.AddProjectNodeEvent -= OnAddProjectNode;
                _pactwareUIKernel.PACTwareKernel.Project.RemoveProjectNodeEvent -= OnRemoveProjectNode;
            }
        }

        private void OnRemoveProjectNode(object sender, PACTwareEventActionProjectNodeArgs e)
        {
            if (e.Success)
            {
                RemoveDeviceNodes(e.ProjectNode);
            }
        }

        private void OnAddProjectNode(object sender, PACTwareEventActionProjectNodeArgs e)
        {
            if (e.Success)
            {
                UpdateDeviceSet();
            }
        }

        private void OnOpenProject(object sender, PACTwareEventActionProjectArgs e)
        {
            if (e.Success)
            {
                UpdateDeviceSet();
            }
        }

        private void RemoveDeviceNodes(IPACTwareProjectNode projectNode)
        {
            if (_pactwareUIKernel?.PACTwareKernel?.Project == null)
            {
                return;
            }

            try
            {
                s_log.Info("Removing device nodes...");
                lock (Lock)
                {
                    var devices = _pactwareUIKernel.GetDeviceProjectNodes(projectNode);
                    var offlineNodes = FindChildNodes<BaseDeviceModel>(DeviceSetNode).ToList();
                    var nodesToDelete = offlineNodes
                        .Where(node => devices.All(d => !ReferenceEquals(d, node.PactwareProjectNode)))
                        .ToList();

                    foreach (var node in nodesToDelete)
                    {
                        node.FdtService?.OnUnloadProjectNode();
                        DeleteNode(SystemContext, node.NodeId);
                    }
                }
                s_log.Info("Finished removing device nodes...");
            }
            catch (Exception ex)
            {
                s_log.Error(nameof(RemoveDeviceNodes) + " error.", ex);
                throw;
            }
        }

        private void UpdateDeviceSet()
        {
            try
            {
                if (_pactwareUIKernel?.PACTwareKernel?.Project == null)
                {
                    return;
                }

                s_log.Info("Updating device nodes...");

                lock (Lock)
                {

                    var devices = _pactwareUIKernel.GetDeviceProjectNodes();
                    var offlineDeviceNodes = FindChildNodes<BaseDeviceModel>(DeviceSetNode).ToArray();

                    foreach (var device in devices)
                    {
                        var offlineDeviceNode = offlineDeviceNodes.FirstOrDefault(d =>
                            d.PactwareProjectNode == device);

                        if (offlineDeviceNode != null)
                        {
                            // Device node already exists.
                            continue;
                        }

                        // Add the offline and online device nodes to the DeviceSet.
                        AddDeviceToDeviceSet(device, DeviceSetNode);
                    }
                }

                s_log.Info("Finished updating device nodes...");
            }
            catch (Exception ex)
            {
                s_log.Error("UpdateDeviceSet error.", ex);
                throw;
            }
        }

        private void UnloadDeviceSet()
        {
            var deviceNodes = FindChildNodes<BaseDeviceModel>(DeviceSetNode);

            foreach (var deviceNode in deviceNodes)
            {
                deviceNode.FdtService?.OnUnloadProjectNode();
                DeleteNode(SystemContext, deviceNode.NodeId);
            }
        }

        private void AddDeviceToDeviceSet(IPACTwareProjectNode pactwareProjectNode, NodeState deviceSetNode)
        {
            var fdtServiceProvider = new FdtServiceProvider();
            fdtServiceProvider.OnLoadProjectNode(pactwareProjectNode);
            var nodeStates = OfflineDeviceModel.Add(pactwareProjectNode, fdtServiceProvider, deviceSetNode,
                SystemContext, ServerNamespaceIndex, _pluginSettings.PluginReadIOProcessData);

            foreach (var nodeState in nodeStates)
            {
                AddPredefinedNode(SystemContext, nodeState);
            }
        }

        private IEnumerable<T> FindChildNodes<T>(NodeState parentNode, bool recursive = false) where T : class
        {
            var children = new List<BaseInstanceState>();
            parentNode.GetChildren(SystemContext, children);

            foreach (var child in children)
            {
                if (recursive)
                {
                    foreach (var childChild in FindChildNodes<T>(child, true))
                    {
                        yield return childChild;
                    }
                }

                if ((object)child is T casted)
                {
                    yield return casted;
                }
            }
        }
    }
}
