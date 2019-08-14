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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using log4net;
using Opc.Ua;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt.Models;
using Wetcon.PactwarePlugin.OpcUaServer.Infrastructure;

namespace Wetcon.PactwarePlugin.OpcUaServer.OpcUa.Models
{
    /// <summary>
    /// Device parameter model.
    /// </summary>
    public class ParameterModel : BaseParameterModel
    {
        private static readonly ILog s_log = LogManager.GetLogger(typeof(ParameterModel));

        public DtmParameter DtmParameter { get; }

        /// <summary>
        /// Initializes a new instance of <see cref="ParameterModel"/>.
        /// </summary>
        /// <param name="deviceModel"></param>
        /// <param name="dtmParameter"></param>
        public ParameterModel(NodeState deviceModel, DtmParameter dtmParameter) : base(deviceModel, dtmParameter.AccessLevel)
        {
            DtmParameter = dtmParameter;
            ParameterId = dtmParameter.Id;
            ParameterName = dtmParameter.Name;
            DisplayName = !string.IsNullOrWhiteSpace(dtmParameter.Label)
                ? new LocalizedText(dtmParameter.Label)
                : new LocalizedText(dtmParameter.Name);
            TypeDefinitionId = VariableTypeIds.BaseDataVariableType;
            DataType = GetOpcUaDataTypeId(dtmParameter.DataType);
        }

        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Description = new LocalizedText(DtmParameter.Descriptor);
        }

        protected override ServiceResult GetValue(ref object value, ref StatusCode statusCode, ref DateTime timestamp)
        {
            if (DtmParameter.Source == ParameterDataSourceKind.DtmParameter)
            {
                return GetValueIDtmParameter(ref value);
            }

            return GetValueDefault(ref value);
        }

        private ServiceResult GetValueDefault(ref object value)
        {
            var itemSelectionList = new DtmItemSelectionList
            {
                ItemSelections = new List<DtmItemSelection>
                {
                    new DtmItemSelection
                    {
                        Id = ParameterId
                    }
                }
            };

            try
            {
                var dtmItemList = ReadDeviceParameter(itemSelectionList);

                var dtmItem = dtmItemList?.Items?.FirstOrDefault(i => i.Id == ParameterId);
                if (dtmItem == null)
                {
                    return new ServiceResult(StatusCodes.Bad);
                }

                var dataValue = dtmItem.ToOpcUaDataValue();
                value = dataValue.Value;
                return new ServiceResult(dataValue.StatusCode);

            }
            catch (TimeoutException ex)
            {
                s_log.Error("GetValue timeout error.", ex);
                return new ServiceResult(StatusCodes.BadTimeout);
            }
            catch (Exception ex)
            {
                s_log.Error("GetValue error.", ex);
                return new ServiceResult(StatusCodes.Bad);
            }
        }

        private DtmItemList ReadDeviceParameter(DtmItemSelectionList itemSelectionList)
        {
            if (DeviceModel.IsOnline)
            {
                return DeviceModel.FdtService
                        .GetService<DtmSingleDeviceDataAccessService>()
                        .ReadOnlineDeviceParameters(itemSelectionList);
            }

            return DeviceModel.FdtService
                .GetService<DtmSingleInstanceDataAccessService>()
                .ReadOfflineDeviceParameters(itemSelectionList);
        }

        private ServiceResult GetValueIDtmParameter(ref object value)
        {
            try
            {
                var parameters = DeviceModel.FdtService
                    .GetService<DtmParameterService>()
                    .GetDtmParameters();

                var parameter = parameters.FirstOrDefault(p => p.Id.Equals(DtmParameter.Id));

                if (null == parameter)
                {
                    return new ServiceResult(StatusCodes.Bad);
                }

                var dataValue = parameter.ToDtmItem().ToOpcUaDataValue();
                value = dataValue.Value;

                return new ServiceResult(dataValue.StatusCode);
            }
            catch (Exception ex)
            {
                s_log.Error("GetValue error.", ex);
                return new ServiceResult(StatusCodes.Bad);
            }
        }

        /// <inheritdoc/>
        protected override ServiceResult SetValue(ref object value, ref StatusCode statusCode, ref DateTime timestamp)
        {
            if (DtmParameter.Source == ParameterDataSourceKind.DtmParameter)
            {
                return SetValueIDtmParameter(ref value);
            }

            return SetValueDefault(ref value);
        }

        private ServiceResult SetValueDefault(ref object value)
        {
            try
            {
                DtmParameter.Value = value;
                var dtmItemToSet = DtmParameter.ToDtmItem();
                var itemList = new DtmItemList { Items = new List<DtmItem> { dtmItemToSet } };
                var dtmItemList = WriteDeviceParameter(itemList);

                var dtmItem = dtmItemList?.Items?.FirstOrDefault(i => i.Id == dtmItemToSet.Id);
                if (dtmItem == null)
                {
                    return new ServiceResult(StatusCodes.Bad);
                }

                return ServiceResult.Good;
            }
            catch (TimeoutException ex)
            {
                s_log.Error("SetValue timeout error.", ex);
                return new ServiceResult(StatusCodes.BadTimeout);
            }
            catch (Exception ex)
            {
                s_log.Error("SetValue error.", ex);
                return new ServiceResult(StatusCodes.Bad);
            }
        }

        private DtmItemList WriteDeviceParameter(DtmItemList itemList)
        {
            if (DeviceModel.IsOnline)
            {
                return DeviceModel.FdtService
                    .GetService<DtmSingleDeviceDataAccessService>()
                    .WriteOnlineDeviceParameters(itemList);
            }

            return DeviceModel.FdtService
                .GetService<DtmSingleInstanceDataAccessService>()
                .WriteOfflineDeviceParameters(itemList);
        }

        private ServiceResult SetValueIDtmParameter(ref object value)
        {
            try
            {
                var setParameterResult = DeviceModel.FdtService
                    .GetService<DtmParameterService>()
                    .SetDtmParameter(DtmParameter.Id, value);

                if (!setParameterResult)
                {
                    return new ServiceResult(StatusCodes.Bad);
                }

                var saveRequestResult = DeviceModel.FdtService
                    .GetService<FdtContainerService>()
                    .SaveRequest();

                if (!saveRequestResult)
                {
                    return new ServiceResult(StatusCodes.Bad);
                }

                return ServiceResult.Good;
            }
            catch (Exception ex)
            {
                s_log.Error("SetValue error.", ex);
                return new ServiceResult(StatusCodes.Bad);
            }
        }

        private NodeId GetOpcUaDataTypeId(DtmDataTypeKind dtmDataTypeKind)
        {
            switch (dtmDataTypeKind)
            {
                case DtmDataTypeKind.ascii:
                case DtmDataTypeKind.packedAscii:
                case DtmDataTypeKind.password:
                case DtmDataTypeKind.bitString:
                case DtmDataTypeKind.hexString:
                    return DataTypeIds.String;
                case DtmDataTypeKind.floatType:
                    return DataTypeIds.Float;
                case DtmDataTypeKind.doubleType:
                    return DataTypeIds.Double;
                case DtmDataTypeKind.intType:
                    return DataTypeIds.Int32;
                case DtmDataTypeKind.unsigned:
                case DtmDataTypeKind.index:
                    return DataTypeIds.UInt32;
                case DtmDataTypeKind.byteType:
                    return DataTypeIds.Byte;
                case DtmDataTypeKind.date:
                case DtmDataTypeKind.dateAndTime:
                case DtmDataTypeKind.time:
                case DtmDataTypeKind.duration:
                    return DataTypeIds.DateTime;
                case DtmDataTypeKind.binary:
                case DtmDataTypeKind.dtmSpecific:
                case DtmDataTypeKind.structured:
                    return DataTypeIds.ByteString;
                default:
                    throw new InvalidEnumArgumentException(dtmDataTypeKind.ToString());
            }
        }
    }
}
