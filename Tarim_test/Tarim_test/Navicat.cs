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
            public string FieldName;
            public string IDName;
        }
        DataPath datapath = new DataPath();
        MySqlConnection conn;

        private void Navicat_Load(object sender, EventArgs e)
        {
            AptWindowSize();
            //加载库名
            PaintTreeView();
            Friqueenchart.Visible = false;
            Timechart.Visible = false;
        }

        private void NavicattreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //此处会有默认点击Bug，会产生点击第一个数据库bug造成的事件，表的level=1
            if (e.Node.Level == 1)
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
                MySQLdataGridView.Visible = true;
                Friqueenchart.Visible = false ;
                Timechart.Visible = false;
            }
            if (e.Node.Level == 3)
            {
                string path = e.Node.FullPath;
                string[] fullpath = path.Split('\\');
                int pathLen = fullpath.Count();
                datapath.IDName = fullpath[pathLen - 1];
                datapath.FieldName = fullpath[pathLen - 2];
                datapath.TableName = fullpath[pathLen - 3];
                datapath.DatabaseName = fullpath[pathLen - 4];
                MySQLdataGridView.Hide();
                Friqueenchart.Visible = true;
                Timechart.Visible = true;
                NavicatDrawMap("E:\\临时软件\\chun\\2021.txt");
            }

        }

        private void Navicat_SizeChanged(object sender, EventArgs e)
        {
            AptWindowSize();
        }

        //获得选定的表中的字段名和ID
        private void MySQLdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GridDdatalabel.Text = MySQLdataGridView.Columns[e.ColumnIndex].HeaderText + "  "+
                MySQLdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            /*
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
            */
        }

        private void CreateDatabasebutton_Click(object sender, EventArgs e)
        {
            CreateMysqlDB("Tarim");
        }

        private void CreateTablebutton_Click(object sender, EventArgs e)
        {
            CreatTableName(); 
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

        private void DebugButton_Click(object sender, EventArgs e)
        {
            // GetTableFieldTime("丙烷机");
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
