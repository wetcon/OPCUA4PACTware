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
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Wetcon.PactwarePlugin.OpcUaServer.Fdt.Models
{
    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.DtmItemListSchemaNs)]
    [XmlRoot("FDT", Namespace = Constants.FdtNamespaces.DtmItemListSchemaNs)]
    public class DtmItemListFdtDoc
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string NodeId { get; set; }

        [XmlElement("DtmItemInfoList")]
        public DtmItemInfoList ItemInfoList { get; set; }

        [XmlElement("DtmItemList")]
        public DtmItemList ItemList { get; set; }

        [XmlElement("DtmItemSelectionList")]
        public DtmItemSelectionList ItemSelectionList { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.DtmItemListSchemaNs)]
    public class DtmItemInfo
    {
        public DtmItemInfo()
        {
            ReadAccess = 1;
            WriteAccess = 0;
        }

        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string NodeId { get; set; }

        [XmlAttribute("id", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string Id { get; set; }

        [XmlElement("SemanticInformation", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public List<DtmSemanticInformation> SemanticInformation { get; set; }

        [XmlAttribute("name", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string Name { get; set; }

        [XmlAttribute("dataType", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public DtmDataTypeKind DataType { get; set; }

        [XmlAttribute("itemType")]
        public DtmItemTypeKind ItemType { get; set; }

        [XmlAttribute("descriptor", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string Descriptor { get; set; }

        [XmlAttribute("moduleName")]
        public string ModuleName { get; set; }

        [XmlAttribute("readAccess", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public uint ReadAccess { get; set; }

        [XmlAttribute("writeAccess", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public uint WriteAccess { get; set; }

        [XmlAttribute("label")]
        public string Label { get; set; }

        [XmlElement("ItemKind")]
        public List<DtmItemKind> ItemKind { get; set; }

        [XmlElement("UnitDescription")]
        public DtmUnitDescription UnitDescription { get; set; }

        [XmlElement("RangeDescriptions")]
        public DtmRangeDescriptions RangeDescriptions { get; set; }

        [XmlElement("ValueDescription")]
        public DtmValueDescription ValueDescription { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.DtmItemListSchemaNs)]
    public class DtmItemInfoGroup
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string NodeId { get; set; }

        [XmlAttribute("name", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string Name { get; set; }

        [XmlElement("SemanticInformation", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public List<DtmSemanticInformation> SemanticInformation { get; set; }

        [XmlAttribute("label", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string Label { get; set; }

        [XmlElement("DtmItemInfo")]
        public List<DtmItemInfo> ItemInfos { get; set; }

        [XmlElement("DtmItemInfoGroup")]
        public List<DtmItemInfoGroup> ItemGroups { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.DtmItemListSchemaNs)]
    public class DtmItem
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string NodeId { get; set; }

        [XmlAttribute("id", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string Id { get; set; }

        [XmlElement("TimeStamp")]
        public DtmTimeStamp TimeStamp { get; set; }

        [XmlElement("Quality")]
        public DtmQuality Quality { get; set; }

        [XmlElement("ItemError")]
        public DtmItemError ItemError { get; set; }

        [XmlElement("Variant", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public DtmVariant Variant { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.DtmItemListSchemaNs)]
    public class DtmItemInfoList
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string NodeId { get; set; }

        [XmlElement("DtmItemInfo")]
        public List<DtmItemInfo> ItemInfos { get; set; }

        [XmlElement("DtmItemInfoGroup")]
        public List<DtmItemInfoGroup> ItemGroups { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.DtmItemListSchemaNs)]
    public class DtmItemList
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string NodeId { get; set; }

        [XmlElement("DtmItem")]
        public List<DtmItem> Items { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.DtmItemListSchemaNs)]
    public class DtmItemSelectionList
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string NodeId { get; set; }

        [XmlElement("DtmItemSelection")]
        public List<DtmItemSelection> ItemSelections { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.DtmItemListSchemaNs)]
    public class DtmItemSelection
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string NodeId { get; set; }

        [XmlAttribute("id", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string Id { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.DtmItemListSchemaNs)]
    public class DtmItemKind
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string NodeId { get; set; }

        [XmlAttribute("itemKind")]
        public DtmItemKinds ItemKind { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.DtmItemListSchemaNs)]
    public class DtmQuality
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string NodeId { get; set; }

        [XmlAttribute("qualityBits")]
        public DtmQualityBitsKind QualityBits { get; set; }

        [XmlAttribute("limitBits")]
        public DtmLimitBitsKind LimitBits { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.DtmItemListSchemaNs)]
    public class DtmItemErrorDescription
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string NodeId { get; set; }

        [XmlAttribute("itemErrorDescription")]
        public DtmItemErrorDescriptionKind ItemErrorDescription { get; set; }

        [XmlAttribute("descriptor", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string Descriptor { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.DtmItemListSchemaNs)]
    public class DtmItemError
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string NodeId { get; set; }

        [XmlElement("ItemErrorDescription")]
        public string ItemErrorDescription { get; set; }

        [XmlElement("CommunicationError", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string CommunicationError { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.DtmItemListSchemaNs)]
    public class DtmPossibleEnumerations
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string NodeId { get; set; }

        [XmlElement("EnumeratorEntries", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public DtmEnumeratorEntries EnumeratorEntries { get; set; }

        [XmlElement("BitEnumeratorEntries", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public DtmEnumeratorEntries BitEnumeratorEntries { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.DtmItemListSchemaNs)]
    public class DtmItemReference
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string NodeId { get; set; }

        [XmlAttribute("idref", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string IdRef { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.DtmItemListSchemaNs)]
    public class DtmLowerRangeDescription
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string NodeId { get; set; }

        [XmlElement("ItemReference")]
        public DtmItemReference ItemReference { get; set; }

        [XmlElement("StringData", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string StringData { get; set; }

        [XmlElement("NumberData", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string NumberData { get; set; }

        [XmlElement("TimeData", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string TimeData { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.DtmItemListSchemaNs)]
    public class DtmUpperRangeDescription
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string NodeId { get; set; }

        [XmlElement("ItemReference")]
        public DtmItemReference ItemReference { get; set; }

        [XmlElement("StringData", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string StringData { get; set; }

        [XmlElement("NumberData", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string NumberData { get; set; }

        [XmlElement("TimeData", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string TimeData { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.DtmItemListSchemaNs)]
    public class DtmRangeDescriptions
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string NodeId { get; set; }

        [XmlElement("RangeDescription")]
        public List<DtmRangeDescription> RangeDescriptions { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.DtmItemListSchemaNs)]
    public class DtmRangeDescription
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string NodeId { get; set; }

        [XmlElement("LowerRangeDescription")]
        public DtmLowerRangeDescription LowerRangeDescription { get; set; }

        [XmlElement("UpperRangeDescription")]
        public DtmUpperRangeDescription UpperRangeDescription { get; set; }

        [XmlElement("LowerRawValue", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public DtmLowerRawValue LowerRawValue { get; set; }

        [XmlElement("UpperRawValue", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public DtmUpperRawValue UpperRawValue { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.DtmItemListSchemaNs)]
    public class DtmValueDescription
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string NodeId { get; set; }

        [XmlElement("PossibleEnumerations")]
        public DtmPossibleEnumerations PossibleEnumerations { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.DtmItemListSchemaNs)]
    public class DtmUnitDescription
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string NodeId { get; set; }

        [XmlElement("ItemReference")]
        public DtmItemReference ItemReference { get; set; }

        [XmlElement("EnumeratorEntry", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public DtmEnumeratorEntry EnumeratorEntry { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.DtmItemListSchemaNs)]
    public class DtmTimeStamp
    {
        [XmlAttribute("nodeId", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string NodeId { get; set; }

        [XmlAttribute("time", Form = XmlSchemaForm.Qualified, Namespace = Constants.FdtNamespaces.FdtDataTypesSchemaNs)]
        public string Time { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = Constants.FdtNamespaces.DtmItemListSchemaNs)]
    public enum DtmQualityBitsKind
    {
        [XmlEnum(Name = "bad")]
        Bad,

        [XmlEnum(Name = "badConfigurationError")]
        BadConfigurationError,

        [XmlEnum(Name = "badNotConnected")]
        BadNotConnected,

        [XmlEnum(Name = "badDeviceFailure")]
        BadDeviceFailure,

        [XmlEnum(Name = "badSensorFailure")]
        BadSensorFailure,

        [XmlEnum(Name = "badLastKnownValue")]
        BadLastKnownValue,

        [XmlEnum(Name = "badCommFailure")]
        BadCommFailure,

        [XmlEnum(Name = "badOutOfService")]
        BadOutOfService,

        [XmlEnum(Name = "badWaitingForInitialData")]
        BadWaitingForInitialData,

        [XmlEnum(Name = "uncertain")]
        Uncertain,

        [XmlEnum(Name = "uncertainLastUsableValue")]
        UncertainLastUsableValue,

        [XmlEnum(Name = "uncertainSensorNotAccurate")]
        UncertainSensorNotAccurate,

        [XmlEnum(Name = "uncertainEUExceeded")]
        UncertainEuExceeded,

        [XmlEnum(Name = "uncertainSubNormal")]
        UncertainSubNormal,

        [XmlEnum(Name = "good")]
        Good,

        [XmlEnum(Name = "goodLocalOverride")]
        GoodLocalOverride
    }

    public enum DtmLimitBitsKind
    {
        [XmlEnum(Name = "none")]
        None,

        [XmlEnum(Name = "low")]
        Low,

        [XmlEnum(Name = "high")]
        High,

        [XmlEnum(Name = "constant")]
        Constant
    }

    public enum DtmItemKinds
    {
        alarm,
        analogInput,
        analogOutput,
        computation,
        contained,
        correction,
        device,
        diagnostic,
        digitalInput,
        digitalOutput,
        discrete,
        discreteInput,
        discreteOutput,
        dynamic,
        frequency,
        frequencyInput,
        frequencyOutput,
        hart,
        input,
        local,
        localDisplay,
        operate,
        output,
        sensorCorrection,
        service,
        tune,
        others
    }

    public enum DtmItemTypeKind
    {
        standard,
        specific
    }

    public enum DtmItemErrorDescriptionKind
    {
        dtmSpecific,
        noLock,
        notLongerValid,
        outOfResources,
        invalidValue
    }
}
