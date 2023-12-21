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

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt;
using Wetcon.PactwarePlugin.OpcUaServer.OpcUa.Models;

namespace Wetcon.PactwarePlugin.OpcUaServer.Plugin.Tests
{
    [TestClass]
    public class ParameterSetModelTests
    {
        [TestMethod]
        public void OfflineNodeOnlyDtmSingleInstanceDataAccess()
        {
            var testServices = new TestFdtServices();

            testServices.DtmSingleInstanceDataAccessService
                .GetOfflineDeviceParameters()
                .Returns(CreateDtmParameter(ParameterDataSourceKind.DtmSingleInstanceDataAccess, "IdA", "IdB"));

            testServices.DtmParameterService
                .GetDtmParameters()
                .Returns(new List<DtmParameter>());

            var offlineDevice = testServices.CreateOfflineDevice();
            var deviceParameterSet = (ParameterSetModel)offlineDevice.ParameterSet;
            var result = deviceParameterSet.GetParameters().ToList();

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(ParameterDataSourceKind.DtmSingleInstanceDataAccess, ((ParameterModel)result[0]).DtmParameter.Source);
            Assert.AreEqual(ParameterDataSourceKind.DtmSingleInstanceDataAccess, ((ParameterModel)result[1]).DtmParameter.Source);
        }

        [TestMethod]
        public void OfflineNodeOnlyDtmParameters()
        {
            var testServices = new TestFdtServices();

            testServices.DtmSingleInstanceDataAccessService
                .GetOfflineDeviceParameters()
                .Returns(new List<DtmParameter>());

            testServices.DtmParameterService
                .GetDtmParameters()
                .Returns(CreateDtmParameter(ParameterDataSourceKind.DtmParameter, "IdB", "IdC"));

            var offlineDevice = testServices.CreateOfflineDevice();
            var deviceParameterSet = (ParameterSetModel)offlineDevice.ParameterSet;
            var result = deviceParameterSet.GetParameters().ToList();

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(ParameterDataSourceKind.DtmParameter, ((ParameterModel)result[0]).DtmParameter.Source);
            Assert.AreEqual(ParameterDataSourceKind.DtmParameter, ((ParameterModel)result[1]).DtmParameter.Source);
        }

        [TestMethod]
        public void OfflineNodeMergesParameterWithDifferentSources()
        {
            var testServices = new TestFdtServices();

            testServices.DtmSingleInstanceDataAccessService
                .GetOfflineDeviceParameters()
                .Returns(CreateDtmParameter(ParameterDataSourceKind.DtmSingleInstanceDataAccess, "IdA", "IdB"));

            testServices.DtmParameterService
                .GetDtmParameters()
                .Returns(CreateDtmParameter(ParameterDataSourceKind.DtmParameter, "IdB", "IdC"));

            var offlineDevice = testServices.CreateOfflineDevice();
            var deviceParameterSet = (ParameterSetModel)offlineDevice.ParameterSet;
            var result = deviceParameterSet.GetParameters().ToList();

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(ParameterDataSourceKind.DtmSingleInstanceDataAccess, ((ParameterModel)result[0]).DtmParameter.Source);
            // IdB: higher prioritity from DtmSingleInstanceDataAccess source
            Assert.AreEqual(ParameterDataSourceKind.DtmSingleInstanceDataAccess, ((ParameterModel)result[1]).DtmParameter.Source);
            Assert.AreEqual(ParameterDataSourceKind.DtmParameter, ((ParameterModel)result[2]).DtmParameter.Source);
        }

        [TestMethod]
        public void OnlineNodeWithoutProcessParameters()
        {
            var testServices = new TestFdtServices();

            testServices.DtmSingleDeviceDataAccessService
                .GetOnlineDeviceParameters()
                .Returns(CreateDtmParameter(ParameterDataSourceKind.DtmSingleDeviceDataAccess, "IdA", "IdB"));

            var onlineDevice = testServices.CreateOnlineDevice(false);
            var deviceParameterSet = (ParameterSetModel)onlineDevice.ParameterSet;
            var result = deviceParameterSet.GetParameters().ToList();

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(ParameterDataSourceKind.DtmSingleDeviceDataAccess, ((ParameterModel)result[0]).DtmParameter.Source);
            Assert.AreEqual(ParameterDataSourceKind.DtmSingleDeviceDataAccess, ((ParameterModel)result[1]).DtmParameter.Source);
        }

        [TestMethod]
        public void OnlineNodeWithProcessParameters()
        {
            var testServices = new TestFdtServices();

            testServices.DtmSingleDeviceDataAccessService
                .GetOnlineDeviceParameters()
                .Returns(new List<DtmParameter>());

            var onlineDevice = testServices.CreateOnlineDevice(true);
            var deviceParameterSet = (ParameterSetModel)onlineDevice.ParameterSet;
            var result = deviceParameterSet.GetParameters().ToList();

            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result[0] is ProcessParameterModel);
            Assert.IsTrue(result[1] is ProcessParameterModel);
        }

        /// <summary>
        /// Creates a list of <see cref="DtmParameter"/> for each given id.
        /// </summary>
        /// <param name="dataSourceKind"></param>
        /// <param name="ids"></param>
        /// <returns></returns>
        private List<DtmParameter> CreateDtmParameter(ParameterDataSourceKind dataSourceKind, params string[] ids)
        {
            return new List<DtmParameter>(
                ids.Select(
                    id => new DtmParameter(id, string.Empty, string.Empty, Fdt.Models.DtmDataTypeKind.ascii, 0, dataSourceKind)
                )
            );
        }
    }
}
