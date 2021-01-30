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
        #region 操作数据库
        //打开mysql连接
        private bool OpenConnection()
        {
            try
            {
                MySqlConnectionStringBuilder sqlstring = new MySqlConnectionStringBuilder
                {
                    Server = server,
                    Port = 3306,
                    UserID = userid,
                    Password = password,
                    CharacterSet = "utf8"
                };

                conn = new MySqlConnection(sqlstring.ConnectionString);
                conn.Open();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        private bool OpenConnection(string database)
        {
            try
            {
                MySqlConnectionStringBuilder sqlstring = new MySqlConnectionStringBuilder
                {
                    Server = server,
                    Port = 3306,
                    UserID = userid,
                    Password = password,
                    Database = database,
                    CharacterSet = "utf8"
                };

                conn = new MySqlConnection(sqlstring.ConnectionString);
                conn.Open();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        //关闭mysql连接
        private bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        //增删改
        private bool AddUpdateDelet(string sql)
        {
            if (CloseConnection())
            {
                MySqlCommand msc = new MySqlCommand(sql, conn);
                int status = msc.ExecuteNonQuery();
                CloseConnection();
                if (status > 0)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        //查询
        private MySqlDataReader Select(string sql)
        {
            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();

                return dataReader;
            }
            return null;
        }
        private MySqlDataReader Select(string database, string sql)
        {
            if (OpenConnection(database))
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();
                return dataReader;
            }
            return null;
        }
        //获取数据库名
        private string[] GetDatabases()
        {
            try
            {
                string getDatabaseSql = "SELECT  GROUP_CONCAT(DISTINCT Table_schema) FROM information_schema.`TABLES`";
                MySqlDataReader data = Select(getDatabaseSql);
                return data[0].ToString().Split(',');
            }
            finally
            {
                CloseConnection();
            }
        }
        //获取数据表名
        private string[] GetTables(string database)
        {
            try
            {
                string getTabesSql = "SELECT GROUP_CONCAT(table_name) FROM information_schema.tables WHERE table_schema='" + database + "'";
                MySqlDataReader data = Select(getTabesSql);
                return data[0].ToString().Split(',');
            }
            finally
            {
                CloseConnection();
            }
        }
        //获取表字段名
        private string[] GetField(string database, string table)
        {
            try
            {
                string getFieldSql = "SELECT GROUP_CONCAT(COLUMN_NAME) FROM INFORMATION_SCHEMA.Columns WHERE table_name='" + table + "' AND table_schema='" + database + "'";
                MySqlDataReader data = Select(getFieldSql);
                return data[0].ToString().Split(',');
            }
            finally
            {
                CloseConnection();
            }
        }
        //获取表数据
        private List<string[]> GetDatas(string database, string[] fields, string table)
        {
            List<string[]> dataList = new List<string[]>();
            foreach (string field in fields)
            {
                try
                {
                    string getDataSql = "SELECT GROUP_CONCAT(" + field + ") FROM " + table + "";
                    MySqlDataReader data = Select(database, getDataSql);
                    dataList.Add(data[0].ToString().Split(','));
                }
                finally
                {
                    CloseConnection();
                }
            }
            return dataList;
        }
        private string[] GetFiledDatas(string database, string field, string table)
        {
            try
            {
                string getDataSql = "SELECT GROUP_CONCAT(" + field + ") FROM " + table + "";
                MySqlDataReader data = Select(database, getDataSql);
                return data[0].ToString().Split(',');
            }
            finally
            {
                CloseConnection();
            }


        }
        private DataSet GetTableData(string database, string table)
        {
            MySqlConnectionStringBuilder sqlstring = new MySqlConnectionStringBuilder
            {
                Server = server,
                Port = 3306,
                UserID = userid,
                Password = password,
                Database = database,
                CharacterSet = "utf8"
            };

            MySqlConnection conn = new MySqlConnection(sqlstring.ConnectionString);

            MySqlDataAdapter sda = new MySqlDataAdapter("select *from " + table, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            return ds;

        }
        #endregion
    }
    public partial class Navicat : Form
    {
        #region 数据库树状结构
        private void PaintTreeView()
        {
            try
            {
                NavicattreeView.Nodes.Clear(); //清空TreeView

                string[] DatabaseNodes = GetDatabases();

                int nodecount = DatabaseNodes.Count();//获得对象数量

                //循环database
                for (int i = 0; i < nodecount; i++)
                {
                    NavicattreeView.Nodes.Add(DatabaseNodes[i]);
                    GetMultiNode(NavicattreeView.Nodes[i], DatabaseNodes[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Not have database");
            }

        }
        private bool GetMultiNode(TreeNode treeNode, string database)
        {
            string[] tableNodes = GetTables(database);
            int tableNodescount = tableNodes.Count();//获得table对象数量

            if (tableNodescount == 0)
            { return false; }

            //循环文件
            for (int j = 0; j < tableNodescount; j++)
            {
                treeNode.Nodes.Add(tableNodes[j]);
                if (database == "tarim")
                {
                    GetTarimFiledNode(treeNode.Nodes[j], database, tableNodes[j]);
                }
            }
            return true;
        }
        private bool GetTarimFiledNode(TreeNode treeNode, string database, string table)
        {
            string[] filedNodes = GetField(database, table);
            int filedNodescount = filedNodes.Count();//获得table对象数量

            if (filedNodescount == 0)
            { return false; }

            //循环文件,不要第一个字段名
            for (int j = 1; j < filedNodescount; j++)
            {
                treeNode.Nodes.Add(filedNodes[j]);
                GetTarimDataNode(treeNode.Nodes[j-1], database, filedNodes[0], table);
            }
            return true;
        }
        private bool GetTarimDataNode(TreeNode treeNode, string database, string filed, string table)
        {
            string[] DatadNodes = GetFiledDatas(database, filed, table);
            int DatadNodescount = DatadNodes.Count();//获得table对象数量

            if (DatadNodescount == 0)
            { return false; }

            //循环文件,不要第一个字段名
            for (int j = 0; j < DatadNodescount; j++)
            {
                treeNode.Nodes.Add(DatadNodes[j]);
            }
            return true;
        }
        #endregion
    }
}
