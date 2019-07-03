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
using System.Linq;
using System.Reflection;
using PWID.Interfaces;

namespace Wetcon.PactwarePlugin.OpcUaServer.Fdt
{
    /// <summary>
    /// Service Provider for Fdt communication services.
    /// </summary>
    public class FdtServiceProvider : IFdtServiceProvider
    {
        private readonly IDictionary<Type, IBaseFdtService> _fdtServices;

        public FdtServiceProvider()
        {
            _fdtServices = new Dictionary<Type, IBaseFdtService>();

            var fdtServiceTypes = GetFdtServiceTypes();
            foreach (var fdtServiceType in fdtServiceTypes)
            {
                var instance = (IBaseFdtService)Activator.CreateInstance(fdtServiceType);
                _fdtServices.Add(instance.GetType(), instance);
            }
        }

        public T GetService<T>() where T : IBaseFdtService
        {
            return (T)_fdtServices[typeof(T)];
        }

        private static IEnumerable<Type> GetFdtServiceTypes()
        {
            return Assembly
                .GetAssembly(typeof(IBaseFdtService))
                .GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && typeof(IBaseFdtService).IsAssignableFrom(t));
        }

        public void OnLoadProjectNode(IPACTwareProjectNode pactwareProjectNode)
        {
            foreach (var service in _fdtServices.Values)
            {
                service.OnLoadProjectNode(pactwareProjectNode);
            }
        }

        public void OnUnloadProjectNode()
        {
            foreach (var service in _fdtServices.Values)
            {
                service.OnUnloadProjectNode();
            }
        }
    }
}
