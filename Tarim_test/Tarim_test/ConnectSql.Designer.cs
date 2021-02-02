namespace Tarim_test
{
    partial class ConnectSql
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
            this.DatabaseULR = new System.Windows.Forms.TextBox();
            this.DatabaseName = new System.Windows.Forms.TextBox();
            this.DatabasePassword = new System.Windows.Forms.TextBox();
            this.ConnectDBbutton = new System.Windows.Forms.Button();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.ULRLable = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.PasswordLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Portlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DatabaseULR
            // 
            this.DatabaseULR.Location = new System.Drawing.Point(229, 94);
            this.DatabaseULR.Name = "DatabaseULR";
            this.DatabaseULR.Size = new System.Drawing.Size(316, 35);
            this.DatabaseULR.TabIndex = 0;
            this.DatabaseULR.Text = "8.131.51.44";
            this.DatabaseULR.Visible = false;
            // 
            // DatabaseName
            // 
            this.DatabaseName.Location = new System.Drawing.Point(229, 232);
            this.DatabaseName.Name = "DatabaseName";
            this.DatabaseName.Size = new System.Drawing.Size(316, 35);
            this.DatabaseName.TabIndex = 2;
            this.DatabaseName.Text = "root";
            this.DatabaseName.Visible = false;
            // 
            // DatabasePassword
            // 
            this.DatabasePassword.Location = new System.Drawing.Point(229, 304);
            this.DatabasePassword.Name = "DatabasePassword";
            this.DatabasePassword.Size = new System.Drawing.Size(316, 35);
            this.DatabasePassword.TabIndex = 3;
            this.DatabasePassword.Text = "root";
            this.DatabasePassword.Visible = false;
            // 
            // ConnectDBbutton
            // 
            this.ConnectDBbutton.Location = new System.Drawing.Point(229, 419);
            this.ConnectDBbutton.Name = "ConnectDBbutton";
            this.ConnectDBbutton.Size = new System.Drawing.Size(126, 45);
            this.ConnectDBbutton.TabIndex = 4;
            this.ConnectDBbutton.Text = "连接";
            this.ConnectDBbutton.UseVisualStyleBackColor = true;
            this.ConnectDBbutton.Click += new System.EventHandler(this.ConnectDBbutton_Click);
            // 
            // Resetbutton
            // 
            this.Resetbutton.Location = new System.Drawing.Point(423, 423);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(105, 40);
            this.Resetbutton.TabIndex = 5;
            this.Resetbutton.Text = "重置";
            this.Resetbutton.UseVisualStyleBackColor = true;
            this.Resetbutton.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // ULRLable
            // 
            this.ULRLable.AutoSize = true;
            this.ULRLable.Location = new System.Drawing.Point(69, 97);
            this.ULRLable.Name = "ULRLable";
            this.ULRLable.Size = new System.Drawing.Size(130, 24);
            this.ULRLable.TabIndex = 6;
            this.ULRLable.Text = "主机地址：";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(93, 235);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(106, 24);
            this.UserName.TabIndex = 7;
            this.UserName.Text = "用户名：";
            // 
            // PasswordLable
            // 
            this.PasswordLable.AutoSize = true;
            this.PasswordLable.Location = new System.Drawing.Point(117, 315);
            this.PasswordLable.Name = "PasswordLable";
            this.PasswordLable.Size = new System.Drawing.Size(82, 24);
            this.PasswordLable.TabIndex = 8;
            this.PasswordLable.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(302, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "连接数据库";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 35);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "3306";
            // 
            // Portlabel
            // 
            this.Portlabel.AutoSize = true;
            this.Portlabel.Location = new System.Drawing.Point(117, 164);
            this.Portlabel.Name = "Portlabel";
            this.Portlabel.Size = new System.Drawing.Size(82, 24);
            this.Portlabel.TabIndex = 11;
            this.Portlabel.Text = "端口：";
            // 
            // ConnectSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 573);
            this.Controls.Add(this.Portlabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordLable);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.ULRLable);
            this.Controls.Add(this.Resetbutton);
            this.Controls.Add(this.ConnectDBbutton);
            this.Controls.Add(this.DatabasePassword);
            this.Controls.Add(this.DatabaseName);
            this.Controls.Add(this.DatabaseULR);
            this.Name = "ConnectSql";
            this.Text = "ConnectSql";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DatabaseULR;
        private System.Windows.Forms.TextBox DatabaseName;
        private System.Windows.Forms.TextBox DatabasePassword;
        private System.Windows.Forms.Button ConnectDBbutton;
        private System.Windows.Forms.Button Resetbutton;
        private System.Windows.Forms.Label ULRLable;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label PasswordLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Portlabel;
    }
}