﻿namespace Tarim_test
{
    partial class Navicat
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
            this.NavicattreeView = new System.Windows.Forms.TreeView();
            this.MySQLdataGridView = new System.Windows.Forms.DataGridView();
            this.GridDdatalabel = new System.Windows.Forms.Label();
            this.CreateDatabasebutton = new System.Windows.Forms.Button();
            this.CreateTablebutton = new System.Windows.Forms.Button();
            this.NavicatStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UploadDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.MySQLdataGridView)).BeginInit();
            this.NavicatStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavicattreeView
            // 
            this.NavicattreeView.Location = new System.Drawing.Point(23, 173);
            this.NavicattreeView.Name = "NavicattreeView";
            this.NavicattreeView.Size = new System.Drawing.Size(400, 970);
            this.NavicattreeView.TabIndex = 0;
            this.NavicattreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.NavicattreeView_AfterSelect);
            // 
            // MySQLdataGridView
            // 
            this.MySQLdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MySQLdataGridView.Location = new System.Drawing.Point(448, 24);
            this.MySQLdataGridView.Name = "MySQLdataGridView";
            this.MySQLdataGridView.RowTemplate.Height = 37;
            this.MySQLdataGridView.Size = new System.Drawing.Size(1249, 1119);
            this.MySQLdataGridView.TabIndex = 1;
            this.MySQLdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MySQLdataGridView_CellClick);
            // 
            // GridDdatalabel
            // 
            this.GridDdatalabel.AutoSize = true;
            this.GridDdatalabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GridDdatalabel.Location = new System.Drawing.Point(55, 1146);
            this.GridDdatalabel.Name = "GridDdatalabel";
            this.GridDdatalabel.Size = new System.Drawing.Size(158, 41);
            this.GridDdatalabel.TabIndex = 4;
            this.GridDdatalabel.Text = "infoshow";
            // 
            // CreateDatabasebutton
            // 
            this.CreateDatabasebutton.Location = new System.Drawing.Point(23, 71);
            this.CreateDatabasebutton.Name = "CreateDatabasebutton";
            this.CreateDatabasebutton.Size = new System.Drawing.Size(161, 40);
            this.CreateDatabasebutton.TabIndex = 5;
            this.CreateDatabasebutton.Text = "创建数据库";
            this.CreateDatabasebutton.UseVisualStyleBackColor = true;
            this.CreateDatabasebutton.Click += new System.EventHandler(this.CreateDatabasebutton_Click);
            // 
            // CreateTablebutton
            // 
            this.CreateTablebutton.Location = new System.Drawing.Point(224, 71);
            this.CreateTablebutton.Name = "CreateTablebutton";
            this.CreateTablebutton.Size = new System.Drawing.Size(170, 40);
            this.CreateTablebutton.TabIndex = 6;
            this.CreateTablebutton.Text = "创建表";
            this.CreateTablebutton.UseVisualStyleBackColor = true;
            this.CreateTablebutton.Click += new System.EventHandler(this.CreateTablebutton_Click);
            // 
            // NavicatStrip
            // 
            this.NavicatStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.NavicatStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.NavicatStrip.Location = new System.Drawing.Point(0, 0);
            this.NavicatStrip.Name = "NavicatStrip";
            this.NavicatStrip.Size = new System.Drawing.Size(1704, 39);
            this.NavicatStrip.TabIndex = 7;
            this.NavicatStrip.Text = "菜单";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UploadDataMenuItem,
            this.DownloadDataMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(74, 38);
            this.ToolStripMenuItem.Text = "菜单";
            // 
            // UploadDataMenuItem
            // 
            this.UploadDataMenuItem.Name = "UploadDataMenuItem";
            this.UploadDataMenuItem.Size = new System.Drawing.Size(324, 38);
            this.UploadDataMenuItem.Text = "上传数据";
            this.UploadDataMenuItem.Click += new System.EventHandler(this.UploadDataMenuItem_Click);
            // 
            // DownloadDataMenuItem
            // 
            this.DownloadDataMenuItem.Name = "DownloadDataMenuItem";
            this.DownloadDataMenuItem.Size = new System.Drawing.Size(324, 38);
            this.DownloadDataMenuItem.Text = "下载数据";
            this.DownloadDataMenuItem.Click += new System.EventHandler(this.DownloadDataMenuItem_Click);
            // 
            // Navicat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1704, 1194);
            this.Controls.Add(this.CreateTablebutton);
            this.Controls.Add(this.CreateDatabasebutton);
            this.Controls.Add(this.GridDdatalabel);
            this.Controls.Add(this.MySQLdataGridView);
            this.Controls.Add(this.NavicattreeView);
            this.Controls.Add(this.NavicatStrip);
            this.MainMenuStrip = this.NavicatStrip;
            this.Name = "Navicat";
            this.Text = "Navicat";
            this.Load += new System.EventHandler(this.Navicat_Load);
            this.SizeChanged += new System.EventHandler(this.Navicat_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.MySQLdataGridView)).EndInit();
            this.NavicatStrip.ResumeLayout(false);
            this.NavicatStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView NavicattreeView;
        private System.Windows.Forms.DataGridView MySQLdataGridView;
        private System.Windows.Forms.Label GridDdatalabel;
        private System.Windows.Forms.Button CreateDatabasebutton;
        private System.Windows.Forms.Button CreateTablebutton;
        private System.Windows.Forms.MenuStrip NavicatStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UploadDataMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DownloadDataMenuItem;
    }
}