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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt;

namespace Wetcon.PactwarePlugin.OpcUaServer.Plugin.Tests
{
    [TestClass]
    public class XmlTests
    {
        private const string ProtocolSchema = @"<?xml version=""1.0""?>
        <FDT xmlns=""x-schema:DTMProtocolsSchema.xml"" xmlns:fdt=""x-schema:FDTDataTypesSchema.xml"">
            <fdt:BusCategories>
                <fdt:BusCategory busCategory=""2C4CD8B8-D509-4ECB-94A7-019F12569C8B"" busCategoryName=""IO-Link"">
                    <fdt:CommunicationTypeEntry communicationType=""supported"" />
                </fdt:BusCategory>
            </fdt:BusCategories>
        </FDT>";

        private const string CommunicationResponse = @"<?xml version=""1.0""?>
        <FDT xmlns=""x-schema:FDTIOLinkCommunicationSchema.xml"" xmlns:fdt=""x-schema:FDTDataTypesSchema.xml"">
        	<ReadProcessDataResponse communicationReference=""5eb65b2e-968f-4788-b972-0a0058c9c94d"" direction=""input"" pdValid=""1"" errorCode=""0"" additionalCode=""0"">
        		<fdt:CommunicationData byteArray=""03B1""/>
        	</ReadProcessDataResponse>
        </FDT>";

        [TestMethod]
        public void ParseProtocol()
        {
            var busCategoryId = IOCommunicationXml.ParseBusCategoryId(ProtocolSchema);

            Assert.AreEqual("2C4CD8B8-D509-4ECB-94A7-019F12569C8B", busCategoryId);
        }

        [TestMethod]
        public void ParseCommunicationData()
        {
            var byteArray = IOCommunicationXml.ParseCommunicationByteArray(CommunicationResponse);

            Assert.AreEqual("03B1", byteArray);
        }
    }
}
