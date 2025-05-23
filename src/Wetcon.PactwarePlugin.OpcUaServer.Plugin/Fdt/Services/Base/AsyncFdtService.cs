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
using PWID.Interfaces;
using PWUtil5;

namespace Wetcon.PactwarePlugin.OpcUaServer.Fdt
{
    /// <summary>
    /// Base class for asynchronous Fdt Services.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AsyncFdtService<T> : BaseFdtService<T> where T : class
    {
        /// <summary>
        /// Invokes the given <see cref="Func{T1,T2,T3,TResult}"/> assuming it will return asynchronously using a DTM callback.
        /// </summary>
        /// <typeparam name="TResultType"></typeparam>
        /// <param name="invokeResponseSubject"></param>
        /// <param name="fn"></param>
        /// <returns></returns>
        protected TResultType InvokeAsync<TResultType>(InvokeResponseSubject invokeResponseSubject, Func<InvokeResponseContext,
            TResultType> fn)
        {
            try
            {
                var context = invokeResponseSubject.CreateNewContext();

                return fn.Invoke(context);
            }
            catch (Exception ex)
            {
                s_log.Error("Exception", ex);
                throw;
            }
        }

        protected bool RegisterObjectCallback(IPACTwareProjectNode pactwareProjectNode)
        {
            var result = pactwareProjectNode.BeginAddObjectCallbackObserver(clsGuid.GetGuid(), this, null, null);

            return pactwareProjectNode.EndAddObjectCallbackObserver(result);
        }

        protected bool UnRegisterObjectCallback(IPACTwareProjectNode pactwareProjectNode)
        {
            var result = pactwareProjectNode.BeginRemoveObjectCallbackObserver(clsGuid.GetGuid(), this, null, null);

            return pactwareProjectNode.EndRemoveObjectCallbackObserver(result);
        }

        public override void OnLoadProjectNode(IPACTwareProjectNode pactwareProjectNode)
        {
            base.OnLoadProjectNode(pactwareProjectNode);
            var result = RegisterObjectCallback(pactwareProjectNode);
            s_log.DebugFormat("Registering object callback {0}", result);
        }

        public override void OnUnloadProjectNode()
        {
            var result = UnRegisterObjectCallback(PactwareProjectNode);
            s_log.DebugFormat("Unregistering object callback {0}", result);
            base.OnUnloadProjectNode();
        }
    }
}
