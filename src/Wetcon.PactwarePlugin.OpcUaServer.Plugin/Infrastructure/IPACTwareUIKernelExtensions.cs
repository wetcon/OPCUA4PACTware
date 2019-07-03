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

using System.Collections.Generic;
using System.Linq;
using PWID.Enumerations;
using PWID.Interfaces;

namespace Wetcon.PactwarePlugin.OpcUaServer.Infrastructure
{
    /// <summary>
    /// IPACTwareUIKernel extensions.
    /// </summary>
    public static class IPACTwareUIKernelExtensions
    {
        /// <summary>
        /// Returns all device project nodes of an <see cref="IPACTwareUIKernel"/> project.
        /// </summary>
        /// <param name="kernel"></param>
        /// <param name="projectNodeToExclude"></param>
        /// <returns></returns>
        public static IEnumerable<IPACTwareProjectNode> GetDeviceProjectNodes(this IPACTwareUIKernel kernel, IPACTwareProjectNode projectNodeToExclude = null)
        {
            return kernel.PACTwareKernel.Project.Collection
                .Where(IsDeviceProjectNode)
                .Where(p => p.Id != projectNodeToExclude?.Id);
        }

        private static bool IsDeviceProjectNode(IPACTwareProjectNode projectNode)
        {
            return projectNode.NodeTyp == PACTwareEnumProjectNodeTyp.ID_DEVICE;
        }
    }
}
