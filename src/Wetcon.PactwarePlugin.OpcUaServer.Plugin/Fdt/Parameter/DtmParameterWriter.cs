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

using System.Linq;

namespace Wetcon.PactwarePlugin.OpcUaServer.Fdt
{
    public class DtmParameterWriter : FdtDataTypeXml
    {
        public DtmParameterWriter(string text) : base(text)
        {

        }

        /// <summary>
        /// Returns the underlying XML.
        /// </summary>
        /// <returns></returns>
        public string ToXml()
        {
            return Xdoc.ToString();
        }

        /// <summary>
        /// Sets the value of the parameter with the given name.
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="value"></param>
        public bool SetParameterValue(string parameterName, object value)
        {
            var variableToSet = Variables.FirstOrDefault(v => v.Attribute("name")?.Value == parameterName);

            if (null == variableToSet || !TryGetFirstNodeByName(variableToSet, "Value", out var valueElement))
            {
                return false;
            }

            if (!TryGetValueAttribute(valueElement, out var valueAttribute, out _))
            {
                return false;
            }

            valueAttribute.SetValue(value);
            return true;
        }
    }
}
