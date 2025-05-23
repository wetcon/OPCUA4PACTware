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
using System.Threading;

namespace Wetcon.PactwarePlugin.OpcUaServer
{
    /// <summary>
    /// Represents the class which holds the completed async result data.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CompletedAsyncResult<T> : IAsyncResult
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="data"></param>
        public CompletedAsyncResult(T data)
        {
            Data = data;
        }

        /// <summary>
        /// The data associated with this async result.
        /// </summary>
        public T Data { get; }

        /// <summary>
        /// Indicates if the async operation is completed.
        /// </summary>
        public bool IsCompleted => true;

        /// <summary>
        /// A wait handle for the async operation (NOT SUPPORTED HERE).
        /// </summary>
        public WaitHandle AsyncWaitHandle => throw new NotSupportedException();

        /// <summary>
        /// User defined data which also holds the async result data as object.
        /// </summary>
        public object AsyncState => Data;

        /// <summary>
        /// Indicates if the operation completed synchronously.
        /// </summary>
        public bool CompletedSynchronously => true;
    }
}
