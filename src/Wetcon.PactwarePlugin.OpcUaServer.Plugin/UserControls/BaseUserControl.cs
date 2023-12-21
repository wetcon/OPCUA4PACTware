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

using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using PWUtil5;
using Wetcon.PactwarePlugin.OpcUaServer.Properties;

namespace Wetcon.PactwarePlugin.OpcUaServer.UserControls
{
    /// <summary>
    /// Base class for user controls.
    /// </summary>
    [TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<BaseUserControl, UserControl>))]
    public class BaseUserControl : ctrlPWBase
    {
        protected void OpenUrlLinkLabel(LinkLabel linkLabel, string url)
        {
            var processStartInfo = new ProcessStartInfo(url);
            Process.Start(processStartInfo);
            linkLabel.LinkVisited = true;
        }

        public override Icon IPACTwareInfomation_Icon => Resources.favicon;

        public override Icon IPACTwareInfomation_CompanyIcon => Resources.favicon;

        protected void OpenUrlLinkLabelText(LinkLabel linkLabel, string prependText = null)
        {
            var url = (prependText ?? string.Empty) + linkLabel.Text;

            OpenUrlLinkLabel(linkLabel, url);
        }
    }
}
