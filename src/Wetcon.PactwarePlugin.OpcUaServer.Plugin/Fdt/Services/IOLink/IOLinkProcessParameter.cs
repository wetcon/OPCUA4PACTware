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
using System.Linq;
using System.Xml;
using PWID.Interfaces;
using Wetcon.IoLink.Helper;

namespace Wetcon.PactwarePlugin.OpcUaServer.Fdt
{
    public static class IODDProcessParameter
    {
        /// <summary>
        /// Retrieves the device type information from a given pactware project node and tries to parse 
        /// an IODD, if available
        /// </summary>
        /// <param name="pactwareProjectNode"></param>
        /// <returns></returns>
        public static List<ProcessMetaDataRecord> FromPWProjectNode(IPACTwareProjectNode pactwareProjectNode)
        {
            var ioDDFilePath = GetIODDFilePath(pactwareProjectNode);
            if (DeviceDescriptionReader.TryReadFromFilename(ioDDFilePath, out var ioDeviceDescription))
            {
                return ioDeviceDescription.GetProcessMetaData()
                            .SelectMany(md => md.ProcessDataRecords)
                            .ToList();
            }

            return new List<ProcessMetaDataRecord>();
        }

        private static string GetIODDFilePath(IPACTwareProjectNode pactwareProjectNode)
        {
            var xml = pactwareProjectNode.CatalogueObject.DeviceTypeId;
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            var deviceTypeNodes = xmlDoc.GetElementsByTagName("fdt:DtmDeviceType");
            var deviceTypeInformationAttribute = deviceTypeNodes[0].Attributes["deviceTypeInformation"];

            if (deviceTypeNodes.Count == 0 || deviceTypeInformationAttribute == null)
            {
                return string.Empty;
            }

            return deviceTypeInformationAttribute.Value;
        }
    }
}
