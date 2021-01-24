using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySQLDriverCS;

namespace Tarim_test
{

    public partial class Navicat : Form
    {
        string server, userid, password;

        MySqlConnection conn;

        private void Navicat_Load(object sender, EventArgs e)
        {
            AptWindowSize();
            //加载库名
            this.DBcomboBox.Items.AddRange(GetDatabases());
            PaintTreeView();
        }

        private void DBcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TablecomboBox.Items.Clear();
            string item = (sender as ComboBox).Text;
            this.TablecomboBox.Items.AddRange(GetTables(item));
        }

        private void NavicattreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level != 0)
            {
                MySQLdataGridView.DataSource = null;

                string path = e.Node.FullPath;
                string[] fullpath = path.Split('\\');
                int pathLen = fullpath.Count();
                string database = fullpath[pathLen - 2];
                string table = fullpath[pathLen - 1];

                DataSet ds = GetTableData(database, table);

                MySQLdataGridView.DataSource = ds.Tables[0];
            }

        }

        private void Navicat_SizeChanged(object sender, EventArgs e)
        {
            AptWindowSize();
        }

        private void MySQLdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GridDdatalabel.Text = e.ColumnIndex.ToString() + "-" + e.RowIndex.ToString();
        }

        private void TablecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string database = this.DBcomboBox.Text;
            string table = this.TablecomboBox.Text;

            this.MySQLdataGridView.Columns.Clear();
            this.MySQLdataGridView.Rows.Clear();

            DataSet ds = GetTableData(database, table);

            MySQLdataGridView.DataSource = ds.Tables[0];


            /*
            string[] datas = GetField(database, table);
            //加载字段
            MySQLdataGridView.ColumnCount = datas.Length;
            for (int i = 0; i < datas.Length; i++)
            {
                this.MySQLdataGridView.Columns[i].Name = datas[i];
            }
            //加载数据
            List<string[]> dataList = GetDatas(database, datas, table);
            int listCount = dataList.Count;
            for (int i = 0; i < dataList[0].Length; i++)
            {
                for (int j = 0; j < listCount; j++)
                {
                    this.MySQLdataGridView.Rows.Add();
                    try
                    {
                        MySQLdataGridView.Rows[i].Cells[j].Value = dataList[j][i];
                    }
                    catch (Exception)
                    {
                    }
                }
            }            */

        }

        public Navicat(string server, string port, string userid, string password, out bool status)
        {
            InitializeComponent();

            this.server = server;
            this.userid = userid;
            this.password = password;

            if (OpenConnection())
            {
                status = true;
            }
            else
            {
                status = false;
            }
        }
    }
}
