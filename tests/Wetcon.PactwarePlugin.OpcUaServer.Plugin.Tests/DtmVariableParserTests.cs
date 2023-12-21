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
using Opc.Ua;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt;

namespace Wetcon.PactwarePlugin.OpcUaServer.Plugin.Tests
{
    [TestClass]
    public class DtmVariableParserTests
    {
        [TestMethod]
        public void ParsesAllParameters()
        {
            var xml = FileAccess.ReadAllText("ExportedVariables.xml");
            var dtmVariableParser = new DtmVariableParser(xml);
            var parameters = dtmVariableParser.Parse();

            Assert.AreEqual(25, parameters.Count);
        }

        [TestMethod]
        public void ParsesDisplayParameter()
        {
            var xml = FileAccess.ReadAllText("ExportedVariables.xml");
            var dtmVariableParser = new DtmVariableParser(xml);
            var parameters = dtmVariableParser.Parse();
            var productTextParameter = parameters.First(p => p.Id.Equals("V_ProductText"));

            Assert.AreEqual("Laser Sensor", productTextParameter.Value);
        }

        [TestMethod]
        public void ParsesUIntParameter()
        {
            var xml = FileAccess.ReadAllText("ExportedVariables.xml");
            var dtmVariableParser = new DtmVariableParser(xml);
            var parameters = dtmVariableParser.Parse();
            var sp1Parameter = parameters.First(p => p.Id.Equals("V_BDC1_SP_1"));

            Assert.AreEqual("100", sp1Parameter.Value);
        }

        [TestMethod]
        public void ParsesTTX300Description()
        {
            var xml = FileAccess.ReadAllText("ExportedVariables2.xml");
            var dtmVariableParser = new DtmVariableParser(xml);
            dtmVariableParser.Parse();
        }

        [TestMethod]
        public void ReturnsAccessLevelByString()
        {
            Assert.AreEqual(AccessLevels.CurrentRead, DtmVariableParser.GetAccessLevel("1", "0"));
            Assert.AreEqual(AccessLevels.CurrentWrite, DtmVariableParser.GetAccessLevel("0", "1"));
            Assert.AreEqual(AccessLevels.CurrentReadOrWrite, DtmVariableParser.GetAccessLevel("1", "1"));
        }
    }
}
