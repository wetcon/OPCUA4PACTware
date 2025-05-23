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

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wetcon.IoLink.Helper;

namespace Wetcon.PactwarePlugin.OpcUaServer.Plugin.Tests
{
    [TestClass]
    public class IODDProcessParameterTests
    {
        [TestMethod]
        public void ParseIODD11()
        {
            var items = ParseMetaData(DeviceDescriptionVersion.Version_11);

            Assert.AreEqual(3, items.Count);

            var uintItem = items[0];

            Assert.AreEqual(ProcessDataType.IntegerT, uintItem.DataType);
            Assert.AreEqual(2, uintItem.BitOffset);
            Assert.AreEqual(14, uintItem.BitLength);
            Assert.AreEqual("Temperature", uintItem.DisplayName);

            var booleanItem1 = items[1];

            Assert.AreEqual(ProcessDataType.BooleanT, booleanItem1.DataType);
            Assert.AreEqual(1, booleanItem1.BitOffset);
            Assert.AreEqual("OUT2", booleanItem1.DisplayName);

            var booleanItem2 = items[2];

            Assert.AreEqual(ProcessDataType.BooleanT, booleanItem2.DataType);
            Assert.AreEqual(0, booleanItem2.BitOffset);
            Assert.AreEqual("OUT1", booleanItem2.DisplayName);
        }

        [TestMethod]
        public void ParseIODD101()
        {
            var items = ParseMetaData(DeviceDescriptionVersion.Version_101);

            Assert.AreEqual(2, items.Count);

            var uintItem = items[0];

            Assert.AreEqual(ProcessDataType.UIntegerT, uintItem.DataType);
            Assert.AreEqual(4, uintItem.BitOffset);
            Assert.AreEqual(12, uintItem.BitLength);
            Assert.AreEqual("Distance", uintItem.DisplayName);

            var booleanItem = items[1];

            Assert.AreEqual(ProcessDataType.BooleanT, booleanItem.DataType);
            Assert.AreEqual(0, booleanItem.BitOffset);
            Assert.AreEqual("Switchstate [OUT1].", booleanItem.DisplayName);
        }

        [TestMethod]
        public void GetProcessDataValues()
        {
            var items = ParseMetaData(DeviceDescriptionVersion.Version_101);
            var interpreter = new ProcessDataInterpreter("0151"); // 21, 1            

            var uintValue = interpreter.Read(items[0]);
            Assert.AreEqual((ulong)21, uintValue);

            var booleanValue = interpreter.Read(items[1]);
            Assert.IsTrue((bool)booleanValue);
        }

        private List<ProcessMetaDataRecord> ParseMetaData(DeviceDescriptionVersion version)
        {
            var filename = version == DeviceDescriptionVersion.Version_101 ?
                "ifm-000174-20150804-IODD1.0.1.xml" : "ifm-000247-20151118-IODD1.1.xml";
            var ioDDFilePath = FileAccess.GetPath(filename);
            DeviceDescriptionReader.TryReadFromFilename(ioDDFilePath, out var ioDeviceDescription);
            return ioDeviceDescription.GetProcessMetaData()[0].ProcessDataRecords;
        }
    }
}
