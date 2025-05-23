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

using System.IO;
using System.Reflection;
using Opc.Ua;
using Opc.Ua.Server;
using PWID.Interfaces;

namespace Wetcon.PactwarePlugin.OpcUaServer
{
    public delegate void ServerStartedEventHandler(IServerInternal server);

    public class OpcUaServer : StandardServer
    {
        public event ServerStartedEventHandler ServerStartedEventHandler;
        private readonly IPACTwareUIKernel _pactwareUIKernel;
        private readonly IPluginSettings _pluginSettings;

        public OpcUaServer(IPACTwareUIKernel pactwareUIKernel, IPluginSettings pluginSettings)
        {
            _pactwareUIKernel = pactwareUIKernel;
            _pluginSettings = pluginSettings;
        }

        /// <summary>
        /// Called after the server has been started.
        /// </summary>
        protected override void OnServerStarted(IServerInternal server)
        {
            base.OnServerStarted(server);
            ServerStartedEventHandler?.Invoke(server);
        }

        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        {
            var nodeManagers = new INodeManager[]
            {
                new OpcUaNodeManager(server, configuration, _pactwareUIKernel, _pluginSettings)
            };

            return new MasterNodeManager(server, configuration, null, nodeManagers);
        }

        protected override ServerProperties LoadServerProperties()
        {
            var assembly = Assembly.GetAssembly(GetType());
            var assemblyVersion = assembly.GetName().Version.ToString();
            var assemblyDate = File.GetLastWriteTimeUtc(assembly.Location);

            var properties = new ServerProperties
            {
                ManufacturerName = _pluginSettings.PluginManufacturerName,
                ProductName = _pluginSettings.PluginName,
                ProductUri = _pluginSettings.PluginManufacturerUrl,
                SoftwareVersion = Utils.GetAssemblySoftwareVersion(),
                BuildNumber = assemblyVersion,
                BuildDate = assemblyDate
            };

            return properties;
        }
    }
}
