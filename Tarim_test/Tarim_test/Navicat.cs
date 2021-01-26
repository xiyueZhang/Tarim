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
        struct DataPath
        {
            public string DatabaseName;
            public string TableName;
            public string ColumnName;
            public string IDName;
        }
        DataPath datapath = new DataPath();
        MySqlConnection conn;

        private void Navicat_Load(object sender, EventArgs e)
        {
            AptWindowSize();
            //加载库名
            PaintTreeView();
        }

        private void NavicattreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level != 0)
            {
                MySQLdataGridView.DataSource = null;

                string path = e.Node.FullPath;
                string[] fullpath = path.Split('\\');
                int pathLen = fullpath.Count();
                //string database = fullpath[pathLen - 2];
                //string table = fullpath[pathLen - 1];

                datapath.DatabaseName = fullpath[pathLen - 2];
                datapath.TableName = fullpath[pathLen - 1];

                DataSet ds = GetTableData(datapath.DatabaseName, datapath.TableName);
                MySQLdataGridView.DataSource = ds.Tables[0];
            }

        }

        private void Navicat_SizeChanged(object sender, EventArgs e)
        {
            AptWindowSize();
        }

        //获得选定的表中的字段名和ID
        private void MySQLdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GridDdatalabel.Text = MySQLdataGridView.RowCount.ToString() +"  "+
                MySQLdataGridView.ToString();
            //try
            //{
            //    datapath.ColumnName = MySQLdataGridView.Columns[e.ColumnIndex].HeaderText;
            //    datapath.IDName = MySQLdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            //    if (DataDownloadDatabase(datapath.TableName, datapath.ColumnName))
            //    {
            //        GridDdatalabel.Text = "数据读取成功";
            //    }
            //    else
            //    {
            //        GridDdatalabel.Text = "数据读取失败";
            //    }
            //    GridDdatalabel.Text = datapath.ColumnName + "-" + datapath.IDName;
            //}
            //catch
            //{
            //    MessageBox.Show("请点击正确位置");
            //}
        }

        private void CreateDatabasebutton_Click(object sender, EventArgs e)
        {
            CreateMysqlDB("Tarim");

        }

        private void CreateTablebutton_Click(object sender, EventArgs e)
        {
            TableName();
            
        }

        private void UploadDataMenuItem_Click(object sender, EventArgs e)
        {
            if (DataUploadDatabase("本特利", "自由端"))
            {
                GridDdatalabel.Text = "数据插入成功";
            }
            else
            {
                GridDdatalabel.Text = "数据插入失败";
            }
        }

        private void DownloadDataMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataDownloadDatabase("本特利", "自由端"))
                {
                    GridDdatalabel.Text = "数据读取成功";
                }
                else
                {
                    GridDdatalabel.Text = "数据读取失败";
                }
            }
            catch
            {
                MessageBox.Show("请点击正确位置");
            }
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
