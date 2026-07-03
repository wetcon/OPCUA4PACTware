/* ========================================================================
 * Copyright (c) 2005-2024 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;
using Opc.Ua.DI;
using Opc.Ua.IA;

namespace Opc.Ua.DI {}
namespace Opc.Ua.IA {}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA1707 // Identifiers should not contain underscores

namespace Opc.Ua.Machinery
{
    #region Object Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class Objects
    {
        public const uint MachineryEquipmentFolderType_MachineryEquipment_Placeholder = 5052;

        public const uint MonitoringType_Consumption = 5047;

        public const uint MonitoringType_Health = 5045;

        public const uint MonitoringType_Health_DeviceHealthAlarms = 5051;

        public const uint MonitoringType_Process = 5046;

        public const uint MonitoringType_Status = 5044;

        public const uint MonitoringType_Status_MachineryItemState = 5048;

        public const uint MonitoringType_Status_MachineryOperationMode = 5049;

        public const uint MonitoringType_Status_Stacklight = 5050;

        public const uint MachineComponentsType_Component_Placeholder = 5002;

        public const uint MachineComponentsType_Component_Placeholder_Identification = 5003;

        public const uint MachineryItemState_StateMachineType_Executing = 5006;

        public const uint MachineryItemState_StateMachineType_FromExecutingToExecuting = 5023;

        public const uint MachineryItemState_StateMachineType_FromExecutingToNotAvailable = 5020;

        public const uint MachineryItemState_StateMachineType_FromExecutingToNotExecuting = 5022;

        public const uint MachineryItemState_StateMachineType_FromExecutingToOutOfService = 5021;

        public const uint MachineryItemState_StateMachineType_FromNotAvailableToExecuting = 5010;

        public const uint MachineryItemState_StateMachineType_FromNotAvailableToNotAvailable = 5011;

        public const uint MachineryItemState_StateMachineType_FromNotAvailableToNotExecuting = 5009;

        public const uint MachineryItemState_StateMachineType_FromNotAvailableToOutOfService = 5008;

        public const uint MachineryItemState_StateMachineType_FromNotExecutingToExecuting = 5018;

        public const uint MachineryItemState_StateMachineType_FromNotExecutingToNotAvailable = 5016;

        public const uint MachineryItemState_StateMachineType_FromNotExecutingToNotExecuting = 5019;

        public const uint MachineryItemState_StateMachineType_FromNotExecutingToOutOfService = 5017;

        public const uint MachineryItemState_StateMachineType_FromOutOfServiceToExecuting = 5014;

        public const uint MachineryItemState_StateMachineType_FromOutOfServiceToNotAvailable = 5012;

        public const uint MachineryItemState_StateMachineType_FromOutOfServiceToNotExecuting = 5013;

        public const uint MachineryItemState_StateMachineType_FromOutOfServiceToOutOfService = 5015;

        public const uint MachineryItemState_StateMachineType_NotAvailable = 5005;

        public const uint MachineryItemState_StateMachineType_NotExecuting = 5007;

        public const uint MachineryItemState_StateMachineType_OutOfService = 5004;

        public const uint MachineryOperationModeStateMachineType_FromMaintenanceToMaintenance = 5035;

        public const uint MachineryOperationModeStateMachineType_FromMaintenanceToNone = 5032;

        public const uint MachineryOperationModeStateMachineType_FromMaintenanceToProcessing = 5034;

        public const uint MachineryOperationModeStateMachineType_FromMaintenanceToSetup = 5033;

        public const uint MachineryOperationModeStateMachineType_FromNoneToMaintenance = 5028;

        public const uint MachineryOperationModeStateMachineType_FromNoneToNone = 5031;

        public const uint MachineryOperationModeStateMachineType_FromNoneToProcessing = 5030;

        public const uint MachineryOperationModeStateMachineType_FromNoneToSetup = 5029;

        public const uint MachineryOperationModeStateMachineType_FromProcessingToMaintenance = 5041;

        public const uint MachineryOperationModeStateMachineType_FromProcessingToNone = 5040;

        public const uint MachineryOperationModeStateMachineType_FromProcessingToProcessing = 5043;

        public const uint MachineryOperationModeStateMachineType_FromProcessingToSetup = 5042;

        public const uint MachineryOperationModeStateMachineType_FromSetupToMaintenance = 5037;

        public const uint MachineryOperationModeStateMachineType_FromSetupToNone = 5036;

        public const uint MachineryOperationModeStateMachineType_FromSetupToProcessing = 5038;

        public const uint MachineryOperationModeStateMachineType_FromSetupToSetup = 5039;

        public const uint MachineryOperationModeStateMachineType_Maintenance = 5025;

        public const uint MachineryOperationModeStateMachineType_None = 5024;

        public const uint MachineryOperationModeStateMachineType_Processing = 5026;

        public const uint MachineryOperationModeStateMachineType_Setup = 5027;

        public const uint Machines = 1001;

        public const uint http___opcfoundation_org_UA_Machinery_ = 5001;
    }
    #endregion

    #region ObjectType Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class ObjectTypes
    {
        public const uint IMachineTagNameplateType = 1011;

        public const uint IMachineryEquipmentType = 1007;

        public const uint IMachineryItemVendorNameplateType = 1003;

        public const uint IMachineVendorNameplateType = 1010;

        public const uint MachineryItemIdentificationType = 1004;

        public const uint MachineIdentificationType = 1012;

        public const uint MachineryComponentIdentificationType = 1005;

        public const uint MachineryOperationCounterType = 1009;

        public const uint MachineryEquipmentFolderType = 1013;

        public const uint MachineryLifetimeCounterType = 1015;

        public const uint MonitoringType = 1014;

        public const uint NotificationsType = 1017;

        public const uint MachineComponentsType = 1006;

        public const uint MachineryItemState_StateMachineType = 1002;

        public const uint MachineryOperationModeStateMachineType = 1008;
    }
    #endregion

    #region Variable Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class Variables
    {
        public const uint IMachineTagNameplateType_Location = 6028;

        public const uint IMachineryEquipmentType_Description = 6107;

        public const uint IMachineryEquipmentType_EquipmentLife = 6109;

        public const uint IMachineryEquipmentType_EquipmentLife_EngineeringUnits = 6112;

        public const uint IMachineryEquipmentType_EquipmentLife_StartValue = 6111;

        public const uint IMachineryEquipmentType_EquipmentLife_LimitValue = 6110;

        public const uint IMachineryEquipmentType_MachineryEquipmentTypeId = 6108;

        public const uint IMachineryItemVendorNameplateType_Manufacturer = 6022;

        public const uint IMachineryItemVendorNameplateType_SerialNumber = 6024;

        public const uint IMachineryItemVendorNameplateType_InitialOperationDate = 6027;

        public const uint IMachineryItemVendorNameplateType_MonthOfConstruction = 6026;

        public const uint IMachineryItemVendorNameplateType_YearOfConstruction = 6025;

        public const uint IMachineVendorNameplateType_ProductInstanceUri = 6023;

        public const uint MachineryItemIdentificationType_AssetId = 6013;

        public const uint MachineryItemIdentificationType_ComponentName = 6014;

        public const uint MachineryItemIdentificationType_DefaultInstanceBrowseName = 6088;

        public const uint MachineryItemIdentificationType_DeviceClass = 6012;

        public const uint MachineryItemIdentificationType_HardwareRevision = 6010;

        public const uint MachineryItemIdentificationType_InitialOperationDate = 6006;

        public const uint MachineryItemIdentificationType_Manufacturer = 6002;

        public const uint MachineryItemIdentificationType_ManufacturerUri = 6007;

        public const uint MachineryItemIdentificationType_Model = 6008;

        public const uint MachineryItemIdentificationType_MonthOfConstruction = 6005;

        public const uint MachineryItemIdentificationType_ProductCode = 6009;

        public const uint MachineryItemIdentificationType_ProductInstanceUri = 6001;

        public const uint MachineryItemIdentificationType_SerialNumber = 6003;

        public const uint MachineryItemIdentificationType_SoftwareRevision = 6011;

        public const uint MachineryItemIdentificationType_YearOfConstruction = 6004;

        public const uint MachineIdentificationType_DefaultInstanceBrowseName = 6030;

        public const uint MachineIdentificationType_ProductInstanceUri = 6015;

        public const uint MachineIdentificationType_Location = 6029;

        public const uint MachineryComponentIdentificationType_DefaultInstanceBrowseName = 6016;

        public const uint MachineryComponentIdentificationType_DeviceRevision = 6017;

        public const uint MachineryOperationCounterType_DefaultInstanceBrowseName = 6082;

        public const uint MachineryOperationCounterType_OperationCycleCounter = 6081;

        public const uint MachineryOperationCounterType_OperationDuration = 6080;

        public const uint MachineryOperationCounterType_PowerOnDuration = 6079;

        public const uint MachineryEquipmentFolderType_MachineryEquipment_Placeholder_AssetId = 6096;

        public const uint MachineryEquipmentFolderType_MachineryEquipment_Placeholder_ComponentName = 6097;

        public const uint MachineryEquipmentFolderType_MachineryEquipment_Placeholder_Description = 6098;

        public const uint MachineryEquipmentFolderType_MachineryEquipment_Placeholder_DeviceClass = 6099;

        public const uint MachineryEquipmentFolderType_MachineryEquipment_Placeholder_Location = 6100;

        public const uint MachineryEquipmentFolderType_MachineryEquipment_Placeholder_MachineryEquipmentTypeId = 6101;

        public const uint MachineryEquipmentFolderType_MachineryEquipment_Placeholder_ManufacturerUri = 6102;

        public const uint MachineryEquipmentFolderType_MachineryEquipment_Placeholder_Model = 6103;

        public const uint MachineryEquipmentFolderType_MachineryEquipment_Placeholder_SerialNumber = 6104;

        public const uint MachineryEquipmentFolderType_DefaultInstanceBrowseName = 6105;

        public const uint MachineryLifetimeCounterType_LifetimeVariable_Placeholder = 6083;

        public const uint MachineryLifetimeCounterType_LifetimeVariable_Placeholder_EngineeringUnits = 6086;

        public const uint MachineryLifetimeCounterType_LifetimeVariable_Placeholder_StartValue = 6085;

        public const uint MachineryLifetimeCounterType_LifetimeVariable_Placeholder_LimitValue = 6084;

        public const uint MachineryLifetimeCounterType_DefaultInstanceBrowseName = 6087;

        public const uint MonitoringType_DefaultInstanceBrowseName = 6089;

        public const uint MonitoringType_Health_DeviceHealth = 6095;

        public const uint MonitoringType_Status_MachineryItemState_CurrentState = 6090;

        public const uint MonitoringType_Status_MachineryItemState_CurrentState_Id = 6091;

        public const uint MonitoringType_Status_MachineryOperationMode_CurrentState = 6092;

        public const uint MonitoringType_Status_MachineryOperationMode_CurrentState_Id = 6093;

        public const uint MonitoringType_Status_Stacklight_StackLevel_DisplayMode = 6034;

        public const uint MonitoringType_Status_Stacklight_StackLevel_LevelPercent = 6035;

        public const uint MonitoringType_Status_Stacklight_StackLevel_LevelPercent_EURange = 6036;

        public const uint MonitoringType_Status_Stacklight_StacklightMode = 6094;

        public const uint NotificationsType_DefaultInstanceBrowseName = 6106;

        public const uint MachineComponentsType_Component_Placeholder_Identification_Manufacturer = 6019;

        public const uint MachineComponentsType_Component_Placeholder_Identification_SerialNumber = 6020;

        public const uint MachineComponentsType_DefaultInstanceBrowseName = 6018;

        public const uint MachineryItemState_StateMachineType_DefaultInstanceBrowseName = 6021;

        public const uint MachineryItemState_StateMachineType_Executing_StateNumber = 6040;

        public const uint MachineryItemState_StateMachineType_FromExecutingToExecuting_TransitionNumber = 6057;

        public const uint MachineryItemState_StateMachineType_FromExecutingToNotAvailable_TransitionNumber = 6054;

        public const uint MachineryItemState_StateMachineType_FromExecutingToNotExecuting_TransitionNumber = 6056;

        public const uint MachineryItemState_StateMachineType_FromExecutingToOutOfService_TransitionNumber = 6055;

        public const uint MachineryItemState_StateMachineType_FromNotAvailableToExecuting_TransitionNumber = 6044;

        public const uint MachineryItemState_StateMachineType_FromNotAvailableToNotAvailable_TransitionNumber = 6045;

        public const uint MachineryItemState_StateMachineType_FromNotAvailableToNotExecuting_TransitionNumber = 6043;

        public const uint MachineryItemState_StateMachineType_FromNotAvailableToOutOfService_TransitionNumber = 6042;

        public const uint MachineryItemState_StateMachineType_FromNotExecutingToExecuting_TransitionNumber = 6052;

        public const uint MachineryItemState_StateMachineType_FromNotExecutingToNotAvailable_TransitionNumber = 6050;

        public const uint MachineryItemState_StateMachineType_FromNotExecutingToNotExecuting_TransitionNumber = 6053;

        public const uint MachineryItemState_StateMachineType_FromNotExecutingToOutOfService_TransitionNumber = 6051;

        public const uint MachineryItemState_StateMachineType_FromOutOfServiceToExecuting_TransitionNumber = 6048;

        public const uint MachineryItemState_StateMachineType_FromOutOfServiceToNotAvailable_TransitionNumber = 6046;

        public const uint MachineryItemState_StateMachineType_FromOutOfServiceToNotExecuting_TransitionNumber = 6047;

        public const uint MachineryItemState_StateMachineType_FromOutOfServiceToOutOfService_TransitionNumber = 6049;

        public const uint MachineryItemState_StateMachineType_NotAvailable_StateNumber = 6039;

        public const uint MachineryItemState_StateMachineType_NotExecuting_StateNumber = 6041;

        public const uint MachineryItemState_StateMachineType_OutOfService_StateNumber = 6038;

        public const uint MachineryOperationModeStateMachineType_DefaultInstanceBrowseName = 6058;

        public const uint MachineryOperationModeStateMachineType_FromMaintenanceToMaintenance_TransitionNumber = 6070;

        public const uint MachineryOperationModeStateMachineType_FromMaintenanceToNone_TransitionNumber = 6067;

        public const uint MachineryOperationModeStateMachineType_FromMaintenanceToProcessing_TransitionNumber = 6069;

        public const uint MachineryOperationModeStateMachineType_FromMaintenanceToSetup_TransitionNumber = 6068;

        public const uint MachineryOperationModeStateMachineType_FromNoneToMaintenance_TransitionNumber = 6063;

        public const uint MachineryOperationModeStateMachineType_FromNoneToNone_TransitionNumber = 6066;

        public const uint MachineryOperationModeStateMachineType_FromNoneToProcessing_TransitionNumber = 6065;

        public const uint MachineryOperationModeStateMachineType_FromNoneToSetup_TransitionNumber = 6064;

        public const uint MachineryOperationModeStateMachineType_FromProcessingToMaintenance_TransitionNumber = 6076;

        public const uint MachineryOperationModeStateMachineType_FromProcessingToNone_TransitionNumber = 6075;

        public const uint MachineryOperationModeStateMachineType_FromProcessingToProcessing_TransitionNumber = 6078;

        public const uint MachineryOperationModeStateMachineType_FromProcessingToSetup_TransitionNumber = 6077;

        public const uint MachineryOperationModeStateMachineType_FromSetupToMaintenance_TransitionNumber = 6072;

        public const uint MachineryOperationModeStateMachineType_FromSetupToNone_TransitionNumber = 6071;

        public const uint MachineryOperationModeStateMachineType_FromSetupToProcessing_TransitionNumber = 6073;

        public const uint MachineryOperationModeStateMachineType_FromSetupToSetup_TransitionNumber = 6074;

        public const uint MachineryOperationModeStateMachineType_Maintenance_StateNumber = 6060;

        public const uint MachineryOperationModeStateMachineType_None_StateNumber = 6059;

        public const uint MachineryOperationModeStateMachineType_Processing_StateNumber = 6061;

        public const uint MachineryOperationModeStateMachineType_Setup_StateNumber = 6062;

        public const uint http___opcfoundation_org_UA_Machinery__NamespaceUri = 6033;

        public const uint http___opcfoundation_org_UA_Machinery__NamespaceVersion = 6034;

        public const uint http___opcfoundation_org_UA_Machinery__NamespacePublicationDate = 6032;

        public const uint http___opcfoundation_org_UA_Machinery__IsNamespaceSubset = 6031;

        public const uint http___opcfoundation_org_UA_Machinery__StaticNodeIdTypes = 6035;

        public const uint http___opcfoundation_org_UA_Machinery__StaticNumericNodeIdRange = 6036;

        public const uint http___opcfoundation_org_UA_Machinery__StaticStringNodeIdPattern = 6037;
    }
    #endregion

    #region Object Node Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class ObjectIds
    {
        public static readonly ExpandedNodeId MachineryEquipmentFolderType_MachineryEquipment_Placeholder = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryEquipmentFolderType_MachineryEquipment_Placeholder, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MonitoringType_Consumption = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MonitoringType_Consumption, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MonitoringType_Health = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MonitoringType_Health, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MonitoringType_Health_DeviceHealthAlarms = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MonitoringType_Health_DeviceHealthAlarms, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MonitoringType_Process = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MonitoringType_Process, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MonitoringType_Status = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MonitoringType_Status, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MonitoringType_Status_MachineryItemState = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MonitoringType_Status_MachineryItemState, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MonitoringType_Status_MachineryOperationMode = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MonitoringType_Status_MachineryOperationMode, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MonitoringType_Status_Stacklight = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MonitoringType_Status_Stacklight, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineComponentsType_Component_Placeholder = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineComponentsType_Component_Placeholder, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineComponentsType_Component_Placeholder_Identification = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineComponentsType_Component_Placeholder_Identification, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_Executing = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_Executing, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromExecutingToExecuting = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromExecutingToExecuting, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromExecutingToNotAvailable = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromExecutingToNotAvailable, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromExecutingToNotExecuting = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromExecutingToNotExecuting, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromExecutingToOutOfService = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromExecutingToOutOfService, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotAvailableToExecuting = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromNotAvailableToExecuting, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotAvailableToNotAvailable = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromNotAvailableToNotAvailable, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotAvailableToNotExecuting = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromNotAvailableToNotExecuting, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotAvailableToOutOfService = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromNotAvailableToOutOfService, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotExecutingToExecuting = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromNotExecutingToExecuting, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotExecutingToNotAvailable = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromNotExecutingToNotAvailable, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotExecutingToNotExecuting = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromNotExecutingToNotExecuting, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotExecutingToOutOfService = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromNotExecutingToOutOfService, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromOutOfServiceToExecuting = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromOutOfServiceToExecuting, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromOutOfServiceToNotAvailable = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromOutOfServiceToNotAvailable, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromOutOfServiceToNotExecuting = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromOutOfServiceToNotExecuting, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromOutOfServiceToOutOfService = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_FromOutOfServiceToOutOfService, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_NotAvailable = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_NotAvailable, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_NotExecuting = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_NotExecuting, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_OutOfService = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryItemState_StateMachineType_OutOfService, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromMaintenanceToMaintenance = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromMaintenanceToMaintenance, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromMaintenanceToNone = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromMaintenanceToNone, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromMaintenanceToProcessing = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromMaintenanceToProcessing, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromMaintenanceToSetup = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromMaintenanceToSetup, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromNoneToMaintenance = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromNoneToMaintenance, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromNoneToNone = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromNoneToNone, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromNoneToProcessing = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromNoneToProcessing, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromNoneToSetup = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromNoneToSetup, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromProcessingToMaintenance = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromProcessingToMaintenance, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromProcessingToNone = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromProcessingToNone, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromProcessingToProcessing = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromProcessingToProcessing, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromProcessingToSetup = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromProcessingToSetup, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromSetupToMaintenance = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromSetupToMaintenance, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromSetupToNone = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromSetupToNone, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromSetupToProcessing = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromSetupToProcessing, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromSetupToSetup = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_FromSetupToSetup, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_Maintenance = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_Maintenance, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_None = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_None, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_Processing = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_Processing, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_Setup = new ExpandedNodeId(Opc.Ua.Machinery.Objects.MachineryOperationModeStateMachineType_Setup, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId Machines = new ExpandedNodeId(Opc.Ua.Machinery.Objects.Machines, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId http___opcfoundation_org_UA_Machinery_ = new ExpandedNodeId(Opc.Ua.Machinery.Objects.http___opcfoundation_org_UA_Machinery_, Opc.Ua.Machinery.Namespaces.Machinery);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class ObjectTypeIds
    {
        public static readonly ExpandedNodeId IMachineTagNameplateType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.IMachineTagNameplateType, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId IMachineryEquipmentType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.IMachineryEquipmentType, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId IMachineryItemVendorNameplateType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.IMachineryItemVendorNameplateType, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId IMachineVendorNameplateType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.IMachineVendorNameplateType, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemIdentificationType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.MachineryItemIdentificationType, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineIdentificationType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.MachineIdentificationType, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryComponentIdentificationType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.MachineryComponentIdentificationType, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationCounterType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.MachineryOperationCounterType, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryEquipmentFolderType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.MachineryEquipmentFolderType, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryLifetimeCounterType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.MachineryLifetimeCounterType, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MonitoringType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.MonitoringType, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId NotificationsType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.NotificationsType, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineComponentsType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.MachineComponentsType, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.MachineryItemState_StateMachineType, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType = new ExpandedNodeId(Opc.Ua.Machinery.ObjectTypes.MachineryOperationModeStateMachineType, Opc.Ua.Machinery.Namespaces.Machinery);
    }
    #endregion

    #region Variable Node Identifiers
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class VariableIds
    {
        public static readonly ExpandedNodeId IMachineTagNameplateType_Location = new ExpandedNodeId(Opc.Ua.Machinery.Variables.IMachineTagNameplateType_Location, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId IMachineryEquipmentType_Description = new ExpandedNodeId(Opc.Ua.Machinery.Variables.IMachineryEquipmentType_Description, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId IMachineryEquipmentType_EquipmentLife = new ExpandedNodeId(Opc.Ua.Machinery.Variables.IMachineryEquipmentType_EquipmentLife, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId IMachineryEquipmentType_EquipmentLife_EngineeringUnits = new ExpandedNodeId(Opc.Ua.Machinery.Variables.IMachineryEquipmentType_EquipmentLife_EngineeringUnits, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId IMachineryEquipmentType_EquipmentLife_StartValue = new ExpandedNodeId(Opc.Ua.Machinery.Variables.IMachineryEquipmentType_EquipmentLife_StartValue, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId IMachineryEquipmentType_EquipmentLife_LimitValue = new ExpandedNodeId(Opc.Ua.Machinery.Variables.IMachineryEquipmentType_EquipmentLife_LimitValue, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId IMachineryEquipmentType_MachineryEquipmentTypeId = new ExpandedNodeId(Opc.Ua.Machinery.Variables.IMachineryEquipmentType_MachineryEquipmentTypeId, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId IMachineryItemVendorNameplateType_Manufacturer = new ExpandedNodeId(Opc.Ua.Machinery.Variables.IMachineryItemVendorNameplateType_Manufacturer, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId IMachineryItemVendorNameplateType_SerialNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.IMachineryItemVendorNameplateType_SerialNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId IMachineryItemVendorNameplateType_InitialOperationDate = new ExpandedNodeId(Opc.Ua.Machinery.Variables.IMachineryItemVendorNameplateType_InitialOperationDate, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId IMachineryItemVendorNameplateType_MonthOfConstruction = new ExpandedNodeId(Opc.Ua.Machinery.Variables.IMachineryItemVendorNameplateType_MonthOfConstruction, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId IMachineryItemVendorNameplateType_YearOfConstruction = new ExpandedNodeId(Opc.Ua.Machinery.Variables.IMachineryItemVendorNameplateType_YearOfConstruction, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId IMachineVendorNameplateType_ProductInstanceUri = new ExpandedNodeId(Opc.Ua.Machinery.Variables.IMachineVendorNameplateType_ProductInstanceUri, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemIdentificationType_AssetId = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_AssetId, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemIdentificationType_ComponentName = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_ComponentName, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemIdentificationType_DefaultInstanceBrowseName = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_DefaultInstanceBrowseName, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemIdentificationType_DeviceClass = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_DeviceClass, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemIdentificationType_HardwareRevision = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_HardwareRevision, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemIdentificationType_InitialOperationDate = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_InitialOperationDate, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemIdentificationType_Manufacturer = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_Manufacturer, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemIdentificationType_ManufacturerUri = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_ManufacturerUri, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemIdentificationType_Model = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_Model, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemIdentificationType_MonthOfConstruction = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_MonthOfConstruction, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemIdentificationType_ProductCode = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_ProductCode, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemIdentificationType_ProductInstanceUri = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_ProductInstanceUri, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemIdentificationType_SerialNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_SerialNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemIdentificationType_SoftwareRevision = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_SoftwareRevision, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemIdentificationType_YearOfConstruction = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemIdentificationType_YearOfConstruction, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineIdentificationType_DefaultInstanceBrowseName = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineIdentificationType_DefaultInstanceBrowseName, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineIdentificationType_ProductInstanceUri = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineIdentificationType_ProductInstanceUri, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineIdentificationType_Location = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineIdentificationType_Location, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryComponentIdentificationType_DefaultInstanceBrowseName = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryComponentIdentificationType_DefaultInstanceBrowseName, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryComponentIdentificationType_DeviceRevision = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryComponentIdentificationType_DeviceRevision, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationCounterType_DefaultInstanceBrowseName = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationCounterType_DefaultInstanceBrowseName, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationCounterType_OperationCycleCounter = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationCounterType_OperationCycleCounter, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationCounterType_OperationDuration = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationCounterType_OperationDuration, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationCounterType_PowerOnDuration = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationCounterType_PowerOnDuration, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryEquipmentFolderType_MachineryEquipment_Placeholder_AssetId = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryEquipmentFolderType_MachineryEquipment_Placeholder_AssetId, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryEquipmentFolderType_MachineryEquipment_Placeholder_ComponentName = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryEquipmentFolderType_MachineryEquipment_Placeholder_ComponentName, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryEquipmentFolderType_MachineryEquipment_Placeholder_Description = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryEquipmentFolderType_MachineryEquipment_Placeholder_Description, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryEquipmentFolderType_MachineryEquipment_Placeholder_DeviceClass = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryEquipmentFolderType_MachineryEquipment_Placeholder_DeviceClass, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryEquipmentFolderType_MachineryEquipment_Placeholder_Location = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryEquipmentFolderType_MachineryEquipment_Placeholder_Location, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryEquipmentFolderType_MachineryEquipment_Placeholder_MachineryEquipmentTypeId = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryEquipmentFolderType_MachineryEquipment_Placeholder_MachineryEquipmentTypeId, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryEquipmentFolderType_MachineryEquipment_Placeholder_ManufacturerUri = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryEquipmentFolderType_MachineryEquipment_Placeholder_ManufacturerUri, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryEquipmentFolderType_MachineryEquipment_Placeholder_Model = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryEquipmentFolderType_MachineryEquipment_Placeholder_Model, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryEquipmentFolderType_MachineryEquipment_Placeholder_SerialNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryEquipmentFolderType_MachineryEquipment_Placeholder_SerialNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryEquipmentFolderType_DefaultInstanceBrowseName = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryEquipmentFolderType_DefaultInstanceBrowseName, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryLifetimeCounterType_LifetimeVariable_Placeholder = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryLifetimeCounterType_LifetimeVariable_Placeholder, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryLifetimeCounterType_LifetimeVariable_Placeholder_EngineeringUnits = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryLifetimeCounterType_LifetimeVariable_Placeholder_EngineeringUnits, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryLifetimeCounterType_LifetimeVariable_Placeholder_StartValue = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryLifetimeCounterType_LifetimeVariable_Placeholder_StartValue, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryLifetimeCounterType_LifetimeVariable_Placeholder_LimitValue = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryLifetimeCounterType_LifetimeVariable_Placeholder_LimitValue, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryLifetimeCounterType_DefaultInstanceBrowseName = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryLifetimeCounterType_DefaultInstanceBrowseName, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MonitoringType_DefaultInstanceBrowseName = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MonitoringType_DefaultInstanceBrowseName, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MonitoringType_Health_DeviceHealth = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MonitoringType_Health_DeviceHealth, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MonitoringType_Status_MachineryItemState_CurrentState = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MonitoringType_Status_MachineryItemState_CurrentState, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MonitoringType_Status_MachineryItemState_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MonitoringType_Status_MachineryItemState_CurrentState_Id, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MonitoringType_Status_MachineryOperationMode_CurrentState = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MonitoringType_Status_MachineryOperationMode_CurrentState, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MonitoringType_Status_MachineryOperationMode_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MonitoringType_Status_MachineryOperationMode_CurrentState_Id, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MonitoringType_Status_Stacklight_StackLevel_DisplayMode = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MonitoringType_Status_Stacklight_StackLevel_DisplayMode, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MonitoringType_Status_Stacklight_StackLevel_LevelPercent = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MonitoringType_Status_Stacklight_StackLevel_LevelPercent, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MonitoringType_Status_Stacklight_StackLevel_LevelPercent_EURange = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MonitoringType_Status_Stacklight_StackLevel_LevelPercent_EURange, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MonitoringType_Status_Stacklight_StacklightMode = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MonitoringType_Status_Stacklight_StacklightMode, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId NotificationsType_DefaultInstanceBrowseName = new ExpandedNodeId(Opc.Ua.Machinery.Variables.NotificationsType_DefaultInstanceBrowseName, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineComponentsType_Component_Placeholder_Identification_Manufacturer = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineComponentsType_Component_Placeholder_Identification_Manufacturer, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineComponentsType_Component_Placeholder_Identification_SerialNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineComponentsType_Component_Placeholder_Identification_SerialNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineComponentsType_DefaultInstanceBrowseName = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineComponentsType_DefaultInstanceBrowseName, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_DefaultInstanceBrowseName = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_DefaultInstanceBrowseName, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_Executing_StateNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_Executing_StateNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromExecutingToExecuting_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromExecutingToExecuting_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromExecutingToNotAvailable_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromExecutingToNotAvailable_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromExecutingToNotExecuting_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromExecutingToNotExecuting_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromExecutingToOutOfService_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromExecutingToOutOfService_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotAvailableToExecuting_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromNotAvailableToExecuting_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotAvailableToNotAvailable_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromNotAvailableToNotAvailable_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotAvailableToNotExecuting_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromNotAvailableToNotExecuting_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotAvailableToOutOfService_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromNotAvailableToOutOfService_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotExecutingToExecuting_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromNotExecutingToExecuting_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotExecutingToNotAvailable_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromNotExecutingToNotAvailable_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotExecutingToNotExecuting_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromNotExecutingToNotExecuting_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromNotExecutingToOutOfService_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromNotExecutingToOutOfService_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromOutOfServiceToExecuting_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromOutOfServiceToExecuting_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromOutOfServiceToNotAvailable_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromOutOfServiceToNotAvailable_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromOutOfServiceToNotExecuting_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromOutOfServiceToNotExecuting_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_FromOutOfServiceToOutOfService_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_FromOutOfServiceToOutOfService_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_NotAvailable_StateNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_NotAvailable_StateNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_NotExecuting_StateNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_NotExecuting_StateNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryItemState_StateMachineType_OutOfService_StateNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryItemState_StateMachineType_OutOfService_StateNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_DefaultInstanceBrowseName = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_DefaultInstanceBrowseName, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromMaintenanceToMaintenance_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromMaintenanceToMaintenance_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromMaintenanceToNone_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromMaintenanceToNone_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromMaintenanceToProcessing_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromMaintenanceToProcessing_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromMaintenanceToSetup_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromMaintenanceToSetup_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromNoneToMaintenance_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromNoneToMaintenance_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromNoneToNone_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromNoneToNone_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromNoneToProcessing_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromNoneToProcessing_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromNoneToSetup_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromNoneToSetup_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromProcessingToMaintenance_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromProcessingToMaintenance_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromProcessingToNone_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromProcessingToNone_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromProcessingToProcessing_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromProcessingToProcessing_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromProcessingToSetup_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromProcessingToSetup_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromSetupToMaintenance_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromSetupToMaintenance_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromSetupToNone_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromSetupToNone_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromSetupToProcessing_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromSetupToProcessing_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_FromSetupToSetup_TransitionNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_FromSetupToSetup_TransitionNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_Maintenance_StateNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_Maintenance_StateNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_None_StateNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_None_StateNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_Processing_StateNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_Processing_StateNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId MachineryOperationModeStateMachineType_Setup_StateNumber = new ExpandedNodeId(Opc.Ua.Machinery.Variables.MachineryOperationModeStateMachineType_Setup_StateNumber, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId http___opcfoundation_org_UA_Machinery__NamespaceUri = new ExpandedNodeId(Opc.Ua.Machinery.Variables.http___opcfoundation_org_UA_Machinery__NamespaceUri, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId http___opcfoundation_org_UA_Machinery__NamespaceVersion = new ExpandedNodeId(Opc.Ua.Machinery.Variables.http___opcfoundation_org_UA_Machinery__NamespaceVersion, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId http___opcfoundation_org_UA_Machinery__NamespacePublicationDate = new ExpandedNodeId(Opc.Ua.Machinery.Variables.http___opcfoundation_org_UA_Machinery__NamespacePublicationDate, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId http___opcfoundation_org_UA_Machinery__IsNamespaceSubset = new ExpandedNodeId(Opc.Ua.Machinery.Variables.http___opcfoundation_org_UA_Machinery__IsNamespaceSubset, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId http___opcfoundation_org_UA_Machinery__StaticNodeIdTypes = new ExpandedNodeId(Opc.Ua.Machinery.Variables.http___opcfoundation_org_UA_Machinery__StaticNodeIdTypes, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId http___opcfoundation_org_UA_Machinery__StaticNumericNodeIdRange = new ExpandedNodeId(Opc.Ua.Machinery.Variables.http___opcfoundation_org_UA_Machinery__StaticNumericNodeIdRange, Opc.Ua.Machinery.Namespaces.Machinery);

        public static readonly ExpandedNodeId http___opcfoundation_org_UA_Machinery__StaticStringNodeIdPattern = new ExpandedNodeId(Opc.Ua.Machinery.Variables.http___opcfoundation_org_UA_Machinery__StaticStringNodeIdPattern, Opc.Ua.Machinery.Namespaces.Machinery);
    }
    #endregion

    #region BrowseName Declarations
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class BrowseNames
    {
        public const string Component_Placeholder = "<Component>";

        public const string Components = "Components";

        public const string Consumption = "Consumption";

        public const string Description = "Description";

        public const string EquipmentLife = "EquipmentLife";

        public const string Executing = "Executing";

        public const string FromExecutingToExecuting = "FromExecutingToExecuting";

        public const string FromExecutingToNotAvailable = "FromExecutingToNotAvailable";

        public const string FromExecutingToNotExecuting = "FromExecutingToNotExecuting";

        public const string FromExecutingToOutOfService = "FromExecutingToOutOfService";

        public const string FromMaintenanceToMaintenance = "FromMaintenanceToMaintenance";

        public const string FromMaintenanceToNone = "FromMaintenanceToNone";

        public const string FromMaintenanceToProcessing = "FromMaintenanceToProcessing";

        public const string FromMaintenanceToSetup = "FromMaintenanceToSetup";

        public const string FromNoneToMaintenance = "FromNoneToMaintenance";

        public const string FromNoneToNone = "FromNoneToNone";

        public const string FromNoneToProcessing = "FromNoneToProcessing";

        public const string FromNoneToSetup = "FromNoneToSetup";

        public const string FromNotAvailableToExecuting = "FromNotAvailableToExecuting";

        public const string FromNotAvailableToNotAvailable = "FromNotAvailableToNotAvailable";

        public const string FromNotAvailableToNotExecuting = "FromNotAvailableToNotExecuting";

        public const string FromNotAvailableToOutOfService = "FromNotAvailableToOutOfService";

        public const string FromNotExecutingToExecuting = "FromNotExecutingToExecuting";

        public const string FromNotExecutingToNotAvailable = "FromNotExecutingToNotAvailable";

        public const string FromNotExecutingToNotExecuting = "FromNotExecutingToNotExecuting";

        public const string FromNotExecutingToOutOfService = "FromNotExecutingToOutOfService";

        public const string FromOutOfServiceToExecuting = "FromOutOfServiceToExecuting";

        public const string FromOutOfServiceToNotAvailable = "FromOutOfServiceToNotAvailable";

        public const string FromOutOfServiceToNotExecuting = "FromOutOfServiceToNotExecuting";

        public const string FromOutOfServiceToOutOfService = "FromOutOfServiceToOutOfService";

        public const string FromProcessingToMaintenance = "FromProcessingToMaintenance";

        public const string FromProcessingToNone = "FromProcessingToNone";

        public const string FromProcessingToProcessing = "FromProcessingToProcessing";

        public const string FromProcessingToSetup = "FromProcessingToSetup";

        public const string FromSetupToMaintenance = "FromSetupToMaintenance";

        public const string FromSetupToNone = "FromSetupToNone";

        public const string FromSetupToProcessing = "FromSetupToProcessing";

        public const string FromSetupToSetup = "FromSetupToSetup";

        public const string Health = "Health";

        public const string http___opcfoundation_org_UA_Machinery_ = "http://opcfoundation.org/UA/Machinery/";

        public const string Identification = "Identification";

        public const string IMachineryEquipmentType = "IMachineryEquipmentType";

        public const string IMachineryItemVendorNameplateType = "IMachineryItemVendorNameplateType";

        public const string IMachineTagNameplateType = "IMachineTagNameplateType";

        public const string IMachineVendorNameplateType = "IMachineVendorNameplateType";

        public const string InitialOperationDate = "InitialOperationDate";

        public const string LifetimeCounters = "LifetimeCounters";

        public const string LifetimeVariable_Placeholder = "<LifetimeVariable>";

        public const string Location = "Location";

        public const string MachineComponentsType = "MachineComponentsType";

        public const string MachineIdentificationType = "MachineIdentificationType";

        public const string MachineryComponentIdentificationType = "MachineryComponentIdentificationType";

        public const string MachineryEquipment = "MachineryEquipment";

        public const string MachineryEquipment_Placeholder = "<MachineryEquipment>";

        public const string MachineryEquipmentFolderType = "MachineryEquipmentFolderType";

        public const string MachineryEquipmentTypeId = "MachineryEquipmentTypeId";

        public const string MachineryItemIdentificationType = "MachineryItemIdentificationType";

        public const string MachineryItemState = "MachineryItemState";

        public const string MachineryItemState_StateMachineType = "MachineryItemState_StateMachineType";

        public const string MachineryLifetimeCounterType = "MachineryLifetimeCounterType";

        public const string MachineryOperationCounterType = "MachineryOperationCounterType";

        public const string MachineryOperationMode = "MachineryOperationMode";

        public const string MachineryOperationModeStateMachineType = "MachineryOperationModeStateMachineType";

        public const string Machines = "Machines";

        public const string Maintenance = "Maintenance";

        public const string Monitoring = "Monitoring";

        public const string MonitoringType = "MonitoringType";

        public const string MonthOfConstruction = "MonthOfConstruction";

        public const string None = "None";

        public const string NotAvailable = "NotAvailable";

        public const string NotExecuting = "NotExecuting";

        public const string Notifications = "Notifications";

        public const string NotificationsType = "NotificationsType";

        public const string OperationCounters = "OperationCounters";

        public const string OutOfService = "OutOfService";

        public const string Process = "Process";

        public const string Processing = "Processing";

        public const string Setup = "Setup";

        public const string Stacklight = "Stacklight";

        public const string Status = "Status";

        public const string YearOfConstruction = "YearOfConstruction";
    }
    #endregion

    #region Namespace Declarations
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the Machinery namespace (.NET code namespace is 'Opc.Ua.Machinery').
        /// </summary>
        public const string Machinery = "http://opcfoundation.org/UA/Machinery/";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the DI namespace (.NET code namespace is 'Opc.Ua.DI').
        /// </summary>
        public const string DI = "http://opcfoundation.org/UA/DI/";

        /// <summary>
        /// The URI for the IA namespace (.NET code namespace is 'Opc.Ua.IA').
        /// </summary>
        public const string IA = "http://opcfoundation.org/UA/IA/";
    }
    #endregion
}