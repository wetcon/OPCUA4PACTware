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

using System.Collections;
using System.Globalization;

namespace Wetcon.PactwarePlugin.OpcUaServer.IODD
{
    /// <summary>
    /// Class to hold and extract information from IO link devices process data. 
    /// Initialized with the byte array returned by a ReadProcessDataRequest.
    /// </summary>
    public class ProcessData
    {
        private readonly BitArray _bitArray;

        /// <summary>
        /// Constructor taking a hexadecimal string as input data.
        /// </summary>
        /// <param name="responseString"></param>
        public ProcessData(string responseString)
        {
            _bitArray = ConvertHexToBitArray(responseString);
        }

        /// <summary>
        /// Constructor taking a <see cref="BitArray"/>.
        /// </summary>
        /// <param name="bitArray"></param>
        public ProcessData(BitArray bitArray)
        {
            _bitArray = bitArray;
        }

        /// <summary>
        /// Converts the ProcessData to a boolean.
        /// </summary>
        /// <returns></returns>

        public bool ToBool()
        {
            return _bitArray[0];
        }

        /// <summary>
        /// Converts the ProcessData to an integer.
        /// </summary>
        /// <returns></returns>
        public int ToInt()
        {
            int res = 0;

            for (int i = 0; i < _bitArray.Count; i++)
            {
                if (_bitArray[i])
                {
                    res |= 1 << i;
                }
            }

            return res;
        }

        /// <summary>
        /// Returns a new <see cref="ProcessData"/> instance based on the given offset and length.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public ProcessData FromOffset(int offset, int length)
        {
            var result = new BitArray(length);

            for (var i = offset; i < offset + length; i++)
            {
                result.Set(i - offset, _bitArray[i]);
            }

            return new ProcessData(result);
        }

        /// <summary>
        /// Interprets the given input string as hexadecimal and converts it to a <see cref="BitArray"/>.
        /// </summary>
        /// <param name="hexData"></param>
        /// <returns></returns>
        public static BitArray ConvertHexToBitArray(string hexData)
        {
            if (hexData == null)
            {
                return null;
            }

            var totalLength = 4 * hexData.Length;
            var bitArray = new BitArray(totalLength);
            for (var i = 0; i < hexData.Length; i++)
            {
                var byteValue = byte.Parse(hexData[i].ToString(), NumberStyles.HexNumber);
                for (var j = 0; j < 4; j++)
                {
                    bitArray.Set(totalLength - 1 - (i * 4 + j), (byteValue & (1 << (3 - j))) != 0);
                }
            }

            return bitArray;
        }
    }
}
