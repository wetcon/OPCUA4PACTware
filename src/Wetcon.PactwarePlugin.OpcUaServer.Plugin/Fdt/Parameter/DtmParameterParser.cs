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

using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Opc.Ua;

namespace Wetcon.PactwarePlugin.OpcUaServer.Fdt
{
    public class DtmVariableParser : FdtDataTypeXml
    {
        public DtmVariableParser(string xml) : base(xml)
        {

        }

        /// <summary>
        /// Parses parameters from the result of an IDtmParameter.GetParameters invocation.
        /// </summary>
        /// <returns></returns>
        public List<DtmParameter> Parse()
        {
            var result = new List<DtmParameter>();

            foreach (var variable in Variables)
            {
                var name = variable.Attribute("name").Value;
                var descriptor = GetAttributeValueOrEmpty(variable, "descriptor");

                if (TryGetFirstNodeByName(variable, "Value", out var valueElement))
                {
                    var readAccess = GetAttributeValueOrEmpty(valueElement, "readAccess");
                    var writeAccess = GetAttributeValueOrEmpty(valueElement, "writeAccess");
                    var accessLevel = GetAccessLevel(readAccess, writeAccess);
                    if (TryGetValueAttribute(valueElement, out var valueAttribute, out var dataType))
                    {
                        var value = valueAttribute.Value;
                        result.Add(new DtmParameter(name, name, descriptor, dataType, accessLevel, ParameterDataSourceKind.DtmParameter, value));
                    }
                }
            }

            return result;
        }

        public static byte GetAccessLevel(string readAccess, string writeAccess)
        {
            const string enabled = "1";
            var accessLevel = AccessLevels.None;

            if (readAccess == enabled || readAccess == string.Empty)
            {
                accessLevel = SetBit(accessLevel, 0);
            }
            if (writeAccess == enabled)
            {
                accessLevel = SetBit(accessLevel, 1);
            }

            return accessLevel;
        }

        private static byte SetBit(byte value, int pos)
        {
            if (pos < 0 || pos > 7)
            {
                throw new ArgumentOutOfRangeException(nameof(pos));
            }

            return (byte)(value | (1 << pos));
        }

        private string GetAttributeValueOrEmpty(XElement element, string attributeName)
        {
            var descriptorAttribute = element.Attribute(attributeName);

            return descriptorAttribute?.Value ?? string.Empty;
        }
    }
}
