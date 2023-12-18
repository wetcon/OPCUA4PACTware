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

using System.Threading.Tasks;
using Opc.Ua;

namespace Wetcon.OpcUaClient.Base
{
    /// <summary>
    /// OPC UA Device Information model client that knows how to read device properties and 
    /// device parameter from a given device node id.
    /// </summary>
    public class OpcUaDiClient : OpcUaClient
    {
        private readonly string _deviceNodeId;
        private ExpandedNodeId _parameterSetNodeId;

        public OpcUaDiClient(string deviceNodeId) : base()
        {
            _deviceNodeId = deviceNodeId;
        }

        public override async Task Initialize(string endpointUrl)
        {
            await base.Initialize(endpointUrl);
            _parameterSetNodeId = GetParameterSetNode();
        }

        private ExpandedNodeId GetParameterSetNode()
        {
            Browse(new NodeId(_deviceNodeId), out var deviceRefs);

            return GetNodeIdByDisplayName(deviceRefs, "ParameterSet");
        }

        public object ReadParameterValue(string parameterName)
        {
            Browse(_parameterSetNodeId, out var parameterRefs);
            var parameterNode = GetNodeIdByDisplayName(parameterRefs, parameterName);

            return ReadVariable(parameterNode);
        }

        public void WriteParameterValue(string parameterName, int value)
        {
            Browse(_parameterSetNodeId, out var parameterRefs);
            var parameterNode = GetNodeIdByDisplayName(parameterRefs, parameterName);

            WriteVariable(parameterNode, value);
        }

        public DeviceProperties ReadDeviceProperties()
        {
            Browse(new NodeId(_deviceNodeId), out var deviceRefs);

            var manufacturer = (ReadVariableByDisplayName(deviceRefs, "Manufacturer") ??
                string.Empty).ToString();
            var model = (ReadVariableByDisplayName(deviceRefs, "Model") ??
                string.Empty).ToString();
            var serialnumber = (ReadVariableByDisplayName(deviceRefs, "SerialNumber") ??
                string.Empty).ToString();

            return new DeviceProperties(manufacturer, model, serialnumber);
        }
    }
}
