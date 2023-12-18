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

namespace Wetcon.PactwarePlugin.OpcUaServer.Fdt
{
    /// <summary>
    /// DTO to hold information about initiating IDtmOnlineParameter Upload / Download requests.
    /// </summary>
    public class InitTransferResponse
    {
        public InitTransferResponse(int transferId, InitTransferStatus initTransferStatus)
        {
            TransferId = transferId;
            InitTransferStatus = initTransferStatus;
        }

        public int TransferId { get; }
        public InitTransferStatus InitTransferStatus { get; }

        public static InitTransferResponse Ok(int transferId)
        {
            return new InitTransferResponse(transferId, InitTransferStatus.Ok);
        }

        public static InitTransferResponse NotOnline(int transferId)
        {
            return new InitTransferResponse(transferId, InitTransferStatus.ErrorNotOnline);
        }
    }
}
