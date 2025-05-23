// Copyright (c) 2019-2025 wetcon gmbh. All rights reserved.
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

using System;
using System.Linq;
using System.Threading.Tasks;
using Opc.Ua;
using Opc.Ua.Client;

namespace Wetcon.OpcUaClient.Base
{
    /// <summary>
    /// OPC UA Client with basic functionality to browse nodes and read variables.
    /// </summary>
    public class OpcUaClient : IDisposable
    {
        protected Session _session;

        public OpcUaClient()
        {

        }

        public virtual Task InitializeAsync(Opc.Ua.Server.StandardServer server)
        {
            var endpoints = server.GetEndpoints();
            if (endpoints.Count == 0)
            {
                throw new InvalidOperationException();
            }
            var firstEndpointUrl = endpoints[0].EndpointUrl;

            return InitializeAsync(firstEndpointUrl);
        }

        public virtual async Task InitializeAsync(string endpointUrl)
        {
            var config = new ApplicationConfiguration()
            {
                ApplicationName = "Wetcon.OpcUaClient",
                ApplicationType = ApplicationType.Client,
                SecurityConfiguration = new SecurityConfiguration
                {
                    ApplicationCertificate = new CertificateIdentifier
                    {
                        StoreType = @"Directory",
                        StorePath = @"%AppData%\wetcon\PACTwarePlugins\OpcUaServer\Certificates\own",
                        SubjectName = @"CN=Wetcon.OpcUaClient, DC=localhost",
                    },
                    TrustedPeerCertificates = new CertificateTrustList
                    {
                        StoreType = @"Directory",
                        StorePath = @"%AppData%\wetcon\PACTwarePlugins\OpcUaServer\Certificates\trusted",
                    },
                    AutoAcceptUntrustedCertificates = true,
                    RejectSHA1SignedCertificates = true,
                },
                TransportConfigurations = new TransportConfigurationCollection(),
                TransportQuotas = new TransportQuotas { OperationTimeout = 15000 },
                ClientConfiguration = new ClientConfiguration { DefaultSessionTimeout = 60000 }
            };

            if (config.SecurityConfiguration.AutoAcceptUntrustedCertificates)
            {
                config.CertificateValidator = new CertificateValidator();
                config.CertificateValidator.CertificateValidation += (s, e) =>
                {
                    e.Accept = e.Error.StatusCode == StatusCodes.BadCertificateUntrusted;
                };
            }

            var configuredEndpoint = new ConfiguredEndpoint(null, new EndpointDescription(endpointUrl));
            _session = await Session.Create(config, configuredEndpoint, true, string.Empty, 60000, null, null).ConfigureAwait(false);
        }

        public object ReadVariable(NodeId nodeId)
        {
            var readValueResult = _session.ReadValue(nodeId);

            return readValueResult.Value;
        }

        /// <summary>
        /// Reads a variable
        /// </summary>
        /// <param name="nodePath"></param>
        /// <returns></returns>
        public object ReadVariable(string nodePath)
        {
            var nodeId = new NodeId(nodePath);

            return ReadVariable(nodeId);
        }

        public object ReadVariableByDisplayName(ReferenceDescriptionCollection refs, string displayName)
        {
            var nodeId = GetNodeIdByDisplayName(refs, displayName);

            return ReadVariable(nodeId);
        }

        /// <summary>
        /// Reads a node
        /// </summary>
        /// <param name="nodePath"></param>
        /// <returns></returns>
        public Node ReadNode(string nodePath)
        {
            var nodeId = new NodeId(nodePath);

            return ReadNode(nodeId);
        }

        /// <summary>
        /// Reads a node
        /// </summary>
        /// <param name="nodeId"></param>
        /// <returns></returns>
        public Node ReadNode(NodeId nodeId)
        {
            var readNodeResult = _session.ReadNode(nodeId);

            return readNodeResult;
        }

        public StatusCode WriteVariable(NodeId nodeId, int value)
        {
            var writeValue = new WriteValue
            {
                NodeId = nodeId,
                AttributeId = Attributes.Value,
                Value =
                {
                    Value = value,
                    StatusCode = StatusCodes.Good,
                    ServerTimestamp = DateTime.MinValue,
                    SourceTimestamp = DateTime.MinValue
                }
            };

            var valuesToWrite = new WriteValueCollection
            {
                writeValue
            };

            _session.Write(null, valuesToWrite, out var results, out var info);

            ClientBase.ValidateResponse(results, valuesToWrite);
            ClientBase.ValidateDiagnosticInfos(info, valuesToWrite);

            return results.First();
        }

        /// <summary>
        /// Browses the server with the given parameter
        /// </summary>
        /// <param name="nodeToBrowse"></param>
        /// <param name="refs"></param>
        public void Browse(NodeId nodeToBrowse, out ReferenceDescriptionCollection refs)
        {
            _session.Browse(null, null, nodeToBrowse, 0u, BrowseDirection.Forward, ReferenceTypeIds.HierarchicalReferences, true,
                    (uint)NodeClass.Variable | (uint)NodeClass.Object | (uint)NodeClass.Method, out _, out refs);
        }

        public void Browse(ExpandedNodeId expandedNodeIdToBrowse, out ReferenceDescriptionCollection refs)
        {
            Browse(ToNodeId(expandedNodeIdToBrowse), out refs);
        }

        /// <summary>
        /// Returns the first node's id with the given display name.
        /// </summary>
        /// <param name="referenceDescriptionCollection"></param>
        /// <param name="displayName"></param>
        /// <exception cref="InvalidOperationException"></exception>
        /// <returns>the first node with given display name</returns>
        public NodeId GetNodeIdByDisplayName(ReferenceDescriptionCollection referenceDescriptionCollection, string displayName)
        {
            var referenceDescription =
                referenceDescriptionCollection.FirstOrDefault(rd => rd.DisplayName.Text.Equals(displayName));

            if (null == referenceDescription)
            {
                throw new InvalidOperationException($"Node with display name {displayName} not found.");
            }

            var expandedNodeId = referenceDescription.NodeId;

            return ToNodeId(expandedNodeId);
        }

        public NodeId ToNodeId(ExpandedNodeId expandedNodeId)
        {
            return ExpandedNodeId.ToNodeId(expandedNodeId, _session.NamespaceUris);
        }

        public void Dispose()
        {
            _session?.Dispose();
        }
    }
}
