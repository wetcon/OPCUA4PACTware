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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Opc.Ua;
using Opc.Ua.Di;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt;
using Wetcon.PactwarePlugin.OpcUaServer.Fdt.Models;
using Wetcon.PactwarePlugin.OpcUaServer.OpcUa.Models;

namespace Wetcon.PactwarePlugin.OpcUaServer.Plugin.Tests
{
    [TestClass]
    public class ParameterModelTests
    {
        [TestMethod]
        public void AccessLevelNone()
        {
            var testServices = new TestFdtServices();
            var parameterModel = CreateParameterModel(true, testServices, AccessLevels.None, "IdA");

            Assert.IsNull(parameterModel.OnReadValue);
            Assert.IsNull(parameterModel.OnWriteValue);
        }

        [TestMethod]
        public void AccessLevelCurrentRead()
        {
            var testServices = new TestFdtServices();
            var parameterModel = CreateParameterModel(true, testServices, AccessLevels.CurrentRead, "IdA");

            Assert.IsNotNull(parameterModel.OnReadValue);
            Assert.IsNull(parameterModel.OnWriteValue);
        }

        [TestMethod]
        public void AccessLevelCurrentReadOrWrite()
        {
            var testServices = new TestFdtServices();
            var parameterModel = CreateParameterModel(true, testServices, AccessLevels.CurrentReadOrWrite, "IdA");

            Assert.IsNotNull(parameterModel.OnReadValue);
            Assert.IsNotNull(parameterModel.OnWriteValue);
        }

        [TestMethod]
        public void ReadDtmParameter()
        {
            var testServices = new TestFdtServices();

            testServices.DtmParameterService
                .GetDtmParameters()
                .Returns(CreateDtmParameter(ParameterDataSourceKind.DtmParameter, AccessLevels.CurrentRead, "IdA", "IdB"));

            var parameterModel = CreateParameterModel(true, testServices, AccessLevels.CurrentRead, "IdA");
            var result = ParameterIOEvent.InvokeRead(parameterModel);

            Assert.AreEqual("IdA", result.Value);
            Assert.AreEqual(StatusCodes.Good, result.ServiceResult.Code);
        }

        [TestMethod]
        public void ReadSingleInstanceDataAccessParameter()
        {
            var testServices = new TestFdtServices();

            testServices.DtmSingleInstanceDataAccessService
                .ReadOfflineDeviceParameters(Arg.Any<DtmItemSelectionList>())
                .Returns(CreateDtmItemList(ParameterDataSourceKind.DtmParameter, AccessLevels.CurrentRead, "IdA", "IdB"));

            var parameterModel = CreateParameterModel(true, testServices, AccessLevels.CurrentRead, "IdA", ParameterDataSourceKind.DtmSingleDeviceDataAccess);
            var result = ParameterIOEvent.InvokeRead(parameterModel);

            Assert.AreEqual("IdA", result.Value);
            Assert.AreEqual(StatusCodes.Good, result.ServiceResult.Code);
        }

        [TestMethod]
        public void ReadSingleDeviceDataAccessParameter()
        {
            var testServices = new TestFdtServices();

            testServices.DtmSingleDeviceDataAccessService
                .ReadOnlineDeviceParameters(Arg.Any<DtmItemSelectionList>())
                .Returns(CreateDtmItemList(ParameterDataSourceKind.DtmParameter, AccessLevels.CurrentRead, "IdA", "IdB"));

            var parameterModel = CreateParameterModel(false, testServices, AccessLevels.CurrentRead, "IdA", ParameterDataSourceKind.DtmSingleDeviceDataAccess);
            var result = ParameterIOEvent.InvokeRead(parameterModel);

            Assert.AreEqual("IdA", result.Value);
            Assert.AreEqual(StatusCodes.Good, result.ServiceResult.Code);
        }

        [TestMethod]
        public void WriteDtmParameter()
        {
            var testServices = new TestFdtServices();

            testServices.DtmParameterService
                .SetDtmParameter(Arg.Any<string>(), Arg.Any<object>())
                .Returns(true);

            testServices.FdtContainerService
                .SaveRequest()
                .Returns(true);

            var parameterModel = CreateParameterModel(true, testServices, AccessLevels.CurrentReadOrWrite, "IdA");
            var result = ParameterIOEvent.InvokeWrite(parameterModel, "value");

            Assert.AreEqual(StatusCodes.Good, result.ServiceResult.Code);
        }

        [TestMethod]
        public void WriteDtmParameterFailDoesNotSave()
        {
            var testServices = new TestFdtServices();

            testServices.DtmParameterService
                .SetDtmParameter(Arg.Any<string>(), Arg.Any<object>())
                .Returns(false);

            testServices.FdtContainerService
                .SaveRequest()
                .Returns(true);

            var parameterModel = CreateParameterModel(true, testServices, AccessLevels.CurrentReadOrWrite, "IdA");
            var result = ParameterIOEvent.InvokeWrite(parameterModel, "value");

            Assert.AreEqual(StatusCodes.Bad, result.ServiceResult.Code);
        }

        [TestMethod]
        public void WriteSingleInstanceDataAccessParameter()
        {
            var testServices = new TestFdtServices();

            testServices.DtmSingleInstanceDataAccessService
                .WriteOfflineDeviceParameters(Arg.Any<DtmItemList>())
                .Returns(CreateDtmItemList(ParameterDataSourceKind.DtmParameter, AccessLevels.CurrentReadOrWrite, "IdA"));

            var parameterModel = CreateParameterModel(true, testServices, AccessLevels.CurrentReadOrWrite, "IdA",
                ParameterDataSourceKind.DtmSingleDeviceDataAccess);
            var result = ParameterIOEvent.InvokeWrite(parameterModel, "value");

            Assert.AreEqual(StatusCodes.Good, result.ServiceResult.Code);
        }

        [TestMethod]
        public void WriteSingleDeviceDataAccessParameter()
        {
            var testServices = new TestFdtServices();

            testServices.DtmSingleDeviceDataAccessService
                .WriteOnlineDeviceParameters(Arg.Any<DtmItemList>())
                .Returns(CreateDtmItemList(ParameterDataSourceKind.DtmSingleDeviceDataAccess, AccessLevels.CurrentReadOrWrite, "IdA"));

            var parameterModel = CreateParameterModel(false, testServices, AccessLevels.CurrentReadOrWrite, "IdA",
                ParameterDataSourceKind.DtmSingleDeviceDataAccess);
            var result = ParameterIOEvent.InvokeWrite(parameterModel, "value");

            Assert.AreEqual(StatusCodes.Good, result.ServiceResult.Code);
        }

        /// <summary>
        /// Creates a list with <see cref="DtmParameter"/> for each given id.
        /// </summary>
        /// <param name="dataSourceKind"></param>
        /// <param name="accessLevel"></param>
        /// <param name="ids"></param>
        /// <returns></returns>
        private List<DtmParameter> CreateDtmParameter(ParameterDataSourceKind dataSourceKind, byte accessLevel, params string[] ids)
        {
            return new List<DtmParameter>(
                ids.Select(
                    id => new DtmParameter(id, string.Empty, string.Empty, DtmDataTypeKind.ascii,
                        accessLevel, dataSourceKind, id)
                )
            );
        }

        private DtmItemList CreateDtmItemList(ParameterDataSourceKind dataSourceKind, byte accessLevel, params string[] ids)
        {
            var dtmItems = CreateDtmParameter(dataSourceKind, accessLevel, ids)
                .Select(p => p.ToDtmItem())
                .ToList();

            return new DtmItemList()
            {
                Items = dtmItems
            };
        }

        private ParameterModel CreateParameterModel(bool offlineDevice, TestFdtServices testFdtServices, byte accessLevel,
            string id, ParameterDataSourceKind parameterDataSourceKind = ParameterDataSourceKind.DtmParameter)
        {
            var device = new DeviceState(null)
            {
                NodeId = new NodeId("")
            };

            var deviceModelContext = new DeviceModelContext(1, testFdtServices.PACTwareProjectNode,
                testFdtServices.FdtServiceProvider, device);

            var parent = offlineDevice ?
                (BaseDeviceModel)new OfflineDeviceModel(deviceModelContext) :
                new OnlineDeviceModel(deviceModelContext, false);

            var parameterModel = new ParameterModel(parent,
                CreateDtmParameter(parameterDataSourceKind, accessLevel, id).First());

            return parameterModel;
        }

        /// <summary>
        /// Helper class to read and write device parameter values and return the result.
        /// </summary>
        class ParameterIOEvent
        {
            public object Value { get; }
            public ServiceResult ServiceResult { get; }

            private ParameterIOEvent(object value, ServiceResult serviceResult)
            {
                Value = value;
                ServiceResult = serviceResult;
            }

            public static ParameterIOEvent InvokeRead(ParameterModel parameterModel)
            {
                return Invoke(parameterModel, parameterModel.OnReadValue);
            }

            public static ParameterIOEvent InvokeWrite(ParameterModel parameterModel, object value)
            {
                return Invoke(parameterModel, parameterModel.OnWriteValue, value);
            }

            private static ParameterIOEvent Invoke(ParameterModel parameterModel, NodeValueEventHandler eventHandler, object value = null)
            {
                var statusCode = new StatusCode();
                var timestamp = DateTime.MinValue;

                var result = eventHandler(Substitute.For<ISystemContext>(), parameterModel, new NumericRange(0),
                    new QualifiedName(string.Empty), ref value, ref statusCode, ref timestamp);

                return new ParameterIOEvent(value, result);
            }
        }
    }
}
