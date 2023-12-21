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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt.Models;
using Wetcon.PactwarePlugin.OpcUaServer.Infrastructure;

namespace Wetcon.PactwarePlugin.OpcUaServer.Fdt
{
    /// <summary>
    /// Base class for parsing and manipulating FDTDataTypesSchema xml.
    /// </summary>
    public abstract class FdtDataTypeXml
    {
        private static readonly XNamespace s_ns = "x-schema:FDTDataTypesSchema.xml";

        protected XDocument Xdoc { get; private set; }

        protected FdtDataTypeXml(string text)
        {
            Xdoc = XDocument.Parse(text);
        }

        protected IEnumerable<XElement> Variables => Xdoc.Descendants(s_ns + "DtmVariable");

        protected bool TryGetFirstNodeByName(XContainer parent, string name, out XElement result)
        {
            result = parent.Descendants(s_ns + name).FirstOrDefault();

            return null != result;
        }

        /// <summary>
        /// Depending on the data type, returns the <see cref="XAttribute"/> storing the actual value of the variable.
        /// </summary>
        /// <param name="valueElement"></param>
        /// <param name="valueAttribute"></param>
        /// <param name="dataType"></param>
        /// <returns></returns>
        protected bool TryGetValueAttribute(XElement valueElement, out XAttribute valueAttribute, out DtmDataTypeKind dataType)
        {
            if (TryGetFirstNodeByName(valueElement, "Display", out var display))
            {
                valueAttribute = display.Attribute("string");
                dataType = DtmDataTypeKind.bitString;

                return true;
            }

            if (TryGetFirstNodeByName(valueElement, "Variant", out var variant))
            {
                var dataTypeName = variant.Attribute("dataType").Value;
                dataType = EnumHelper.Parse<DtmDataTypeKind>(dataTypeName);

                switch (dataType)
                {
                    case DtmDataTypeKind.unsigned:
                    case DtmDataTypeKind.intType:
                    case DtmDataTypeKind.floatType:
                    case DtmDataTypeKind.doubleType:
                    case DtmDataTypeKind.index:
                    case DtmDataTypeKind.byteType:
                        valueAttribute = GetAttributeFromFirstDescendant(variant, "NumberData", "number");
                        return true;
                    case DtmDataTypeKind.binary:
                    case DtmDataTypeKind.dtmSpecific:
                    case DtmDataTypeKind.structured:
                        valueAttribute = GetAttributeFromFirstDescendant(variant, "BinaryVariable", "binData");
                        return true;
                    case DtmDataTypeKind.ascii:
                    case DtmDataTypeKind.packedAscii:
                    case DtmDataTypeKind.password:
                    case DtmDataTypeKind.bitString:
                    case DtmDataTypeKind.hexString:
                        valueAttribute = GetAttributeFromFirstDescendant(variant, "StringData", "string");
                        return true;
                    case DtmDataTypeKind.date:
                    case DtmDataTypeKind.time:
                    case DtmDataTypeKind.dateAndTime:
                    case DtmDataTypeKind.duration:
                        valueAttribute = GetAttributeFromFirstDescendant(variant, "TimeData", "time");
                        return true;
                }
            }

            valueAttribute = null;
            dataType = DtmDataTypeKind.ascii;

            return false;
        }

        private XAttribute GetAttributeFromFirstDescendant(XContainer parent, string descendantName, string attributeName)
        {
            if (TryGetFirstNodeByName(parent, descendantName, out var descendant))
            {
                return descendant.Attribute(attributeName);
            }

            throw new InvalidOperationException();
        }
    }
}
