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
using PWID.Interfaces;
using PWUtil5;

namespace Wetcon.PactwarePlugin.OpcUaServer.Infrastructure
{
    /// <summary>
    /// Retrieves the object pointer from a given project node on construction,
    /// releases the object pointer upon destruction
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DtmInterface<T> : IDisposable where T : class
    {
        private readonly IPACTwareProjectNode _projectNode;
        private bool _disposed;
        private object _objectPointer;

        public T ObjectPointer
        {
            get
            {
                if (_disposed)
                {
                    throw new ObjectDisposedException(ToString());
                }

                if (_objectPointer == null)
                {
                    _objectPointer = GetObjectPointer();
                }

                return _objectPointer as T;
            }
        }

        private DtmInterface(IPACTwareProjectNode projectNode)
        {
            _projectNode = projectNode;
            _objectPointer = GetObjectPointer();
        }

        public static DtmInterface<T> Access(IPACTwareProjectNode projectNode)
        {
            return new DtmInterface<T>(projectNode);
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                ReleaseObjectPointer();
                _disposed = true;
            }
        }

        /// <summary>
        /// Returns the object pointer from a project node.
        /// </summary>
        /// <returns>The object pointer or <see langword="null"/>.</returns>
        private object GetObjectPointer()
        {
            if (null == _projectNode)
            {
                return null;
            }

            var result = _projectNode.BeginGetObjectPointer(clsGuid.GetGuid(), null, null);
            return _projectNode.EndGetObjectPointer(result);
        }

        /// <summary>
        /// Release the object pointer from a project node.
        /// </summary>
        private void ReleaseObjectPointer()
        {
            if (null == _projectNode || null == _objectPointer)
            {
                return;
            }

            var result = _projectNode.BeginReleaseObjectPointer(clsGuid.GetGuid(), null, null);
            _projectNode.EndReleaseObjectPointer(result);
            _objectPointer = null;
        }
    }
}
