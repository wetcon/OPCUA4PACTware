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
using Opc.Ua;

namespace Wetcon.PactwarePlugin.OpcUaServer.OpcUa.Models
{
    /// <summary>
    /// Device parameter base model.
    /// </summary>
    public abstract class BaseParameterModel : BaseDataVariableState
    {
        /// <summary>
        /// Device of the parameter
        /// </summary>
        public BaseDeviceModel DeviceModel { get; protected set; }

        /// <summary>
        /// Parameter Id
        /// </summary>
        public string ParameterId { get; protected set; }

        /// <summary>
        /// Parameter name
        /// </summary>
        public string ParameterName { get; protected set; }

        /// <summary>
        /// Initializes a new instance of <see cref="BaseParameterModel"/>.
        /// </summary>
        /// <param name="deviceModel"></param>
        /// <param name="accessLevel"></param>        
        protected BaseParameterModel(NodeState deviceModel, byte accessLevel) : base(deviceModel)
        {
            DeviceModel = (BaseDeviceModel)deviceModel;

            TypeDefinitionId = VariableTypeIds.BaseDataVariableType;
            ValueRank = -1;
            AccessLevel = accessLevel;
            UserAccessLevel = accessLevel;

            if (CanRead)
            {
                OnReadValue = GetValueEventHandler;
            }

            if (CanWrite)
            {
                OnWriteValue = SetValueEventHandler;
            }
        }

        public void AddUnit(Opc.Ua.Server.ServerSystemContext context)
        {
            var engineeringUnits = new PropertyState<EUInformation>(this)
            {
                Value = new EUInformation("unitName", Constants.ServerNamespaceUri)
            };
            var nodeId = new NodeId($"{NodeId.Identifier}.Unit", 2);
            var qualifiedName = new QualifiedName("EUInformation");
            var displayName = new LocalizedText("Unit");

            AddChild(engineeringUnits);

            engineeringUnits.Create(context, nodeId, qualifiedName, displayName, true);
        }

        private bool CanWrite => (AccessLevel & AccessLevels.CurrentWrite) != 0;

        private bool CanRead => (AccessLevel & AccessLevels.CurrentRead) != 0;

        private ServiceResult GetValueEventHandler(ISystemContext context, NodeState node, NumericRange indexRange,
            QualifiedName dataEncoding, ref object value, ref StatusCode statusCode, ref DateTime timestamp)
        {
            var result = GetValue(ref value, ref statusCode, ref timestamp);
            UpdateValue(statusCode, value);

            return result;
        }

        protected virtual ServiceResult GetValue(ref object value, ref StatusCode statusCode, ref DateTime timestamp)
        {
            return new ServiceResult(StatusCodes.BadNotImplemented);
        }

        private ServiceResult SetValueEventHandler(ISystemContext context, NodeState node, NumericRange indexRange,
            QualifiedName dataEncoding, ref object value, ref StatusCode statusCode, ref DateTime timestamp)
        {
            var result = SetValue(ref value, ref statusCode, ref timestamp);

            return result;
        }

        protected virtual ServiceResult SetValue(ref object value, ref StatusCode statusCode, ref DateTime timestamp)
        {
            return new ServiceResult(StatusCodes.BadNotImplemented);
        }

        private void UpdateValue(StatusCode statusCode, object value)
        {
            if (StatusCode.IsGood(statusCode) && Value != value)
            {
                Value = value;
            }
        }
    }
}
