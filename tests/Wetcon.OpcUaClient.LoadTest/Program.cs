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
using System.Threading.Tasks;
using Wetcon.OpcUaClient.Base;

namespace Wetcon.OpcUaClient
{
    class Program : ApplicationBase<LoadTestArguments>
    {
        private int ValueToWrite { get; set; } = 5;

        protected override string Name { get; set; } = "LoadTestApp";

        protected override int Delay => 0;

        protected override bool WriteParameter => Arguments.WriteParameter;

        public static async Task Main(string[] args)
        {
            var parameters = new LoadTestArguments();
            parameters.Parse(args);
            var threadCount = parameters.ThreadsCount;

            var tasks = new List<Task>();

            for (var i = 0; i < threadCount; i++)
            {
                var program = new Program
                {
                    ValueToWrite = i + 1
                };

                program.Name += "_" + program.ValueToWrite;
                var task = Task.Run(async () => await program.Run(args));
                tasks.Add(task);
            }

            await Task.WhenAny(tasks);
        }

        protected override IDeviceClient CreateDeviceClient()
        {
            return new WriteDeviceParameterClient(OpcClient, ValueToWrite);
        }
    }
}
