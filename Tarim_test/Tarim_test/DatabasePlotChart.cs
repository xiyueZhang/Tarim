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
        public bool NavicatDrawMap(string FilePath)
        {
            //Double[] arrX;
            Double[] arrY;

            arrY = DataCpature.VibMachineData(FilePath);
            if (arrY == null)
            {
                return false;
            }
            else
            {
                int len = arrY.Length;           //算该字符串的长度

                double[] sx = new double[len];
                Fourier.Spectrum(arrY, sx, len);

                Friqueenchart .Series["频域图"].Points.Clear();
                for (int j = 0; j < 500; j++)
                {
                    double xxx = Convert.ToDouble(j * 2000 / (double)2000);//0.4ms采集22个点-->1s采集55000点
                                                                           //chart3.Series["Series1"].Points.AddXY(xxx, sx[j]);
                    Friqueenchart.Series[0].Points.AddXY(xxx, sx[j]);
                }
                Timechart.Series["时域图"].Points.Clear();
                for (int j = 0; j < len; j++)
                {
                    double xLable = Convert.ToDouble((j * 64 * 1024) / (double)len);
                    Timechart.Series[0].Points.AddY(arrY[j]);
                }
                return true;
            }

        }
    }
}
