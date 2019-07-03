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
using Wetcon.PactwarePlugin.OpcUaServer.Fdt;
using Wetcon.PactwarePlugin.OpcUaServer.IODD;

namespace Wetcon.PactwarePlugin.OpcUaServer.OpcUa.Models
{
    /// <summary>
    /// Process parameter model.
    /// </summary>
    public class ProcessParameterModel : BaseParameterModel
    {
        private static readonly ILog s_log = LogManager.GetLogger(typeof(ProcessParameterModel));

        public ProcessDataRecord ProcessDataRecord { get; }

        /// <summary>
        /// Initializes a new instance of <see cref="ParameterModel"/>.
        /// </summary>
        /// <param name="deviceModel"></param>
        /// <param name="processDataRecord"></param>
        public ProcessParameterModel(NodeState deviceModel, ProcessDataRecord processDataRecord) : base(deviceModel, AccessLevels.CurrentRead)
        {
            ProcessDataRecord = processDataRecord;
            ParameterId = processDataRecord.Name;
            ParameterName = processDataRecord.Name;
            DisplayName = new LocalizedText(processDataRecord.Name);
            TypeDefinitionId = VariableTypeIds.BaseDataVariableType;
            DataType = GetOpcUaDataTypeId(processDataRecord.Type);
        }

        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Description = new LocalizedText("Process Parameter " + ProcessDataRecord.Name);
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

        private NodeId GetOpcUaDataTypeId(DataType dataType)
        {
            switch (dataType)
            {
                case IODD.DataType.Boolean:
                    return DataTypeIds.String;
                case IODD.DataType.UInteger:
                    return DataTypeIds.UInt32;
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

            var processData = new ProcessData(response);
            var value = ProcessDataRecord.GetValue(processData);

            return new DataValue(new Variant(value)) { SourceTimestamp = DateTime.Now };
        }
    }
}
