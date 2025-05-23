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
using System.Threading;
using System.Threading.Tasks;

namespace Wetcon.OpcUaClient.Base
{
    /// <summary>
    /// Base application to read device properties and parameters from an OPC UA Server and send them to a cloud
    /// endpoint.
    /// </summary>
    public abstract class ApplicationBase<TArgumentsType> where TArgumentsType : ConsoleArguments, new()
    {
        protected OpcUaDiClient OpcClient { get; private set; }
        protected IDeviceClient DeviceClient { get; private set; }
        protected TArgumentsType Arguments { get; private set; }

        protected virtual int Delay => 5 * 1000;

        protected virtual bool WriteParameter => true;

        protected abstract string Name { get; set; }

        public async Task Run(string[] args)
        {
            Console.CancelKeyPress += (sender, e) =>
            {
                LogLine("Exiting...");
                Environment.Exit(0);
            };

            LogLine("Press CTRL + C to exit");
            Arguments = new TArgumentsType();
            Arguments.Parse(args);

            await ReadAndSendTelemetryData();
        }

        protected abstract IDeviceClient CreateDeviceClient();

        private async Task ReadAndSendTelemetryData()
        {
            try
            {
                using (OpcClient = new OpcUaDiClient(Arguments.DeviceNodeId))
                {
                    await OpcClient.InitializeAsync(Arguments.OpcUaEndpointUrl);

                    using (DeviceClient = CreateDeviceClient())
                    {
                        var deviceProperties = OpcClient.ReadDeviceProperties();
                        ProcessDeviceProperties(deviceProperties);

                        while (true)
                        {
                            ProcessDataPoint();
                            if (Delay > 0)
                            {
                                Thread.Sleep(Delay);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                LogLine("Exception: " + e);
                Console.ReadLine();
            }
        }

        private void ProcessDeviceProperties(DeviceProperties deviceProperties)
        {
            LogLine("Processing Device Properties...");
            DeviceClient.ProcessDeviceProperties(deviceProperties.Manufacturer, deviceProperties.Model,
                deviceProperties.SerialNumber);
            LogLine("Done.");
        }

        private void ProcessDataPoint()
        {
            Log($"Reading device parameter '{Arguments.DeviceParameterName}'...");
            try
            {
                var parameterValue = OpcClient.ReadParameterValue(Arguments.DeviceParameterName);
                LogLine($" {parameterValue}");

                if (WriteParameter)
                {
                    Log($"Processing parameter {Arguments.UploadParameterName}...");
                    DeviceClient.ProcessDatapoint(Arguments.UploadParameterName, parameterValue);
                }
            }
            catch (Exception e)
            {
                LogLine($"Error: {e.Message}");
            }

            LogLine(" done.");
        }

        protected void Log(string text)
        {
            Console.Write("[{0}] {1}", Name, text);
        }

        protected void LogLine(string text)
        {
            Console.WriteLine("[{0}] {1}", Name, text);
        }
    }
}
