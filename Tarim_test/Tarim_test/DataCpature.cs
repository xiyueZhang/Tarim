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
    class DataCpature
    {
        public static Tuple<double[], double[]> TarimEData(string FilePath)
        {


            Double[] arrX;
            Double[] arrY;

            List<string> lines;
            lines = new List<string>();

            FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            StreamReader rd = new StreamReader(fs);

            string s;
            //读入文件所有行，存放到List<string>集合中;有效数字部分从8到lines.Count-1
            while ((s = rd.ReadLine()) != null)
            {
                lines.Add(s);
            }

            rd.Close();
            fs.Close();
            int m = lines.Count - 8;
            string[] arrstr1 = new string[m];
            string[] arrstr2 = new string[m];
            string[] arrstr3 = new string[m];
            string[] arrstr4 = new string[m];
            string[] arrstr5 = new string[m];
            string[] arrstr6 = new string[m];
            string[] arrstr7 = new string[m];
            string[] arrstr8 = new string[m];
            try
            {
                for (int i = 8; i < lines.Count; i++)
                {
                    arrstr1[i - 8] = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0];
                    arrstr2[i - 8] = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1];
                    arrstr3[i - 8] = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[2];
                    arrstr4[i - 8] = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[3];
                    arrstr5[i - 8] = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[4];
                    arrstr6[i - 8] = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[5];
                    arrstr7[i - 8] = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[6];
                    arrstr8[i - 8] = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[7];
                }
            }
            catch (Exception)
            {
                MessageBox.Show("这不是艾默生采集的数据");
                return null;
            }
            int n = 4 * m;
            arrX = new double[n];//时间
            for (int i = 0; i < n; i++)
            {
                if (i < m)
                {
                    arrX[i] = Convert.ToDouble(arrstr1[i]);
                }
                else if (i >= m && i < 2 * m)
                {
                    arrX[i] = Convert.ToDouble(arrstr3[i - m]);
                }
                else if (i >= 2 * m && i < 3 * m)
                {
                    arrX[i] = Convert.ToDouble(arrstr5[i - 2 * m]);
                }
                else
                {
                    arrX[i] = Convert.ToDouble(arrstr7[i - 3 * m]);
                }
            }

            arrY = new double[n];//幅值
            for (int i = 0; i < n; i++)
            {
                if (i < m)
                {
                    arrY[i] = Convert.ToDouble(arrstr2[i]);//Convert.ToDouble(str_1[i])
                }
                else if (i >= m && i < 2 * m)
                {
                    arrY[i] = Convert.ToDouble(arrstr4[i - m]);
                }
                else if (i >= 2 * m && i < 3 * m)
                {
                    arrY[i] = Convert.ToDouble(arrstr6[i - 2 * m]);
                }
                else
                {
                    arrY[i] = Convert.ToDouble(arrstr8[i - 3 * m]);
                }
            }
            Tuple<double[], double[]> DataTup = new Tuple<double[], double[]>(arrX, arrY);
            return DataTup;
            
        }
        public static double[] VibMachineData(string FilePath)
        {
            //Double[] arrX;
            Double[] arrY;

            List<string> lines;
            lines = new List<string>();

            FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            StreamReader rd = new StreamReader(fs);
            string s;
            while ((s = rd.ReadLine()) != null)
            {
                lines.Add(s);
            }
            rd.Close();
            fs.Close();
            int m = lines.Count;
            string[] arrstr1 = new string[m];

            try
            {
                for (int i = 0; i < lines.Count; i++)
                {
                    arrstr1[i] = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0];
                }
            }

            catch (Exception)
            {
                MessageBox.Show("这不是数据采集卡的数据");
                return null;
            }
            arrY = new double[m];//幅值
            for (int i = 0; i < m; i++)
            {
                if (i < m)
                {
                    arrY[i] = Convert.ToDouble(arrstr1[i]);//Convert.ToDouble(str_1[i])
                }
            }

            return arrY;
        }
    }
}
