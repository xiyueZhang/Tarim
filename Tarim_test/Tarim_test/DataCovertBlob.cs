using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using MySql.Data.MySqlClient;
using MySQLDriverCS;
using System.IO;

namespace Tarim_test
{
    class DataConvert
    {
        public static byte[] ArrToBlob(double[] ArrData)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(ms, ArrData);
            byte[] byteArr = ms.ToArray();
            
            try
            {
                return byteArr;
            }
            catch
            {
                return null;
            }
            finally
            {
                ms.Close();
                ms.Dispose();
            }
            

        }

        public static double[] BlobToArr(MySqlDataReader data)
        {
            BinaryFormatter bFormatter = new BinaryFormatter();
            data.Read();
            byte[] blob = new byte[data.GetBytes(0, 0, null, 0, int.MaxValue)];
            data.GetBytes(0, 0, blob, 0, blob.Length);
            data.Close();
            MemoryStream ms = new MemoryStream(blob)
            {
                Position = 0
            };
            try
            {
                double[] arr = (double[])bFormatter.Deserialize(ms);
                return arr;
            }
            catch
            {
                return null;
            }
            finally
            {
                ms.Dispose();
            }
        }
    }
}