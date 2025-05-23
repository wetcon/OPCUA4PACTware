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

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt;

namespace Wetcon.PactwarePlugin.OpcUaServer.Plugin.Tests
{
    [TestClass]
    public class OnlineParameterServiceTests
    {
        [TestMethod]
        public void DownloadRequestDeviceNotOnline()
        {
            var onlineParameterService = CreateOnlineParameterService(true);
            var result = onlineParameterService.StartDownloadRequest();

            Assert.AreEqual(InitTransferStatus.ErrorNotOnline, result.InitTransferStatus);
        }

        [TestMethod]
        public void UploadRequestDeviceNotOnline()
        {
            var onlineParameterService = CreateOnlineParameterService(true);
            var result = onlineParameterService.StartUploadRequest();

            Assert.AreEqual(InitTransferStatus.ErrorNotOnline, result.InitTransferStatus);
        }

        [TestMethod]
        public void DownloadRequestDeviceOnline()
        {
            var onlineParameterService = CreateOnlineParameterService(false);
            var result = onlineParameterService.StartDownloadRequest();

            Assert.AreEqual(InitTransferStatus.Ok, result.InitTransferStatus);
        }

        [TestMethod]
        public void UploadRequestDeviceOnline()
        {
            var onlineParameterService = CreateOnlineParameterService(false);
            var result = onlineParameterService.StartUploadRequest();

            Assert.AreEqual(InitTransferStatus.Ok, result.InitTransferStatus);
        }

        [TestMethod]
        public void DownloadRequestFetchResult()
        {
            var onlineParameterService = CreateOnlineParameterService(false);
            var startTransferResult = onlineParameterService.StartDownloadRequest();
            var result = onlineParameterService.FetchTransferResultData(startTransferResult.TransferId);

            Assert.AreEqual(true.ToString(), result.Response);
            Assert.AreEqual(TransferStatus.Completed, result.Status);
        }

        [TestMethod]
        public void UploadRequestFetchResult()
        {
            var onlineParameterService = CreateOnlineParameterService(false);
            var startTransferResult = onlineParameterService.StartUploadRequest();
            var result = onlineParameterService.FetchTransferResultData(startTransferResult.TransferId);

            Assert.AreEqual(true.ToString(), result.Response);
            Assert.AreEqual(TransferStatus.Completed, result.Status);
        }



        [TestMethod]
        public void UploadRequestFetchResultDifferentTransferId()
        {
            var onlineParameterService = CreateOnlineParameterService(false);
            var startTransferResult = onlineParameterService.StartUploadRequest();
            var differentTransferId = startTransferResult.TransferId + 1;
            var result = onlineParameterService.FetchTransferResultData(differentTransferId);

            Assert.AreEqual(TransferStatus.NoResultsForTransferId, result.Status);
        }

        [TestMethod]
        public void TransferRequestOverwriteResultForSameDevice()
        {
            var onlineParameterService = CreateOnlineParameterService(false);
            var startTransferResultFirst = onlineParameterService.StartUploadRequest();
            var startTransferResultSecond = onlineParameterService.StartDownloadRequest();

            var resultFirst = onlineParameterService.FetchTransferResultData(startTransferResultFirst.TransferId);
            var resultSecond = onlineParameterService.FetchTransferResultData(startTransferResultSecond.TransferId);

            Assert.AreEqual(TransferStatus.NoResultsForTransferId, resultFirst.Status);
            Assert.AreEqual(TransferStatus.Completed, resultSecond.Status);
        }

        private DtmOnlineParameterService CreateOnlineParameterService(bool emptyDevice)
        {
            var mock = PACTwareMock.Create()
                .AddDevice("deviceName", "deviceId", emptyDevice, false, !emptyDevice);

            var onlineParameterService = new DtmOnlineParameterService();
            onlineParameterService.OnLoadProjectNode(mock.Devices.First());

            return onlineParameterService;
        }
    }
}
