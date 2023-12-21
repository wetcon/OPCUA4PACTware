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

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt;

namespace Wetcon.PactwarePlugin.OpcUaServer.Plugin.Tests
{
    [TestClass]
    public class DtmParameterWriterTests
    {
        [TestMethod]
        public void SetsDisplayParameter()
        {
            const string parameterName = "V_ProductText";
            var xml = FileAccess.ReadAllText("DTMParameterSchema.xml");
            var writer = new DtmParameterWriter(xml);

            writer.SetParameterValue(parameterName, "Laser Sensor 2");

            var dtmVariableParser = new DtmVariableParser(writer.ToXml());
            var parameters = dtmVariableParser.Parse();
            var productTextParameter = parameters.First(p => p.Id.Equals(parameterName));

            Assert.AreEqual("Laser Sensor 2", productTextParameter.Value);
        }

        [TestMethod]
        public void ParsesUIntParameter()
        {
            const string parameterName = "V_BDC1_SP_1";
            var xml = FileAccess.ReadAllText("DTMParameterSchema.xml");
            var writer = new DtmParameterWriter(xml);

            writer.SetParameterValue(parameterName, "120");

            var dtmVariableParser = new DtmVariableParser(writer.ToXml());
            var parameters = dtmVariableParser.Parse();
            var sp1Parameter = parameters.First(p => p.Id.Equals(parameterName));

            Assert.AreEqual("120", sp1Parameter.Value);
        }
    }
}
