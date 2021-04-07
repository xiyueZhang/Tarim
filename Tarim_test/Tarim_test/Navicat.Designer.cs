namespace Tarim_test
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.NavicattreeView = new System.Windows.Forms.TreeView();
            this.MySQLdataGridView = new System.Windows.Forms.DataGridView();
            this.GridDdatalabel = new System.Windows.Forms.Label();
            this.CreateDatabasebutton = new System.Windows.Forms.Button();
            this.CreateTablebutton = new System.Windows.Forms.Button();
            this.NavicatStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UploadDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DebugButton = new System.Windows.Forms.Button();
            this.Friqueenchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Timechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.创建数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据建立ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.MySQLdataGridView)).BeginInit();
            this.NavicatStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Friqueenchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timechart)).BeginInit();
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
            this.MySQLdataGridView.Location = new System.Drawing.Point(448, 29);
            this.MySQLdataGridView.Name = "MySQLdataGridView";
            this.MySQLdataGridView.RowTemplate.Height = 37;
            this.MySQLdataGridView.Size = new System.Drawing.Size(1249, 1114);
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
            this.CreateDatabasebutton.Location = new System.Drawing.Point(23, 51);
            this.CreateDatabasebutton.Name = "CreateDatabasebutton";
            this.CreateDatabasebutton.Size = new System.Drawing.Size(161, 40);
            this.CreateDatabasebutton.TabIndex = 5;
            this.CreateDatabasebutton.Text = "创建数据库";
            this.CreateDatabasebutton.UseVisualStyleBackColor = true;
            this.CreateDatabasebutton.Click += new System.EventHandler(this.CreateDatabasebutton_Click);
            // 
            // CreateTablebutton
            // 
            this.CreateTablebutton.Location = new System.Drawing.Point(220, 51);
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
            this.ToolStripMenuItem,
            this.创建数据库ToolStripMenuItem,
            this.数据建立ToolStripMenuItem,
            this.退出连接ToolStripMenuItem});
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
            this.ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
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
            // DebugButton
            // 
            this.DebugButton.Location = new System.Drawing.Point(113, 117);
            this.DebugButton.Name = "DebugButton";
            this.DebugButton.Size = new System.Drawing.Size(185, 44);
            this.DebugButton.TabIndex = 8;
            this.DebugButton.Text = "测试按键";
            this.DebugButton.UseVisualStyleBackColor = true;
            this.DebugButton.Click += new System.EventHandler(this.DebugButton_Click);
            // 
            // Friqueenchart
            // 
            chartArea1.Name = "ChartArea1";
            this.Friqueenchart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Friqueenchart.Legends.Add(legend1);
            this.Friqueenchart.Location = new System.Drawing.Point(458, 42);
            this.Friqueenchart.Name = "Friqueenchart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "频域图";
            this.Friqueenchart.Series.Add(series1);
            this.Friqueenchart.Size = new System.Drawing.Size(1238, 530);
            this.Friqueenchart.TabIndex = 9;
            this.Friqueenchart.Text = "频域图";
            // 
            // Timechart
            // 
            chartArea2.Name = "ChartArea1";
            this.Timechart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Timechart.Legends.Add(legend2);
            this.Timechart.Location = new System.Drawing.Point(459, 588);
            this.Timechart.Name = "Timechart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "时域图";
            this.Timechart.Series.Add(series2);
            this.Timechart.Size = new System.Drawing.Size(1236, 554);
            this.Timechart.TabIndex = 10;
            this.Timechart.Text = "时域图";
            // 
            // 创建数据库ToolStripMenuItem
            // 
            this.创建数据库ToolStripMenuItem.Name = "创建数据库ToolStripMenuItem";
            this.创建数据库ToolStripMenuItem.Size = new System.Drawing.Size(146, 35);
            this.创建数据库ToolStripMenuItem.Text = "创建数据库";
            // 
            // 数据建立ToolStripMenuItem
            // 
            this.数据建立ToolStripMenuItem.Name = "数据建立ToolStripMenuItem";
            this.数据建立ToolStripMenuItem.Size = new System.Drawing.Size(122, 35);
            this.数据建立ToolStripMenuItem.Text = "数据建立";
            // 
            // 退出连接ToolStripMenuItem
            // 
            this.退出连接ToolStripMenuItem.Name = "退出连接ToolStripMenuItem";
            this.退出连接ToolStripMenuItem.Size = new System.Drawing.Size(122, 35);
            this.退出连接ToolStripMenuItem.Text = "退出连接";
            // 
            // Navicat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1704, 1194);
            this.Controls.Add(this.Timechart);
            this.Controls.Add(this.Friqueenchart);
            this.Controls.Add(this.DebugButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.Friqueenchart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timechart)).EndInit();
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
        private System.Windows.Forms.Button DebugButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart Friqueenchart;
        private System.Windows.Forms.DataVisualization.Charting.Chart Timechart;
        private System.Windows.Forms.ToolStripMenuItem 创建数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据建立ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出连接ToolStripMenuItem;
    }
}