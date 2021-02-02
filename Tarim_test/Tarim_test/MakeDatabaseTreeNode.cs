﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tarim_test
{
    class MakeDatabaseTreeNode: TreeView
    {
        public MakeDatabaseTreeNode DatabaseTreeList;
        public string debug_text = "use to debug";
        public void PaintTreeView(string fullPath)
        {
            try
            {
                DatabaseTreeList.Nodes.Clear(); //清空TreeView

                DirectoryInfo dirs = new DirectoryInfo(fullPath); //获得程序所在路径的目录对象
                DirectoryInfo[] dir = dirs.GetDirectories();//获得目录下文件夹对象
                FileInfo[] file = dirs.GetFiles();//获得目录下文件对象
                int dircount = dir.Count();//获得文件夹对象数量
                int filecount = file.Count();//获得文件对象数量

                //循环文件夹
                for (int i = 0; i < dircount; i++)
                {
                    DatabaseTreeList.Nodes.Add(dir[i].Name);
                    string pathNode = fullPath + "\\" + dir[i].Name;
                    GetMultiNode(DatabaseTreeList.Nodes[i], pathNode);
                }

                //循环文件
                for (int j = 0; j < filecount; j++)
                {
                    DatabaseTreeList.Nodes.Add(file[j].Name);
                }
            }
            catch (Exception)
            {
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
