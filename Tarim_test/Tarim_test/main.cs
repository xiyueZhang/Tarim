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
    public partial class Tarim : Form
    {
        private enum DataPath
        {
            VIBMACHINE = 0,
            TARIMEMERSON,
            VIBDATABASE
        }
        DataPath _GetButtonPath;
        string path = "E:\\临时软件";
        public Tarim()
        {
            InitializeComponent();
 
        }

        private void Tarim_Load(object sender, EventArgs e)
        {
            AptWindowSize();
            PaintTreeView(path);
        }

        private void Make_TreeList_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FilePath = new FolderBrowserDialog
            {
                Description = "请选择包含数据存储路径"
            };
            if (FilePath.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = FilePath.SelectedPath; 
            }
            _GetButtonPath = DataPath.VIBMACHINE;
            PaintTreeView(path);


        }

        private void Tarim_TreeList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            InfoShow.Text = path + "\\" + e.Node.FullPath;

            if (Check_File_Type.Target_File_Type(InfoShow.Text, "txt", "TXT"))
            {
                switch (_GetButtonPath)
                {
                    case DataPath.TARIMEMERSON:
                        if(TarimDrawMap(InfoShow.Text))
                        {
                            InfoShow.Text = "塔里木数据绘制成功";
                            break;
                        }
                        else
                            break;
                    case DataPath.VIBMACHINE:
                        if(DrawMap(InfoShow.Text))
                        {
                            InfoShow.Text = "采集卡数据绘制成功";
                            break;
                        }
                        else
                            break;
                    default: break;
                }
            }
            else
            {
                InfoShow.Text = path + "\\" + e.Node.FullPath + "不是txt文件";
            }
        }

        private void Layout_Function(object sender, EventArgs e)
        {
            AptWindowSize();
        }

        private void TarimDataShow_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FilePath = new FolderBrowserDialog
            {
                Description = "请选择包含塔里木数据所在路径"
            };
            if (FilePath.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = FilePath.SelectedPath;
            }

            _GetButtonPath = DataPath.TARIMEMERSON;
            
            PaintTreeView(path);
            
        }

        private void TarimDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FilePath = new FolderBrowserDialog
            {
                Description = "请选择包含塔里木数据所在路径"
            };
            if (FilePath.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = FilePath.SelectedPath;
            }
            _GetButtonPath = DataPath.TARIMEMERSON;
            PaintTreeView(path);
        }

        private void ToolStripCloudDB_Click(object sender, EventArgs e)
        {
            ConnectSql connectSql = new ConnectSql();
            connectSql.Show();
        }
    }
}
