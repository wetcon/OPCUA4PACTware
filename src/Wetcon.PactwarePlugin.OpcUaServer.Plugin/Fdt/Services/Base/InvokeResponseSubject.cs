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

using System;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Reactive.Threading.Tasks;
using System.Threading.Tasks;
using PWUtil5;

namespace Wetcon.PactwarePlugin.OpcUaServer.Fdt
{
    /// <summary>
    /// Obervable used to handle DTM callbacks.
    /// </summary>
    public class InvokeResponseSubject
    {
        private readonly Subject<InvokeResponseInfo> _invokeResponseInfoSubject;
        private readonly TimeSpan _timeOut;

        public InvokeResponseSubject(TimeSpan timeOut)
        {
            _timeOut = timeOut;
            _invokeResponseInfoSubject = new Subject<InvokeResponseInfo>();
        }

        private Task<InvokeResponseInfo> ToObservableTask(string invokeId)
        {
            return _invokeResponseInfoSubject.AsObservable()
                .Where(e => e.InvokeId == invokeId)
                .Buffer(_timeOut, 1)
                .Select(xs => xs.FirstOrDefault())
                .FirstOrDefaultAsync()
                .ToTask();
        }

        public void OnNext(string invokeId, string response)
        {
            _invokeResponseInfoSubject.OnNext(new InvokeResponseInfo(invokeId, response));
        }

        public void OnError(string response)
        {
            _invokeResponseInfoSubject.OnError(new Exception(response));
        }

        public InvokeResponseContext CreateNewContext()
        {
            var invokeId = clsGuid.GetGuid();
            var task = ToObservableTask(invokeId);

            return new InvokeResponseContext(invokeId, task);
        }
    }
}
