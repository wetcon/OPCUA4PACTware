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

using System.Linq;
using Opc.Ua;
using Opc.Ua.Di;
using PWID.Enumerations;
using PWID.Interfaces;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt;

namespace Wetcon.PactwarePlugin.OpcUaServer.OpcUa.Models
{
    /// <summary>
    /// Device model.
    /// </summary>
    public abstract class BaseDeviceModel : DeviceState
    {
        /// <summary>
        /// Pactware ProjectNode
        /// </summary>
        public IPACTwareProjectNode PactwareProjectNode { get; }

        /// <summary>
        /// FdtService.
        /// </summary>
        public IFdtServiceProvider FdtService { get; }

        /// <summary>
        /// DeviceModel Type.
        /// </summary>
        protected abstract DeviceModelType DeviceModelType { get; }

        /// <summary>
        /// Device Id.
        /// </summary>
        public string DeviceId { get; }

        /// <summary>
        /// Device name.
        /// </summary>
        public string DeviceName { get; }

        /// <summary>
        /// Flag to determine whether to read IO process data.
        /// </summary>
        public bool ReadIOProcessData { get; }

        public ushort ServerNamespaceIndex { get; }

        /// <summary>
        /// Initializes a new instance of <see cref="BaseDeviceModel"/>.
        /// </summary>
        /// <param name="serverNamespaceIndex"></param>
        /// <param name="pactwareProjectNode"></param>
        /// <param name="fdtService"></param>
        /// <param name="parent"></param>
        /// <param name="readIOProcessData"></param>
        protected BaseDeviceModel(ushort serverNamespaceIndex, IPACTwareProjectNode pactwareProjectNode,
            IFdtServiceProvider fdtService, NodeState parent, bool readIOProcessData)
            : base(parent)
        {
            PactwareProjectNode = pactwareProjectNode;
            FdtService = fdtService;
            DeviceId = PactwareProjectNode.CatalogueObject.Id;

            NodeId = new NodeId($"{parent.NodeId.Identifier}.Device.{DeviceId}", 2);

            DeviceName = !string.IsNullOrWhiteSpace(PactwareProjectNode.Tagname) ?
                PactwareProjectNode.Tagname : PactwareProjectNode.DeviceName;

            ReadIOProcessData = readIOProcessData;
            ServerNamespaceIndex = serverNamespaceIndex;
            ParameterSet = new ParameterSetModel(this);
            WriteMask = AttributeWriteMask.None;
            UserWriteMask = AttributeWriteMask.None;
            EventNotifier = EventNotifiers.None;
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            Manufacturer.Value = new LocalizedText(PactwareProjectNode.CatalogueObject.Vendor);
            Model.Value = new LocalizedText(PactwareProjectNode.CatalogueObject.Name);
            DeviceClass.Value = GetDeviceClass();
            SerialNumber.Value = DeviceId;

            var deviceHealth = GetDeviceHealth();

            if (deviceHealth.HasValue)
            {
                DeviceHealth.Value = deviceHealth.Value;
            }
        }

        private string GetDeviceClass()
        {
            string deviceClass = null;

            if (!(PactwareProjectNode.CatalogueObject is IPACTwareCatalogueNodeInfo pactwareCatalogNodeInfo))
            {
                return deviceClass;
            }

            var classificationDomain = pactwareCatalogNodeInfo.ClassificationDomain;
            var classification = pactwareCatalogNodeInfo.Classifications.FirstOrDefault();

            if (!string.IsNullOrWhiteSpace(classificationDomain))
            {
                deviceClass = classificationDomain;
            }

            if (string.IsNullOrWhiteSpace(classification?.Classification))
            {
                return deviceClass;
            }

            if (string.IsNullOrWhiteSpace(deviceClass))
            {
                deviceClass = classification.Classification;
            }
            else
            {
                deviceClass = deviceClass + "." + classification.Classification;
            }

            return deviceClass;
        }

        private DeviceHealthEnumeration? GetDeviceHealth()
        {
            if (!(PactwareProjectNode is IPACTwareProjectNodeDiagnosis projectNodeDiagnosis))
            {
                return DeviceHealthEnumeration.NORMAL;
            }

            switch (projectNodeDiagnosis.State)
            {
                case PACTwareEnumProjectNodeDiagnosisState.CHECK_FUNCTION:
                    return DeviceHealthEnumeration.CHECK_FUNCTION;
                case PACTwareEnumProjectNodeDiagnosisState.FAILURE:
                    return DeviceHealthEnumeration.FAILURE;
                case PACTwareEnumProjectNodeDiagnosisState.MAINTENANCE_REQUIRED:
                    return DeviceHealthEnumeration.MAINTENANCE_REQUIRED;
                case PACTwareEnumProjectNodeDiagnosisState.OUT_OF_SPECIFICATION:
                    return DeviceHealthEnumeration.OFF_SPEC;
                case PACTwareEnumProjectNodeDiagnosisState.NOT_SUPPORTED:
                case PACTwareEnumProjectNodeDiagnosisState.DIAGNOSIS_ACTIVE:
                case PACTwareEnumProjectNodeDiagnosisState.DIAGNOSIS_PASSIVE:
                    return null;
                default:
                    return DeviceHealthEnumeration.NORMAL;
            }
        }

        public bool IsOnline => DeviceModelType == DeviceModelType.Online;

        public override void Dispose()
        {
            FdtService?.OnUnloadProjectNode();
            base.Dispose();
        }
    }

    /// <summary>
    /// Device model type enumeration.
    /// </summary>
    public enum DeviceModelType
    {
        /// <summary>
        /// Offline device model.
        /// </summary>
        Offline,
        /// <summary>
        /// Online device model.
        /// </summary>
        Online
    }
}
