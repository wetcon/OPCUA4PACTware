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

using System;
using System.Threading.Tasks;
using log4net;
using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;
using PWID.Interfaces;

namespace Wetcon.PactwarePlugin.OpcUaServer
{
    /// <summary>
    /// OpcUa Application Manager.
    /// </summary>
    public class OpcUaApplicationManager
    {
        public OpcUaServer Server { get; private set; }
        private readonly IPACTwareUIKernel _pactwareUIKernel;
        private readonly IPluginSettings _pluginSettings;
        private ApplicationInstance _applicationInstance;
        private readonly TaskCompletionSource<Task> _appRunningCompletionSource = new TaskCompletionSource<Task>();
        private static readonly bool s_autoAcceptCertificate = true;
        private static readonly ILog s_opcLog = LogManager.GetLogger(typeof(OpcUaApplicationManager));

        /// <summary>
        /// Initializes a new instance of <see cref="OpcUaApplicationManager"/>
        /// </summary>
        public OpcUaApplicationManager(IPACTwareUIKernel pactwareUIKernel, IPluginSettings pluginSettings)
        {
            _pactwareUIKernel = pactwareUIKernel;
            _pluginSettings = pluginSettings;
        }

        /// <summary>
        /// Starts the OpcUa application.
        /// </summary>
        /// <returns></returns>
        public async Task<bool> StartApplicationAsync()
        {
            if (_applicationInstance != null)
            {
                // Application already started.
                return true;
            }

            try
            {
                var telemetry = DefaultTelemetry.Create(x => { });

                var application = new ApplicationInstance(telemetry)
                {
                    ApplicationName = _pluginSettings.PluginName,
                    ApplicationType = ApplicationType.Server
                };

                // load the application configuration.
                var config = await application.LoadApplicationConfigurationAsync(_pluginSettings.OpcUaConfigFilePath, false);
                var applicationSettings = Properties.Settings.Default;

                if (string.IsNullOrEmpty(applicationSettings.UserOpcServerUri))
                {
                    applicationSettings.UserOpcServerUri = config.ServerConfiguration.BaseAddresses[0];
                    applicationSettings.Save();
                }
                else
                {
                    config.ServerConfiguration.BaseAddresses[0] = applicationSettings.UserOpcServerUri;
                }

                // check the application certificate.
                var hasAppCertificate = await application.CheckApplicationInstanceCertificatesAsync(true, 0);
                if (!hasAppCertificate)
                {
                    throw new Exception("Application instance certificate invalid!");
                }

                if (!config.SecurityConfiguration.AutoAcceptUntrustedCertificates)
                {
                    config.CertificateValidator.CertificateValidation += CertificateValidator_CertificateValidation;
                }

                // start the server.
                Server = new OpcUaServer(_pactwareUIKernel, _pluginSettings);
                Server.ServerStartedEventHandler += OnServerStarted;

                await application.StartAsync(Server);
            }
            catch (Exception ex)
            {
                s_opcLog.Error("Error starting server.", ex);
                _appRunningCompletionSource.SetException(ex);

                return false;
            }

            // Wait until the server is running.
            await _appRunningCompletionSource.Task;
            return true;
        }

        /// <summary>
        /// Stops the OpcUa application.
        /// </summary>
        /// <returns></returns>
        public async Task<bool> StopApplicationAsync()
        {
            try
            {
                if (Server != null && Server.CurrentInstance.CurrentState == ServerState.Running)
                {
                    await Server.StopAsync();
                }

                Server?.Dispose();
                _applicationInstance = null;
                Server = null;
            }
            catch (Exception ex)
            {
                s_opcLog.Error("Error stopping server.", ex);
                return false;
            }

            await Task.CompletedTask;
            return true;
        }

        /// <summary>
        /// Method called when the OpcUa application is running.
        /// </summary>
        /// <param name="serverInternal">IServerInternal</param>
        private void OnServerStarted(IServerInternal serverInternal)
        {
            _appRunningCompletionSource.SetResult(Task.CompletedTask);
            Server.ServerStartedEventHandler -= OnServerStarted;
        }

        private static void CertificateValidator_CertificateValidation(CertificateValidator validator, CertificateValidationEventArgs e)
        {
            if (e.Error.StatusCode != StatusCodes.BadCertificateUntrusted)
            {
                return;
            }

            e.Accept = s_autoAcceptCertificate;

            s_opcLog.DebugFormat(s_autoAcceptCertificate ? "Accepted Certificate: {0}" : "Rejected Certificate: {0}",
                e.Certificate.Subject);
        }
    }
}
