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
using Jigfdt.Fdt100;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt.Models;

namespace Wetcon.PactwarePlugin.OpcUaServer.Fdt
{
    /// <summary>
    /// Provides methods to get, read and write offline device parameters (using IDtmSingleInstanceDataAccess).
    /// </summary>
    public class DtmSingleInstanceDataAccessService : SyncFdtService<IDtmSingleInstanceDataAccess>
    {
        public virtual List<DtmParameter> GetOfflineDeviceParameters()
        {
            return InvokeSync(() =>
            {
                if (DtmInterface.ObjectPointer == null)
                {
                    return null;
                }

                var result = DtmInterface.ObjectPointer.GetItemList();
                LogDtmCall("GetItemList", result);

                var dtmItemList = FdtXmlSerializer.Deserialize<DtmItemListFdtDoc>(result);

                return DtmParameterMerger.Flatten(ParameterDataSourceKind.DtmSingleInstanceDataAccess,
                    dtmItemList.ItemInfoList);
            });
        }

        public virtual DtmItemList ReadOfflineDeviceParameters(DtmItemSelectionList dtmItemSelectionList)
        {
            return InvokeSync(() =>
            {
                if (DtmInterface.ObjectPointer == null)
                {
                    return null;
                }

                var fdtDoc = new DtmItemListFdtDoc
                {
                    ItemSelectionList = dtmItemSelectionList
                };

                var fdtDocXml = FdtXmlSerializer.Serialize(fdtDoc);
                var result = DtmInterface.ObjectPointer.Read(fdtDocXml);
                LogDtmCall("Read", result);

                var responseFdtDocXml = FdtXmlSerializer.Deserialize<DtmItemListFdtDoc>(result);

                return responseFdtDocXml.ItemList;
            });
        }

        public virtual DtmItemList WriteOfflineDeviceParameters(DtmItemList dtmItemList)
        {
            return InvokeSync(() =>
            {
                if (DtmInterface.ObjectPointer == null)
                {
                    return null;
                }

                var fdtDoc = new DtmItemListFdtDoc
                {
                    ItemList = dtmItemList
                };

                var fdtDocXml = FdtXmlSerializer.Serialize(fdtDoc);
                var result = DtmInterface.ObjectPointer.Write(fdtDocXml);
                LogDtmCall("Write", result);

                var responseFdtDocXml = FdtXmlSerializer.Deserialize<DtmItemListFdtDoc>(result);

                return responseFdtDocXml.ItemList;
            });
        }
    }
}
