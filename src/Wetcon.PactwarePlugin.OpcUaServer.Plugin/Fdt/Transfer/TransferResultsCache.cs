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

using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Wetcon.PactwarePlugin.OpcUaServer.Fdt
{
    /// <summary>
    /// Caches the last request of IDtmOnlineParameter Upload / Download for each device.
    /// </summary>
    public class TransferResultsCache
    {
        private readonly ConcurrentDictionary<string, Task<InvokeResponseInfo>> _transferResultTasks = new ConcurrentDictionary<string, Task<InvokeResponseInfo>>();

        public void Add(string deviceId, Task<InvokeResponseInfo> task)
        {
            _transferResultTasks.TryRemove(deviceId, out _);
            _transferResultTasks.TryAdd(deviceId, task);
        }

        public TransferResult GetResult(string deviceId, int transferId)
        {
            if (!_transferResultTasks.TryGetValue(deviceId, out var result))
            {
                return new TransferResult(TransferStatus.NoResultsForDevice);
            }

            if (!result.IsCompleted)
            {
                return new TransferResult(TransferStatus.NotCompleted);
            }

            if (null == result.Result)
            {
                return new TransferResult(TransferStatus.Timeout);
            }

            return result.Result.InvokeId.GetHashCode().Equals(transferId) ?
                new TransferResult(TransferStatus.Completed, result.Result.Response) :
                new TransferResult(TransferStatus.NoResultsForTransferId);
        }
    }
}
