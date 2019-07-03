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

using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace Wetcon.PactwarePlugin.OpcUaServer
{
    /// <summary>
    /// Plugin settings interface.
    /// </summary>
    public interface IPluginSettings
    {
        /// <summary>
        /// Full path of the plugin DLL.
        /// </summary>
        string PluginFilePath { get; }

        /// <summary>
        /// Plugin descriptor Id used by PACTware.
        /// </summary>
        string PluginDescriptorId { get; }

        /// <summary>
        /// Plugin name.
        /// </summary>
        string PluginName { get; }

        /// <summary>
        /// Plugin description.
        /// </summary>
        string PluginDescription { get; }

        /// <summary>
        /// Plugin manufacturer name.
        /// </summary>
        string PluginManufacturerName { get; }

        /// <summary>
        /// Plugin manufacturer url.
        /// </summary>
        string PluginManufacturerUrl { get; }

        /// <summary>
        /// Flag to control whether IO process data is added to device parameter.
        /// </summary>
        bool PluginReadIOProcessData { get; }

        /// <summary>
        /// Plugin manufacturer icon.
        /// </summary>
        Icon PluginManufacturerIcon { get; }

        /// <summary>
        /// Config file for OPC UA
        /// </summary>
        string OpcUaConfigFilePath { get; }
    }

    /// <summary>
    /// Plugin settings.
    /// </summary>
    public class PluginSettings : IPluginSettings
    {
        public PluginSettings(string pluginFilePath,
            string pluginDescriptorId, string pluginName, string pluginDescription, string pluginManufacturerName,
            string pluginManufacturerUrl, Icon pluginManufacturerIcon, string opcUaConfigFilePath,
            bool pluginReadIOProcessData)
        {
            PluginFilePath = pluginFilePath;
            PluginDescriptorId = pluginDescriptorId;
            PluginName = pluginName;
            PluginManufacturerName = pluginManufacturerName;
            PluginManufacturerUrl = pluginManufacturerUrl;
            PluginDescription = pluginDescription;
            PluginManufacturerIcon = pluginManufacturerIcon;
            OpcUaConfigFilePath = opcUaConfigFilePath;
            PluginReadIOProcessData = pluginReadIOProcessData;
        }

        /// <inheritdoc/>
        public string PluginFilePath { get; }

        /// <inheritdoc/>
        public string PluginDescriptorId { get; }

        /// <inheritdoc/>
        public string PluginName { get; }

        /// <inheritdoc/>
        public string PluginManufacturerName { get; }

        /// <inheritdoc/>
        public string PluginDescription { get; }

        /// <inheritdoc/>
        public Icon PluginManufacturerIcon { get; }

        /// <inheritdoc/>
        public string OpcUaConfigFilePath { get; }

        /// <inheritdoc/>
        public string PluginManufacturerUrl { get; }

        /// <inheritdoc/>        
        public bool PluginReadIOProcessData { get; }

        /// <summary>
        /// Loads plugin settings.
        /// </summary>
        /// <returns></returns>
        public static IPluginSettings LoadSettings()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var pluginFileInfo = new FileInfo(assembly.CodeBase.Replace("file:///", string.Empty));
            var pluginFolderPath = pluginFileInfo.DirectoryName;
            Debug.Assert(pluginFolderPath != null);
            var pluginResourcesPath = Path.Combine(pluginFolderPath, "Resources");
            var pluginDescriptorId = "{2487DD09-1566-4CF9-A604-6AD3148B3858}"; //UUID only valid for PACTware 5.X

            var pluginConfig = ConfigurationManager.OpenExeConfiguration(pluginFileInfo.FullName);
            var pluginName = pluginConfig.AppSettings.Settings["PluginName"].Value;
            var pluginDescription = pluginConfig.AppSettings.Settings["PluginDescription"].Value;
            var pluginManufacturerName = pluginConfig.AppSettings.Settings["PluginManufacturerName"].Value;
            var pluginManufacturerUrl = pluginConfig.AppSettings.Settings["PluginManufacturerUrl"].Value;
            var pluginReadIOProcessDataString = pluginConfig.AppSettings.Settings["PluginReadIOProcessData"].Value;
            var pluginManufacturerIcon = new Icon(Path.Combine(pluginResourcesPath, "wetconIcon.ico"));
            var opcUaConfigFilePath = Path.Combine(pluginFolderPath, "WetconOpcUaServer.Config.xml");

            var pluginReadIOProcessData = false;
            if (bool.TryParse(pluginReadIOProcessDataString, out var parsedBool))
            {
                pluginReadIOProcessData = parsedBool;
            }

            return new PluginSettings(pluginFileInfo.FullName, pluginDescriptorId, pluginName, pluginDescription,
                pluginManufacturerName, pluginManufacturerUrl, pluginManufacturerIcon, opcUaConfigFilePath,
                pluginReadIOProcessData);
        }
    }
}
