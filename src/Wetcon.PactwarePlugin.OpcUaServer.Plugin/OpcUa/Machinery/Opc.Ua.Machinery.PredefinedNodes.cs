/* ========================================================================
 * Copyright (c) 2005-2024 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Text;
using System.IO;
using Opc.Ua;
using Opc.Ua.DI;
using Opc.Ua.IA;

namespace Opc.Ua.DI {}
namespace Opc.Ua.IA {}

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CA1515 // Consider making public types internal
#pragma warning disable CA1707 // Identifiers should not contain underscores
#pragma warning disable CA1028 // Enum Storage should be Int32

namespace Opc.Ua.Machinery
{
    #region _ClassName_ Declarations
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public static partial class PredefinedNodes
    {
        #region PredefinedNodes Declarations
        // <summary/>
        public static NodeStateCollection Load(ISystemContext context)
        {
            byte[] initializationBuffer = Convert.FromBase64String(
               "AwAAACYAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvVUEvTWFjaGluZXJ5Lx8AAABodHRwOi8vb3Bj" +
               "Zm91bmRhdGlvbi5vcmcvVUEvSUEvHwAAAGh0dHA6Ly9vcGNmb3VuZGF0aW9uLm9yZy9VQS9ESS//////" +
               "EQAAACRoABAIAAAAAQAYAAAASU1hY2hpbmVUYWdOYW1lcGxhdGVUeXBlAQHzAwMAAAAAVwAAAEludGVy" +
               "ZmFjZSBjb250YWluaW5nIGluZm9ybWF0aW9uIG9mIHRoZSBpZGVudGlmaWNhdGlvbiBvZiBhIG1hY2hp" +
               "bmUgc2V0IGJ5IHRoZSBjdXN0b21lcgEDyDoBAQAAAAEAw0QBAQH0AwEAAAA1YIkLAgAAAAEACAAAAExv" +
               "Y2F0aW9uAQGMFwMAAAAALAEAAFRvIGJlIHVzZWQgYnkgZW5kIHVzZXJzIHRvIHN0b3JlIHRoZSBsb2Nh" +
               "dGlvbiBvZiB0aGUgbWFjaGluZSBpbiBhIHNjaGVtZSBzcGVjaWZpYyB0byB0aGUgZW5kIHVzZXIgU2Vy" +
               "dmVycyBzaGFsbCBzdXBwb3J0IGF0IGxlYXN0IDYwIFVuaWNvZGUgY2hhcmFjdGVycyBmb3IgdGhlIGNs" +
               "aWVudHMgd3JpdGluZyB0aGlzIHZhbHVlLCB0aGlzIG1lYW5zIGNsaWVudHMgY2FuIGV4cGVjdCB0byBi" +
               "ZSBhYmxlIHRvIHdyaXRlIHN0cmluZ3Mgd2l0aCBhIGxlbmd0aCBvZiA2MCBVbmljb2RlIGNoYXJhY3Rl" +
               "cnMgaW50byB0aGF0IGZpZWxkLgAuAEQAUIwXAAAADP////8DA/////8AAAAAJGgAEAgAAAABABcAAABJ" +
               "TWFjaGluZXJ5RXF1aXBtZW50VHlwZQEB7wMDAAAAAFsAAABQcm92aWRlcyBiYXNlIGlkZW50aWZpY2F0" +
               "aW9uIGluZm9ybWF0aW9uIG9mIE1hY2hpbmVyeUVxdWlwbWVudCB0aGF0IGNhbiBiZSBzZXQgYnkgdGhl" +
               "IHVzZXIuAQHzAwEBAAAAAQDDRAEBAbwTAwAAADVgiQsCAAAAAQALAAAARGVzY3JpcHRpb24BAdsXAwAA" +
               "AADDAAAAQWRkaXRpb25hbCBpbmZvcm1hdGlvbiBhbmQgZGVzY3JpcHRpb24gYWJvdXQgdGhlIE1hY2hp" +
               "bmVyeUVxdWlwbWVudC4gU2hvdWxkIGJlIHVzZWQgaWYgRGVzY3JpcHRpb24gQXR0cmlidXRlIGNhbm5v" +
               "dCBiZSB3cml0dGVuIHZpYSBPUEMgVUEgYW5kIHNob3VsZCBiZSBpZGVhbGx5IGlkZW50aWNhbCB0byBE" +
               "ZXNjcmlwdGlvbiBBdHRyaWJ1dGUuAC4ARABQ2xcAAAAV/////wMD/////wAAAAA1YIkLAgAAAAEADQAA" +
               "AEVxdWlwbWVudExpZmUBAd0XAwAAAAAuAAAATGlmZXRpbWUgaW5kaWNhdGlvbiBvZiB0aGUgTWFjaGlu" +
               "ZXJ5RXF1aXBtZW50LgAvAQPUAQBQ3RcAAAAa/////wEB/////wMAAAAVYIkLAgAAAAAAEAAAAEVuZ2lu" +
               "ZWVyaW5nVW5pdHMBAeAXAC4ARABO4BcAAAEAdwP/////AQH/////AAAAADVgiQsCAAAAAwAKAAAAU3Rh" +
               "cnRWYWx1ZQEB3xcDAAAAAFMAAABTdGFydFZhbHVlIGluZGljYXRlcyB0aGUgaW5pdGlhbCB2YWx1ZSwg" +
               "d2hlbiB0aGVyZSBpcyBzdGlsbCB0aGUgZnVsbCBsaWZldGltZSBsZWZ0LgAuAEQATt8XAAAAGv////8B" +
               "Af////8AAAAANWCJCwIAAAADAAoAAABMaW1pdFZhbHVlAQHeFwMAAAAAPwAAAExpbWl0VmFsdWUgaW5k" +
               "aWNhdGVzIHdoZW4gdGhlIGVuZCBvZiBsaWZldGltZSBoYXMgYmVlbiByZWFjaGVkLgAuAEQATt4XAAAA" +
               "Gv////8BAf////8AAAAANWCJCwIAAAABABgAAABNYWNoaW5lcnlFcXVpcG1lbnRUeXBlSWQBAdwXAwAA" +
               "AACMAAAASWRlbnRpZmljYXRpb24gb2YgYSBnZW5lcmljIE1hY2hpbmVyeUVxdWlwbWVudC4gRGVmaW5l" +
               "ZCBieSBlYWNoIGNvbXBhbnkgKGUuZy4sIGNvbXBhbnkgaGFzIGFuIE1hY2hpbmVyeUVxdWlwbWVudFR5" +
               "cGVJZCBmb3IgYWxsIDggbW0gZHJpbGxzKS4ALgBEAE7cFwAAAAz/////AwP/////AAAAACRoABAIAAAA" +
               "AQAhAAAASU1hY2hpbmVyeUl0ZW1WZW5kb3JOYW1lcGxhdGVUeXBlAQHrAwMAAAAAaAAAAEludGVyZmFj" +
               "ZSBjb250YWluaW5nIGlkZW50aWZpY2F0aW9uIGFuZCBuYW1lcGxhdGUgaW5mb3JtYXRpb24gZm9yIGEg" +
               "TWFjaGluZXJ5SXRlbSBwcm92aWRlZCBieSB0aGUgdmVuZG9yAQO7OgEBAAAAAQDDRAEBAewDBQAAADVg" +
               "iQsCAAAAAwAMAAAATWFudWZhY3R1cmVyAQGGFwMAAAAASgAAAEEgaHVtYW4tcmVhZGFibGUsIGxvY2Fs" +
               "aXplZCBuYW1lIG9mIHRoZSBtYW51ZmFjdHVyZXIgb2YgdGhlIE1hY2hpbmVyeUl0ZW0uAC4ARABOhhcA" +
               "AAAV/////wEB/////wAAAAA1YIkLAgAAAAMADAAAAFNlcmlhbE51bWJlcgEBiBcDAAAAABcBAABBIHN0" +
               "cmluZyBjb250YWluaW5nIGEgdW5pcXVlIHByb2R1Y3Rpb24gbnVtYmVyIG9mIHRoZSBtYW51ZmFjdHVy" +
               "ZXIgb2YgdGhlIE1hY2hpbmVyeUl0ZW0uIFRoZSBnbG9iYWwgdW5pcXVlbmVzcyBvZiB0aGUgc2VyaWFs" +
               "IG51bWJlciBpcyBvbmx5IGdpdmVuIGluIHRoZSBjb250ZXh0IG9mIHRoZSBtYW51ZmFjdHVyZXIsIGFu" +
               "ZCBwb3RlbnRpYWxseSB0aGUgbW9kZWwuIFRoZSB2YWx1ZSBzaGFsbCBub3QgY2hhbmdlIGR1cmluZyB0" +
               "aGUgbGlmZS1jeWNsZSBvZiB0aGUgTWFjaGluZXJ5SXRlbS4ALgBEAE6IFwAAAAz/////AQH/////AAAA" +
               "ADVgiQsCAAAAAQAUAAAASW5pdGlhbE9wZXJhdGlvbkRhdGUBAYsXAwAAAABpAAAAVGhlIGRhdGUsIHdo" +
               "ZW4gdGhlIE1hY2hpbmVyeUl0ZW0gd2FzIHN3aXRjaGVkIG9uIHRoZSBmaXJzdCB0aW1lIGFmdGVyIGl0" +
               "IGhhcyBsZWZ0IHRoZSBtYW51ZmFjdHVyZXIgcGxhbnQuAC4ARABQixcAAAAN/////wEB/////wAAAAA1" +
               "YIkLAgAAAAEAEwAAAE1vbnRoT2ZDb25zdHJ1Y3Rpb24BAYoXAwAAAACtAAAAVGhlIG1vbnRoIGluIHdo" +
               "aWNoIHRoZSBtYW51ZmFjdHVyaW5nIHByb2Nlc3Mgb2YgdGhlIE1hY2hpbmVyeUl0ZW0gaGFzIGJlZW4g" +
               "Y29tcGxldGVkLiBJdCBzaGFsbCBiZSBhIG51bWJlciBiZXR3ZWVuIDEgYW5kIDEyLCByZXByZXNlbnRp" +
               "bmcgdGhlIG1vbnRoIGZyb20gSmFudWFyeSB0byBEZWNlbWJlci4ALgBEAFCKFwAAAAP/////AQH/////" +
               "AAAAADVgiQsCAAAAAQASAAAAWWVhck9mQ29uc3RydWN0aW9uAQGJFwMAAAAAxAAAAFRoZSB5ZWFyIChH" +
               "cmVnb3JpYW4gY2FsZW5kYXIpIGluIHdoaWNoIHRoZSBtYW51ZmFjdHVyaW5nIHByb2Nlc3Mgb2YgdGhl" +
               "IE1hY2hpbmVyeUl0ZW0gaGFzIGJlZW4gY29tcGxldGVkLiBJdCBzaGFsbCBiZSBhIGZvdXItZGlnaXQg" +
               "bnVtYmVyIGFuZCBuZXZlciBjaGFuZ2UgZHVyaW5nIHRoZSBsaWZlLWN5Y2xlIG9mIGEgTWFjaGluZXJ5" +
               "SXRlbS4ALgBEAFCJFwAAAAX/////AQH/////AAAAACRoABAIAAAAAQAbAAAASU1hY2hpbmVWZW5kb3JO" +
               "YW1lcGxhdGVUeXBlAQHyAwMAAAAAagAAAEludGVyZmFjZSBjb250YWluaW5nIGlkZW50aWZpY2F0aW9u" +
               "IGFuZCBuYW1lcGxhdGUgaW5mb3JtYXRpb24gZm9yIGEgbWFjaGluZSBwcm92aWRlZCBieSB0aGUgbWFj" +
               "aGluZSB2ZW5kb3IBAesDAQEAAAABAMNEAQEB9AMBAAAANWCJCwIAAAADABIAAABQcm9kdWN0SW5zdGFu" +
               "Y2VVcmkBAYcXAwAAAABRAAAAQSBnbG9iYWxseSB1bmlxdWUgcmVzb3VyY2UgaWRlbnRpZmllciBwcm92" +
               "aWRlZCBieSB0aGUgbWFudWZhY3R1cmVyIG9mIHRoZSBtYWNoaW5lAC4ARABOhxcAAAAM/////wEB////" +
               "/wAAAAAkaAAQCAAAAAEAHwAAAE1hY2hpbmVyeUl0ZW1JZGVudGlmaWNhdGlvblR5cGUBAewDAwAAAABO" +
               "AAAAQ29udGFpbnMgaW5mb3JtYXRpb24gYWJvdXQgdGhlIGlkZW50aWZpY2F0aW9uIGFuZCBuYW1lcGxh" +
               "dGUgb2YgYSBNYWNoaW5lcnlJdGVtAQPtAwECAAAAAQDDRAABAesDAQDDRAABA8g6DwAAADVgqQsCAAAA" +
               "AwAHAAAAQXNzZXRJZAEBfRcDAAAAADABAABUbyBiZSB1c2VkIGJ5IGVuZCB1c2VycyB0byBzdG9yZSBh" +
               "IHVuaXF1ZSBpZGVudGlmaWNhdGlvbiBpbiB0aGUgY29udGV4dCBvZiB0aGVpciBvdmVyYWxsIGFwcGxp" +
               "Y2F0aW9uLiBTZXJ2ZXJzIHNoYWxsIHN1cHBvcnQgYXQgbGVhc3QgNDAgVW5pY29kZSBjaGFyYWN0ZXJz" +
               "IGZvciB0aGUgY2xpZW50cyB3cml0aW5nIHRoaXMgdmFsdWUsIHRoaXMgbWVhbnMgY2xpZW50cyBjYW4g" +
               "ZXhwZWN0IHRvIGJlIGFibGUgdG8gd3JpdGUgc3RyaW5ncyB3aXRoIGEgbGVuZ3RoIG9mIDQwIFVuaWNv" +
               "ZGUgY2hhcmFjdGVycyBpbnRvIHRoYXQgZmllbGQuAC4ARABQfRcAAAwAAAAAAAz/////AwP/////AAAA" +
               "ADVgqQsCAAAAAwANAAAAQ29tcG9uZW50TmFtZQEBfhcDAAAAAHoBAABUbyBiZSB1c2VkIGJ5IGVuZCB1" +
               "c2VycyB0byBzdG9yZSBhIGh1bWFuLXJlYWRhYmxlIGxvY2FsaXplZCB0ZXh0IGZvciB0aGUgTWFjaGlu" +
               "ZXJ5SXRlbS4gVGhlIG1pbmltdW0gbnVtYmVyIG9mIGxvY2FsZXMgc3VwcG9ydGVkIGZvciB0aGlzIHBy" +
               "b3BlcnR5IHNoYWxsIGJlIHR3by4gU2VydmVycyBzaGFsbCBzdXBwb3J0IGF0IGxlYXN0IDQwIFVuaWNv" +
               "ZGUgY2hhcmFjdGVycyBmb3IgdGhlIGNsaWVudHMgd3JpdGluZyB0aGUgdGV4dCBwYXJ0IG9mIGVhY2gg" +
               "bG9jYWxlLCB0aGlzIG1lYW5zIGNsaWVudHMgY2FuIGV4cGVjdCB0byBiZSBhYmxlIHRvIHdyaXRlIHRl" +
               "eHRzIHdpdGggYSBsZW5ndGggb2YgNDAgVW5pY29kZSBjaGFyYWN0ZXJzIGludG8gdGhhdCBmaWVsZC4A" +
               "LgBEAFB+FwAAFQAAFf////8DA/////8AAAAANWCpCgIAAAAAABkAAABEZWZhdWx0SW5zdGFuY2VCcm93" +
               "c2VOYW1lAQHIFwMAAAAAMQAAAFRoZSBkZWZhdWx0IEJyb3dzZU5hbWUgZm9yIGluc3RhbmNlcyBvZiB0" +
               "aGUgdHlwZS4ALgBEyBcAABQDAA4AAABJZGVudGlmaWNhdGlvbgAU/////wMD/////wAAAAA1YIkLAgAA" +
               "AAMACwAAAERldmljZUNsYXNzAQF8FwMAAAAASAAAAEluZGljYXRlcyBpbiB3aGljaCBkb21haW4gb3Ig" +
               "Zm9yIHdoYXQgcHVycG9zZSB0aGUgTWFjaGluZXJ5SXRlbSBpcyB1c2VkLgAuAEQAUHwXAAAADP////8B" +
               "Af////8AAAAANWCJCwIAAAADABAAAABIYXJkd2FyZVJldmlzaW9uAQF6FwMAAAAAJAEAAEEgc3RyaW5n" +
               "IHJlcHJlc2VudGF0aW9uIG9mIHRoZSByZXZpc2lvbiBsZXZlbCBvZiB0aGUgaGFyZHdhcmUgb2YgYSBN" +
               "YWNoaW5lcnlJdGVtLiBIYXJkd2FyZSBpcyBwaHlzaWNhbCBlcXVpcG1lbnQsIGFzIG9wcG9zZWQgdG8g" +
               "cHJvZ3JhbXMsIHByb2NlZHVyZXMsIHJ1bGVzIGFuZCBhc3NvY2lhdGVkIGRvY3VtZW50YXRpb24uIE1h" +
               "bnkgbWFjaGluZXMgd2lsbCBub3QgcHJvdmlkZSBzdWNoIGluZm9ybWF0aW9uIGR1ZSB0byB0aGUgbW9k" +
               "dWxhciBhbmQgY29uZmlndXJhYmxlIG5hdHVyZSBvZiB0aGUgbWFjaGluZS4ALgBEAFB6FwAAAAz/////" +
               "AQH/////AAAAADVgiQsCAAAAAQAUAAAASW5pdGlhbE9wZXJhdGlvbkRhdGUBAXYXAwAAAABpAAAAVGhl" +
               "IGRhdGUsIHdoZW4gdGhlIE1hY2hpbmVyeUl0ZW0gd2FzIHN3aXRjaGVkIG9uIHRoZSBmaXJzdCB0aW1l" +
               "IGFmdGVyIGl0IGhhcyBsZWZ0IHRoZSBtYW51ZmFjdHVyZXIgcGxhbnQuAC4ARABQdhcAAAAN/////wEB" +
               "/////wAAAAA1YIkLAgAAAAMADAAAAE1hbnVmYWN0dXJlcgEBchcDAAAAAEoAAABBIGh1bWFuLXJlYWRh" +
               "YmxlLCBsb2NhbGl6ZWQgbmFtZSBvZiB0aGUgbWFudWZhY3R1cmVyIG9mIHRoZSBNYWNoaW5lcnlJdGVt" +
               "LgAuAEQATnIXAAAAFf////8BAf////8AAAAANWCJCwIAAAADAA8AAABNYW51ZmFjdHVyZXJVcmkBAXcX" +
               "AwAAAABGAAAAQSBnbG9iYWxseSB1bmlxdWUgaWRlbnRpZmllciBvZiB0aGUgbWFudWZhY3R1cmVyIG9m" +
               "IHRoZSBNYWNoaW5lcnlJdGVtLgAuAEQAUHcXAAAADP////8BAf////8AAAAANWCJCwIAAAADAAUAAABN" +
               "b2RlbAEBeBcDAAAAAEMAAABBIGh1bWFuLXJlYWRhYmxlLCBsb2NhbGl6ZWQgbmFtZSBvZiB0aGUgbW9k" +
               "ZWwgb2YgdGhlIE1hY2hpbmVyeUl0ZW0uAC4ARABQeBcAAAAV/////wEB/////wAAAAA1YIkLAgAAAAEA" +
               "EwAAAE1vbnRoT2ZDb25zdHJ1Y3Rpb24BAXUXAwAAAACtAAAAVGhlIG1vbnRoIGluIHdoaWNoIHRoZSBt" +
               "YW51ZmFjdHVyaW5nIHByb2Nlc3Mgb2YgdGhlIE1hY2hpbmVyeUl0ZW0gaGFzIGJlZW4gY29tcGxldGVk" +
               "LiBJdCBzaGFsbCBiZSBhIG51bWJlciBiZXR3ZWVuIDEgYW5kIDEyLCByZXByZXNlbnRpbmcgdGhlIG1v" +
               "bnRoIGZyb20gSmFudWFyeSB0byBEZWNlbWJlci4ALgBEAFB1FwAAAAP/////AQH/////AAAAADVgiQsC" +
               "AAAAAwALAAAAUHJvZHVjdENvZGUBAXkXAwAAAAD7AAAAQSBtYWNoaW5lLXJlYWRhYmxlIHN0cmluZyBv" +
               "ZiB0aGUgbW9kZWwgb2YgdGhlIE1hY2hpbmVyeUl0ZW0sIHRoYXQgbWlnaHQgaW5jbHVkZSBvcHRpb25z" +
               "IGxpa2UgdGhlIGhhcmR3YXJlIGNvbmZpZ3VyYXRpb24gb2YgdGhlIG1vZGVsLiBUaGlzIGluZm9ybWF0" +
               "aW9uIG1pZ2h0IGJlIHByb3ZpZGVkIGJ5IHRoZSBFUlAgc3lzdGVtIG9mIHRoZSB2ZW5kb3IuIEZvciBl" +
               "eGFtcGxlLCBpdCBjYW4gYmUgdXNlZCBhcyBvcmRlciBpbmZvcm1hdGlvbi4ALgBEAFB5FwAAAAz/////" +
               "AQH/////AAAAADVgiQsCAAAAAwASAAAAUHJvZHVjdEluc3RhbmNlVXJpAQFxFwMAAAAAWAAAAEEgZ2xv" +
               "YmFsbHkgdW5pcXVlIHJlc291cmNlIGlkZW50aWZpZXIgcHJvdmlkZWQgYnkgdGhlIG1hbnVmYWN0dXJl" +
               "ciBvZiB0aGUgTWFjaGluZXJ5SXRlbS4ALgBEAFBxFwAAAAz/////AQH/////AAAAADVgiQsCAAAAAwAM" +
               "AAAAU2VyaWFsTnVtYmVyAQFzFwMAAAAAFwEAAEEgc3RyaW5nIGNvbnRhaW5pbmcgYSB1bmlxdWUgcHJv" +
               "ZHVjdGlvbiBudW1iZXIgb2YgdGhlIG1hbnVmYWN0dXJlciBvZiB0aGUgTWFjaGluZXJ5SXRlbS4gVGhl" +
               "IGdsb2JhbCB1bmlxdWVuZXNzIG9mIHRoZSBzZXJpYWwgbnVtYmVyIGlzIG9ubHkgZ2l2ZW4gaW4gdGhl" +
               "IGNvbnRleHQgb2YgdGhlIG1hbnVmYWN0dXJlciwgYW5kIHBvdGVudGlhbGx5IHRoZSBtb2RlbC4gVGhl" +
               "IHZhbHVlIHNoYWxsIG5vdCBjaGFuZ2UgZHVyaW5nIHRoZSBsaWZlLWN5Y2xlIG9mIHRoZSBNYWNoaW5l" +
               "cnlJdGVtLgAuAEQATnMXAAAADP////8BAf////8AAAAANWCJCwIAAAADABAAAABTb2Z0d2FyZVJldmlz" +
               "aW9uAQF7FwMAAAAA0AEAAEEgc3RyaW5nIHJlcHJlc2VudGF0aW9uIG9mIHRoZSByZXZpc2lvbiBsZXZl" +
               "bCBvZiBhIE1hY2hpbmVyeUl0ZW0uIEluIG1vc3QgY2FzZXMsIE1hY2hpbmVyeUl0ZW1zIGNvbnNpc3Qg" +
               "b2Ygc2V2ZXJhbCBzb2Z0d2FyZSBjb21wb25lbnRzLiBJbiB0aGF0IGNhc2UsIGluZm9ybWF0aW9uIGFi" +
               "b3V0IHRoZSBzb2Z0d2FyZSBjb21wb25lbnRzIG1pZ2h0IGJlIHByb3ZpZGVkIGFzIGFkZGl0aW9uYWwg" +
               "aW5mb3JtYXRpb24gaW4gdGhlIGFkZHJlc3Mgc3BhY2UsIGluY2x1ZGluZyBpbmRpdmlkdWFsIHJldmlz" +
               "aW9uIGluZm9ybWF0aW9uLiBJbiB0aGF0IGNhc2UsIHRoaXMgcHJvcGVydHkgaXMgZWl0aGVyIG5vdCBw" +
               "cm92aWRlZCBvciBwcm92aWRlcyBhbiBvdmVyYWxsIHNvZnR3YXJlIHJldmlzaW9uIGxldmVsLiBUaGUg" +
               "dmFsdWUgbWlnaHQgY2hhbmdlIGR1cmluZyB0aGUgbGlmZS1jeWNsZSBvZiBhIE1hY2hpbmVyeUl0ZW0u" +
               "AC4ARABQexcAAAAM/////wEB/////wAAAAA1YIkLAgAAAAEAEgAAAFllYXJPZkNvbnN0cnVjdGlvbgEB" +
               "dBcDAAAAAMQAAABUaGUgeWVhciAoR3JlZ29yaWFuIGNhbGVuZGFyKSBpbiB3aGljaCB0aGUgbWFudWZh" +
               "Y3R1cmluZyBwcm9jZXNzIG9mIHRoZSBNYWNoaW5lcnlJdGVtIGhhcyBiZWVuIGNvbXBsZXRlZC4gSXQg" +
               "c2hhbGwgYmUgYSBmb3VyLWRpZ2l0IG51bWJlciBhbmQgbmV2ZXIgY2hhbmdlIGR1cmluZyB0aGUgbGlm" +
               "ZS1jeWNsZSBvZiBhIE1hY2hpbmVyeUl0ZW0uAC4ARABQdBcAAAAF/////wEB/////wAAAAAkYAAQCAAA" +
               "AAEAGQAAAE1hY2hpbmVJZGVudGlmaWNhdGlvblR5cGUBAfQDAwAAAABIAAAAQ29udGFpbnMgaW5mb3Jt" +
               "YXRpb24gYWJvdXQgdGhlIGlkZW50aWZpY2F0aW9uIGFuZCBuYW1lcGxhdGUgb2YgYSBtYWNoaW5lAQHs" +
               "AwIAAAABAMNEAAEB8wMBAMNEAAEB8gMDAAAANWCpCgIAAAAAABkAAABEZWZhdWx0SW5zdGFuY2VCcm93" +
               "c2VOYW1lAQGOFwMAAAAAMQAAAFRoZSBkZWZhdWx0IEJyb3dzZU5hbWUgZm9yIGluc3RhbmNlcyBvZiB0" +
               "aGUgdHlwZS4ALgBEjhcAABQDAA4AAABJZGVudGlmaWNhdGlvbgAU/////wEB/////wAAAAA1YIkLAgAA" +
               "AAMAEgAAAFByb2R1Y3RJbnN0YW5jZVVyaQEBfxcDAAAAAFEAAABBIGdsb2JhbGx5IHVuaXF1ZSByZXNv" +
               "dXJjZSBpZGVudGlmaWVyIHByb3ZpZGVkIGJ5IHRoZSBtYW51ZmFjdHVyZXIgb2YgdGhlIG1hY2hpbmUA" +
               "LgBEAE5/FwAAAAz/////AQH/////AAAAADVgiQsCAAAAAQAIAAAATG9jYXRpb24BAY0XAwAAAAAtAQAA" +
               "VG8gYmUgdXNlZCBieSBlbmQgdXNlcnMgdG8gc3RvcmUgdGhlIGxvY2F0aW9uIG9mIHRoZSBtYWNoaW5l" +
               "IGluIGEgc2NoZW1lIHNwZWNpZmljIHRvIHRoZSBlbmQgdXNlci4gU2VydmVycyBzaGFsbCBzdXBwb3J0" +
               "IGF0IGxlYXN0IDYwIFVuaWNvZGUgY2hhcmFjdGVycyBmb3IgdGhlIGNsaWVudHMgd3JpdGluZyB0aGlz" +
               "IHZhbHVlLCB0aGlzIG1lYW5zIGNsaWVudHMgY2FuIGV4cGVjdCB0byBiZSBhYmxlIHRvIHdyaXRlIHN0" +
               "cmluZ3Mgd2l0aCBhIGxlbmd0aCBvZiA2MCBVbmljb2RlIGNoYXJhY3RlcnMgaW50byB0aGF0IGZpZWxk" +
               "LgAuAEQAUI0XAAAADP////8DA/////8AAAAAJGAAEAgAAAABACQAAABNYWNoaW5lcnlDb21wb25lbnRJ" +
               "ZGVudGlmaWNhdGlvblR5cGUBAe0DAwAAAABKAAAAQ29udGFpbnMgaW5mb3JtYXRpb24gYWJvdXQgdGhl" +
               "IGlkZW50aWZpY2F0aW9uIGFuZCBuYW1lcGxhdGUgb2YgYSBjb21wb25lbnQBAewD/////wIAAAA1YKkK" +
               "AgAAAAAAGQAAAERlZmF1bHRJbnN0YW5jZUJyb3dzZU5hbWUBAYAXAwAAAAAxAAAAVGhlIGRlZmF1bHQg" +
               "QnJvd3NlTmFtZSBmb3IgaW5zdGFuY2VzIG9mIHRoZSB0eXBlLgAuAESAFwAAFAMADgAAAElkZW50aWZp" +
               "Y2F0aW9uABT/////AwP/////AAAAADVgiQsCAAAAAwAOAAAARGV2aWNlUmV2aXNpb24BAYEXAwAAAAAI" +
               "AQAAQSBzdHJpbmcgcmVwcmVzZW50YXRpb24gb2YgdGhlIG92ZXJhbGwgcmV2aXNpb24gbGV2ZWwgb2Yg" +
               "dGhlIGNvbXBvbmVudC4gT2Z0ZW4sIGl0IGlzIGluY3JlYXNlZCB3aGVuIGVpdGhlciB0aGUgU29mdHdh" +
               "cmVSZXZpc2lvbiBhbmQgLyBvciB0aGUgSGFyZHdhcmVSZXZpc2lvbiBvZiB0aGUgY29tcG9uZW50IGlz" +
               "IGluY3JlYXNlZC4gQXMgYW4gZXhhbXBsZSwgaXQgY2FuIGJlIHVzZWQgaW4gRVJQIHN5c3RlbXMgdG9n" +
               "ZXRoZXIgd2l0aCB0aGUgUHJvZHVjdENvZGUuAC4ARABQgRcAAAAM/////wEB/////wAAAAAEYAAQCAAA" +
               "AAEAHQAAAE1hY2hpbmVyeU9wZXJhdGlvbkNvdW50ZXJUeXBlAQHxAwED7QMBAAAAAQDDRAABA+ABBAAA" +
               "ADVgqQoCAAAAAAAZAAAARGVmYXVsdEluc3RhbmNlQnJvd3NlTmFtZQEBwhcDAAAAADAAAABUaGUgZGVm" +
               "YXVsdCBCcm93c2VOYW1lIGZvciBpbnN0YW5jZXMgb2YgdGhlIHR5cGUALgBEwhcAABQDABEAAABPcGVy" +
               "YXRpb25Db3VudGVycwAU/////wMD/////wAAAAA1YIkLAgAAAAMAFQAAAE9wZXJhdGlvbkN5Y2xlQ291" +
               "bnRlcgEBwRcDAAAAADMBAABPcGVyYXRpb25DeWNsZUNvdW50ZXIgaXMgY291bnRpbmcgdGhlIHRpbWVz" +
               "IHRoZSBjb21wb25lbnQgc3dpdGNoZXMgZnJvbSBub3QgcGVyZm9ybWluZyBhbiBhY3Rpdml0eSB0byBw" +
               "ZXJmb3JtaW5nIGFuIGFjdGl2aXR5LiBGb3IgZXhhbXBsZSwgZWFjaCB0aW1lIGEgdmFsdmUgc3RhcnRz" +
               "IG1vdmluZywgaXMgY291bnRlZC4gVGhpcyB2YWx1ZSBzaGFsbCBvbmx5IGluY3JlYXNlIGR1cmluZyB0" +
               "aGUgbGlmZXRpbWUgb2YgdGhlIGNvbXBvbmVudCBhbmQgc2hhbGwgbm90IGJlIHJlc2V0IHdoZW4gdGhl" +
               "IGNvbXBvbmVudCBpcyByZXN0YXJ0ZWQuAC4ARABQwRcAAAAc/////wMD/////wAAAAA1YIkLAgAAAAMA" +
               "EQAAAE9wZXJhdGlvbkR1cmF0aW9uAQHAFwMAAAAA+gIAAE9wZXJhdGlvbkR1cmF0aW9uIGlzIHRoZSBk" +
               "dXJhdGlvbiB0aGUgTWFjaGluZXJ5SXRlbSBoYXMgYmVlbiBwb3dlcmVkIGFuZCBwZXJmb3JtaW5nIGFu" +
               "IGFjdGl2aXR5LiBUaGlzIGNvdW50ZXIgaXMgaW50ZW5kZWQgZm9yIG1hY2hpbmVzIGFuZCBjb21wb25l" +
               "bnRzIHdoZXJlIGEgZGlzdGluY3Rpb24gaXMgbWFkZSBiZXR3ZWVuIHN3aXRjaGVkIG9uIGFuZCBpbiBv" +
               "cGVyYXRpb24uIEZvciBleGFtcGxlLCBhIGRyaXZlIG1pZ2h0IGJlIHBvd2VyZWQgb24gYnV0IG5vdCBv" +
               "cGVyYXRpbmcuIEl0IGlzIG5vdCBpbnRlbmRlZCBmb3IgbWFjaGluZXMgb3IgY29tcG9uZW50cyBhbHdh" +
               "eXMgcGVyZm9ybWluZyBhbiBhY3Rpdml0eSBsaWtlIHNlbnNvcnMgYWx3YXlzIG1lYXN1cmluZyBkYXRh" +
               "LiBUaGlzIHZhbHVlIHNoYWxsIG9ubHkgaW5jcmVhc2UgZHVyaW5nIHRoZSBsaWZldGltZSBvZiB0aGUg" +
               "TWFjaGluZXJ5SXRlbSBhbmQgc2hhbGwgbm90IGJlIHJlc2V0IHdoZW4gaXQgaXMgcmVzdGFydGVkLiBU" +
               "aGUgT3BlcmF0aW9uRHVyYXRpb24gaXMgcHJvdmlkZWQgYXMgRHVyYXRpb24sIGkuZS4sIGluIG1pbGxp" +
               "c2Vjb25kcyBvciBldmVuIGZyYWN0aW9ucyBvZiBhIG1pbGxpc2Vjb25kLiBIb3dldmVyLCB0aGUgU2Vy" +
               "dmVyIGlzIG5vdCBleHBlY3RlZCB0byB1cGRhdGUgdGhlIHZhbHVlIGluIHN1Y2ggYSBoaWdoIGZyZXF1" +
               "ZW5jeSwgYnV0IG1heWJlIG9uY2UgYSBtaW51dGUgb3Igb25jZSBhbiBob3VyLCBkZXBlbmRpbmcgb24g" +
               "dGhlIGFwcGxpY2F0aW9uLgAuAEQAUMAXAAABACIB/////wMD/////wAAAAA1YIkLAgAAAAMADwAAAFBv" +
               "d2VyT25EdXJhdGlvbgEBvxcDAAAAAEUDAABQb3dlck9uRHVyYXRpb24gaXMgdGhlIGR1cmF0aW9uIHRo" +
               "ZSBNYWNoaW5lcnlJdGVtIGhhcyBiZWVuIHBvd2VyZWQuIFRoZSBtYWluIHB1cnBvc2UgaXMgdG8gZGV0" +
               "ZXJtaW5lIHRoZSB0aW1lIGluIHdoaWNoIGRlZ3JhZGF0aW9uIG9mIHRoZSBNYWNoaW5lcnlJdGVtIG9j" +
               "Y3VycmVkLiBUaGUgZGV0YWlscywgd2hlbiB0aGUgdGltZSBpcyBjb3VudGVkLCBpcyBpbXBsZW1lbnRh" +
               "dGlvbi1zcGVjaWZpYy4gQ29tcGFuaW9uIHNwZWNpZmljYXRpb25zIG1pZ2h0IGRlZmluZSBzcGVjaWZp" +
               "YyBydWxlcy4gVHlwaWNhbGx5LCB3aGVuIHRoZSBNYWNoaW5lcnlJdGVtIGhhcyBzdXBwbHkgdm9sdGFn" +
               "ZSBhbmQgdGhlIG1haW4gQ1BVIGlzIHJ1bm5pbmcsIHRoZSB0aW1lIGlzIGNvdW50ZWQuIFRoaXMgbWF5" +
               "IGluY2x1ZGUgYW55IGtpbmQgb2Ygc2xlZXAgbW9kZSwgYnV0IG1heSBub3QgaW5jbHVkZSBwdXJlIFdh" +
               "a2Ugb24gTEFOLiBUaGlzIHZhbHVlIHNoYWxsIG9ubHkgaW5jcmVhc2UgZHVyaW5nIHRoZSBsaWZldGlt" +
               "ZSBvZiB0aGUgTWFjaGluZXJ5SXRlbSBhbmQgc2hhbGwgbm90IGJlIHJlc2V0IHdoZW4gaXQgaXMgcmVz" +
               "dGFydGVkLiBUaGUgUG93ZXJPbkR1cmF0aW9uIGlzIHByb3ZpZGVkIGFzIER1cmF0aW9uLCBpLmUuLCBp" +
               "biBtaWxsaXNlY29uZHMgb3IgZXZlbiBmcmFjdGlvbnMgb2YgYSBtaWxsaXNlY29uZC4gSG93ZXZlciwg" +
               "dGhlIFNlcnZlciBpcyBub3QgZXhwZWN0ZWQgdG8gdXBkYXRlIHRoZSB2YWx1ZSBpbiBzdWNoIGEgaGln" +
               "aCBmcmVxdWVuY3ksIGJ1dCBtYXliZSBvbmNlIGEgbWludXRlIG9yIG9uY2UgYW4gaG91ciwgZGVwZW5k" +
               "aW5nIG9uIHRoZSBhcHBsaWNhdGlvbi4ALgBEAFC/FwAAAQAiAf////8DA/////8AAAAAJGAAEAgAAAAB" +
               "ABwAAABNYWNoaW5lcnlFcXVpcG1lbnRGb2xkZXJUeXBlAQH1AwMAAAAAQQAAAERlZmluZXMgYW4gZW50" +
               "cnkgcG9pbnQgZm9yIE1hY2hpbmVyeUVxdWlwbWVudCBvZiBhIE1hY2hpbmVyeUl0ZW0uAD3/////AgAA" +
               "ACRgwAsBAAAAHgAAAE1hY2hpbmVyeUVxdWlwbWVudF9QbGFjZWhvbGRlcgEAFAAAADxNYWNoaW5lcnlF" +
               "cXVpcG1lbnQ+AQG8EwMAAAAATwAAAFBsYWNlaG9sZGVyIGZvciBNYWNoaW5lcnlFcXVpcG1lbnQgdGhh" +
               "dCBpbXBsZW1lbnRzIHRoZSBJTWFjaGluZXJ5RXF1aXBtZW50VHlwZS4ALwA6AQD0LLwTAAACAAAAAQDD" +
               "RAABAe8DAQDDRAABA7s6CQAAADVgiQsCAAAAAwAHAAAAQXNzZXRJZAEB0BcDAAAAAIUAAABDb21wYW55" +
               "d2lkZSB1bmlxdWUgSUQgZm9yIGEgc3BlY2lmaWMgYXNzZXQgKEVhY2ggOCBtbSBkcmlsbCBvZiBhIGNv" +
               "bXBhbnkgaGFzIHRoZSBzYW1lIE1hY2hpbmVyeUVxdWlwbWVudFR5cGVJZCBhbmQgYSB1bmlxdWUgQXNz" +
               "ZXRJZCkuAC4ARABQ0BcAAAAM/////wMD/////wAAAAA1YIkLAgAAAAMADQAAAENvbXBvbmVudE5hbWUB" +
               "AdEXAwAAAAAlAAAAVXNlZCBuYW1lIGZvciB0aGUgTWFjaGluZXJ5RXF1aXBtZW50LgAuAEQAUNEXAAAA" +
               "Ff////8DA/////8AAAAANWCJCwIAAAABAAsAAABEZXNjcmlwdGlvbgEB0hcDAAAAAMMAAABBZGRpdGlv" +
               "bmFsIGluZm9ybWF0aW9uIGFuZCBkZXNjcmlwdGlvbiBhYm91dCB0aGUgTWFjaGluZXJ5RXF1aXBtZW50" +
               "LiBTaG91bGQgYmUgdXNlZCBpZiBEZXNjcmlwdGlvbiBBdHRyaWJ1dGUgY2Fubm90IGJlIHdyaXR0ZW4g" +
               "dmlhIE9QQyBVQSBhbmQgc2hvdWxkIGJlIGlkZWFsbHkgaWRlbnRpY2FsIHRvIERlc2NyaXB0aW9uIEF0" +
               "dHJpYnV0ZS4ALgBEAFDSFwAAABX/////AwP/////AAAAADVgiQsCAAAAAwALAAAARGV2aWNlQ2xhc3MB" +
               "AdMXAwAAAABcAAAAQ2xhc3Mgb2YgdGhlIE1hY2hpbmVyeUVxdWlwbWVudCAoZS5nLjogRWFjaCBkcmls" +
               "bCBvZiBhIGNvbXBhbnkgaGFzIHRoZSBEZXZpY2VDbGFzcyAiZHJpbGwiKS4ALgBEAFDTFwAAAAz/////" +
               "AQH/////AAAAADVgiQsCAAAAAQAIAAAATG9jYXRpb24BAdQXAwAAAABzAAAATG9jYXRpb24gb2YgdGhl" +
               "IE1hY2hpbmVyeUVxdWlwbWVudCAoZS5nLjogU3RvcmFnZSBMb2NhdGlvbjsgUG9zaXRpb24gaW4gdGhl" +
               "IFRvb2wgQ2hhbmdlcjsgUG9zaXRpb24gb24gdGhlIG1hY2hpbmUpLgAuAEQAUNQXAAAADP////8DA///" +
               "//8AAAAANWCJCwIAAAABABgAAABNYWNoaW5lcnlFcXVpcG1lbnRUeXBlSWQBAdUXAwAAAACMAAAASWRl" +
               "bnRpZmljYXRpb24gb2YgYSBnZW5lcmljIE1hY2hpbmVyeUVxdWlwbWVudC4gRGVmaW5lZCBieSBlYWNo" +
               "IGNvbXBhbnkgKGUuZy4sIGNvbXBhbnkgaGFzIGFuIE1hY2hpbmVyeUVxdWlwbWVudFR5cGVJZCBmb3Ig" +
               "YWxsIDggbW0gZHJpbGxzKS4ALgBEAE7VFwAAAAz/////AwP/////AAAAADVgiQsCAAAAAwAPAAAATWFu" +
               "dWZhY3R1cmVyVXJpAQHWFwMAAAAAJwAAAE1hbnVmYWN0dXJlciBvZiB0aGUgTWFjaGluZXJ5RXF1aXBt" +
               "ZW50LgAuAEQAUNYXAAAADP////8BAf////8AAAAANWCJCwIAAAADAAUAAABNb2RlbAEB1xcDAAAAACAA" +
               "AABNb2RlbCBvZiB0aGUgTWFjaGluZXJ5RXF1aXBtZW50LgAuAEQAUNcXAAAAFf////8BAf////8AAAAA" +
               "NWCJCwIAAAADAAwAAABTZXJpYWxOdW1iZXIBAdgXAwAAAAAoAAAAU2VyaWFsIE51bWJlciBvZiB0aGUg" +
               "TWFjaGluZXJ5RXF1aXBtZW50LgAuAEQAUNgXAAAADP////8BAf////8AAAAANWCpCgIAAAAAABkAAABE" +
               "ZWZhdWx0SW5zdGFuY2VCcm93c2VOYW1lAQHZFwMAAAAAMQAAAFRoZSBkZWZhdWx0IEJyb3dzZU5hbWUg" +
               "Zm9yIGluc3RhbmNlcyBvZiB0aGUgdHlwZS4ALgBE2RcAABQBABIAAABNYWNoaW5lcnlFcXVpcG1lbnQA" +
               "FP////8DA/////8AAAAABGAAEAgAAAABABwAAABNYWNoaW5lcnlMaWZldGltZUNvdW50ZXJUeXBlAQH3" +
               "AwA9/////wIAAAAVYMkLAgAAABwAAABMaWZldGltZVZhcmlhYmxlX1BsYWNlaG9sZGVyAQASAAAAPExp" +
               "ZmV0aW1lVmFyaWFibGU+AQHDFwAvAQPUAQEA9izDFwAAABr/////AwP/////AwAAABVgiQsCAAAAAAAQ" +
               "AAAARW5naW5lZXJpbmdVbml0cwEBxhcALgBEAE7GFwAAAQB3A/////8BAf////8AAAAANWCJCwIAAAAD" +
               "AAoAAABTdGFydFZhbHVlAQHFFwMAAAAAUwAAAFN0YXJ0VmFsdWUgaW5kaWNhdGVzIHRoZSBpbml0aWFs" +
               "IHZhbHVlLCB3aGVuIHRoZXJlIGlzIHN0aWxsIHRoZSBmdWxsIGxpZmV0aW1lIGxlZnQuAC4ARABOxRcA" +
               "AAAa/////wEB/////wAAAAA1YIkLAgAAAAMACgAAAExpbWl0VmFsdWUBAcQXAwAAAAA/AAAATGltaXRW" +
               "YWx1ZSBpbmRpY2F0ZXMgd2hlbiB0aGUgZW5kIG9mIGxpZmV0aW1lIGhhcyBiZWVuIHJlYWNoZWQuAC4A" +
               "RABOxBcAAAAa/////wEB/////wAAAAA1YKkKAgAAAAAAGQAAAERlZmF1bHRJbnN0YW5jZUJyb3dzZU5h" +
               "bWUBAccXAwAAAAAwAAAAVGhlIGRlZmF1bHQgQnJvd3NlTmFtZSBmb3IgaW5zdGFuY2VzIG9mIHRoZSB0" +
               "eXBlAC4ARMcXAAAUAQAQAAAATGlmZXRpbWVDb3VudGVycwAU/////wMD/////wAAAAAkYAAQCAAAAAEA" +
               "DgAAAE1vbml0b3JpbmdUeXBlAQH2AwMAAAAAOgAAAEVudHJ5IHBvaW50IGZvciBtb25pdG9yaW5nIGlu" +
               "Zm9ybWF0aW9uIG9mIGEgTWFjaGluZXJ5SXRlbS4APf////8FAAAAJGCACwEAAAABAAsAAABDb25zdW1w" +
               "dGlvbgEBtxMDAAAAAD0AAABFbnRyeSBwb2ludCBmb3IgY29uc3VtcHRpb24gaW5mb3JtYXRpb24gb2Yg" +
               "dGhlIE1hY2hpbmVyeUl0ZW0uAC8APQBQtxMAAP////8AAAAANWCpCgIAAAAAABkAAABEZWZhdWx0SW5z" +
               "dGFuY2VCcm93c2VOYW1lAQHJFwMAAAAAMQAAAFRoZSBkZWZhdWx0IEJyb3dzZU5hbWUgZm9yIGluc3Rh" +
               "bmNlcyBvZiB0aGUgdHlwZS4ALgBEyRcAABQBAAoAAABNb25pdG9yaW5nABT/////AQH/////AAAAACRg" +
               "gAsBAAAAAQAGAAAASGVhbHRoAQG1EwMAAAAANwAAAEVudHJ5IHBvaW50IG9mIGhlYWx0aCBpbmZvcm1h" +
               "dGlvbiBvZiB0aGUgTWFjaGluZXJ5SXRlbS4ALwA9AFC1EwAAAQAAAAEAw0QAAQPLOgIAAAAVYIkLAgAA" +
               "AAMADAAAAERldmljZUhlYWx0aAEBzxcALwA/AFDPFwAAAQNkGP////8DA/////8AAAAABGCACwEAAAAD" +
               "ABIAAABEZXZpY2VIZWFsdGhBbGFybXMBAbsTAC8APQBQuxMAAP////8AAAAAJGCACwEAAAABAAcAAABQ" +
               "cm9jZXNzAQG2EwMAAAAAOQAAAEVudHJ5IHBvaW50IGZvciBwcm9jZXNzIGluZm9ybWF0aW9uIG9mIHRo" +
               "ZSBNYWNoaW5lcnlJdGVtLgAvAD0AULYTAAD/////AAAAACRggAsBAAAAAQAGAAAAU3RhdHVzAQG0EwMA" +
               "AAAA8wAAAEVudHJ5IHBvaW50IGZvciBzdGF0dXMgaW5mb3JtYXRpb24gb2YgdGhlIE1hY2hpbmVyeUl0" +
               "ZW0uIElmIHRoaXMgT2JqZWN0IGlzIHByb3ZpZGVkLCBhbmQgdGhlIE1hY2hpbmVyeUl0ZW1TdGF0ZSBp" +
               "cyBwcm92aWRlZCwgaXQgc2hhbGwgYmUgcmVmZXJlbmNlZC4gSWYgdGhpcyBPYmplY3QgaXMgcHJvdmlk" +
               "ZWQgYW5kIHRoZSBNYWNoaW5lcnlPcGVyYXRpb25Nb2RlIGlzIHByb3ZpZGVkLCBpdCBzaGFsbCBiZSBy" +
               "ZWZlcmVuY2VkLgAvAD0AULQTAAD/////AwAAAARggAsBAAAAAQASAAAATWFjaGluZXJ5SXRlbVN0YXRl" +
               "AQG4EwAvAQHqAwBQuBMAAP////8BAAAAFWCJCwIAAAAAAAwAAABDdXJyZW50U3RhdGUBAcoXAC8BAMgK" +
               "AE7KFwAAABX/////AQH/////AQAAABVgiQsCAAAAAAACAAAASWQBAcsXAC4ARABOyxcAAAAR/////wEB" +
               "/////wAAAAAEYIALAQAAAAEAFgAAAE1hY2hpbmVyeU9wZXJhdGlvbk1vZGUBAbkTAC8BAfADAFC5EwAA" +
               "/////wEAAAAVYIkLAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBzBcALwEAyAoATswXAAAAFf////8BAf//" +
               "//8BAAAAFWCJCwIAAAAAAAIAAABJZAEBzRcALgBEAE7NFwAAABH/////AQH/////AAAAAARggAsBAAAA" +
               "AQAKAAAAU3RhY2tsaWdodAEBuhMALwEC6gMAULoTAAD/////AQAAADVgiQsCAAAAAgAOAAAAU3RhY2ts" +
               "aWdodE1vZGUBAc4XAwAAAABnAAAAU2hvd3MgaW4gd2hhdCB3YXkgKHN0YWNrIG9mIGluZGl2aWR1YWwg" +
               "bGlnaHRzLCBsZXZlbCBtZXRlciwgcnVubmluZyBsaWdodCkgdGhlIHN0YWNrbGlnaHQgdW5pdCBpcyB1" +
               "c2VkLgAuAEQATs4XAAABAroL/////wMD/////wAAAAAkYAAQCAAAAAEAEQAAAE5vdGlmaWNhdGlvbnNU" +
               "eXBlAQH5AwMAAAAALAAAAFByb3ZpZGVzIG5vdGlmaWNhdGlvbnMgYXMgZXZlbnRzIG9yIG9iamVjdHMu" +
               "AD3/////AQAAADVgqQoCAAAAAAAZAAAARGVmYXVsdEluc3RhbmNlQnJvd3NlTmFtZQEB2hcDAAAAADEA" +
               "AABUaGUgZGVmYXVsdCBCcm93c2VOYW1lIGZvciBpbnN0YW5jZXMgb2YgdGhlIHR5cGUuAC4ARNoXAAAU" +
               "AQANAAAATm90aWZpY2F0aW9ucwAU/////wMD/////wAAAAAkYAAQCAAAAAEAFQAAAE1hY2hpbmVDb21w" +
               "b25lbnRzVHlwZQEB7gMDAAAAADEAAABDb250YWlucyBhbGwgaWRlbnRpZmlhYmxlIGNvbXBvbmVudHMg" +
               "b2YgYSBtYWNoaW5lADr/////AgAAACRgwAsBAAAAFQAAAENvbXBvbmVudF9QbGFjZWhvbGRlcgEACwAA" +
               "ADxDb21wb25lbnQ+AQGKEwMAAAAANAAAAFJlcHJlc2VudHMgdGhlIGlkZW50aWZpYWJsZSBjb21wb25l" +
               "bnRzIG9mIGEgbWFjaGluZS4ALwA6AQD0LIoTAAD/////AQAAACRggAsBAAAAAwAOAAAASWRlbnRpZmlj" +
               "YXRpb24BAYsTAwAAAABOAAAAQ29udGFpbnMgaW5mb3JtYXRpb24gYWJvdXQgdGhlIGlkZW50aWZpY2F0" +
               "aW9uIGFuZCBuYW1lcGxhdGUgb2YgYSBNYWNoaW5lcnlJdGVtAQDERAEB7AMATosTAAACAAAAAQDDRAAB" +
               "AesDAQDDRAABA8g6AgAAADVgiQsCAAAAAwAMAAAATWFudWZhY3R1cmVyAQGDFwMAAAAASgAAAEEgaHVt" +
               "YW4tcmVhZGFibGUsIGxvY2FsaXplZCBuYW1lIG9mIHRoZSBtYW51ZmFjdHVyZXIgb2YgdGhlIE1hY2hp" +
               "bmVyeUl0ZW0uAC4ARABOgxcAAAAV/////wEB/////wAAAAA1YIkLAgAAAAMADAAAAFNlcmlhbE51bWJl" +
               "cgEBhBcDAAAAABcBAABBIHN0cmluZyBjb250YWluaW5nIGEgdW5pcXVlIHByb2R1Y3Rpb24gbnVtYmVy" +
               "IG9mIHRoZSBtYW51ZmFjdHVyZXIgb2YgdGhlIE1hY2hpbmVyeUl0ZW0uIFRoZSBnbG9iYWwgdW5pcXVl" +
               "bmVzcyBvZiB0aGUgc2VyaWFsIG51bWJlciBpcyBvbmx5IGdpdmVuIGluIHRoZSBjb250ZXh0IG9mIHRo" +
               "ZSBtYW51ZmFjdHVyZXIsIGFuZCBwb3RlbnRpYWxseSB0aGUgbW9kZWwuIFRoZSB2YWx1ZSBzaGFsbCBu" +
               "b3QgY2hhbmdlIGR1cmluZyB0aGUgbGlmZS1jeWNsZSBvZiB0aGUgTWFjaGluZXJ5SXRlbS4ALgBEAE6E" +
               "FwAAAAz/////AQH/////AAAAADVgqQoCAAAAAAAZAAAARGVmYXVsdEluc3RhbmNlQnJvd3NlTmFtZQEB" +
               "ghcDAAAAADEAAABUaGUgZGVmYXVsdCBCcm93c2VOYW1lIGZvciBpbnN0YW5jZXMgb2YgdGhlIHR5cGUu" +
               "AC4ARIIXAAAUAQAKAAAAQ29tcG9uZW50cwAU/////wMD/////wAAAAAkYAAQCAAAAAEAIwAAAE1hY2hp" +
               "bmVyeUl0ZW1TdGF0ZV9TdGF0ZU1hY2hpbmVUeXBlAQHqAwMAAAAAOAAAAFN0YXRlIG1hY2hpbmUgcmVw" +
               "cmVzZW50aW5nIHRoZSBzdGF0ZSBvZiBhIG1hY2hpbmVyeSBpdGVtAQDTCv////8VAAAANWCpCgIAAAAA" +
               "ABkAAABEZWZhdWx0SW5zdGFuY2VCcm93c2VOYW1lAQGFFwMAAAAAMAAAAFRoZSBkZWZhdWx0IEJyb3dz" +
               "ZU5hbWUgZm9yIGluc3RhbmNlcyBvZiB0aGUgdHlwZQAuAESFFwAAFAEAEgAAAE1hY2hpbmVyeUl0ZW1T" +
               "dGF0ZQAU/////wMD/////wAAAAAkYIAKAQAAAAEACQAAAEV4ZWN1dGluZwEBjhMDAAAAAGAAAABUaGUg" +
               "bWFjaGluZSBpcyBhdmFpbGFibGUgJiBmdW5jdGlvbmFsIGFuZCBpcyBhY3RpdmVseSBwZXJmb3JtaW5n" +
               "IGFuIGFjdGl2aXR5IChwdXJzdWVzIGEgcHVycG9zZSkALwEAAwmOEwAACAAAAAA0AQEBkhMANAEBAZYT" +
               "ADQBAQGaEwAzAQEBnBMAMwEBAZ0TADMBAQGeEwAzAQEBnxMANAEBAZ8TAQAAABVgqQsCAAAAAAALAAAA" +
               "U3RhdGVOdW1iZXIBAZgXAC4ARABOmBcAAAcDAAAAAAf/////AQH/////AAAAACRggAoBAAAAAQAYAAAA" +
               "RnJvbUV4ZWN1dGluZ1RvRXhlY3V0aW5nAQGfEwMAAAAAMgAAAFRyYW5zaXRpb24gZnJvbSBzdGF0ZSBF" +
               "eGVjdXRpbmcgdG8gc3RhdGUgRXhlY3V0aW5nAC8BAAYJnxMAAAIAAAAAMwABAY4TADQAAQGOEwEAAAAV" +
               "YKkLAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAakXAC4ARABOqRcAAAcOAAAAAAf/////AQH/////" +
               "AAAAACRggAoBAAAAAQAbAAAARnJvbUV4ZWN1dGluZ1RvTm90QXZhaWxhYmxlAQGcEwMAAAAANQAAAFRy" +
               "YW5zaXRpb24gZnJvbSBzdGF0ZSBFeGVjdXRpbmcgdG8gc3RhdGUgTm90QXZhaWxhYmxlAC8BAAYJnBMA" +
               "AAIAAAAAMwABAY4TADQAAQGNEwEAAAAVYKkLAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAaYXAC4A" +
               "RABOphcAAAcGAAAAAAf/////AQH/////AAAAACRggAoBAAAAAQAbAAAARnJvbUV4ZWN1dGluZ1RvTm90" +
               "RXhlY3V0aW5nAQGeEwMAAAAANQAAAFRyYW5zaXRpb24gZnJvbSBzdGF0ZSBFeGVjdXRpbmcgdG8gc3Rh" +
               "dGUgTm90RXhlY3V0aW5nAC8BAAYJnhMAAAIAAAAAMwABAY4TADQAAQGPEwEAAAAVYKkLAgAAAAAAEAAA" +
               "AFRyYW5zaXRpb25OdW1iZXIBAagXAC4ARABOqBcAAAcIAAAAAAf/////AQH/////AAAAACRggAoBAAAA" +
               "AQAbAAAARnJvbUV4ZWN1dGluZ1RvT3V0T2ZTZXJ2aWNlAQGdEwMAAAAANQAAAFRyYW5zaXRpb24gZnJv" +
               "bSBzdGF0ZSBFeGVjdXRpbmcgdG8gc3RhdGUgT3V0T2ZTZXJ2aWNlAC8BAAYJnRMAAAIAAAAAMwABAY4T" +
               "ADQAAQGMEwEAAAAVYKkLAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAacXAC4ARABOpxcAAAcHAAAA" +
               "AAf/////AQH/////AAAAACRggAoBAAAAAQAbAAAARnJvbU5vdEF2YWlsYWJsZVRvRXhlY3V0aW5nAQGS" +
               "EwMAAAAANQAAAFRyYW5zaXRpb24gZnJvbSBzdGF0ZSBOb3RBdmFpbGFibGUgdG8gc3RhdGUgRXhlY3V0" +
               "aW5nAC8BAAYJkhMAAAIAAAAANAABAY4TADMAAQGNEwEAAAAVYKkLAgAAAAAAEAAAAFRyYW5zaXRpb25O" +
               "dW1iZXIBAZwXAC4ARABOnBcAAAcBAAAAAAf/////AQH/////AAAAACRggAoBAAAAAQAeAAAARnJvbU5v" +
               "dEF2YWlsYWJsZVRvTm90QXZhaWxhYmxlAQGTEwMAAAAAOAAAAFRyYW5zaXRpb24gZnJvbSBzdGF0ZSBO" +
               "b3RBdmFpbGFibGUgdG8gc3RhdGUgTm90QXZhaWxhYmxlAC8BAAYJkxMAAAIAAAAAMwABAY0TADQAAQGN" +
               "EwEAAAAVYKkLAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAZ0XAC4ARABOnRcAAAcMAAAAAAf/////" +
               "AQH/////AAAAACRggAoBAAAAAQAeAAAARnJvbU5vdEF2YWlsYWJsZVRvTm90RXhlY3V0aW5nAQGREwMA" +
               "AAAAOAAAAFRyYW5zaXRpb24gZnJvbSBzdGF0ZSBOb3RBdmFpbGFibGUgdG8gc3RhdGUgTm90RXhlY3V0" +
               "aW5nAC8BAAYJkRMAAAIAAAAAMwABAY0TADQAAQGPEwEAAAAVYKkLAgAAAAAAEAAAAFRyYW5zaXRpb25O" +
               "dW1iZXIBAZsXAC4ARABOmxcAAAcCAAAAAAf/////AQH/////AAAAACRggAoBAAAAAQAeAAAARnJvbU5v" +
               "dEF2YWlsYWJsZVRvT3V0T2ZTZXJ2aWNlAQGQEwMAAAAAOAAAAFRyYW5zaXRpb24gZnJvbSBzdGF0ZSBO" +
               "b3RBdmFpbGFibGUgdG8gc3RhdGUgT3V0T2ZTZXJ2aWNlAC8BAAYJkBMAAAIAAAAAMwABAY0TADQAAQGM" +
               "EwEAAAAVYKkLAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAZoXAC4ARABOmhcAAAcAAAAAAAf/////" +
               "AQH/////AAAAACRggAoBAAAAAQAbAAAARnJvbU5vdEV4ZWN1dGluZ1RvRXhlY3V0aW5nAQGaEwMAAAAA" +
               "NQAAAFRyYW5zaXRpb24gZnJvbSBzdGF0ZSBOb3RFeGVjdXRpbmcgdG8gc3RhdGUgRXhlY3V0aW5nAC8B" +
               "AAYJmhMAAAIAAAAANAABAY4TADMAAQGPEwEAAAAVYKkLAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIB" +
               "AaQXAC4ARABOpBcAAAcLAAAAAAf/////AQH/////AAAAACRggAoBAAAAAQAeAAAARnJvbU5vdEV4ZWN1" +
               "dGluZ1RvTm90QXZhaWxhYmxlAQGYEwMAAAAAOAAAAFRyYW5zaXRpb24gZnJvbSBzdGF0ZSBOb3RFeGVj" +
               "dXRpbmcgdG8gc3RhdGUgTm90QXZhaWxhYmxlAC8BAAYJmBMAAAIAAAAANAABAY0TADMAAQGPEwEAAAAV" +
               "YKkLAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAaIXAC4ARABOohcAAAcJAAAAAAf/////AQH/////" +
               "AAAAACRggAoBAAAAAQAeAAAARnJvbU5vdEV4ZWN1dGluZ1RvTm90RXhlY3V0aW5nAQGbEwMAAAAAOAAA" +
               "AFRyYW5zaXRpb24gZnJvbSBzdGF0ZSBOb3RFeGVjdXRpbmcgdG8gc3RhdGUgTm90RXhlY3V0aW5nAC8B" +
               "AAYJmxMAAAIAAAAAMwABAY8TADQAAQGPEwEAAAAVYKkLAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIB" +
               "AaUXAC4ARABOpRcAAAcPAAAAAAf/////AQH/////AAAAACRggAoBAAAAAQAeAAAARnJvbU5vdEV4ZWN1" +
               "dGluZ1RvT3V0T2ZTZXJ2aWNlAQGZEwMAAAAAOAAAAFRyYW5zaXRpb24gZnJvbSBzdGF0ZSBOb3RFeGVj" +
               "dXRpbmcgdG8gc3RhdGUgT3V0T2ZTZXJ2aWNlAC8BAAYJmRMAAAIAAAAAMwABAY8TADQAAQGMEwEAAAAV" +
               "YKkLAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAaMXAC4ARABOoxcAAAcKAAAAAAf/////AQH/////" +
               "AAAAACRggAoBAAAAAQAbAAAARnJvbU91dE9mU2VydmljZVRvRXhlY3V0aW5nAQGWEwMAAAAANQAAAFRy" +
               "YW5zaXRpb24gZnJvbSBzdGF0ZSBPdXRPZlNlcnZpY2UgdG8gc3RhdGUgRXhlY3V0aW5nAC8BAAYJlhMA" +
               "AAIAAAAANAABAY4TADMAAQGMEwEAAAAVYKkLAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAaAXAC4A" +
               "RABOoBcAAAcEAAAAAAf/////AQH/////AAAAACRggAoBAAAAAQAeAAAARnJvbU91dE9mU2VydmljZVRv" +
               "Tm90QXZhaWxhYmxlAQGUEwMAAAAAOAAAAFRyYW5zaXRpb24gZnJvbSBzdGF0ZSBPdXRPZlNlcnZpY2Ug" +
               "dG8gc3RhdGUgTm90QXZhaWxhYmxlAC8BAAYJlBMAAAIAAAAANAABAY0TADMAAQGMEwEAAAAVYKkLAgAA" +
               "AAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAZ4XAC4ARABOnhcAAAcDAAAAAAf/////AQH/////AAAAACRg" +
               "gAoBAAAAAQAeAAAARnJvbU91dE9mU2VydmljZVRvTm90RXhlY3V0aW5nAQGVEwMAAAAAOAAAAFRyYW5z" +
               "aXRpb24gZnJvbSBzdGF0ZSBPdXRPZlNlcnZpY2UgdG8gc3RhdGUgTm90RXhlY3V0aW5nAC8BAAYJlRMA" +
               "AAIAAAAANAABAY8TADMAAQGMEwEAAAAVYKkLAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAZ8XAC4A" +
               "RABOnxcAAAcFAAAAAAf/////AQH/////AAAAACRggAoBAAAAAQAeAAAARnJvbU91dE9mU2VydmljZVRv" +
               "T3V0T2ZTZXJ2aWNlAQGXEwMAAAAAOAAAAFRyYW5zaXRpb24gZnJvbSBzdGF0ZSBPdXRPZlNlcnZpY2Ug" +
               "dG8gc3RhdGUgT3V0T2ZTZXJ2aWNlAC8BAAYJlxMAAAIAAAAAMwABAYwTADQAAQGMEwEAAAAVYKkLAgAA" +
               "AAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAaEXAC4ARABOoRcAAAcNAAAAAAf/////AQH/////AAAAACRg" +
               "gAoBAAAAAQAMAAAATm90QXZhaWxhYmxlAQGNEwMAAAAAagAAAFRoZSBtYWNoaW5lIGlzIG5vdCBhdmFp" +
               "bGFibGUgYW5kIGRvZXMgbm90IHBlcmZvcm0gYW55IGFjdGl2aXR5IChlLmcuLCBzd2l0Y2hlZCBvZmYs" +
               "IGluIGVuZXJneSBzYXZpbmcgbW9kZSkALwEAAwmNEwAACAAAAAA0AQEBnBMAMwEBAZITADMBAQGTEwA0" +
               "AQEBkxMAMwEBAZETADMBAQGQEwA0AQEBmBMANAEBAZQTAQAAABVgqQsCAAAAAAALAAAAU3RhdGVOdW1i" +
               "ZXIBAZcXAC4ARABOlxcAAAcAAAAAAAf/////AQH/////AAAAACRggAoBAAAAAQAMAAAATm90RXhlY3V0" +
               "aW5nAQGPEwMAAAAAjAAAAFRoZSBtYWNoaW5lIGlzIGF2YWlsYWJsZSAmIGZ1bmN0aW9uYWwgYW5kIGRv" +
               "ZXMgbm90IHBlcmZvcm0gYW55IGFjdGl2aXR5LiBJdCB3YWl0cyBmb3IgYW4gYWN0aW9uIGZyb20gb3V0" +
               "c2lkZSB0byBzdGFydCBvciByZXN0YXJ0IGFuIGFjdGl2aXR5AC8BAAMJjxMAAAgAAAAANAEBAZ4TADQB" +
               "AQGREwAzAQEBmhMAMwEBAZgTADMBAQGbEwA0AQEBmxMAMwEBAZkTADQBAQGVEwEAAAAVYKkLAgAAAAAA" +
               "CwAAAFN0YXRlTnVtYmVyAQGZFwAuAEQATpkXAAAHAgAAAAAH/////wEB/////wAAAAAkYIAKAQAAAAEA" +
               "DAAAAE91dE9mU2VydmljZQEBjBMDAAAAAFYAAABUaGUgbWFjaGluZSBpcyBub3QgZnVuY3Rpb25hbCBh" +
               "bmQgZG9lcyBub3QgcGVyZm9ybSBhbnkgYWN0aXZpdHkgKGUuZy4sIGVycm9yLCBibG9ja2VkKQAvAQAD" +
               "CYwTAAAIAAAAADQBAQGdEwA0AQEBkBMANAEBAZkTADMBAQGWEwAzAQEBlBMAMwEBAZUTADMBAQGXEwA0" +
               "AQEBlxMBAAAAFWCpCwIAAAAAAAsAAABTdGF0ZU51bWJlcgEBlhcALgBEAE6WFwAABwEAAAAAB/////8B" +
               "Af////8AAAAAJGAAEAgAAAABACYAAABNYWNoaW5lcnlPcGVyYXRpb25Nb2RlU3RhdGVNYWNoaW5lVHlw" +
               "ZQEB8AMDAAAAAEAAAABTdGF0ZSBtYWNoaW5lIHJlcHJlc2VudGluZyB0aGUgb3BlcmF0aW9uIG1vZGUg" +
               "b2YgYSBNYWNoaW5lcnlJdGVtAQDTCv////8VAAAANWCpCgIAAAAAABkAAABEZWZhdWx0SW5zdGFuY2VC" +
               "cm93c2VOYW1lAQGqFwMAAAAAMAAAAFRoZSBkZWZhdWx0IEJyb3dzZU5hbWUgZm9yIGluc3RhbmNlcyBv" +
               "ZiB0aGUgdHlwZQAuAESqFwAAFAEAFgAAAE1hY2hpbmVyeU9wZXJhdGlvbk1vZGUAFP////8DA/////8A" +
               "AAAAJGCACgEAAAABABwAAABGcm9tTWFpbnRlbmFuY2VUb01haW50ZW5hbmNlAQGrEwMAAAAANgAAAFRy" +
               "YW5zaXRpb24gZnJvbSBzdGF0ZSBNYWludGVuYW5jZSB0byBzdGF0ZSBNYWludGVuYW5jZQAvAQAGCasT" +
               "AAACAAAAADMAAQGhEwA0AAEBoRMBAAAAFWCpCwIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQG2FwAu" +
               "AEQATrYXAAAHDQAAAAAH/////wEB/////wAAAAAkYIAKAQAAAAEAFQAAAEZyb21NYWludGVuYW5jZVRv" +
               "Tm9uZQEBqBMDAAAAAC8AAABUcmFuc2l0aW9uIGZyb20gc3RhdGUgTWFpbnRlbmFuY2UgdG8gc3RhdGUg" +
               "Tm9uZQAvAQAGCagTAAACAAAAADMAAQGhEwA0AAEBoBMBAAAAFWCpCwIAAAAAABAAAABUcmFuc2l0aW9u" +
               "TnVtYmVyAQGzFwAuAEQATrMXAAAHAwAAAAAH/////wEB/////wAAAAAkYIAKAQAAAAEAGwAAAEZyb21N" +
               "YWludGVuYW5jZVRvUHJvY2Vzc2luZwEBqhMDAAAAADUAAABUcmFuc2l0aW9uIGZyb20gc3RhdGUgTWFp" +
               "bnRlbmFuY2UgdG8gc3RhdGUgUHJvY2Vzc2luZwAvAQAGCaoTAAACAAAAADMAAQGhEwA0AAEBohMBAAAA" +
               "FWCpCwIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQG1FwAuAEQATrUXAAAHBAAAAAAH/////wEB////" +
               "/wAAAAAkYIAKAQAAAAEAFgAAAEZyb21NYWludGVuYW5jZVRvU2V0dXABAakTAwAAAAAwAAAAVHJhbnNp" +
               "dGlvbiBmcm9tIHN0YXRlIE1haW50ZW5hbmNlIHRvIHN0YXRlIFNldHVwAC8BAAYJqRMAAAIAAAAAMwAB" +
               "AaETADQAAQGjEwEAAAAVYKkLAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAbQXAC4ARABOtBcAAAcF" +
               "AAAAAAf/////AQH/////AAAAACRggAoBAAAAAQAVAAAARnJvbU5vbmVUb01haW50ZW5hbmNlAQGkEwMA" +
               "AAAALwAAAFRyYW5zaXRpb24gZnJvbSBzdGF0ZSBOb25lIHRvIHN0YXRlIE1haW50ZW5hbmNlAC8BAAYJ" +
               "pBMAAAIAAAAANAABAaETADMAAQGgEwEAAAAVYKkLAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAa8X" +
               "AC4ARABOrxcAAAcAAAAAAAf/////AQH/////AAAAACRggAoBAAAAAQAOAAAARnJvbU5vbmVUb05vbmUB" +
               "AacTAwAAAAAoAAAAVHJhbnNpdGlvbiBmcm9tIHN0YXRlIE5vbmUgdG8gc3RhdGUgTm9uZQAvAQAGCacT" +
               "AAACAAAAADMAAQGgEwA0AAEBoBMBAAAAFWCpCwIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVyAQGyFwAu" +
               "AEQATrIXAAAHDAAAAAAH/////wEB/////wAAAAAkYIAKAQAAAAEAFAAAAEZyb21Ob25lVG9Qcm9jZXNz" +
               "aW5nAQGmEwMAAAAALgAAAFRyYW5zaXRpb24gZnJvbSBzdGF0ZSBOb25lIHRvIHN0YXRlIFByb2Nlc3Np" +
               "bmcALwEABgmmEwAAAgAAAAAzAAEBoBMANAABAaITAQAAABVgqQsCAAAAAAAQAAAAVHJhbnNpdGlvbk51" +
               "bWJlcgEBsRcALgBEAE6xFwAABwEAAAAAB/////8BAf////8AAAAAJGCACgEAAAABAA8AAABGcm9tTm9u" +
               "ZVRvU2V0dXABAaUTAwAAAAApAAAAVHJhbnNpdGlvbiBmcm9tIHN0YXRlIE5vbmUgdG8gc3RhdGUgU2V0" +
               "dXAALwEABgmlEwAAAgAAAAAzAAEBoBMANAABAaMTAQAAABVgqQsCAAAAAAAQAAAAVHJhbnNpdGlvbk51" +
               "bWJlcgEBsBcALgBEAE6wFwAABwIAAAAAB/////8BAf////8AAAAAJGCACgEAAAABABsAAABGcm9tUHJv" +
               "Y2Vzc2luZ1RvTWFpbnRlbmFuY2UBAbETAwAAAAA1AAAAVHJhbnNpdGlvbiBmcm9tIHN0YXRlIFByb2Nl" +
               "c3NpbmcgdG8gc3RhdGUgTWFpbnRlbmFuY2UALwEABgmxEwAAAgAAAAA0AAEBoRMAMwABAaITAQAAABVg" +
               "qQsCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBvBcALgBEAE68FwAABwcAAAAAB/////8BAf////8A" +
               "AAAAJGCACgEAAAABABQAAABGcm9tUHJvY2Vzc2luZ1RvTm9uZQEBsBMDAAAAAC4AAABUcmFuc2l0aW9u" +
               "IGZyb20gc3RhdGUgUHJvY2Vzc2luZyB0byBzdGF0ZSBOb25lAC8BAAYJsBMAAAIAAAAANAABAaATADMA" +
               "AQGiEwEAAAAVYKkLAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAbsXAC4ARABOuxcAAAcGAAAAAAf/" +
               "////AQH/////AAAAACRggAoBAAAAAQAaAAAARnJvbVByb2Nlc3NpbmdUb1Byb2Nlc3NpbmcBAbMTAwAA" +
               "AAA0AAAAVHJhbnNpdGlvbiBmcm9tIHN0YXRlIFByb2Nlc3NpbmcgdG8gc3RhdGUgUHJvY2Vzc2luZwAv" +
               "AQAGCbMTAAACAAAAADMAAQGiEwA0AAEBohMBAAAAFWCpCwIAAAAAABAAAABUcmFuc2l0aW9uTnVtYmVy" +
               "AQG+FwAuAEQATr4XAAAHDgAAAAAH/////wEB/////wAAAAAkYIAKAQAAAAEAFQAAAEZyb21Qcm9jZXNz" +
               "aW5nVG9TZXR1cAEBshMDAAAAAC8AAABUcmFuc2l0aW9uIGZyb20gc3RhdGUgUHJvY2Vzc2luZyB0byBz" +
               "dGF0ZSBTZXR1cAAvAQAGCbITAAACAAAAADMAAQGiEwA0AAEBoxMBAAAAFWCpCwIAAAAAABAAAABUcmFu" +
               "c2l0aW9uTnVtYmVyAQG9FwAuAEQATr0XAAAHCAAAAAAH/////wEB/////wAAAAAkYIAKAQAAAAEAFgAA" +
               "AEZyb21TZXR1cFRvTWFpbnRlbmFuY2UBAa0TAwAAAAAwAAAAVHJhbnNpdGlvbiBmcm9tIHN0YXRlIFNl" +
               "dHVwIHRvIHN0YXRlIE1haW50ZW5hbmNlAC8BAAYJrRMAAAIAAAAANAABAaETADMAAQGjEwEAAAAVYKkL" +
               "AgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAbgXAC4ARABOuBcAAAcKAAAAAAf/////AQH/////AAAA" +
               "ACRggAoBAAAAAQAPAAAARnJvbVNldHVwVG9Ob25lAQGsEwMAAAAAKQAAAFRyYW5zaXRpb24gZnJvbSBz" +
               "dGF0ZSBTZXR1cCB0byBzdGF0ZSBOb25lAC8BAAYJrBMAAAIAAAAANAABAaATADMAAQGjEwEAAAAVYKkL" +
               "AgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAbcXAC4ARABOtxcAAAcJAAAAAAf/////AQH/////AAAA" +
               "ACRggAoBAAAAAQAVAAAARnJvbVNldHVwVG9Qcm9jZXNzaW5nAQGuEwMAAAAALwAAAFRyYW5zaXRpb24g" +
               "ZnJvbSBzdGF0ZSBTZXR1cCB0byBzdGF0ZSBQcm9jZXNzaW5nAC8BAAYJrhMAAAIAAAAANAABAaITADMA" +
               "AQGjEwEAAAAVYKkLAgAAAAAAEAAAAFRyYW5zaXRpb25OdW1iZXIBAbkXAC4ARABOuRcAAAcLAAAAAAf/" +
               "////AQH/////AAAAACRggAoBAAAAAQAQAAAARnJvbVNldHVwVG9TZXR1cAEBrxMDAAAAACoAAABUcmFu" +
               "c2l0aW9uIGZyb20gc3RhdGUgU2V0dXAgdG8gc3RhdGUgU2V0dXAALwEABgmvEwAAAgAAAAAzAAEBoxMA" +
               "NAABAaMTAQAAABVgqQsCAAAAAAAQAAAAVHJhbnNpdGlvbk51bWJlcgEBuhcALgBEAE66FwAABw8AAAAA" +
               "B/////8BAf////8AAAAAJGCACgEAAAABAAsAAABNYWludGVuYW5jZQEBoRMDAAAAAG4AAABNYWNoaW5l" +
               "cnlJdGVtIGlzIHNldCBpbnRvIG1haW50ZW5hbmNlIG1vZGUgd2l0aCB0aGUgaW50ZW50aW9uIHRvIGNh" +
               "cnJ5IG91dCBtYWludGVuYW5jZSBvciBzZXJ2aWNpbmcgYWN0aXZpdGllcwAvAQADCaETAAAIAAAAADMB" +
               "AQGrEwA0AQEBqxMAMwEBAagTADMBAQGqEwAzAQEBqRMANAEBAaQTADQBAQGxEwA0AQEBrRMBAAAAFWCp" +
               "CwIAAAAAAAsAAABTdGF0ZU51bWJlcgEBrBcALgBEAE6sFwAABwEAAAAAB/////8BAf////8AAAAAJGCA" +
               "CgEAAAABAAQAAABOb25lAQGgEwMAAAAALgAAAFRoZXJlIGlzIGN1cnJlbnRseSBubyBvcGVyYXRpb24g" +
               "bW9kZSBhdmFpbGFibGUALwEAAwmgEwAACAAAAAA0AQEBqBMAMwEBAaQTADMBAQGnEwA0AQEBpxMAMwEB" +
               "AaYTADMBAQGlEwA0AQEBsBMANAEBAawTAQAAABVgqQsCAAAAAAALAAAAU3RhdGVOdW1iZXIBAasXAC4A" +
               "RABOqxcAAAcAAAAAAAf/////AQH/////AAAAACRggAoBAAAAAQAKAAAAUHJvY2Vzc2luZwEBohMDAAAA" +
               "AGUAAABNYWNoaW5lcnlJdGVtIGlzIHNldCBpbnRvIHByb2Nlc3NpbmcgbW9kZSB3aXRoIHRoZSBpbnRl" +
               "bnRpb24gdG8gY2Fycnkgb3V0IHRoZSB2YWx1ZSBhZGRpbmcgYWN0aXZpdGllcwAvAQADCaITAAAIAAAA" +
               "ADQBAQGqEwA0AQEBphMAMwEBAbETADMBAQGwEwAzAQEBsxMANAEBAbMTADMBAQGyEwA0AQEBrhMBAAAA" +
               "FWCpCwIAAAAAAAsAAABTdGF0ZU51bWJlcgEBrRcALgBEAE6tFwAABwMAAAAAB/////8BAf////8AAAAA" +
               "JGCACgEAAAABAAUAAABTZXR1cAEBoxMDAAAAAIwAAABNYWNoaW5lcnlJdGVtIGlzIHNldCBpbnRvIHNl" +
               "dHVwIG1vZGUgd2l0aCB0aGUgaW50ZW50aW9uIHRvIGNhcnJ5IG91dCBzZXR1cCwgcHJlcGFyYXRpb24g" +
               "b3IgcG9zdHByb2Nlc3NpbmcgYWN0aXZpdGllcyBvZiBhIHByb2R1Y3Rpb24gcHJvY2VzcwAvAQADCaMT" +
               "AAAIAAAAADQBAQGpEwA0AQEBpRMANAEBAbITADMBAQGtEwAzAQEBrBMAMwEBAa4TADMBAQGvEwA0AQEB" +
               "rxMBAAAAFWCpCwIAAAAAAAsAAABTdGF0ZU51bWJlcgEBrhcALgBEAE6uFwAABwIAAAAAB/////8BAf//" +
               "//8AAAAApGCAAgEAAAABAAgAAABNYWNoaW5lcwEB6QMDAAAAAHYAAABUaGlzIG9iamVjdCBpcyB0aGUg" +
               "ZW50cnkgcG9pbnQgdG8gbWFjaGluZXMgbWFuYWdlZCBpbiB0aGUgc2VydmVyLiBBbGwgbWFjaGluZXMg" +
               "YXJlIGRpcmVjdGx5IHJlZmVyZW5jZWQgYnkgdGhpcyBvYmplY3QuAD3pAwAAAQEAAAAAIwEAVQAAAAAE" +
               "YMACAQAAACYAAABodHRwX19fb3BjZm91bmRhdGlvbl9vcmdfVUFfTWFjaGluZXJ5XwEAJgAAAGh0dHA6" +
               "Ly9vcGNmb3VuZGF0aW9uLm9yZy9VQS9NYWNoaW5lcnkvAQGJEwEAYC2JEwAAAQAAAAAvAQEAwy0HAAAA" +
               "FWCpCgIAAAAAAAwAAABOYW1lc3BhY2VVcmkBAZEXAC4ARJEXAAAMJgAAAGh0dHA6Ly9vcGNmb3VuZGF0" +
               "aW9uLm9yZy9VQS9NYWNoaW5lcnkvAAz/////AQH/////AAAAABVgqQoCAAAAAAAQAAAATmFtZXNwYWNl" +
               "VmVyc2lvbgEBkhcALgBEkhcAAAwGAAAAMS4wNC4xAAz/////AQH/////AAAAABVgqQoCAAAAAAAYAAAA" +
               "TmFtZXNwYWNlUHVibGljYXRpb25EYXRlAQGQFwAuAESQFwAADQAAgZKxetwBAA3/////AQH/////AAAA" +
               "ABVgqQoCAAAAAAARAAAASXNOYW1lc3BhY2VTdWJzZXQBAY8XAC4ARI8XAAABAAAB/////wEB/////wAA" +
               "AAAXYKkKAgAAAAAAEQAAAFN0YXRpY05vZGVJZFR5cGVzAQGTFwAuAESTFwAAhgEAAAAAAAAAAQAAAQEA" +
               "AAABAAAAAAAAAAEB/////wAAAAAXYKkKAgAAAAAAGAAAAFN0YXRpY051bWVyaWNOb2RlSWRSYW5nZQEB" +
               "lBcALgBElBcAAIwBAAAADAAAADE6MjE0NzQ4MzY0NwEAIwEBAAAAAQAAAAAAAAABAf////8AAAAAFWCp" +
               "CgIAAAAAABkAAABTdGF0aWNTdHJpbmdOb2RlSWRQYXR0ZXJuAQGVFwAuAESVFwAADAAAAAAADP////8B" +
               "Af////8AAAAA"
            );
            using (MemoryStream stream = new MemoryStream(initializationBuffer))
            {
                NodeStateCollection predefinedNodes = new NodeStateCollection();
                predefinedNodes.LoadFromBinary(context, stream, true);
                return predefinedNodes;
            }
        }
        #endregion
    }
    #endregion
}