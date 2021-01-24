namespace Tarim_test
{
    partial class Tarim
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Make_TreeList_Button = new System.Windows.Forms.Button();
            this.InfoShow = new System.Windows.Forms.Label();
            this.Tarim_TreeList = new System.Windows.Forms.TreeView();
            this.FreqDemo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TimeDemo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TarimDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripCloudDB = new System.Windows.Forms.ToolStripMenuItem();
            this.TarimDataShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FreqDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeDemo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Make_TreeList_Button
            // 
            this.Make_TreeList_Button.Location = new System.Drawing.Point(378, 370);
            this.Make_TreeList_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Make_TreeList_Button.Name = "Make_TreeList_Button";
            this.Make_TreeList_Button.Size = new System.Drawing.Size(222, 102);
            this.Make_TreeList_Button.TabIndex = 1;
            this.Make_TreeList_Button.Text = "数据库";
            this.Make_TreeList_Button.UseVisualStyleBackColor = true;
            this.Make_TreeList_Button.Click += new System.EventHandler(this.Make_TreeList_Click);
            // 
            // InfoShow
            // 
            this.InfoShow.AutoSize = true;
            this.InfoShow.Location = new System.Drawing.Point(4, 858);
            this.InfoShow.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.InfoShow.Name = "InfoShow";
            this.InfoShow.Size = new System.Drawing.Size(106, 24);
            this.InfoShow.TabIndex = 3;
            this.InfoShow.Text = "InfoShow";
            // 
            // Tarim_TreeList
            // 
            this.Tarim_TreeList.Location = new System.Drawing.Point(8, 46);
            this.Tarim_TreeList.Margin = new System.Windows.Forms.Padding(6);
            this.Tarim_TreeList.Name = "Tarim_TreeList";
            this.Tarim_TreeList.Size = new System.Drawing.Size(334, 802);
            this.Tarim_TreeList.TabIndex = 4;
            this.Tarim_TreeList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tarim_TreeList_AfterSelect);
            // 
            // FreqDemo
            // 
            chartArea5.CursorX.IsUserEnabled = true;
            chartArea5.CursorX.IsUserSelectionEnabled = true;
            chartArea5.Name = "ChartArea1";
            this.FreqDemo.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.FreqDemo.Legends.Add(legend5);
            this.FreqDemo.Location = new System.Drawing.Point(626, 24);
            this.FreqDemo.Margin = new System.Windows.Forms.Padding(6);
            this.FreqDemo.Name = "FreqDemo";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.LegendText = "频域图";
            series5.Name = "Series1";
            series5.ToolTip = "\"#VALX,#VALY\"";
            this.FreqDemo.Series.Add(series5);
            this.FreqDemo.Size = new System.Drawing.Size(1134, 492);
            this.FreqDemo.TabIndex = 5;
            this.FreqDemo.Text = "Frequency domain diagram";
            // 
            // TimeDemo
            // 
            chartArea6.CursorX.IsUserEnabled = true;
            chartArea6.CursorX.IsUserSelectionEnabled = true;
            chartArea6.CursorY.IsUserEnabled = true;
            chartArea6.CursorY.IsUserSelectionEnabled = true;
            chartArea6.Name = "ChartArea1";
            this.TimeDemo.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.TimeDemo.Legends.Add(legend6);
            this.TimeDemo.Location = new System.Drawing.Point(626, 528);
            this.TimeDemo.Margin = new System.Windows.Forms.Padding(6);
            this.TimeDemo.Name = "TimeDemo";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.LegendText = "时域图";
            series6.Name = "Series1";
            series6.ToolTip = "\"#VALX,#VALY\"";
            this.TimeDemo.Series.Add(series6);
            this.TimeDemo.Size = new System.Drawing.Size(1134, 524);
            this.TimeDemo.TabIndex = 6;
            this.TimeDemo.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1769, 39);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TarimDataToolStripMenuItem,
            this.ToolStripCloudDB});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // TarimDataToolStripMenuItem
            // 
            this.TarimDataToolStripMenuItem.DoubleClickEnabled = true;
            this.TarimDataToolStripMenuItem.Name = "TarimDataToolStripMenuItem";
            this.TarimDataToolStripMenuItem.Size = new System.Drawing.Size(256, 38);
            this.TarimDataToolStripMenuItem.Text = "塔里木数据";
            this.TarimDataToolStripMenuItem.ToolTipText = "塔里木数据查看";
            this.TarimDataToolStripMenuItem.Click += new System.EventHandler(this.TarimDataToolStripMenuItem_Click);
            // 
            // ToolStripCloudDB
            // 
            this.ToolStripCloudDB.Name = "ToolStripCloudDB";
            this.ToolStripCloudDB.Size = new System.Drawing.Size(256, 38);
            this.ToolStripCloudDB.Text = "连接云数据库";
            this.ToolStripCloudDB.Click += new System.EventHandler(this.ToolStripCloudDB_Click);
            // 
            // TarimDataShow
            // 
            this.TarimDataShow.Location = new System.Drawing.Point(376, 520);
            this.TarimDataShow.Name = "TarimDataShow";
            this.TarimDataShow.Size = new System.Drawing.Size(223, 102);
            this.TarimDataShow.TabIndex = 8;
            this.TarimDataShow.Text = "塔里木数据";
            this.TarimDataShow.UseVisualStyleBackColor = true;
            this.TarimDataShow.Click += new System.EventHandler(this.TarimDataShow_Click);
            // 
            // Tarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1769, 1047);
            this.Controls.Add(this.TarimDataShow);
            this.Controls.Add(this.TimeDemo);
            this.Controls.Add(this.FreqDemo);
            this.Controls.Add(this.Tarim_TreeList);
            this.Controls.Add(this.InfoShow);
            this.Controls.Add(this.Make_TreeList_Button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Tarim";
            this.Text = "塔里木故障诊断";
            this.Load += new System.EventHandler(this.Tarim_Load);
            this.ResizeBegin += new System.EventHandler(this.Layout_Function);
            this.ResizeEnd += new System.EventHandler(this.Layout_Function);
            this.SizeChanged += new System.EventHandler(this.Layout_Function);
            ((System.ComponentModel.ISupportInitialize)(this.FreqDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeDemo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Make_TreeList_Button;
        private System.Windows.Forms.Label InfoShow;
        private System.Windows.Forms.TreeView Tarim_TreeList;
        private System.Windows.Forms.DataVisualization.Charting.Chart FreqDemo;
        private System.Windows.Forms.DataVisualization.Charting.Chart TimeDemo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TarimDataToolStripMenuItem;
        private System.Windows.Forms.Button TarimDataShow;
        private System.Windows.Forms.ToolStripMenuItem ToolStripCloudDB;
    }
}

