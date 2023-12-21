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

using System;
using System.Threading.Tasks;
using PWID.Interfaces;

namespace Wetcon.PactwarePlugin.OpcUaServer.Plugin.Tests
{
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

            await Task.Run(appManager.StartApplicationAsync);            

            using (var client = new OpcUaClient.Base.OpcUaClient())
            {
                await client.InitializeAsync(appManager.Server);
                fn(new TestContext(appManager.Server, client));
            }

            await appManager.StopApplicationAsync();
        }
    }
}
