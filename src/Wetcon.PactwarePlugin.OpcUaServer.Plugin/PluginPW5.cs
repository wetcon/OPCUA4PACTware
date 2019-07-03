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
using System.Collections.ObjectModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using PWID.Classes;
using PWID.Enumerations;
using PWID.EventArgs;
using PWID.Interfaces;
using PWUtil5;
using Wetcon.PactwarePlugin.OpcUaServer.Infrastructure;
using Wetcon.PactwarePlugin.OpcUaServer.UserControls;

namespace Wetcon.PactwarePlugin.OpcUaServer
{
    /// <summary>
    /// Represents the OPC UA Server plugin for PACTware 5.
    /// </summary>
    public class PluginPW5 : clsPWBase, IPACTwareControlInformation, IPACTwareAddinKernel
    {

#pragma warning disable 67 // Unused member

        private event EventHandler<PACTwareEventMenuChangedArgs> _menuChangedEvent;

#pragma warning restore

        private CultureInfo _pactwareUiCulture;
        private IPACTwareUIKernel _pactwareUiKernel;
        private static readonly ILog s_log = LogManager.GetLogger(typeof(PluginPW5));
        private static readonly ILog s_opcLog = LogManager.GetLogger(typeof(OpcUaServer));
        private IPluginSettings _pluginSettings;
        private OpcUaApplicationManager _opcUaApplicationManager;

        /// <summary>
        /// Gets the type of the object.
        /// </summary>
        protected override PACTwareEnumObjectTyp IPACTwareDescriptor_ObjectTyp => PACTwareEnumObjectTyp.ID_PWADDIN;

        /// <summary>
        /// Gets the UUID of the plugin.
        /// </summary>
        protected override string IPACTwareDescriptor_id => _pluginSettings.PluginDescriptorId;

        /// <summary>
        /// Gets the description/label of the plugin in the AddIns-Manager.
        /// </summary>
        protected override string IPACTwareInfomation_Description => _pluginSettings.PluginDescription;

        /// <summary>
        /// Gets the name of the plugin.
        /// </summary>
        protected override string IPACTwareInfomation_Name => _pluginSettings.PluginName;

        public string Name => IPACTwareInfomation_Name;

        /// <summary>
        /// Gets the owner of the plugin.
        /// </summary>
        protected override string IPACTwareInfomation_Company => _pluginSettings.PluginManufacturerName;

        /// <summary>
        /// Gets the company/manufacturer logo.
        /// </summary>
        protected override Icon IPACTwareInfomation_CompanyIcon => _pluginSettings.PluginManufacturerIcon;

        /// <summary>
        /// The version of the plugin.
        /// </summary>
        protected override string IPACTwareDescriptor_version => typeof(PluginPW5).Assembly.GetName().Version.ToString(3);


        #region IPACTwareAddinKernel

        /// <summary>
        /// Gets the current culture identifier.
        /// </summary>
        int IPACTwareAddinKernel.Language => _pactwareUiCulture.LCID;

        /// <summary>
        /// Gets the type of the plugin.
        /// </summary>
        PACTwareEnumAddinTyp IPACTwareAddinKernel.AddinTyp => PACTwareEnumAddinTyp.ID_ADDIN_GENERAL;

        /// <summary>
        /// The event which is raised when the menu has changed.
        /// </summary>
        event EventHandler<PACTwareEventMenuChangedArgs> IPACTwareAddinKernel.MenuChangedEvent
        {
            add => _menuChangedEvent += value;
            remove => _menuChangedEvent -= value;
        }

        /// <summary>
        /// Creates the menu entries for the plugin. Gets called, when the menu is opened.
        /// The menu items are identified by their menu ids and handled by function "<see cref="IPACTwareAddinKernel.BeginStartApplication"/>".
        /// </summary>
        /// <param name="type"></param>
        /// <param name="node"></param>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        IAsyncResult IPACTwareAddinKernel.BeginGetMenu(PACTwareEnumMenuTyp type, IPACTwareProjectNode node, AsyncCallback callback, object state)
        {
            //No additional menu entry is needed so return null
            return new CompletedAsyncResult<ReadOnlyCollection<PACTwareMenuItem>>(null);
        }

        /// <summary>
        /// Gets the result data from "<see cref="IPACTwareAddinKernel.BeginGetMenu"/>".
        /// </summary>
        /// <param name="asyncResult"></param>
        /// <returns></returns>
        ReadOnlyCollection<PACTwareMenuItem> IPACTwareAddinKernel.EndGetMenu(IAsyncResult asyncResult)
        {
            return ((CompletedAsyncResult<ReadOnlyCollection<PACTwareMenuItem>>)asyncResult).Data;
        }

        /// <summary>
        /// Method called when the plugin is loaded.
        /// </summary>
        /// <param name="kernel"></param>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        IAsyncResult IPACTwareAddinKernel.BeginInitialise(IPACTwareUIKernel kernel, AsyncCallback callback,
            object state)
        {
            return InitializePluginAsync(kernel).AsAsyncResult(callback, state);
        }

        /// <summary>
        /// Gets the result data from "<see cref="IPACTwareAddinKernel.BeginInitialise"/>".
        /// </summary>
        /// <param name="asyncResult"></param>
        /// <returns></returns>
        bool IPACTwareAddinKernel.EndInitialise(IAsyncResult asyncResult)
        {
            return ((Task<bool>)asyncResult).Result;
        }

        /// <summary>
        /// Method called when the plugin is unloaded.
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        IAsyncResult IPACTwareAddinKernel.BeginUnload(AsyncCallback callback, object state)
        {
            return UnloadPluginAsync().AsAsyncResult(callback, state);
        }

        /// <summary>
        /// Gets the result data from "<see cref="IPACTwareAddinKernel.BeginUnload"/>".
        /// </summary>
        /// <param name="asyncResult"></param>
        /// <returns></returns>
        bool IPACTwareAddinKernel.EndUnload(IAsyncResult asyncResult)
        {
            return ((Task<bool>)asyncResult).Result;
        }

        /// <summary>
        /// Sets the current UI culture.
        /// </summary>
        /// <param name="languageId"></param>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        IAsyncResult IPACTwareAddinKernel.BeginSetLanguage(int languageId, AsyncCallback callback, object state)
        {
            return SetPluginLanguageAsync(languageId).AsAsyncResult(callback, state);
        }

        /// <summary>
        /// Gets the result data from "<see cref="IPACTwareAddinKernel.BeginSetLanguage"/>".
        /// </summary>
        /// <param name="asyncResult"></param>
        /// <returns></returns>
        bool IPACTwareAddinKernel.EndSetLanguage(IAsyncResult asyncResult)
        {
            return ((Task<bool>)asyncResult).Result;
        }

        /// <summary>
        /// Gets called when no UI is started
        /// </summary>
        /// <param name="type"></param>
        /// <param name="typeInfo"></param>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        IAsyncResult IPACTwareAddinKernel.BeginStartApplication(PACTwareEnumUserinterfaceType type, string typeInfo, AsyncCallback callback, object state)
        {
            return new CompletedAsyncResult<string>(true.ToString());
        }

        /// <summary>
        /// Gets the result data from "<see cref="IPACTwareAddinKernel.BeginStartApplication"/>".
        /// </summary>
        /// <param name="asyncResult"></param>
        /// <returns></returns>
        string IPACTwareAddinKernel.EndStartApplication(IAsyncResult asyncResult)
        {
            return ((CompletedAsyncResult<string>)asyncResult).Data;
        }

        /// <summary>
        /// Terminate the application if it was started by "<see cref="IPACTwareAddinKernel.BeginStartApplication"/>".
        /// </summary>
        /// <param name="refId"></param>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        IAsyncResult IPACTwareAddinKernel.BeginTerminateApplication(string refId, AsyncCallback callback, object state)
        {
            //Release resources etc.
            return new CompletedAsyncResult<bool>(true);
        }

        /// <summary>
        /// Gets the result data from "<see cref="IPACTwareAddinKernel.BeginTerminateApplication"/>".
        /// </summary>
        /// <param name="asyncResult"></param>
        /// <returns></returns>
        bool IPACTwareAddinKernel.EndTerminateApplication(IAsyncResult asyncResult)
        {
            return ((CompletedAsyncResult<bool>)asyncResult).Data;
        }

        #endregion


        #region IPACTwareControlInformation

        /// <summary>
        /// Specifies which UI to open depending on the "<paramref name="type"/>".
        /// </summary>
        /// <param name="type">The type of the user interface.</param>
        /// <param name="typeInfo">Additional info.</param>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <returns>The control to open.</returns>
        IAsyncResult IPACTwareControlInformation.BeginGetUserInterfaceInfo(PACTwareEnumUserinterfaceType type, string typeInfo, AsyncCallback callback, object state)
        {
            PACTwareUserInterfaceInformation pactWareUserInterfaceInformation = null;

            switch (type)
            {
                case PACTwareEnumUserinterfaceType.PW_FRM_ABOUT:
                    // Show info dialog if user clicks on info in Add-In manager
                    pactWareUserInterfaceInformation = new PACTwareUserInterfaceInformation(typeof(AboutUserControl).FullName);
                    break;
                case PACTwareEnumUserinterfaceType.PW_FRM_OPTIONS:
                    pactWareUserInterfaceInformation = new PACTwareUserInterfaceInformation(typeof(OptionsUserControl).FullName);
                    break;
            }

            return new CompletedAsyncResult<PACTwareUserInterfaceInformation>(pactWareUserInterfaceInformation);
        }

        /// <summary>
        /// Gets the result data from "<see cref="IPACTwareControlInformation.BeginGetUserInterfaceInfo"/>".
        /// </summary>
        /// <param name="asyncResult"></param>
        /// <returns></returns>
        PACTwareUserInterfaceInformation IPACTwareControlInformation.EndGetUserInterfaceInfo(IAsyncResult asyncResult)
        {
            return ((CompletedAsyncResult<PACTwareUserInterfaceInformation>)asyncResult).Data;
        }

        #endregion

        /// <summary>
        /// Initializes the plugin.
        /// </summary>
        /// <param name="pactwareUiKernel"></param>
        /// <returns></returns>
        private async Task<bool> InitializePluginAsync(IPACTwareUIKernel pactwareUiKernel)
        {
            try
            {
                _pactwareUiCulture = new CultureInfo("en-us");
                _pluginSettings = PluginSettings.LoadSettings();
                ConfigureLogging();
                s_log.Info("InitializePluginAsync. Plugin version: " + IPACTwareDescriptor_version);
                _opcUaApplicationManager = new OpcUaApplicationManager(pactwareUiKernel, _pluginSettings);
                _pactwareUiKernel = pactwareUiKernel;

                var serverStarted = await _opcUaApplicationManager.StartApplicationAsync();

                return serverStarted;
            }
            catch (Exception ex)
            {
                s_log.Exception(ex);
                await Task.Factory.FromAsync(
                    _pactwareUiKernel.BeginShowMessageBox(
                        clsGuid.GetGuid(),
                        this,
                        ex.ToString(),
                        "OpcUaServer PACTware Plugin",
                        PACTwareEnumMessageTypes.ID_MSG_CRITICAL,
                        null,
                        null),
                    _pactwareUiKernel.EndShowMessageBox);
                return false;
            }
        }

        /// <summary>
        /// Unloads the plugin.
        /// </summary>
        /// <returns></returns>
        private async Task<bool> UnloadPluginAsync()
        {
            try
            {
                var serverStopped = await _opcUaApplicationManager.StopApplicationAsync();
                Opc.Ua.Utils.Tracing.TraceEventHandler -= OpcUATraceEventHandler;

                _pactwareUiKernel = null;

                return serverStopped;
            }
            catch (Exception ex)
            {
                s_log.Exception(ex);
                return false;
            }
        }

        /// <summary>
        /// Sets the language used by the plugin.
        /// </summary>
        /// <param name="languageId">Language Id.</param>
        /// <returns></returns>
        private async Task<bool> SetPluginLanguageAsync(int languageId)
        {
            try
            {
                _pactwareUiCulture = new CultureInfo(languageId, true);
                Thread.CurrentThread.CurrentUICulture = _pactwareUiCulture;
            }
            catch (Exception exception)
            {
                s_log.Exception(exception);
                return false;
            }

            await Task.CompletedTask;
            return true;
        }

        /// <summary>
        /// Configures log4net and opc ua logging.
        /// </summary>
        private void ConfigureLogging()
        {
            var log4NetConfigFilePath = _pluginSettings.PluginFilePath + ".config";
            XmlConfigurator.ConfigureAndWatch(new FileInfo(log4NetConfigFilePath));

            // redirect all internal OPC UA logging to log4net
            Opc.Ua.Utils.Tracing.TraceEventHandler += OpcUATraceEventHandler;
        }

        private void OpcUATraceEventHandler(object sender, Opc.Ua.TraceEventArgs e)
        {
            var message = string.Format(e.Format, e.Arguments ?? new object[0]);

            if ((e.TraceMask & Opc.Ua.Utils.TraceMasks.Error) != 0)
            {
                s_opcLog.Error(message, e.Exception);
            }
            else if ((e.TraceMask & Opc.Ua.Utils.TraceMasks.Information) != 0)
            {
                s_opcLog.Info(message);
            }
            else
            {
                s_opcLog.Debug(message);
            }
        }
    }
}
