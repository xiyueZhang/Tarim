using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarim_test
{
    public partial class ConnectSql : Form
    {
        public ConnectSql()
        {
            InitializeComponent();
        }

        private void ConnectDBbutton_Click(object sender, EventArgs e)
        {
            string server = DatabaseULR.Text;
            string port = Portlabel.Text;
            string ClientName = DatabaseName.Text;
            string Password = DatabasePassword.Text;

            Navicat f = new Navicat(server, port, ClientName, Password, out bool status);
            if (status)
            {
                f.Show();
                return;
            }
            MessageBox.Show("连接失败！");

        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            DatabaseULR.Clear();
            DatabaseName.Clear();
            DatabasePassword.Clear();
        }
    }
}
