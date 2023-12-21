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
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Devices.Client;
using Microsoft.Azure.Devices.Shared;
using Newtonsoft.Json;
using Wetcon.OpcUaClient.Base;

namespace OPCUA2AzureIOT
{
    public class IoTHubDeviceClient : IDeviceClient
    {
        readonly DeviceClient _deviceClient;

        public IoTHubDeviceClient(string connectionString)
        {
            _deviceClient = DeviceClient.CreateFromConnectionString(connectionString, TransportType.Mqtt);
            _deviceClient.OperationTimeoutInMilliseconds = 30 * 1000;
        }

        public async Task ProcessDatapoint(string name, object value)
        {
            var dataPoint = new Dictionary<string, object> { { name, value } };
            var messageString = JsonConvert.SerializeObject(dataPoint);
            var message = new Message(Encoding.ASCII.GetBytes(messageString));

            await _deviceClient.SendEventAsync(message);
        }

        public async Task ProcessDeviceProperties(string manufacturer, string model, string serialnumber)
        {
            var reportedProperties =
                new TwinCollection
                {
                    ["device_manufacturer"] = manufacturer,
                    ["device_model"] = model,
                    ["device_serialnumber"] = serialnumber
                };

            await _deviceClient.UpdateReportedPropertiesAsync(reportedProperties);
        }

        public void Dispose()
        {
            _deviceClient.Dispose();
        }
    }
}
