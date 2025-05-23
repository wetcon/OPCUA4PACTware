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

using System;
using System.ComponentModel;
using System.Globalization;
using Opc.Ua;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt.Models;

namespace Wetcon.PactwarePlugin.OpcUaServer.Fdt
{
    /// <summary>
    /// Represents a device parameter.
    /// </summary>
    public class DtmParameter
    {
        public DtmParameter(string id, string name, string descriptor, DtmDataTypeKind dataType, byte accessLevel, ParameterDataSourceKind source,
            object value = null)
        {
            Id = id;
            Name = name;
            Label = name;
            Descriptor = descriptor;
            DataType = dataType;
            AccessLevel = accessLevel;
            Source = source;
            Value = value;
        }

        public string Id { get; }

        public string Name { get; }

        public string Label { get; }

        public string Descriptor { get; }

        public DtmDataTypeKind DataType { get; }

        public byte AccessLevel { get; }

        public object Value { get; set; }

        public ParameterDataSourceKind Source { get; }

        public DtmItem ToDtmItem()
        {
            var dtmItem = new DtmItem
            {
                Id = Id,
                Variant = new DtmVariant()
                {
                    DataType = DataType
                }
            };
            switch (DataType)
            {
                case DtmDataTypeKind.ascii:
                case DtmDataTypeKind.packedAscii:
                case DtmDataTypeKind.password:
                case DtmDataTypeKind.bitString:
                case DtmDataTypeKind.hexString:
                    dtmItem.Variant.StringData = new DtmStringData
                    {
                        String = Value.ToString()
                    };
                    break;
                case DtmDataTypeKind.floatType:
                    dtmItem.Variant.NumberData = new DtmNumberData
                    {
                        Number = Convert.ToSingle(Value).ToString(CultureInfo.InvariantCulture)
                    };
                    break;
                case DtmDataTypeKind.doubleType:
                    dtmItem.Variant.NumberData = new DtmNumberData
                    {
                        Number = Convert.ToDouble(Value).ToString(CultureInfo.InvariantCulture)
                    };
                    break;
                case DtmDataTypeKind.intType:
                    dtmItem.Variant.NumberData = new DtmNumberData
                    {
                        Number = Convert.ToInt32(Value).ToString(CultureInfo.InvariantCulture)
                    };
                    break;
                case DtmDataTypeKind.unsigned:
                case DtmDataTypeKind.index:
                    dtmItem.Variant.NumberData = new DtmNumberData
                    {
                        Number = Convert.ToInt32(Value).ToString(CultureInfo.InvariantCulture)
                    };
                    break;
                case DtmDataTypeKind.byteType:
                    dtmItem.Variant.NumberData = new DtmNumberData
                    {
                        Number = Convert.ToByte(Value).ToString(CultureInfo.InvariantCulture)
                    };
                    break;
                case DtmDataTypeKind.date:
                case DtmDataTypeKind.dateAndTime:
                case DtmDataTypeKind.time:
                case DtmDataTypeKind.duration:
                    // A date in a subset of the ISO 8601 format, with optional time and no optional zone. Fractional seconds can be as precise as nanoseconds.
                    // Example:"1988-04-07T18:39:09".
                    dtmItem.Variant.TimeData = new DtmTimeData
                    {
                        Time = Convert.ToDateTime(Value).ToString("s", CultureInfo.InvariantCulture)
                    };
                    break;
                case DtmDataTypeKind.binary:
                case DtmDataTypeKind.dtmSpecific:
                    dtmItem.Variant.BinaryVariable = new DtmBinaryVariable
                    {
                        BinData = System.Text.Encoding.Default.GetString((byte[])TypeInfo.Cast(Value, BuiltInType.ByteString))
                    };
                    break;
                case DtmDataTypeKind.structured:
                    dtmItem.Variant.StructuredVariable = new DtmStructuredVariable
                    {
                        BinaryVariable = new DtmBinaryVariable
                        {
                            BinData = System.Text.Encoding.Default.GetString((byte[])TypeInfo.Cast(Value, BuiltInType.ByteString))
                        }
                    };
                    break;
                default:
                    throw new InvalidEnumArgumentException(DataType.ToString());
            }

            return dtmItem;
        }
    }
}
