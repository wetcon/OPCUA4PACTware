using System;
using System.Windows.Forms;

namespace Wetcon.PactwarePlugin.OpcUaServer.UserControls
{
    partial class AboutUserControl
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.licenseTextBox = new System.Windows.Forms.RichTextBox();
            this.websiteLinkLabel = new System.Windows.Forms.LinkLabel();
            this.emailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.bOk = new System.Windows.Forms.Button();
            this.lblCompany = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(234, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Temp";
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(234, 44);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(75, 25);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version";
            // 
            // lblPath
            // 
            this.lblPath.Location = new System.Drawing.Point(234, 80);
            this.lblPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(75, 25);
            this.lblPath.TabIndex = 3;
            this.lblPath.Text = "Path";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(324, 40);
            this.txtVersion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = true;
            this.txtVersion.Size = new System.Drawing.Size(97, 26);
            this.txtVersion.TabIndex = 4;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(324, 77);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(380, 26);
            this.txtPath.TabIndex = 5;
            // 
            // licenseTextBox
            // 
            this.licenseTextBox.Location = new System.Drawing.Point(238, 120);
            this.licenseTextBox.Name = "licenseTextBox";
            this.licenseTextBox.ReadOnly = true;
            this.licenseTextBox.Size = new System.Drawing.Size(468, 210);
            this.licenseTextBox.TabIndex = 8;
            this.licenseTextBox.Text = "";
            this.licenseTextBox.VisibleChanged += new System.EventHandler(this.licenseTextBox_VisibleChanged);
            // 
            // websiteLinkLabel
            // 
            this.websiteLinkLabel.AutoSize = true;
            this.websiteLinkLabel.Location = new System.Drawing.Point(345, 341);
            this.websiteLinkLabel.Name = "websiteLinkLabel";
            this.websiteLinkLabel.Size = new System.Drawing.Size(104, 20);
            this.websiteLinkLabel.TabIndex = 24;
            this.websiteLinkLabel.TabStop = true;
            this.websiteLinkLabel.Text = "wetcon gmbh";
            this.websiteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.websiteLinkLabel_LinkClicked);
            // 
            // emailLinkLabel
            // 
            this.emailLinkLabel.AutoSize = true;
            this.emailLinkLabel.Location = new System.Drawing.Point(562, 338);
            this.emailLinkLabel.Name = "emailLinkLabel";
            this.emailLinkLabel.Size = new System.Drawing.Size(142, 20);
            this.emailLinkLabel.TabIndex = 23;
            this.emailLinkLabel.TabStop = true;
            this.emailLinkLabel.Text = "office@wetcon.net";
            this.emailLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.emailLinkLabel_LinkClicked);
            // 
            // bOk
            // 
            this.bOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bOk.Location = new System.Drawing.Point(585, 371);
            this.bOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(120, 34);
            this.bOk.TabIndex = 22;
            this.bOk.Text = "OK";
            this.bOk.Click += new EventHandler(bOk_Click);
            // 
            // lblCompany
            // 
            this.lblCompany.Location = new System.Drawing.Point(234, 341);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(120, 18);
            this.lblCompany.TabIndex = 21;
            this.lblCompany.Text = "Development";
            // 
            // AboutUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Wetcon.PactwarePlugin.OpcUaServer.Properties.Resources.DialogBitmap;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.websiteLinkLabel);
            this.Controls.Add(this.emailLinkLabel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.licenseTextBox);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AboutUserControl";
            this.Size = new System.Drawing.Size(732, 415);
            this.Load += new System.EventHandler(this.AboutUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AboutUserControl_Load(object sender, EventArgs e)
        {
            base.ParentForm.AcceptButton = bOk;
            base.ParentForm.CancelButton = bOk;
        }

        #endregion

        private PluginPW5 mAddinBase;

        private Label lblTitle;

        private Label lblVersion;

        private Label lblPath;

        private TextBox txtVersion;

        private TextBox txtPath;

        private RichTextBox licenseTextBox;
        private LinkLabel websiteLinkLabel;
        private LinkLabel emailLinkLabel;
        private Button bOk;
        private Label lblCompany;
    }
}
