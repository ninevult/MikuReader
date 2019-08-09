﻿namespace MikuReader
{
    partial class FrmMangaBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMangaBrowser));
            this.browser = new System.Windows.Forms.WebBrowser();
            this.mnuNav = new System.Windows.Forms.MenuStrip();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addThisTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setReaderInSettingsToLEGACYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // browser
            // 
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.Location = new System.Drawing.Point(0, 33);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(1730, 840);
            this.browser.TabIndex = 0;
            this.browser.Url = new System.Uri("https://mangadex.org/", System.UriKind.Absolute);
            this.browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Browser_DocumentCompleted);
            // 
            // mnuNav
            // 
            this.mnuNav.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goBackToolStripMenuItem,
            this.addThisTitleToolStripMenuItem,
            this.setReaderInSettingsToLEGACYToolStripMenuItem});
            this.mnuNav.Location = new System.Drawing.Point(0, 0);
            this.mnuNav.Name = "mnuNav";
            this.mnuNav.Size = new System.Drawing.Size(1730, 33);
            this.mnuNav.TabIndex = 1;
            this.mnuNav.Text = "menuStrip1";
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.goBackToolStripMenuItem.Text = "< Go Back";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.GoBackToolStripMenuItem_Click);
            // 
            // addThisTitleToolStripMenuItem
            // 
            this.addThisTitleToolStripMenuItem.Enabled = false;
            this.addThisTitleToolStripMenuItem.Name = "addThisTitleToolStripMenuItem";
            this.addThisTitleToolStripMenuItem.Size = new System.Drawing.Size(131, 29);
            this.addThisTitleToolStripMenuItem.Text = "Add This Title";
            this.addThisTitleToolStripMenuItem.Click += new System.EventHandler(this.AddThisTitleToolStripMenuItem_Click);
            // 
            // setReaderInSettingsToLEGACYToolStripMenuItem
            // 
            this.setReaderInSettingsToLEGACYToolStripMenuItem.Enabled = false;
            this.setReaderInSettingsToLEGACYToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setReaderInSettingsToLEGACYToolStripMenuItem.Name = "setReaderInSettingsToLEGACYToolStripMenuItem";
            this.setReaderInSettingsToLEGACYToolStripMenuItem.Size = new System.Drawing.Size(356, 29);
            this.setReaderInSettingsToLEGACYToolStripMenuItem.Text = "*Set \"Reader\" in settings to \"LEGACY\"*";
            // 
            // FrmBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 873);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.mnuNav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuNav;
            this.Name = "FrmBrowse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MikuReader | Browse for Manga";
            this.mnuNav.ResumeLayout(false);
            this.mnuNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.MenuStrip mnuNav;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addThisTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setReaderInSettingsToLEGACYToolStripMenuItem;
    }
}