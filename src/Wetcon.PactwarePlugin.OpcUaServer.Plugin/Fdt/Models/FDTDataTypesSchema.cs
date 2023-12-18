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

using System.Collections.Generic;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Wetcon.PactwarePlugin.OpcUaServer.Fdt.Models
{
    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
    public class DtmVariant
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified)]
        public string NodeId { get; set; }

        [XmlAttribute("dataType")] public DtmDataTypeKind DataType { get; set; }

        [XmlAttribute("byteLength")] public uint ByteLength { get; set; }

        [XmlAttribute("displayFormat")] public string DisplayFormat { get; set; }

        [XmlElement("StringData", Form = XmlSchemaForm.Qualified)]
        public DtmStringData StringData { get; set; }

        [XmlElement("NumberData", Form = XmlSchemaForm.Qualified)]
        public DtmNumberData NumberData { get; set; }

        [XmlElement("TimeData", Form = XmlSchemaForm.Qualified)]
        public DtmTimeData TimeData { get; set; }

        [XmlElement("BitEnumeratorVariable", Form = XmlSchemaForm.Qualified)]
        public DtmBitEnumeratorVariable BitEnumeratorVariable { get; set; }

        [XmlElement("BinaryVariable", Form = XmlSchemaForm.Qualified)]
        public DtmBinaryVariable BinaryVariable { get; set; }

        [XmlElement("StructuredVariable", Form = XmlSchemaForm.Qualified)]
        public DtmStructuredVariable StructuredVariable { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
    public class DtmVariable
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified)]
        public string NodeId { get; set; }

        [XmlElement("EnumeratorEntry", Form = XmlSchemaForm.Qualified)]
        public DtmEnumeratorEntry EnumeratorEntry { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
    public class DtmBitVariable
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified)]
        public string NodeId { get; set; }

        [XmlElement("EnumeratorEntry", Form = XmlSchemaForm.Qualified)]
        public List<DtmEnumeratorEntry> EnumeratorEntry { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
    public class DtmEnumeratorVariable
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified)]
        public string NodeId { get; set; }

        [XmlElement("Variable", Form = XmlSchemaForm.Qualified)]
        public DtmVariable Variable { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
    public class DtmBitEnumeratorVariable
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified)]
        public string NodeId { get; set; }

        [XmlElement("BitVariable", Form = XmlSchemaForm.Qualified)]
        public DtmBitVariable Variable { get; set; }

        [XmlElement("BitEnumeratorEntries", Form = XmlSchemaForm.Qualified)]
        public DtmBitEnumeratorEntries BitEnumeratorEntries { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
    public class DtmBinaryVariable
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified)]
        public string NodeId { get; set; }

        [XmlAttribute("binData")] public string BinData { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
    public class DtmStructuredVariable
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified)]
        public string NodeId { get; set; }

        [XmlAttribute("dataTypeDescriptor")] public string DataTypeDescriptor { get; set; }

        [XmlElement("BinaryVariable", Form = XmlSchemaForm.Qualified)]
        public DtmBinaryVariable BinaryVariable { get; set; }

        [XmlElement("StructuredElements", Form = XmlSchemaForm.Qualified)]
        public DtmStructuredElements StructuredElements { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
    public class DtmStructuredElements
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified)]
        public string NodeId { get; set; }

        [XmlElement("StructuredElement", Form = XmlSchemaForm.Qualified)]
        public List<DtmStructuredElement> StructuredElements { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
    public class DtmStructuredElement
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified)]
        public string NodeId { get; set; }

        [XmlAttribute("bitLength")] public uint BitLength { get; set; }

        [XmlElement("Display", Form = XmlSchemaForm.Qualified)]
        public DtmDisplay Display { get; set; }

        [XmlElement("DtmVariableReference", Form = XmlSchemaForm.Qualified)]
        public DtmVariableReference VariableReference { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
    public class DtmDisplay
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified)]
        public string NodeId { get; set; }

        [XmlAttribute("string")] public string String { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
    public class DtmVariableReference
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified)]
        public string NodeId { get; set; }

        [XmlAttribute("reference")] public string Reference { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
    public class DtmSemanticInformation
    {
        [XmlAttribute("nodeId")] public string NodeId { get; set; }

        [XmlAttribute("applicationDomain")] public string ApplicationDomain { get; set; }

        [XmlAttribute("semanticId")] public string SemanticId { get; set; }

        [XmlAttribute("address")] public string Address { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
    public class DtmEnumeratorEntries
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified)]
        public string NodeId { get; set; }

        [XmlElement("EnumeratorEntry", Form = XmlSchemaForm.Qualified)]
        public List<DtmEnumeratorEntry> EnumeratorEntries { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
    public class DtmBitEnumeratorEntries
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified)]
        public string NodeId { get; set; }

        [XmlElement("EnumeratorEntry", Form = XmlSchemaForm.Qualified)]
        public List<DtmEnumeratorEntry> EnumeratorEntries { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
    public class DtmEnumeratorEntry
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified)]
        public string NodeId { get; set; }

        [XmlAttribute("index")] public int Index { get; set; }

        [XmlAttribute("name")] public string Name { get; set; }

        [XmlAttribute("descriptor")] public int Descriptor { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
    public class DtmStringData
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified)]
        public string NodeId { get; set; }

        [XmlAttribute("string")] public string String { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
    public class DtmNumberData
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified)]
        public string NodeId { get; set; }

        [XmlAttribute("number")] public string Number { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
    public class DtmTimeData
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified)]
        public string NodeId { get; set; }

        /// <summary>
        /// A date in a subset of the ISO 8601 format, with optional time and no optional zone. Fractional seconds can be as precise as nanoseconds.
        /// Example:"1988-04-07T18:39:09".
        /// </summary>
        [XmlAttribute("time")]
        public string Time { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
    public class DtmLowerRawValue
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified)]
        public string NodeId { get; set; }

        [XmlAttribute("number")] public double Number { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
    public class DtmUpperRawValue
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified)]
        public string NodeId { get; set; }

        [XmlAttribute("number")] public double Number { get; set; }
    }

    public enum DtmDataTypeKind
    {
        [XmlEnum(Name = "byte")]
        byteType,

        [XmlEnum(Name = "float")]
        floatType,

        [XmlEnum(Name = "double")]
        doubleType,

        [XmlEnum(Name = "int")]
        intType,

        unsigned,
        enumerator,
        bitEnumerator,
        index,
        ascii,
        packedAscii,
        password,
        bitString,
        hexString,
        date,
        time,
        dateAndTime,
        duration,
        binary,
        structured,
        dtmSpecific
    }

}
