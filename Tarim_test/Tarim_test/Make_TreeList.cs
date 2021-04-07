using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Tarim_test
{
    public partial class Tarim : Form
    {
        private void PaintTreeView(string fullPath)
        {

            Tarim_TreeList.Nodes.Clear(); //清空TreeView

            DirectoryInfo dirs = new DirectoryInfo(fullPath); //获得程序所在路径的目录对象
            DirectoryInfo[] dir = dirs.GetDirectories();//获得目录下文件夹对象
            FileInfo[] file = dirs.GetFiles();//获得目录下文件对象
            int dircount = dir.Count();//获得文件夹对象数量
            int filecount = file.Count();//获得文件对象数量

            //循环文件夹
            for (int i = 0; i < dircount; i++)
            {
                Tarim_TreeList.Nodes.Add(dir[i].Name);
                string pathNode = fullPath + "\\" + dir[i].Name;
                GetMultiNode(Tarim_TreeList.Nodes[i], pathNode);
            }

            //循环文件
            for (int j = 0; j < filecount; j++)
            {
                Tarim_TreeList.Nodes.Add(file[j].Name);
            }


        }
        private bool GetMultiNode(TreeNode treeNode, string path)
        {
            if (Directory.Exists(path) == false)
            { return false; }

            DirectoryInfo dirs = new DirectoryInfo(path); //获得程序所在路径的目录对象
            DirectoryInfo[] dir = dirs.GetDirectories();//获得目录下文件夹对象
            FileInfo[] file = dirs.GetFiles();//获得目录下文件对象
            int dircount = dir.Count();//获得文件夹对象数量
            int filecount = file.Count();//获得文件对象数量
            int sumcount = dircount + filecount;

            if (sumcount == 0)
            { return false; }

            //循环文件夹
            for (int j = 0; j < dircount; j++)
            {
                treeNode.Nodes.Add(dir[j].Name);
                string pathNodeB = path + "\\" + dir[j].Name;
                GetMultiNode(treeNode.Nodes[j], pathNodeB);
            }

            //循环文件
            for (int j = 0; j < filecount; j++)
            {
                treeNode.Nodes.Add(file[j].Name);
            }
            return true;
        }
    }

}
