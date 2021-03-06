﻿namespace MikuReader.wf.Forms
{
    partial class FrmSettings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.rbDouble = new System.Windows.Forms.RadioButton();
            this.groupBoxReader = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.groupBoxApplication = new System.Windows.Forms.GroupBox();
            this.lblLang = new System.Windows.Forms.Label();
            this.cmboLanguage = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblAppDir = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.chkUpdates = new System.Windows.Forms.CheckBox();
            this.groupBoxReader.SuspendLayout();
            this.groupBoxApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSingle
            // 
            this.rbSingle.AutoSize = true;
            this.rbSingle.Location = new System.Drawing.Point(6, 25);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(119, 24);
            this.rbSingle.TabIndex = 0;
            this.rbSingle.TabStop = true;
            this.rbSingle.Text = "Single Page";
            this.rbSingle.UseVisualStyleBackColor = true;
            // 
            // rbDouble
            // 
            this.rbDouble.AutoSize = true;
            this.rbDouble.Location = new System.Drawing.Point(6, 55);
            this.rbDouble.Name = "rbDouble";
            this.rbDouble.Size = new System.Drawing.Size(126, 24);
            this.rbDouble.TabIndex = 1;
            this.rbDouble.TabStop = true;
            this.rbDouble.Text = "Double Page";
            this.rbDouble.UseVisualStyleBackColor = true;
            // 
            // groupBoxReader
            // 
            this.groupBoxReader.Controls.Add(this.rbSingle);
            this.groupBoxReader.Controls.Add(this.rbDouble);
            this.groupBoxReader.Location = new System.Drawing.Point(12, 12);
            this.groupBoxReader.Name = "groupBoxReader";
            this.groupBoxReader.Size = new System.Drawing.Size(168, 178);
            this.groupBoxReader.TabIndex = 2;
            this.groupBoxReader.TabStop = false;
            this.groupBoxReader.Text = "Reader";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(364, 196);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 44);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 196);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(121, 44);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // groupBoxApplication
            // 
            this.groupBoxApplication.Controls.Add(this.lblLang);
            this.groupBoxApplication.Controls.Add(this.cmboLanguage);
            this.groupBoxApplication.Controls.Add(this.btnBrowse);
            this.groupBoxApplication.Controls.Add(this.lblAppDir);
            this.groupBoxApplication.Controls.Add(this.txtDir);
            this.groupBoxApplication.Controls.Add(this.chkUpdates);
            this.groupBoxApplication.Location = new System.Drawing.Point(186, 12);
            this.groupBoxApplication.Name = "groupBoxApplication";
            this.groupBoxApplication.Size = new System.Drawing.Size(291, 178);
            this.groupBoxApplication.TabIndex = 5;
            this.groupBoxApplication.TabStop = false;
            this.groupBoxApplication.Text = "Application";
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(6, 121);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(149, 20);
            this.lblLang.TabIndex = 10;
            this.lblLang.Text = "Interface Language";
            // 
            // cmboLanguage
            // 
            this.cmboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboLanguage.FormattingEnabled = true;
            this.cmboLanguage.Location = new System.Drawing.Point(6, 144);
            this.cmboLanguage.Name = "cmboLanguage";
            this.cmboLanguage.Size = new System.Drawing.Size(279, 28);
            this.cmboLanguage.TabIndex = 9;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(244, 75);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(41, 36);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // lblAppDir
            // 
            this.lblAppDir.AutoSize = true;
            this.lblAppDir.Location = new System.Drawing.Point(2, 59);
            this.lblAppDir.Name = "lblAppDir";
            this.lblAppDir.Size = new System.Drawing.Size(105, 20);
            this.lblAppDir.TabIndex = 7;
            this.lblAppDir.Text = "App Directory";
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(6, 82);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(232, 26);
            this.txtDir.TabIndex = 6;
            // 
            // chkUpdates
            // 
            this.chkUpdates.AutoSize = true;
            this.chkUpdates.Location = new System.Drawing.Point(6, 26);
            this.chkUpdates.Name = "chkUpdates";
            this.chkUpdates.Size = new System.Drawing.Size(241, 24);
            this.chkUpdates.TabIndex = 0;
            this.chkUpdates.Text = "Check for updates on startup";
            this.chkUpdates.UseVisualStyleBackColor = true;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 252);
            this.Controls.Add(this.groupBoxApplication);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBoxReader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MikuReader Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.groupBoxReader.ResumeLayout(false);
            this.groupBoxReader.PerformLayout();
            this.groupBoxApplication.ResumeLayout(false);
            this.groupBoxApplication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.RadioButton rbDouble;
        private System.Windows.Forms.GroupBox groupBoxReader;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.GroupBox groupBoxApplication;
        private System.Windows.Forms.CheckBox chkUpdates;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblAppDir;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.ComboBox cmboLanguage;
    }
}