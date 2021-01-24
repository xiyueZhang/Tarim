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
            this.NavicattreeView = new System.Windows.Forms.TreeView();
            this.MySQLdataGridView = new System.Windows.Forms.DataGridView();
            this.DBcomboBox = new System.Windows.Forms.ComboBox();
            this.TablecomboBox = new System.Windows.Forms.ComboBox();
            this.GridDdatalabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MySQLdataGridView)).BeginInit();
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
            // DBcomboBox
            // 
            this.DBcomboBox.FormattingEnabled = true;
            this.DBcomboBox.Location = new System.Drawing.Point(23, 53);
            this.DBcomboBox.Name = "DBcomboBox";
            this.DBcomboBox.Size = new System.Drawing.Size(305, 32);
            this.DBcomboBox.TabIndex = 2;
            this.DBcomboBox.SelectedIndexChanged += new System.EventHandler(this.DBcomboBox_SelectedIndexChanged);
            // 
            // TablecomboBox
            // 
            this.TablecomboBox.FormattingEnabled = true;
            this.TablecomboBox.Location = new System.Drawing.Point(23, 113);
            this.TablecomboBox.Name = "TablecomboBox";
            this.TablecomboBox.Size = new System.Drawing.Size(304, 32);
            this.TablecomboBox.TabIndex = 3;
            this.TablecomboBox.SelectedIndexChanged += new System.EventHandler(this.TablecomboBox_SelectedIndexChanged);
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
            // Navicat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1704, 1194);
            this.Controls.Add(this.GridDdatalabel);
            this.Controls.Add(this.TablecomboBox);
            this.Controls.Add(this.DBcomboBox);
            this.Controls.Add(this.MySQLdataGridView);
            this.Controls.Add(this.NavicattreeView);
            this.Name = "Navicat";
            this.Text = "Navicat";
            this.Load += new System.EventHandler(this.Navicat_Load);
            this.SizeChanged += new System.EventHandler(this.Navicat_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.MySQLdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView NavicattreeView;
        private System.Windows.Forms.DataGridView MySQLdataGridView;
        private System.Windows.Forms.ComboBox DBcomboBox;
        private System.Windows.Forms.ComboBox TablecomboBox;
        private System.Windows.Forms.Label GridDdatalabel;
    }
}