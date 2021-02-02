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
    class GetUpLoadDataName
    {
        public static void GetAlltxtFileName()
        {

        }

        public static void GetDatabaseDataTag()
        {

        }
        //一次传入一台设备的信息
        public static string[]  GetUplodDataPath(string[] fileName,string[] Databasetag)
        {
            var diffArr = fileName.Where(c => !Databasetag.Contains(c)).ToArray();
            return diffArr;

        }
    }
}