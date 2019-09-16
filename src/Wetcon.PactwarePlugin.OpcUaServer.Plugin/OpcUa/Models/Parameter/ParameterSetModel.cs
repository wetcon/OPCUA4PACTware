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
using log4net;
using Opc.Ua;
using Wetcon.IoLink.Helper;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt;

namespace Wetcon.PactwarePlugin.OpcUaServer.OpcUa.Models
{
    /// <summary>
    /// Device parameter set model.
    /// </summary>
    public class ParameterSetModel : BaseObjectState
    {
        private static readonly ILog s_log = LogManager.GetLogger(typeof(ParameterSetModel));

        /// <summary>
        /// Parent device model.
        /// </summary>
        public BaseDeviceModel DeviceModel { get; }

        public List<BaseDataVariableState> Parameters { get; private set; }

        /// <summary>
        /// Initializes a new instance of <see cref="ParameterSetModel"/>
        /// </summary>
        /// <param name="parent"></param>
        public ParameterSetModel(NodeState parent) : base(parent)
        {
            DeviceModel = (BaseDeviceModel)parent;
            Parameters = new List<BaseDataVariableState>();
        }

        public void ReloadParameters()
        {
            Parameters = GetParameters();
        }

        /// <inheritdoc/>
        public override void GetChildren(ISystemContext context, IList<BaseInstanceState> children)
        {
            Parameters.ForEach(children.Add);

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Gets the device parameters models.
        /// </summary>
        /// <returns></returns>
        public List<BaseDataVariableState> GetParameters()
        {
            var parameters = new List<BaseDataVariableState>();

            try
            {
                // get device parameter
                var dtmItemInfos = GetDeviceParameters() ?? new List<DtmParameter>();

                foreach (var dtmItemInfo in dtmItemInfos)
                {
                    var parameterModel = new ParameterModel(DeviceModel, dtmItemInfo);
                    SetParameterId(parameterModel);
                    parameters.Add(parameterModel);
                }

                if (DeviceModel.IsOnline && DeviceModel.ReadIOProcessData)
                {
                    // get (process specific) process parameter
                    var processParameter = GetProcessParameter();

                    foreach (var parameter in processParameter)
                    {
                        var parameterModel = new ProcessParameterModel(DeviceModel, parameter);
                        SetParameterId(parameterModel);
                        parameters.Add(parameterModel);
                    }
                }
            }
            catch (Exception ex)
            {
                s_log.Error("GetParametersAsync error", ex);
            }

            return parameters;
        }

        private List<ProcessMetaDataRecord> GetProcessParameter()
        {
            return IODDProcessParameter.FromPWProjectNode(DeviceModel.PactwareProjectNode);
        }

        private void SetParameterId(NodeState parameter)
        {
            var parameterNodeId = new NodeId(Parent.NodeId.Identifier + "." + parameter.DisplayName.Text,
                DeviceModel.ServerNamespaceIndex);
            parameter.BrowseName = new QualifiedName(parameter.DisplayName.Text);
            parameter.NodeId = parameterNodeId;
        }

        private List<DtmParameter> GetDeviceParameters()
        {
            s_log.InfoFormat("Loading device parameters for {0} (isOnline: {1})...", DeviceModel, DeviceModel.IsOnline);
            if (DeviceModel.IsOnline)
            {
                var result = DeviceModel.FdtService
                    .GetService<DtmSingleDeviceDataAccessService>()
                    .GetOnlineDeviceParameters();

                s_log.InfoFormat("Loading device parameters for {0} done.", DeviceModel);
                return result;
            }

            var singleInstanceParameters = DeviceModel.FdtService
                .GetService<DtmSingleInstanceDataAccessService>()
                .GetOfflineDeviceParameters();

            var dtmParameters = DeviceModel.FdtService
                .GetService<DtmParameterService>()
                .GetDtmParameters();

            s_log.InfoFormat("Loading device parameters for {0} done.", DeviceModel);
            return DtmParameterMerger.Merge(singleInstanceParameters, dtmParameters);
        }
    }
}
