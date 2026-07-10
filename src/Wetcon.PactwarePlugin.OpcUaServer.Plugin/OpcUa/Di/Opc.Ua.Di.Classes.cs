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


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA1515 // Consider making public types internal
#pragma warning disable CA1707 // Identifiers should not contain underscores
#pragma warning disable CA1028 // Enum Storage should be Int32

namespace Opc.Ua.DI
{
    #region TopologyElementTypeState Class
    #if (!OPCUA_EXCLUDE_TopologyElementTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class TopologyElementTypeState : BaseObjectState
    {
        #region Constructors
        public TopologyElementTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.TopologyElementType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (ParameterSet != null)
            {
                ParameterSet.Initialize(context, ParameterSet_InitializationString);
            }

            if (MethodSet != null)
            {
                MethodSet.Initialize(context, MethodSet_InitializationString);
            }

            if (Identification != null)
            {
                Identification.Initialize(context, Identification_InitializationString);
            }

            if (Lock != null)
            {
                Lock.Initialize(context, Lock_InitializationString);
            }
        }

        #region Initialization String
        private const string ParameterSet_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAMAAAAUGFy" +
           "YW1ldGVyU2V0AQGKEwAvADqKEwAA/////wEAAAAVYMkKAgAAAB8AAABQYXJhbWV0ZXJJZGVudGlmaWVy" +
           "X1BsYWNlaG9sZGVyAQAVAAAAPFBhcmFtZXRlcklkZW50aWZpZXI+AQGBFwAvAD+BFwAAABj/////AQH/" +
           "////AAAAAA==";

        private const string MethodSet_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAJAAAATWV0" +
           "aG9kU2V0AQGLEwAvADqLEwAA/////wAAAAA=";

        private const string Identification_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAOAAAASWRl" +
           "bnRpZmljYXRpb24BAX4XAC8BAe0DfhcAAP////8AAAAA";

        private const string Lock_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAEAAAATG9j" +
           "awEBERgALwEB9BgRGAAA/////wgAAAAVYIkKAgAAAAEABgAAAExvY2tlZAEBRBkALgBERBkAAAAB////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEADQAAAExvY2tpbmdDbGllbnQBARMYAC4ARBMYAAAADP////8BAf//" +
           "//8AAAAAFWCJCgIAAAABAAsAAABMb2NraW5nVXNlcgEBFBgALgBEFBgAAAAM/////wEB/////wAAAAAV" +
           "YIkKAgAAAAEAEQAAAFJlbWFpbmluZ0xvY2tUaW1lAQEVGAAuAEQVGAAAAQAiAf////8BAf////8AAAAA" +
           "BGGCCgQAAAABAAgAAABJbml0TG9jawEBFhgALwEB+RgWGAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAA" +
           "SW5wdXRBcmd1bWVudHMBARcYAC4ARBcYAACWAQAAAAEAKgEBFgAAAAcAAABDb250ZXh0AAz/////AAAA" +
           "AAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQEY" +
           "GAAuAEQYGAAAlgEAAAABACoBAR0AAAAOAAAASW5pdExvY2tTdGF0dXMABv////8AAAAAAAEAKAEBAAAA" +
           "AQAAAAEAAAABAf////8AAAAABGGCCgQAAAABAAkAAABSZW5ld0xvY2sBARkYAC8BAfwYGRgAAAEB////" +
           "/wEAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBGhgALgBEGhgAAJYBAAAAAQAqAQEeAAAA" +
           "DwAAAFJlbmV3TG9ja1N0YXR1cwAG/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIK" +
           "BAAAAAEACAAAAEV4aXRMb2NrAQEbGAAvAQH+GBsYAAABAf////8BAAAAF2CpCgIAAAAAAA8AAABPdXRw" +
           "dXRBcmd1bWVudHMBARwYAC4ARBwYAACWAQAAAAEAKgEBHQAAAA4AAABFeGl0TG9ja1N0YXR1cwAG////" +
           "/wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIKBAAAAAEACQAAAEJyZWFrTG9jawEBHRgA" +
           "LwEBABkdGAAAAQH/////AQAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQEeGAAuAEQeGAAA" +
           "lgEAAAABACoBAR4AAAAPAAAAQnJlYWtMb2NrU3RhdHVzAAb/////AAAAAAABACgBAQAAAAEAAAABAAAA" +
           "AQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAbAAAAVG9w" +
           "b2xvZ3lFbGVtZW50VHlwZUluc3RhbmNlAQHpAwEB6QPpAwAA/////wUAAAAEYIAKAQAAAAEADAAAAFBh" +
           "cmFtZXRlclNldAEBihMALwA6ihMAAP////8BAAAAFWDJCgIAAAAfAAAAUGFyYW1ldGVySWRlbnRpZmll" +
           "cl9QbGFjZWhvbGRlcgEAFQAAADxQYXJhbWV0ZXJJZGVudGlmaWVyPgEBgRcALwA/gRcAAAAY/////wEB" +
           "/////wAAAAAEYIAKAQAAAAEACQAAAE1ldGhvZFNldAEBixMALwA6ixMAAP////8AAAAABGDACgEAAAAb" +
           "AAAAR3JvdXBJZGVudGlmaWVyX1BsYWNlaG9sZGVyAQARAAAAPEdyb3VwSWRlbnRpZmllcj4BAacZAC8B" +
           "Ae0DpxkAAP////8AAAAABGCACgEAAAABAA4AAABJZGVudGlmaWNhdGlvbgEBfhcALwEB7QN+FwAA////" +
           "/wAAAAAEYIAKAQAAAAEABAAAAExvY2sBAREYAC8BAfQYERgAAP////8IAAAAFWCJCgIAAAABAAYAAABM" +
           "b2NrZWQBAUQZAC4AREQZAAAAAf////8BAf////8AAAAAFWCJCgIAAAABAA0AAABMb2NraW5nQ2xpZW50" +
           "AQETGAAuAEQTGAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAATG9ja2luZ1VzZXIBARQYAC4A" +
           "RBQYAAAADP////8BAf////8AAAAAFWCJCgIAAAABABEAAABSZW1haW5pbmdMb2NrVGltZQEBFRgALgBE" +
           "FRgAAAEAIgH/////AQH/////AAAAAARhggoEAAAAAQAIAAAASW5pdExvY2sBARYYAC8BAfkYFhgAAAEB" +
           "/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQEXGAAuAEQXGAAAlgEAAAABACoBARYA" +
           "AAAHAAAAQ29udGV4dAAM/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAXYKkKAgAAAAAA" +
           "DwAAAE91dHB1dEFyZ3VtZW50cwEBGBgALgBEGBgAAJYBAAAAAQAqAQEdAAAADgAAAEluaXRMb2NrU3Rh" +
           "dHVzAAb/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAAARhggoEAAAAAQAJAAAAUmVuZXdM" +
           "b2NrAQEZGAAvAQH8GBkYAAABAf////8BAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBARoY" +
           "AC4ARBoYAACWAQAAAAEAKgEBHgAAAA8AAABSZW5ld0xvY2tTdGF0dXMABv////8AAAAAAAEAKAEBAAAA" +
           "AQAAAAEAAAABAf////8AAAAABGGCCgQAAAABAAgAAABFeGl0TG9jawEBGxgALwEB/hgbGAAAAQH/////" +
           "AQAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQEcGAAuAEQcGAAAlgEAAAABACoBAR0AAAAO" +
           "AAAARXhpdExvY2tTdGF0dXMABv////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAABGGCCgQA" +
           "AAABAAkAAABCcmVha0xvY2sBAR0YAC8BAQAZHRgAAAEB/////wEAAAAXYKkKAgAAAAAADwAAAE91dHB1" +
           "dEFyZ3VtZW50cwEBHhgALgBEHhgAAJYBAAAAAQAqAQEeAAAADwAAAEJyZWFrTG9ja1N0YXR1cwAG////" +
           "/wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public BaseObjectState ParameterSet
        {
            get => m_parameterSet;

            set
            {
                if (!Object.ReferenceEquals(m_parameterSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_parameterSet = value;
            }
        }

        public BaseObjectState MethodSet
        {
            get => m_methodSet;

            set
            {
                if (!Object.ReferenceEquals(m_methodSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_methodSet = value;
            }
        }

        public FunctionalGroupTypeState Identification
        {
            get => m_identification;

            set
            {
                if (!Object.ReferenceEquals(m_identification, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_identification = value;
            }
        }

        public LockingServicesTypeState Lock
        {
            get => m_lock;

            set
            {
                if (!Object.ReferenceEquals(m_lock, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lock = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_parameterSet != null)
            {
                children.Add(m_parameterSet);
            }

            if (m_methodSet != null)
            {
                children.Add(m_methodSet);
            }

            if (m_identification != null)
            {
                children.Add(m_identification);
            }

            if (m_lock != null)
            {
                children.Add(m_lock);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_parameterSet, child))
            {
                m_parameterSet = null;
                return;
            }

            if (Object.ReferenceEquals(m_methodSet, child))
            {
                m_methodSet = null;
                return;
            }

            if (Object.ReferenceEquals(m_identification, child))
            {
                m_identification = null;
                return;
            }

            if (Object.ReferenceEquals(m_lock, child))
            {
                m_lock = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.ParameterSet:
                {
                    if (createOrReplace)
                    {
                        if (ParameterSet == null)
                        {
                            if (replacement == null)
                            {
                                ParameterSet = new BaseObjectState(this);
                            }
                            else
                            {
                                ParameterSet = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = ParameterSet;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.MethodSet:
                {
                    if (createOrReplace)
                    {
                        if (MethodSet == null)
                        {
                            if (replacement == null)
                            {
                                MethodSet = new BaseObjectState(this);
                            }
                            else
                            {
                                MethodSet = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = MethodSet;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.Identification:
                {
                    if (createOrReplace)
                    {
                        if (Identification == null)
                        {
                            if (replacement == null)
                            {
                                Identification = new FunctionalGroupTypeState(this);
                            }
                            else
                            {
                                Identification = (FunctionalGroupTypeState)replacement;
                            }
                        }
                    }

                    instance = Identification;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.Lock:
                {
                    if (createOrReplace)
                    {
                        if (Lock == null)
                        {
                            if (replacement == null)
                            {
                                Lock = new LockingServicesTypeState(this);
                            }
                            else
                            {
                                Lock = (LockingServicesTypeState)replacement;
                            }
                        }
                    }

                    instance = Lock;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseObjectState m_parameterSet;
        private BaseObjectState m_methodSet;
        private FunctionalGroupTypeState m_identification;
        private LockingServicesTypeState m_lock;
        #endregion
    }
    #endif
    #endregion

    #region IVendorNameplateTypeState Class
    #if (!OPCUA_EXCLUDE_IVendorNameplateTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class IVendorNameplateTypeState : BaseInterfaceState
    {
        #region Constructors
        public IVendorNameplateTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.IVendorNameplateType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Manufacturer != null)
            {
                Manufacturer.Initialize(context, Manufacturer_InitializationString);
            }

            if (ManufacturerUri != null)
            {
                ManufacturerUri.Initialize(context, ManufacturerUri_InitializationString);
            }

            if (Model != null)
            {
                Model.Initialize(context, Model_InitializationString);
            }

            if (HardwareRevision != null)
            {
                HardwareRevision.Initialize(context, HardwareRevision_InitializationString);
            }

            if (SoftwareRevision != null)
            {
                SoftwareRevision.Initialize(context, SoftwareRevision_InitializationString);
            }

            if (DeviceRevision != null)
            {
                DeviceRevision.Initialize(context, DeviceRevision_InitializationString);
            }

            if (ProductCode != null)
            {
                ProductCode.Initialize(context, ProductCode_InitializationString);
            }

            if (DeviceManual != null)
            {
                DeviceManual.Initialize(context, DeviceManual_InitializationString);
            }

            if (DeviceClass != null)
            {
                DeviceClass.Initialize(context, DeviceClass_InitializationString);
            }

            if (SerialNumber != null)
            {
                SerialNumber.Initialize(context, SerialNumber_InitializationString);
            }

            if (ProductInstanceUri != null)
            {
                ProductInstanceUri.Initialize(context, ProductInstanceUri_InitializationString);
            }

            if (RevisionCounter != null)
            {
                RevisionCounter.Initialize(context, RevisionCounter_InitializationString);
            }

            if (SoftwareReleaseDate != null)
            {
                SoftwareReleaseDate.Initialize(context, SoftwareReleaseDate_InitializationString);
            }

            if (PatchIdentifiers != null)
            {
                PatchIdentifiers.Initialize(context, PatchIdentifiers_InitializationString);
            }
        }

        #region Initialization String
        private const string Manufacturer_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAMAAAATWFu" +
           "dWZhY3R1cmVyAQG8OgAuAES8OgAAABX/////AQH/////AAAAAA==";

        private const string ManufacturerUri_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAPAAAATWFu" +
           "dWZhY3R1cmVyVXJpAQG9OgAuAES9OgAAAAz/////AQH/////AAAAAA==";

        private const string Model_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAFAAAATW9k" +
           "ZWwBAb46AC4ARL46AAAAFf////8BAf////8AAAAA";

        private const string HardwareRevision_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAQAAAASGFy" +
           "ZHdhcmVSZXZpc2lvbgEBvzoALgBEvzoAAAAM/////wEB/////wAAAAA=";

        private const string SoftwareRevision_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAQAAAAU29m" +
           "dHdhcmVSZXZpc2lvbgEBwDoALgBEwDoAAAAM/////wEB/////wAAAAA=";

        private const string DeviceRevision_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAOAAAARGV2" +
           "aWNlUmV2aXNpb24BAcE6AC4ARME6AAAADP////8BAf////8AAAAA";

        private const string ProductCode_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQALAAAAUHJv" +
           "ZHVjdENvZGUBAcI6AC4ARMI6AAAADP////8BAf////8AAAAA";

        private const string DeviceManual_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAMAAAARGV2" +
           "aWNlTWFudWFsAQHDOgAuAETDOgAAAAz/////AQH/////AAAAAA==";

        private const string DeviceClass_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQALAAAARGV2" +
           "aWNlQ2xhc3MBAcQ6AC4ARMQ6AAAADP////8BAf////8AAAAA";

        private const string SerialNumber_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAMAAAAU2Vy" +
           "aWFsTnVtYmVyAQHFOgAuAETFOgAAAAz/////AQH/////AAAAAA==";

        private const string ProductInstanceUri_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQASAAAAUHJv" +
           "ZHVjdEluc3RhbmNlVXJpAQHGOgAuAETGOgAAAAz/////AQH/////AAAAAA==";

        private const string RevisionCounter_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAPAAAAUmV2" +
           "aXNpb25Db3VudGVyAQHHOgAuAETHOgAAAAb/////AQH/////AAAAAA==";

        private const string SoftwareReleaseDate_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQATAAAAU29m" +
           "dHdhcmVSZWxlYXNlRGF0ZQEBFwAALgBEFwAAAAAN/////wEB/////wAAAAA=";

        private const string PatchIdentifiers_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xdgiQoCAAAAAQAQAAAAUGF0" +
           "Y2hJZGVudGlmaWVycwEBGAAALgBEGAAAAAAMAQAAAAEAAAAAAAAAAQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAcAAAASVZl" +
           "bmRvck5hbWVwbGF0ZVR5cGVJbnN0YW5jZQEBuzoBAbs6uzoAAP////8OAAAAFWCJCgIAAAABAAwAAABN" +
           "YW51ZmFjdHVyZXIBAbw6AC4ARLw6AAAAFf////8BAf////8AAAAAFWCJCgIAAAABAA8AAABNYW51ZmFj" +
           "dHVyZXJVcmkBAb06AC4ARL06AAAADP////8BAf////8AAAAAFWCJCgIAAAABAAUAAABNb2RlbAEBvjoA" +
           "LgBEvjoAAAAV/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEhhcmR3YXJlUmV2aXNpb24BAb86AC4A" +
           "RL86AAAADP////8BAf////8AAAAAFWCJCgIAAAABABAAAABTb2Z0d2FyZVJldmlzaW9uAQHAOgAuAETA" +
           "OgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAOAAAARGV2aWNlUmV2aXNpb24BAcE6AC4ARME6AAAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABQcm9kdWN0Q29kZQEBwjoALgBEwjoAAAAM/////wEB" +
           "/////wAAAAAVYIkKAgAAAAEADAAAAERldmljZU1hbnVhbAEBwzoALgBEwzoAAAAM/////wEB/////wAA" +
           "AAAVYIkKAgAAAAEACwAAAERldmljZUNsYXNzAQHEOgAuAETEOgAAAAz/////AQH/////AAAAABVgiQoC" +
           "AAAAAQAMAAAAU2VyaWFsTnVtYmVyAQHFOgAuAETFOgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAS" +
           "AAAAUHJvZHVjdEluc3RhbmNlVXJpAQHGOgAuAETGOgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAP" +
           "AAAAUmV2aXNpb25Db3VudGVyAQHHOgAuAETHOgAAAAb/////AQH/////AAAAABVgiQoCAAAAAQATAAAA" +
           "U29mdHdhcmVSZWxlYXNlRGF0ZQEBFwAALgBEFwAAAAAN/////wEB/////wAAAAAXYIkKAgAAAAEAEAAA" +
           "AFBhdGNoSWRlbnRpZmllcnMBARgAAC4ARBgAAAAADAEAAAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public PropertyState<LocalizedText> Manufacturer
        {
            get => m_manufacturer;

            set
            {
                if (!Object.ReferenceEquals(m_manufacturer, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manufacturer = value;
            }
        }

        public PropertyState<string> ManufacturerUri
        {
            get => m_manufacturerUri;

            set
            {
                if (!Object.ReferenceEquals(m_manufacturerUri, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manufacturerUri = value;
            }
        }

        public PropertyState<LocalizedText> Model
        {
            get => m_model;

            set
            {
                if (!Object.ReferenceEquals(m_model, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_model = value;
            }
        }

        public PropertyState<string> HardwareRevision
        {
            get => m_hardwareRevision;

            set
            {
                if (!Object.ReferenceEquals(m_hardwareRevision, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_hardwareRevision = value;
            }
        }

        public PropertyState<string> SoftwareRevision
        {
            get => m_softwareRevision;

            set
            {
                if (!Object.ReferenceEquals(m_softwareRevision, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_softwareRevision = value;
            }
        }

        public PropertyState<string> DeviceRevision
        {
            get => m_deviceRevision;

            set
            {
                if (!Object.ReferenceEquals(m_deviceRevision, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceRevision = value;
            }
        }

        public PropertyState<string> ProductCode
        {
            get => m_productCode;

            set
            {
                if (!Object.ReferenceEquals(m_productCode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_productCode = value;
            }
        }

        public PropertyState<string> DeviceManual
        {
            get => m_deviceManual;

            set
            {
                if (!Object.ReferenceEquals(m_deviceManual, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceManual = value;
            }
        }

        public PropertyState<string> DeviceClass
        {
            get => m_deviceClass;

            set
            {
                if (!Object.ReferenceEquals(m_deviceClass, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceClass = value;
            }
        }

        public PropertyState<string> SerialNumber
        {
            get => m_serialNumber;

            set
            {
                if (!Object.ReferenceEquals(m_serialNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_serialNumber = value;
            }
        }

        public PropertyState<string> ProductInstanceUri
        {
            get => m_productInstanceUri;

            set
            {
                if (!Object.ReferenceEquals(m_productInstanceUri, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_productInstanceUri = value;
            }
        }

        public PropertyState<int> RevisionCounter
        {
            get => m_revisionCounter;

            set
            {
                if (!Object.ReferenceEquals(m_revisionCounter, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_revisionCounter = value;
            }
        }

        public PropertyState<DateTime> SoftwareReleaseDate
        {
            get => m_softwareReleaseDate;

            set
            {
                if (!Object.ReferenceEquals(m_softwareReleaseDate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_softwareReleaseDate = value;
            }
        }

        public PropertyState<string[]> PatchIdentifiers
        {
            get => m_patchIdentifiers;

            set
            {
                if (!Object.ReferenceEquals(m_patchIdentifiers, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_patchIdentifiers = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_manufacturer != null)
            {
                children.Add(m_manufacturer);
            }

            if (m_manufacturerUri != null)
            {
                children.Add(m_manufacturerUri);
            }

            if (m_model != null)
            {
                children.Add(m_model);
            }

            if (m_hardwareRevision != null)
            {
                children.Add(m_hardwareRevision);
            }

            if (m_softwareRevision != null)
            {
                children.Add(m_softwareRevision);
            }

            if (m_deviceRevision != null)
            {
                children.Add(m_deviceRevision);
            }

            if (m_productCode != null)
            {
                children.Add(m_productCode);
            }

            if (m_deviceManual != null)
            {
                children.Add(m_deviceManual);
            }

            if (m_deviceClass != null)
            {
                children.Add(m_deviceClass);
            }

            if (m_serialNumber != null)
            {
                children.Add(m_serialNumber);
            }

            if (m_productInstanceUri != null)
            {
                children.Add(m_productInstanceUri);
            }

            if (m_revisionCounter != null)
            {
                children.Add(m_revisionCounter);
            }

            if (m_softwareReleaseDate != null)
            {
                children.Add(m_softwareReleaseDate);
            }

            if (m_patchIdentifiers != null)
            {
                children.Add(m_patchIdentifiers);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_manufacturer, child))
            {
                m_manufacturer = null;
                return;
            }

            if (Object.ReferenceEquals(m_manufacturerUri, child))
            {
                m_manufacturerUri = null;
                return;
            }

            if (Object.ReferenceEquals(m_model, child))
            {
                m_model = null;
                return;
            }

            if (Object.ReferenceEquals(m_hardwareRevision, child))
            {
                m_hardwareRevision = null;
                return;
            }

            if (Object.ReferenceEquals(m_softwareRevision, child))
            {
                m_softwareRevision = null;
                return;
            }

            if (Object.ReferenceEquals(m_deviceRevision, child))
            {
                m_deviceRevision = null;
                return;
            }

            if (Object.ReferenceEquals(m_productCode, child))
            {
                m_productCode = null;
                return;
            }

            if (Object.ReferenceEquals(m_deviceManual, child))
            {
                m_deviceManual = null;
                return;
            }

            if (Object.ReferenceEquals(m_deviceClass, child))
            {
                m_deviceClass = null;
                return;
            }

            if (Object.ReferenceEquals(m_serialNumber, child))
            {
                m_serialNumber = null;
                return;
            }

            if (Object.ReferenceEquals(m_productInstanceUri, child))
            {
                m_productInstanceUri = null;
                return;
            }

            if (Object.ReferenceEquals(m_revisionCounter, child))
            {
                m_revisionCounter = null;
                return;
            }

            if (Object.ReferenceEquals(m_softwareReleaseDate, child))
            {
                m_softwareReleaseDate = null;
                return;
            }

            if (Object.ReferenceEquals(m_patchIdentifiers, child))
            {
                m_patchIdentifiers = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.Manufacturer:
                {
                    if (createOrReplace)
                    {
                        if (Manufacturer == null)
                        {
                            if (replacement == null)
                            {
                                Manufacturer = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                Manufacturer = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = Manufacturer;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.ManufacturerUri:
                {
                    if (createOrReplace)
                    {
                        if (ManufacturerUri == null)
                        {
                            if (replacement == null)
                            {
                                ManufacturerUri = new PropertyState<string>(this);
                            }
                            else
                            {
                                ManufacturerUri = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ManufacturerUri;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.Model:
                {
                    if (createOrReplace)
                    {
                        if (Model == null)
                        {
                            if (replacement == null)
                            {
                                Model = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                Model = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = Model;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.HardwareRevision:
                {
                    if (createOrReplace)
                    {
                        if (HardwareRevision == null)
                        {
                            if (replacement == null)
                            {
                                HardwareRevision = new PropertyState<string>(this);
                            }
                            else
                            {
                                HardwareRevision = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = HardwareRevision;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.SoftwareRevision:
                {
                    if (createOrReplace)
                    {
                        if (SoftwareRevision == null)
                        {
                            if (replacement == null)
                            {
                                SoftwareRevision = new PropertyState<string>(this);
                            }
                            else
                            {
                                SoftwareRevision = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SoftwareRevision;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.DeviceRevision:
                {
                    if (createOrReplace)
                    {
                        if (DeviceRevision == null)
                        {
                            if (replacement == null)
                            {
                                DeviceRevision = new PropertyState<string>(this);
                            }
                            else
                            {
                                DeviceRevision = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceRevision;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.ProductCode:
                {
                    if (createOrReplace)
                    {
                        if (ProductCode == null)
                        {
                            if (replacement == null)
                            {
                                ProductCode = new PropertyState<string>(this);
                            }
                            else
                            {
                                ProductCode = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ProductCode;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.DeviceManual:
                {
                    if (createOrReplace)
                    {
                        if (DeviceManual == null)
                        {
                            if (replacement == null)
                            {
                                DeviceManual = new PropertyState<string>(this);
                            }
                            else
                            {
                                DeviceManual = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceManual;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.DeviceClass:
                {
                    if (createOrReplace)
                    {
                        if (DeviceClass == null)
                        {
                            if (replacement == null)
                            {
                                DeviceClass = new PropertyState<string>(this);
                            }
                            else
                            {
                                DeviceClass = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceClass;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.SerialNumber:
                {
                    if (createOrReplace)
                    {
                        if (SerialNumber == null)
                        {
                            if (replacement == null)
                            {
                                SerialNumber = new PropertyState<string>(this);
                            }
                            else
                            {
                                SerialNumber = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SerialNumber;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.ProductInstanceUri:
                {
                    if (createOrReplace)
                    {
                        if (ProductInstanceUri == null)
                        {
                            if (replacement == null)
                            {
                                ProductInstanceUri = new PropertyState<string>(this);
                            }
                            else
                            {
                                ProductInstanceUri = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ProductInstanceUri;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.RevisionCounter:
                {
                    if (createOrReplace)
                    {
                        if (RevisionCounter == null)
                        {
                            if (replacement == null)
                            {
                                RevisionCounter = new PropertyState<int>(this);
                            }
                            else
                            {
                                RevisionCounter = (PropertyState<int>)replacement;
                            }
                        }
                    }

                    instance = RevisionCounter;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.SoftwareReleaseDate:
                {
                    if (createOrReplace)
                    {
                        if (SoftwareReleaseDate == null)
                        {
                            if (replacement == null)
                            {
                                SoftwareReleaseDate = new PropertyState<DateTime>(this);
                            }
                            else
                            {
                                SoftwareReleaseDate = (PropertyState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = SoftwareReleaseDate;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.PatchIdentifiers:
                {
                    if (createOrReplace)
                    {
                        if (PatchIdentifiers == null)
                        {
                            if (replacement == null)
                            {
                                PatchIdentifiers = new PropertyState<string[]>(this);
                            }
                            else
                            {
                                PatchIdentifiers = (PropertyState<string[]>)replacement;
                            }
                        }
                    }

                    instance = PatchIdentifiers;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<LocalizedText> m_manufacturer;
        private PropertyState<string> m_manufacturerUri;
        private PropertyState<LocalizedText> m_model;
        private PropertyState<string> m_hardwareRevision;
        private PropertyState<string> m_softwareRevision;
        private PropertyState<string> m_deviceRevision;
        private PropertyState<string> m_productCode;
        private PropertyState<string> m_deviceManual;
        private PropertyState<string> m_deviceClass;
        private PropertyState<string> m_serialNumber;
        private PropertyState<string> m_productInstanceUri;
        private PropertyState<int> m_revisionCounter;
        private PropertyState<DateTime> m_softwareReleaseDate;
        private PropertyState<string[]> m_patchIdentifiers;
        #endregion
    }
    #endif
    #endregion

    #region ITagNameplateTypeState Class
    #if (!OPCUA_EXCLUDE_ITagNameplateTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class ITagNameplateTypeState : BaseInterfaceState
    {
        #region Constructors
        public ITagNameplateTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.ITagNameplateType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (AssetId != null)
            {
                AssetId.Initialize(context, AssetId_InitializationString);
            }

            if (ComponentName != null)
            {
                ComponentName.Initialize(context, ComponentName_InitializationString);
            }
        }

        #region Initialization String
        private const string AssetId_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAHAAAAQXNz" +
           "ZXRJZAEByToALgBEyToAAAAM/////wEB/////wAAAAA=";

        private const string ComponentName_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQANAAAAQ29t" +
           "cG9uZW50TmFtZQEByjoALgBEyjoAAAAV/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAZAAAASVRh" +
           "Z05hbWVwbGF0ZVR5cGVJbnN0YW5jZQEByDoBAcg6yDoAAP////8CAAAAFWCJCgIAAAABAAcAAABBc3Nl" +
           "dElkAQHJOgAuAETJOgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQANAAAAQ29tcG9uZW50TmFtZQEB" +
           "yjoALgBEyjoAAAAV/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public PropertyState<string> AssetId
        {
            get => m_assetId;

            set
            {
                if (!Object.ReferenceEquals(m_assetId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_assetId = value;
            }
        }

        public PropertyState<LocalizedText> ComponentName
        {
            get => m_componentName;

            set
            {
                if (!Object.ReferenceEquals(m_componentName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_componentName = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_assetId != null)
            {
                children.Add(m_assetId);
            }

            if (m_componentName != null)
            {
                children.Add(m_componentName);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_assetId, child))
            {
                m_assetId = null;
                return;
            }

            if (Object.ReferenceEquals(m_componentName, child))
            {
                m_componentName = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.AssetId:
                {
                    if (createOrReplace)
                    {
                        if (AssetId == null)
                        {
                            if (replacement == null)
                            {
                                AssetId = new PropertyState<string>(this);
                            }
                            else
                            {
                                AssetId = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = AssetId;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.ComponentName:
                {
                    if (createOrReplace)
                    {
                        if (ComponentName == null)
                        {
                            if (replacement == null)
                            {
                                ComponentName = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                ComponentName = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = ComponentName;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_assetId;
        private PropertyState<LocalizedText> m_componentName;
        #endregion
    }
    #endif
    #endregion

    #region IDeviceHealthTypeState Class
    #if (!OPCUA_EXCLUDE_IDeviceHealthTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class IDeviceHealthTypeState : BaseInterfaceState
    {
        #region Constructors
        public IDeviceHealthTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.IDeviceHealthType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (DeviceHealth != null)
            {
                DeviceHealth.Initialize(context, DeviceHealth_InitializationString);
            }

            if (DeviceHealthAlarms != null)
            {
                DeviceHealthAlarms.Initialize(context, DeviceHealthAlarms_InitializationString);
            }
        }

        #region Initialization String
        private const string DeviceHealth_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAMAAAARGV2" +
           "aWNlSGVhbHRoAQHMOgAvAD/MOgAAAQFkGP////8BAf////8AAAAA";

        private const string DeviceHealthAlarms_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQASAAAARGV2" +
           "aWNlSGVhbHRoQWxhcm1zAQHNOgAvAD3NOgAA/////wAAAAA=";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAZAAAASURl" +
           "dmljZUhlYWx0aFR5cGVJbnN0YW5jZQEByzoBAcs6yzoAAP////8CAAAAFWCJCgIAAAABAAwAAABEZXZp" +
           "Y2VIZWFsdGgBAcw6AC8AP8w6AAABAWQY/////wEB/////wAAAAAEYIAKAQAAAAEAEgAAAERldmljZUhl" +
           "YWx0aEFsYXJtcwEBzToALwA9zToAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public BaseDataVariableState<DeviceHealthEnumeration> DeviceHealth
        {
            get => m_deviceHealth;

            set
            {
                if (!Object.ReferenceEquals(m_deviceHealth, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceHealth = value;
            }
        }

        public FolderState DeviceHealthAlarms
        {
            get => m_deviceHealthAlarms;

            set
            {
                if (!Object.ReferenceEquals(m_deviceHealthAlarms, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceHealthAlarms = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_deviceHealth != null)
            {
                children.Add(m_deviceHealth);
            }

            if (m_deviceHealthAlarms != null)
            {
                children.Add(m_deviceHealthAlarms);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_deviceHealth, child))
            {
                m_deviceHealth = null;
                return;
            }

            if (Object.ReferenceEquals(m_deviceHealthAlarms, child))
            {
                m_deviceHealthAlarms = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.DeviceHealth:
                {
                    if (createOrReplace)
                    {
                        if (DeviceHealth == null)
                        {
                            if (replacement == null)
                            {
                                DeviceHealth = new BaseDataVariableState<DeviceHealthEnumeration>(this);
                            }
                            else
                            {
                                DeviceHealth = (BaseDataVariableState<DeviceHealthEnumeration>)replacement;
                            }
                        }
                    }

                    instance = DeviceHealth;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.DeviceHealthAlarms:
                {
                    if (createOrReplace)
                    {
                        if (DeviceHealthAlarms == null)
                        {
                            if (replacement == null)
                            {
                                DeviceHealthAlarms = new FolderState(this);
                            }
                            else
                            {
                                DeviceHealthAlarms = (FolderState)replacement;
                            }
                        }
                    }

                    instance = DeviceHealthAlarms;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<DeviceHealthEnumeration> m_deviceHealth;
        private FolderState m_deviceHealthAlarms;
        #endregion
    }
    #endif
    #endregion

    #region ISupportInfoTypeState Class
    #if (!OPCUA_EXCLUDE_ISupportInfoTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class ISupportInfoTypeState : BaseInterfaceState
    {
        #region Constructors
        public ISupportInfoTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.ISupportInfoType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (DeviceTypeImage != null)
            {
                DeviceTypeImage.Initialize(context, DeviceTypeImage_InitializationString);
            }

            if (Documentation != null)
            {
                Documentation.Initialize(context, Documentation_InitializationString);
            }

            if (DocumentationFiles != null)
            {
                DocumentationFiles.Initialize(context, DocumentationFiles_InitializationString);
            }

            if (ProtocolSupport != null)
            {
                ProtocolSupport.Initialize(context, ProtocolSupport_InitializationString);
            }

            if (ImageSet != null)
            {
                ImageSet.Initialize(context, ImageSet_InitializationString);
            }
        }

        #region Initialization String
        private const string DeviceTypeImage_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAPAAAARGV2" +
           "aWNlVHlwZUltYWdlAQHPOgAvAD3POgAA/////wEAAAAVYMkKAgAAABsAAABJbWFnZUlkZW50aWZpZXJf" +
           "UGxhY2Vob2xkZXIBABEAAAA8SW1hZ2VJZGVudGlmaWVyPgEB0DoALwA/0DoAAAAe/////wEB/////wAA" +
           "AAA=";

        private const string Documentation_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQANAAAARG9j" +
           "dW1lbnRhdGlvbgEB0ToALwA90ToAAP////8BAAAAFWDJCgIAAAAeAAAARG9jdW1lbnRJZGVudGlmaWVy" +
           "X1BsYWNlaG9sZGVyAQAUAAAAPERvY3VtZW50SWRlbnRpZmllcj4BAdI6AC8AP9I6AAAAD/////8BAf//" +
           "//8AAAAA";

        private const string DocumentationFiles_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQASAAAARG9j" +
           "dW1lbnRhdGlvbkZpbGVzAQEbAAAvAD0bAAAA/////wEAAAAEYMAKAQAAABoAAABEb2N1bWVudEZpbGVJ" +
           "ZF9QbGFjZWhvbGRlcgEAEAAAADxEb2N1bWVudEZpbGVJZD4BARwAAC8BADctHAAAAP////8KAAAAFWCJ" +
           "CgIAAAAAAAQAAABTaXplAQEdAAAuAEQdAAAAAAn/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAV3Jp" +
           "dGFibGUBAR4AAC4ARB4AAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAwAAABVc2VyV3JpdGFibGUB" +
           "AR8AAC4ARB8AAAAAAf////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABPcGVuQ291bnQBASAAAC4ARCAA" +
           "AAAABf////8BAf////8AAAAABGGCCgQAAAAAAAQAAABPcGVuAQEkAAAvAQA8LSQAAAABAf////8CAAAA" +
           "F2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBJQAALgBEJQAAAJYBAAAAAQAqAQETAAAABAAAAE1v" +
           "ZGUAA/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBASYAAC4ARCYAAACWAQAAAAEAKgEBGQAAAAoAAABGaWxlSGFuZGxlAAf/////AAAAAAAB" +
           "ACgBAQAAAAEAAAABAAAAAQH/////AAAAAARhggoEAAAAAAAFAAAAQ2xvc2UBAScAAC8BAD8tJwAAAAEB" +
           "/////wEAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQE+AAAuAEQ+AAAAlgEAAAABACoBARkA" +
           "AAAKAAAARmlsZUhhbmRsZQAH/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIKBAAA" +
           "AAAABAAAAFJlYWQBAT8AAC8BAEEtPwAAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1l" +
           "bnRzAQFAAAAuAERAAAAAlgIAAAABACoBARkAAAAKAAAARmlsZUhhbmRsZQAH/////wAAAAAAAQAqAQEV" +
           "AAAABgAAAExlbmd0aAAG/////wAAAAAAAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAAXYKkKAgAAAAAA" +
           "DwAAAE91dHB1dEFyZ3VtZW50cwEBQQAALgBEQQAAAJYBAAAAAQAqAQETAAAABAAAAERhdGEAD/////8A" +
           "AAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAABGGCCgQAAAAAAAUAAABXcml0ZQEBQgAALwEARC1C" +
           "AAAAAQH/////AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAUMAAC4AREMAAACWAgAAAAEA" +
           "KgEBGQAAAAoAAABGaWxlSGFuZGxlAAf/////AAAAAAABACoBARMAAAAEAAAARGF0YQAP/////wAAAAAA" +
           "AQAoAQEAAAABAAAAAgAAAAEB/////wAAAAAEYYIKBAAAAAAACwAAAEdldFBvc2l0aW9uAQFEAAAvAQBG" +
           "LUQAAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBRQAALgBERQAAAJYBAAAA" +
           "AQAqAQEZAAAACgAAAEZpbGVIYW5kbGUAB/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAA" +
           "F2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAUYAAC4AREYAAACWAQAAAAEAKgEBFwAAAAgAAABQ" +
           "b3NpdGlvbgAJ/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIKBAAAAAAACwAAAFNl" +
           "dFBvc2l0aW9uAQFHAAAvAQBJLUcAAAABAf////8BAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50" +
           "cwEBSAAALgBESAAAAJYCAAAAAQAqAQEZAAAACgAAAEZpbGVIYW5kbGUAB/////8AAAAAAAEAKgEBFwAA" +
           "AAgAAABQb3NpdGlvbgAJ/////wAAAAAAAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAA=";

        private const string ProtocolSupport_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAPAAAAUHJv" +
           "dG9jb2xTdXBwb3J0AQHTOgAvAD3TOgAA/////wEAAAAVYMkKAgAAACUAAABQcm90b2NvbFN1cHBvcnRJ" +
           "ZGVudGlmaWVyX1BsYWNlaG9sZGVyAQAbAAAAPFByb3RvY29sU3VwcG9ydElkZW50aWZpZXI+AQHUOgAv" +
           "AD/UOgAAAA//////AQH/////AAAAAA==";

        private const string ImageSet_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAIAAAASW1h" +
           "Z2VTZXQBAdU6AC8APdU6AAD/////AQAAABVgyQoCAAAAGwAAAEltYWdlSWRlbnRpZmllcl9QbGFjZWhv" +
           "bGRlcgEAEQAAADxJbWFnZUlkZW50aWZpZXI+AQHWOgAvAD/WOgAAAB7/////AQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAYAAAASVN1" +
           "cHBvcnRJbmZvVHlwZUluc3RhbmNlAQHOOgEBzjrOOgAA/////wUAAAAEYIAKAQAAAAEADwAAAERldmlj" +
           "ZVR5cGVJbWFnZQEBzzoALwA9zzoAAP////8BAAAAFWDJCgIAAAAbAAAASW1hZ2VJZGVudGlmaWVyX1Bs" +
           "YWNlaG9sZGVyAQARAAAAPEltYWdlSWRlbnRpZmllcj4BAdA6AC8AP9A6AAAAHv////8BAf////8AAAAA" +
           "BGCACgEAAAABAA0AAABEb2N1bWVudGF0aW9uAQHROgAvAD3ROgAA/////wEAAAAVYMkKAgAAAB4AAABE" +
           "b2N1bWVudElkZW50aWZpZXJfUGxhY2Vob2xkZXIBABQAAAA8RG9jdW1lbnRJZGVudGlmaWVyPgEB0joA" +
           "LwA/0joAAAAP/////wEB/////wAAAAAEYIAKAQAAAAEAEgAAAERvY3VtZW50YXRpb25GaWxlcwEBGwAA" +
           "LwA9GwAAAP////8BAAAABGDACgEAAAAaAAAARG9jdW1lbnRGaWxlSWRfUGxhY2Vob2xkZXIBABAAAAA8" +
           "RG9jdW1lbnRGaWxlSWQ+AQEcAAAvAQA3LRwAAAD/////CgAAABVgiQoCAAAAAAAEAAAAU2l6ZQEBHQAA" +
           "LgBEHQAAAAAJ/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFdyaXRhYmxlAQEeAAAuAEQeAAAAAAH/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAMAAAAVXNlcldyaXRhYmxlAQEfAAAuAEQfAAAAAAH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAJAAAAT3BlbkNvdW50AQEgAAAuAEQgAAAAAAX/////AQH/////AAAAAARh" +
           "ggoEAAAAAAAEAAAAT3BlbgEBJAAALwEAPC0kAAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRB" +
           "cmd1bWVudHMBASUAAC4ARCUAAACWAQAAAAEAKgEBEwAAAAQAAABNb2RlAAP/////AAAAAAABACgBAQAA" +
           "AAEAAAABAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQEmAAAuAEQmAAAA" +
           "lgEAAAABACoBARkAAAAKAAAARmlsZUhhbmRsZQAH/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB////" +
           "/wAAAAAEYYIKBAAAAAAABQAAAENsb3NlAQEnAAAvAQA/LScAAAABAf////8BAAAAF2CpCgIAAAAAAA4A" +
           "AABJbnB1dEFyZ3VtZW50cwEBPgAALgBEPgAAAJYBAAAAAQAqAQEZAAAACgAAAEZpbGVIYW5kbGUAB///" +
           "//8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAABGGCCgQAAAAAAAQAAABSZWFkAQE/AAAvAQBB" +
           "LT8AAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBQAAALgBEQAAAAJYCAAAA" +
           "AQAqAQEZAAAACgAAAEZpbGVIYW5kbGUAB/////8AAAAAAAEAKgEBFQAAAAYAAABMZW5ndGgABv////8A" +
           "AAAAAAEAKAEBAAAAAQAAAAIAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMB" +
           "AUEAAC4AREEAAACWAQAAAAEAKgEBEwAAAAQAAABEYXRhAA//////AAAAAAABACgBAQAAAAEAAAABAAAA" +
           "AQH/////AAAAAARhggoEAAAAAAAFAAAAV3JpdGUBAUIAAC8BAEQtQgAAAAEB/////wEAAAAXYKkKAgAA" +
           "AAAADgAAAElucHV0QXJndW1lbnRzAQFDAAAuAERDAAAAlgIAAAABACoBARkAAAAKAAAARmlsZUhhbmRs" +
           "ZQAH/////wAAAAAAAQAqAQETAAAABAAAAERhdGEAD/////8AAAAAAAEAKAEBAAAAAQAAAAIAAAABAf//" +
           "//8AAAAABGGCCgQAAAAAAAsAAABHZXRQb3NpdGlvbgEBRAAALwEARi1EAAAAAQH/////AgAAABdgqQoC" +
           "AAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAUUAAC4AREUAAACWAQAAAAEAKgEBGQAAAAoAAABGaWxlSGFu" +
           "ZGxlAAf/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0" +
           "QXJndW1lbnRzAQFGAAAuAERGAAAAlgEAAAABACoBARcAAAAIAAAAUG9zaXRpb24ACf////8AAAAAAAEA" +
           "KAEBAAAAAQAAAAEAAAABAf////8AAAAABGGCCgQAAAAAAAsAAABTZXRQb3NpdGlvbgEBRwAALwEASS1H" +
           "AAAAAQH/////AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAUgAAC4AREgAAACWAgAAAAEA" +
           "KgEBGQAAAAoAAABGaWxlSGFuZGxlAAf/////AAAAAAABACoBARcAAAAIAAAAUG9zaXRpb24ACf////8A" +
           "AAAAAAEAKAEBAAAAAQAAAAIAAAABAf////8AAAAABGCACgEAAAABAA8AAABQcm90b2NvbFN1cHBvcnQB" +
           "AdM6AC8APdM6AAD/////AQAAABVgyQoCAAAAJQAAAFByb3RvY29sU3VwcG9ydElkZW50aWZpZXJfUGxh" +
           "Y2Vob2xkZXIBABsAAAA8UHJvdG9jb2xTdXBwb3J0SWRlbnRpZmllcj4BAdQ6AC8AP9Q6AAAAD/////8B" +
           "Af////8AAAAABGCACgEAAAABAAgAAABJbWFnZVNldAEB1ToALwA91ToAAP////8BAAAAFWDJCgIAAAAb" +
           "AAAASW1hZ2VJZGVudGlmaWVyX1BsYWNlaG9sZGVyAQARAAAAPEltYWdlSWRlbnRpZmllcj4BAdY6AC8A" +
           "P9Y6AAAAHv////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public FolderState DeviceTypeImage
        {
            get => m_deviceTypeImage;

            set
            {
                if (!Object.ReferenceEquals(m_deviceTypeImage, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceTypeImage = value;
            }
        }

        public FolderState Documentation
        {
            get => m_documentation;

            set
            {
                if (!Object.ReferenceEquals(m_documentation, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_documentation = value;
            }
        }

        public FolderState DocumentationFiles
        {
            get => m_documentationFiles;

            set
            {
                if (!Object.ReferenceEquals(m_documentationFiles, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_documentationFiles = value;
            }
        }

        public FolderState ProtocolSupport
        {
            get => m_protocolSupport;

            set
            {
                if (!Object.ReferenceEquals(m_protocolSupport, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_protocolSupport = value;
            }
        }

        public FolderState ImageSet
        {
            get => m_imageSet;

            set
            {
                if (!Object.ReferenceEquals(m_imageSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_imageSet = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_deviceTypeImage != null)
            {
                children.Add(m_deviceTypeImage);
            }

            if (m_documentation != null)
            {
                children.Add(m_documentation);
            }

            if (m_documentationFiles != null)
            {
                children.Add(m_documentationFiles);
            }

            if (m_protocolSupport != null)
            {
                children.Add(m_protocolSupport);
            }

            if (m_imageSet != null)
            {
                children.Add(m_imageSet);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_deviceTypeImage, child))
            {
                m_deviceTypeImage = null;
                return;
            }

            if (Object.ReferenceEquals(m_documentation, child))
            {
                m_documentation = null;
                return;
            }

            if (Object.ReferenceEquals(m_documentationFiles, child))
            {
                m_documentationFiles = null;
                return;
            }

            if (Object.ReferenceEquals(m_protocolSupport, child))
            {
                m_protocolSupport = null;
                return;
            }

            if (Object.ReferenceEquals(m_imageSet, child))
            {
                m_imageSet = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.DeviceTypeImage:
                {
                    if (createOrReplace)
                    {
                        if (DeviceTypeImage == null)
                        {
                            if (replacement == null)
                            {
                                DeviceTypeImage = new FolderState(this);
                            }
                            else
                            {
                                DeviceTypeImage = (FolderState)replacement;
                            }
                        }
                    }

                    instance = DeviceTypeImage;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.Documentation:
                {
                    if (createOrReplace)
                    {
                        if (Documentation == null)
                        {
                            if (replacement == null)
                            {
                                Documentation = new FolderState(this);
                            }
                            else
                            {
                                Documentation = (FolderState)replacement;
                            }
                        }
                    }

                    instance = Documentation;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.DocumentationFiles:
                {
                    if (createOrReplace)
                    {
                        if (DocumentationFiles == null)
                        {
                            if (replacement == null)
                            {
                                DocumentationFiles = new FolderState(this);
                            }
                            else
                            {
                                DocumentationFiles = (FolderState)replacement;
                            }
                        }
                    }

                    instance = DocumentationFiles;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.ProtocolSupport:
                {
                    if (createOrReplace)
                    {
                        if (ProtocolSupport == null)
                        {
                            if (replacement == null)
                            {
                                ProtocolSupport = new FolderState(this);
                            }
                            else
                            {
                                ProtocolSupport = (FolderState)replacement;
                            }
                        }
                    }

                    instance = ProtocolSupport;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.ImageSet:
                {
                    if (createOrReplace)
                    {
                        if (ImageSet == null)
                        {
                            if (replacement == null)
                            {
                                ImageSet = new FolderState(this);
                            }
                            else
                            {
                                ImageSet = (FolderState)replacement;
                            }
                        }
                    }

                    instance = ImageSet;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private FolderState m_deviceTypeImage;
        private FolderState m_documentation;
        private FolderState m_documentationFiles;
        private FolderState m_protocolSupport;
        private FolderState m_imageSet;
        #endregion
    }
    #endif
    #endregion

    #region IAssetLocationIndicationTypeState Class
    #if (!OPCUA_EXCLUDE_IAssetLocationIndicationTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class IAssetLocationIndicationTypeState : BaseInterfaceState
    {
        #region Constructors
        public IAssetLocationIndicationTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.IAssetLocationIndicationType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (UsedIndicationType != null)
            {
                UsedIndicationType.Initialize(context, UsedIndicationType_InitializationString);
            }

            if (SupportedIndicationTypes != null)
            {
                SupportedIndicationTypes.Initialize(context, SupportedIndicationTypes_InitializationString);
            }
        }

        #region Initialization String
        private const string UsedIndicationType_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQASAAAAVXNl" +
           "ZEluZGljYXRpb25UeXBlAQGbAAAuAESbAAAAAQGaAf////8BAf////8AAAAA";

        private const string SupportedIndicationTypes_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAYAAAAU3Vw" +
           "cG9ydGVkSW5kaWNhdGlvblR5cGVzAQGcAAAuAEScAAAAAQGaAf////8BAf////8AAAAA";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAkAAAASUFz" +
           "c2V0TG9jYXRpb25JbmRpY2F0aW9uVHlwZUluc3RhbmNlAQF2AAEBdgB2AAAA/////wUAAAAEYYIKBAAA" +
           "AAEAFwAAAFN0YXJ0TG9jYXRpb25JbmRpY2F0aW9uAQF3AAAvAQF3AHcAAAABAf////8BAAAAF2CpCgIA" +
           "AAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBnQEALgBEnQEAAJYBAAAAAQAqAQEjAAAAEgAAAEluZGljYXRp" +
           "b25EdXJhdGlvbgEAIgH/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAAARhggoEAAAAAQAW" +
           "AAAAU3RvcExvY2F0aW9uSW5kaWNhdGlvbgEBeQAALwEBeQB5AAAAAQH/////AAAAABVgiQoCAAAAAQAM" +
           "AAAASXNJbmRpY2F0aW5nAQGaAAAuAESaAAAAAAH/////AQH/////AAAAABVgiQoCAAAAAQASAAAAVXNl" +
           "ZEluZGljYXRpb25UeXBlAQGbAAAuAESbAAAAAQGaAf////8BAf////8AAAAAFWCJCgIAAAABABgAAABT" +
           "dXBwb3J0ZWRJbmRpY2F0aW9uVHlwZXMBAZwAAC4ARJwAAAABAZoB/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public StartLocationIndicationMethodState StartLocationIndication
        {
            get => m_startLocationIndicationMethod;

            set
            {
                if (!Object.ReferenceEquals(m_startLocationIndicationMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startLocationIndicationMethod = value;
            }
        }

        public MethodState StopLocationIndication
        {
            get => m_stopLocationIndicationMethod;

            set
            {
                if (!Object.ReferenceEquals(m_stopLocationIndicationMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopLocationIndicationMethod = value;
            }
        }

        public PropertyState<bool> IsIndicating
        {
            get => m_isIndicating;

            set
            {
                if (!Object.ReferenceEquals(m_isIndicating, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isIndicating = value;
            }
        }

        public PropertyState<ushort> UsedIndicationType
        {
            get => m_usedIndicationType;

            set
            {
                if (!Object.ReferenceEquals(m_usedIndicationType, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_usedIndicationType = value;
            }
        }

        public PropertyState<ushort> SupportedIndicationTypes
        {
            get => m_supportedIndicationTypes;

            set
            {
                if (!Object.ReferenceEquals(m_supportedIndicationTypes, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_supportedIndicationTypes = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_startLocationIndicationMethod != null)
            {
                children.Add(m_startLocationIndicationMethod);
            }

            if (m_stopLocationIndicationMethod != null)
            {
                children.Add(m_stopLocationIndicationMethod);
            }

            if (m_isIndicating != null)
            {
                children.Add(m_isIndicating);
            }

            if (m_usedIndicationType != null)
            {
                children.Add(m_usedIndicationType);
            }

            if (m_supportedIndicationTypes != null)
            {
                children.Add(m_supportedIndicationTypes);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_startLocationIndicationMethod, child))
            {
                m_startLocationIndicationMethod = null;
                return;
            }

            if (Object.ReferenceEquals(m_stopLocationIndicationMethod, child))
            {
                m_stopLocationIndicationMethod = null;
                return;
            }

            if (Object.ReferenceEquals(m_isIndicating, child))
            {
                m_isIndicating = null;
                return;
            }

            if (Object.ReferenceEquals(m_usedIndicationType, child))
            {
                m_usedIndicationType = null;
                return;
            }

            if (Object.ReferenceEquals(m_supportedIndicationTypes, child))
            {
                m_supportedIndicationTypes = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.StartLocationIndication:
                {
                    if (createOrReplace)
                    {
                        if (StartLocationIndication == null)
                        {
                            if (replacement == null)
                            {
                                StartLocationIndication = new StartLocationIndicationMethodState(this);
                            }
                            else
                            {
                                StartLocationIndication = (StartLocationIndicationMethodState)replacement;
                            }
                        }
                    }

                    instance = StartLocationIndication;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.StopLocationIndication:
                {
                    if (createOrReplace)
                    {
                        if (StopLocationIndication == null)
                        {
                            if (replacement == null)
                            {
                                StopLocationIndication = new MethodState(this);
                            }
                            else
                            {
                                StopLocationIndication = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StopLocationIndication;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.IsIndicating:
                {
                    if (createOrReplace)
                    {
                        if (IsIndicating == null)
                        {
                            if (replacement == null)
                            {
                                IsIndicating = new PropertyState<bool>(this);
                            }
                            else
                            {
                                IsIndicating = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsIndicating;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.UsedIndicationType:
                {
                    if (createOrReplace)
                    {
                        if (UsedIndicationType == null)
                        {
                            if (replacement == null)
                            {
                                UsedIndicationType = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                UsedIndicationType = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = UsedIndicationType;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.SupportedIndicationTypes:
                {
                    if (createOrReplace)
                    {
                        if (SupportedIndicationTypes == null)
                        {
                            if (replacement == null)
                            {
                                SupportedIndicationTypes = new PropertyState<ushort>(this);
                            }
                            else
                            {
                                SupportedIndicationTypes = (PropertyState<ushort>)replacement;
                            }
                        }
                    }

                    instance = SupportedIndicationTypes;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private StartLocationIndicationMethodState m_startLocationIndicationMethod;
        private MethodState m_stopLocationIndicationMethod;
        private PropertyState<bool> m_isIndicating;
        private PropertyState<ushort> m_usedIndicationType;
        private PropertyState<ushort> m_supportedIndicationTypes;
        #endregion
    }
    #endif
    #endregion

    #region ComponentTypeState Class
    #if (!OPCUA_EXCLUDE_ComponentTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class ComponentTypeState : TopologyElementTypeState
    {
        #region Constructors
        public ComponentTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.ComponentType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Manufacturer != null)
            {
                Manufacturer.Initialize(context, Manufacturer_InitializationString);
            }

            if (ManufacturerUri != null)
            {
                ManufacturerUri.Initialize(context, ManufacturerUri_InitializationString);
            }

            if (Model != null)
            {
                Model.Initialize(context, Model_InitializationString);
            }

            if (HardwareRevision != null)
            {
                HardwareRevision.Initialize(context, HardwareRevision_InitializationString);
            }

            if (SoftwareRevision != null)
            {
                SoftwareRevision.Initialize(context, SoftwareRevision_InitializationString);
            }

            if (DeviceRevision != null)
            {
                DeviceRevision.Initialize(context, DeviceRevision_InitializationString);
            }

            if (ProductCode != null)
            {
                ProductCode.Initialize(context, ProductCode_InitializationString);
            }

            if (DeviceManual != null)
            {
                DeviceManual.Initialize(context, DeviceManual_InitializationString);
            }

            if (DeviceClass != null)
            {
                DeviceClass.Initialize(context, DeviceClass_InitializationString);
            }

            if (SerialNumber != null)
            {
                SerialNumber.Initialize(context, SerialNumber_InitializationString);
            }

            if (ProductInstanceUri != null)
            {
                ProductInstanceUri.Initialize(context, ProductInstanceUri_InitializationString);
            }

            if (RevisionCounter != null)
            {
                RevisionCounter.Initialize(context, RevisionCounter_InitializationString);
            }

            if (AssetId != null)
            {
                AssetId.Initialize(context, AssetId_InitializationString);
            }

            if (ComponentName != null)
            {
                ComponentName.Initialize(context, ComponentName_InitializationString);
            }
        }

        #region Initialization String
        private const string Manufacturer_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAMAAAATWFu" +
           "dWZhY3R1cmVyAQHuOgAuAETuOgAAABX/////AQH/////AAAAAA==";

        private const string ManufacturerUri_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAPAAAATWFu" +
           "dWZhY3R1cmVyVXJpAQHvOgAuAETvOgAAAAz/////AQH/////AAAAAA==";

        private const string Model_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAFAAAATW9k" +
           "ZWwBAfA6AC4ARPA6AAAAFf////8BAf////8AAAAA";

        private const string HardwareRevision_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAQAAAASGFy" +
           "ZHdhcmVSZXZpc2lvbgEB8ToALgBE8ToAAAAM/////wEB/////wAAAAA=";

        private const string SoftwareRevision_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAQAAAAU29m" +
           "dHdhcmVSZXZpc2lvbgEB8joALgBE8joAAAAM/////wEB/////wAAAAA=";

        private const string DeviceRevision_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAOAAAARGV2" +
           "aWNlUmV2aXNpb24BAfM6AC4ARPM6AAAADP////8BAf////8AAAAA";

        private const string ProductCode_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQALAAAAUHJv" +
           "ZHVjdENvZGUBAfQ6AC4ARPQ6AAAADP////8BAf////8AAAAA";

        private const string DeviceManual_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAMAAAARGV2" +
           "aWNlTWFudWFsAQH1OgAuAET1OgAAAAz/////AQH/////AAAAAA==";

        private const string DeviceClass_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQALAAAARGV2" +
           "aWNlQ2xhc3MBAfY6AC4ARPY6AAAADP////8BAf////8AAAAA";

        private const string SerialNumber_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAMAAAAU2Vy" +
           "aWFsTnVtYmVyAQH3OgAuAET3OgAAAAz/////AQH/////AAAAAA==";

        private const string ProductInstanceUri_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQASAAAAUHJv" +
           "ZHVjdEluc3RhbmNlVXJpAQH4OgAuAET4OgAAAAz/////AQH/////AAAAAA==";

        private const string RevisionCounter_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAPAAAAUmV2" +
           "aXNpb25Db3VudGVyAQH5OgAuAET5OgAAAAb/////AQH/////AAAAAA==";

        private const string AssetId_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAHAAAAQXNz" +
           "ZXRJZAEB+joALgBE+joAAAAM/////wEB/////wAAAAA=";

        private const string ComponentName_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQANAAAAQ29t" +
           "cG9uZW50TmFtZQEB+zoALgBE+zoAAAAV/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAVAAAAQ29t" +
           "cG9uZW50VHlwZUluc3RhbmNlAQHXOgEB1zrXOgAAAgAAAAEAw0QAAQG7OgEAw0QAAQHIOg4AAAAVYIkK" +
           "AgAAAAEADAAAAE1hbnVmYWN0dXJlcgEB7joALgBE7joAAAAV/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "DwAAAE1hbnVmYWN0dXJlclVyaQEB7zoALgBE7zoAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEABQAA" +
           "AE1vZGVsAQHwOgAuAETwOgAAABX/////AQH/////AAAAABVgiQoCAAAAAQAQAAAASGFyZHdhcmVSZXZp" +
           "c2lvbgEB8ToALgBE8ToAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAFNvZnR3YXJlUmV2aXNp" +
           "b24BAfI6AC4ARPI6AAAADP////8BAf////8AAAAAFWCJCgIAAAABAA4AAABEZXZpY2VSZXZpc2lvbgEB" +
           "8zoALgBE8zoAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAFByb2R1Y3RDb2RlAQH0OgAuAET0" +
           "OgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAARGV2aWNlTWFudWFsAQH1OgAuAET1OgAAAAz/" +
           "////AQH/////AAAAABVgiQoCAAAAAQALAAAARGV2aWNlQ2xhc3MBAfY6AC4ARPY6AAAADP////8BAf//" +
           "//8AAAAAFWCJCgIAAAABAAwAAABTZXJpYWxOdW1iZXIBAfc6AC4ARPc6AAAADP////8BAf////8AAAAA" +
           "FWCJCgIAAAABABIAAABQcm9kdWN0SW5zdGFuY2VVcmkBAfg6AC4ARPg6AAAADP////8BAf////8AAAAA" +
           "FWCJCgIAAAABAA8AAABSZXZpc2lvbkNvdW50ZXIBAfk6AC4ARPk6AAAABv////8BAf////8AAAAAFWCJ" +
           "CgIAAAABAAcAAABBc3NldElkAQH6OgAuAET6OgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQANAAAA" +
           "Q29tcG9uZW50TmFtZQEB+zoALgBE+zoAAAAV/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public PropertyState<LocalizedText> Manufacturer
        {
            get => m_manufacturer;

            set
            {
                if (!Object.ReferenceEquals(m_manufacturer, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manufacturer = value;
            }
        }

        public PropertyState<string> ManufacturerUri
        {
            get => m_manufacturerUri;

            set
            {
                if (!Object.ReferenceEquals(m_manufacturerUri, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manufacturerUri = value;
            }
        }

        public PropertyState<LocalizedText> Model
        {
            get => m_model;

            set
            {
                if (!Object.ReferenceEquals(m_model, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_model = value;
            }
        }

        public PropertyState<string> HardwareRevision
        {
            get => m_hardwareRevision;

            set
            {
                if (!Object.ReferenceEquals(m_hardwareRevision, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_hardwareRevision = value;
            }
        }

        public PropertyState<string> SoftwareRevision
        {
            get => m_softwareRevision;

            set
            {
                if (!Object.ReferenceEquals(m_softwareRevision, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_softwareRevision = value;
            }
        }

        public PropertyState<string> DeviceRevision
        {
            get => m_deviceRevision;

            set
            {
                if (!Object.ReferenceEquals(m_deviceRevision, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceRevision = value;
            }
        }

        public PropertyState<string> ProductCode
        {
            get => m_productCode;

            set
            {
                if (!Object.ReferenceEquals(m_productCode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_productCode = value;
            }
        }

        public PropertyState<string> DeviceManual
        {
            get => m_deviceManual;

            set
            {
                if (!Object.ReferenceEquals(m_deviceManual, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceManual = value;
            }
        }

        public PropertyState<string> DeviceClass
        {
            get => m_deviceClass;

            set
            {
                if (!Object.ReferenceEquals(m_deviceClass, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceClass = value;
            }
        }

        public PropertyState<string> SerialNumber
        {
            get => m_serialNumber;

            set
            {
                if (!Object.ReferenceEquals(m_serialNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_serialNumber = value;
            }
        }

        public PropertyState<string> ProductInstanceUri
        {
            get => m_productInstanceUri;

            set
            {
                if (!Object.ReferenceEquals(m_productInstanceUri, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_productInstanceUri = value;
            }
        }

        public PropertyState<int> RevisionCounter
        {
            get => m_revisionCounter;

            set
            {
                if (!Object.ReferenceEquals(m_revisionCounter, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_revisionCounter = value;
            }
        }

        public PropertyState<string> AssetId
        {
            get => m_assetId;

            set
            {
                if (!Object.ReferenceEquals(m_assetId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_assetId = value;
            }
        }

        public PropertyState<LocalizedText> ComponentName
        {
            get => m_componentName;

            set
            {
                if (!Object.ReferenceEquals(m_componentName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_componentName = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_manufacturer != null)
            {
                children.Add(m_manufacturer);
            }

            if (m_manufacturerUri != null)
            {
                children.Add(m_manufacturerUri);
            }

            if (m_model != null)
            {
                children.Add(m_model);
            }

            if (m_hardwareRevision != null)
            {
                children.Add(m_hardwareRevision);
            }

            if (m_softwareRevision != null)
            {
                children.Add(m_softwareRevision);
            }

            if (m_deviceRevision != null)
            {
                children.Add(m_deviceRevision);
            }

            if (m_productCode != null)
            {
                children.Add(m_productCode);
            }

            if (m_deviceManual != null)
            {
                children.Add(m_deviceManual);
            }

            if (m_deviceClass != null)
            {
                children.Add(m_deviceClass);
            }

            if (m_serialNumber != null)
            {
                children.Add(m_serialNumber);
            }

            if (m_productInstanceUri != null)
            {
                children.Add(m_productInstanceUri);
            }

            if (m_revisionCounter != null)
            {
                children.Add(m_revisionCounter);
            }

            if (m_assetId != null)
            {
                children.Add(m_assetId);
            }

            if (m_componentName != null)
            {
                children.Add(m_componentName);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_manufacturer, child))
            {
                m_manufacturer = null;
                return;
            }

            if (Object.ReferenceEquals(m_manufacturerUri, child))
            {
                m_manufacturerUri = null;
                return;
            }

            if (Object.ReferenceEquals(m_model, child))
            {
                m_model = null;
                return;
            }

            if (Object.ReferenceEquals(m_hardwareRevision, child))
            {
                m_hardwareRevision = null;
                return;
            }

            if (Object.ReferenceEquals(m_softwareRevision, child))
            {
                m_softwareRevision = null;
                return;
            }

            if (Object.ReferenceEquals(m_deviceRevision, child))
            {
                m_deviceRevision = null;
                return;
            }

            if (Object.ReferenceEquals(m_productCode, child))
            {
                m_productCode = null;
                return;
            }

            if (Object.ReferenceEquals(m_deviceManual, child))
            {
                m_deviceManual = null;
                return;
            }

            if (Object.ReferenceEquals(m_deviceClass, child))
            {
                m_deviceClass = null;
                return;
            }

            if (Object.ReferenceEquals(m_serialNumber, child))
            {
                m_serialNumber = null;
                return;
            }

            if (Object.ReferenceEquals(m_productInstanceUri, child))
            {
                m_productInstanceUri = null;
                return;
            }

            if (Object.ReferenceEquals(m_revisionCounter, child))
            {
                m_revisionCounter = null;
                return;
            }

            if (Object.ReferenceEquals(m_assetId, child))
            {
                m_assetId = null;
                return;
            }

            if (Object.ReferenceEquals(m_componentName, child))
            {
                m_componentName = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.Manufacturer:
                {
                    if (createOrReplace)
                    {
                        if (Manufacturer == null)
                        {
                            if (replacement == null)
                            {
                                Manufacturer = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                Manufacturer = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = Manufacturer;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.ManufacturerUri:
                {
                    if (createOrReplace)
                    {
                        if (ManufacturerUri == null)
                        {
                            if (replacement == null)
                            {
                                ManufacturerUri = new PropertyState<string>(this);
                            }
                            else
                            {
                                ManufacturerUri = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ManufacturerUri;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.Model:
                {
                    if (createOrReplace)
                    {
                        if (Model == null)
                        {
                            if (replacement == null)
                            {
                                Model = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                Model = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = Model;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.HardwareRevision:
                {
                    if (createOrReplace)
                    {
                        if (HardwareRevision == null)
                        {
                            if (replacement == null)
                            {
                                HardwareRevision = new PropertyState<string>(this);
                            }
                            else
                            {
                                HardwareRevision = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = HardwareRevision;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.SoftwareRevision:
                {
                    if (createOrReplace)
                    {
                        if (SoftwareRevision == null)
                        {
                            if (replacement == null)
                            {
                                SoftwareRevision = new PropertyState<string>(this);
                            }
                            else
                            {
                                SoftwareRevision = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SoftwareRevision;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.DeviceRevision:
                {
                    if (createOrReplace)
                    {
                        if (DeviceRevision == null)
                        {
                            if (replacement == null)
                            {
                                DeviceRevision = new PropertyState<string>(this);
                            }
                            else
                            {
                                DeviceRevision = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceRevision;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.ProductCode:
                {
                    if (createOrReplace)
                    {
                        if (ProductCode == null)
                        {
                            if (replacement == null)
                            {
                                ProductCode = new PropertyState<string>(this);
                            }
                            else
                            {
                                ProductCode = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ProductCode;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.DeviceManual:
                {
                    if (createOrReplace)
                    {
                        if (DeviceManual == null)
                        {
                            if (replacement == null)
                            {
                                DeviceManual = new PropertyState<string>(this);
                            }
                            else
                            {
                                DeviceManual = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceManual;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.DeviceClass:
                {
                    if (createOrReplace)
                    {
                        if (DeviceClass == null)
                        {
                            if (replacement == null)
                            {
                                DeviceClass = new PropertyState<string>(this);
                            }
                            else
                            {
                                DeviceClass = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = DeviceClass;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.SerialNumber:
                {
                    if (createOrReplace)
                    {
                        if (SerialNumber == null)
                        {
                            if (replacement == null)
                            {
                                SerialNumber = new PropertyState<string>(this);
                            }
                            else
                            {
                                SerialNumber = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SerialNumber;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.ProductInstanceUri:
                {
                    if (createOrReplace)
                    {
                        if (ProductInstanceUri == null)
                        {
                            if (replacement == null)
                            {
                                ProductInstanceUri = new PropertyState<string>(this);
                            }
                            else
                            {
                                ProductInstanceUri = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ProductInstanceUri;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.RevisionCounter:
                {
                    if (createOrReplace)
                    {
                        if (RevisionCounter == null)
                        {
                            if (replacement == null)
                            {
                                RevisionCounter = new PropertyState<int>(this);
                            }
                            else
                            {
                                RevisionCounter = (PropertyState<int>)replacement;
                            }
                        }
                    }

                    instance = RevisionCounter;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.AssetId:
                {
                    if (createOrReplace)
                    {
                        if (AssetId == null)
                        {
                            if (replacement == null)
                            {
                                AssetId = new PropertyState<string>(this);
                            }
                            else
                            {
                                AssetId = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = AssetId;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.ComponentName:
                {
                    if (createOrReplace)
                    {
                        if (ComponentName == null)
                        {
                            if (replacement == null)
                            {
                                ComponentName = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                ComponentName = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = ComponentName;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<LocalizedText> m_manufacturer;
        private PropertyState<string> m_manufacturerUri;
        private PropertyState<LocalizedText> m_model;
        private PropertyState<string> m_hardwareRevision;
        private PropertyState<string> m_softwareRevision;
        private PropertyState<string> m_deviceRevision;
        private PropertyState<string> m_productCode;
        private PropertyState<string> m_deviceManual;
        private PropertyState<string> m_deviceClass;
        private PropertyState<string> m_serialNumber;
        private PropertyState<string> m_productInstanceUri;
        private PropertyState<int> m_revisionCounter;
        private PropertyState<string> m_assetId;
        private PropertyState<LocalizedText> m_componentName;
        #endregion
    }
    #endif
    #endregion

    #region DeviceTypeState Class
    #if (!OPCUA_EXCLUDE_DeviceTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class DeviceTypeState : ComponentTypeState
    {
        #region Constructors
        public DeviceTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.DeviceType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (ManufacturerUri != null)
            {
                ManufacturerUri.Initialize(context, ManufacturerUri_InitializationString);
            }

            if (ProductCode != null)
            {
                ProductCode.Initialize(context, ProductCode_InitializationString);
            }

            if (DeviceClass != null)
            {
                DeviceClass.Initialize(context, DeviceClass_InitializationString);
            }

            if (ProductInstanceUri != null)
            {
                ProductInstanceUri.Initialize(context, ProductInstanceUri_InitializationString);
            }

            if (DeviceHealth != null)
            {
                DeviceHealth.Initialize(context, DeviceHealth_InitializationString);
            }

            if (DeviceHealthAlarms != null)
            {
                DeviceHealthAlarms.Initialize(context, DeviceHealthAlarms_InitializationString);
            }

            if (DeviceTypeImage != null)
            {
                DeviceTypeImage.Initialize(context, DeviceTypeImage_InitializationString);
            }

            if (Documentation != null)
            {
                Documentation.Initialize(context, Documentation_InitializationString);
            }

            if (ProtocolSupport != null)
            {
                ProtocolSupport.Initialize(context, ProtocolSupport_InitializationString);
            }

            if (ImageSet != null)
            {
                ImageSet.Initialize(context, ImageSet_InitializationString);
            }
        }

        #region Initialization String
        private const string ManufacturerUri_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAPAAAATWFu" +
           "dWZhY3R1cmVyVXJpAQH8OgAuAET8OgAAAAz/////AQH/////AAAAAA==";

        private const string ProductCode_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQALAAAAUHJv" +
           "ZHVjdENvZGUBAf06AC4ARP06AAAADP////8BAf////8AAAAA";

        private const string DeviceClass_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQALAAAARGV2" +
           "aWNlQ2xhc3MBAUYZAC4AREYZAAAADP////8BAf////8AAAAA";

        private const string ProductInstanceUri_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQASAAAAUHJv" +
           "ZHVjdEluc3RhbmNlVXJpAQH+OgAuAET+OgAAAAz/////AQH/////AAAAAA==";

        private const string DeviceHealth_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAMAAAARGV2" +
           "aWNlSGVhbHRoAQFAGAAvAD9AGAAAAQFkGP////8BAf////8AAAAA";

        private const string DeviceHealthAlarms_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQASAAAARGV2" +
           "aWNlSGVhbHRoQWxhcm1zAQEBOwAvAD0BOwAA/////wAAAAA=";

        private const string DeviceTypeImage_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAPAAAARGV2" +
           "aWNlVHlwZUltYWdlAQFBGAAvAD1BGAAA/////wEAAAAVYMkKAgAAABsAAABJbWFnZUlkZW50aWZpZXJf" +
           "UGxhY2Vob2xkZXIBABEAAAA8SW1hZ2VJZGVudGlmaWVyPgEBQhgALwA/QhgAAAAe/////wEB/////wAA" +
           "AAA=";

        private const string Documentation_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQANAAAARG9j" +
           "dW1lbnRhdGlvbgEBQxgALwA9QxgAAP////8BAAAAFWDJCgIAAAAeAAAARG9jdW1lbnRJZGVudGlmaWVy" +
           "X1BsYWNlaG9sZGVyAQAUAAAAPERvY3VtZW50SWRlbnRpZmllcj4BAUQYAC8AP0QYAAAAD/////8BAf//" +
           "//8AAAAA";

        private const string ProtocolSupport_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAPAAAAUHJv" +
           "dG9jb2xTdXBwb3J0AQFFGAAvAD1FGAAA/////wEAAAAVYMkKAgAAACUAAABQcm90b2NvbFN1cHBvcnRJ" +
           "ZGVudGlmaWVyX1BsYWNlaG9sZGVyAQAbAAAAPFByb3RvY29sU3VwcG9ydElkZW50aWZpZXI+AQFGGAAv" +
           "AD9GGAAAAA//////AQH/////AAAAAA==";

        private const string ImageSet_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAIAAAASW1h" +
           "Z2VTZXQBAUcYAC8APUcYAAD/////AQAAABVgyQoCAAAAGwAAAEltYWdlSWRlbnRpZmllcl9QbGFjZWhv" +
           "bGRlcgEAEQAAADxJbWFnZUlkZW50aWZpZXI+AQFIGAAvAD9IGAAAAB7/////AQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQASAAAARGV2" +
           "aWNlVHlwZUluc3RhbmNlAQHqAwEB6gPqAwAAAgAAAAEAw0QAAQHOOgEAw0QAAQHLOhMAAAAVYIkKAgAA" +
           "AAEADAAAAE1hbnVmYWN0dXJlcgEBcxcALgBEcxcAAAAV/////wEB/////wAAAAAVYIkKAgAAAAEADwAA" +
           "AE1hbnVmYWN0dXJlclVyaQEB/DoALgBE/DoAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAE1v" +
           "ZGVsAQF0FwAuAER0FwAAABX/////AQH/////AAAAABVgiQoCAAAAAQAQAAAASGFyZHdhcmVSZXZpc2lv" +
           "bgEBeBcALgBEeBcAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAFNvZnR3YXJlUmV2aXNpb24B" +
           "AXcXAC4ARHcXAAAADP////8BAf////8AAAAAFWCJCgIAAAABAA4AAABEZXZpY2VSZXZpc2lvbgEBdhcA" +
           "LgBEdhcAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAFByb2R1Y3RDb2RlAQH9OgAuAET9OgAA" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAARGV2aWNlTWFudWFsAQF1FwAuAER1FwAAAAz/////" +
           "AQH/////AAAAABVgiQoCAAAAAQALAAAARGV2aWNlQ2xhc3MBAUYZAC4AREYZAAAADP////8BAf////8A" +
           "AAAAFWCJCgIAAAABAAwAAABTZXJpYWxOdW1iZXIBAXEXAC4ARHEXAAAADP////8BAf////8AAAAAFWCJ" +
           "CgIAAAABABIAAABQcm9kdWN0SW5zdGFuY2VVcmkBAf46AC4ARP46AAAADP////8BAf////8AAAAAFWCJ" +
           "CgIAAAABAA8AAABSZXZpc2lvbkNvdW50ZXIBAXIXAC4ARHIXAAAABv////8BAf////8AAAAABGDACgEA" +
           "AAAYAAAAQ1BJZGVudGlmaWVyX1BsYWNlaG9sZGVyAQAOAAAAPENQSWRlbnRpZmllcj4BAasZAC8BAaQY" +
           "qxkAAP////8BAAAABGCACgEAAAABAA4AAABOZXR3b3JrQWRkcmVzcwEBwBkALwEB7QPAGQAA/////wAA" +
           "AAAVYIkKAgAAAAEADAAAAERldmljZUhlYWx0aAEBQBgALwA/QBgAAAEBZBj/////AQH/////AAAAAARg" +
           "gAoBAAAAAQASAAAARGV2aWNlSGVhbHRoQWxhcm1zAQEBOwAvAD0BOwAA/////wAAAAAEYIAKAQAAAAEA" +
           "DwAAAERldmljZVR5cGVJbWFnZQEBQRgALwA9QRgAAP////8BAAAAFWDJCgIAAAAbAAAASW1hZ2VJZGVu" +
           "dGlmaWVyX1BsYWNlaG9sZGVyAQARAAAAPEltYWdlSWRlbnRpZmllcj4BAUIYAC8AP0IYAAAAHv////8B" +
           "Af////8AAAAABGCACgEAAAABAA0AAABEb2N1bWVudGF0aW9uAQFDGAAvAD1DGAAA/////wEAAAAVYMkK" +
           "AgAAAB4AAABEb2N1bWVudElkZW50aWZpZXJfUGxhY2Vob2xkZXIBABQAAAA8RG9jdW1lbnRJZGVudGlm" +
           "aWVyPgEBRBgALwA/RBgAAAAP/////wEB/////wAAAAAEYIAKAQAAAAEADwAAAFByb3RvY29sU3VwcG9y" +
           "dAEBRRgALwA9RRgAAP////8BAAAAFWDJCgIAAAAlAAAAUHJvdG9jb2xTdXBwb3J0SWRlbnRpZmllcl9Q" +
           "bGFjZWhvbGRlcgEAGwAAADxQcm90b2NvbFN1cHBvcnRJZGVudGlmaWVyPgEBRhgALwA/RhgAAAAP////" +
           "/wEB/////wAAAAAEYIAKAQAAAAEACAAAAEltYWdlU2V0AQFHGAAvAD1HGAAA/////wEAAAAVYMkKAgAA" +
           "ABsAAABJbWFnZUlkZW50aWZpZXJfUGxhY2Vob2xkZXIBABEAAAA8SW1hZ2VJZGVudGlmaWVyPgEBSBgA" +
           "LwA/SBgAAAAe/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public BaseDataVariableState<DeviceHealthEnumeration> DeviceHealth
        {
            get => m_deviceHealth;

            set
            {
                if (!Object.ReferenceEquals(m_deviceHealth, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceHealth = value;
            }
        }

        public FolderState DeviceHealthAlarms
        {
            get => m_deviceHealthAlarms;

            set
            {
                if (!Object.ReferenceEquals(m_deviceHealthAlarms, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceHealthAlarms = value;
            }
        }

        public FolderState DeviceTypeImage
        {
            get => m_deviceTypeImage;

            set
            {
                if (!Object.ReferenceEquals(m_deviceTypeImage, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deviceTypeImage = value;
            }
        }

        public FolderState Documentation
        {
            get => m_documentation;

            set
            {
                if (!Object.ReferenceEquals(m_documentation, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_documentation = value;
            }
        }

        public FolderState ProtocolSupport
        {
            get => m_protocolSupport;

            set
            {
                if (!Object.ReferenceEquals(m_protocolSupport, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_protocolSupport = value;
            }
        }

        public FolderState ImageSet
        {
            get => m_imageSet;

            set
            {
                if (!Object.ReferenceEquals(m_imageSet, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_imageSet = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_deviceHealth != null)
            {
                children.Add(m_deviceHealth);
            }

            if (m_deviceHealthAlarms != null)
            {
                children.Add(m_deviceHealthAlarms);
            }

            if (m_deviceTypeImage != null)
            {
                children.Add(m_deviceTypeImage);
            }

            if (m_documentation != null)
            {
                children.Add(m_documentation);
            }

            if (m_protocolSupport != null)
            {
                children.Add(m_protocolSupport);
            }

            if (m_imageSet != null)
            {
                children.Add(m_imageSet);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_deviceHealth, child))
            {
                m_deviceHealth = null;
                return;
            }

            if (Object.ReferenceEquals(m_deviceHealthAlarms, child))
            {
                m_deviceHealthAlarms = null;
                return;
            }

            if (Object.ReferenceEquals(m_deviceTypeImage, child))
            {
                m_deviceTypeImage = null;
                return;
            }

            if (Object.ReferenceEquals(m_documentation, child))
            {
                m_documentation = null;
                return;
            }

            if (Object.ReferenceEquals(m_protocolSupport, child))
            {
                m_protocolSupport = null;
                return;
            }

            if (Object.ReferenceEquals(m_imageSet, child))
            {
                m_imageSet = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.DeviceHealth:
                {
                    if (createOrReplace)
                    {
                        if (DeviceHealth == null)
                        {
                            if (replacement == null)
                            {
                                DeviceHealth = new BaseDataVariableState<DeviceHealthEnumeration>(this);
                            }
                            else
                            {
                                DeviceHealth = (BaseDataVariableState<DeviceHealthEnumeration>)replacement;
                            }
                        }
                    }

                    instance = DeviceHealth;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.DeviceHealthAlarms:
                {
                    if (createOrReplace)
                    {
                        if (DeviceHealthAlarms == null)
                        {
                            if (replacement == null)
                            {
                                DeviceHealthAlarms = new FolderState(this);
                            }
                            else
                            {
                                DeviceHealthAlarms = (FolderState)replacement;
                            }
                        }
                    }

                    instance = DeviceHealthAlarms;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.DeviceTypeImage:
                {
                    if (createOrReplace)
                    {
                        if (DeviceTypeImage == null)
                        {
                            if (replacement == null)
                            {
                                DeviceTypeImage = new FolderState(this);
                            }
                            else
                            {
                                DeviceTypeImage = (FolderState)replacement;
                            }
                        }
                    }

                    instance = DeviceTypeImage;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.Documentation:
                {
                    if (createOrReplace)
                    {
                        if (Documentation == null)
                        {
                            if (replacement == null)
                            {
                                Documentation = new FolderState(this);
                            }
                            else
                            {
                                Documentation = (FolderState)replacement;
                            }
                        }
                    }

                    instance = Documentation;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.ProtocolSupport:
                {
                    if (createOrReplace)
                    {
                        if (ProtocolSupport == null)
                        {
                            if (replacement == null)
                            {
                                ProtocolSupport = new FolderState(this);
                            }
                            else
                            {
                                ProtocolSupport = (FolderState)replacement;
                            }
                        }
                    }

                    instance = ProtocolSupport;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.ImageSet:
                {
                    if (createOrReplace)
                    {
                        if (ImageSet == null)
                        {
                            if (replacement == null)
                            {
                                ImageSet = new FolderState(this);
                            }
                            else
                            {
                                ImageSet = (FolderState)replacement;
                            }
                        }
                    }

                    instance = ImageSet;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<DeviceHealthEnumeration> m_deviceHealth;
        private FolderState m_deviceHealthAlarms;
        private FolderState m_deviceTypeImage;
        private FolderState m_documentation;
        private FolderState m_protocolSupport;
        private FolderState m_imageSet;
        #endregion
    }
    #endif
    #endregion

    #region SoftwareTypeState Class
    #if (!OPCUA_EXCLUDE_SoftwareTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class SoftwareTypeState : ComponentTypeState
    {
        #region Constructors
        public SoftwareTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.SoftwareType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAUAAAAU29m" +
           "dHdhcmVUeXBlSW5zdGFuY2UBAQI7AQECOwI7AAD/////AwAAABVgiQoCAAAAAQAMAAAATWFudWZhY3R1" +
           "cmVyAQEZOwAuAEQZOwAAABX/////AQH/////AAAAABVgiQoCAAAAAQAFAAAATW9kZWwBARs7AC4ARBs7" +
           "AAAAFf////8BAf////8AAAAAFWCJCgIAAAABABAAAABTb2Z0d2FyZVJldmlzaW9uAQEdOwAuAEQdOwAA" +
           "AAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region BlockTypeState Class
    #if (!OPCUA_EXCLUDE_BlockTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class BlockTypeState : TopologyElementTypeState
    {
        #region Constructors
        public BlockTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.BlockType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (RevisionCounter != null)
            {
                RevisionCounter.Initialize(context, RevisionCounter_InitializationString);
            }

            if (ActualMode != null)
            {
                ActualMode.Initialize(context, ActualMode_InitializationString);
            }

            if (PermittedMode != null)
            {
                PermittedMode.Initialize(context, PermittedMode_InitializationString);
            }

            if (NormalMode != null)
            {
                NormalMode.Initialize(context, NormalMode_InitializationString);
            }

            if (TargetMode != null)
            {
                TargetMode.Initialize(context, TargetMode_InitializationString);
            }
        }

        #region Initialization String
        private const string RevisionCounter_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAPAAAAUmV2" +
           "aXNpb25Db3VudGVyAQF5FwAuAER5FwAAAAb/////AQH/////AAAAAA==";

        private const string ActualMode_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAKAAAAQWN0" +
           "dWFsTW9kZQEBehcALgBEehcAAAAV/////wEB/////wAAAAA=";

        private const string PermittedMode_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xdgiQoCAAAAAQANAAAAUGVy" +
           "bWl0dGVkTW9kZQEBexcALgBEexcAAAAVAQAAAAEAAAAAAAAAAQH/////AAAAAA==";

        private const string NormalMode_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xdgiQoCAAAAAQAKAAAATm9y" +
           "bWFsTW9kZQEBfBcALgBEfBcAAAAVAQAAAAEAAAAAAAAAAQH/////AAAAAA==";

        private const string TargetMode_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xdgiQoCAAAAAQAKAAAAVGFy" +
           "Z2V0TW9kZQEBfRcALgBEfRcAAAAVAQAAAAEAAAAAAAAAAQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQARAAAAQmxv" +
           "Y2tUeXBlSW5zdGFuY2UBAesDAQHrA+sDAAD/////BQAAABVgiQoCAAAAAQAPAAAAUmV2aXNpb25Db3Vu" +
           "dGVyAQF5FwAuAER5FwAAAAb/////AQH/////AAAAABVgiQoCAAAAAQAKAAAAQWN0dWFsTW9kZQEBehcA" +
           "LgBEehcAAAAV/////wEB/////wAAAAAXYIkKAgAAAAEADQAAAFBlcm1pdHRlZE1vZGUBAXsXAC4ARHsX" +
           "AAAAFQEAAAABAAAAAAAAAAEB/////wAAAAAXYIkKAgAAAAEACgAAAE5vcm1hbE1vZGUBAXwXAC4ARHwX" +
           "AAAAFQEAAAABAAAAAAAAAAEB/////wAAAAAXYIkKAgAAAAEACgAAAFRhcmdldE1vZGUBAX0XAC4ARH0X" +
           "AAAAFQEAAAABAAAAAAAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public PropertyState<int> RevisionCounter
        {
            get => m_revisionCounter;

            set
            {
                if (!Object.ReferenceEquals(m_revisionCounter, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_revisionCounter = value;
            }
        }

        public PropertyState<LocalizedText> ActualMode
        {
            get => m_actualMode;

            set
            {
                if (!Object.ReferenceEquals(m_actualMode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_actualMode = value;
            }
        }

        public PropertyState<LocalizedText[]> PermittedMode
        {
            get => m_permittedMode;

            set
            {
                if (!Object.ReferenceEquals(m_permittedMode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_permittedMode = value;
            }
        }

        public PropertyState<LocalizedText[]> NormalMode
        {
            get => m_normalMode;

            set
            {
                if (!Object.ReferenceEquals(m_normalMode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_normalMode = value;
            }
        }

        public PropertyState<LocalizedText[]> TargetMode
        {
            get => m_targetMode;

            set
            {
                if (!Object.ReferenceEquals(m_targetMode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_targetMode = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_revisionCounter != null)
            {
                children.Add(m_revisionCounter);
            }

            if (m_actualMode != null)
            {
                children.Add(m_actualMode);
            }

            if (m_permittedMode != null)
            {
                children.Add(m_permittedMode);
            }

            if (m_normalMode != null)
            {
                children.Add(m_normalMode);
            }

            if (m_targetMode != null)
            {
                children.Add(m_targetMode);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_revisionCounter, child))
            {
                m_revisionCounter = null;
                return;
            }

            if (Object.ReferenceEquals(m_actualMode, child))
            {
                m_actualMode = null;
                return;
            }

            if (Object.ReferenceEquals(m_permittedMode, child))
            {
                m_permittedMode = null;
                return;
            }

            if (Object.ReferenceEquals(m_normalMode, child))
            {
                m_normalMode = null;
                return;
            }

            if (Object.ReferenceEquals(m_targetMode, child))
            {
                m_targetMode = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.RevisionCounter:
                {
                    if (createOrReplace)
                    {
                        if (RevisionCounter == null)
                        {
                            if (replacement == null)
                            {
                                RevisionCounter = new PropertyState<int>(this);
                            }
                            else
                            {
                                RevisionCounter = (PropertyState<int>)replacement;
                            }
                        }
                    }

                    instance = RevisionCounter;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.ActualMode:
                {
                    if (createOrReplace)
                    {
                        if (ActualMode == null)
                        {
                            if (replacement == null)
                            {
                                ActualMode = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                ActualMode = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = ActualMode;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.PermittedMode:
                {
                    if (createOrReplace)
                    {
                        if (PermittedMode == null)
                        {
                            if (replacement == null)
                            {
                                PermittedMode = new PropertyState<LocalizedText[]>(this);
                            }
                            else
                            {
                                PermittedMode = (PropertyState<LocalizedText[]>)replacement;
                            }
                        }
                    }

                    instance = PermittedMode;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.NormalMode:
                {
                    if (createOrReplace)
                    {
                        if (NormalMode == null)
                        {
                            if (replacement == null)
                            {
                                NormalMode = new PropertyState<LocalizedText[]>(this);
                            }
                            else
                            {
                                NormalMode = (PropertyState<LocalizedText[]>)replacement;
                            }
                        }
                    }

                    instance = NormalMode;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.TargetMode:
                {
                    if (createOrReplace)
                    {
                        if (TargetMode == null)
                        {
                            if (replacement == null)
                            {
                                TargetMode = new PropertyState<LocalizedText[]>(this);
                            }
                            else
                            {
                                TargetMode = (PropertyState<LocalizedText[]>)replacement;
                            }
                        }
                    }

                    instance = TargetMode;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<int> m_revisionCounter;
        private PropertyState<LocalizedText> m_actualMode;
        private PropertyState<LocalizedText[]> m_permittedMode;
        private PropertyState<LocalizedText[]> m_normalMode;
        private PropertyState<LocalizedText[]> m_targetMode;
        #endregion
    }
    #endif
    #endregion

    #region DeviceHealthDiagnosticAlarmTypeState Class
    #if (!OPCUA_EXCLUDE_DeviceHealthDiagnosticAlarmTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class DeviceHealthDiagnosticAlarmTypeState : InstrumentDiagnosticAlarmState
    {
        #region Constructors
        public DeviceHealthDiagnosticAlarmTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.DeviceHealthDiagnosticAlarmType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAnAAAARGV2" +
           "aWNlSGVhbHRoRGlhZ25vc3RpY0FsYXJtVHlwZUluc3RhbmNlAQEnOwEBJzsnOwAA/////xsAAAAVYIkI" +
           "AgAAAAAABwAAAEV2ZW50SWQBAQAAAC4ARAAP/////wEB/////wAAAAAVYIkIAgAAAAAACQAAAEV2ZW50" +
           "VHlwZQEBAAAALgBEABH/////AQH/////AAAAABVgiQgCAAAAAAAKAAAAU291cmNlTm9kZQEBAAAALgBE" +
           "ABH/////AQH/////AAAAABVgiQgCAAAAAAAKAAAAU291cmNlTmFtZQEBAAAALgBEAAz/////AQH/////" +
           "AAAAABVgiQgCAAAAAAAEAAAAVGltZQEBAAAALgBEAQAmAf////8BAf////8AAAAAFWCJCAIAAAAAAAsA" +
           "AABSZWNlaXZlVGltZQEBAAAALgBEAQAmAf////8BAf////8AAAAAFWCJCAIAAAAAAAcAAABNZXNzYWdl" +
           "AQEAAAAuAEQAFf////8BAf////8AAAAAFWCJCAIAAAAAAAgAAABTZXZlcml0eQEBAAAALgBEAAX/////" +
           "AQH/////AAAAABVgiQgCAAAAAAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEBAAAALgBEABH/////AQH/////" +
           "AAAAABVgiQgCAAAAAAASAAAAQ29uZGl0aW9uQ2xhc3NOYW1lAQEAAAAuAEQAFf////8BAf////8AAAAA" +
           "FWCJCAIAAAAAAA0AAABDb25kaXRpb25OYW1lAQEAAAAuAEQADP////8BAf////8AAAAAFWCJCAIAAAAA" +
           "AAgAAABCcmFuY2hJZAEBAAAALgBEABH/////AQH/////AAAAABVgiQgCAAAAAAAGAAAAUmV0YWluAQEA" +
           "AAAuAEQAAf////8BAf////8AAAAAFWCJCAIAAAAAAAwAAABFbmFibGVkU3RhdGUBAQAAAC8BACMjABX/" +
           "////AQEFAAAAAQAsIwADAQAqAAAARGV2aWNlSGVhbHRoRGlhZ25vc3RpY0FsYXJtVHlwZV9BY2tlZFN0" +
           "YXRlAQAsIwADAQAuAAAARGV2aWNlSGVhbHRoRGlhZ25vc3RpY0FsYXJtVHlwZV9Db25maXJtZWRTdGF0" +
           "ZQEALCMAAwEAKwAAAERldmljZUhlYWx0aERpYWdub3N0aWNBbGFybVR5cGVfQWN0aXZlU3RhdGUBACwj" +
           "AAMBAC8AAABEZXZpY2VIZWFsdGhEaWFnbm9zdGljQWxhcm1UeXBlX1N1cHByZXNzZWRTdGF0ZQEALCMA" +
           "AwEALQAAAERldmljZUhlYWx0aERpYWdub3N0aWNBbGFybVR5cGVfU2hlbHZpbmdTdGF0ZQEAAAAVYIkI" +
           "AgAAAAAAAgAAAElkAQEAAAAuAEQAAf////8BAf////8AAAAAFWCJCAIAAAAAAAcAAABRdWFsaXR5AQEA" +
           "AAAvAQAqIwAT/////wEB/////wEAAAAVYIkIAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBAAAALgBE" +
           "AQAmAf////8BAf////8AAAAAFWCJCAIAAAAAAAwAAABMYXN0U2V2ZXJpdHkBAQAAAC8BACojAAX/////" +
           "AQH/////AQAAABVgiQgCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQEAAAAuAEQBACYB/////wEB////" +
           "/wAAAAAVYIkIAgAAAAAABwAAAENvbW1lbnQBAQAAAC8BACojABX/////AQH/////AQAAABVgiQgCAAAA" +
           "AAAPAAAAU291cmNlVGltZXN0YW1wAQEAAAAuAEQBACYB/////wEB/////wAAAAAVYIkIAgAAAAAADAAA" +
           "AENsaWVudFVzZXJJZAEBAAAALgBEAAz/////AQH/////AAAAAARhgggEAAAAAAAHAAAARGlzYWJsZQEB" +
           "AAAALwEARCMBAQEAAAABAPkLAAEA8woAAAAABGGCCAQAAAAAAAYAAABFbmFibGUBAQAAAC8BAEMjAQEB" +
           "AAAAAQD5CwABAPMKAAAAAARhgggEAAAAAAAKAAAAQWRkQ29tbWVudAEBAAAALwEARSMBAQEAAAABAPkL" +
           "AAEADQsBAAAAF2CpCAIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBAAAALgBElgIAAAABACoBAUYAAAAH" +
           "AAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRv" +
           "IGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQg" +
           "dG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAAVYIkIAgAAAAAA" +
           "CgAAAEFja2VkU3RhdGUDAQAqAAAARGV2aWNlSGVhbHRoRGlhZ25vc3RpY0FsYXJtVHlwZV9BY2tlZFN0" +
           "YXRlAC8BACMjABX/////AQEBAAAAAQAsIwEDAQAsAAAARGV2aWNlSGVhbHRoRGlhZ25vc3RpY0FsYXJt" +
           "VHlwZV9FbmFibGVkU3RhdGUBAAAAFWCJCAIAAAAAAAIAAABJZAEBAAAALgBEAAH/////AQH/////AAAA" +
           "AARhgggEAAAAAAALAAAAQWNrbm93bGVkZ2UBAQAAAC8BAJcjAQEBAAAAAQD5CwABAPAiAQAAABdgqQgC" +
           "AAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQAAAC4ARJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50SWQAD///" +
           "//8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50LgEAKgEB" +
           "QgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0byB0aGUg" +
           "Y29uZGl0aW9uLgEAKAEBAAAAAQAAAAIAAAABAf////8AAAAAFWCJCAIAAAAAAAsAAABBY3RpdmVTdGF0" +
           "ZQMBACsAAABEZXZpY2VIZWFsdGhEaWFnbm9zdGljQWxhcm1UeXBlX0FjdGl2ZVN0YXRlAC8BACMjABX/" +
           "////AQEBAAAAAQAsIwEDAQAsAAAARGV2aWNlSGVhbHRoRGlhZ25vc3RpY0FsYXJtVHlwZV9FbmFibGVk" +
           "U3RhdGUBAAAAFWCJCAIAAAAAAAIAAABJZAEBAAAALgBEAAH/////AQH/////AAAAABVgiQgCAAAAAAAJ" +
           "AAAASW5wdXROb2RlAQEAAAAuAEQAEf////8BAf////8AAAAAFWCJCAIAAAAAABMAAABTdXBwcmVzc2Vk" +
           "T3JTaGVsdmVkAQEAAAAuAEQAAf////8BAf////8AAAAAFWCJCAIAAAAAAAsAAABOb3JtYWxTdGF0ZQEB" +
           "AAAALgBEABH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region FailureAlarmTypeState Class
    #if (!OPCUA_EXCLUDE_FailureAlarmTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class FailureAlarmTypeState : DeviceHealthDiagnosticAlarmTypeState
    {
        #region Constructors
        public FailureAlarmTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.FailureAlarmType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAYAAAARmFp" +
           "bHVyZUFsYXJtVHlwZUluc3RhbmNlAQG8OwEBvDu8OwAA/////xsAAAAVYIkIAgAAAAAABwAAAEV2ZW50" +
           "SWQBAQAAAC4ARAAP/////wEB/////wAAAAAVYIkIAgAAAAAACQAAAEV2ZW50VHlwZQEBAAAALgBEABH/" +
           "////AQH/////AAAAABVgiQgCAAAAAAAKAAAAU291cmNlTm9kZQEBAAAALgBEABH/////AQH/////AAAA" +
           "ABVgiQgCAAAAAAAKAAAAU291cmNlTmFtZQEBAAAALgBEAAz/////AQH/////AAAAABVgiQgCAAAAAAAE" +
           "AAAAVGltZQEBAAAALgBEAQAmAf////8BAf////8AAAAAFWCJCAIAAAAAAAsAAABSZWNlaXZlVGltZQEB" +
           "AAAALgBEAQAmAf////8BAf////8AAAAAFWCJCAIAAAAAAAcAAABNZXNzYWdlAQEAAAAuAEQAFf////8B" +
           "Af////8AAAAAFWCJCAIAAAAAAAgAAABTZXZlcml0eQEBAAAALgBEAAX/////AQH/////AAAAABVgiQgC" +
           "AAAAAAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEBAAAALgBEABH/////AQH/////AAAAABVgiQgCAAAAAAAS" +
           "AAAAQ29uZGl0aW9uQ2xhc3NOYW1lAQEAAAAuAEQAFf////8BAf////8AAAAAFWCJCAIAAAAAAA0AAABD" +
           "b25kaXRpb25OYW1lAQEAAAAuAEQADP////8BAf////8AAAAAFWCJCAIAAAAAAAgAAABCcmFuY2hJZAEB" +
           "AAAALgBEABH/////AQH/////AAAAABVgiQgCAAAAAAAGAAAAUmV0YWluAQEAAAAuAEQAAf////8BAf//" +
           "//8AAAAAFWCJCAIAAAAAAAwAAABFbmFibGVkU3RhdGUBAQAAAC8BACMjABX/////AQEFAAAAAQAsIwAD" +
           "AQAbAAAARmFpbHVyZUFsYXJtVHlwZV9BY2tlZFN0YXRlAQAsIwADAQAfAAAARmFpbHVyZUFsYXJtVHlw" +
           "ZV9Db25maXJtZWRTdGF0ZQEALCMAAwEAHAAAAEZhaWx1cmVBbGFybVR5cGVfQWN0aXZlU3RhdGUBACwj" +
           "AAMBACAAAABGYWlsdXJlQWxhcm1UeXBlX1N1cHByZXNzZWRTdGF0ZQEALCMAAwEAHgAAAEZhaWx1cmVB" +
           "bGFybVR5cGVfU2hlbHZpbmdTdGF0ZQEAAAAVYIkIAgAAAAAAAgAAAElkAQEAAAAuAEQAAf////8BAf//" +
           "//8AAAAAFWCJCAIAAAAAAAcAAABRdWFsaXR5AQEAAAAvAQAqIwAT/////wEB/////wEAAAAVYIkIAgAA" +
           "AAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBAAAALgBEAQAmAf////8BAf////8AAAAAFWCJCAIAAAAAAAwA" +
           "AABMYXN0U2V2ZXJpdHkBAQAAAC8BACojAAX/////AQH/////AQAAABVgiQgCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQEAAAAuAEQBACYB/////wEB/////wAAAAAVYIkIAgAAAAAABwAAAENvbW1lbnQBAQAA" +
           "AC8BACojABX/////AQH/////AQAAABVgiQgCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQEAAAAuAEQB" +
           "ACYB/////wEB/////wAAAAAVYIkIAgAAAAAADAAAAENsaWVudFVzZXJJZAEBAAAALgBEAAz/////AQH/" +
           "////AAAAAARhgggEAAAAAAAHAAAARGlzYWJsZQEBAAAALwEARCMBAQEAAAABAPkLAAEA8woAAAAABGGC" +
           "CAQAAAAAAAYAAABFbmFibGUBAQAAAC8BAEMjAQEBAAAAAQD5CwABAPMKAAAAAARhgggEAAAAAAAKAAAA" +
           "QWRkQ29tbWVudAEBAAAALwEARSMBAQEAAAABAPkLAAEADQsBAAAAF2CpCAIAAAAAAA4AAABJbnB1dEFy" +
           "Z3VtZW50cwEBAAAALgBElgIAAAABACoBAUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABU" +
           "aGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQA" +
           "Ff////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEA" +
           "AAABAAAAAgAAAAEB/////wAAAAAVYIkIAgAAAAAACgAAAEFja2VkU3RhdGUDAQAbAAAARmFpbHVyZUFs" +
           "YXJtVHlwZV9BY2tlZFN0YXRlAC8BACMjABX/////AQEBAAAAAQAsIwEDAQAdAAAARmFpbHVyZUFsYXJt" +
           "VHlwZV9FbmFibGVkU3RhdGUBAAAAFWCJCAIAAAAAAAIAAABJZAEBAAAALgBEAAH/////AQH/////AAAA" +
           "AARhgggEAAAAAAALAAAAQWNrbm93bGVkZ2UBAQAAAC8BAJcjAQEBAAAAAQD5CwABAPAiAQAAABdgqQgC" +
           "AAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQAAAC4ARJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50SWQAD///" +
           "//8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50LgEAKgEB" +
           "QgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0byB0aGUg" +
           "Y29uZGl0aW9uLgEAKAEBAAAAAQAAAAIAAAABAf////8AAAAAFWCJCAIAAAAAAAsAAABBY3RpdmVTdGF0" +
           "ZQMBABwAAABGYWlsdXJlQWxhcm1UeXBlX0FjdGl2ZVN0YXRlAC8BACMjABX/////AQEBAAAAAQAsIwED" +
           "AQAdAAAARmFpbHVyZUFsYXJtVHlwZV9FbmFibGVkU3RhdGUBAAAAFWCJCAIAAAAAAAIAAABJZAEBAAAA" +
           "LgBEAAH/////AQH/////AAAAABVgiQgCAAAAAAAJAAAASW5wdXROb2RlAQEAAAAuAEQAEf////8BAf//" +
           "//8AAAAAFWCJCAIAAAAAABMAAABTdXBwcmVzc2VkT3JTaGVsdmVkAQEAAAAuAEQAAf////8BAf////8A" +
           "AAAAFWCJCAIAAAAAAAsAAABOb3JtYWxTdGF0ZQEBAAAALgBEABH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region CheckFunctionAlarmTypeState Class
    #if (!OPCUA_EXCLUDE_CheckFunctionAlarmTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class CheckFunctionAlarmTypeState : DeviceHealthDiagnosticAlarmTypeState
    {
        #region Constructors
        public CheckFunctionAlarmTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.CheckFunctionAlarmType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAeAAAAQ2hl" +
           "Y2tGdW5jdGlvbkFsYXJtVHlwZUluc3RhbmNlAQFRPAEBUTxRPAAA/////xsAAAAVYIkIAgAAAAAABwAA" +
           "AEV2ZW50SWQBAQAAAC4ARAAP/////wEB/////wAAAAAVYIkIAgAAAAAACQAAAEV2ZW50VHlwZQEBAAAA" +
           "LgBEABH/////AQH/////AAAAABVgiQgCAAAAAAAKAAAAU291cmNlTm9kZQEBAAAALgBEABH/////AQH/" +
           "////AAAAABVgiQgCAAAAAAAKAAAAU291cmNlTmFtZQEBAAAALgBEAAz/////AQH/////AAAAABVgiQgC" +
           "AAAAAAAEAAAAVGltZQEBAAAALgBEAQAmAf////8BAf////8AAAAAFWCJCAIAAAAAAAsAAABSZWNlaXZl" +
           "VGltZQEBAAAALgBEAQAmAf////8BAf////8AAAAAFWCJCAIAAAAAAAcAAABNZXNzYWdlAQEAAAAuAEQA" +
           "Ff////8BAf////8AAAAAFWCJCAIAAAAAAAgAAABTZXZlcml0eQEBAAAALgBEAAX/////AQH/////AAAA" +
           "ABVgiQgCAAAAAAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEBAAAALgBEABH/////AQH/////AAAAABVgiQgC" +
           "AAAAAAASAAAAQ29uZGl0aW9uQ2xhc3NOYW1lAQEAAAAuAEQAFf////8BAf////8AAAAAFWCJCAIAAAAA" +
           "AA0AAABDb25kaXRpb25OYW1lAQEAAAAuAEQADP////8BAf////8AAAAAFWCJCAIAAAAAAAgAAABCcmFu" +
           "Y2hJZAEBAAAALgBEABH/////AQH/////AAAAABVgiQgCAAAAAAAGAAAAUmV0YWluAQEAAAAuAEQAAf//" +
           "//8BAf////8AAAAAFWCJCAIAAAAAAAwAAABFbmFibGVkU3RhdGUBAQAAAC8BACMjABX/////AQEFAAAA" +
           "AQAsIwADAQAhAAAAQ2hlY2tGdW5jdGlvbkFsYXJtVHlwZV9BY2tlZFN0YXRlAQAsIwADAQAlAAAAQ2hl" +
           "Y2tGdW5jdGlvbkFsYXJtVHlwZV9Db25maXJtZWRTdGF0ZQEALCMAAwEAIgAAAENoZWNrRnVuY3Rpb25B" +
           "bGFybVR5cGVfQWN0aXZlU3RhdGUBACwjAAMBACYAAABDaGVja0Z1bmN0aW9uQWxhcm1UeXBlX1N1cHBy" +
           "ZXNzZWRTdGF0ZQEALCMAAwEAJAAAAENoZWNrRnVuY3Rpb25BbGFybVR5cGVfU2hlbHZpbmdTdGF0ZQEA" +
           "AAAVYIkIAgAAAAAAAgAAAElkAQEAAAAuAEQAAf////8BAf////8AAAAAFWCJCAIAAAAAAAcAAABRdWFs" +
           "aXR5AQEAAAAvAQAqIwAT/////wEB/////wEAAAAVYIkIAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEB" +
           "AAAALgBEAQAmAf////8BAf////8AAAAAFWCJCAIAAAAAAAwAAABMYXN0U2V2ZXJpdHkBAQAAAC8BACoj" +
           "AAX/////AQH/////AQAAABVgiQgCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQEAAAAuAEQBACYB////" +
           "/wEB/////wAAAAAVYIkIAgAAAAAABwAAAENvbW1lbnQBAQAAAC8BACojABX/////AQH/////AQAAABVg" +
           "iQgCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQEAAAAuAEQBACYB/////wEB/////wAAAAAVYIkIAgAA" +
           "AAAADAAAAENsaWVudFVzZXJJZAEBAAAALgBEAAz/////AQH/////AAAAAARhgggEAAAAAAAHAAAARGlz" +
           "YWJsZQEBAAAALwEARCMBAQEAAAABAPkLAAEA8woAAAAABGGCCAQAAAAAAAYAAABFbmFibGUBAQAAAC8B" +
           "AEMjAQEBAAAAAQD5CwABAPMKAAAAAARhgggEAAAAAAAKAAAAQWRkQ29tbWVudAEBAAAALwEARSMBAQEA" +
           "AAABAPkLAAEADQsBAAAAF2CpCAIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBAAAALgBElgIAAAABACoB" +
           "AUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2" +
           "ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNv" +
           "bW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAAVYIkI" +
           "AgAAAAAACgAAAEFja2VkU3RhdGUDAQAhAAAAQ2hlY2tGdW5jdGlvbkFsYXJtVHlwZV9BY2tlZFN0YXRl" +
           "AC8BACMjABX/////AQEBAAAAAQAsIwEDAQAjAAAAQ2hlY2tGdW5jdGlvbkFsYXJtVHlwZV9FbmFibGVk" +
           "U3RhdGUBAAAAFWCJCAIAAAAAAAIAAABJZAEBAAAALgBEAAH/////AQH/////AAAAAARhgggEAAAAAAAL" +
           "AAAAQWNrbm93bGVkZ2UBAQAAAC8BAJcjAQEBAAAAAQD5CwABAPAiAQAAABdgqQgCAAAAAAAOAAAASW5w" +
           "dXRBcmd1bWVudHMBAQAAAC4ARJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAo" +
           "AAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21t" +
           "ZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEA" +
           "KAEBAAAAAQAAAAIAAAABAf////8AAAAAFWCJCAIAAAAAAAsAAABBY3RpdmVTdGF0ZQMBACIAAABDaGVj" +
           "a0Z1bmN0aW9uQWxhcm1UeXBlX0FjdGl2ZVN0YXRlAC8BACMjABX/////AQEBAAAAAQAsIwEDAQAjAAAA" +
           "Q2hlY2tGdW5jdGlvbkFsYXJtVHlwZV9FbmFibGVkU3RhdGUBAAAAFWCJCAIAAAAAAAIAAABJZAEBAAAA" +
           "LgBEAAH/////AQH/////AAAAABVgiQgCAAAAAAAJAAAASW5wdXROb2RlAQEAAAAuAEQAEf////8BAf//" +
           "//8AAAAAFWCJCAIAAAAAABMAAABTdXBwcmVzc2VkT3JTaGVsdmVkAQEAAAAuAEQAAf////8BAf////8A" +
           "AAAAFWCJCAIAAAAAAAsAAABOb3JtYWxTdGF0ZQEBAAAALgBEABH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region OffSpecAlarmTypeState Class
    #if (!OPCUA_EXCLUDE_OffSpecAlarmTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class OffSpecAlarmTypeState : DeviceHealthDiagnosticAlarmTypeState
    {
        #region Constructors
        public OffSpecAlarmTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.OffSpecAlarmType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAYAAAAT2Zm" +
           "U3BlY0FsYXJtVHlwZUluc3RhbmNlAQHmPAEB5jzmPAAA/////xsAAAAVYIkIAgAAAAAABwAAAEV2ZW50" +
           "SWQBAQAAAC4ARAAP/////wEB/////wAAAAAVYIkIAgAAAAAACQAAAEV2ZW50VHlwZQEBAAAALgBEABH/" +
           "////AQH/////AAAAABVgiQgCAAAAAAAKAAAAU291cmNlTm9kZQEBAAAALgBEABH/////AQH/////AAAA" +
           "ABVgiQgCAAAAAAAKAAAAU291cmNlTmFtZQEBAAAALgBEAAz/////AQH/////AAAAABVgiQgCAAAAAAAE" +
           "AAAAVGltZQEBAAAALgBEAQAmAf////8BAf////8AAAAAFWCJCAIAAAAAAAsAAABSZWNlaXZlVGltZQEB" +
           "AAAALgBEAQAmAf////8BAf////8AAAAAFWCJCAIAAAAAAAcAAABNZXNzYWdlAQEAAAAuAEQAFf////8B" +
           "Af////8AAAAAFWCJCAIAAAAAAAgAAABTZXZlcml0eQEBAAAALgBEAAX/////AQH/////AAAAABVgiQgC" +
           "AAAAAAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEBAAAALgBEABH/////AQH/////AAAAABVgiQgCAAAAAAAS" +
           "AAAAQ29uZGl0aW9uQ2xhc3NOYW1lAQEAAAAuAEQAFf////8BAf////8AAAAAFWCJCAIAAAAAAA0AAABD" +
           "b25kaXRpb25OYW1lAQEAAAAuAEQADP////8BAf////8AAAAAFWCJCAIAAAAAAAgAAABCcmFuY2hJZAEB" +
           "AAAALgBEABH/////AQH/////AAAAABVgiQgCAAAAAAAGAAAAUmV0YWluAQEAAAAuAEQAAf////8BAf//" +
           "//8AAAAAFWCJCAIAAAAAAAwAAABFbmFibGVkU3RhdGUBAQAAAC8BACMjABX/////AQEFAAAAAQAsIwAD" +
           "AQAbAAAAT2ZmU3BlY0FsYXJtVHlwZV9BY2tlZFN0YXRlAQAsIwADAQAfAAAAT2ZmU3BlY0FsYXJtVHlw" +
           "ZV9Db25maXJtZWRTdGF0ZQEALCMAAwEAHAAAAE9mZlNwZWNBbGFybVR5cGVfQWN0aXZlU3RhdGUBACwj" +
           "AAMBACAAAABPZmZTcGVjQWxhcm1UeXBlX1N1cHByZXNzZWRTdGF0ZQEALCMAAwEAHgAAAE9mZlNwZWNB" +
           "bGFybVR5cGVfU2hlbHZpbmdTdGF0ZQEAAAAVYIkIAgAAAAAAAgAAAElkAQEAAAAuAEQAAf////8BAf//" +
           "//8AAAAAFWCJCAIAAAAAAAcAAABRdWFsaXR5AQEAAAAvAQAqIwAT/////wEB/////wEAAAAVYIkIAgAA" +
           "AAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBAAAALgBEAQAmAf////8BAf////8AAAAAFWCJCAIAAAAAAAwA" +
           "AABMYXN0U2V2ZXJpdHkBAQAAAC8BACojAAX/////AQH/////AQAAABVgiQgCAAAAAAAPAAAAU291cmNl" +
           "VGltZXN0YW1wAQEAAAAuAEQBACYB/////wEB/////wAAAAAVYIkIAgAAAAAABwAAAENvbW1lbnQBAQAA" +
           "AC8BACojABX/////AQH/////AQAAABVgiQgCAAAAAAAPAAAAU291cmNlVGltZXN0YW1wAQEAAAAuAEQB" +
           "ACYB/////wEB/////wAAAAAVYIkIAgAAAAAADAAAAENsaWVudFVzZXJJZAEBAAAALgBEAAz/////AQH/" +
           "////AAAAAARhgggEAAAAAAAHAAAARGlzYWJsZQEBAAAALwEARCMBAQEAAAABAPkLAAEA8woAAAAABGGC" +
           "CAQAAAAAAAYAAABFbmFibGUBAQAAAC8BAEMjAQEBAAAAAQD5CwABAPMKAAAAAARhgggEAAAAAAAKAAAA" +
           "QWRkQ29tbWVudAEBAAAALwEARSMBAQEAAAABAPkLAAEADQsBAAAAF2CpCAIAAAAAAA4AAABJbnB1dEFy" +
           "Z3VtZW50cwEBAAAALgBElgIAAAABACoBAUYAAAAHAAAARXZlbnRJZAAP/////wAAAAADAAAAACgAAABU" +
           "aGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAABwAAAENvbW1lbnQA" +
           "Ff////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRvIHRoZSBjb25kaXRpb24uAQAoAQEA" +
           "AAABAAAAAgAAAAEB/////wAAAAAVYIkIAgAAAAAACgAAAEFja2VkU3RhdGUDAQAbAAAAT2ZmU3BlY0Fs" +
           "YXJtVHlwZV9BY2tlZFN0YXRlAC8BACMjABX/////AQEBAAAAAQAsIwEDAQAdAAAAT2ZmU3BlY0FsYXJt" +
           "VHlwZV9FbmFibGVkU3RhdGUBAAAAFWCJCAIAAAAAAAIAAABJZAEBAAAALgBEAAH/////AQH/////AAAA" +
           "AARhgggEAAAAAAALAAAAQWNrbm93bGVkZ2UBAQAAAC8BAJcjAQEBAAAAAQD5CwABAPAiAQAAABdgqQgC" +
           "AAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAQAAAC4ARJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50SWQAD///" +
           "//8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50LgEAKgEB" +
           "QgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0byB0aGUg" +
           "Y29uZGl0aW9uLgEAKAEBAAAAAQAAAAIAAAABAf////8AAAAAFWCJCAIAAAAAAAsAAABBY3RpdmVTdGF0" +
           "ZQMBABwAAABPZmZTcGVjQWxhcm1UeXBlX0FjdGl2ZVN0YXRlAC8BACMjABX/////AQEBAAAAAQAsIwED" +
           "AQAdAAAAT2ZmU3BlY0FsYXJtVHlwZV9FbmFibGVkU3RhdGUBAAAAFWCJCAIAAAAAAAIAAABJZAEBAAAA" +
           "LgBEAAH/////AQH/////AAAAABVgiQgCAAAAAAAJAAAASW5wdXROb2RlAQEAAAAuAEQAEf////8BAf//" +
           "//8AAAAAFWCJCAIAAAAAABMAAABTdXBwcmVzc2VkT3JTaGVsdmVkAQEAAAAuAEQAAf////8BAf////8A" +
           "AAAAFWCJCAIAAAAAAAsAAABOb3JtYWxTdGF0ZQEBAAAALgBEABH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MaintenanceRequiredAlarmTypeState Class
    #if (!OPCUA_EXCLUDE_MaintenanceRequiredAlarmTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class MaintenanceRequiredAlarmTypeState : DeviceHealthDiagnosticAlarmTypeState
    {
        #region Constructors
        public MaintenanceRequiredAlarmTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.MaintenanceRequiredAlarmType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAkAAAATWFp" +
           "bnRlbmFuY2VSZXF1aXJlZEFsYXJtVHlwZUluc3RhbmNlAQF7PQEBez17PQAA/////xsAAAAVYIkIAgAA" +
           "AAAABwAAAEV2ZW50SWQBAQAAAC4ARAAP/////wEB/////wAAAAAVYIkIAgAAAAAACQAAAEV2ZW50VHlw" +
           "ZQEBAAAALgBEABH/////AQH/////AAAAABVgiQgCAAAAAAAKAAAAU291cmNlTm9kZQEBAAAALgBEABH/" +
           "////AQH/////AAAAABVgiQgCAAAAAAAKAAAAU291cmNlTmFtZQEBAAAALgBEAAz/////AQH/////AAAA" +
           "ABVgiQgCAAAAAAAEAAAAVGltZQEBAAAALgBEAQAmAf////8BAf////8AAAAAFWCJCAIAAAAAAAsAAABS" +
           "ZWNlaXZlVGltZQEBAAAALgBEAQAmAf////8BAf////8AAAAAFWCJCAIAAAAAAAcAAABNZXNzYWdlAQEA" +
           "AAAuAEQAFf////8BAf////8AAAAAFWCJCAIAAAAAAAgAAABTZXZlcml0eQEBAAAALgBEAAX/////AQH/" +
           "////AAAAABVgiQgCAAAAAAAQAAAAQ29uZGl0aW9uQ2xhc3NJZAEBAAAALgBEABH/////AQH/////AAAA" +
           "ABVgiQgCAAAAAAASAAAAQ29uZGl0aW9uQ2xhc3NOYW1lAQEAAAAuAEQAFf////8BAf////8AAAAAFWCJ" +
           "CAIAAAAAAA0AAABDb25kaXRpb25OYW1lAQEAAAAuAEQADP////8BAf////8AAAAAFWCJCAIAAAAAAAgA" +
           "AABCcmFuY2hJZAEBAAAALgBEABH/////AQH/////AAAAABVgiQgCAAAAAAAGAAAAUmV0YWluAQEAAAAu" +
           "AEQAAf////8BAf////8AAAAAFWCJCAIAAAAAAAwAAABFbmFibGVkU3RhdGUBAQAAAC8BACMjABX/////" +
           "AQEFAAAAAQAsIwADAQAnAAAATWFpbnRlbmFuY2VSZXF1aXJlZEFsYXJtVHlwZV9BY2tlZFN0YXRlAQAs" +
           "IwADAQArAAAATWFpbnRlbmFuY2VSZXF1aXJlZEFsYXJtVHlwZV9Db25maXJtZWRTdGF0ZQEALCMAAwEA" +
           "KAAAAE1haW50ZW5hbmNlUmVxdWlyZWRBbGFybVR5cGVfQWN0aXZlU3RhdGUBACwjAAMBACwAAABNYWlu" +
           "dGVuYW5jZVJlcXVpcmVkQWxhcm1UeXBlX1N1cHByZXNzZWRTdGF0ZQEALCMAAwEAKgAAAE1haW50ZW5h" +
           "bmNlUmVxdWlyZWRBbGFybVR5cGVfU2hlbHZpbmdTdGF0ZQEAAAAVYIkIAgAAAAAAAgAAAElkAQEAAAAu" +
           "AEQAAf////8BAf////8AAAAAFWCJCAIAAAAAAAcAAABRdWFsaXR5AQEAAAAvAQAqIwAT/////wEB////" +
           "/wEAAAAVYIkIAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBAAAALgBEAQAmAf////8BAf////8AAAAA" +
           "FWCJCAIAAAAAAAwAAABMYXN0U2V2ZXJpdHkBAQAAAC8BACojAAX/////AQH/////AQAAABVgiQgCAAAA" +
           "AAAPAAAAU291cmNlVGltZXN0YW1wAQEAAAAuAEQBACYB/////wEB/////wAAAAAVYIkIAgAAAAAABwAA" +
           "AENvbW1lbnQBAQAAAC8BACojABX/////AQH/////AQAAABVgiQgCAAAAAAAPAAAAU291cmNlVGltZXN0" +
           "YW1wAQEAAAAuAEQBACYB/////wEB/////wAAAAAVYIkIAgAAAAAADAAAAENsaWVudFVzZXJJZAEBAAAA" +
           "LgBEAAz/////AQH/////AAAAAARhgggEAAAAAAAHAAAARGlzYWJsZQEBAAAALwEARCMBAQEAAAABAPkL" +
           "AAEA8woAAAAABGGCCAQAAAAAAAYAAABFbmFibGUBAQAAAC8BAEMjAQEBAAAAAQD5CwABAPMKAAAAAARh" +
           "gggEAAAAAAAKAAAAQWRkQ29tbWVudAEBAAAALwEARSMBAQEAAAABAPkLAAEADQsBAAAAF2CpCAIAAAAA" +
           "AA4AAABJbnB1dEFyZ3VtZW50cwEBAAAALgBElgIAAAABACoBAUYAAAAHAAAARXZlbnRJZAAP/////wAA" +
           "AAADAAAAACgAAABUaGUgaWRlbnRpZmllciBmb3IgdGhlIGV2ZW50IHRvIGNvbW1lbnQuAQAqAQFCAAAA" +
           "BwAAAENvbW1lbnQAFf////8AAAAAAwAAAAAkAAAAVGhlIGNvbW1lbnQgdG8gYWRkIHRvIHRoZSBjb25k" +
           "aXRpb24uAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAAVYIkIAgAAAAAACgAAAEFja2VkU3RhdGUDAQAn" +
           "AAAATWFpbnRlbmFuY2VSZXF1aXJlZEFsYXJtVHlwZV9BY2tlZFN0YXRlAC8BACMjABX/////AQEBAAAA" +
           "AQAsIwEDAQApAAAATWFpbnRlbmFuY2VSZXF1aXJlZEFsYXJtVHlwZV9FbmFibGVkU3RhdGUBAAAAFWCJ" +
           "CAIAAAAAAAIAAABJZAEBAAAALgBEAAH/////AQH/////AAAAAARhgggEAAAAAAALAAAAQWNrbm93bGVk" +
           "Z2UBAQAAAC8BAJcjAQEBAAAAAQD5CwABAPAiAQAAABdgqQgCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMB" +
           "AQAAAC4ARJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50" +
           "aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAA" +
           "AAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAIA" +
           "AAABAf////8AAAAAFWCJCAIAAAAAAAsAAABBY3RpdmVTdGF0ZQMBACgAAABNYWludGVuYW5jZVJlcXVp" +
           "cmVkQWxhcm1UeXBlX0FjdGl2ZVN0YXRlAC8BACMjABX/////AQEBAAAAAQAsIwEDAQApAAAATWFpbnRl" +
           "bmFuY2VSZXF1aXJlZEFsYXJtVHlwZV9FbmFibGVkU3RhdGUBAAAAFWCJCAIAAAAAAAIAAABJZAEBAAAA" +
           "LgBEAAH/////AQH/////AAAAABVgiQgCAAAAAAAJAAAASW5wdXROb2RlAQEAAAAuAEQAEf////8BAf//" +
           "//8AAAAAFWCJCAIAAAAAABMAAABTdXBwcmVzc2VkT3JTaGVsdmVkAQEAAAAuAEQAAf////8BAf////8A" +
           "AAAAFWCJCAIAAAAAAAsAAABOb3JtYWxTdGF0ZQEBAAAALgBEABH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ConfigurableObjectTypeState Class
    #if (!OPCUA_EXCLUDE_ConfigurableObjectTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class ConfigurableObjectTypeState : BaseObjectState
    {
        #region Constructors
        public ConfigurableObjectTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.ConfigurableObjectType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAeAAAAQ29u" +
           "ZmlndXJhYmxlT2JqZWN0VHlwZUluc3RhbmNlAQHsAwEB7APsAwAA/////wIAAAAEYIAKAQAAAAEADgAA" +
           "AFN1cHBvcnRlZFR5cGVzAQGMEwAvAD2MEwAA/////wAAAAAEYMAKAQAAABwAAABPYmplY3RJZGVudGlm" +
           "aWVyX1BsYWNlaG9sZGVyAQASAAAAPE9iamVjdElkZW50aWZpZXI+AQGKFwAvADqKFwAA/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public FolderState SupportedTypes
        {
            get => m_supportedTypes;

            set
            {
                if (!Object.ReferenceEquals(m_supportedTypes, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_supportedTypes = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_supportedTypes != null)
            {
                children.Add(m_supportedTypes);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_supportedTypes, child))
            {
                m_supportedTypes = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.SupportedTypes:
                {
                    if (createOrReplace)
                    {
                        if (SupportedTypes == null)
                        {
                            if (replacement == null)
                            {
                                SupportedTypes = new FolderState(this);
                            }
                            else
                            {
                                SupportedTypes = (FolderState)replacement;
                            }
                        }
                    }

                    instance = SupportedTypes;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private FolderState m_supportedTypes;
        #endregion
    }
    #endif
    #endregion

    #region LifetimeVariableTypeState Class
    #if (!OPCUA_EXCLUDE_LifetimeVariableTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class LifetimeVariableTypeState : AnalogUnitState
    {
        #region Constructors
        public LifetimeVariableTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.VariableTypes.LifetimeVariableType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.Number, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Indication != null)
            {
                Indication.Initialize(context, Indication_InitializationString);
            }

            if (WarningValues != null)
            {
                WarningValues.Initialize(context, WarningValues_InitializationString);
            }
        }

        #region Initialization String
        private const string Indication_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAKAAAASW5k" +
           "aWNhdGlvbgEB1wEDAAAAAIkAAABJbmRpY2F0aW9uIGdpdmVzIGFuIGluZGljYXRpb24gb2Ygd2hhdCBp" +
           "cyBhY3R1YWxseSBtZWFzdXJlZCAvIHJlcHJlc2VudGVkIGJ5IHRoZSBWYWx1ZSBvZiB0aGUgVmFyaWFi" +
           "bGUgYW5kIHRoZSBTdGFydFZhbHVlIGFuZCBMaW1pdFZhbHVlLgAuAETXAQAAABH/////AQH/////AAAA" +
           "AA==";

        private const string WarningValues_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQANAAAAV2Fy" +
           "bmluZ1ZhbHVlcwEB2AEDAAAAAIQAAABXYXJuaW5nVmFsdWVzIGluZGljYXRlcyBvbmUgb3IgbW9yZSBs" +
           "ZXZlbHMgd2hlbiB0aGUgZW5kIG9mIGxpZmV0aW1lIGlzIHJlYWNoZWQgc29vbiBhbmQgY2FuIGJlIHVz" +
           "ZWQgdG8gaW5mb3JtIHRoZSB1c2VyIHdoZW4gcmVhY2hlZC4ALgBE2AEAAAAa/f///wEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQICAAAAAQAcAAAATGlm" +
           "ZXRpbWVWYXJpYWJsZVR5cGVJbnN0YW5jZQEB1AEBAdQB1AEAAAAa/////wEB/////wUAAAAVYIkIAgAA" +
           "AAAAEAAAAEVuZ2luZWVyaW5nVW5pdHMBAQAAAC4ARAEAdwP/////AQH/////AAAAADVgiQoCAAAAAQAK" +
           "AAAAU3RhcnRWYWx1ZQEB1QEDAAAAAFMAAABTdGFydFZhbHVlIGluZGljYXRlcyB0aGUgaW5pdGlhbCB2" +
           "YWx1ZSwgd2hlbiB0aGVyZSBpcyBzdGlsbCB0aGUgZnVsbCBsaWZldGltZSBsZWZ0LgAuAETVAQAAABr/" +
           "////AQH/////AAAAADVgiQoCAAAAAQAKAAAATGltaXRWYWx1ZQEB1gEDAAAAAD8AAABMaW1pdFZhbHVl" +
           "IGluZGljYXRlcyB3aGVuIHRoZSBlbmQgb2YgbGlmZXRpbWUgaGFzIGJlZW4gcmVhY2hlZC4ALgBE1gEA" +
           "AAAa/////wEB/////wAAAAA1YIkKAgAAAAEACgAAAEluZGljYXRpb24BAdcBAwAAAACJAAAASW5kaWNh" +
           "dGlvbiBnaXZlcyBhbiBpbmRpY2F0aW9uIG9mIHdoYXQgaXMgYWN0dWFsbHkgbWVhc3VyZWQgLyByZXBy" +
           "ZXNlbnRlZCBieSB0aGUgVmFsdWUgb2YgdGhlIFZhcmlhYmxlIGFuZCB0aGUgU3RhcnRWYWx1ZSBhbmQg" +
           "TGltaXRWYWx1ZS4ALgBE1wEAAAAR/////wEB/////wAAAAA1YIkKAgAAAAEADQAAAFdhcm5pbmdWYWx1" +
           "ZXMBAdgBAwAAAACEAAAAV2FybmluZ1ZhbHVlcyBpbmRpY2F0ZXMgb25lIG9yIG1vcmUgbGV2ZWxzIHdo" +
           "ZW4gdGhlIGVuZCBvZiBsaWZldGltZSBpcyByZWFjaGVkIHNvb24gYW5kIGNhbiBiZSB1c2VkIHRvIGlu" +
           "Zm9ybSB0aGUgdXNlciB3aGVuIHJlYWNoZWQuAC4ARNgBAAAAGv3///8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public PropertyState StartValue
        {
            get => m_startValue;

            set
            {
                if (!Object.ReferenceEquals(m_startValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startValue = value;
            }
        }

        public PropertyState LimitValue
        {
            get => m_limitValue;

            set
            {
                if (!Object.ReferenceEquals(m_limitValue, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_limitValue = value;
            }
        }

        public PropertyState<NodeId> Indication
        {
            get => m_indication;

            set
            {
                if (!Object.ReferenceEquals(m_indication, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_indication = value;
            }
        }

        public PropertyState WarningValues
        {
            get => m_warningValues;

            set
            {
                if (!Object.ReferenceEquals(m_warningValues, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_warningValues = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_startValue != null)
            {
                children.Add(m_startValue);
            }

            if (m_limitValue != null)
            {
                children.Add(m_limitValue);
            }

            if (m_indication != null)
            {
                children.Add(m_indication);
            }

            if (m_warningValues != null)
            {
                children.Add(m_warningValues);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_startValue, child))
            {
                m_startValue = null;
                return;
            }

            if (Object.ReferenceEquals(m_limitValue, child))
            {
                m_limitValue = null;
                return;
            }

            if (Object.ReferenceEquals(m_indication, child))
            {
                m_indication = null;
                return;
            }

            if (Object.ReferenceEquals(m_warningValues, child))
            {
                m_warningValues = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.StartValue:
                {
                    if (createOrReplace)
                    {
                        if (StartValue == null)
                        {
                            if (replacement == null)
                            {
                                StartValue = new PropertyState(this);
                            }
                            else
                            {
                                StartValue = (PropertyState)replacement;
                            }
                        }
                    }

                    instance = StartValue;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.LimitValue:
                {
                    if (createOrReplace)
                    {
                        if (LimitValue == null)
                        {
                            if (replacement == null)
                            {
                                LimitValue = new PropertyState(this);
                            }
                            else
                            {
                                LimitValue = (PropertyState)replacement;
                            }
                        }
                    }

                    instance = LimitValue;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.Indication:
                {
                    if (createOrReplace)
                    {
                        if (Indication == null)
                        {
                            if (replacement == null)
                            {
                                Indication = new PropertyState<NodeId>(this);
                            }
                            else
                            {
                                Indication = (PropertyState<NodeId>)replacement;
                            }
                        }
                    }

                    instance = Indication;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.WarningValues:
                {
                    if (createOrReplace)
                    {
                        if (WarningValues == null)
                        {
                            if (replacement == null)
                            {
                                WarningValues = new PropertyState(this);
                            }
                            else
                            {
                                WarningValues = (PropertyState)replacement;
                            }
                        }
                    }

                    instance = WarningValues;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState m_startValue;
        private PropertyState m_limitValue;
        private PropertyState<NodeId> m_indication;
        private PropertyState m_warningValues;
        #endregion
    }

    #region LifetimeVariableTypeState<T> Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class LifetimeVariableTypeState<T> : LifetimeVariableTypeState
    {
        #region Constructors
        public LifetimeVariableTypeState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region BaseLifetimeIndicationTypeState Class
    #if (!OPCUA_EXCLUDE_BaseLifetimeIndicationTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class BaseLifetimeIndicationTypeState : BaseObjectState
    {
        #region Constructors
        public BaseLifetimeIndicationTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.BaseLifetimeIndicationType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAiAAAAQmFz" +
           "ZUxpZmV0aW1lSW5kaWNhdGlvblR5cGVJbnN0YW5jZQEB2QEBAdkB2QEAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region TimeIndicationTypeState Class
    #if (!OPCUA_EXCLUDE_TimeIndicationTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class TimeIndicationTypeState : BaseLifetimeIndicationTypeState
    {
        #region Constructors
        public TimeIndicationTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.TimeIndicationType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAaAAAAVGlt" +
           "ZUluZGljYXRpb25UeXBlSW5zdGFuY2UBAdoBAQHaAdoBAAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region NumberOfPartsIndicationTypeState Class
    #if (!OPCUA_EXCLUDE_NumberOfPartsIndicationTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class NumberOfPartsIndicationTypeState : BaseLifetimeIndicationTypeState
    {
        #region Constructors
        public NumberOfPartsIndicationTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.NumberOfPartsIndicationType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAjAAAATnVt" +
           "YmVyT2ZQYXJ0c0luZGljYXRpb25UeXBlSW5zdGFuY2UBAdsBAQHbAdsBAAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region NumberOfUsagesIndicationTypeState Class
    #if (!OPCUA_EXCLUDE_NumberOfUsagesIndicationTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class NumberOfUsagesIndicationTypeState : BaseLifetimeIndicationTypeState
    {
        #region Constructors
        public NumberOfUsagesIndicationTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.NumberOfUsagesIndicationType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAkAAAATnVt" +
           "YmVyT2ZVc2FnZXNJbmRpY2F0aW9uVHlwZUluc3RhbmNlAQHcAQEB3AHcAQAA/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region LengthIndicationTypeState Class
    #if (!OPCUA_EXCLUDE_LengthIndicationTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class LengthIndicationTypeState : BaseLifetimeIndicationTypeState
    {
        #region Constructors
        public LengthIndicationTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.LengthIndicationType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAcAAAATGVu" +
           "Z3RoSW5kaWNhdGlvblR5cGVJbnN0YW5jZQEB3QEBAd0B3QEAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region DiameterIndicationTypeState Class
    #if (!OPCUA_EXCLUDE_DiameterIndicationTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class DiameterIndicationTypeState : BaseLifetimeIndicationTypeState
    {
        #region Constructors
        public DiameterIndicationTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.DiameterIndicationType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAeAAAARGlh" +
           "bWV0ZXJJbmRpY2F0aW9uVHlwZUluc3RhbmNlAQHeAQEB3gHeAQAA/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region SubstanceVolumeIndicationTypeState Class
    #if (!OPCUA_EXCLUDE_SubstanceVolumeIndicationTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class SubstanceVolumeIndicationTypeState : BaseLifetimeIndicationTypeState
    {
        #region Constructors
        public SubstanceVolumeIndicationTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.SubstanceVolumeIndicationType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAlAAAAU3Vi" +
           "c3RhbmNlVm9sdW1lSW5kaWNhdGlvblR5cGVJbnN0YW5jZQEB3wEBAd8B3wEAAP////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region FunctionalGroupTypeState Class
    #if (!OPCUA_EXCLUDE_FunctionalGroupTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class FunctionalGroupTypeState : FolderState
    {
        #region Constructors
        public FunctionalGroupTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.FunctionalGroupType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (UIElement != null)
            {
                UIElement.Initialize(context, UIElement_InitializationString);
            }
        }

        #region Initialization String
        private const string UIElement_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAJAAAAVUlF" +
           "bGVtZW50AQFjGAAvAQFmGGMYAAAAGP////8BAf////8AAAAA";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAbAAAARnVu" +
           "Y3Rpb25hbEdyb3VwVHlwZUluc3RhbmNlAQHtAwEB7QPtAwAA/////wIAAAAEYMAKAQAAABsAAABHcm91" +
           "cElkZW50aWZpZXJfUGxhY2Vob2xkZXIBABEAAAA8R3JvdXBJZGVudGlmaWVyPgEBixcALwEB7QOLFwAA" +
           "/////wEAAAAVYIkKAgAAAAEACQAAAFVJRWxlbWVudAEBYhgALwEBZhhiGAAAABj/////AQH/////AAAA" +
           "ABVgiQoCAAAAAQAJAAAAVUlFbGVtZW50AQFjGAAvAQFmGGMYAAAAGP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public UIElementTypeState UIElement
        {
            get => m_uIElement;

            set
            {
                if (!Object.ReferenceEquals(m_uIElement, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_uIElement = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_uIElement != null)
            {
                children.Add(m_uIElement);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_uIElement, child))
            {
                m_uIElement = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.UIElement:
                {
                    if (createOrReplace)
                    {
                        if (UIElement == null)
                        {
                            if (replacement == null)
                            {
                                UIElement = new UIElementTypeState(this);
                            }
                            else
                            {
                                UIElement = (UIElementTypeState)replacement;
                            }
                        }
                    }

                    instance = UIElement;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private UIElementTypeState m_uIElement;
        #endregion
    }
    #endif
    #endregion

    #region ProtocolTypeState Class
    #if (!OPCUA_EXCLUDE_ProtocolTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class ProtocolTypeState : BaseObjectState
    {
        #region Constructors
        public ProtocolTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.ProtocolType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAUAAAAUHJv" +
           "dG9jb2xUeXBlSW5zdGFuY2UBAe4DAQHuA+4DAAD/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region IOperationCounterTypeState Class
    #if (!OPCUA_EXCLUDE_IOperationCounterTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class IOperationCounterTypeState : BaseInterfaceState
    {
        #region Constructors
        public IOperationCounterTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.IOperationCounterType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (PowerOnDuration != null)
            {
                PowerOnDuration.Initialize(context, PowerOnDuration_InitializationString);
            }

            if (OperationDuration != null)
            {
                OperationDuration.Initialize(context, OperationDuration_InitializationString);
            }

            if (OperationCycleCounter != null)
            {
                OperationCycleCounter.Initialize(context, OperationCycleCounter_InitializationString);
            }
        }

        #region Initialization String
        private const string PowerOnDuration_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAPAAAAUG93" +
           "ZXJPbkR1cmF0aW9uAQHhAQMAAAAAMQMAAFBvd2VyT25EdXJhdGlvbiBpcyB0aGUgZHVyYXRpb24gdGhl" +
           "IERldmljZSBoYXMgYmVlbiBwb3dlcmVkLiBUaGUgbWFpbiBwdXJwb3NlIGlzIHRvIGRldGVybWluZSB0" +
           "aGUgdGltZSBpbiB3aGljaCBkZWdyYWRhdGlvbiBvZiB0aGUgRGV2aWNlIG9jY3VycmVkLiBUaGUgZGV0" +
           "YWlscywgd2hlbiB0aGUgdGltZSBpcyBjb3VudGVkLCBpcyBpbXBsZW1lbnRhdGlvbi1zcGVjaWZpYy4g" +
           "Q29tcGFuaW9uIHNwZWNpZmljYXRpb25zIGNhbiBkZWZpbmUgc3BlY2lmaWMgcnVsZXMuIFR5cGljYWxs" +
           "eSwgd2hlbiB0aGUgRGV2aWNlIGhhcyBzdXBwbHkgdm9sdGFnZSBhbmQgdGhlIG1haW4gQ1BVIGlzIHJ1" +
           "bm5pbmcsIHRoZSB0aW1lIGlzIGNvdW50ZWQuIFRoaXMgY2FuIGluY2x1ZGUgYW55IGtpbmQgb2Ygc2xl" +
           "ZXAgbW9kZSwgYnV0IGNhbm5vdCBpbmNsdWRlIHB1cmUgV2FrZSBvbiBMQU4uIFRoaXMgdmFsdWUgc2hh" +
           "bGwgb25seSBpbmNyZWFzZSBkdXJpbmcgdGhlIGxpZmV0aW1lIG9mIHRoZSBEZXZpY2UgYW5kIHNoYWxs" +
           "IG5vdCBiZSByZXNldCB3aGVuIHRoZSBEZXZpY2UgaXMgcmVzdGFydGVkLiBUaGUgUG93ZXJPbkR1cmF0" +
           "aW9uIGlzIHByb3ZpZGVkIGFzIER1cmF0aW9uLCBpLmUuLCBpbiBtaWxsaXNlY29uZHMgb3IgZXZlbiBm" +
           "cmFjdGlvbnMgb2YgYSBtaWxsaXNlY29uZC4gSG93ZXZlciwgdGhlIFNlcnZlciBpcyBub3QgZXhwZWN0" +
           "ZWQgdG8gdXBkYXRlIHRoZSB2YWx1ZSBpbiBzdWNoIGEgaGlnaCBmcmVxdWVuY3ksIGJ1dCBwb3NzaWJs" +
           "eSBvbmNlIGEgbWludXRlIG9yIG9uY2UgYW4gaG91ciwgZGVwZW5kaW5nIG9uIHRoZSBhcHBsaWNhdGlv" +
           "bi4ALgBE4QEAAAEAIgH/////AQH/////AAAAAA==";

        private const string OperationDuration_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQARAAAAT3Bl" +
           "cmF0aW9uRHVyYXRpb24BAeIBAwAAAADWAgAAT3BlcmF0aW9uRHVyYXRpb24gaXMgdGhlIGR1cmF0aW9u" +
           "IHRoZSBEZXZpY2UgaGFzIGJlZW4gcG93ZXJlZCBhbmQgcGVyZm9ybWluZyBhbiBhY3Rpdml0eS4gVGhp" +
           "cyBjb3VudGVyIGlzIGludGVuZGVkIGZvciBEZXZpY2VzIHdoZXJlIGEgZGlzdGluY3Rpb24gaXMgbWFk" +
           "ZSBiZXR3ZWVuIHN3aXRjaGVkIG9uIGFuZCBpbiBvcGVyYXRpb24uIEZvciBleGFtcGxlLCBhIGRyaXZl" +
           "IGNhbiBiZSBwb3dlcmVkIG9uIGJ1dCBub3Qgb3BlcmF0aW5nLiBJdCBpcyBub3QgaW50ZW5kZWQgZm9y" +
           "IERldmljZXMgYWx3YXlzIHBlcmZvcm1pbmcgYW4gYWN0aXZpdHkgbGlrZSBzZW5zb3JzIGFsd2F5cyBt" +
           "ZWFzdXJpbmcgZGF0YS4gVGhpcyB2YWx1ZSBzaGFsbCBvbmx5IGluY3JlYXNlIGR1cmluZyB0aGUgbGlm" +
           "ZXRpbWUgb2YgdGhlIERldmljZSBhbmQgc2hhbGwgbm90IGJlIHJlc2V0IHdoZW4gdGhlIERldmljZSBp" +
           "cyByZXN0YXJ0ZWQuIFRoZSBPcGVyYXRpb25EdXJhdGlvbiBpcyBwcm92aWRlZCBhcyBEdXJhdGlvbiwg" +
           "aS5lLiwgaW4gbWlsbGlzZWNvbmRzIG9yIGV2ZW4gZnJhY3Rpb25zIG9mIGEgbWlsbGlzZWNvbmQuIEhv" +
           "d2V2ZXIsIHRoZSBTZXJ2ZXIgaXMgbm90IGV4cGVjdGVkIHRvIHVwZGF0ZSB0aGUgdmFsdWUgaW4gc3Vj" +
           "aCBhIGhpZ2ggZnJlcXVlbmN5LCBidXQgcG9zc2libHkgb25jZSBhIG1pbnV0ZSBvciBvbmNlIGFuIGhv" +
           "dXIsIGRlcGVuZGluZyBvbiB0aGUgYXBwbGljYXRpb24uAC4AROIBAAABACIB/////wEB/////wAAAAA=";

        private const string OperationCycleCounter_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////zVgiQoCAAAAAQAVAAAAT3Bl" +
           "cmF0aW9uQ3ljbGVDb3VudGVyAQHjAQMAAAAAKgEAAE9wZXJhdGlvbkN5Y2xlQ291bnRlciBpcyBjb3Vu" +
           "dGluZyB0aGUgdGltZXMgdGhlIERldmljZSBzd2l0Y2hlcyBmcm9tIG5vdCBwZXJmb3JtaW5nIGFuIGFj" +
           "dGl2aXR5IHRvIHBlcmZvcm1pbmcgYW4gYWN0aXZpdHkuIEZvciBleGFtcGxlLCBlYWNoIHRpbWUgYSB2" +
           "YWx2ZSBzdGFydHMgbW92aW5nLCBpcyBjb3VudGVkLiBUaGlzIHZhbHVlIHNoYWxsIG9ubHkgaW5jcmVh" +
           "c2UgZHVyaW5nIHRoZSBsaWZldGltZSBvZiB0aGUgRGV2aWNlIGFuZCBzaGFsbCBub3QgYmUgcmVzZXQg" +
           "d2hlbiB0aGUgRGV2aWNlIGlzIHJlc3RhcnRlZC4ALgBE4wEAAAAc/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAdAAAASU9w" +
           "ZXJhdGlvbkNvdW50ZXJUeXBlSW5zdGFuY2UBAeABAQHgAeABAAD/////AwAAADVgiQoCAAAAAQAPAAAA" +
           "UG93ZXJPbkR1cmF0aW9uAQHhAQMAAAAAMQMAAFBvd2VyT25EdXJhdGlvbiBpcyB0aGUgZHVyYXRpb24g" +
           "dGhlIERldmljZSBoYXMgYmVlbiBwb3dlcmVkLiBUaGUgbWFpbiBwdXJwb3NlIGlzIHRvIGRldGVybWlu" +
           "ZSB0aGUgdGltZSBpbiB3aGljaCBkZWdyYWRhdGlvbiBvZiB0aGUgRGV2aWNlIG9jY3VycmVkLiBUaGUg" +
           "ZGV0YWlscywgd2hlbiB0aGUgdGltZSBpcyBjb3VudGVkLCBpcyBpbXBsZW1lbnRhdGlvbi1zcGVjaWZp" +
           "Yy4gQ29tcGFuaW9uIHNwZWNpZmljYXRpb25zIGNhbiBkZWZpbmUgc3BlY2lmaWMgcnVsZXMuIFR5cGlj" +
           "YWxseSwgd2hlbiB0aGUgRGV2aWNlIGhhcyBzdXBwbHkgdm9sdGFnZSBhbmQgdGhlIG1haW4gQ1BVIGlz" +
           "IHJ1bm5pbmcsIHRoZSB0aW1lIGlzIGNvdW50ZWQuIFRoaXMgY2FuIGluY2x1ZGUgYW55IGtpbmQgb2Yg" +
           "c2xlZXAgbW9kZSwgYnV0IGNhbm5vdCBpbmNsdWRlIHB1cmUgV2FrZSBvbiBMQU4uIFRoaXMgdmFsdWUg" +
           "c2hhbGwgb25seSBpbmNyZWFzZSBkdXJpbmcgdGhlIGxpZmV0aW1lIG9mIHRoZSBEZXZpY2UgYW5kIHNo" +
           "YWxsIG5vdCBiZSByZXNldCB3aGVuIHRoZSBEZXZpY2UgaXMgcmVzdGFydGVkLiBUaGUgUG93ZXJPbkR1" +
           "cmF0aW9uIGlzIHByb3ZpZGVkIGFzIER1cmF0aW9uLCBpLmUuLCBpbiBtaWxsaXNlY29uZHMgb3IgZXZl" +
           "biBmcmFjdGlvbnMgb2YgYSBtaWxsaXNlY29uZC4gSG93ZXZlciwgdGhlIFNlcnZlciBpcyBub3QgZXhw" +
           "ZWN0ZWQgdG8gdXBkYXRlIHRoZSB2YWx1ZSBpbiBzdWNoIGEgaGlnaCBmcmVxdWVuY3ksIGJ1dCBwb3Nz" +
           "aWJseSBvbmNlIGEgbWludXRlIG9yIG9uY2UgYW4gaG91ciwgZGVwZW5kaW5nIG9uIHRoZSBhcHBsaWNh" +
           "dGlvbi4ALgBE4QEAAAEAIgH/////AQH/////AAAAADVgiQoCAAAAAQARAAAAT3BlcmF0aW9uRHVyYXRp" +
           "b24BAeIBAwAAAADWAgAAT3BlcmF0aW9uRHVyYXRpb24gaXMgdGhlIGR1cmF0aW9uIHRoZSBEZXZpY2Ug" +
           "aGFzIGJlZW4gcG93ZXJlZCBhbmQgcGVyZm9ybWluZyBhbiBhY3Rpdml0eS4gVGhpcyBjb3VudGVyIGlz" +
           "IGludGVuZGVkIGZvciBEZXZpY2VzIHdoZXJlIGEgZGlzdGluY3Rpb24gaXMgbWFkZSBiZXR3ZWVuIHN3" +
           "aXRjaGVkIG9uIGFuZCBpbiBvcGVyYXRpb24uIEZvciBleGFtcGxlLCBhIGRyaXZlIGNhbiBiZSBwb3dl" +
           "cmVkIG9uIGJ1dCBub3Qgb3BlcmF0aW5nLiBJdCBpcyBub3QgaW50ZW5kZWQgZm9yIERldmljZXMgYWx3" +
           "YXlzIHBlcmZvcm1pbmcgYW4gYWN0aXZpdHkgbGlrZSBzZW5zb3JzIGFsd2F5cyBtZWFzdXJpbmcgZGF0" +
           "YS4gVGhpcyB2YWx1ZSBzaGFsbCBvbmx5IGluY3JlYXNlIGR1cmluZyB0aGUgbGlmZXRpbWUgb2YgdGhl" +
           "IERldmljZSBhbmQgc2hhbGwgbm90IGJlIHJlc2V0IHdoZW4gdGhlIERldmljZSBpcyByZXN0YXJ0ZWQu" +
           "IFRoZSBPcGVyYXRpb25EdXJhdGlvbiBpcyBwcm92aWRlZCBhcyBEdXJhdGlvbiwgaS5lLiwgaW4gbWls" +
           "bGlzZWNvbmRzIG9yIGV2ZW4gZnJhY3Rpb25zIG9mIGEgbWlsbGlzZWNvbmQuIEhvd2V2ZXIsIHRoZSBT" +
           "ZXJ2ZXIgaXMgbm90IGV4cGVjdGVkIHRvIHVwZGF0ZSB0aGUgdmFsdWUgaW4gc3VjaCBhIGhpZ2ggZnJl" +
           "cXVlbmN5LCBidXQgcG9zc2libHkgb25jZSBhIG1pbnV0ZSBvciBvbmNlIGFuIGhvdXIsIGRlcGVuZGlu" +
           "ZyBvbiB0aGUgYXBwbGljYXRpb24uAC4AROIBAAABACIB/////wEB/////wAAAAA1YIkKAgAAAAEAFQAA" +
           "AE9wZXJhdGlvbkN5Y2xlQ291bnRlcgEB4wEDAAAAACoBAABPcGVyYXRpb25DeWNsZUNvdW50ZXIgaXMg" +
           "Y291bnRpbmcgdGhlIHRpbWVzIHRoZSBEZXZpY2Ugc3dpdGNoZXMgZnJvbSBub3QgcGVyZm9ybWluZyBh" +
           "biBhY3Rpdml0eSB0byBwZXJmb3JtaW5nIGFuIGFjdGl2aXR5LiBGb3IgZXhhbXBsZSwgZWFjaCB0aW1l" +
           "IGEgdmFsdmUgc3RhcnRzIG1vdmluZywgaXMgY291bnRlZC4gVGhpcyB2YWx1ZSBzaGFsbCBvbmx5IGlu" +
           "Y3JlYXNlIGR1cmluZyB0aGUgbGlmZXRpbWUgb2YgdGhlIERldmljZSBhbmQgc2hhbGwgbm90IGJlIHJl" +
           "c2V0IHdoZW4gdGhlIERldmljZSBpcyByZXN0YXJ0ZWQuAC4AROMBAAAAHP////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public PropertyState<double> PowerOnDuration
        {
            get => m_powerOnDuration;

            set
            {
                if (!Object.ReferenceEquals(m_powerOnDuration, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_powerOnDuration = value;
            }
        }

        public PropertyState<double> OperationDuration
        {
            get => m_operationDuration;

            set
            {
                if (!Object.ReferenceEquals(m_operationDuration, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operationDuration = value;
            }
        }

        public PropertyState OperationCycleCounter
        {
            get => m_operationCycleCounter;

            set
            {
                if (!Object.ReferenceEquals(m_operationCycleCounter, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_operationCycleCounter = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_powerOnDuration != null)
            {
                children.Add(m_powerOnDuration);
            }

            if (m_operationDuration != null)
            {
                children.Add(m_operationDuration);
            }

            if (m_operationCycleCounter != null)
            {
                children.Add(m_operationCycleCounter);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_powerOnDuration, child))
            {
                m_powerOnDuration = null;
                return;
            }

            if (Object.ReferenceEquals(m_operationDuration, child))
            {
                m_operationDuration = null;
                return;
            }

            if (Object.ReferenceEquals(m_operationCycleCounter, child))
            {
                m_operationCycleCounter = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.PowerOnDuration:
                {
                    if (createOrReplace)
                    {
                        if (PowerOnDuration == null)
                        {
                            if (replacement == null)
                            {
                                PowerOnDuration = new PropertyState<double>(this);
                            }
                            else
                            {
                                PowerOnDuration = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = PowerOnDuration;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.OperationDuration:
                {
                    if (createOrReplace)
                    {
                        if (OperationDuration == null)
                        {
                            if (replacement == null)
                            {
                                OperationDuration = new PropertyState<double>(this);
                            }
                            else
                            {
                                OperationDuration = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = OperationDuration;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.OperationCycleCounter:
                {
                    if (createOrReplace)
                    {
                        if (OperationCycleCounter == null)
                        {
                            if (replacement == null)
                            {
                                OperationCycleCounter = new PropertyState(this);
                            }
                            else
                            {
                                OperationCycleCounter = (PropertyState)replacement;
                            }
                        }
                    }

                    instance = OperationCycleCounter;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<double> m_powerOnDuration;
        private PropertyState<double> m_operationDuration;
        private PropertyState m_operationCycleCounter;
        #endregion
    }
    #endif
    #endregion

    #region UIElementTypeState Class
    #if (!OPCUA_EXCLUDE_UIElementTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class UIElementTypeState : BaseDataVariableState
    {
        #region Constructors
        public UIElementTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.VariableTypes.UIElementType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        protected override NodeId GetDefaultDataTypeId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DataTypes.BaseDataType, Opc.Ua.Namespaces.OpcUa, namespaceUris);
        }

        protected override int GetDefaultValueRank()
        {
            return ValueRanks.Scalar;
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQICAAAAAQAVAAAAVUlF" +
           "bGVtZW50VHlwZUluc3RhbmNlAQFmGAEBZhhmGAAAABj/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }

    #region UIElementTypeState<T> Class
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class UIElementTypeState<T> : UIElementTypeState
    {
        #region Constructors
        public UIElementTypeState(NodeState parent) : base(parent)
        {
            Value = default(T);
        }

        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);

            Value = default(T);
            DataType = TypeInfo.GetDataTypeId(typeof(T));
            ValueRank = TypeInfo.GetValueRank(typeof(T));
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }
        #endregion

        #region Public Members
        public new T Value
        {
            get
            {
                return CheckTypeBeforeCast<T>(((BaseVariableState)this).Value, true);
            }

            set
            {
                ((BaseVariableState)this).Value = value;
            }
        }
        #endregion
    }
    #endregion
    #endif
    #endregion

    #region NetworkTypeState Class
    #if (!OPCUA_EXCLUDE_NetworkTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class NetworkTypeState : BaseObjectState
    {
        #region Constructors
        public NetworkTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.NetworkType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Lock != null)
            {
                Lock.Initialize(context, Lock_InitializationString);
            }
        }

        #region Initialization String
        private const string Lock_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAEAAAATG9j" +
           "awEBlhgALwEB9BiWGAAA/////wgAAAAVYIkKAgAAAAEABgAAAExvY2tlZAEBYRkALgBEYRkAAAAB////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEADQAAAExvY2tpbmdDbGllbnQBAZgYAC4ARJgYAAAADP////8BAf//" +
           "//8AAAAAFWCJCgIAAAABAAsAAABMb2NraW5nVXNlcgEBmRgALgBEmRgAAAAM/////wEB/////wAAAAAV" +
           "YIkKAgAAAAEAEQAAAFJlbWFpbmluZ0xvY2tUaW1lAQGaGAAuAESaGAAAAQAiAf////8BAf////8AAAAA" +
           "BGGCCgQAAAABAAgAAABJbml0TG9jawEBmxgALwEB+RibGAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAA" +
           "SW5wdXRBcmd1bWVudHMBAZwYAC4ARJwYAACWAQAAAAEAKgEBFgAAAAcAAABDb250ZXh0AAz/////AAAA" +
           "AAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGd" +
           "GAAuAESdGAAAlgEAAAABACoBAR0AAAAOAAAASW5pdExvY2tTdGF0dXMABv////8AAAAAAAEAKAEBAAAA" +
           "AQAAAAEAAAABAf////8AAAAABGGCCgQAAAABAAkAAABSZW5ld0xvY2sBAZ4YAC8BAfwYnhgAAAEB////" +
           "/wEAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBnxgALgBEnxgAAJYBAAAAAQAqAQEeAAAA" +
           "DwAAAFJlbmV3TG9ja1N0YXR1cwAG/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIK" +
           "BAAAAAEACAAAAEV4aXRMb2NrAQGgGAAvAQH+GKAYAAABAf////8BAAAAF2CpCgIAAAAAAA8AAABPdXRw" +
           "dXRBcmd1bWVudHMBAaEYAC4ARKEYAACWAQAAAAEAKgEBHQAAAA4AAABFeGl0TG9ja1N0YXR1cwAG////" +
           "/wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIKBAAAAAEACQAAAEJyZWFrTG9jawEBohgA" +
           "LwEBABmiGAAAAQH/////AQAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGjGAAuAESjGAAA" +
           "lgEAAAABACoBAR4AAAAPAAAAQnJlYWtMb2NrU3RhdHVzAAb/////AAAAAAABACgBAQAAAAEAAAABAAAA" +
           "AQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQATAAAATmV0" +
           "d29ya1R5cGVJbnN0YW5jZQEBZxgBAWcYZxgAAP////8CAAAABGDACgEAAAAdAAAAUHJvZmlsZUlkZW50" +
           "aWZpZXJfUGxhY2Vob2xkZXIBABMAAAA8UHJvZmlsZUlkZW50aWZpZXI+AQHEGQAvAQHuA8QZAAD/////" +
           "AAAAAARggAoBAAAAAQAEAAAATG9jawEBlhgALwEB9BiWGAAA/////wgAAAAVYIkKAgAAAAEABgAAAExv" +
           "Y2tlZAEBYRkALgBEYRkAAAAB/////wEB/////wAAAAAVYIkKAgAAAAEADQAAAExvY2tpbmdDbGllbnQB" +
           "AZgYAC4ARJgYAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABMb2NraW5nVXNlcgEBmRgALgBE" +
           "mRgAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEAEQAAAFJlbWFpbmluZ0xvY2tUaW1lAQGaGAAuAESa" +
           "GAAAAQAiAf////8BAf////8AAAAABGGCCgQAAAABAAgAAABJbml0TG9jawEBmxgALwEB+RibGAAAAQH/" +
           "////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAZwYAC4ARJwYAACWAQAAAAEAKgEBFgAA" +
           "AAcAAABDb250ZXh0AAz/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABdgqQoCAAAAAAAP" +
           "AAAAT3V0cHV0QXJndW1lbnRzAQGdGAAuAESdGAAAlgEAAAABACoBAR0AAAAOAAAASW5pdExvY2tTdGF0" +
           "dXMABv////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAABGGCCgQAAAABAAkAAABSZW5ld0xv" +
           "Y2sBAZ4YAC8BAfwYnhgAAAEB/////wEAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBnxgA" +
           "LgBEnxgAAJYBAAAAAQAqAQEeAAAADwAAAFJlbmV3TG9ja1N0YXR1cwAG/////wAAAAAAAQAoAQEAAAAB" +
           "AAAAAQAAAAEB/////wAAAAAEYYIKBAAAAAEACAAAAEV4aXRMb2NrAQGgGAAvAQH+GKAYAAABAf////8B" +
           "AAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAaEYAC4ARKEYAACWAQAAAAEAKgEBHQAAAA4A" +
           "AABFeGl0TG9ja1N0YXR1cwAG/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIKBAAA" +
           "AAEACQAAAEJyZWFrTG9jawEBohgALwEBABmiGAAAAQH/////AQAAABdgqQoCAAAAAAAPAAAAT3V0cHV0" +
           "QXJndW1lbnRzAQGjGAAuAESjGAAAlgEAAAABACoBAR4AAAAPAAAAQnJlYWtMb2NrU3RhdHVzAAb/////" +
           "AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public LockingServicesTypeState Lock
        {
            get => m_lock;

            set
            {
                if (!Object.ReferenceEquals(m_lock, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lock = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_lock != null)
            {
                children.Add(m_lock);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_lock, child))
            {
                m_lock = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.Lock:
                {
                    if (createOrReplace)
                    {
                        if (Lock == null)
                        {
                            if (replacement == null)
                            {
                                Lock = new LockingServicesTypeState(this);
                            }
                            else
                            {
                                Lock = (LockingServicesTypeState)replacement;
                            }
                        }
                    }

                    instance = Lock;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private LockingServicesTypeState m_lock;
        #endregion
    }
    #endif
    #endregion

    #region ConnectionPointTypeState Class
    #if (!OPCUA_EXCLUDE_ConnectionPointTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class ConnectionPointTypeState : TopologyElementTypeState
    {
        #region Constructors
        public ConnectionPointTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.ConnectionPointType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAbAAAAQ29u" +
           "bmVjdGlvblBvaW50VHlwZUluc3RhbmNlAQGkGAEBpBikGAAA/////wIAAAAEYIAKAQAAAAEADgAAAE5l" +
           "dHdvcmtBZGRyZXNzAQHSGAAvAQHtA9IYAAD/////AAAAAARgwAoBAAAAHQAAAFByb2ZpbGVJZGVudGlm" +
           "aWVyX1BsYWNlaG9sZGVyAQATAAAAPFByb2ZpbGVJZGVudGlmaWVyPgEBYxkALwEB7gNjGQAA/////wAA" +
           "AAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public FunctionalGroupTypeState NetworkAddress
        {
            get => m_networkAddress;

            set
            {
                if (!Object.ReferenceEquals(m_networkAddress, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_networkAddress = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_networkAddress != null)
            {
                children.Add(m_networkAddress);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_networkAddress, child))
            {
                m_networkAddress = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.NetworkAddress:
                {
                    if (createOrReplace)
                    {
                        if (NetworkAddress == null)
                        {
                            if (replacement == null)
                            {
                                NetworkAddress = new FunctionalGroupTypeState(this);
                            }
                            else
                            {
                                NetworkAddress = (FunctionalGroupTypeState)replacement;
                            }
                        }
                    }

                    instance = NetworkAddress;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private FunctionalGroupTypeState m_networkAddress;
        #endregion
    }
    #endif
    #endregion

    #region TransferServicesTypeState Class
    #if (!OPCUA_EXCLUDE_TransferServicesTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class TransferServicesTypeState : BaseObjectState
    {
        #region Constructors
        public TransferServicesTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.TransferServicesType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAcAAAAVHJh" +
           "bnNmZXJTZXJ2aWNlc1R5cGVJbnN0YW5jZQEBfhkBAX4ZfhkAAP////8DAAAABGGCCgQAAAABABAAAABU" +
           "cmFuc2ZlclRvRGV2aWNlAQF/GQAvAQF/GX8ZAAABAf////8BAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRB" +
           "cmd1bWVudHMBAYAZAC4ARIAZAACWAgAAAAEAKgEBGQAAAAoAAABUcmFuc2ZlcklEAAb/////AAAAAAAB" +
           "ACoBASEAAAASAAAASW5pdFRyYW5zZmVyU3RhdHVzAAb/////AAAAAAABACgBAQAAAAEAAAACAAAAAQH/" +
           "////AAAAAARhggoEAAAAAQASAAAAVHJhbnNmZXJGcm9tRGV2aWNlAQGBGQAvAQGBGYEZAAABAf////8B" +
           "AAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAYIZAC4ARIIZAACWAgAAAAEAKgEBGQAAAAoA" +
           "AABUcmFuc2ZlcklEAAb/////AAAAAAABACoBASEAAAASAAAASW5pdFRyYW5zZmVyU3RhdHVzAAb/////" +
           "AAAAAAABACgBAQAAAAEAAAACAAAAAQH/////AAAAAARhggoEAAAAAQAXAAAARmV0Y2hUcmFuc2ZlclJl" +
           "c3VsdERhdGEBAYMZAC8BAYMZgxkAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRz" +
           "AQGEGQAuAESEGQAAlgQAAAABACoBARkAAAAKAAAAVHJhbnNmZXJJRAAG/////wAAAAAAAQAqAQEdAAAA" +
           "DgAAAFNlcXVlbmNlTnVtYmVyAAb/////AAAAAAABACoBASoAAAAbAAAATWF4UGFyYW1ldGVyUmVzdWx0" +
           "c1RvUmV0dXJuAAb/////AAAAAAABACoBAR4AAAAPAAAAT21pdEdvb2RSZXN1bHRzAAH/////AAAAAAAB" +
           "ACgBAQAAAAEAAAAEAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGFGQAu" +
           "AESFGQAAlgEAAAABACoBAR4AAAAPAAAARmV0Y2hSZXN1bHREYXRhABb/////AAAAAAABACgBAQAAAAEA" +
           "AAABAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public TransferToDeviceMethodState TransferToDevice
        {
            get => m_transferToDeviceMethod;

            set
            {
                if (!Object.ReferenceEquals(m_transferToDeviceMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_transferToDeviceMethod = value;
            }
        }

        public TransferFromDeviceMethodState TransferFromDevice
        {
            get => m_transferFromDeviceMethod;

            set
            {
                if (!Object.ReferenceEquals(m_transferFromDeviceMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_transferFromDeviceMethod = value;
            }
        }

        public FetchTransferResultDataMethodState FetchTransferResultData
        {
            get => m_fetchTransferResultDataMethod;

            set
            {
                if (!Object.ReferenceEquals(m_fetchTransferResultDataMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_fetchTransferResultDataMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_transferToDeviceMethod != null)
            {
                children.Add(m_transferToDeviceMethod);
            }

            if (m_transferFromDeviceMethod != null)
            {
                children.Add(m_transferFromDeviceMethod);
            }

            if (m_fetchTransferResultDataMethod != null)
            {
                children.Add(m_fetchTransferResultDataMethod);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_transferToDeviceMethod, child))
            {
                m_transferToDeviceMethod = null;
                return;
            }

            if (Object.ReferenceEquals(m_transferFromDeviceMethod, child))
            {
                m_transferFromDeviceMethod = null;
                return;
            }

            if (Object.ReferenceEquals(m_fetchTransferResultDataMethod, child))
            {
                m_fetchTransferResultDataMethod = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.TransferToDevice:
                {
                    if (createOrReplace)
                    {
                        if (TransferToDevice == null)
                        {
                            if (replacement == null)
                            {
                                TransferToDevice = new TransferToDeviceMethodState(this);
                            }
                            else
                            {
                                TransferToDevice = (TransferToDeviceMethodState)replacement;
                            }
                        }
                    }

                    instance = TransferToDevice;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.TransferFromDevice:
                {
                    if (createOrReplace)
                    {
                        if (TransferFromDevice == null)
                        {
                            if (replacement == null)
                            {
                                TransferFromDevice = new TransferFromDeviceMethodState(this);
                            }
                            else
                            {
                                TransferFromDevice = (TransferFromDeviceMethodState)replacement;
                            }
                        }
                    }

                    instance = TransferFromDevice;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.FetchTransferResultData:
                {
                    if (createOrReplace)
                    {
                        if (FetchTransferResultData == null)
                        {
                            if (replacement == null)
                            {
                                FetchTransferResultData = new FetchTransferResultDataMethodState(this);
                            }
                            else
                            {
                                FetchTransferResultData = (FetchTransferResultDataMethodState)replacement;
                            }
                        }
                    }

                    instance = FetchTransferResultData;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private TransferToDeviceMethodState m_transferToDeviceMethod;
        private TransferFromDeviceMethodState m_transferFromDeviceMethod;
        private FetchTransferResultDataMethodState m_fetchTransferResultDataMethod;
        #endregion
    }
    #endif
    #endregion

    #region LockingServicesTypeState Class
    #if (!OPCUA_EXCLUDE_LockingServicesTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class LockingServicesTypeState : BaseObjectState
    {
        #region Constructors
        public LockingServicesTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.LockingServicesType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAbAAAATG9j" +
           "a2luZ1NlcnZpY2VzVHlwZUluc3RhbmNlAQH0GAEB9Bj0GAAA/////wkAAAAVYKkKAgAAAAAAGQAAAERl" +
           "ZmF1bHRJbnN0YW5jZUJyb3dzZU5hbWUBARI+AC4ARBI+AAAUAQAEAAAATG9jawAU/////wEB/////wAA" +
           "AAAVYIkKAgAAAAEABgAAAExvY2tlZAEBhhkALgBEhhkAAAAB/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "DQAAAExvY2tpbmdDbGllbnQBAfYYAC4ARPYYAAAADP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABM" +
           "b2NraW5nVXNlcgEB9xgALgBE9xgAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEAEQAAAFJlbWFpbmlu" +
           "Z0xvY2tUaW1lAQH4GAAuAET4GAAAAQAiAf////8BAf////8AAAAABGGCCgQAAAABAAgAAABJbml0TG9j" +
           "awEB+RgALwEB+Rj5GAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAfoYAC4A" +
           "RPoYAACWAQAAAAEAKgEBFgAAAAcAAABDb250ZXh0AAz/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/" +
           "////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQH7GAAuAET7GAAAlgEAAAABACoBAR0A" +
           "AAAOAAAASW5pdExvY2tTdGF0dXMABv////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAABGGC" +
           "CgQAAAABAAkAAABSZW5ld0xvY2sBAfwYAC8BAfwY/BgAAAEB/////wEAAAAXYKkKAgAAAAAADwAAAE91" +
           "dHB1dEFyZ3VtZW50cwEB/RgALgBE/RgAAJYBAAAAAQAqAQEeAAAADwAAAFJlbmV3TG9ja1N0YXR1cwAG" +
           "/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAEYYIKBAAAAAEACAAAAEV4aXRMb2NrAQH+" +
           "GAAvAQH+GP4YAAABAf////8BAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAf8YAC4ARP8Y" +
           "AACWAQAAAAEAKgEBHQAAAA4AAABFeGl0TG9ja1N0YXR1cwAG/////wAAAAAAAQAoAQEAAAABAAAAAQAA" +
           "AAEB/////wAAAAAEYYIKBAAAAAEACQAAAEJyZWFrTG9jawEBABkALwEBABkAGQAAAQH/////AQAAABdg" +
           "qQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQEBGQAuAEQBGQAAlgEAAAABACoBAR4AAAAPAAAAQnJl" +
           "YWtMb2NrU3RhdHVzAAb/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public PropertyState<bool> Locked
        {
            get => m_locked;

            set
            {
                if (!Object.ReferenceEquals(m_locked, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_locked = value;
            }
        }

        public PropertyState<string> LockingClient
        {
            get => m_lockingClient;

            set
            {
                if (!Object.ReferenceEquals(m_lockingClient, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lockingClient = value;
            }
        }

        public PropertyState<string> LockingUser
        {
            get => m_lockingUser;

            set
            {
                if (!Object.ReferenceEquals(m_lockingUser, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_lockingUser = value;
            }
        }

        public PropertyState<double> RemainingLockTime
        {
            get => m_remainingLockTime;

            set
            {
                if (!Object.ReferenceEquals(m_remainingLockTime, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_remainingLockTime = value;
            }
        }

        public InitLockMethodState InitLock
        {
            get => m_initLockMethod;

            set
            {
                if (!Object.ReferenceEquals(m_initLockMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_initLockMethod = value;
            }
        }

        public RenewLockMethodState RenewLock
        {
            get => m_renewLockMethod;

            set
            {
                if (!Object.ReferenceEquals(m_renewLockMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_renewLockMethod = value;
            }
        }

        public ExitLockMethodState ExitLock
        {
            get => m_exitLockMethod;

            set
            {
                if (!Object.ReferenceEquals(m_exitLockMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_exitLockMethod = value;
            }
        }

        public BreakLockMethodState BreakLock
        {
            get => m_breakLockMethod;

            set
            {
                if (!Object.ReferenceEquals(m_breakLockMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_breakLockMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_locked != null)
            {
                children.Add(m_locked);
            }

            if (m_lockingClient != null)
            {
                children.Add(m_lockingClient);
            }

            if (m_lockingUser != null)
            {
                children.Add(m_lockingUser);
            }

            if (m_remainingLockTime != null)
            {
                children.Add(m_remainingLockTime);
            }

            if (m_initLockMethod != null)
            {
                children.Add(m_initLockMethod);
            }

            if (m_renewLockMethod != null)
            {
                children.Add(m_renewLockMethod);
            }

            if (m_exitLockMethod != null)
            {
                children.Add(m_exitLockMethod);
            }

            if (m_breakLockMethod != null)
            {
                children.Add(m_breakLockMethod);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_locked, child))
            {
                m_locked = null;
                return;
            }

            if (Object.ReferenceEquals(m_lockingClient, child))
            {
                m_lockingClient = null;
                return;
            }

            if (Object.ReferenceEquals(m_lockingUser, child))
            {
                m_lockingUser = null;
                return;
            }

            if (Object.ReferenceEquals(m_remainingLockTime, child))
            {
                m_remainingLockTime = null;
                return;
            }

            if (Object.ReferenceEquals(m_initLockMethod, child))
            {
                m_initLockMethod = null;
                return;
            }

            if (Object.ReferenceEquals(m_renewLockMethod, child))
            {
                m_renewLockMethod = null;
                return;
            }

            if (Object.ReferenceEquals(m_exitLockMethod, child))
            {
                m_exitLockMethod = null;
                return;
            }

            if (Object.ReferenceEquals(m_breakLockMethod, child))
            {
                m_breakLockMethod = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.Locked:
                {
                    if (createOrReplace)
                    {
                        if (Locked == null)
                        {
                            if (replacement == null)
                            {
                                Locked = new PropertyState<bool>(this);
                            }
                            else
                            {
                                Locked = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = Locked;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.LockingClient:
                {
                    if (createOrReplace)
                    {
                        if (LockingClient == null)
                        {
                            if (replacement == null)
                            {
                                LockingClient = new PropertyState<string>(this);
                            }
                            else
                            {
                                LockingClient = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = LockingClient;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.LockingUser:
                {
                    if (createOrReplace)
                    {
                        if (LockingUser == null)
                        {
                            if (replacement == null)
                            {
                                LockingUser = new PropertyState<string>(this);
                            }
                            else
                            {
                                LockingUser = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = LockingUser;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.RemainingLockTime:
                {
                    if (createOrReplace)
                    {
                        if (RemainingLockTime == null)
                        {
                            if (replacement == null)
                            {
                                RemainingLockTime = new PropertyState<double>(this);
                            }
                            else
                            {
                                RemainingLockTime = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = RemainingLockTime;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.InitLock:
                {
                    if (createOrReplace)
                    {
                        if (InitLock == null)
                        {
                            if (replacement == null)
                            {
                                InitLock = new InitLockMethodState(this);
                            }
                            else
                            {
                                InitLock = (InitLockMethodState)replacement;
                            }
                        }
                    }

                    instance = InitLock;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.RenewLock:
                {
                    if (createOrReplace)
                    {
                        if (RenewLock == null)
                        {
                            if (replacement == null)
                            {
                                RenewLock = new RenewLockMethodState(this);
                            }
                            else
                            {
                                RenewLock = (RenewLockMethodState)replacement;
                            }
                        }
                    }

                    instance = RenewLock;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.ExitLock:
                {
                    if (createOrReplace)
                    {
                        if (ExitLock == null)
                        {
                            if (replacement == null)
                            {
                                ExitLock = new ExitLockMethodState(this);
                            }
                            else
                            {
                                ExitLock = (ExitLockMethodState)replacement;
                            }
                        }
                    }

                    instance = ExitLock;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.BreakLock:
                {
                    if (createOrReplace)
                    {
                        if (BreakLock == null)
                        {
                            if (replacement == null)
                            {
                                BreakLock = new BreakLockMethodState(this);
                            }
                            else
                            {
                                BreakLock = (BreakLockMethodState)replacement;
                            }
                        }
                    }

                    instance = BreakLock;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<bool> m_locked;
        private PropertyState<string> m_lockingClient;
        private PropertyState<string> m_lockingUser;
        private PropertyState<double> m_remainingLockTime;
        private InitLockMethodState m_initLockMethod;
        private RenewLockMethodState m_renewLockMethod;
        private ExitLockMethodState m_exitLockMethod;
        private BreakLockMethodState m_breakLockMethod;
        #endregion
    }
    #endif
    #endregion

    #region SoftwareUpdateTypeState Class
    #if (!OPCUA_EXCLUDE_SoftwareUpdateTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class SoftwareUpdateTypeState : BaseObjectState
    {
        #region Constructors
        public SoftwareUpdateTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.SoftwareUpdateType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (Loading != null)
            {
                Loading.Initialize(context, Loading_InitializationString);
            }

            if (PrepareForUpdate != null)
            {
                PrepareForUpdate.Initialize(context, PrepareForUpdate_InitializationString);
            }

            if (Installation != null)
            {
                Installation.Initialize(context, Installation_InitializationString);
            }

            if (PowerCycle != null)
            {
                PowerCycle.Initialize(context, PowerCycle_InitializationString);
            }

            if (Confirmation != null)
            {
                Confirmation.Initialize(context, Confirmation_InitializationString);
            }

            if (Parameters != null)
            {
                Parameters.Initialize(context, Parameters_InitializationString);
            }

            if (UpdateStatus != null)
            {
                UpdateStatus.Initialize(context, UpdateStatus_InitializationString);
            }

            if (SoftwareClass != null)
            {
                SoftwareClass.Initialize(context, SoftwareClass_InitializationString);
            }

            if (SoftwareSubclass != null)
            {
                SoftwareSubclass.Initialize(context, SoftwareSubclass_InitializationString);
            }

            if (SoftwareName != null)
            {
                SoftwareName.Initialize(context, SoftwareName_InitializationString);
            }

            if (UnsignedPackageAllowed != null)
            {
                UnsignedPackageAllowed.Initialize(context, UnsignedPackageAllowed_InitializationString);
            }

            if (VendorErrorCode != null)
            {
                VendorErrorCode.Initialize(context, VendorErrorCode_InitializationString);
            }
        }

        #region Initialization String
        private const string Loading_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAHAAAATG9h" +
           "ZGluZwEBAgAALwEBhwACAAAA/////wAAAAA=";

        private const string PrepareForUpdate_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAQAAAAUHJl" +
           "cGFyZUZvclVwZGF0ZQEBBAAALwEB1QAEAAAA/////wMAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0" +
           "ZQEBBQAALwEAyAoFAAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAQYAAC4ARAYAAAAA" +
           "Ef////8BAf////8AAAAABGGCCgQAAAABAAcAAABQcmVwYXJlAQETAAAvAQHkABMAAAABAf////8AAAAA" +
           "BGGCCgQAAAABAAUAAABBYm9ydAEBFAAALwEB5QAUAAAAAQH/////AAAAAA==";

        private const string Installation_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAMAAAASW5z" +
           "dGFsbGF0aW9uAQEoAAAvAQH5ACgAAAD/////AgAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQEp" +
           "AAAvAQDICikAAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBKgAALgBEKgAAAAAR////" +
           "/wEB/////wAAAAAEYYIKBAAAAAEABgAAAFJlc3VtZQEBPQAALwEBDgE9AAAAAQH/////AAAAAA==";

        private const string PowerCycle_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAKAAAAUG93" +
           "ZXJDeWNsZQEBTAAALwEBHQFMAAAA/////wEAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBTQAA" +
           "LwEAyApNAAAAABX/////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAU4AAC4ARE4AAAAAEf////8B" +
           "Af////8AAAAA";

        private const string Confirmation_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAMAAAAQ29u" +
           "ZmlybWF0aW9uAQFiAAAvAQEzAWIAAAD/////AwAAABVgiQoCAAAAAAAMAAAAQ3VycmVudFN0YXRlAQFj" +
           "AAAvAQDICmMAAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBZAAALgBEZAAAAAAR////" +
           "/wEB/////wAAAAAEYYIKBAAAAAEABwAAAENvbmZpcm0BAXAAAC8BAUEBcAAAAAEB/////wAAAAAVYIkK" +
           "AgAAAAEAEwAAAENvbmZpcm1hdGlvblRpbWVvdXQBAXEAAC8AP3EAAAABACIB/////wEB/////wAAAAA=";

        private const string Parameters_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAKAAAAUGFy" +
           "YW1ldGVycwEBegAALwEAgD16AAAA/////wQAAAAVYIkKAgAAAAAAFwAAAENsaWVudFByb2Nlc3NpbmdU" +
           "aW1lb3V0AQF7AAAuAER7AAAAAQAiAf////8BAf////8AAAAABGGCCgQAAAAAABMAAABHZW5lcmF0ZUZp" +
           "bGVGb3JSZWFkAQF8AAAvAQCCPXwAAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50" +
           "cwEBfQAALgBEfQAAAJYBAAAAAQAqAQEeAAAADwAAAEdlbmVyYXRlT3B0aW9ucwAY/////wAAAAAAAQAo" +
           "AQEAAAABAAAAAQAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBfgAALgBE" +
           "fgAAAJYDAAAAAQAqAQEZAAAACgAAAEZpbGVOb2RlSWQAEf////8AAAAAAAEAKgEBGQAAAAoAAABGaWxl" +
           "SGFuZGxlAAf/////AAAAAAABACoBASUAAAAWAAAAQ29tcGxldGlvblN0YXRlTWFjaGluZQAR/////wAA" +
           "AAAAAQAoAQEAAAABAAAAAwAAAAEB/////wAAAAAEYYIKBAAAAAAAFAAAAEdlbmVyYXRlRmlsZUZvcldy" +
           "aXRlAQF/AAAvAQCFPX8AAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBgAAA" +
           "LgBEgAAAAJYBAAAAAQAqAQEeAAAADwAAAEdlbmVyYXRlT3B0aW9ucwAY/////wAAAAAAAQAoAQEAAAAB" +
           "AAAAAQAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBgQAALgBEgQAAAJYC" +
           "AAAAAQAqAQEZAAAACgAAAEZpbGVOb2RlSWQAEf////8AAAAAAAEAKgEBGQAAAAoAAABGaWxlSGFuZGxl" +
           "AAf/////AAAAAAABACgBAQAAAAEAAAACAAAAAQH/////AAAAAARhggoEAAAAAAAOAAAAQ2xvc2VBbmRD" +
           "b21taXQBAYIAAC8BAIc9ggAAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGD" +
           "AAAuAESDAAAAlgEAAAABACoBARkAAAAKAAAARmlsZUhhbmRsZQAH/////wAAAAAAAQAoAQEAAAABAAAA" +
           "AQAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBhAAALgBEhAAAAJYBAAAA" +
           "AQAqAQElAAAAFgAAAENvbXBsZXRpb25TdGF0ZU1hY2hpbmUAEf////8AAAAAAAEAKAEBAAAAAQAAAAEA" +
           "AAABAf////8AAAAA";

        private const string UpdateStatus_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAMAAAAVXBk" +
           "YXRlU3RhdHVzAQGFAAAvAD+FAAAAABX/////AQH/////AAAAAA==";

        private const string SoftwareClass_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQANAAAAU29m" +
           "dHdhcmVDbGFzcwEBYAEALgBEYAEAAAEBmAH/////AQH/////AAAAAA==";

        private const string SoftwareSubclass_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAQAAAAU29m" +
           "dHdhcmVTdWJjbGFzcwEBYQEALgBEYQEAAAAM/////wEB/////wAAAAA=";

        private const string SoftwareName_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAMAAAAU29m" +
           "dHdhcmVOYW1lAQFiAQAuAERiAQAAAAz/////AQH/////AAAAAA==";

        private const string UnsignedPackageAllowed_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAWAAAAVW5z" +
           "aWduZWRQYWNrYWdlQWxsb3dlZAEBYwEALgBEYwEAAAAB/////wEB/////wAAAAA=";

        private const string VendorErrorCode_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAPAAAAVmVu" +
           "ZG9yRXJyb3JDb2RlAQGSAQAvAD+SAQAAAAb/////AQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAaAAAAU29m" +
           "dHdhcmVVcGRhdGVUeXBlSW5zdGFuY2UBAQEAAQEBAAEAAAD/////DQAAAARggAoBAAAAAQAHAAAATG9h" +
           "ZGluZwEBAgAALwEBhwACAAAA/////wAAAAAEYIAKAQAAAAEAEAAAAFByZXBhcmVGb3JVcGRhdGUBAQQA" +
           "AC8BAdUABAAAAP////8DAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBAQUAAC8BAMgKBQAAAAAV" +
           "/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQEGAAAuAEQGAAAAABH/////AQH/////AAAAAARh" +
           "ggoEAAAAAQAHAAAAUHJlcGFyZQEBEwAALwEB5AATAAAAAQH/////AAAAAARhggoEAAAAAQAFAAAAQWJv" +
           "cnQBARQAAC8BAeUAFAAAAAEB/////wAAAAAEYIAKAQAAAAEADAAAAEluc3RhbGxhdGlvbgEBKAAALwEB" +
           "+QAoAAAA/////wIAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBKQAALwEAyAopAAAAABX/////" +
           "AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBASoAAC4ARCoAAAAAEf////8BAf////8AAAAABGGCCgQA" +
           "AAABAAYAAABSZXN1bWUBAT0AAC8BAQ4BPQAAAAEB/////wAAAAAEYIAKAQAAAAEACgAAAFBvd2VyQ3lj" +
           "bGUBAUwAAC8BAR0BTAAAAP////8BAAAAFWCJCgIAAAAAAAwAAABDdXJyZW50U3RhdGUBAU0AAC8BAMgK" +
           "TQAAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAAAgAAAElkAQFOAAAuAEROAAAAABH/////AQH/////" +
           "AAAAAARggAoBAAAAAQAMAAAAQ29uZmlybWF0aW9uAQFiAAAvAQEzAWIAAAD/////AwAAABVgiQoCAAAA" +
           "AAAMAAAAQ3VycmVudFN0YXRlAQFjAAAvAQDICmMAAAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIA" +
           "AABJZAEBZAAALgBEZAAAAAAR/////wEB/////wAAAAAEYYIKBAAAAAEABwAAAENvbmZpcm0BAXAAAC8B" +
           "AUEBcAAAAAEB/////wAAAAAVYIkKAgAAAAEAEwAAAENvbmZpcm1hdGlvblRpbWVvdXQBAXEAAC8AP3EA" +
           "AAABACIB/////wEB/////wAAAAAEYIAKAQAAAAEACgAAAFBhcmFtZXRlcnMBAXoAAC8BAIA9egAAAP//" +
           "//8EAAAAFWCJCgIAAAAAABcAAABDbGllbnRQcm9jZXNzaW5nVGltZW91dAEBewAALgBEewAAAAEAIgH/" +
           "////AQH/////AAAAAARhggoEAAAAAAATAAAAR2VuZXJhdGVGaWxlRm9yUmVhZAEBfAAALwEAgj18AAAA" +
           "AQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAX0AAC4ARH0AAACWAQAAAAEAKgEB" +
           "HgAAAA8AAABHZW5lcmF0ZU9wdGlvbnMAGP////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAA" +
           "F2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAX4AAC4ARH4AAACWAwAAAAEAKgEBGQAAAAoAAABG" +
           "aWxlTm9kZUlkABH/////AAAAAAABACoBARkAAAAKAAAARmlsZUhhbmRsZQAH/////wAAAAAAAQAqAQEl" +
           "AAAAFgAAAENvbXBsZXRpb25TdGF0ZU1hY2hpbmUAEf////8AAAAAAAEAKAEBAAAAAQAAAAMAAAABAf//" +
           "//8AAAAABGGCCgQAAAAAABQAAABHZW5lcmF0ZUZpbGVGb3JXcml0ZQEBfwAALwEAhT1/AAAAAQH/////" +
           "AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAYAAAC4ARIAAAACWAQAAAAEAKgEBHgAAAA8A" +
           "AABHZW5lcmF0ZU9wdGlvbnMAGP////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAF2CpCgIA" +
           "AAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAYEAAC4ARIEAAACWAgAAAAEAKgEBGQAAAAoAAABGaWxlTm9k" +
           "ZUlkABH/////AAAAAAABACoBARkAAAAKAAAARmlsZUhhbmRsZQAH/////wAAAAAAAQAoAQEAAAABAAAA" +
           "AgAAAAEB/////wAAAAAEYYIKBAAAAAAADgAAAENsb3NlQW5kQ29tbWl0AQGCAAAvAQCHPYIAAAABAf//" +
           "//8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBgwAALgBEgwAAAJYBAAAAAQAqAQEZAAAA" +
           "CgAAAEZpbGVIYW5kbGUAB/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAF2CpCgIAAAAA" +
           "AA8AAABPdXRwdXRBcmd1bWVudHMBAYQAAC4ARIQAAACWAQAAAAEAKgEBJQAAABYAAABDb21wbGV0aW9u" +
           "U3RhdGVNYWNoaW5lABH/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABVgiQoCAAAAAQAM" +
           "AAAAVXBkYXRlU3RhdHVzAQGFAAAvAD+FAAAAABX/////AQH/////AAAAABVgiQoCAAAAAQANAAAAU29m" +
           "dHdhcmVDbGFzcwEBYAEALgBEYAEAAAEBmAH/////AQH/////AAAAABVgiQoCAAAAAQAQAAAAU29mdHdh" +
           "cmVTdWJjbGFzcwEBYQEALgBEYQEAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAFNvZnR3YXJl" +
           "TmFtZQEBYgEALgBEYgEAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEAFgAAAFVuc2lnbmVkUGFja2Fn" +
           "ZUFsbG93ZWQBAWMBAC4ARGMBAAAAAf////8BAf////8AAAAAFWCJCgIAAAABAA8AAABWZW5kb3JFcnJv" +
           "ckNvZGUBAZIBAC8AP5IBAAAABv////8BAf////8AAAAAFWCpCgIAAAAAABkAAABEZWZhdWx0SW5zdGFu" +
           "Y2VCcm93c2VOYW1lAQGGAAAuAESGAAAAFAEADgAAAFNvZnR3YXJlVXBkYXRlABT/////AQH/////AAAA" +
           "AA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public SoftwareLoadingTypeState Loading
        {
            get => m_loading;

            set
            {
                if (!Object.ReferenceEquals(m_loading, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_loading = value;
            }
        }

        public PrepareForUpdateStateMachineTypeState PrepareForUpdate
        {
            get => m_prepareForUpdate;

            set
            {
                if (!Object.ReferenceEquals(m_prepareForUpdate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_prepareForUpdate = value;
            }
        }

        public InstallationStateMachineTypeState Installation
        {
            get => m_installation;

            set
            {
                if (!Object.ReferenceEquals(m_installation, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_installation = value;
            }
        }

        public PowerCycleStateMachineTypeState PowerCycle
        {
            get => m_powerCycle;

            set
            {
                if (!Object.ReferenceEquals(m_powerCycle, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_powerCycle = value;
            }
        }

        public ConfirmationStateMachineTypeState Confirmation
        {
            get => m_confirmation;

            set
            {
                if (!Object.ReferenceEquals(m_confirmation, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_confirmation = value;
            }
        }

        public TemporaryFileTransferState Parameters
        {
            get => m_parameters;

            set
            {
                if (!Object.ReferenceEquals(m_parameters, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_parameters = value;
            }
        }

        public BaseDataVariableState<LocalizedText> UpdateStatus
        {
            get => m_updateStatus;

            set
            {
                if (!Object.ReferenceEquals(m_updateStatus, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_updateStatus = value;
            }
        }

        public PropertyState<SoftwareClass> SoftwareClass
        {
            get => m_softwareClass;

            set
            {
                if (!Object.ReferenceEquals(m_softwareClass, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_softwareClass = value;
            }
        }

        public PropertyState<string> SoftwareSubclass
        {
            get => m_softwareSubclass;

            set
            {
                if (!Object.ReferenceEquals(m_softwareSubclass, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_softwareSubclass = value;
            }
        }

        public PropertyState<string> SoftwareName
        {
            get => m_softwareName;

            set
            {
                if (!Object.ReferenceEquals(m_softwareName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_softwareName = value;
            }
        }

        public PropertyState<bool> UnsignedPackageAllowed
        {
            get => m_unsignedPackageAllowed;

            set
            {
                if (!Object.ReferenceEquals(m_unsignedPackageAllowed, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_unsignedPackageAllowed = value;
            }
        }

        public BaseDataVariableState<int> VendorErrorCode
        {
            get => m_vendorErrorCode;

            set
            {
                if (!Object.ReferenceEquals(m_vendorErrorCode, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_vendorErrorCode = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_loading != null)
            {
                children.Add(m_loading);
            }

            if (m_prepareForUpdate != null)
            {
                children.Add(m_prepareForUpdate);
            }

            if (m_installation != null)
            {
                children.Add(m_installation);
            }

            if (m_powerCycle != null)
            {
                children.Add(m_powerCycle);
            }

            if (m_confirmation != null)
            {
                children.Add(m_confirmation);
            }

            if (m_parameters != null)
            {
                children.Add(m_parameters);
            }

            if (m_updateStatus != null)
            {
                children.Add(m_updateStatus);
            }

            if (m_softwareClass != null)
            {
                children.Add(m_softwareClass);
            }

            if (m_softwareSubclass != null)
            {
                children.Add(m_softwareSubclass);
            }

            if (m_softwareName != null)
            {
                children.Add(m_softwareName);
            }

            if (m_unsignedPackageAllowed != null)
            {
                children.Add(m_unsignedPackageAllowed);
            }

            if (m_vendorErrorCode != null)
            {
                children.Add(m_vendorErrorCode);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_loading, child))
            {
                m_loading = null;
                return;
            }

            if (Object.ReferenceEquals(m_prepareForUpdate, child))
            {
                m_prepareForUpdate = null;
                return;
            }

            if (Object.ReferenceEquals(m_installation, child))
            {
                m_installation = null;
                return;
            }

            if (Object.ReferenceEquals(m_powerCycle, child))
            {
                m_powerCycle = null;
                return;
            }

            if (Object.ReferenceEquals(m_confirmation, child))
            {
                m_confirmation = null;
                return;
            }

            if (Object.ReferenceEquals(m_parameters, child))
            {
                m_parameters = null;
                return;
            }

            if (Object.ReferenceEquals(m_updateStatus, child))
            {
                m_updateStatus = null;
                return;
            }

            if (Object.ReferenceEquals(m_softwareClass, child))
            {
                m_softwareClass = null;
                return;
            }

            if (Object.ReferenceEquals(m_softwareSubclass, child))
            {
                m_softwareSubclass = null;
                return;
            }

            if (Object.ReferenceEquals(m_softwareName, child))
            {
                m_softwareName = null;
                return;
            }

            if (Object.ReferenceEquals(m_unsignedPackageAllowed, child))
            {
                m_unsignedPackageAllowed = null;
                return;
            }

            if (Object.ReferenceEquals(m_vendorErrorCode, child))
            {
                m_vendorErrorCode = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.Loading:
                {
                    if (createOrReplace)
                    {
                        if (Loading == null)
                        {
                            if (replacement == null)
                            {
                                Loading = new SoftwareLoadingTypeState(this);
                            }
                            else
                            {
                                Loading = (SoftwareLoadingTypeState)replacement;
                            }
                        }
                    }

                    instance = Loading;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.PrepareForUpdate:
                {
                    if (createOrReplace)
                    {
                        if (PrepareForUpdate == null)
                        {
                            if (replacement == null)
                            {
                                PrepareForUpdate = new PrepareForUpdateStateMachineTypeState(this);
                            }
                            else
                            {
                                PrepareForUpdate = (PrepareForUpdateStateMachineTypeState)replacement;
                            }
                        }
                    }

                    instance = PrepareForUpdate;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.Installation:
                {
                    if (createOrReplace)
                    {
                        if (Installation == null)
                        {
                            if (replacement == null)
                            {
                                Installation = new InstallationStateMachineTypeState(this);
                            }
                            else
                            {
                                Installation = (InstallationStateMachineTypeState)replacement;
                            }
                        }
                    }

                    instance = Installation;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.PowerCycle:
                {
                    if (createOrReplace)
                    {
                        if (PowerCycle == null)
                        {
                            if (replacement == null)
                            {
                                PowerCycle = new PowerCycleStateMachineTypeState(this);
                            }
                            else
                            {
                                PowerCycle = (PowerCycleStateMachineTypeState)replacement;
                            }
                        }
                    }

                    instance = PowerCycle;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.Confirmation:
                {
                    if (createOrReplace)
                    {
                        if (Confirmation == null)
                        {
                            if (replacement == null)
                            {
                                Confirmation = new ConfirmationStateMachineTypeState(this);
                            }
                            else
                            {
                                Confirmation = (ConfirmationStateMachineTypeState)replacement;
                            }
                        }
                    }

                    instance = Confirmation;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.Parameters:
                {
                    if (createOrReplace)
                    {
                        if (Parameters == null)
                        {
                            if (replacement == null)
                            {
                                Parameters = new TemporaryFileTransferState(this);
                            }
                            else
                            {
                                Parameters = (TemporaryFileTransferState)replacement;
                            }
                        }
                    }

                    instance = Parameters;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.UpdateStatus:
                {
                    if (createOrReplace)
                    {
                        if (UpdateStatus == null)
                        {
                            if (replacement == null)
                            {
                                UpdateStatus = new BaseDataVariableState<LocalizedText>(this);
                            }
                            else
                            {
                                UpdateStatus = (BaseDataVariableState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = UpdateStatus;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.SoftwareClass:
                {
                    if (createOrReplace)
                    {
                        if (SoftwareClass == null)
                        {
                            if (replacement == null)
                            {
                                SoftwareClass = new PropertyState<SoftwareClass>(this);
                            }
                            else
                            {
                                SoftwareClass = (PropertyState<SoftwareClass>)replacement;
                            }
                        }
                    }

                    instance = SoftwareClass;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.SoftwareSubclass:
                {
                    if (createOrReplace)
                    {
                        if (SoftwareSubclass == null)
                        {
                            if (replacement == null)
                            {
                                SoftwareSubclass = new PropertyState<string>(this);
                            }
                            else
                            {
                                SoftwareSubclass = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SoftwareSubclass;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.SoftwareName:
                {
                    if (createOrReplace)
                    {
                        if (SoftwareName == null)
                        {
                            if (replacement == null)
                            {
                                SoftwareName = new PropertyState<string>(this);
                            }
                            else
                            {
                                SoftwareName = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SoftwareName;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.UnsignedPackageAllowed:
                {
                    if (createOrReplace)
                    {
                        if (UnsignedPackageAllowed == null)
                        {
                            if (replacement == null)
                            {
                                UnsignedPackageAllowed = new PropertyState<bool>(this);
                            }
                            else
                            {
                                UnsignedPackageAllowed = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = UnsignedPackageAllowed;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.VendorErrorCode:
                {
                    if (createOrReplace)
                    {
                        if (VendorErrorCode == null)
                        {
                            if (replacement == null)
                            {
                                VendorErrorCode = new BaseDataVariableState<int>(this);
                            }
                            else
                            {
                                VendorErrorCode = (BaseDataVariableState<int>)replacement;
                            }
                        }
                    }

                    instance = VendorErrorCode;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private SoftwareLoadingTypeState m_loading;
        private PrepareForUpdateStateMachineTypeState m_prepareForUpdate;
        private InstallationStateMachineTypeState m_installation;
        private PowerCycleStateMachineTypeState m_powerCycle;
        private ConfirmationStateMachineTypeState m_confirmation;
        private TemporaryFileTransferState m_parameters;
        private BaseDataVariableState<LocalizedText> m_updateStatus;
        private PropertyState<SoftwareClass> m_softwareClass;
        private PropertyState<string> m_softwareSubclass;
        private PropertyState<string> m_softwareName;
        private PropertyState<bool> m_unsignedPackageAllowed;
        private BaseDataVariableState<int> m_vendorErrorCode;
        #endregion
    }
    #endif
    #endregion

    #region SoftwareLoadingTypeState Class
    #if (!OPCUA_EXCLUDE_SoftwareLoadingTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class SoftwareLoadingTypeState : BaseObjectState
    {
        #region Constructors
        public SoftwareLoadingTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.SoftwareLoadingType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (UpdateKey != null)
            {
                UpdateKey.Initialize(context, UpdateKey_InitializationString);
            }
        }

        #region Initialization String
        private const string UpdateKey_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAJAAAAVXBk" +
           "YXRlS2V5AQGIAAAvAD+IAAAAAAz/////AQH/////AAAAAA==";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAbAAAAU29m" +
           "dHdhcmVMb2FkaW5nVHlwZUluc3RhbmNlAQGHAAEBhwCHAAAA/////wEAAAAVYIkKAgAAAAEACQAAAFVw" +
           "ZGF0ZUtleQEBiAAALwA/iAAAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public BaseDataVariableState<string> UpdateKey
        {
            get => m_updateKey;

            set
            {
                if (!Object.ReferenceEquals(m_updateKey, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_updateKey = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_updateKey != null)
            {
                children.Add(m_updateKey);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_updateKey, child))
            {
                m_updateKey = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.UpdateKey:
                {
                    if (createOrReplace)
                    {
                        if (UpdateKey == null)
                        {
                            if (replacement == null)
                            {
                                UpdateKey = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                UpdateKey = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = UpdateKey;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<string> m_updateKey;
        #endregion
    }
    #endif
    #endregion

    #region PackageLoadingTypeState Class
    #if (!OPCUA_EXCLUDE_PackageLoadingTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class PackageLoadingTypeState : SoftwareLoadingTypeState
    {
        #region Constructors
        public PackageLoadingTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.PackageLoadingType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (WriteBlockSize != null)
            {
                WriteBlockSize.Initialize(context, WriteBlockSize_InitializationString);
            }
        }

        #region Initialization String
        private const string WriteBlockSize_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAOAAAAV3Jp" +
           "dGVCbG9ja1NpemUBAZgAAC4ARJgAAAAAB/////8BAf////8AAAAA";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAaAAAAUGFj" +
           "a2FnZUxvYWRpbmdUeXBlSW5zdGFuY2UBAYkAAQGJAIkAAAD/////BAAAAARggAoBAAAAAQAOAAAAQ3Vy" +
           "cmVudFZlcnNpb24BAYsAAC8BAdQAiwAAAP////8DAAAAFWCJCgIAAAABAAwAAABNYW51ZmFjdHVyZXIB" +
           "AVkBAC4ARFkBAAAAFf////8BAf////8AAAAAFWCJCgIAAAABAA8AAABNYW51ZmFjdHVyZXJVcmkBAVoB" +
           "AC4ARFoBAAAADP////8BAf////8AAAAAFWCJCgIAAAABABAAAABTb2Z0d2FyZVJldmlzaW9uAQFbAQAu" +
           "AERbAQAAAAz/////AQH/////AAAAAARggAoBAAAAAQAMAAAARmlsZVRyYW5zZmVyAQGMAAAvAQCAPYwA" +
           "AAD/////BAAAABVgiQoCAAAAAAAXAAAAQ2xpZW50UHJvY2Vzc2luZ1RpbWVvdXQBAY0AAC4ARI0AAAAB" +
           "ACIB/////wEB/////wAAAAAEYYIKBAAAAAAAEwAAAEdlbmVyYXRlRmlsZUZvclJlYWQBAY4AAC8BAII9" +
           "jgAAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGPAAAuAESPAAAAlgEAAAAB" +
           "ACoBAR4AAAAPAAAAR2VuZXJhdGVPcHRpb25zABj/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////" +
           "AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGQAAAuAESQAAAAlgMAAAABACoBARkAAAAK" +
           "AAAARmlsZU5vZGVJZAAR/////wAAAAAAAQAqAQEZAAAACgAAAEZpbGVIYW5kbGUAB/////8AAAAAAAEA" +
           "KgEBJQAAABYAAABDb21wbGV0aW9uU3RhdGVNYWNoaW5lABH/////AAAAAAABACgBAQAAAAEAAAADAAAA" +
           "AQH/////AAAAAARhggoEAAAAAAAUAAAAR2VuZXJhdGVGaWxlRm9yV3JpdGUBAZEAAC8BAIU9kQAAAAEB" +
           "/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJndW1lbnRzAQGSAAAuAESSAAAAlgEAAAABACoBAR4A" +
           "AAAPAAAAR2VuZXJhdGVPcHRpb25zABj/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABdg" +
           "qQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGTAAAuAESTAAAAlgIAAAABACoBARkAAAAKAAAARmls" +
           "ZU5vZGVJZAAR/////wAAAAAAAQAqAQEZAAAACgAAAEZpbGVIYW5kbGUAB/////8AAAAAAAEAKAEBAAAA" +
           "AQAAAAIAAAABAf////8AAAAABGGCCgQAAAAAAA4AAABDbG9zZUFuZENvbW1pdAEBlAAALwEAhz2UAAAA" +
           "AQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAZUAAC4ARJUAAACWAQAAAAEAKgEB" +
           "GQAAAAoAAABGaWxlSGFuZGxlAAf/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABdgqQoC" +
           "AAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQGWAAAuAESWAAAAlgEAAAABACoBASUAAAAWAAAAQ29tcGxl" +
           "dGlvblN0YXRlTWFjaGluZQAR/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAVYIkKAgAA" +
           "AAEADAAAAEVycm9yTWVzc2FnZQEBlwAALwA/lwAAAAAV/////wEB/////wAAAAAVYIkKAgAAAAEADgAA" +
           "AFdyaXRlQmxvY2tTaXplAQGYAAAuAESYAAAAAAf/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public SoftwareVersionTypeState CurrentVersion
        {
            get => m_currentVersion;

            set
            {
                if (!Object.ReferenceEquals(m_currentVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_currentVersion = value;
            }
        }

        public TemporaryFileTransferState FileTransfer
        {
            get => m_fileTransfer;

            set
            {
                if (!Object.ReferenceEquals(m_fileTransfer, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_fileTransfer = value;
            }
        }

        public BaseDataVariableState<LocalizedText> ErrorMessage
        {
            get => m_errorMessage;

            set
            {
                if (!Object.ReferenceEquals(m_errorMessage, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_errorMessage = value;
            }
        }

        public PropertyState<uint> WriteBlockSize
        {
            get => m_writeBlockSize;

            set
            {
                if (!Object.ReferenceEquals(m_writeBlockSize, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_writeBlockSize = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_currentVersion != null)
            {
                children.Add(m_currentVersion);
            }

            if (m_fileTransfer != null)
            {
                children.Add(m_fileTransfer);
            }

            if (m_errorMessage != null)
            {
                children.Add(m_errorMessage);
            }

            if (m_writeBlockSize != null)
            {
                children.Add(m_writeBlockSize);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_currentVersion, child))
            {
                m_currentVersion = null;
                return;
            }

            if (Object.ReferenceEquals(m_fileTransfer, child))
            {
                m_fileTransfer = null;
                return;
            }

            if (Object.ReferenceEquals(m_errorMessage, child))
            {
                m_errorMessage = null;
                return;
            }

            if (Object.ReferenceEquals(m_writeBlockSize, child))
            {
                m_writeBlockSize = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.CurrentVersion:
                {
                    if (createOrReplace)
                    {
                        if (CurrentVersion == null)
                        {
                            if (replacement == null)
                            {
                                CurrentVersion = new SoftwareVersionTypeState(this);
                            }
                            else
                            {
                                CurrentVersion = (SoftwareVersionTypeState)replacement;
                            }
                        }
                    }

                    instance = CurrentVersion;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.FileTransfer:
                {
                    if (createOrReplace)
                    {
                        if (FileTransfer == null)
                        {
                            if (replacement == null)
                            {
                                FileTransfer = new TemporaryFileTransferState(this);
                            }
                            else
                            {
                                FileTransfer = (TemporaryFileTransferState)replacement;
                            }
                        }
                    }

                    instance = FileTransfer;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.ErrorMessage:
                {
                    if (createOrReplace)
                    {
                        if (ErrorMessage == null)
                        {
                            if (replacement == null)
                            {
                                ErrorMessage = new BaseDataVariableState<LocalizedText>(this);
                            }
                            else
                            {
                                ErrorMessage = (BaseDataVariableState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = ErrorMessage;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.WriteBlockSize:
                {
                    if (createOrReplace)
                    {
                        if (WriteBlockSize == null)
                        {
                            if (replacement == null)
                            {
                                WriteBlockSize = new PropertyState<uint>(this);
                            }
                            else
                            {
                                WriteBlockSize = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = WriteBlockSize;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private SoftwareVersionTypeState m_currentVersion;
        private TemporaryFileTransferState m_fileTransfer;
        private BaseDataVariableState<LocalizedText> m_errorMessage;
        private PropertyState<uint> m_writeBlockSize;
        #endregion
    }
    #endif
    #endregion

    #region DirectLoadingTypeState Class
    #if (!OPCUA_EXCLUDE_DirectLoadingTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class DirectLoadingTypeState : PackageLoadingTypeState
    {
        #region Constructors
        public DirectLoadingTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.DirectLoadingType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (WriteTimeout != null)
            {
                WriteTimeout.Initialize(context, WriteTimeout_InitializationString);
            }
        }

        #region Initialization String
        private const string WriteTimeout_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAMAAAAV3Jp" +
           "dGVUaW1lb3V0AQGqAAAuAESqAAAAAQAiAf////8BAf////8AAAAA";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAZAAAARGly" +
           "ZWN0TG9hZGluZ1R5cGVJbnN0YW5jZQEBmQABAZkAmQAAAP////8FAAAABGCACgEAAAABAA4AAABDdXJy" +
           "ZW50VmVyc2lvbgEBiwAALwEB1ACLAAAA/////wMAAAAVYIkKAgAAAAEADAAAAE1hbnVmYWN0dXJlcgEB" +
           "WQEALgBEWQEAAAAV/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAE1hbnVmYWN0dXJlclVyaQEBWgEA" +
           "LgBEWgEAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAFNvZnR3YXJlUmV2aXNpb24BAVsBAC4A" +
           "RFsBAAAADP////8BAf////8AAAAABGCACgEAAAABAAwAAABGaWxlVHJhbnNmZXIBAYwAAC8BAIA9jAAA" +
           "AP////8EAAAAFWCJCgIAAAAAABcAAABDbGllbnRQcm9jZXNzaW5nVGltZW91dAEBjQAALgBEjQAAAAEA" +
           "IgH/////AQH/////AAAAAARhggoEAAAAAAATAAAAR2VuZXJhdGVGaWxlRm9yUmVhZAEBjgAALwEAgj2O" +
           "AAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAY8AAC4ARI8AAACWAQAAAAEA" +
           "KgEBHgAAAA8AAABHZW5lcmF0ZU9wdGlvbnMAGP////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8A" +
           "AAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAZAAAC4ARJAAAACWAwAAAAEAKgEBGQAAAAoA" +
           "AABGaWxlTm9kZUlkABH/////AAAAAAABACoBARkAAAAKAAAARmlsZUhhbmRsZQAH/////wAAAAAAAQAq" +
           "AQElAAAAFgAAAENvbXBsZXRpb25TdGF0ZU1hY2hpbmUAEf////8AAAAAAAEAKAEBAAAAAQAAAAMAAAAB" +
           "Af////8AAAAABGGCCgQAAAAAABQAAABHZW5lcmF0ZUZpbGVGb3JXcml0ZQEBkQAALwEAhT2RAAAAAQH/" +
           "////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAZIAAC4ARJIAAACWAQAAAAEAKgEBHgAA" +
           "AA8AAABHZW5lcmF0ZU9wdGlvbnMAGP////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAF2Cp" +
           "CgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAZMAAC4ARJMAAACWAgAAAAEAKgEBGQAAAAoAAABGaWxl" +
           "Tm9kZUlkABH/////AAAAAAABACoBARkAAAAKAAAARmlsZUhhbmRsZQAH/////wAAAAAAAQAoAQEAAAAB" +
           "AAAAAgAAAAEB/////wAAAAAEYYIKBAAAAAAADgAAAENsb3NlQW5kQ29tbWl0AQGUAAAvAQCHPZQAAAAB" +
           "Af////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBlQAALgBElQAAAJYBAAAAAQAqAQEZ" +
           "AAAACgAAAEZpbGVIYW5kbGUAB/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAF2CpCgIA" +
           "AAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAZYAAC4ARJYAAACWAQAAAAEAKgEBJQAAABYAAABDb21wbGV0" +
           "aW9uU3RhdGVNYWNoaW5lABH/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABVgiQoCAAAA" +
           "AQAMAAAARXJyb3JNZXNzYWdlAQGXAAAvAD+XAAAAABX/////AQH/////AAAAABVgiQoCAAAAAQAOAAAA" +
           "VXBkYXRlQmVoYXZpb3IBAakAAC8AP6kAAAABAU0B/////wEB/////wAAAAAVYIkKAgAAAAEADAAAAFdy" +
           "aXRlVGltZW91dAEBqgAALgBEqgAAAAEAIgH/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public BaseDataVariableState<uint> UpdateBehavior
        {
            get => m_updateBehavior;

            set
            {
                if (!Object.ReferenceEquals(m_updateBehavior, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_updateBehavior = value;
            }
        }

        public PropertyState<double> WriteTimeout
        {
            get => m_writeTimeout;

            set
            {
                if (!Object.ReferenceEquals(m_writeTimeout, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_writeTimeout = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_updateBehavior != null)
            {
                children.Add(m_updateBehavior);
            }

            if (m_writeTimeout != null)
            {
                children.Add(m_writeTimeout);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_updateBehavior, child))
            {
                m_updateBehavior = null;
                return;
            }

            if (Object.ReferenceEquals(m_writeTimeout, child))
            {
                m_writeTimeout = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.UpdateBehavior:
                {
                    if (createOrReplace)
                    {
                        if (UpdateBehavior == null)
                        {
                            if (replacement == null)
                            {
                                UpdateBehavior = new BaseDataVariableState<uint>(this);
                            }
                            else
                            {
                                UpdateBehavior = (BaseDataVariableState<uint>)replacement;
                            }
                        }
                    }

                    instance = UpdateBehavior;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.WriteTimeout:
                {
                    if (createOrReplace)
                    {
                        if (WriteTimeout == null)
                        {
                            if (replacement == null)
                            {
                                WriteTimeout = new PropertyState<double>(this);
                            }
                            else
                            {
                                WriteTimeout = (PropertyState<double>)replacement;
                            }
                        }
                    }

                    instance = WriteTimeout;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<uint> m_updateBehavior;
        private PropertyState<double> m_writeTimeout;
        #endregion
    }
    #endif
    #endregion

    #region CachedLoadingTypeState Class
    #if (!OPCUA_EXCLUDE_CachedLoadingTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class CachedLoadingTypeState : PackageLoadingTypeState
    {
        #region Constructors
        public CachedLoadingTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.CachedLoadingType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (FallbackVersion != null)
            {
                FallbackVersion.Initialize(context, FallbackVersion_InitializationString);
            }
        }

        #region Initialization String
        private const string FallbackVersion_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAoBAAAAAQAPAAAARmFs" +
           "bGJhY2tWZXJzaW9uAQG8AAAvAQHUALwAAAD/////AwAAABVgiQoCAAAAAQAMAAAATWFudWZhY3R1cmVy" +
           "AQF1AQAuAER1AQAAABX/////AQH/////AAAAABVgiQoCAAAAAQAPAAAATWFudWZhY3R1cmVyVXJpAQF2" +
           "AQAuAER2AQAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAQAAAAU29mdHdhcmVSZXZpc2lvbgEBdwEA" +
           "LgBEdwEAAAAM/////wEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAZAAAAQ2Fj" +
           "aGVkTG9hZGluZ1R5cGVJbnN0YW5jZQEBqwABAasAqwAAAP////8GAAAABGCACgEAAAABAA4AAABDdXJy" +
           "ZW50VmVyc2lvbgEBiwAALwEB1ACLAAAA/////wMAAAAVYIkKAgAAAAEADAAAAE1hbnVmYWN0dXJlcgEB" +
           "WQEALgBEWQEAAAAV/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAE1hbnVmYWN0dXJlclVyaQEBWgEA" +
           "LgBEWgEAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAFNvZnR3YXJlUmV2aXNpb24BAVsBAC4A" +
           "RFsBAAAADP////8BAf////8AAAAABGCACgEAAAABAAwAAABGaWxlVHJhbnNmZXIBAYwAAC8BAIA9jAAA" +
           "AP////8EAAAAFWCJCgIAAAAAABcAAABDbGllbnRQcm9jZXNzaW5nVGltZW91dAEBjQAALgBEjQAAAAEA" +
           "IgH/////AQH/////AAAAAARhggoEAAAAAAATAAAAR2VuZXJhdGVGaWxlRm9yUmVhZAEBjgAALwEAgj2O" +
           "AAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAY8AAC4ARI8AAACWAQAAAAEA" +
           "KgEBHgAAAA8AAABHZW5lcmF0ZU9wdGlvbnMAGP////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8A" +
           "AAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAZAAAC4ARJAAAACWAwAAAAEAKgEBGQAAAAoA" +
           "AABGaWxlTm9kZUlkABH/////AAAAAAABACoBARkAAAAKAAAARmlsZUhhbmRsZQAH/////wAAAAAAAQAq" +
           "AQElAAAAFgAAAENvbXBsZXRpb25TdGF0ZU1hY2hpbmUAEf////8AAAAAAAEAKAEBAAAAAQAAAAMAAAAB" +
           "Af////8AAAAABGGCCgQAAAAAABQAAABHZW5lcmF0ZUZpbGVGb3JXcml0ZQEBkQAALwEAhT2RAAAAAQH/" +
           "////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAZIAAC4ARJIAAACWAQAAAAEAKgEBHgAA" +
           "AA8AAABHZW5lcmF0ZU9wdGlvbnMAGP////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAF2Cp" +
           "CgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAZMAAC4ARJMAAACWAgAAAAEAKgEBGQAAAAoAAABGaWxl" +
           "Tm9kZUlkABH/////AAAAAAABACoBARkAAAAKAAAARmlsZUhhbmRsZQAH/////wAAAAAAAQAoAQEAAAAB" +
           "AAAAAgAAAAEB/////wAAAAAEYYIKBAAAAAAADgAAAENsb3NlQW5kQ29tbWl0AQGUAAAvAQCHPZQAAAAB" +
           "Af////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBlQAALgBElQAAAJYBAAAAAQAqAQEZ" +
           "AAAACgAAAEZpbGVIYW5kbGUAB/////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAAF2CpCgIA" +
           "AAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAZYAAC4ARJYAAACWAQAAAAEAKgEBJQAAABYAAABDb21wbGV0" +
           "aW9uU3RhdGVNYWNoaW5lABH/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAABVgiQoCAAAA" +
           "AQAMAAAARXJyb3JNZXNzYWdlAQGXAAAvAD+XAAAAABX/////AQH/////AAAAAARggAoBAAAAAQAOAAAA" +
           "UGVuZGluZ1ZlcnNpb24BAbsAAC8BAdQAuwAAAP////8DAAAAFWCJCgIAAAABAAwAAABNYW51ZmFjdHVy" +
           "ZXIBAW4BAC4ARG4BAAAAFf////8BAf////8AAAAAFWCJCgIAAAABAA8AAABNYW51ZmFjdHVyZXJVcmkB" +
           "AW8BAC4ARG8BAAAADP////8BAf////8AAAAAFWCJCgIAAAABABAAAABTb2Z0d2FyZVJldmlzaW9uAQFw" +
           "AQAuAERwAQAAAAz/////AQH/////AAAAAARggAoBAAAAAQAPAAAARmFsbGJhY2tWZXJzaW9uAQG8AAAv" +
           "AQHUALwAAAD/////AwAAABVgiQoCAAAAAQAMAAAATWFudWZhY3R1cmVyAQF1AQAuAER1AQAAABX/////" +
           "AQH/////AAAAABVgiQoCAAAAAQAPAAAATWFudWZhY3R1cmVyVXJpAQF2AQAuAER2AQAAAAz/////AQH/" +
           "////AAAAABVgiQoCAAAAAQAQAAAAU29mdHdhcmVSZXZpc2lvbgEBdwEALgBEdwEAAAAM/////wEB////" +
           "/wAAAAAEYYIKBAAAAAEAEQAAAEdldFVwZGF0ZUJlaGF2aW9yAQG9AAAvAQG9AL0AAAABAf////8CAAAA" +
           "F2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBvgAALgBEvgAAAJYDAAAAAQAqAQEeAAAADwAAAE1h" +
           "bnVmYWN0dXJlclVyaQAM/////wAAAAAAAQAqAQEfAAAAEAAAAFNvZnR3YXJlUmV2aXNpb24ADP////8A" +
           "AAAAAAEAKgEBIwAAABAAAABQYXRjaElkZW50aWZpZXJzAAwBAAAAAQAAAAAAAAAAAQAoAQEAAAABAAAA" +
           "AwAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEBvwAALgBEvwAAAJYBAAAA" +
           "AQAqAQEfAAAADgAAAFVwZGF0ZUJlaGF2aW9yAQFNAf////8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf//" +
           "//8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public SoftwareVersionTypeState PendingVersion
        {
            get => m_pendingVersion;

            set
            {
                if (!Object.ReferenceEquals(m_pendingVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pendingVersion = value;
            }
        }

        public SoftwareVersionTypeState FallbackVersion
        {
            get => m_fallbackVersion;

            set
            {
                if (!Object.ReferenceEquals(m_fallbackVersion, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_fallbackVersion = value;
            }
        }

        public GetUpdateBehaviorMethodState GetUpdateBehavior
        {
            get => m_getUpdateBehaviorMethod;

            set
            {
                if (!Object.ReferenceEquals(m_getUpdateBehaviorMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_getUpdateBehaviorMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_pendingVersion != null)
            {
                children.Add(m_pendingVersion);
            }

            if (m_fallbackVersion != null)
            {
                children.Add(m_fallbackVersion);
            }

            if (m_getUpdateBehaviorMethod != null)
            {
                children.Add(m_getUpdateBehaviorMethod);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_pendingVersion, child))
            {
                m_pendingVersion = null;
                return;
            }

            if (Object.ReferenceEquals(m_fallbackVersion, child))
            {
                m_fallbackVersion = null;
                return;
            }

            if (Object.ReferenceEquals(m_getUpdateBehaviorMethod, child))
            {
                m_getUpdateBehaviorMethod = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.PendingVersion:
                {
                    if (createOrReplace)
                    {
                        if (PendingVersion == null)
                        {
                            if (replacement == null)
                            {
                                PendingVersion = new SoftwareVersionTypeState(this);
                            }
                            else
                            {
                                PendingVersion = (SoftwareVersionTypeState)replacement;
                            }
                        }
                    }

                    instance = PendingVersion;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.FallbackVersion:
                {
                    if (createOrReplace)
                    {
                        if (FallbackVersion == null)
                        {
                            if (replacement == null)
                            {
                                FallbackVersion = new SoftwareVersionTypeState(this);
                            }
                            else
                            {
                                FallbackVersion = (SoftwareVersionTypeState)replacement;
                            }
                        }
                    }

                    instance = FallbackVersion;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.GetUpdateBehavior:
                {
                    if (createOrReplace)
                    {
                        if (GetUpdateBehavior == null)
                        {
                            if (replacement == null)
                            {
                                GetUpdateBehavior = new GetUpdateBehaviorMethodState(this);
                            }
                            else
                            {
                                GetUpdateBehavior = (GetUpdateBehaviorMethodState)replacement;
                            }
                        }
                    }

                    instance = GetUpdateBehavior;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private SoftwareVersionTypeState m_pendingVersion;
        private SoftwareVersionTypeState m_fallbackVersion;
        private GetUpdateBehaviorMethodState m_getUpdateBehaviorMethod;
        #endregion
    }
    #endif
    #endregion

    #region FileSystemLoadingTypeState Class
    #if (!OPCUA_EXCLUDE_FileSystemLoadingTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class FileSystemLoadingTypeState : SoftwareLoadingTypeState
    {
        #region Constructors
        public FileSystemLoadingTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.FileSystemLoadingType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (ValidateFiles != null)
            {
                ValidateFiles.Initialize(context, ValidateFiles_InitializationString);
            }
        }

        #region Initialization String
        private const string ValidateFiles_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQANAAAAVmFs" +
           "aWRhdGVGaWxlcwEB0QAALwEB0QDRAAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVu" +
           "dHMBAdIAAC4ARNIAAACWAQAAAAEAKgEBGgAAAAcAAABOb2RlSWRzABEBAAAAAQAAAAAAAAAAAQAoAQEA" +
           "AAABAAAAAQAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEB0wAALgBE0wAA" +
           "AJYCAAAAAQAqAQEYAAAACQAAAEVycm9yQ29kZQAG/////wAAAAAAAQAqAQEbAAAADAAAAEVycm9yTWVz" +
           "c2FnZQAV/////wAAAAAAAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAdAAAARmls" +
           "ZVN5c3RlbUxvYWRpbmdUeXBlSW5zdGFuY2UBAcAAAQHAAMAAAAD/////AwAAAARggAoBAAAAAAAKAAAA" +
           "RmlsZVN5c3RlbQEBwgAALwEAKTTCAAAA/////wQAAAAEYYIKBAAAAAAADwAAAENyZWF0ZURpcmVjdG9y" +
           "eQEBwwAALwEASzTDAAAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAcQAAC4A" +
           "RMQAAACWAQAAAAEAKgEBHAAAAA0AAABEaXJlY3RvcnlOYW1lAAz/////AAAAAAABACgBAQAAAAEAAAAB" +
           "AAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHFAAAuAETFAAAAlgEAAAAB" +
           "ACoBAR4AAAAPAAAARGlyZWN0b3J5Tm9kZUlkABH/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////" +
           "AAAAAARhggoEAAAAAAAKAAAAQ3JlYXRlRmlsZQEBxgAALwEATjTGAAAAAQH/////AgAAABdgqQoCAAAA" +
           "AAAOAAAASW5wdXRBcmd1bWVudHMBAccAAC4ARMcAAACWAgAAAAEAKgEBFwAAAAgAAABGaWxlTmFtZQAM" +
           "/////wAAAAAAAQAqAQEeAAAADwAAAFJlcXVlc3RGaWxlT3BlbgAB/////wAAAAAAAQAoAQEAAAABAAAA" +
           "AgAAAAEB/////wAAAAAXYKkKAgAAAAAADwAAAE91dHB1dEFyZ3VtZW50cwEByAAALgBEyAAAAJYCAAAA" +
           "AQAqAQEZAAAACgAAAEZpbGVOb2RlSWQAEf////8AAAAAAAEAKgEBGQAAAAoAAABGaWxlSGFuZGxlAAf/" +
           "////AAAAAAABACgBAQAAAAEAAAACAAAAAQH/////AAAAAARhwgoEAAAAFgAAAERlbGV0ZUZpbGVTeXN0" +
           "ZW1PYmplY3QAAAYAAABEZWxldGUBAckAAC8BAFE0yQAAAAEB/////wEAAAAXYKkKAgAAAAAADgAAAElu" +
           "cHV0QXJndW1lbnRzAQHKAAAuAETKAAAAlgEAAAABACoBAR0AAAAOAAAAT2JqZWN0VG9EZWxldGUAEf//" +
           "//8AAAAAAAEAKAEBAAAAAQAAAAEAAAABAf////8AAAAABGGCCgQAAAAAAAoAAABNb3ZlT3JDb3B5AQHL" +
           "AAAvAQBTNMsAAAABAf////8CAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBzAAALgBEzAAA" +
           "AJYEAAAAAQAqAQEhAAAAEgAAAE9iamVjdFRvTW92ZU9yQ29weQAR/////wAAAAAAAQAqAQEeAAAADwAA" +
           "AFRhcmdldERpcmVjdG9yeQAR/////wAAAAAAAQAqAQEZAAAACgAAAENyZWF0ZUNvcHkAAf////8AAAAA" +
           "AAEAKgEBFgAAAAcAAABOZXdOYW1lAAz/////AAAAAAABACgBAQAAAAEAAAAEAAAAAQH/////AAAAABdg" +
           "qQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHNAAAuAETNAAAAlgEAAAABACoBARgAAAAJAAAATmV3" +
           "Tm9kZUlkABH/////AAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAAARhggoEAAAAAQARAAAAR2V0" +
           "VXBkYXRlQmVoYXZpb3IBAc4AAC8BAc4AzgAAAAEB/////wIAAAAXYKkKAgAAAAAADgAAAElucHV0QXJn" +
           "dW1lbnRzAQHPAAAuAETPAAAAlgEAAAABACoBARoAAAAHAAAATm9kZUlkcwARAQAAAAEAAAAAAAAAAAEA" +
           "KAEBAAAAAQAAAAEAAAABAf////8AAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAdAAAC4A" +
           "RNAAAACWAQAAAAEAKgEBHwAAAA4AAABVcGRhdGVCZWhhdmlvcgEBTQH/////AAAAAAABACgBAQAAAAEA" +
           "AAABAAAAAQH/////AAAAAARhggoEAAAAAQANAAAAVmFsaWRhdGVGaWxlcwEB0QAALwEB0QDRAAAAAQH/" +
           "////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAdIAAC4ARNIAAACWAQAAAAEAKgEBGgAA" +
           "AAcAAABOb2RlSWRzABEBAAAAAQAAAAAAAAAAAQAoAQEAAAABAAAAAQAAAAEB/////wAAAAAXYKkKAgAA" +
           "AAAADwAAAE91dHB1dEFyZ3VtZW50cwEB0wAALgBE0wAAAJYCAAAAAQAqAQEYAAAACQAAAEVycm9yQ29k" +
           "ZQAG/////wAAAAAAAQAqAQEbAAAADAAAAEVycm9yTWVzc2FnZQAV/////wAAAAAAAQAoAQEAAAABAAAA" +
           "AgAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public FileDirectoryState FileSystem
        {
            get => m_fileSystem;

            set
            {
                if (!Object.ReferenceEquals(m_fileSystem, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_fileSystem = value;
            }
        }

        public GetUpdateBehaviorMethodState GetUpdateBehavior
        {
            get => m_getUpdateBehaviorMethod;

            set
            {
                if (!Object.ReferenceEquals(m_getUpdateBehaviorMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_getUpdateBehaviorMethod = value;
            }
        }

        public ValidateFilesMethodState ValidateFiles
        {
            get => m_validateFilesMethod;

            set
            {
                if (!Object.ReferenceEquals(m_validateFilesMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_validateFilesMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_fileSystem != null)
            {
                children.Add(m_fileSystem);
            }

            if (m_getUpdateBehaviorMethod != null)
            {
                children.Add(m_getUpdateBehaviorMethod);
            }

            if (m_validateFilesMethod != null)
            {
                children.Add(m_validateFilesMethod);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_fileSystem, child))
            {
                m_fileSystem = null;
                return;
            }

            if (Object.ReferenceEquals(m_getUpdateBehaviorMethod, child))
            {
                m_getUpdateBehaviorMethod = null;
                return;
            }

            if (Object.ReferenceEquals(m_validateFilesMethod, child))
            {
                m_validateFilesMethod = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.BrowseNames.FileSystem:
                {
                    if (createOrReplace)
                    {
                        if (FileSystem == null)
                        {
                            if (replacement == null)
                            {
                                FileSystem = new FileDirectoryState(this);
                            }
                            else
                            {
                                FileSystem = (FileDirectoryState)replacement;
                            }
                        }
                    }

                    instance = FileSystem;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.GetUpdateBehavior:
                {
                    if (createOrReplace)
                    {
                        if (GetUpdateBehavior == null)
                        {
                            if (replacement == null)
                            {
                                GetUpdateBehavior = new GetUpdateBehaviorMethodState(this);
                            }
                            else
                            {
                                GetUpdateBehavior = (GetUpdateBehaviorMethodState)replacement;
                            }
                        }
                    }

                    instance = GetUpdateBehavior;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.ValidateFiles:
                {
                    if (createOrReplace)
                    {
                        if (ValidateFiles == null)
                        {
                            if (replacement == null)
                            {
                                ValidateFiles = new ValidateFilesMethodState(this);
                            }
                            else
                            {
                                ValidateFiles = (ValidateFilesMethodState)replacement;
                            }
                        }
                    }

                    instance = ValidateFiles;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private FileDirectoryState m_fileSystem;
        private GetUpdateBehaviorMethodState m_getUpdateBehaviorMethod;
        private ValidateFilesMethodState m_validateFilesMethod;
        #endregion
    }
    #endif
    #endregion

    #region SoftwareVersionTypeState Class
    #if (!OPCUA_EXCLUDE_SoftwareVersionTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class SoftwareVersionTypeState : BaseObjectState
    {
        #region Constructors
        public SoftwareVersionTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.SoftwareVersionType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (PatchIdentifiers != null)
            {
                PatchIdentifiers.Initialize(context, PatchIdentifiers_InitializationString);
            }

            if (ReleaseDate != null)
            {
                ReleaseDate.Initialize(context, ReleaseDate_InitializationString);
            }

            if (ChangeLogReference != null)
            {
                ChangeLogReference.Initialize(context, ChangeLogReference_InitializationString);
            }

            if (Hash != null)
            {
                Hash.Initialize(context, Hash_InitializationString);
            }

            if (Clear != null)
            {
                Clear.Initialize(context, Clear_InitializationString);
            }
        }

        #region Initialization String
        private const string PatchIdentifiers_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xdgiQoCAAAAAQAQAAAAUGF0" +
           "Y2hJZGVudGlmaWVycwEBfwEALgBEfwEAAAAMAQAAAAEAAAAAAAAAAQH/////AAAAAA==";

        private const string ReleaseDate_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQALAAAAUmVs" +
           "ZWFzZURhdGUBAYABAC4ARIABAAAADf////8BAf////8AAAAA";

        private const string ChangeLogReference_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQASAAAAQ2hh" +
           "bmdlTG9nUmVmZXJlbmNlAQGBAQAuAESBAQAAAAz/////AQH/////AAAAAA==";

        private const string Hash_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAEAAAASGFz" +
           "aAEBggEALgBEggEAAAAP/////wEB/////wAAAAA=";

        private const string Clear_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAFAAAAQ2xl" +
           "YXIBAWcBAC8BAWcBZwEAAAEB/////wAAAAA=";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAbAAAAU29m" +
           "dHdhcmVWZXJzaW9uVHlwZUluc3RhbmNlAQHUAAEB1ADUAAAA/////wgAAAAVYIkKAgAAAAEADAAAAE1h" +
           "bnVmYWN0dXJlcgEBfAEALgBEfAEAAAAV/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAE1hbnVmYWN0" +
           "dXJlclVyaQEBfQEALgBEfQEAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAFNvZnR3YXJlUmV2" +
           "aXNpb24BAX4BAC4ARH4BAAAADP////8BAf////8AAAAAF2CJCgIAAAABABAAAABQYXRjaElkZW50aWZp" +
           "ZXJzAQF/AQAuAER/AQAAAAwBAAAAAQAAAAAAAAABAf////8AAAAAFWCJCgIAAAABAAsAAABSZWxlYXNl" +
           "RGF0ZQEBgAEALgBEgAEAAAAN/////wEB/////wAAAAAVYIkKAgAAAAEAEgAAAENoYW5nZUxvZ1JlZmVy" +
           "ZW5jZQEBgQEALgBEgQEAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEABAAAAEhhc2gBAYIBAC4ARIIB" +
           "AAAAD/////8BAf////8AAAAABGGCCgQAAAABAAUAAABDbGVhcgEBZwEALwEBZwFnAQAAAQH/////AAAA" +
           "AA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public PropertyState<LocalizedText> Manufacturer
        {
            get => m_manufacturer;

            set
            {
                if (!Object.ReferenceEquals(m_manufacturer, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manufacturer = value;
            }
        }

        public PropertyState<string> ManufacturerUri
        {
            get => m_manufacturerUri;

            set
            {
                if (!Object.ReferenceEquals(m_manufacturerUri, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manufacturerUri = value;
            }
        }

        public PropertyState<string> SoftwareRevision
        {
            get => m_softwareRevision;

            set
            {
                if (!Object.ReferenceEquals(m_softwareRevision, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_softwareRevision = value;
            }
        }

        public PropertyState<string[]> PatchIdentifiers
        {
            get => m_patchIdentifiers;

            set
            {
                if (!Object.ReferenceEquals(m_patchIdentifiers, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_patchIdentifiers = value;
            }
        }

        public PropertyState<DateTime> ReleaseDate
        {
            get => m_releaseDate;

            set
            {
                if (!Object.ReferenceEquals(m_releaseDate, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_releaseDate = value;
            }
        }

        public PropertyState<string> ChangeLogReference
        {
            get => m_changeLogReference;

            set
            {
                if (!Object.ReferenceEquals(m_changeLogReference, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_changeLogReference = value;
            }
        }

        public PropertyState<byte[]> Hash
        {
            get => m_hash;

            set
            {
                if (!Object.ReferenceEquals(m_hash, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_hash = value;
            }
        }

        public MethodState Clear
        {
            get => m_clearMethod;

            set
            {
                if (!Object.ReferenceEquals(m_clearMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_clearMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_manufacturer != null)
            {
                children.Add(m_manufacturer);
            }

            if (m_manufacturerUri != null)
            {
                children.Add(m_manufacturerUri);
            }

            if (m_softwareRevision != null)
            {
                children.Add(m_softwareRevision);
            }

            if (m_patchIdentifiers != null)
            {
                children.Add(m_patchIdentifiers);
            }

            if (m_releaseDate != null)
            {
                children.Add(m_releaseDate);
            }

            if (m_changeLogReference != null)
            {
                children.Add(m_changeLogReference);
            }

            if (m_hash != null)
            {
                children.Add(m_hash);
            }

            if (m_clearMethod != null)
            {
                children.Add(m_clearMethod);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_manufacturer, child))
            {
                m_manufacturer = null;
                return;
            }

            if (Object.ReferenceEquals(m_manufacturerUri, child))
            {
                m_manufacturerUri = null;
                return;
            }

            if (Object.ReferenceEquals(m_softwareRevision, child))
            {
                m_softwareRevision = null;
                return;
            }

            if (Object.ReferenceEquals(m_patchIdentifiers, child))
            {
                m_patchIdentifiers = null;
                return;
            }

            if (Object.ReferenceEquals(m_releaseDate, child))
            {
                m_releaseDate = null;
                return;
            }

            if (Object.ReferenceEquals(m_changeLogReference, child))
            {
                m_changeLogReference = null;
                return;
            }

            if (Object.ReferenceEquals(m_hash, child))
            {
                m_hash = null;
                return;
            }

            if (Object.ReferenceEquals(m_clearMethod, child))
            {
                m_clearMethod = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.Manufacturer:
                {
                    if (createOrReplace)
                    {
                        if (Manufacturer == null)
                        {
                            if (replacement == null)
                            {
                                Manufacturer = new PropertyState<LocalizedText>(this);
                            }
                            else
                            {
                                Manufacturer = (PropertyState<LocalizedText>)replacement;
                            }
                        }
                    }

                    instance = Manufacturer;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.ManufacturerUri:
                {
                    if (createOrReplace)
                    {
                        if (ManufacturerUri == null)
                        {
                            if (replacement == null)
                            {
                                ManufacturerUri = new PropertyState<string>(this);
                            }
                            else
                            {
                                ManufacturerUri = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ManufacturerUri;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.SoftwareRevision:
                {
                    if (createOrReplace)
                    {
                        if (SoftwareRevision == null)
                        {
                            if (replacement == null)
                            {
                                SoftwareRevision = new PropertyState<string>(this);
                            }
                            else
                            {
                                SoftwareRevision = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SoftwareRevision;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.PatchIdentifiers:
                {
                    if (createOrReplace)
                    {
                        if (PatchIdentifiers == null)
                        {
                            if (replacement == null)
                            {
                                PatchIdentifiers = new PropertyState<string[]>(this);
                            }
                            else
                            {
                                PatchIdentifiers = (PropertyState<string[]>)replacement;
                            }
                        }
                    }

                    instance = PatchIdentifiers;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.ReleaseDate:
                {
                    if (createOrReplace)
                    {
                        if (ReleaseDate == null)
                        {
                            if (replacement == null)
                            {
                                ReleaseDate = new PropertyState<DateTime>(this);
                            }
                            else
                            {
                                ReleaseDate = (PropertyState<DateTime>)replacement;
                            }
                        }
                    }

                    instance = ReleaseDate;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.ChangeLogReference:
                {
                    if (createOrReplace)
                    {
                        if (ChangeLogReference == null)
                        {
                            if (replacement == null)
                            {
                                ChangeLogReference = new PropertyState<string>(this);
                            }
                            else
                            {
                                ChangeLogReference = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ChangeLogReference;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.Hash:
                {
                    if (createOrReplace)
                    {
                        if (Hash == null)
                        {
                            if (replacement == null)
                            {
                                Hash = new PropertyState<byte[]>(this);
                            }
                            else
                            {
                                Hash = (PropertyState<byte[]>)replacement;
                            }
                        }
                    }

                    instance = Hash;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.Clear:
                {
                    if (createOrReplace)
                    {
                        if (Clear == null)
                        {
                            if (replacement == null)
                            {
                                Clear = new MethodState(this);
                            }
                            else
                            {
                                Clear = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Clear;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<LocalizedText> m_manufacturer;
        private PropertyState<string> m_manufacturerUri;
        private PropertyState<string> m_softwareRevision;
        private PropertyState<string[]> m_patchIdentifiers;
        private PropertyState<DateTime> m_releaseDate;
        private PropertyState<string> m_changeLogReference;
        private PropertyState<byte[]> m_hash;
        private MethodState m_clearMethod;
        #endregion
    }
    #endif
    #endregion

    #region SoftwareFolderTypeState Class
    #if (!OPCUA_EXCLUDE_SoftwareFolderTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class SoftwareFolderTypeState : FolderState
    {
        #region Constructors
        public SoftwareFolderTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.SoftwareFolderType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAaAAAAU29m" +
           "dHdhcmVGb2xkZXJUeXBlSW5zdGFuY2UBAWwBAQFsAWwBAAD/////AwAAABVgiQoCAAAAAQANAAAAU29m" +
           "dHdhcmVDbGFzcwEBbQEALgBEbQEAAAEBmAH/////AQH/////AAAAAARhggoEAAAAAQADAAAAQWRkAQGT" +
           "AQAvAQGTAZMBAAABAf////8BAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBlAEALgBElAEA" +
           "AJYCAAAAAQAqAQEXAAAACAAAAFN1YmNsYXNzAAz/////AAAAAAABACoBARMAAAAEAAAATmFtZQAM////" +
           "/wAAAAAAAQAoAQEAAAABAAAAAgAAAAEB/////wAAAAAEYYIKBAAAAAEABgAAAERlbGV0ZQEBlQEALwEB" +
           "lQGVAQAAAQH/////AQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAZYBAC4ARJYBAACWAQAA" +
           "AAEAKgEBHQAAAA4AAABPYmplY3RUb0RlbGV0ZQAR/////wAAAAAAAQAoAQEAAAABAAAAAQAAAAEB////" +
           "/wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public PropertyState<SoftwareClass> SoftwareClass
        {
            get => m_softwareClass;

            set
            {
                if (!Object.ReferenceEquals(m_softwareClass, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_softwareClass = value;
            }
        }

        public AddMethodState Add
        {
            get => m_addMethod;

            set
            {
                if (!Object.ReferenceEquals(m_addMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_addMethod = value;
            }
        }

        public new DeleteMethodState Delete
        {
            get => m_deleteMethod;

            set
            {
                if (!Object.ReferenceEquals(m_deleteMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_deleteMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_softwareClass != null)
            {
                children.Add(m_softwareClass);
            }

            if (m_addMethod != null)
            {
                children.Add(m_addMethod);
            }

            if (m_deleteMethod != null)
            {
                children.Add(m_deleteMethod);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_softwareClass, child))
            {
                m_softwareClass = null;
                return;
            }

            if (Object.ReferenceEquals(m_addMethod, child))
            {
                m_addMethod = null;
                return;
            }

            if (Object.ReferenceEquals(m_deleteMethod, child))
            {
                m_deleteMethod = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.SoftwareClass:
                {
                    if (createOrReplace)
                    {
                        if (SoftwareClass == null)
                        {
                            if (replacement == null)
                            {
                                SoftwareClass = new PropertyState<SoftwareClass>(this);
                            }
                            else
                            {
                                SoftwareClass = (PropertyState<SoftwareClass>)replacement;
                            }
                        }
                    }

                    instance = SoftwareClass;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.Add:
                {
                    if (createOrReplace)
                    {
                        if (Add == null)
                        {
                            if (replacement == null)
                            {
                                Add = new AddMethodState(this);
                            }
                            else
                            {
                                Add = (AddMethodState)replacement;
                            }
                        }
                    }

                    instance = Add;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.Delete:
                {
                    if (createOrReplace)
                    {
                        if (Delete == null)
                        {
                            if (replacement == null)
                            {
                                Delete = new DeleteMethodState(this);
                            }
                            else
                            {
                                Delete = (DeleteMethodState)replacement;
                            }
                        }
                    }

                    instance = Delete;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<SoftwareClass> m_softwareClass;
        private AddMethodState m_addMethod;
        private DeleteMethodState m_deleteMethod;
        #endregion
    }
    #endif
    #endregion

    #region PrepareForUpdateStateMachineTypeState Class
    #if (!OPCUA_EXCLUDE_PrepareForUpdateStateMachineTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class PrepareForUpdateStateMachineTypeState : FiniteStateMachineState
    {
        #region Constructors
        public PrepareForUpdateStateMachineTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.PrepareForUpdateStateMachineType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (PercentComplete != null)
            {
                PercentComplete.Initialize(context, PercentComplete_InitializationString);
            }

            if (Resume != null)
            {
                Resume.Initialize(context, Resume_InitializationString);
            }
        }

        #region Initialization String
        private const string PercentComplete_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAPAAAAUGVy" +
           "Y2VudENvbXBsZXRlAQHjAAAvAD/jAAAAAAP/////AQH/////AAAAAA==";

        private const string Resume_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAGAAAAUmVz" +
           "dW1lAQHmAAAvAQHmAOYAAAABAQEAAAAANQEBAfUAAAAAAA==";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAoAAAAUHJl" +
           "cGFyZUZvclVwZGF0ZVN0YXRlTWFjaGluZVR5cGVJbnN0YW5jZQEB1QABAdUA1QAAAP////8OAAAAFWCJ" +
           "CAIAAAAAAAwAAABDdXJyZW50U3RhdGUBAQAAAC8BAMgKABX/////AQH/////AQAAABVgiQgCAAAAAAAC" +
           "AAAASWQBAQAAAC4ARAAR/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAFBlcmNlbnRDb21wbGV0ZQEB" +
           "4wAALwA/4wAAAAAD/////wEB/////wAAAAAEYYIKBAAAAAEABwAAAFByZXBhcmUBAeQAAC8BAeQA5AAA" +
           "AAEBAQAAAAA1AQEB7wAAAAAABGGCCgQAAAABAAUAAABBYm9ydAEB5QAALwEB5QDlAAAAAQECAAAAADUB" +
           "AQHxAAA1AQEB9wAAAAAABGGCCgQAAAABAAYAAABSZXN1bWUBAeYAAC8BAeYA5gAAAAEBAQAAAAA1AQEB" +
           "9QAAAAAABGCACgEAAAABAAQAAABJZGxlAQHnAAAvAQAFCecAAAADAAAAADMBAQHvAAA0AQEB8QAANAEB" +
           "AfcAAQAAABVgqQoCAAAAAAALAAAAU3RhdGVOdW1iZXIBAegAAC4AROgAAAAHAQAAAAAH/////wEB////" +
           "/wAAAAAEYIAKAQAAAAEACQAAAFByZXBhcmluZwEB6QAALwEAAwnpAAAAAwAAAAA0AQEB7wAAMwEBAfEA" +
           "ADMBAQHzAAEAAAAVYKkKAgAAAAAACwAAAFN0YXRlTnVtYmVyAQHqAAAuAETqAAAABwIAAAAAB/////8B" +
           "Af////8AAAAABGCACgEAAAABABEAAABQcmVwYXJlZEZvclVwZGF0ZQEB6wAALwEAAwnrAAAAAgAAAAA0" +
           "AQEB8wAAMwEBAfUAAQAAABVgqQoCAAAAAAALAAAAU3RhdGVOdW1iZXIBAewAAC4AROwAAAAHAwAAAAAH" +
           "/////wEB/////wAAAAAEYIAKAQAAAAEACAAAAFJlc3VtaW5nAQHtAAAvAQADCe0AAAACAAAAADQBAQH1" +
           "AAAzAQEB9wABAAAAFWCpCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEB7gAALgBE7gAAAAcEAAAAAAf/////" +
           "AQH/////AAAAAARggAoBAAAAAQAPAAAASWRsZVRvUHJlcGFyaW5nAQHvAAAvAQAGCe8AAAAEAAAAADUA" +
           "AQHkAAAzAAEB5wAANAABAekAADYAAQAHCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIB" +
           "AfAAAC4ARPAAAAAHDAAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAEADwAAAFByZXBhcmluZ1RvSWRs" +
           "ZQEB8QAALwEABgnxAAAABAAAAAA1AAEB5QAANAABAecAADMAAQHpAAA2AAEABwkBAAAAFWCpCgIAAAAA" +
           "ABAAAABUcmFuc2l0aW9uTnVtYmVyAQHyAAAuAETyAAAABxUAAAAAB/////8BAf////8AAAAABGCACgEA" +
           "AAABABwAAABQcmVwYXJpbmdUb1ByZXBhcmVkRm9yVXBkYXRlAQHzAAAvAQAGCfMAAAADAAAAADMAAQHp" +
           "AAA0AAEB6wAANgABAAcJAQAAABVgqQoCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEB9AAALgBE9AAA" +
           "AAcXAAAAAAf/////AQH/////AAAAAARggAoBAAAAAQAbAAAAUHJlcGFyZWRGb3JVcGRhdGVUb1Jlc3Vt" +
           "aW5nAQH1AAAvAQAGCfUAAAAEAAAAADUAAQHmAAAzAAEB6wAANAABAe0AADYAAQAHCQEAAAAVYKkKAgAA" +
           "AAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAfYAAC4ARPYAAAAHIgAAAAAH/////wEB/////wAAAAAEYIAK" +
           "AQAAAAEADgAAAFJlc3VtaW5nVG9JZGxlAQH3AAAvAQAGCfcAAAAEAAAAADUAAQHlAAA0AAEB5wAAMwAB" +
           "Ae0AADYAAQAHCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAfgAAC4ARPgAAAAHKQAA" +
           "AAAH/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public BaseDataVariableState<byte> PercentComplete
        {
            get => m_percentComplete;

            set
            {
                if (!Object.ReferenceEquals(m_percentComplete, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_percentComplete = value;
            }
        }

        public MethodState Prepare
        {
            get => m_prepareMethod;

            set
            {
                if (!Object.ReferenceEquals(m_prepareMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_prepareMethod = value;
            }
        }

        public MethodState Abort
        {
            get => m_abortMethod;

            set
            {
                if (!Object.ReferenceEquals(m_abortMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_abortMethod = value;
            }
        }

        public MethodState Resume
        {
            get => m_resumeMethod;

            set
            {
                if (!Object.ReferenceEquals(m_resumeMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resumeMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_percentComplete != null)
            {
                children.Add(m_percentComplete);
            }

            if (m_prepareMethod != null)
            {
                children.Add(m_prepareMethod);
            }

            if (m_abortMethod != null)
            {
                children.Add(m_abortMethod);
            }

            if (m_resumeMethod != null)
            {
                children.Add(m_resumeMethod);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_percentComplete, child))
            {
                m_percentComplete = null;
                return;
            }

            if (Object.ReferenceEquals(m_prepareMethod, child))
            {
                m_prepareMethod = null;
                return;
            }

            if (Object.ReferenceEquals(m_abortMethod, child))
            {
                m_abortMethod = null;
                return;
            }

            if (Object.ReferenceEquals(m_resumeMethod, child))
            {
                m_resumeMethod = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.PercentComplete:
                {
                    if (createOrReplace)
                    {
                        if (PercentComplete == null)
                        {
                            if (replacement == null)
                            {
                                PercentComplete = new BaseDataVariableState<byte>(this);
                            }
                            else
                            {
                                PercentComplete = (BaseDataVariableState<byte>)replacement;
                            }
                        }
                    }

                    instance = PercentComplete;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.Prepare:
                {
                    if (createOrReplace)
                    {
                        if (Prepare == null)
                        {
                            if (replacement == null)
                            {
                                Prepare = new MethodState(this);
                            }
                            else
                            {
                                Prepare = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Prepare;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.Abort:
                {
                    if (createOrReplace)
                    {
                        if (Abort == null)
                        {
                            if (replacement == null)
                            {
                                Abort = new MethodState(this);
                            }
                            else
                            {
                                Abort = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Abort;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.Resume:
                {
                    if (createOrReplace)
                    {
                        if (Resume == null)
                        {
                            if (replacement == null)
                            {
                                Resume = new MethodState(this);
                            }
                            else
                            {
                                Resume = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Resume;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<byte> m_percentComplete;
        private MethodState m_prepareMethod;
        private MethodState m_abortMethod;
        private MethodState m_resumeMethod;
        #endregion
    }
    #endif
    #endregion

    #region InstallationStateMachineTypeState Class
    #if (!OPCUA_EXCLUDE_InstallationStateMachineTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class InstallationStateMachineTypeState : FiniteStateMachineState
    {
        #region Constructors
        public InstallationStateMachineTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.InstallationStateMachineType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);

            if (PercentComplete != null)
            {
                PercentComplete.Initialize(context, PercentComplete_InitializationString);
            }

            if (InstallationDelay != null)
            {
                InstallationDelay.Initialize(context, InstallationDelay_InitializationString);
            }

            if (InstallSoftwarePackage != null)
            {
                InstallSoftwarePackage.Initialize(context, InstallSoftwarePackage_InitializationString);
            }

            if (InstallFiles != null)
            {
                InstallFiles.Initialize(context, InstallFiles_InitializationString);
            }

            if (Uninstall != null)
            {
                Uninstall.Initialize(context, Uninstall_InitializationString);
            }
        }

        #region Initialization String
        private const string PercentComplete_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQAPAAAAUGVy" +
           "Y2VudENvbXBsZXRlAQEHAQAvAD8HAQAAAAP/////AQH/////AAAAAA==";

        private const string InstallationDelay_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////xVgiQoCAAAAAQARAAAASW5z" +
           "dGFsbGF0aW9uRGVsYXkBAQgBAC8APwgBAAABACIB/////wEB/////wAAAAA=";

        private const string InstallSoftwarePackage_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAWAAAASW5z" +
           "dGFsbFNvZnR3YXJlUGFja2FnZQEBCQEALwEBCQEJAQAAAQEBAAAAADUBAQEVAQEAAAAXYKkKAgAAAAAA" +
           "DgAAAElucHV0QXJndW1lbnRzAQEKAQAuAEQKAQAAlgQAAAABACoBAR4AAAAPAAAATWFudWZhY3R1cmVy" +
           "VXJpAAz/////AAAAAAABACoBAR8AAAAQAAAAU29mdHdhcmVSZXZpc2lvbgAM/////wAAAAAAAQAqAQEj" +
           "AAAAEAAAAFBhdGNoSWRlbnRpZmllcnMADAEAAAABAAAAAAAAAAABACoBARMAAAAEAAAASGFzaAAP////" +
           "/wAAAAAAAQAoAQEAAAABAAAABAAAAAEB/////wAAAAA=";

        private const string InstallFiles_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAMAAAASW5z" +
           "dGFsbEZpbGVzAQEMAQAvAQEMAQwBAAABAQEAAAAANQEBARUBAQAAABdgqQoCAAAAAAAOAAAASW5wdXRB" +
           "cmd1bWVudHMBAQ0BAC4ARA0BAACWAQAAAAEAKgEBGgAAAAcAAABOb2RlSWRzABEBAAAAAQAAAAAAAAAA" +
           "AQAoAQEAAAABAAAAAQAAAAEB/////wAAAAA=";

        private const string Uninstall_InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggoEAAAAAQAJAAAAVW5p" +
           "bnN0YWxsAQGXAQAvAQGXAZcBAAABAQEAAAAANQEBARUBAAAAAA==";

        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAkAAAASW5z" +
           "dGFsbGF0aW9uU3RhdGVNYWNoaW5lVHlwZUluc3RhbmNlAQH5AAEB+QD5AAAA/////w4AAAAVYIkIAgAA" +
           "AAAADAAAAEN1cnJlbnRTdGF0ZQEBAAAALwEAyAoAFf////8BAf////8BAAAAFWCJCAIAAAAAAAIAAABJ" +
           "ZAEBAAAALgBEABH/////AQH/////AAAAABVgiQoCAAAAAQAPAAAAUGVyY2VudENvbXBsZXRlAQEHAQAv" +
           "AD8HAQAAAAP/////AQH/////AAAAABVgiQoCAAAAAQARAAAASW5zdGFsbGF0aW9uRGVsYXkBAQgBAC8A" +
           "PwgBAAABACIB/////wEB/////wAAAAAEYYIKBAAAAAEAFgAAAEluc3RhbGxTb2Z0d2FyZVBhY2thZ2UB" +
           "AQkBAC8BAQkBCQEAAAEBAQAAAAA1AQEBFQEBAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB" +
           "CgEALgBECgEAAJYEAAAAAQAqAQEeAAAADwAAAE1hbnVmYWN0dXJlclVyaQAM/////wAAAAAAAQAqAQEf" +
           "AAAAEAAAAFNvZnR3YXJlUmV2aXNpb24ADP////8AAAAAAAEAKgEBIwAAABAAAABQYXRjaElkZW50aWZp" +
           "ZXJzAAwBAAAAAQAAAAAAAAAAAQAqAQETAAAABAAAAEhhc2gAD/////8AAAAAAAEAKAEBAAAAAQAAAAQA" +
           "AAABAf////8AAAAABGGCCgQAAAABAAwAAABJbnN0YWxsRmlsZXMBAQwBAC8BAQwBDAEAAAEBAQAAAAA1" +
           "AQEBFQEBAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBDQEALgBEDQEAAJYBAAAAAQAqAQEa" +
           "AAAABwAAAE5vZGVJZHMAEQEAAAABAAAAAAAAAAABACgBAQAAAAEAAAABAAAAAQH/////AAAAAARhggoE" +
           "AAAAAQAJAAAAVW5pbnN0YWxsAQGXAQAvAQGXAZcBAAABAQEAAAAANQEBARUBAAAAAARhggoEAAAAAQAG" +
           "AAAAUmVzdW1lAQEOAQAvAQEOAQ4BAAABAQEAAAAANQEBARsBAAAAAARggAoBAAAAAQAEAAAASWRsZQEB" +
           "DwEALwEABQkPAQAAAwAAAAAzAQEBFQEANAEBARcBADQBAQEbAQEAAAAVYKkKAgAAAAAACwAAAFN0YXRl" +
           "TnVtYmVyAQEQAQAuAEQQAQAABwEAAAAAB/////8BAf////8AAAAABGCACgEAAAABAAoAAABJbnN0YWxs" +
           "aW5nAQERAQAvAQADCREBAAADAAAAADQBAQEVAQAzAQEBFwEAMwEBARkBAQAAABVgqQoCAAAAAAALAAAA" +
           "U3RhdGVOdW1iZXIBARIBAC4ARBIBAAAHAgAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAEABQAAAEVy" +
           "cm9yAQETAQAvAQADCRMBAAACAAAAADQBAQEZAQAzAQEBGwEBAAAAFWCpCgIAAAAAAAsAAABTdGF0ZU51" +
           "bWJlcgEBFAEALgBEFAEAAAcDAAAAAAf/////AQH/////AAAAAARggAoBAAAAAQAQAAAASWRsZVRvSW5z" +
           "dGFsbGluZwEBFQEALwEABgkVAQAABgAAAAA1AAEBCQEANQABAQwBADUAAQGXAQAzAAEBDwEANAABAREB" +
           "ADYAAQAHCQEAAAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAYMBAC4ARIMBAAAHDAAAAAAH" +
           "/////wEB/////wAAAAAEYIAKAQAAAAEAEAAAAEluc3RhbGxpbmdUb0lkbGUBARcBAC8BAAYJFwEAAAMA" +
           "AAAANAABAQ8BADMAAQERAQA2AAEABwkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQEY" +
           "AQAuAEQYAQAABxUAAAAAB/////8BAf////8AAAAABGCACgEAAAABABEAAABJbnN0YWxsaW5nVG9FcnJv" +
           "cgEBGQEALwEABgkZAQAAAwAAAAAzAAEBEQEANAABARMBADYAAQAHCQEAAAAVYKkKAgAAAAAAEAAAAFRy" +
           "YW5zaXRpb25OdW1iZXIBARoBAC4ARBoBAAAHFwAAAAAH/////wEB/////wAAAAAEYIAKAQAAAAEACwAA" +
           "AEVycm9yVG9JZGxlAQEbAQAvAQAGCRsBAAAEAAAAADUAAQEOAQA0AAEBDwEAMwABARMBADYAAQAHCQEA" +
           "AAAVYKkKAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBARwBAC4ARBwBAAAHHwAAAAAH/////wEB////" +
           "/wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public BaseDataVariableState<byte> PercentComplete
        {
            get => m_percentComplete;

            set
            {
                if (!Object.ReferenceEquals(m_percentComplete, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_percentComplete = value;
            }
        }

        public BaseDataVariableState<double> InstallationDelay
        {
            get => m_installationDelay;

            set
            {
                if (!Object.ReferenceEquals(m_installationDelay, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_installationDelay = value;
            }
        }

        public InstallSoftwarePackageMethodState InstallSoftwarePackage
        {
            get => m_installSoftwarePackageMethod;

            set
            {
                if (!Object.ReferenceEquals(m_installSoftwarePackageMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_installSoftwarePackageMethod = value;
            }
        }

        public InstallFilesMethodState InstallFiles
        {
            get => m_installFilesMethod;

            set
            {
                if (!Object.ReferenceEquals(m_installFilesMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_installFilesMethod = value;
            }
        }

        public MethodState Uninstall
        {
            get => m_uninstallMethod;

            set
            {
                if (!Object.ReferenceEquals(m_uninstallMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_uninstallMethod = value;
            }
        }

        public MethodState Resume
        {
            get => m_resumeMethod;

            set
            {
                if (!Object.ReferenceEquals(m_resumeMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_resumeMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_percentComplete != null)
            {
                children.Add(m_percentComplete);
            }

            if (m_installationDelay != null)
            {
                children.Add(m_installationDelay);
            }

            if (m_installSoftwarePackageMethod != null)
            {
                children.Add(m_installSoftwarePackageMethod);
            }

            if (m_installFilesMethod != null)
            {
                children.Add(m_installFilesMethod);
            }

            if (m_uninstallMethod != null)
            {
                children.Add(m_uninstallMethod);
            }

            if (m_resumeMethod != null)
            {
                children.Add(m_resumeMethod);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_percentComplete, child))
            {
                m_percentComplete = null;
                return;
            }

            if (Object.ReferenceEquals(m_installationDelay, child))
            {
                m_installationDelay = null;
                return;
            }

            if (Object.ReferenceEquals(m_installSoftwarePackageMethod, child))
            {
                m_installSoftwarePackageMethod = null;
                return;
            }

            if (Object.ReferenceEquals(m_installFilesMethod, child))
            {
                m_installFilesMethod = null;
                return;
            }

            if (Object.ReferenceEquals(m_uninstallMethod, child))
            {
                m_uninstallMethod = null;
                return;
            }

            if (Object.ReferenceEquals(m_resumeMethod, child))
            {
                m_resumeMethod = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.PercentComplete:
                {
                    if (createOrReplace)
                    {
                        if (PercentComplete == null)
                        {
                            if (replacement == null)
                            {
                                PercentComplete = new BaseDataVariableState<byte>(this);
                            }
                            else
                            {
                                PercentComplete = (BaseDataVariableState<byte>)replacement;
                            }
                        }
                    }

                    instance = PercentComplete;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.InstallationDelay:
                {
                    if (createOrReplace)
                    {
                        if (InstallationDelay == null)
                        {
                            if (replacement == null)
                            {
                                InstallationDelay = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                InstallationDelay = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = InstallationDelay;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.InstallSoftwarePackage:
                {
                    if (createOrReplace)
                    {
                        if (InstallSoftwarePackage == null)
                        {
                            if (replacement == null)
                            {
                                InstallSoftwarePackage = new InstallSoftwarePackageMethodState(this);
                            }
                            else
                            {
                                InstallSoftwarePackage = (InstallSoftwarePackageMethodState)replacement;
                            }
                        }
                    }

                    instance = InstallSoftwarePackage;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.InstallFiles:
                {
                    if (createOrReplace)
                    {
                        if (InstallFiles == null)
                        {
                            if (replacement == null)
                            {
                                InstallFiles = new InstallFilesMethodState(this);
                            }
                            else
                            {
                                InstallFiles = (InstallFilesMethodState)replacement;
                            }
                        }
                    }

                    instance = InstallFiles;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.Uninstall:
                {
                    if (createOrReplace)
                    {
                        if (Uninstall == null)
                        {
                            if (replacement == null)
                            {
                                Uninstall = new MethodState(this);
                            }
                            else
                            {
                                Uninstall = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Uninstall;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.Resume:
                {
                    if (createOrReplace)
                    {
                        if (Resume == null)
                        {
                            if (replacement == null)
                            {
                                Resume = new MethodState(this);
                            }
                            else
                            {
                                Resume = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Resume;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<byte> m_percentComplete;
        private BaseDataVariableState<double> m_installationDelay;
        private InstallSoftwarePackageMethodState m_installSoftwarePackageMethod;
        private InstallFilesMethodState m_installFilesMethod;
        private MethodState m_uninstallMethod;
        private MethodState m_resumeMethod;
        #endregion
    }
    #endif
    #endregion

    #region PowerCycleStateMachineTypeState Class
    #if (!OPCUA_EXCLUDE_PowerCycleStateMachineTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class PowerCycleStateMachineTypeState : FiniteStateMachineState
    {
        #region Constructors
        public PowerCycleStateMachineTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.PowerCycleStateMachineType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAiAAAAUG93" +
           "ZXJDeWNsZVN0YXRlTWFjaGluZVR5cGVJbnN0YW5jZQEBHQEBAR0BHQEAAP////8FAAAAFWCJCAIAAAAA" +
           "AAwAAABDdXJyZW50U3RhdGUBAQAAAC8BAMgKABX/////AQH/////AQAAABVgiQgCAAAAAAACAAAASWQB" +
           "AQAAAC4ARAAR/////wEB/////wAAAAAEYIAKAQAAAAEAFwAAAE5vdFdhaXRpbmdGb3JQb3dlckN5Y2xl" +
           "AQErAQAvAQAFCSsBAAACAAAAADMBAQEvAQA0AQEBMQEBAAAAFWCpCgIAAAAAAAsAAABTdGF0ZU51bWJl" +
           "cgEBLAEALgBELAEAAAcBAAAAAAf/////AQH/////AAAAAARggAoBAAAAAQAUAAAAV2FpdGluZ0ZvclBv" +
           "d2VyQ3ljbGUBAS0BAC8BAAMJLQEAAAIAAAAANAEBAS8BADMBAQExAQEAAAAVYKkKAgAAAAAACwAAAFN0" +
           "YXRlTnVtYmVyAQEuAQAuAEQuAQAABwIAAAAAB/////8BAf////8AAAAABGCACgEAAAABAC0AAABOb3RX" +
           "YWl0aW5nRm9yUG93ZXJDeWNsZVRvV2FpdGluZ0ZvclBvd2VyQ3ljbGUBAS8BAC8BAAYJLwEAAAMAAAAA" +
           "MwABASsBADQAAQEtAQA2AAEABwkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQEwAQAu" +
           "AEQwAQAABwwAAAAAB/////8BAf////8AAAAABGCACgEAAAABAC0AAABXYWl0aW5nRm9yUG93ZXJDeWNs" +
           "ZVRvTm90V2FpdGluZ0ZvclBvd2VyQ3ljbGUBATEBAC8BAAYJMQEAAAMAAAAANAABASsBADMAAQEtAQA2" +
           "AAEABwkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQEyAQAuAEQyAQAABxUAAAAAB///" +
           "//8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ConfirmationStateMachineTypeState Class
    #if (!OPCUA_EXCLUDE_ConfirmationStateMachineTypeState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class ConfirmationStateMachineTypeState : FiniteStateMachineState
    {
        #region Constructors
        public ConfirmationStateMachineTypeState(NodeState parent) : base(parent)
        {
        }

        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.DI.ObjectTypes.ConfirmationStateMachineType, Opc.Ua.DI.Namespaces.DI, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRggAIBAAAAAQAkAAAAQ29u" +
           "ZmlybWF0aW9uU3RhdGVNYWNoaW5lVHlwZUluc3RhbmNlAQEzAQEBMwEzAQAA/////wcAAAAVYIkIAgAA" +
           "AAAADAAAAEN1cnJlbnRTdGF0ZQEBAAAALwEAyAoAFf////8BAf////8BAAAAFWCJCAIAAAAAAAIAAABJ" +
           "ZAEBAAAALgBEABH/////AQH/////AAAAAARhggoEAAAAAQAHAAAAQ29uZmlybQEBQQEALwEBQQFBAQAA" +
           "AQEBAAAAADUBAQFJAQAAAAAVYIkKAgAAAAEAEwAAAENvbmZpcm1hdGlvblRpbWVvdXQBAUIBAC8AP0IB" +
           "AAABACIB/////wEB/////wAAAAAEYIAKAQAAAAEAFAAAAE5vdFdhaXRpbmdGb3JDb25maXJtAQFDAQAv" +
           "AQAFCUMBAAACAAAAADMBAQFHAQA0AQEBSQEBAAAAFWCpCgIAAAAAAAsAAABTdGF0ZU51bWJlcgEBRAEA" +
           "LgBERAEAAAcBAAAAAAf/////AQH/////AAAAAARggAoBAAAAAQARAAAAV2FpdGluZ0ZvckNvbmZpcm0B" +
           "AUUBAC8BAAMJRQEAAAIAAAAANAEBAUcBADMBAQFJAQEAAAAVYKkKAgAAAAAACwAAAFN0YXRlTnVtYmVy" +
           "AQFGAQAuAERGAQAABwIAAAAAB/////8BAf////8AAAAABGCACgEAAAABACcAAABOb3RXYWl0aW5nRm9y" +
           "Q29uZmlybVRvV2FpdGluZ0ZvckNvbmZpcm0BAUcBAC8BAAYJRwEAAAMAAAAAMwABAUMBADQAAQFFAQA2" +
           "AAEABwkBAAAAFWCpCgIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQFIAQAuAERIAQAABwwAAAAAB///" +
           "//8BAf////8AAAAABGCACgEAAAABACcAAABXYWl0aW5nRm9yQ29uZmlybVRvTm90V2FpdGluZ0ZvckNv" +
           "bmZpcm0BAUkBAC8BAAYJSQEAAAQAAAAANQABAUEBADQAAQFDAQAzAAEBRQEANgABAAcJAQAAABVgqQoC" +
           "AAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBSgEALgBESgEAAAcVAAAAAAf/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        public MethodState Confirm
        {
            get => m_confirmMethod;

            set
            {
                if (!Object.ReferenceEquals(m_confirmMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_confirmMethod = value;
            }
        }

        public BaseDataVariableState<double> ConfirmationTimeout
        {
            get => m_confirmationTimeout;

            set
            {
                if (!Object.ReferenceEquals(m_confirmationTimeout, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_confirmationTimeout = value;
            }
        }
        #endregion

        #region Overridden Methods
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_confirmMethod != null)
            {
                children.Add(m_confirmMethod);
            }

            if (m_confirmationTimeout != null)
            {
                children.Add(m_confirmationTimeout);
            }

            base.GetChildren(context, children);
        }
            
        protected override void RemoveExplicitlyDefinedChild(BaseInstanceState child)
        {
            if (Object.ReferenceEquals(m_confirmMethod, child))
            {
                m_confirmMethod = null;
                return;
            }

            if (Object.ReferenceEquals(m_confirmationTimeout, child))
            {
                m_confirmationTimeout = null;
                return;
            }

            base.RemoveExplicitlyDefinedChild(child);
        }

        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case Opc.Ua.DI.BrowseNames.Confirm:
                {
                    if (createOrReplace)
                    {
                        if (Confirm == null)
                        {
                            if (replacement == null)
                            {
                                Confirm = new MethodState(this);
                            }
                            else
                            {
                                Confirm = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Confirm;
                    break;
                }

                case Opc.Ua.DI.BrowseNames.ConfirmationTimeout:
                {
                    if (createOrReplace)
                    {
                        if (ConfirmationTimeout == null)
                        {
                            if (replacement == null)
                            {
                                ConfirmationTimeout = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                ConfirmationTimeout = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = ConfirmationTimeout;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private MethodState m_confirmMethod;
        private BaseDataVariableState<double> m_confirmationTimeout;
        #endregion
    }
    #endif
    #endregion

    #region InitLockMethodState Class
    #if (!OPCUA_EXCLUDE_InitLockMethodState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class InitLockMethodState : MethodState
    {
        #region Constructors
        public InitLockMethodState(NodeState parent) : base(parent)
        {
        }

        public new static NodeState Construct(NodeState parent)
        {
            return new InitLockMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQASAAAASW5p" +
           "dExvY2tNZXRob2RUeXBlAQEAAAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        public InitLockMethodStateMethodCallHandler OnCall;

        public InitLockMethodStateMethodAsyncCallHandler OnCallAsync;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            string context = (string)_inputArguments[0];

            int initLockStatus = (int)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    context,
                    ref initLockStatus);
            }

            _outputArguments[0] = initLockStatus;

            return _result;
        }

        #if (OPCUA_INCLUDE_ASYNC)
        protected override async ValueTask<ServiceResult> CallAsync(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments,
            CancellationToken cancellationToken = default)
        {
            if (OnCall == null && OnCallAsync == null)
            {
                return await base.CallAsync(_context, _objectId, _inputArguments, _outputArguments, cancellationToken).ConfigureAwait(false);
            }

            InitLockMethodStateResult _result = null;

            string context = (string)_inputArguments[0];

            if (OnCallAsync != null)
            {
                _result = await OnCallAsync(
                    _context,
                    this,
                    _objectId,
                    context,
                    cancellationToken).ConfigureAwait(false);
            }
            else if (OnCall != null)
            {
                return Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            _outputArguments[0] = _result.InitLockStatus;

            return _result.ServiceResult;
        }
        #endif

        #endregion

        #region Private Fields
        #endregion
    }

    /// <exclude />
    public delegate ServiceResult InitLockMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        string context,
        ref int initLockStatus);

    /// <exclude />
    public partial class InitLockMethodStateResult
    {
        public ServiceResult ServiceResult { get; set; }
        public int InitLockStatus { get; set; }
    }

    /// <exclude />
    public delegate ValueTask<InitLockMethodStateResult> InitLockMethodStateMethodAsyncCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        string context,
        CancellationToken cancellationToken);
    #endif
    #endregion

    #region RenewLockMethodState Class
    #if (!OPCUA_EXCLUDE_RenewLockMethodState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class RenewLockMethodState : MethodState
    {
        #region Constructors
        public RenewLockMethodState(NodeState parent) : base(parent)
        {
        }

        public new static NodeState Construct(NodeState parent)
        {
            return new RenewLockMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQATAAAAUmVu" +
           "ZXdMb2NrTWV0aG9kVHlwZQEBAAABAQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        public RenewLockMethodStateMethodCallHandler OnCall;

        public RenewLockMethodStateMethodAsyncCallHandler OnCallAsync;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            int renewLockStatus = (int)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    ref renewLockStatus);
            }

            _outputArguments[0] = renewLockStatus;

            return _result;
        }

        #if (OPCUA_INCLUDE_ASYNC)
        protected override async ValueTask<ServiceResult> CallAsync(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments,
            CancellationToken cancellationToken = default)
        {
            if (OnCall == null && OnCallAsync == null)
            {
                return await base.CallAsync(_context, _objectId, _inputArguments, _outputArguments, cancellationToken).ConfigureAwait(false);
            }

            RenewLockMethodStateResult _result = null;

            if (OnCallAsync != null)
            {
                _result = await OnCallAsync(
                    _context,
                    this,
                    _objectId,
                    cancellationToken).ConfigureAwait(false);
            }
            else if (OnCall != null)
            {
                return Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            _outputArguments[0] = _result.RenewLockStatus;

            return _result.ServiceResult;
        }
        #endif

        #endregion

        #region Private Fields
        #endregion
    }

    /// <exclude />
    public delegate ServiceResult RenewLockMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ref int renewLockStatus);

    /// <exclude />
    public partial class RenewLockMethodStateResult
    {
        public ServiceResult ServiceResult { get; set; }
        public int RenewLockStatus { get; set; }
    }

    /// <exclude />
    public delegate ValueTask<RenewLockMethodStateResult> RenewLockMethodStateMethodAsyncCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        CancellationToken cancellationToken);
    #endif
    #endregion

    #region ExitLockMethodState Class
    #if (!OPCUA_EXCLUDE_ExitLockMethodState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class ExitLockMethodState : MethodState
    {
        #region Constructors
        public ExitLockMethodState(NodeState parent) : base(parent)
        {
        }

        public new static NodeState Construct(NodeState parent)
        {
            return new ExitLockMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQASAAAARXhp" +
           "dExvY2tNZXRob2RUeXBlAQEAAAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        public ExitLockMethodStateMethodCallHandler OnCall;

        public ExitLockMethodStateMethodAsyncCallHandler OnCallAsync;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            int exitLockStatus = (int)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    ref exitLockStatus);
            }

            _outputArguments[0] = exitLockStatus;

            return _result;
        }

        #if (OPCUA_INCLUDE_ASYNC)
        protected override async ValueTask<ServiceResult> CallAsync(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments,
            CancellationToken cancellationToken = default)
        {
            if (OnCall == null && OnCallAsync == null)
            {
                return await base.CallAsync(_context, _objectId, _inputArguments, _outputArguments, cancellationToken).ConfigureAwait(false);
            }

            ExitLockMethodStateResult _result = null;

            if (OnCallAsync != null)
            {
                _result = await OnCallAsync(
                    _context,
                    this,
                    _objectId,
                    cancellationToken).ConfigureAwait(false);
            }
            else if (OnCall != null)
            {
                return Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            _outputArguments[0] = _result.ExitLockStatus;

            return _result.ServiceResult;
        }
        #endif

        #endregion

        #region Private Fields
        #endregion
    }

    /// <exclude />
    public delegate ServiceResult ExitLockMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ref int exitLockStatus);

    /// <exclude />
    public partial class ExitLockMethodStateResult
    {
        public ServiceResult ServiceResult { get; set; }
        public int ExitLockStatus { get; set; }
    }

    /// <exclude />
    public delegate ValueTask<ExitLockMethodStateResult> ExitLockMethodStateMethodAsyncCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        CancellationToken cancellationToken);
    #endif
    #endregion

    #region BreakLockMethodState Class
    #if (!OPCUA_EXCLUDE_BreakLockMethodState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class BreakLockMethodState : MethodState
    {
        #region Constructors
        public BreakLockMethodState(NodeState parent) : base(parent)
        {
        }

        public new static NodeState Construct(NodeState parent)
        {
            return new BreakLockMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQATAAAAQnJl" +
           "YWtMb2NrTWV0aG9kVHlwZQEBAAABAQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        public BreakLockMethodStateMethodCallHandler OnCall;

        public BreakLockMethodStateMethodAsyncCallHandler OnCallAsync;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            int breakLockStatus = (int)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    ref breakLockStatus);
            }

            _outputArguments[0] = breakLockStatus;

            return _result;
        }

        #if (OPCUA_INCLUDE_ASYNC)
        protected override async ValueTask<ServiceResult> CallAsync(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments,
            CancellationToken cancellationToken = default)
        {
            if (OnCall == null && OnCallAsync == null)
            {
                return await base.CallAsync(_context, _objectId, _inputArguments, _outputArguments, cancellationToken).ConfigureAwait(false);
            }

            BreakLockMethodStateResult _result = null;

            if (OnCallAsync != null)
            {
                _result = await OnCallAsync(
                    _context,
                    this,
                    _objectId,
                    cancellationToken).ConfigureAwait(false);
            }
            else if (OnCall != null)
            {
                return Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            _outputArguments[0] = _result.BreakLockStatus;

            return _result.ServiceResult;
        }
        #endif

        #endregion

        #region Private Fields
        #endregion
    }

    /// <exclude />
    public delegate ServiceResult BreakLockMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ref int breakLockStatus);

    /// <exclude />
    public partial class BreakLockMethodStateResult
    {
        public ServiceResult ServiceResult { get; set; }
        public int BreakLockStatus { get; set; }
    }

    /// <exclude />
    public delegate ValueTask<BreakLockMethodStateResult> BreakLockMethodStateMethodAsyncCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        CancellationToken cancellationToken);
    #endif
    #endregion

    #region StartLocationIndicationMethodState Class
    #if (!OPCUA_EXCLUDE_StartLocationIndicationMethodState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class StartLocationIndicationMethodState : MethodState
    {
        #region Constructors
        public StartLocationIndicationMethodState(NodeState parent) : base(parent)
        {
        }

        public new static NodeState Construct(NodeState parent)
        {
            return new StartLocationIndicationMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQAhAAAAU3Rh" +
           "cnRMb2NhdGlvbkluZGljYXRpb25NZXRob2RUeXBlAQEAAAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        public StartLocationIndicationMethodStateMethodCallHandler OnCall;

        public StartLocationIndicationMethodStateMethodAsyncCallHandler OnCallAsync;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            double indicationDuration = (double)_inputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    indicationDuration);
            }

            return _result;
        }

        #if (OPCUA_INCLUDE_ASYNC)
        protected override async ValueTask<ServiceResult> CallAsync(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments,
            CancellationToken cancellationToken = default)
        {
            if (OnCall == null && OnCallAsync == null)
            {
                return await base.CallAsync(_context, _objectId, _inputArguments, _outputArguments, cancellationToken).ConfigureAwait(false);
            }

            StartLocationIndicationMethodStateResult _result = null;

            double indicationDuration = (double)_inputArguments[0];

            if (OnCallAsync != null)
            {
                _result = await OnCallAsync(
                    _context,
                    this,
                    _objectId,
                    indicationDuration,
                    cancellationToken).ConfigureAwait(false);
            }
            else if (OnCall != null)
            {
                return Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            return _result.ServiceResult;
        }
        #endif

        #endregion

        #region Private Fields
        #endregion
    }

    /// <exclude />
    public delegate ServiceResult StartLocationIndicationMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        double indicationDuration);

    /// <exclude />
    public partial class StartLocationIndicationMethodStateResult
    {
        public ServiceResult ServiceResult { get; set; }
    }

    /// <exclude />
    public delegate ValueTask<StartLocationIndicationMethodStateResult> StartLocationIndicationMethodStateMethodAsyncCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        double indicationDuration,
        CancellationToken cancellationToken);
    #endif
    #endregion

    #region TransferToDeviceMethodState Class
    #if (!OPCUA_EXCLUDE_TransferToDeviceMethodState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class TransferToDeviceMethodState : MethodState
    {
        #region Constructors
        public TransferToDeviceMethodState(NodeState parent) : base(parent)
        {
        }

        public new static NodeState Construct(NodeState parent)
        {
            return new TransferToDeviceMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQAaAAAAVHJh" +
           "bnNmZXJUb0RldmljZU1ldGhvZFR5cGUBAQAAAQEAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        public TransferToDeviceMethodStateMethodCallHandler OnCall;

        public TransferToDeviceMethodStateMethodAsyncCallHandler OnCallAsync;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            int transferID = (int)_outputArguments[0];
            int initTransferStatus = (int)_outputArguments[1];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    ref transferID,
                    ref initTransferStatus);
            }

            _outputArguments[0] = transferID;
            _outputArguments[1] = initTransferStatus;

            return _result;
        }

        #if (OPCUA_INCLUDE_ASYNC)
        protected override async ValueTask<ServiceResult> CallAsync(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments,
            CancellationToken cancellationToken = default)
        {
            if (OnCall == null && OnCallAsync == null)
            {
                return await base.CallAsync(_context, _objectId, _inputArguments, _outputArguments, cancellationToken).ConfigureAwait(false);
            }

            TransferToDeviceMethodStateResult _result = null;

            if (OnCallAsync != null)
            {
                _result = await OnCallAsync(
                    _context,
                    this,
                    _objectId,
                    cancellationToken).ConfigureAwait(false);
            }
            else if (OnCall != null)
            {
                return Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            _outputArguments[0] = _result.TransferID;
            _outputArguments[1] = _result.InitTransferStatus;

            return _result.ServiceResult;
        }
        #endif

        #endregion

        #region Private Fields
        #endregion
    }

    /// <exclude />
    public delegate ServiceResult TransferToDeviceMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ref int transferID,
        ref int initTransferStatus);

    /// <exclude />
    public partial class TransferToDeviceMethodStateResult
    {
        public ServiceResult ServiceResult { get; set; }
        public int TransferID { get; set; }
        public int InitTransferStatus { get; set; }
    }

    /// <exclude />
    public delegate ValueTask<TransferToDeviceMethodStateResult> TransferToDeviceMethodStateMethodAsyncCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        CancellationToken cancellationToken);
    #endif
    #endregion

    #region TransferFromDeviceMethodState Class
    #if (!OPCUA_EXCLUDE_TransferFromDeviceMethodState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class TransferFromDeviceMethodState : MethodState
    {
        #region Constructors
        public TransferFromDeviceMethodState(NodeState parent) : base(parent)
        {
        }

        public new static NodeState Construct(NodeState parent)
        {
            return new TransferFromDeviceMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQAcAAAAVHJh" +
           "bnNmZXJGcm9tRGV2aWNlTWV0aG9kVHlwZQEBAAABAQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        public TransferFromDeviceMethodStateMethodCallHandler OnCall;

        public TransferFromDeviceMethodStateMethodAsyncCallHandler OnCallAsync;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            int transferID = (int)_outputArguments[0];
            int initTransferStatus = (int)_outputArguments[1];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    ref transferID,
                    ref initTransferStatus);
            }

            _outputArguments[0] = transferID;
            _outputArguments[1] = initTransferStatus;

            return _result;
        }

        #if (OPCUA_INCLUDE_ASYNC)
        protected override async ValueTask<ServiceResult> CallAsync(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments,
            CancellationToken cancellationToken = default)
        {
            if (OnCall == null && OnCallAsync == null)
            {
                return await base.CallAsync(_context, _objectId, _inputArguments, _outputArguments, cancellationToken).ConfigureAwait(false);
            }

            TransferFromDeviceMethodStateResult _result = null;

            if (OnCallAsync != null)
            {
                _result = await OnCallAsync(
                    _context,
                    this,
                    _objectId,
                    cancellationToken).ConfigureAwait(false);
            }
            else if (OnCall != null)
            {
                return Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            _outputArguments[0] = _result.TransferID;
            _outputArguments[1] = _result.InitTransferStatus;

            return _result.ServiceResult;
        }
        #endif

        #endregion

        #region Private Fields
        #endregion
    }

    /// <exclude />
    public delegate ServiceResult TransferFromDeviceMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        ref int transferID,
        ref int initTransferStatus);

    /// <exclude />
    public partial class TransferFromDeviceMethodStateResult
    {
        public ServiceResult ServiceResult { get; set; }
        public int TransferID { get; set; }
        public int InitTransferStatus { get; set; }
    }

    /// <exclude />
    public delegate ValueTask<TransferFromDeviceMethodStateResult> TransferFromDeviceMethodStateMethodAsyncCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        CancellationToken cancellationToken);
    #endif
    #endregion

    #region FetchTransferResultDataMethodState Class
    #if (!OPCUA_EXCLUDE_FetchTransferResultDataMethodState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class FetchTransferResultDataMethodState : MethodState
    {
        #region Constructors
        public FetchTransferResultDataMethodState(NodeState parent) : base(parent)
        {
        }

        public new static NodeState Construct(NodeState parent)
        {
            return new FetchTransferResultDataMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQAhAAAARmV0" +
           "Y2hUcmFuc2ZlclJlc3VsdERhdGFNZXRob2RUeXBlAQEAAAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        public FetchTransferResultDataMethodStateMethodCallHandler OnCall;

        public FetchTransferResultDataMethodStateMethodAsyncCallHandler OnCallAsync;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            int transferID = (int)_inputArguments[0];
            int sequenceNumber = (int)_inputArguments[1];
            int maxParameterResultsToReturn = (int)_inputArguments[2];
            bool omitGoodResults = (bool)_inputArguments[3];

            ExtensionObject fetchResultData = (ExtensionObject)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    transferID,
                    sequenceNumber,
                    maxParameterResultsToReturn,
                    omitGoodResults,
                    ref fetchResultData);
            }

            _outputArguments[0] = fetchResultData;

            return _result;
        }

        #if (OPCUA_INCLUDE_ASYNC)
        protected override async ValueTask<ServiceResult> CallAsync(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments,
            CancellationToken cancellationToken = default)
        {
            if (OnCall == null && OnCallAsync == null)
            {
                return await base.CallAsync(_context, _objectId, _inputArguments, _outputArguments, cancellationToken).ConfigureAwait(false);
            }

            FetchTransferResultDataMethodStateResult _result = null;

            int transferID = (int)_inputArguments[0];
            int sequenceNumber = (int)_inputArguments[1];
            int maxParameterResultsToReturn = (int)_inputArguments[2];
            bool omitGoodResults = (bool)_inputArguments[3];

            if (OnCallAsync != null)
            {
                _result = await OnCallAsync(
                    _context,
                    this,
                    _objectId,
                    transferID,
                    sequenceNumber,
                    maxParameterResultsToReturn,
                    omitGoodResults,
                    cancellationToken).ConfigureAwait(false);
            }
            else if (OnCall != null)
            {
                return Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            _outputArguments[0] = _result.FetchResultData;

            return _result.ServiceResult;
        }
        #endif

        #endregion

        #region Private Fields
        #endregion
    }

    /// <exclude />
    public delegate ServiceResult FetchTransferResultDataMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        int transferID,
        int sequenceNumber,
        int maxParameterResultsToReturn,
        bool omitGoodResults,
        ref ExtensionObject fetchResultData);

    /// <exclude />
    public partial class FetchTransferResultDataMethodStateResult
    {
        public ServiceResult ServiceResult { get; set; }
        public ExtensionObject FetchResultData { get; set; }
    }

    /// <exclude />
    public delegate ValueTask<FetchTransferResultDataMethodStateResult> FetchTransferResultDataMethodStateMethodAsyncCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        int transferID,
        int sequenceNumber,
        int maxParameterResultsToReturn,
        bool omitGoodResults,
        CancellationToken cancellationToken);
    #endif
    #endregion

    #region GetUpdateBehaviorMethodState Class
    #if (!OPCUA_EXCLUDE_GetUpdateBehaviorMethodState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class GetUpdateBehaviorMethodState : MethodState
    {
        #region Constructors
        public GetUpdateBehaviorMethodState(NodeState parent) : base(parent)
        {
        }

        public new static NodeState Construct(NodeState parent)
        {
            return new GetUpdateBehaviorMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQAbAAAAR2V0" +
           "VXBkYXRlQmVoYXZpb3JNZXRob2RUeXBlAQEAAAEBAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        public GetUpdateBehaviorMethodStateMethodCallHandler OnCall;

        public GetUpdateBehaviorMethodStateMethodAsyncCallHandler OnCallAsync;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            string manufacturerUri = (string)_inputArguments[0];
            string softwareRevision = (string)_inputArguments[1];
            string[] patchIdentifiers = (string[])_inputArguments[2];

            uint updateBehavior = (uint)_outputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    manufacturerUri,
                    softwareRevision,
                    patchIdentifiers,
                    ref updateBehavior);
            }

            _outputArguments[0] = updateBehavior;

            return _result;
        }

        #if (OPCUA_INCLUDE_ASYNC)
        protected override async ValueTask<ServiceResult> CallAsync(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments,
            CancellationToken cancellationToken = default)
        {
            if (OnCall == null && OnCallAsync == null)
            {
                return await base.CallAsync(_context, _objectId, _inputArguments, _outputArguments, cancellationToken).ConfigureAwait(false);
            }

            GetUpdateBehaviorMethodStateResult _result = null;

            string manufacturerUri = (string)_inputArguments[0];
            string softwareRevision = (string)_inputArguments[1];
            string[] patchIdentifiers = (string[])_inputArguments[2];

            if (OnCallAsync != null)
            {
                _result = await OnCallAsync(
                    _context,
                    this,
                    _objectId,
                    manufacturerUri,
                    softwareRevision,
                    patchIdentifiers,
                    cancellationToken).ConfigureAwait(false);
            }
            else if (OnCall != null)
            {
                return Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            _outputArguments[0] = _result.UpdateBehavior;

            return _result.ServiceResult;
        }
        #endif

        #endregion

        #region Private Fields
        #endregion
    }

    /// <exclude />
    public delegate ServiceResult GetUpdateBehaviorMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        string manufacturerUri,
        string softwareRevision,
        string[] patchIdentifiers,
        ref uint updateBehavior);

    /// <exclude />
    public partial class GetUpdateBehaviorMethodStateResult
    {
        public ServiceResult ServiceResult { get; set; }
        public uint UpdateBehavior { get; set; }
    }

    /// <exclude />
    public delegate ValueTask<GetUpdateBehaviorMethodStateResult> GetUpdateBehaviorMethodStateMethodAsyncCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        string manufacturerUri,
        string softwareRevision,
        string[] patchIdentifiers,
        CancellationToken cancellationToken);
    #endif
    #endregion

    #region ValidateFilesMethodState Class
    #if (!OPCUA_EXCLUDE_ValidateFilesMethodState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class ValidateFilesMethodState : MethodState
    {
        #region Constructors
        public ValidateFilesMethodState(NodeState parent) : base(parent)
        {
        }

        public new static NodeState Construct(NodeState parent)
        {
            return new ValidateFilesMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQAXAAAAVmFs" +
           "aWRhdGVGaWxlc01ldGhvZFR5cGUBAQAAAQEAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        public ValidateFilesMethodStateMethodCallHandler OnCall;

        public ValidateFilesMethodStateMethodAsyncCallHandler OnCallAsync;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            NodeId[] nodeIds = (NodeId[])_inputArguments[0];

            int errorCode = (int)_outputArguments[0];
            LocalizedText errorMessage = (LocalizedText)_outputArguments[1];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    nodeIds,
                    ref errorCode,
                    ref errorMessage);
            }

            _outputArguments[0] = errorCode;
            _outputArguments[1] = errorMessage;

            return _result;
        }

        #if (OPCUA_INCLUDE_ASYNC)
        protected override async ValueTask<ServiceResult> CallAsync(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments,
            CancellationToken cancellationToken = default)
        {
            if (OnCall == null && OnCallAsync == null)
            {
                return await base.CallAsync(_context, _objectId, _inputArguments, _outputArguments, cancellationToken).ConfigureAwait(false);
            }

            ValidateFilesMethodStateResult _result = null;

            NodeId[] nodeIds = (NodeId[])_inputArguments[0];

            if (OnCallAsync != null)
            {
                _result = await OnCallAsync(
                    _context,
                    this,
                    _objectId,
                    nodeIds,
                    cancellationToken).ConfigureAwait(false);
            }
            else if (OnCall != null)
            {
                return Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            _outputArguments[0] = _result.ErrorCode;
            _outputArguments[1] = _result.ErrorMessage;

            return _result.ServiceResult;
        }
        #endif

        #endregion

        #region Private Fields
        #endregion
    }

    /// <exclude />
    public delegate ServiceResult ValidateFilesMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        NodeId[] nodeIds,
        ref int errorCode,
        ref LocalizedText errorMessage);

    /// <exclude />
    public partial class ValidateFilesMethodStateResult
    {
        public ServiceResult ServiceResult { get; set; }
        public int ErrorCode { get; set; }
        public LocalizedText ErrorMessage { get; set; }
    }

    /// <exclude />
    public delegate ValueTask<ValidateFilesMethodStateResult> ValidateFilesMethodStateMethodAsyncCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        NodeId[] nodeIds,
        CancellationToken cancellationToken);
    #endif
    #endregion

    #region AddMethodState Class
    #if (!OPCUA_EXCLUDE_AddMethodState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class AddMethodState : MethodState
    {
        #region Constructors
        public AddMethodState(NodeState parent) : base(parent)
        {
        }

        public new static NodeState Construct(NodeState parent)
        {
            return new AddMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQANAAAAQWRk" +
           "TWV0aG9kVHlwZQEBAAABAQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        public AddMethodStateMethodCallHandler OnCall;

        public AddMethodStateMethodAsyncCallHandler OnCallAsync;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            string subclass = (string)_inputArguments[0];
            string name = (string)_inputArguments[1];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    subclass,
                    name);
            }

            return _result;
        }

        #if (OPCUA_INCLUDE_ASYNC)
        protected override async ValueTask<ServiceResult> CallAsync(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments,
            CancellationToken cancellationToken = default)
        {
            if (OnCall == null && OnCallAsync == null)
            {
                return await base.CallAsync(_context, _objectId, _inputArguments, _outputArguments, cancellationToken).ConfigureAwait(false);
            }

            AddMethodStateResult _result = null;

            string subclass = (string)_inputArguments[0];
            string name = (string)_inputArguments[1];

            if (OnCallAsync != null)
            {
                _result = await OnCallAsync(
                    _context,
                    this,
                    _objectId,
                    subclass,
                    name,
                    cancellationToken).ConfigureAwait(false);
            }
            else if (OnCall != null)
            {
                return Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            return _result.ServiceResult;
        }
        #endif

        #endregion

        #region Private Fields
        #endregion
    }

    /// <exclude />
    public delegate ServiceResult AddMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        string subclass,
        string name);

    /// <exclude />
    public partial class AddMethodStateResult
    {
        public ServiceResult ServiceResult { get; set; }
    }

    /// <exclude />
    public delegate ValueTask<AddMethodStateResult> AddMethodStateMethodAsyncCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        string subclass,
        string name,
        CancellationToken cancellationToken);
    #endif
    #endregion

    #region DeleteMethodState Class
    #if (!OPCUA_EXCLUDE_DeleteMethodState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class DeleteMethodState : MethodState
    {
        #region Constructors
        public DeleteMethodState(NodeState parent) : base(parent)
        {
        }

        public new static NodeState Construct(NodeState parent)
        {
            return new DeleteMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQAQAAAARGVs" +
           "ZXRlTWV0aG9kVHlwZQEBAAABAQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        public DeleteMethodStateMethodCallHandler OnCall;

        public DeleteMethodStateMethodAsyncCallHandler OnCallAsync;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            NodeId objectToDelete = (NodeId)_inputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    objectToDelete);
            }

            return _result;
        }

        #if (OPCUA_INCLUDE_ASYNC)
        protected override async ValueTask<ServiceResult> CallAsync(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments,
            CancellationToken cancellationToken = default)
        {
            if (OnCall == null && OnCallAsync == null)
            {
                return await base.CallAsync(_context, _objectId, _inputArguments, _outputArguments, cancellationToken).ConfigureAwait(false);
            }

            DeleteMethodStateResult _result = null;

            NodeId objectToDelete = (NodeId)_inputArguments[0];

            if (OnCallAsync != null)
            {
                _result = await OnCallAsync(
                    _context,
                    this,
                    _objectId,
                    objectToDelete,
                    cancellationToken).ConfigureAwait(false);
            }
            else if (OnCall != null)
            {
                return Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            return _result.ServiceResult;
        }
        #endif

        #endregion

        #region Private Fields
        #endregion
    }

    /// <exclude />
    public delegate ServiceResult DeleteMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        NodeId objectToDelete);

    /// <exclude />
    public partial class DeleteMethodStateResult
    {
        public ServiceResult ServiceResult { get; set; }
    }

    /// <exclude />
    public delegate ValueTask<DeleteMethodStateResult> DeleteMethodStateMethodAsyncCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        NodeId objectToDelete,
        CancellationToken cancellationToken);
    #endif
    #endregion

    #region InstallSoftwarePackageMethodState Class
    #if (!OPCUA_EXCLUDE_InstallSoftwarePackageMethodState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class InstallSoftwarePackageMethodState : MethodState
    {
        #region Constructors
        public InstallSoftwarePackageMethodState(NodeState parent) : base(parent)
        {
        }

        public new static NodeState Construct(NodeState parent)
        {
            return new InstallSoftwarePackageMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQAgAAAASW5z" +
           "dGFsbFNvZnR3YXJlUGFja2FnZU1ldGhvZFR5cGUBAQAAAQEAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        public InstallSoftwarePackageMethodStateMethodCallHandler OnCall;

        public InstallSoftwarePackageMethodStateMethodAsyncCallHandler OnCallAsync;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            string manufacturerUri = (string)_inputArguments[0];
            string softwareRevision = (string)_inputArguments[1];
            string[] patchIdentifiers = (string[])_inputArguments[2];
            byte[] hash = (byte[])_inputArguments[3];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    manufacturerUri,
                    softwareRevision,
                    patchIdentifiers,
                    hash);
            }

            return _result;
        }

        #if (OPCUA_INCLUDE_ASYNC)
        protected override async ValueTask<ServiceResult> CallAsync(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments,
            CancellationToken cancellationToken = default)
        {
            if (OnCall == null && OnCallAsync == null)
            {
                return await base.CallAsync(_context, _objectId, _inputArguments, _outputArguments, cancellationToken).ConfigureAwait(false);
            }

            InstallSoftwarePackageMethodStateResult _result = null;

            string manufacturerUri = (string)_inputArguments[0];
            string softwareRevision = (string)_inputArguments[1];
            string[] patchIdentifiers = (string[])_inputArguments[2];
            byte[] hash = (byte[])_inputArguments[3];

            if (OnCallAsync != null)
            {
                _result = await OnCallAsync(
                    _context,
                    this,
                    _objectId,
                    manufacturerUri,
                    softwareRevision,
                    patchIdentifiers,
                    hash,
                    cancellationToken).ConfigureAwait(false);
            }
            else if (OnCall != null)
            {
                return Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            return _result.ServiceResult;
        }
        #endif

        #endregion

        #region Private Fields
        #endregion
    }

    /// <exclude />
    public delegate ServiceResult InstallSoftwarePackageMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        string manufacturerUri,
        string softwareRevision,
        string[] patchIdentifiers,
        byte[] hash);

    /// <exclude />
    public partial class InstallSoftwarePackageMethodStateResult
    {
        public ServiceResult ServiceResult { get; set; }
    }

    /// <exclude />
    public delegate ValueTask<InstallSoftwarePackageMethodStateResult> InstallSoftwarePackageMethodStateMethodAsyncCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        string manufacturerUri,
        string softwareRevision,
        string[] patchIdentifiers,
        byte[] hash,
        CancellationToken cancellationToken);
    #endif
    #endregion

    #region InstallFilesMethodState Class
    #if (!OPCUA_EXCLUDE_InstallFilesMethodState)
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public partial class InstallFilesMethodState : MethodState
    {
        #region Constructors
        public InstallFilesMethodState(NodeState parent) : base(parent)
        {
        }

        public new static NodeState Construct(NodeState parent)
        {
            return new InstallFilesMethodState(parent);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAB8AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvREkv/////wRhggAEAAAAAQAWAAAASW5z" +
           "dGFsbEZpbGVzTWV0aG9kVHlwZQEBAAABAQAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Event Callbacks
        public InstallFilesMethodStateMethodCallHandler OnCall;

        public InstallFilesMethodStateMethodAsyncCallHandler OnCallAsync;
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        protected override ServiceResult Call(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments)
        {
            if (OnCall == null)
            {
                return base.Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            ServiceResult _result = null;

            NodeId[] nodeIds = (NodeId[])_inputArguments[0];

            if (OnCall != null)
            {
                _result = OnCall(
                    _context,
                    this,
                    _objectId,
                    nodeIds);
            }

            return _result;
        }

        #if (OPCUA_INCLUDE_ASYNC)
        protected override async ValueTask<ServiceResult> CallAsync(
            ISystemContext _context,
            NodeId _objectId,
            IList<object> _inputArguments,
            IList<object> _outputArguments,
            CancellationToken cancellationToken = default)
        {
            if (OnCall == null && OnCallAsync == null)
            {
                return await base.CallAsync(_context, _objectId, _inputArguments, _outputArguments, cancellationToken).ConfigureAwait(false);
            }

            InstallFilesMethodStateResult _result = null;

            NodeId[] nodeIds = (NodeId[])_inputArguments[0];

            if (OnCallAsync != null)
            {
                _result = await OnCallAsync(
                    _context,
                    this,
                    _objectId,
                    nodeIds,
                    cancellationToken).ConfigureAwait(false);
            }
            else if (OnCall != null)
            {
                return Call(_context, _objectId, _inputArguments, _outputArguments);
            }

            return _result.ServiceResult;
        }
        #endif

        #endregion

        #region Private Fields
        #endregion
    }

    /// <exclude />
    public delegate ServiceResult InstallFilesMethodStateMethodCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        NodeId[] nodeIds);

    /// <exclude />
    public partial class InstallFilesMethodStateResult
    {
        public ServiceResult ServiceResult { get; set; }
    }

    /// <exclude />
    public delegate ValueTask<InstallFilesMethodStateResult> InstallFilesMethodStateMethodAsyncCallHandler(
        ISystemContext _context,
        MethodState _method,
        NodeId _objectId,
        NodeId[] nodeIds,
        CancellationToken cancellationToken);
    #endif
    #endregion
}