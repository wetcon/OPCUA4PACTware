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
using System.Collections.Concurrent;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Wetcon.PactwarePlugin.OpcUaServer.Fdt
{
    /// <summary>
    /// Helper class for Xml serialization of FDT objects.
    /// </summary>
    public static class FdtXmlSerializer
    {
        private static readonly ConcurrentDictionary<Type, XmlSerializer> s_serializers =
            new ConcurrentDictionary<Type, XmlSerializer>();

        private static readonly XmlSerializerNamespaces s_fdtXmlNamespaces = new XmlSerializerNamespaces();

        static FdtXmlSerializer()
        {
            s_fdtXmlNamespaces.Add("fdt", Constants.FdtNamespaces.FdtDataTypesSchemaNs);
        }

        /// <summary>
        /// Deserializes xml string into an FDT object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static T Deserialize<T>(string xml) where T : class
        {
            var xmlSerializer = GetSerializer<T>();
            using (var tr = new StringReader(xml))
            {
                return xmlSerializer.Deserialize(tr) as T;
            }
        }

        /// <summary>
        /// Serializes an FDT object into a xml string.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string Serialize(object obj)
        {
            var xmlSerializer = GetSerializer(obj.GetType());
            var sbXml = new StringBuilder();
            using (var tw = new StringWriter(sbXml))
            {
                xmlSerializer.Serialize(tw, obj, s_fdtXmlNamespaces);
                return sbXml.ToString();
            }
        }

        private static XmlSerializer GetSerializer<T>() where T : class
        {
            var type = typeof(T);
            return GetSerializer(type);
        }

        private static XmlSerializer GetSerializer(Type type)
        {
            return s_serializers.GetOrAdd(type, t => new XmlSerializer(t));
        }
    }
}
