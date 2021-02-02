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
using System.IO;

namespace Tarim_test
{
    public partial class Navicat : Form
    {
        #region 操作数据库
        /// <summary>
        /// 创建数据库
        /// </summary>
        public void CreateMysqlDB(string DatabasName)
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

            MySqlCommand cmd = new MySqlCommand("CREATE DATABASE "+ DatabasName+"; ", conn);
            conn.Open();

            //防止第二次启动时再次新建数据库
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                GridDdatalabel.Text = "建立数据库成功";
            }
            catch (Exception)
            {
                conn.Close();
                GridDdatalabel.Text= "建立数据库失败，已存在了";
                //throw;
            }
            //防止第二次启动时再次新建数据库
        }
        /// <summary>
        /// 建表
        /// </summary>
        public void AlterTableExample(string DatabasName,string TableName,string columnName)
        {
            MySqlConnectionStringBuilder sqlstring = new MySqlConnectionStringBuilder
            {
                Server = server,
                Port = 3306,
                UserID = userid,
                Password = password,
                Database = DatabasName,
                CharacterSet = "utf8"
            };
            //创建外键，每个表的外键名称必须不一样2021.2.2，调试debug结果。
            string createStatement = "CREATE TABLE " +
                TableName +
                " (" +
                "time VarChar(50),"+
                "district VarChar(50)," +
                "location VarChar(50)," +
                "CONSTRAINT fk_" + TableName +
                "_district FOREIGN KEY(district) REFERENCES tarim_area(District)," +
                "CONSTRAINT fk_" + TableName +
                "_location FOREIGN KEY(location) REFERENCES tarim_area(District)" +
                ")";
            string alterStatement = columnName;

            using (MySqlConnection conn = new MySqlConnection(sqlstring.ConnectionString))
            {
                conn.Open();

                //防止第二次启动时再次新建数据表
                try
                {
                    // 建表  
                    using (MySqlCommand cmd = new MySqlCommand(createStatement, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    // 改表或者增加行  
                    using (MySqlCommand cmd = new MySqlCommand(alterStatement, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    GridDdatalabel.Text= "建表成功";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    GridDdatalabel.Text="建表失败，已存在";
                }
                //防止第二次启动时再次新建数据表

            }
        }
        private void CreatTableName()
        {
            string Path= "E:\\临时软件";
            FolderBrowserDialog FilePath = new FolderBrowserDialog
            {
                Description = "请选择包含数据存储路径"
            };
            if (FilePath.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Path = FilePath.SelectedPath;
            }

            DirectoryInfo dirs = new DirectoryInfo(Path); //获得程序所在路径的目录对象

            DirectoryInfo[] dir = dirs.GetDirectories();//获得目录下文件夹对象
            FileInfo[] file = dirs.GetFiles();//获得目录下文件对象
            int dircount = dir.Count();//获得文件夹对象数量
            int filecount = file.Count();//获得文件对象数量

            //循环文件夹
            for (int i = 0; i < dircount; i++)
            {
                try
                {
                    string Colunpath = Path + "\\" + dir[i].Name;
                    string columnName = FiledsName(Colunpath, dir[i].Name.Remove(dir[i].Name.IndexOf('#')));
                    AlterTableExample("tarim", dir[i].Name.Remove(dir[i].Name.IndexOf('#')), columnName);
                }
                
                catch
                {
                    string Colunpath = Path + "\\" + dir[i].Name;
                    string columnName = FiledsName(Colunpath, dir[i].Name);
                    AlterTableExample("tarim", dir[i].Name, columnName);
                }
            }
        }
        private string FiledsName(string path,string table )
        {
            DirectoryInfo dirs = new DirectoryInfo(path); //获得程序所在路径的目录对象
            DirectoryInfo[] dir = dirs.GetDirectories();//获得目录下文件夹对象
            string FiledsName = "ALTER TABLE "+ table;
            FileInfo[] file = dirs.GetFiles();//获得目录下文件对象
            int dircount = dir.Count();//获得文件夹对象数量
            int filecount = file.Count();//获得文件对象数量
            

            //循环文件夹
            for (int i = 0; i < dircount; i++)
            {
                FiledsName = FiledsName + " ADD "+dir[i].Name+ " blob,";
            }
            //删去最后的一个逗号
            FiledsName = FiledsName.Substring(0, FiledsName.Length - 1);
            return FiledsName;
        }

        public bool DataUploadDatabase(string tableName,string fieldName)
        {
            double[] arr = { 1, 2, 3 };
            MySqlConnectionStringBuilder sqlstring = new MySqlConnectionStringBuilder
            {
                Server = server,
                Port = 3306,
                UserID = userid,
                Password = password,
                Database = "tarim",
                CharacterSet = "utf8"
            };
            conn = new MySqlConnection(sqlstring.ConnectionString);
            //插入语句命令
            // CommandText = "insert into " + tableName + "(" + fieldName + ") values(@file)";
            //"insert into " + tableName + "(" + fieldName + ") values(@blobData)";
            string insertStr = "insert into " + tableName + "(" + fieldName + ") values(@blobData);";
            MySqlParameter par = new MySqlParameter("@blobData", MySqlDbType.Blob)
            {
                Value = DataConvert.ArrToBlob(arr)
            };
            MySqlCommand cmd = new MySqlCommand(insertStr, conn);
            cmd.Parameters.Add(par);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool DataDownloadDatabase(string tableName, string fieldName)
        {
            MySqlDataReader myData;
            double[] arr;
            MySqlConnectionStringBuilder sqlstring = new MySqlConnectionStringBuilder
            {
                Server = server,
                Port = 3306,
                UserID = userid,
                Password = password,
                Database = "tarim",
                CharacterSet = "utf8"
            };
            conn = new MySqlConnection(sqlstring.ConnectionString);
            string readStr = "select "+ fieldName + " from "+ tableName + " where ID = 2;";
            MySqlCommand cmd = new MySqlCommand(readStr, conn);
            try
            {
                conn.Open();
                myData = cmd.ExecuteReader();
                arr=DataConvert.BlobToArr(myData);
                MessageBox.Show(arr[0].ToString());
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }

        }

        public string[] GetTableFieldTime(string tablename)
        {
            string[] AllTime=GetFiledDatas("tarim", "time", tablename);
            for(int i=0;i< AllTime.Length;i++ )
            {
                AllTime[i] = tablename + "\\" + AllTime[i];
            }
            
            return AllTime;
        }
        #endregion

    }
}
