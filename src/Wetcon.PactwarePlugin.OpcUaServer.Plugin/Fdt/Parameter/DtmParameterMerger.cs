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

using System.Collections.Generic;
using System.Linq;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt.Models;
using Wetcon.PactwarePlugin.OpcUaServer.Infrastructure;

namespace Wetcon.PactwarePlugin.OpcUaServer.Fdt
{
    public static class DtmParameterMerger
    {
        /// <summary>
        /// Merges two lists of <see cref="DtmParameter"/>. Uses all elements of the prio1 list and add elements of
        /// prio2 only if the element's Id is not contained in prio1 list.
        /// </summary>
        /// <param name="prio1"></param>
        /// <param name="prio2"></param>
        /// <returns></returns>
        public static List<DtmParameter> Merge(List<DtmParameter> prio1, List<DtmParameter> prio2)
        {
            prio1 = prio1 ?? new List<DtmParameter>();
            prio2 = prio2 ?? new List<DtmParameter>();

            var result = new List<DtmParameter>(prio1);

            foreach (var dtmParameter in prio2)
            {
                if (!prio1.Any(i => i.Id.Equals(dtmParameter.Id)))
                {
                    result.Add(dtmParameter);
                }
            }

            return result;
        }

        /// <summary>
        /// Flattens a <see cref="DtmItemInfoList"/>.
        /// </summary>
        /// <param name="parameterDataSourceKind"></param>
        /// <param name="dtmItemInfoList"></param>
        /// <returns></returns>
        public static List<DtmParameter> Flatten(ParameterDataSourceKind parameterDataSourceKind, DtmItemInfoList dtmItemInfoList)
        {
            var dtmItemInfos = new List<DtmItemInfo>();

            if (dtmItemInfoList?.ItemInfos != null)
            {
                dtmItemInfos.AddRange(dtmItemInfoList.ItemInfos);
            }

            if (dtmItemInfoList?.ItemGroups != null)
            {
                var dtmItemInfosInGroups = dtmItemInfoList.ItemGroups
                    .Flatten(gr => gr.ItemGroups)
                    .SelectMany(gr => gr.ItemInfos);

                dtmItemInfos.AddRange(dtmItemInfosInGroups);
            }

            return dtmItemInfos
                .Select(i => i.ToDtmParameter(parameterDataSourceKind))
                .ToList();
        }
    }
}
