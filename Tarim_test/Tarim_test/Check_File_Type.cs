using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarim_test
{
    class Check_File_Type
    {
        public static bool Target_File_Type(string FileName ,string Type1,string Type2)
        {
            string[] IsTxtFile = FileName.Split('.');
            int PathLen = IsTxtFile.Count();
            if (IsTxtFile[PathLen - 1] == Type1 || IsTxtFile[PathLen - 1] == Type2)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }
    }
}
