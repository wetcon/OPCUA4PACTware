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

using System.Reflection;
using PWUtil5;

namespace Wetcon.PactwarePlugin.OpcUaServer.UserControls
{
    public partial class AboutUserControl : BaseUserControl
    {
        delegate void SetRtfCallback(string rtf);

        public AboutUserControl()
        {
            InitializeComponent();
        }

        protected override bool OnInitialized()
        {
            var flag = base.OnInitialized();
            if (!flag)
            {
                return false;
            }

            mAddinBase = (Source as OpcUaPlugin);
            lblTitle.Text = mAddinBase.Name;
            Wnd.BeginSetCaption(clsGuid.GetGuid(), mAddinBase.Name + " Info", null, null);
            var assembly = Assembly.GetAssembly(GetType());
            txtVersion.Text = assembly.GetName().Version.ToString();
            txtPath.Text = assembly.Location;

            return true;
        }

        private void SetRtf(string rtf)
        {
            if (licenseTextBox.InvokeRequired)
            {
                var callBack = new SetRtfCallback(SetRtf);
                Invoke(callBack, rtf);
            }
            else
            {
                licenseTextBox.Rtf = rtf;
            }
        }

        private void websiteLinkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            OpenUrlLinkLabel(websiteLinkLabel, "https://www.wetcon.net/");
        }

        private void emailLinkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            OpenUrlLinkLabelText(emailLinkLabel, "mailto:");
        }

        private void bOk_Click(object sender, System.EventArgs e)
        {
            Wnd.BeginUnload(clsGuid.GetGuid(), null, null);
        }

        private void licenseTextBox_VisibleChanged(object sender, System.EventArgs e)
        {
            var licenseText = string.Empty;

            if (Visible && !Disposing)
            {
                licenseText = Properties.Resources.agb;
            }

            SetRtf(licenseText);
        }
    }
}
