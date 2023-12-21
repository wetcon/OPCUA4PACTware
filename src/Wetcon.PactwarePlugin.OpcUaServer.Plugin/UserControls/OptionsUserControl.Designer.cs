using PWUtil5;

namespace Wetcon.PactwarePlugin.OpcUaServer.UserControls
{
    partial class OptionsUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serverUriLabel = new System.Windows.Forms.Label();
            this.serverUriTextBox = new System.Windows.Forms.TextBox();
            this.infoLinkLabel = new System.Windows.Forms.LinkLabel();
            this.settingChangedLabel = new System.Windows.Forms.Label();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.settingsGroupBox.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverUriLabel
            // 
            this.serverUriLabel.AutoSize = true;
            this.serverUriLabel.Location = new System.Drawing.Point(25, 48);
            this.serverUriLabel.Name = "serverUriLabel";
            this.serverUriLabel.Size = new System.Drawing.Size(116, 20);
            this.serverUriLabel.TabIndex = 0;
            this.serverUriLabel.Text = "Opc Server Uri:";
            // 
            // serverUriTextBox
            // 
            this.serverUriTextBox.Location = new System.Drawing.Point(147, 45);
            this.serverUriTextBox.Name = "serverUriTextBox";
            this.serverUriTextBox.Size = new System.Drawing.Size(275, 26);
            this.serverUriTextBox.TabIndex = 1;
            this.serverUriTextBox.Text = global::Wetcon.PactwarePlugin.OpcUaServer.Properties.Settings.Default.UserOpcServerUri;
            this.serverUriTextBox.TextChanged += new System.EventHandler(this.ServerUriTextBox_TextChanged);
            // 
            // infoLinkLabel
            // 
            this.infoLinkLabel.AutoSize = true;
            this.infoLinkLabel.Location = new System.Drawing.Point(25, 88);
            this.infoLinkLabel.Name = "infoLinkLabel";
            this.infoLinkLabel.Size = new System.Drawing.Size(345, 20);
            this.infoLinkLabel.TabIndex = 2;
            this.infoLinkLabel.TabStop = true;
            this.infoLinkLabel.Text = "https://www.wetcon.net/";
            this.infoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.InfoLinkLabel_LinkClicked);
            // 
            // settingChangedLabel
            // 
            this.settingChangedLabel.AutoSize = true;
            this.settingChangedLabel.Location = new System.Drawing.Point(25, 141);
            this.settingChangedLabel.Name = "settingChangedLabel";
            this.settingChangedLabel.Size = new System.Drawing.Size(397, 20);
            this.settingChangedLabel.TabIndex = 4;
            this.settingChangedLabel.Text = "Please restart PACTware for this change to take effect.";
            this.settingChangedLabel.Visible = false;
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.serverUriLabel);
            this.settingsGroupBox.Controls.Add(this.settingChangedLabel);
            this.settingsGroupBox.Controls.Add(this.serverUriTextBox);
            this.settingsGroupBox.Controls.Add(this.infoLinkLabel);
            this.settingsGroupBox.Location = new System.Drawing.Point(7, 0);
            this.settingsGroupBox.Margin = new System.Windows.Forms.Padding(20, 3, 20, 55);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(441, 179);
            this.settingsGroupBox.TabIndex = 5;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Options";
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.cancelButton);
            this.buttonPanel.Controls.Add(this.okButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 184);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(455, 50);
            this.buttonPanel.TabIndex = 6;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(340, 11);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 30);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(229, 11);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 30);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // OptionsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.settingsGroupBox);
            this.Name = "OptionsUserControl";
            this.Size = new System.Drawing.Size(455, 234);
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void InfoLinkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            OpenUrlLinkLabelText(infoLinkLabel);
        }

        private void ServerUriTextBox_TextChanged(object sender, System.EventArgs e)
        {
            this.settingChangedLabel.Visible = true;
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            Wnd.BeginUnload(clsGuid.GetGuid(), null, null);
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            this.ActiveControl = null;

            Properties.Settings.Default.UserOpcServerUri = serverUriTextBox.Text;
            Properties.Settings.Default.Save();

            Wnd.BeginUnload(clsGuid.GetGuid(), null, null);
        }

        #endregion

        private System.Windows.Forms.Label serverUriLabel;
        private System.Windows.Forms.TextBox serverUriTextBox;
        private System.Windows.Forms.LinkLabel infoLinkLabel;
        private System.Windows.Forms.Label settingChangedLabel;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}
