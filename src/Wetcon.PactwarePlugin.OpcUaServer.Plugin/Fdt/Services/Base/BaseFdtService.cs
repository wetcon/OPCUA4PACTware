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
using System.Threading.Tasks;
using log4net;
using PWID.Interfaces;
using Wetcon.PactwarePlugin.OpcUaServer.Infrastructure;

namespace Wetcon.PactwarePlugin.OpcUaServer.Fdt
{
    /// <summary>
    /// Base class for Fdt services.
    /// </summary>
    public abstract class BaseFdtService<T> : IDisposable, IBaseFdtService where T : class
    {
        protected static readonly ILog s_log = LogManager.GetLogger($"BaseFdtService<{DtmDescription}>");
        protected IPACTwareProjectNode PactwareProjectNode;
        protected DtmInterface<T> DtmInterface;
        private static string DtmDescription => typeof(T).Name;

        public virtual void OnLoadProjectNode(IPACTwareProjectNode pactwareProjectNode)
        {
            DtmInterface?.Dispose();
            s_log.DebugFormat("Loading DTM interface {0}", DtmDescription);
            PactwareProjectNode = pactwareProjectNode;
            DtmInterface = DtmInterface<T>.Access(DtmProjectNode);
        }

        public virtual void OnUnloadProjectNode()
        {
            s_log.DebugFormat("Unloading DTM interface {0}", DtmDescription);
            DtmInterface?.Dispose();
        }

        protected virtual IPACTwareProjectNode DtmProjectNode => PactwareProjectNode;

        public void Dispose()
        {
            OnUnloadProjectNode();
        }

        protected InvokeResponseInfo WaitFor(Task<InvokeResponseInfo> waitResponseTask)
        {
            return waitResponseTask
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
        }

        protected void LogDtmCall(string function, object result)
        {
            s_log.InfoFormat("{0}.{1}() >> {2}", DtmDescription, function, result);
        }
    }
}
