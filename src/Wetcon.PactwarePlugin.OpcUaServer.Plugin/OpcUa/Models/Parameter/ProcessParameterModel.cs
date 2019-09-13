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
using System.ComponentModel;
using log4net;
using Opc.Ua;
using Wetcon.IoLink.Helper;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt;

namespace Wetcon.PactwarePlugin.OpcUaServer.OpcUa.Models
{
    /// <summary>
    /// Process parameter model.
    /// </summary>
    public class ProcessParameterModel : BaseParameterModel
    {
        private static readonly ILog s_log = LogManager.GetLogger(typeof(ProcessParameterModel));
        private readonly string _nodeName;

        public ProcessMetaDataRecord ProcessMetaDataRecord { get; }

        /// <summary>
        /// Initializes a new instance of <see cref="ParameterModel"/>.
        /// </summary>
        /// <param name="deviceModel"></param>
        /// <param name="processDataRecord"></param>
        public ProcessParameterModel(NodeState deviceModel, ProcessMetaDataRecord processDataRecord)
            : base(deviceModel, AccessLevels.CurrentRead)
        {
            ProcessMetaDataRecord = processDataRecord;
            _nodeName = $"{ProcessMetaDataRecord.ParentId ?? "ProcessData"}.{ProcessMetaDataRecord.DisplayName}";
            ParameterId = _nodeName;
            ParameterName = _nodeName;
            DisplayName = new LocalizedText(_nodeName);
            TypeDefinitionId = VariableTypeIds.BaseDataVariableType;
            DataType = GetOpcUaDataTypeId(processDataRecord.DataType);
        }

        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Description = new LocalizedText("Process Parameter " + _nodeName);
        }

        protected override ServiceResult GetValue(ref object value, ref StatusCode statusCode, ref DateTime timestamp)
        {
            try
            {
                var result = DeviceModel.FdtService
                    .GetService<IOProcessParametersService>()
                    .ReadIOProcessParameter(DeviceModel.PactwareProjectNode);

                if (string.IsNullOrEmpty(result))
                {
                    return new ServiceResult(StatusCodes.Bad);
                }

                var dataValue = ToOpcUaDataValue(result);
                value = dataValue.Value;

                return new ServiceResult(dataValue.StatusCode);

            }
            catch (TimeoutException ex)
            {
                s_log.Error("GetValue timeout error.", ex);
                return new ServiceResult(StatusCodes.BadTimeout);
            }
            catch (IOProcessParametersService.NotConnectedException)
            {
                return new ServiceResult(StatusCodes.BadNotConnected);
            }
            catch (Exception ex)
            {
                s_log.Error("GetValue error.", ex);
                return new ServiceResult(StatusCodes.Bad);
            }
        }

        private NodeId GetOpcUaDataTypeId(ProcessDataType dataType)
        {
            switch (dataType)
            {
                case ProcessDataType.BooleanT:
                    return DataTypeIds.Boolean;
                case ProcessDataType.UIntegerT:
                    return DataTypeIds.UInt64;
                case ProcessDataType.IntegerT:
                    return DataTypeIds.Int64;
                case ProcessDataType.Float32T:
                    return DataTypeIds.Float;
                case ProcessDataType.StringT:
                    return DataTypeIds.String;

                default:
                    throw new InvalidEnumArgumentException(dataType.ToString());
            }
        }

        private DataValue ToOpcUaDataValue(string response)
        {
            if (string.IsNullOrEmpty(response))
            {
                return new DataValue(StatusCodes.Bad) { SourceTimestamp = DateTime.Now };
            }

            var interpreter = new ProcessDataInterpreter(response);
            var value = interpreter.Read(ProcessMetaDataRecord);

            return new DataValue(new Variant(value)) { SourceTimestamp = DateTime.Now };
        }
    }
}
