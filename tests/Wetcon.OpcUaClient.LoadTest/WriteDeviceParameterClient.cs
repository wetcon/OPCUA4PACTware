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

using System.Threading.Tasks;
using Wetcon.OpcUaClient.Base;

namespace Wetcon.OpcUaClient
{
    /// <summary>
    /// 
    /// </summary>
    class WriteDeviceParameterClient : IDeviceClient
    {
        private readonly OpcUaDiClient _opcClient;
        private readonly int _valueToWrite;

        public WriteDeviceParameterClient(OpcUaDiClient opcClient, int valueToWrite)
        {
            _opcClient = opcClient;
            _valueToWrite = valueToWrite;
        }

        public void Dispose()
        {

        }

        public Task ProcessDeviceProperties(string manufacturer, string model, string serialNumber)
        {
            return Task.CompletedTask;
        }

        public Task ProcessDatapoint(string name, object value)
        {
            _opcClient.WriteParameterValue(name, _valueToWrite);

            return Task.CompletedTask;
        }
    }
}
