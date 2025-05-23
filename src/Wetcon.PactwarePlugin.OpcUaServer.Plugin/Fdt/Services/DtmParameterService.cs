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
using System.Collections.Generic;
using Jigfdt.Fdt100;

namespace Wetcon.PactwarePlugin.OpcUaServer.Fdt
{
    /// <summary>
    /// Retrieves device parameters using IDtmParameter.GetParameters method.
    /// </summary>
    public class DtmParameterService : SyncFdtService<IDtmParameter>
    {
        public virtual bool SetDtmParameter(string parameterId, object value)
        {
            return InvokeSync(() =>
            {
                if (null == DtmInterface.ObjectPointer)
                {
                    return false;
                }

                var getParametersXml = DoGetDtmParametersXml();
                var dtmParameterWriter = new DtmParameterWriter(getParametersXml);

                if (!dtmParameterWriter.SetParameterValue(parameterId, value))
                {
                    return false;
                }

                var xml = dtmParameterWriter.ToXml();
                var result = DtmInterface.ObjectPointer.SetParameters("FDT", xml);
                LogDtmCall("SetParameters", result);

                return result;
            });
        }

        public virtual List<DtmParameter> GetDtmParameters()
        {
            try
            {
                return InvokeSync(() =>
                {
                    if (null == DtmInterface.ObjectPointer)
                    {
                        return new List<DtmParameter>();
                    }

                    var parameterString = DoGetDtmParametersXml();
                    var dtmVariableParser = new DtmVariableParser(parameterString);

                    return dtmVariableParser.Parse();
                });
            }
            catch (Exception ex)
            {
                s_log.Error("IDtmParameter.GetParameters() error", ex);
            }

            return new List<DtmParameter>();
        }

        private string DoGetDtmParametersXml()
        {
            if (null == DtmInterface.ObjectPointer)
            {
                return null;
            }

            var result = DtmInterface.ObjectPointer.GetParameters("FDT");

            LogDtmCall("GetParameters", result);

            return result;
        }
    }
}
