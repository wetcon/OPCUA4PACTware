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
using System.Xml;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Threading;
using Opc.Ua;
using Opc.Ua.DI;
using Opc.Ua.Machinery;

namespace Opc.Ua.DI {}
namespace Opc.Ua.Machinery {}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA1515 // Consider making public types internal
#pragma warning disable CA1707 // Identifiers should not contain underscores
#pragma warning disable CA1028 // Enum Storage should be Int32

namespace Opc.Ua.Pumps
{
    #region ControlModeEnum Enumeration
    #if (!OPCUA_EXCLUDE_ControlModeEnum)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Pumps.Namespaces.Pumps)]
    
    public enum ControlModeEnum
    {
        [EnumMember(Value = "ConstantPressureControl_0")]
        ConstantPressureControl = 0,

        [EnumMember(Value = "ConstantTemperatureControl_1")]
        ConstantTemperatureControl = 1,

        [EnumMember(Value = "DifferentialPressureControl_2")]
        DifferentialPressureControl = 2,

        [EnumMember(Value = "ConstantDifferentialPressureControl_3")]
        ConstantDifferentialPressureControl = 3,

        [EnumMember(Value = "VariableDifferentialPressureControl_4")]
        VariableDifferentialPressureControl = 4,

        [EnumMember(Value = "FlowDependentDifferentialPressureControl_5")]
        FlowDependentDifferentialPressureControl = 5,

        [EnumMember(Value = "ReturnFlowTemperatureControl_6")]
        ReturnFlowTemperatureControl = 6,

        [EnumMember(Value = "FlowTemperatureControl_7")]
        FlowTemperatureControl = 7,

        [EnumMember(Value = "FlowRateControl_8")]
        FlowRateControl = 8,

        [EnumMember(Value = "SpeedControl_9")]
        SpeedControl = 9,

        [EnumMember(Value = "Automatic_10")]
        Automatic = 10,

        [EnumMember(Value = "Uncontrolled_11")]
        Uncontrolled = 11,
    }

    #region ControlModeEnumCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfControlModeEnum", Namespace = Opc.Ua.Pumps.Namespaces.Pumps, ItemName = "ControlModeEnum")]
    public partial class ControlModeEnumCollection : List<ControlModeEnum>, ICloneable
    {
        #region Constructors
        public ControlModeEnumCollection() {}

        public ControlModeEnumCollection(int capacity) : base(capacity) {}

        public ControlModeEnumCollection(IEnumerable<ControlModeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator ControlModeEnumCollection(ControlModeEnum[] values)
        {
            if (values != null)
            {
                return new ControlModeEnumCollection(values);
            }

            return new ControlModeEnumCollection();
        }

        public static explicit operator ControlModeEnum[](ControlModeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (ControlModeEnumCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ControlModeEnumCollection clone = new ControlModeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ControlModeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region DistributionTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_DistributionTypeEnum)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Pumps.Namespaces.Pumps)]
    
    public enum DistributionTypeEnum
    {
        [EnumMember(Value = "ManufacturerSpecific_0")]
        ManufacturerSpecific = 0,

        [EnumMember(Value = "OperatorSpecific_1")]
        OperatorSpecific = 1,

        [EnumMember(Value = "ConcerningTimeDistribution_2")]
        ConcerningTimeDistribution = 2,

        [EnumMember(Value = "ConcerningLoadDistribution_3")]
        ConcerningLoadDistribution = 3,
    }

    #region DistributionTypeEnumCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfDistributionTypeEnum", Namespace = Opc.Ua.Pumps.Namespaces.Pumps, ItemName = "DistributionTypeEnum")]
    public partial class DistributionTypeEnumCollection : List<DistributionTypeEnum>, ICloneable
    {
        #region Constructors
        public DistributionTypeEnumCollection() {}

        public DistributionTypeEnumCollection(int capacity) : base(capacity) {}

        public DistributionTypeEnumCollection(IEnumerable<DistributionTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator DistributionTypeEnumCollection(DistributionTypeEnum[] values)
        {
            if (values != null)
            {
                return new DistributionTypeEnumCollection(values);
            }

            return new DistributionTypeEnumCollection();
        }

        public static explicit operator DistributionTypeEnum[](DistributionTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (DistributionTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DistributionTypeEnumCollection clone = new DistributionTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((DistributionTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ExchangeModeEnum Enumeration
    #if (!OPCUA_EXCLUDE_ExchangeModeEnum)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Pumps.Namespaces.Pumps)]
    
    public enum ExchangeModeEnum
    {
        [EnumMember(Value = "ManufacturerSpecific_0")]
        ManufacturerSpecific = 0,

        [EnumMember(Value = "ExchangeDisabled_1")]
        ExchangeDisabled = 1,

        [EnumMember(Value = "OperatorSpecific_2")]
        OperatorSpecific = 2,
    }

    #region ExchangeModeEnumCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfExchangeModeEnum", Namespace = Opc.Ua.Pumps.Namespaces.Pumps, ItemName = "ExchangeModeEnum")]
    public partial class ExchangeModeEnumCollection : List<ExchangeModeEnum>, ICloneable
    {
        #region Constructors
        public ExchangeModeEnumCollection() {}

        public ExchangeModeEnumCollection(int capacity) : base(capacity) {}

        public ExchangeModeEnumCollection(IEnumerable<ExchangeModeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator ExchangeModeEnumCollection(ExchangeModeEnum[] values)
        {
            if (values != null)
            {
                return new ExchangeModeEnumCollection(values);
            }

            return new ExchangeModeEnumCollection();
        }

        public static explicit operator ExchangeModeEnum[](ExchangeModeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (ExchangeModeEnumCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ExchangeModeEnumCollection clone = new ExchangeModeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ExchangeModeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region FieldbusEnum Enumeration
    #if (!OPCUA_EXCLUDE_FieldbusEnum)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Pumps.Namespaces.Pumps)]
    
    public enum FieldbusEnum
    {
        [EnumMember(Value = "Other_0")]
        Other = 0,

        [EnumMember(Value = "ARCNET_1")]
        ARCNET = 1,

        [EnumMember(Value = "AS_Interface_2")]
        AS_Interface = 2,

        [EnumMember(Value = "BACnet_IP_3")]
        BACnet_IP = 3,

        [EnumMember(Value = "BACnet_MSTP_4")]
        BACnet_MSTP = 4,

        [EnumMember(Value = "Bluetooth_5")]
        Bluetooth = 5,

        [EnumMember(Value = "BluetoothLowEnergy_6")]
        BluetoothLowEnergy = 6,

        [EnumMember(Value = "CAN_7")]
        CAN = 7,

        [EnumMember(Value = "CANopen_8")]
        CANopen = 8,

        [EnumMember(Value = "CC_Link_9")]
        CC_Link = 9,

        [EnumMember(Value = "ControlNet_10")]
        ControlNet = 10,

        [EnumMember(Value = "DALI_11")]
        DALI = 11,

        [EnumMember(Value = "DECTULE_12")]
        DECTULE = 12,

        [EnumMember(Value = "DeviceNet_13")]
        DeviceNet = 13,

        [EnumMember(Value = "DMX_14")]
        DMX = 14,

        [EnumMember(Value = "KNX_15")]
        KNX = 15,

        [EnumMember(Value = "EnOcean_16")]
        EnOcean = 16,

        [EnumMember(Value = "EtherCAT_17")]
        EtherCAT = 17,

        [EnumMember(Value = "Ethernet_IP_18")]
        Ethernet_IP = 18,

        [EnumMember(Value = "EthernetTCP_IP_19")]
        EthernetTCP_IP = 19,

        [EnumMember(Value = "IEEE1588_20")]
        IEEE1588 = 20,

        [EnumMember(Value = "GSM_21")]
        GSM = 21,

        [EnumMember(Value = "Interbus_22")]
        Interbus = 22,

        [EnumMember(Value = "IO_Link_23")]
        IO_Link = 23,

        [EnumMember(Value = "HART_24")]
        HART = 24,

        [EnumMember(Value = "LON_25")]
        LON = 25,

        [EnumMember(Value = "LoRaWAN_26")]
        LoRaWAN = 26,

        [EnumMember(Value = "LIN_Bus_27")]
        LIN_Bus = 27,

        [EnumMember(Value = "LTE_28")]
        LTE = 28,

        [EnumMember(Value = "LTE_M_29")]
        LTE_M = 29,

        [EnumMember(Value = "M_Bus_30")]
        M_Bus = 30,

        [EnumMember(Value = "ModbusTCP_31")]
        ModbusTCP = 31,

        [EnumMember(Value = "ModbusRTU_32")]
        ModbusRTU = 32,

        [EnumMember(Value = "MP_Bus_33")]
        MP_Bus = 33,

        [EnumMember(Value = "NB_IOT_34")]
        NB_IOT = 34,

        [EnumMember(Value = "NFC_35")]
        NFC = 35,

        [EnumMember(Value = "OPCUA_36")]
        OPCUA = 36,

        [EnumMember(Value = "OPCDA_37")]
        OPCDA = 37,

        [EnumMember(Value = "PROFIBUSDP_38")]
        PROFIBUSDP = 38,

        [EnumMember(Value = "PROFINETRT_39")]
        PROFINETRT = 39,

        [EnumMember(Value = "Powerlink_40")]
        Powerlink = 40,

        [EnumMember(Value = "SERCOS_41")]
        SERCOS = 41,

        [EnumMember(Value = "SMI_42")]
        SMI = 42,

        [EnumMember(Value = "Thread_43")]
        Thread = 43,

        [EnumMember(Value = "UMTS_44")]
        UMTS = 44,

        [EnumMember(Value = "WIFI_45")]
        WIFI = 45,

        [EnumMember(Value = "X2X_Link_46")]
        X2X_Link = 46,

        [EnumMember(Value = "VARAN_47")]
        VARAN = 47,

        [EnumMember(Value = "ZigBee_48")]
        ZigBee = 48,

        [EnumMember(Value = "Z_Wave_49")]
        Z_Wave = 49,
    }

    #region FieldbusEnumCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfFieldbusEnum", Namespace = Opc.Ua.Pumps.Namespaces.Pumps, ItemName = "FieldbusEnum")]
    public partial class FieldbusEnumCollection : List<FieldbusEnum>, ICloneable
    {
        #region Constructors
        public FieldbusEnumCollection() {}

        public FieldbusEnumCollection(int capacity) : base(capacity) {}

        public FieldbusEnumCollection(IEnumerable<FieldbusEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator FieldbusEnumCollection(FieldbusEnum[] values)
        {
            if (values != null)
            {
                return new FieldbusEnumCollection(values);
            }

            return new FieldbusEnumCollection();
        }

        public static explicit operator FieldbusEnum[](FieldbusEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (FieldbusEnumCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            FieldbusEnumCollection clone = new FieldbusEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((FieldbusEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region MaintenanceLevelEnum Enumeration
    #if (!OPCUA_EXCLUDE_MaintenanceLevelEnum)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Pumps.Namespaces.Pumps)]
    
    public enum MaintenanceLevelEnum
    {
        [EnumMember(Value = "Level1_0")]
        Level1 = 0,

        [EnumMember(Value = "Level2_1")]
        Level2 = 1,

        [EnumMember(Value = "Level3_2")]
        Level3 = 2,

        [EnumMember(Value = "Level4_3")]
        Level4 = 3,

        [EnumMember(Value = "Level5_4")]
        Level5 = 4,
    }

    #region MaintenanceLevelEnumCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfMaintenanceLevelEnum", Namespace = Opc.Ua.Pumps.Namespaces.Pumps, ItemName = "MaintenanceLevelEnum")]
    public partial class MaintenanceLevelEnumCollection : List<MaintenanceLevelEnum>, ICloneable
    {
        #region Constructors
        public MaintenanceLevelEnumCollection() {}

        public MaintenanceLevelEnumCollection(int capacity) : base(capacity) {}

        public MaintenanceLevelEnumCollection(IEnumerable<MaintenanceLevelEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator MaintenanceLevelEnumCollection(MaintenanceLevelEnum[] values)
        {
            if (values != null)
            {
                return new MaintenanceLevelEnumCollection(values);
            }

            return new MaintenanceLevelEnumCollection();
        }

        public static explicit operator MaintenanceLevelEnum[](MaintenanceLevelEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (MaintenanceLevelEnumCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MaintenanceLevelEnumCollection clone = new MaintenanceLevelEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((MaintenanceLevelEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region MultiPumpOperationModeEnum Enumeration
    #if (!OPCUA_EXCLUDE_MultiPumpOperationModeEnum)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Pumps.Namespaces.Pumps)]
    
    public enum MultiPumpOperationModeEnum
    {
        [EnumMember(Value = "Standalone_0")]
        Standalone = 0,

        [EnumMember(Value = "RedundancyOperation_1")]
        RedundancyOperation = 1,

        [EnumMember(Value = "AdditionOperation_2")]
        AdditionOperation = 2,

        [EnumMember(Value = "MixedRedundancy_3")]
        MixedRedundancy = 3,
    }

    #region MultiPumpOperationModeEnumCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfMultiPumpOperationModeEnum", Namespace = Opc.Ua.Pumps.Namespaces.Pumps, ItemName = "MultiPumpOperationModeEnum")]
    public partial class MultiPumpOperationModeEnumCollection : List<MultiPumpOperationModeEnum>, ICloneable
    {
        #region Constructors
        public MultiPumpOperationModeEnumCollection() {}

        public MultiPumpOperationModeEnumCollection(int capacity) : base(capacity) {}

        public MultiPumpOperationModeEnumCollection(IEnumerable<MultiPumpOperationModeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator MultiPumpOperationModeEnumCollection(MultiPumpOperationModeEnum[] values)
        {
            if (values != null)
            {
                return new MultiPumpOperationModeEnumCollection(values);
            }

            return new MultiPumpOperationModeEnumCollection();
        }

        public static explicit operator MultiPumpOperationModeEnum[](MultiPumpOperationModeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (MultiPumpOperationModeEnumCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            MultiPumpOperationModeEnumCollection clone = new MultiPumpOperationModeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((MultiPumpOperationModeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region OperatingModeEnum Enumeration
    #if (!OPCUA_EXCLUDE_OperatingModeEnum)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Pumps.Namespaces.Pumps)]
    
    public enum OperatingModeEnum
    {
        [EnumMember(Value = "SingleOperation_0")]
        SingleOperation = 0,

        [EnumMember(Value = "SeriesOperation_1")]
        SeriesOperation = 1,

        [EnumMember(Value = "ParallelOperation_2")]
        ParallelOperation = 2,
    }

    #region OperatingModeEnumCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfOperatingModeEnum", Namespace = Opc.Ua.Pumps.Namespaces.Pumps, ItemName = "OperatingModeEnum")]
    public partial class OperatingModeEnumCollection : List<OperatingModeEnum>, ICloneable
    {
        #region Constructors
        public OperatingModeEnumCollection() {}

        public OperatingModeEnumCollection(int capacity) : base(capacity) {}

        public OperatingModeEnumCollection(IEnumerable<OperatingModeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator OperatingModeEnumCollection(OperatingModeEnum[] values)
        {
            if (values != null)
            {
                return new OperatingModeEnumCollection(values);
            }

            return new OperatingModeEnumCollection();
        }

        public static explicit operator OperatingModeEnum[](OperatingModeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (OperatingModeEnumCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OperatingModeEnumCollection clone = new OperatingModeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((OperatingModeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region OperationModeEnum Enumeration
    #if (!OPCUA_EXCLUDE_OperationModeEnum)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Pumps.Namespaces.Pumps)]
    
    public enum OperationModeEnum
    {
        [EnumMember(Value = "AutoControl_0")]
        AutoControl = 0,

        [EnumMember(Value = "ClosedLoopStandardPID_1")]
        ClosedLoopStandardPID = 1,

        [EnumMember(Value = "Advanced_2")]
        Advanced = 2,

        [EnumMember(Value = "StandBy_3")]
        StandBy = 3,

        [EnumMember(Value = "OpenLoopMin_4")]
        OpenLoopMin = 4,

        [EnumMember(Value = "OpenLoopValue_5")]
        OpenLoopValue = 5,

        [EnumMember(Value = "OpenLoopMax_6")]
        OpenLoopMax = 6,

        [EnumMember(Value = "ClosedLoopMin_7")]
        ClosedLoopMin = 7,

        [EnumMember(Value = "ClosedLoopMax_8")]
        ClosedLoopMax = 8,

        [EnumMember(Value = "Test_9")]
        Test = 9,

        [EnumMember(Value = "Calibration_10")]
        Calibration = 10,
    }

    #region OperationModeEnumCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfOperationModeEnum", Namespace = Opc.Ua.Pumps.Namespaces.Pumps, ItemName = "OperationModeEnum")]
    public partial class OperationModeEnumCollection : List<OperationModeEnum>, ICloneable
    {
        #region Constructors
        public OperationModeEnumCollection() {}

        public OperationModeEnumCollection(int capacity) : base(capacity) {}

        public OperationModeEnumCollection(IEnumerable<OperationModeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator OperationModeEnumCollection(OperationModeEnum[] values)
        {
            if (values != null)
            {
                return new OperationModeEnumCollection(values);
            }

            return new OperationModeEnumCollection();
        }

        public static explicit operator OperationModeEnum[](OperationModeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (OperationModeEnumCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OperationModeEnumCollection clone = new OperationModeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((OperationModeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region PortDirectionEnum Enumeration
    #if (!OPCUA_EXCLUDE_PortDirectionEnum)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Pumps.Namespaces.Pumps)]
    
    public enum PortDirectionEnum
    {
        [EnumMember(Value = "In_0")]
        In = 0,

        [EnumMember(Value = "Out_1")]
        Out = 1,

        [EnumMember(Value = "InOut_2")]
        InOut = 2,
    }

    #region PortDirectionEnumCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfPortDirectionEnum", Namespace = Opc.Ua.Pumps.Namespaces.Pumps, ItemName = "PortDirectionEnum")]
    public partial class PortDirectionEnumCollection : List<PortDirectionEnum>, ICloneable
    {
        #region Constructors
        public PortDirectionEnumCollection() {}

        public PortDirectionEnumCollection(int capacity) : base(capacity) {}

        public PortDirectionEnumCollection(IEnumerable<PortDirectionEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator PortDirectionEnumCollection(PortDirectionEnum[] values)
        {
            if (values != null)
            {
                return new PortDirectionEnumCollection(values);
            }

            return new PortDirectionEnumCollection();
        }

        public static explicit operator PortDirectionEnum[](PortDirectionEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (PortDirectionEnumCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PortDirectionEnumCollection clone = new PortDirectionEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((PortDirectionEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region DeviceTypeEnum Enumeration
    #if (!OPCUA_EXCLUDE_DeviceTypeEnum)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Pumps.Namespaces.Pumps)]
    
    public enum DeviceTypeEnum
    {
        [EnumMember(Value = "RotodynamicPump_0")]
        RotodynamicPump = 0,

        [EnumMember(Value = "PositiveDisplacementPump_1")]
        PositiveDisplacementPump = 1,

        [EnumMember(Value = "ProcessVacuumPump_2")]
        ProcessVacuumPump = 2,

        [EnumMember(Value = "TurboVacuumPump_3")]
        TurboVacuumPump = 3,

        [EnumMember(Value = "VacuumPump_4")]
        VacuumPump = 4,

        [EnumMember(Value = "LiquidPump_5")]
        LiquidPump = 5,

        [EnumMember(Value = "Pump_6")]
        Pump = 6,
    }

    #region DeviceTypeEnumCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfDeviceTypeEnum", Namespace = Opc.Ua.Pumps.Namespaces.Pumps, ItemName = "DeviceTypeEnum")]
    public partial class DeviceTypeEnumCollection : List<DeviceTypeEnum>, ICloneable
    {
        #region Constructors
        public DeviceTypeEnumCollection() {}

        public DeviceTypeEnumCollection(int capacity) : base(capacity) {}

        public DeviceTypeEnumCollection(IEnumerable<DeviceTypeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator DeviceTypeEnumCollection(DeviceTypeEnum[] values)
        {
            if (values != null)
            {
                return new DeviceTypeEnumCollection(values);
            }

            return new DeviceTypeEnumCollection();
        }

        public static explicit operator DeviceTypeEnum[](DeviceTypeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (DeviceTypeEnumCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DeviceTypeEnumCollection clone = new DeviceTypeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((DeviceTypeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region PumpKickModeEnum Enumeration
    #if (!OPCUA_EXCLUDE_PumpKickModeEnum)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Pumps.Namespaces.Pumps)]
    
    public enum PumpKickModeEnum
    {
        [EnumMember(Value = "ManufacturerSpecific_0")]
        ManufacturerSpecific = 0,

        [EnumMember(Value = "Disabled_1")]
        Disabled = 1,

        [EnumMember(Value = "OperatorSpecific_2")]
        OperatorSpecific = 2,
    }

    #region PumpKickModeEnumCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfPumpKickModeEnum", Namespace = Opc.Ua.Pumps.Namespaces.Pumps, ItemName = "PumpKickModeEnum")]
    public partial class PumpKickModeEnumCollection : List<PumpKickModeEnum>, ICloneable
    {
        #region Constructors
        public PumpKickModeEnumCollection() {}

        public PumpKickModeEnumCollection(int capacity) : base(capacity) {}

        public PumpKickModeEnumCollection(IEnumerable<PumpKickModeEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator PumpKickModeEnumCollection(PumpKickModeEnum[] values)
        {
            if (values != null)
            {
                return new PumpKickModeEnumCollection(values);
            }

            return new PumpKickModeEnumCollection();
        }

        public static explicit operator PumpKickModeEnum[](PumpKickModeEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (PumpKickModeEnumCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PumpKickModeEnumCollection clone = new PumpKickModeEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((PumpKickModeEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region PumpRoleEnum Enumeration
    #if (!OPCUA_EXCLUDE_PumpRoleEnum)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Pumps.Namespaces.Pumps)]
    
    public enum PumpRoleEnum
    {
        [EnumMember(Value = "Slave_0")]
        Slave = 0,

        [EnumMember(Value = "Master_1")]
        Master = 1,

        [EnumMember(Value = "SlaveAndAuxiliaryMaster_2")]
        SlaveAndAuxiliaryMaster = 2,
    }

    #region PumpRoleEnumCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfPumpRoleEnum", Namespace = Opc.Ua.Pumps.Namespaces.Pumps, ItemName = "PumpRoleEnum")]
    public partial class PumpRoleEnumCollection : List<PumpRoleEnum>, ICloneable
    {
        #region Constructors
        public PumpRoleEnumCollection() {}

        public PumpRoleEnumCollection(int capacity) : base(capacity) {}

        public PumpRoleEnumCollection(IEnumerable<PumpRoleEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator PumpRoleEnumCollection(PumpRoleEnum[] values)
        {
            if (values != null)
            {
                return new PumpRoleEnumCollection(values);
            }

            return new PumpRoleEnumCollection();
        }

        public static explicit operator PumpRoleEnum[](PumpRoleEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (PumpRoleEnumCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PumpRoleEnumCollection clone = new PumpRoleEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((PumpRoleEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region StateOfTheItemEnum Enumeration
    #if (!OPCUA_EXCLUDE_StateOfTheItemEnum)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [DataContract(Namespace = Opc.Ua.Pumps.Namespaces.Pumps)]
    
    public enum StateOfTheItemEnum
    {
        [EnumMember(Value = "IdleState_0")]
        IdleState = 0,

        [EnumMember(Value = "StandByState_1")]
        StandByState = 1,

        [EnumMember(Value = "OperatingState_2")]
        OperatingState = 2,

        [EnumMember(Value = "ExternalDisabledState_3")]
        ExternalDisabledState = 3,

        [EnumMember(Value = "DownState_4")]
        DownState = 4,
    }

    #region StateOfTheItemEnumCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfStateOfTheItemEnum", Namespace = Opc.Ua.Pumps.Namespaces.Pumps, ItemName = "StateOfTheItemEnum")]
    public partial class StateOfTheItemEnumCollection : List<StateOfTheItemEnum>, ICloneable
    {
        #region Constructors
        public StateOfTheItemEnumCollection() {}

        public StateOfTheItemEnumCollection(int capacity) : base(capacity) {}

        public StateOfTheItemEnumCollection(IEnumerable<StateOfTheItemEnum> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator StateOfTheItemEnumCollection(StateOfTheItemEnum[] values)
        {
            if (values != null)
            {
                return new StateOfTheItemEnumCollection(values);
            }

            return new StateOfTheItemEnumCollection();
        }

        public static explicit operator StateOfTheItemEnum[](StateOfTheItemEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (StateOfTheItemEnumCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            StateOfTheItemEnumCollection clone = new StateOfTheItemEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((StateOfTheItemEnum)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region DeclarationOfConformityOptionSet Class
    #if (!OPCUA_EXCLUDE_DeclarationOfConformityOptionSet)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = Opc.Ua.Pumps.Namespaces.Pumps)]
    public partial class DeclarationOfConformityOptionSet : Opc.Ua.OptionSet
    {
        #region Constructors
        public DeclarationOfConformityOptionSet()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId => DataTypeIds.DeclarationOfConformityOptionSet;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId => ObjectIds.DeclarationOfConformityOptionSet_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId => ObjectIds.DeclarationOfConformityOptionSet_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public override ExpandedNodeId JsonEncodingId => DataTypeIds.DeclarationOfConformityOptionSet;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(Opc.Ua.Pumps.Namespaces.Pumps);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(Opc.Ua.Pumps.Namespaces.Pumps);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            DeclarationOfConformityOptionSet value = encodeable as DeclarationOfConformityOptionSet;

            if (value == null)
            {
                return false;
            }


            return base.IsEqual(encodeable);
        }

        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (DeclarationOfConformityOptionSet)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DeclarationOfConformityOptionSet clone = (DeclarationOfConformityOptionSet)base.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region DeclarationOfConformityOptionSetCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfDeclarationOfConformityOptionSet", Namespace = Opc.Ua.Pumps.Namespaces.Pumps, ItemName = "DeclarationOfConformityOptionSet")]
    public partial class DeclarationOfConformityOptionSetCollection : List<DeclarationOfConformityOptionSet>, ICloneable
    {
        #region Constructors
        public DeclarationOfConformityOptionSetCollection() {}

        public DeclarationOfConformityOptionSetCollection(int capacity) : base(capacity) {}

        public DeclarationOfConformityOptionSetCollection(IEnumerable<DeclarationOfConformityOptionSet> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator DeclarationOfConformityOptionSetCollection(DeclarationOfConformityOptionSet[] values)
        {
            if (values != null)
            {
                return new DeclarationOfConformityOptionSetCollection(values);
            }

            return new DeclarationOfConformityOptionSetCollection();
        }

        public static explicit operator DeclarationOfConformityOptionSet[](DeclarationOfConformityOptionSetCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (DeclarationOfConformityOptionSetCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            DeclarationOfConformityOptionSetCollection clone = new DeclarationOfConformityOptionSetCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((DeclarationOfConformityOptionSet)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ExplosionProtectionOptionSet Class
    #if (!OPCUA_EXCLUDE_ExplosionProtectionOptionSet)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = Opc.Ua.Pumps.Namespaces.Pumps)]
    public partial class ExplosionProtectionOptionSet : Opc.Ua.OptionSet
    {
        #region Constructors
        public ExplosionProtectionOptionSet()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId => DataTypeIds.ExplosionProtectionOptionSet;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId => ObjectIds.ExplosionProtectionOptionSet_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId => ObjectIds.ExplosionProtectionOptionSet_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public override ExpandedNodeId JsonEncodingId => DataTypeIds.ExplosionProtectionOptionSet;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(Opc.Ua.Pumps.Namespaces.Pumps);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(Opc.Ua.Pumps.Namespaces.Pumps);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ExplosionProtectionOptionSet value = encodeable as ExplosionProtectionOptionSet;

            if (value == null)
            {
                return false;
            }


            return base.IsEqual(encodeable);
        }

        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (ExplosionProtectionOptionSet)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ExplosionProtectionOptionSet clone = (ExplosionProtectionOptionSet)base.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region ExplosionProtectionOptionSetCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfExplosionProtectionOptionSet", Namespace = Opc.Ua.Pumps.Namespaces.Pumps, ItemName = "ExplosionProtectionOptionSet")]
    public partial class ExplosionProtectionOptionSetCollection : List<ExplosionProtectionOptionSet>, ICloneable
    {
        #region Constructors
        public ExplosionProtectionOptionSetCollection() {}

        public ExplosionProtectionOptionSetCollection(int capacity) : base(capacity) {}

        public ExplosionProtectionOptionSetCollection(IEnumerable<ExplosionProtectionOptionSet> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator ExplosionProtectionOptionSetCollection(ExplosionProtectionOptionSet[] values)
        {
            if (values != null)
            {
                return new ExplosionProtectionOptionSetCollection(values);
            }

            return new ExplosionProtectionOptionSetCollection();
        }

        public static explicit operator ExplosionProtectionOptionSet[](ExplosionProtectionOptionSetCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (ExplosionProtectionOptionSetCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ExplosionProtectionOptionSetCollection clone = new ExplosionProtectionOptionSetCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ExplosionProtectionOptionSet)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region ExplosionZoneOptionSet Class
    #if (!OPCUA_EXCLUDE_ExplosionZoneOptionSet)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = Opc.Ua.Pumps.Namespaces.Pumps)]
    public partial class ExplosionZoneOptionSet : Opc.Ua.OptionSet
    {
        #region Constructors
        public ExplosionZoneOptionSet()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId => DataTypeIds.ExplosionZoneOptionSet;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId => ObjectIds.ExplosionZoneOptionSet_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId => ObjectIds.ExplosionZoneOptionSet_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public override ExpandedNodeId JsonEncodingId => DataTypeIds.ExplosionZoneOptionSet;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(Opc.Ua.Pumps.Namespaces.Pumps);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(Opc.Ua.Pumps.Namespaces.Pumps);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ExplosionZoneOptionSet value = encodeable as ExplosionZoneOptionSet;

            if (value == null)
            {
                return false;
            }


            return base.IsEqual(encodeable);
        }

        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (ExplosionZoneOptionSet)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ExplosionZoneOptionSet clone = (ExplosionZoneOptionSet)base.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region ExplosionZoneOptionSetCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfExplosionZoneOptionSet", Namespace = Opc.Ua.Pumps.Namespaces.Pumps, ItemName = "ExplosionZoneOptionSet")]
    public partial class ExplosionZoneOptionSetCollection : List<ExplosionZoneOptionSet>, ICloneable
    {
        #region Constructors
        public ExplosionZoneOptionSetCollection() {}

        public ExplosionZoneOptionSetCollection(int capacity) : base(capacity) {}

        public ExplosionZoneOptionSetCollection(IEnumerable<ExplosionZoneOptionSet> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator ExplosionZoneOptionSetCollection(ExplosionZoneOptionSet[] values)
        {
            if (values != null)
            {
                return new ExplosionZoneOptionSetCollection(values);
            }

            return new ExplosionZoneOptionSetCollection();
        }

        public static explicit operator ExplosionZoneOptionSet[](ExplosionZoneOptionSetCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (ExplosionZoneOptionSetCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            ExplosionZoneOptionSetCollection clone = new ExplosionZoneOptionSetCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ExplosionZoneOptionSet)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region OfferedControlModesOptionSet Class
    #if (!OPCUA_EXCLUDE_OfferedControlModesOptionSet)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = Opc.Ua.Pumps.Namespaces.Pumps)]
    public partial class OfferedControlModesOptionSet : Opc.Ua.OptionSet
    {
        #region Constructors
        public OfferedControlModesOptionSet()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId => DataTypeIds.OfferedControlModesOptionSet;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId => ObjectIds.OfferedControlModesOptionSet_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId => ObjectIds.OfferedControlModesOptionSet_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public override ExpandedNodeId JsonEncodingId => DataTypeIds.OfferedControlModesOptionSet;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(Opc.Ua.Pumps.Namespaces.Pumps);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(Opc.Ua.Pumps.Namespaces.Pumps);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            OfferedControlModesOptionSet value = encodeable as OfferedControlModesOptionSet;

            if (value == null)
            {
                return false;
            }


            return base.IsEqual(encodeable);
        }

        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (OfferedControlModesOptionSet)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OfferedControlModesOptionSet clone = (OfferedControlModesOptionSet)base.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region OfferedControlModesOptionSetCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfOfferedControlModesOptionSet", Namespace = Opc.Ua.Pumps.Namespaces.Pumps, ItemName = "OfferedControlModesOptionSet")]
    public partial class OfferedControlModesOptionSetCollection : List<OfferedControlModesOptionSet>, ICloneable
    {
        #region Constructors
        public OfferedControlModesOptionSetCollection() {}

        public OfferedControlModesOptionSetCollection(int capacity) : base(capacity) {}

        public OfferedControlModesOptionSetCollection(IEnumerable<OfferedControlModesOptionSet> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator OfferedControlModesOptionSetCollection(OfferedControlModesOptionSet[] values)
        {
            if (values != null)
            {
                return new OfferedControlModesOptionSetCollection(values);
            }

            return new OfferedControlModesOptionSetCollection();
        }

        public static explicit operator OfferedControlModesOptionSet[](OfferedControlModesOptionSetCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (OfferedControlModesOptionSetCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OfferedControlModesOptionSetCollection clone = new OfferedControlModesOptionSetCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((OfferedControlModesOptionSet)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region OfferedFieldbusesOptionSet Class
    #if (!OPCUA_EXCLUDE_OfferedFieldbusesOptionSet)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = Opc.Ua.Pumps.Namespaces.Pumps)]
    public partial class OfferedFieldbusesOptionSet : Opc.Ua.OptionSet
    {
        #region Constructors
        public OfferedFieldbusesOptionSet()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
        }
        #endregion

        #region Public Properties
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId => DataTypeIds.OfferedFieldbusesOptionSet;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId => ObjectIds.OfferedFieldbusesOptionSet_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId => ObjectIds.OfferedFieldbusesOptionSet_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public override ExpandedNodeId JsonEncodingId => DataTypeIds.OfferedFieldbusesOptionSet;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(Opc.Ua.Pumps.Namespaces.Pumps);


            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(Opc.Ua.Pumps.Namespaces.Pumps);


            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            OfferedFieldbusesOptionSet value = encodeable as OfferedFieldbusesOptionSet;

            if (value == null)
            {
                return false;
            }


            return base.IsEqual(encodeable);
        }

        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            return (OfferedFieldbusesOptionSet)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OfferedFieldbusesOptionSet clone = (OfferedFieldbusesOptionSet)base.MemberwiseClone();


            return clone;
        }
        #endregion

        #region Private Fields
        #endregion
    }

    #region OfferedFieldbusesOptionSetCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfOfferedFieldbusesOptionSet", Namespace = Opc.Ua.Pumps.Namespaces.Pumps, ItemName = "OfferedFieldbusesOptionSet")]
    public partial class OfferedFieldbusesOptionSetCollection : List<OfferedFieldbusesOptionSet>, ICloneable
    {
        #region Constructors
        public OfferedFieldbusesOptionSetCollection() {}

        public OfferedFieldbusesOptionSetCollection(int capacity) : base(capacity) {}

        public OfferedFieldbusesOptionSetCollection(IEnumerable<OfferedFieldbusesOptionSet> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator OfferedFieldbusesOptionSetCollection(OfferedFieldbusesOptionSet[] values)
        {
            if (values != null)
            {
                return new OfferedFieldbusesOptionSetCollection(values);
            }

            return new OfferedFieldbusesOptionSetCollection();
        }

        public static explicit operator OfferedFieldbusesOptionSet[](OfferedFieldbusesOptionSetCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (OfferedFieldbusesOptionSetCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            OfferedFieldbusesOptionSetCollection clone = new OfferedFieldbusesOptionSetCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((OfferedFieldbusesOptionSet)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion

    #region PhysicalAddressDataType Class
    #if (!OPCUA_EXCLUDE_PhysicalAddressDataType)
    /// <exclude />
    [Flags]
    public enum PhysicalAddressDataTypeFields : uint
    {
        None = 0,
        Street = 0x1,
        Number = 0x2,
        City = 0x4,
        PostalCode = 0x8,
        State = 0x10,
        Country = 0x20,
    }

    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [DataContract(Namespace = Opc.Ua.Pumps.Namespaces.Pumps)]
    public partial class PhysicalAddressDataType : IEncodeable, IJsonEncodeable
    {
        #region Constructors
        public PhysicalAddressDataType()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            EncodingMask = (uint)PhysicalAddressDataTypeFields.None;
            m_street = null;
            m_number = null;
            m_city = null;
            m_postalCode = null;
            m_state = null;
            m_country = null;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "EncodingMask", IsRequired = true, Order = 0)]
        public virtual uint EncodingMask { get; set; }

        [DataMember(Name = "Street", IsRequired = false, Order = 1)]
        public LocalizedText Street
        {
            get { return m_street;  }
            set { m_street = value; }
        }

        [DataMember(Name = "Number", IsRequired = false, Order = 2)]
        public LocalizedText Number
        {
            get { return m_number;  }
            set { m_number = value; }
        }

        [DataMember(Name = "City", IsRequired = false, Order = 3)]
        public LocalizedText City
        {
            get { return m_city;  }
            set { m_city = value; }
        }

        [DataMember(Name = "PostalCode", IsRequired = false, Order = 4)]
        public LocalizedText PostalCode
        {
            get { return m_postalCode;  }
            set { m_postalCode = value; }
        }

        [DataMember(Name = "State", IsRequired = false, Order = 5)]
        public LocalizedText State
        {
            get { return m_state;  }
            set { m_state = value; }
        }

        [DataMember(Name = "Country", IsRequired = false, Order = 6)]
        public LocalizedText Country
        {
            get { return m_country;  }
            set { m_country = value; }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId => DataTypeIds.PhysicalAddressDataType;

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId => ObjectIds.PhysicalAddressDataType_Encoding_DefaultBinary;

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId => ObjectIds.PhysicalAddressDataType_Encoding_DefaultXml;

        /// <summary cref="IJsonEncodeable.JsonEncodingId" />
        public virtual ExpandedNodeId JsonEncodingId => DataTypeIds.PhysicalAddressDataType;

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Opc.Ua.Pumps.Namespaces.Pumps);
            encoder.WriteEncodingMask((uint)EncodingMask);

            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.Street) != 0) encoder.WriteLocalizedText("Street", Street);
            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.Number) != 0) encoder.WriteLocalizedText("Number", Number);
            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.City) != 0) encoder.WriteLocalizedText("City", City);
            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.PostalCode) != 0) encoder.WriteLocalizedText("PostalCode", PostalCode);
            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.State) != 0) encoder.WriteLocalizedText("State", State);
            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.Country) != 0) encoder.WriteLocalizedText("Country", Country);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Opc.Ua.Pumps.Namespaces.Pumps);

            EncodingMask = decoder.ReadEncodingMask(m_FieldNames);

            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.Street) != 0) Street = decoder.ReadLocalizedText("Street");
            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.Number) != 0) Number = decoder.ReadLocalizedText("Number");
            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.City) != 0) City = decoder.ReadLocalizedText("City");
            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.PostalCode) != 0) PostalCode = decoder.ReadLocalizedText("PostalCode");
            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.State) != 0) State = decoder.ReadLocalizedText("State");
            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.Country) != 0) Country = decoder.ReadLocalizedText("Country");

            decoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            PhysicalAddressDataType value = encodeable as PhysicalAddressDataType;

            if (value == null)
            {
                return false;
            }

            if (value.EncodingMask != this.EncodingMask) return false;

            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.Street) != 0) if (!Utils.IsEqual(m_street, value.m_street)) return false;
            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.Number) != 0) if (!Utils.IsEqual(m_number, value.m_number)) return false;
            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.City) != 0) if (!Utils.IsEqual(m_city, value.m_city)) return false;
            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.PostalCode) != 0) if (!Utils.IsEqual(m_postalCode, value.m_postalCode)) return false;
            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.State) != 0) if (!Utils.IsEqual(m_state, value.m_state)) return false;
            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.Country) != 0) if (!Utils.IsEqual(m_country, value.m_country)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            return (PhysicalAddressDataType)this.MemberwiseClone();
        }

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PhysicalAddressDataType clone = (PhysicalAddressDataType)base.MemberwiseClone();

            clone.EncodingMask = this.EncodingMask;

            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.Street) != 0) clone.m_street = (LocalizedText)Utils.Clone(this.m_street);
            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.Number) != 0) clone.m_number = (LocalizedText)Utils.Clone(this.m_number);
            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.City) != 0) clone.m_city = (LocalizedText)Utils.Clone(this.m_city);
            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.PostalCode) != 0) clone.m_postalCode = (LocalizedText)Utils.Clone(this.m_postalCode);
            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.State) != 0) clone.m_state = (LocalizedText)Utils.Clone(this.m_state);
            if ((EncodingMask & (uint)PhysicalAddressDataTypeFields.Country) != 0) clone.m_country = (LocalizedText)Utils.Clone(this.m_country);

            return clone;
        }
        #endregion

        #region Private Fields
        private LocalizedText m_street;
        private LocalizedText m_number;
        private LocalizedText m_city;
        private LocalizedText m_postalCode;
        private LocalizedText m_state;
        private LocalizedText m_country;

        private static readonly string[] m_FieldNames = Enum.GetNames(typeof(PhysicalAddressDataTypeFields)).Where(x => x != nameof(PhysicalAddressDataTypeFields.None)).ToArray();
        #endregion
    }

    #region PhysicalAddressDataTypeCollection Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [CollectionDataContract(Name = "ListOfPhysicalAddressDataType", Namespace = Opc.Ua.Pumps.Namespaces.Pumps, ItemName = "PhysicalAddressDataType")]
    public partial class PhysicalAddressDataTypeCollection : List<PhysicalAddressDataType>, ICloneable
    {
        #region Constructors
        public PhysicalAddressDataTypeCollection() {}

        public PhysicalAddressDataTypeCollection(int capacity) : base(capacity) {}

        public PhysicalAddressDataTypeCollection(IEnumerable<PhysicalAddressDataType> collection) : base(collection) {}
        #endregion

        #region Static Operators
        public static implicit operator PhysicalAddressDataTypeCollection(PhysicalAddressDataType[] values)
        {
            if (values != null)
            {
                return new PhysicalAddressDataTypeCollection(values);
            }

            return new PhysicalAddressDataTypeCollection();
        }

        public static explicit operator PhysicalAddressDataType[](PhysicalAddressDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        public object Clone()
        {
            return (PhysicalAddressDataTypeCollection)this.MemberwiseClone();
        }
        #endregion

        /// <summary cref="Object.MemberwiseClone" />
        public new object MemberwiseClone()
        {
            PhysicalAddressDataTypeCollection clone = new PhysicalAddressDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((PhysicalAddressDataType)Utils.Clone(this[ii]));
            }

            return clone;
        }
    }
    #endregion
    #endif
    #endregion
}