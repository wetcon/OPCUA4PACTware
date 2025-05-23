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

using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Amazon.IotData;
using Amazon.IotData.Model;
using Newtonsoft.Json;
using Wetcon.OpcUaClient.Base;

namespace OPCUA2AWSIOT
{
    public class AwsIoTDeviceClient : IDeviceClient
    {
        readonly AmazonIotDataClient _deviceClient;
        readonly string _thingName;

        public AwsIoTDeviceClient(string accessKeyId, string secretAccessKey, string serviceUrl, string thingName)
        {
            _deviceClient = new AmazonIotDataClient(accessKeyId, secretAccessKey, serviceUrl);
            _thingName = thingName;
        }

        public async Task ProcessDatapoint(string name, object value)
        {
            var dataPoint = new Dictionary<string, object> { { name, value } };
            var reportedData = WrapReportedData(dataPoint);
            var payload = JsonConvert.SerializeObject(reportedData);

            await UpdateThingShadow(payload);
        }

        public async Task ProcessDeviceProperties(string manufacturer, string model, string serialnumber)
        {
            var dataPoint = WrapReportedData(new
            {
                device_manufacturer = manufacturer,
                device_model = model,
                device_serialnumber = serialnumber
            });

            var payload = JsonConvert.SerializeObject(dataPoint);

            await UpdateThingShadow(payload);
        }

        private async Task UpdateThingShadow(string payload)
        {
            using (var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(payload)))
            {
                var updateRequest = new UpdateThingShadowRequest()
                {
                    ThingName = _thingName,
                    Payload = memoryStream
                };

                await _deviceClient.UpdateThingShadowAsync(updateRequest);
            }
        }

        private object WrapReportedData(object reportedData)
        {
            return new
            {
                state = new
                {
                    reported = reportedData
                }
            };
        }

        public void Dispose()
        {
            _deviceClient.Dispose();
        }
    }
}
