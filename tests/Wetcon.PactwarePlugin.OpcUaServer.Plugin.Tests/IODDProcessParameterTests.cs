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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wetcon.PactwarePlugin.OpcUaServer.IODD;

namespace Wetcon.PactwarePlugin.OpcUaServer.Plugin.Tests
{
    [TestClass]
    public class IODDProcessParameterTests
    {

        [TestMethod]
        public void ParseIODD()
        {
            var items = ProcessDataRecordParser.Parse(FileAccess.GetPath("ifm-000174-20150804-IODD1.0.1.xml"));
            Assert.AreEqual(2, items.Count);

            var uintItem = items[0];

            Assert.AreEqual(DataType.UInteger, uintItem.Type);
            Assert.AreEqual(4, uintItem.BitOffset);
            Assert.AreEqual(12, uintItem.BitLength);
            Assert.AreEqual("TN_PDV1", uintItem.Name);

            var booleanItem = items[1];

            Assert.AreEqual(DataType.Boolean, booleanItem.Type);
            Assert.AreEqual(0, booleanItem.BitOffset);
            Assert.AreEqual("TN_PDV2", booleanItem.Name);
        }

        [TestMethod]
        public void GetProcessDataValues()
        {
            var items = ProcessDataRecordParser.Parse(FileAccess.GetPath("ifm-000174-20150804-IODD1.0.1.xml"));
            var processData = new ProcessData("0151"); //21,  1

            var uintValue = items[0].GetValue(processData);
            Assert.AreEqual(21, uintValue);

            var booleanValue = items[1].GetValue(processData);
            Assert.IsTrue((bool)booleanValue);
        }
    }
}
