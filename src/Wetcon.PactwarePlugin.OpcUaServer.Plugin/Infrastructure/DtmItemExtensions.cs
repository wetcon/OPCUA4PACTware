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
using System.ComponentModel;
using Opc.Ua;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt.Models;

namespace Wetcon.PactwarePlugin.OpcUaServer.Infrastructure
{
    /// <summary>
    /// Provides extension methods for the <see cref="DtmItemExtensions"/> interface.
    /// </summary>
    public static class DtmItemExtensions
    {
        public static DataValue ToOpcUaDataValue(this DtmItem dtmItem)
        {
            // Check dtmItem quality.
            if (dtmItem.Quality != null &&
                dtmItem.Quality.QualityBits != DtmQualityBitsKind.Good &&
                dtmItem.Quality.QualityBits != DtmQualityBitsKind.GoodLocalOverride)
            {
                return new DataValue(StatusCodes.Bad) { SourceTimestamp = DateTime.Now };
            }

            var dtmDataTypeKind = dtmItem.Variant.DataType;
            switch (dtmDataTypeKind)
            {
                case DtmDataTypeKind.ascii:
                case DtmDataTypeKind.packedAscii:
                case DtmDataTypeKind.password:
                case DtmDataTypeKind.bitString:
                case DtmDataTypeKind.hexString:
                    return new DataValue(new Variant(dtmItem.Variant.StringData.String)) { SourceTimestamp = DateTime.Now };
                case DtmDataTypeKind.floatType:
                    return new DataValue(new Variant(float.Parse(dtmItem.Variant.NumberData.Number))) { SourceTimestamp = DateTime.Now };
                case DtmDataTypeKind.doubleType:
                    return new DataValue(new Variant(double.Parse(dtmItem.Variant.NumberData.Number))) { SourceTimestamp = DateTime.Now };
                case DtmDataTypeKind.intType:
                    return new DataValue(new Variant(int.Parse(dtmItem.Variant.NumberData.Number))) { SourceTimestamp = DateTime.Now };
                case DtmDataTypeKind.unsigned:
                case DtmDataTypeKind.index:
                    return new DataValue(new Variant(uint.Parse(dtmItem.Variant.NumberData.Number))) { SourceTimestamp = DateTime.Now };
                case DtmDataTypeKind.byteType:
                    return new DataValue(new Variant(byte.Parse(dtmItem.Variant.NumberData.Number))) { SourceTimestamp = DateTime.Now };
                case DtmDataTypeKind.date:
                case DtmDataTypeKind.dateAndTime:
                case DtmDataTypeKind.time:
                case DtmDataTypeKind.duration:
                    return new DataValue(new Variant(DateTime.Parse(dtmItem.Variant.TimeData.Time))) { SourceTimestamp = DateTime.Now };
                case DtmDataTypeKind.binary:
                case DtmDataTypeKind.dtmSpecific:
                    var bytes = TypeInfo.Cast(System.Text.Encoding.Default.GetBytes(dtmItem.Variant.BinaryVariable.BinData), BuiltInType.ByteString);
                    return new DataValue(new Variant(bytes)) { SourceTimestamp = DateTime.Now };
                case DtmDataTypeKind.structured:
                    var structureBytes = TypeInfo.Cast(System.Text.Encoding.Default.GetBytes(dtmItem.Variant.StructuredVariable.BinaryVariable.BinData), BuiltInType.ByteString);
                    return new DataValue(new Variant(structureBytes)) { SourceTimestamp = DateTime.Now };
                default:
                    throw new InvalidEnumArgumentException(dtmDataTypeKind.ToString());
            }
        }
    }
}
