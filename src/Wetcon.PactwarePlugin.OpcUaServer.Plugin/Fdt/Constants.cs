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

namespace Wetcon.PactwarePlugin.OpcUaServer.Fdt
{
    public static class Constants
    {
        public static class FdtNamespaces
        {
            /// <summary>
            /// Gets the FDT data types schema namespace.
            /// </summary>
            public const string FdtDataTypesSchemaNs = "x-schema:FDTDataTypesSchema.xml";

            /// <summary>
            /// DtmItemListSchema namespace.
            /// </summary>
            public const string DtmItemListSchemaNs = "x-schema:DTMItemListSchema.xml";
        }

        public static class Timeouts
        {
            public static TimeSpan GetOnlineDeviceParametersTimeout = TimeSpan.FromSeconds(30);
            public static TimeSpan ReadOnlineDeviceParametersTimeout = TimeSpan.FromSeconds(30);
            public static TimeSpan WriteOnlineDeviceParametersTimeout = TimeSpan.FromSeconds(30);
            public static TimeSpan CommunicationConnectTimeout = TimeSpan.FromSeconds(30);
            public static TimeSpan CommunicationTransactionTimeout = TimeSpan.FromSeconds(30);
            public static TimeSpan CommunicationDisconnectTimeout = TimeSpan.FromSeconds(30);
            public static TimeSpan TransferRequestTimeout = TimeSpan.FromSeconds(30);

        }
    }
}
