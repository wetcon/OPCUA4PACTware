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

namespace Wetcon.OpcUaClient.Base
{
    /// <summary>
    /// Provides access to console arguments
    /// </summary>
    public abstract class ConsoleArguments
    {
        public string OpcUaEndpointUrl { get; protected set; }
        public string DeviceNodeId { get; protected set; }
        public string DeviceParameterName { get; protected set; }
        public string UploadParameterName { get; protected set; }

        public void Parse(string[] args)
        {
            ReadDefaultArguments(args);
            ReadArguments(args);
        }

        private void ReadDefaultArguments(string[] args)
        {
            DeviceNodeId = GetArgument(args, 0);
            OpcUaEndpointUrl = GetArgument(args, 1);
            DeviceParameterName = GetArgument(args, 2);
            UploadParameterName = GetArgument(args, 3);
        }

        protected abstract void ReadArguments(string[] args);

        protected string GetArgument(string[] args, int index)
        {
            if (index >= args.Length)
            {
                return null;
            }

            return args[index];
        }
    }
}
