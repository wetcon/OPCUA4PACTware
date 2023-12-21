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

using System.Xml;

namespace Wetcon.PactwarePlugin.OpcUaServer.Fdt
{
    /// <summary>
    /// Helper class to create and parse IFdtCommunication connect, transaction and disconnect requests.
    /// </summary>
    public class IOCommunicationXml
    {
        private static string ReadFirstNodeAttribute(string xml, string tagName, string attributeName)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            var busCategoryNodes = xmlDoc.GetElementsByTagName(tagName);
            if (busCategoryNodes.Count == 0 ||
                busCategoryNodes[0].Attributes?.Count == 0)
            {
                return null;
            }

            var busCategoryAttribute = busCategoryNodes[0].Attributes?[attributeName];

            return busCategoryAttribute?.Value;
        }

        public static string ParseCommunicationByteArray(string communicationResponse)
        {
            return ReadFirstNodeAttribute(communicationResponse, "fdt:CommunicationData", "byteArray");
        }

        public static string ParseCommunicationReference(string response)
        {
            return ReadFirstNodeAttribute(response, "ConnectResponse", "communicationReference");
        }

        public static string ParseBusCategoryId(string supportedProtocols)
        {
            return ReadFirstNodeAttribute(supportedProtocols, "fdt:BusCategory", "busCategory");
        }

        public static bool HasError(string response)
        {
            return !string.IsNullOrEmpty(ReadFirstNodeAttribute(response, "fdt:CommunicationError", "communicationError"));
        }

        public string GetConnectRequestXml(string tag)
        {
            var connectRequestXml = @"
<FDT xmlns=""x-schema:FDTIOLinkCommunicationSchema.xml"">
    <ConnectRequest tag=""{0}""/>
</FDT>";
            return string.Format(connectRequestXml, tag);
        }

        public string GetTransactionRequestXml(string communicationReference)
        {
            var transactionRequestXml = @"
<FDT xmlns=""x-schema:FDTIOLinkCommunicationSchema.xml"">
    <ReadProcessDataRequest communicationReference=""{0}"" direction=""o"" />
</FDT>";

            return string.Format(transactionRequestXml, communicationReference);
        }

        public string GetDisconnectRequest(string communicationReference)
        {
            var disconnectRequestXml = @"
<FDT xmlns:fdt=""x-schema:FDTDataTypesSchema.xml"">
    <DisconnectRequest communicationReference=""{0}""/>
</FDT>";
            return string.Format(disconnectRequestXml, communicationReference);
        }
    }
}
