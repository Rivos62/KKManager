﻿namespace KKManager
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCardBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFemaleCardFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMaleCardFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sideloaderModsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1012, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCardBrowserToolStripMenuItem,
            this.sideloaderModsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // openCardBrowserToolStripMenuItem
            // 
            this.openCardBrowserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFemaleCardFolderToolStripMenuItem,
            this.openMaleCardFolderToolStripMenuItem,
            this.toolStripSeparator1,
            this.otherToolStripMenuItem});
            this.openCardBrowserToolStripMenuItem.Name = "openCardBrowserToolStripMenuItem";
            this.openCardBrowserToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.openCardBrowserToolStripMenuItem.Text = "Open card browser";
            // 
            // openFemaleCardFolderToolStripMenuItem
            // 
            this.openFemaleCardFolderToolStripMenuItem.Name = "openFemaleCardFolderToolStripMenuItem";
            this.openFemaleCardFolderToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.openFemaleCardFolderToolStripMenuItem.Text = "Open female card folder";
            this.openFemaleCardFolderToolStripMenuItem.Click += new System.EventHandler(this.openFemaleCardFolderToolStripMenuItem_Click);
            // 
            // openMaleCardFolderToolStripMenuItem
            // 
            this.openMaleCardFolderToolStripMenuItem.Name = "openMaleCardFolderToolStripMenuItem";
            this.openMaleCardFolderToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.openMaleCardFolderToolStripMenuItem.Text = "Open male card folder";
            this.openMaleCardFolderToolStripMenuItem.Click += new System.EventHandler(this.openMaleCardFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.otherToolStripMenuItem.Text = "Open other folder...";
            this.otherToolStripMenuItem.Click += new System.EventHandler(this.otherToolStripMenuItem_Click);
            // 
            // sideloaderModsToolStripMenuItem
            // 
            this.sideloaderModsToolStripMenuItem.Name = "sideloaderModsToolStripMenuItem";
            this.sideloaderModsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.sideloaderModsToolStripMenuItem.Text = "Open sideloader mod browser";
            this.sideloaderModsToolStripMenuItem.Click += new System.EventHandler(this.sideloaderModsToolStripMenuItem_Click);
            // 
            // dockPanel
            // 
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.Location = new System.Drawing.Point(0, 24);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(1012, 655);
            this.dockPanel.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 679);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sideloaderModsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCardBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFemaleCardFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMaleCardFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
    }
}