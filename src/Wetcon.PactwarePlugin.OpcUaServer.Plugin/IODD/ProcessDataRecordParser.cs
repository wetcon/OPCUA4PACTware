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

using System.Collections.Generic;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt;

namespace Wetcon.PactwarePlugin.OpcUaServer.IODD
{

    /// <summary>
    /// Helper class to parse IODD files.
    /// </summary>
    public class ProcessDataRecordParser
    {
        /// <summary>
        /// Parses an IODD V1.01 file and returns a list of process data records.
        /// </summary>
        /// <param name="ioddFilePath"></param>
        /// <returns></returns>
        public static List<ProcessDataRecord> Parse(string ioddFilePath)
        {
            var result = new List<ProcessDataRecord>();

            foreach (var recordItem in Parse101(ioddFilePath))
            {
                if (recordItem.Item is IODD101.UIntegerT uintegerT)
                {
                    result.Add(new ProcessDataRecord(recordItem.Name.textId, DataType.UInteger, recordItem.bitOffset, uintegerT.bitLength));
                }
                else if (recordItem.Item is IODD101.BooleanT)
                {
                    result.Add(new ProcessDataRecord(recordItem.Name.textId, DataType.Boolean, recordItem.bitOffset, 1));
                }
            }

            return result;
        }

        private static IEnumerable<IODD101.RecordItemT> Parse101(string ioddFilePath)
        {
            var ioddXml = System.IO.File.ReadAllText(ioddFilePath);
            var ioDevice = FdtXmlSerializer.Deserialize<IODD101.IODevice>(ioddXml);
            var processDataCollection = ioDevice.ProfileBody.DeviceFunction.ProcessDataCollection;

            foreach (var processDataRecord in processDataCollection.ProcessData)
            {
                var processDataItem = (IODD101.RecordT)processDataRecord.ProcessDataIn.Item;
                foreach (var recordItem in processDataItem.RecordItem)
                {
                    yield return recordItem;
                }
            }
        }
    }
}
