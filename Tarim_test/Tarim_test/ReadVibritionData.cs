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


        public bool DrawMap(string FilePath)
        {
            //Double[] arrX;
            Double[] arrY;
            Double[] Vib_array;

            arrY = DataCpature.VibMachineData(FilePath);
            if(arrY == null)
            {
                return false;
            }
            else
            {
                int len = arrY.Length;           //算该字符串的长度
                List<double> list = arrY.ToList();
                list.RemoveAt(len-1);
                Vib_array = list.ToArray();
                len = Vib_array.Length;
                double[] sx = new double[len];
                Fourier.Spectrum(arrY, sx, len);

                FreqDemo.Series["Series1"].Points.Clear();
                for (int j = 0; j < 500; j++)
                {
                    double xxx = Convert.ToDouble(j * 2000 / (double)2000);//0.4ms采集22个点-->1s采集55000点
                                                                           //chart3.Series["Series1"].Points.AddXY(xxx, sx[j]);
                    FreqDemo.Series[0].Points.AddXY(xxx, sx[j]);
                }
                TimeDemo.Series["Series1"].Points.Clear();
                for (int j = 0; j < len; j++)
                {
                    double xLable = Convert.ToDouble((j * 64 * 1024) / (double)len);
                    TimeDemo.Series[0].Points.AddY(arrY[j]);
                }
                double Temp = arrY[len];
                Tempreture.Text = "温度：" + Temp.ToString ("#0.00") + "℃";
                return true;
            }

        }

        public bool TarimDrawMap(string FilePath)
        {

            Double[] arrX;
            Double[] arrY;

            var DataTup = DataCpature.TarimEData(FilePath);
            if (DataTup == null)
            {
                return false;
            }
            else
            {
                arrX = DataTup.Item1;
                arrY = DataTup.Item2;
                int len = arrY.Length;           //算该字符串的长度
                double[] sx = new double[len];
                Fourier.Spectrum(arrY, sx, len);

                FreqDemo.Series["Series1"].Points.Clear();
                for (int j = 0; j < 5000; j++)
                {
                    double xLable = Convert.ToDouble((j * 5000) / (double)5000);
                    //chart3.Series["Series1"].Points.AddXY(xxx, sx[j]);
                    FreqDemo.Series[0].Points.AddXY(xLable, sx[j]);
                }
                TimeDemo.Series["Series1"].Points.Clear();
                for (int j = 0; j < len; j++)
                {
                    TimeDemo.Series[0].Points.AddXY(arrX[j], arrY[j]);
                }
                return true;
            }

        }

        public bool DatabaseMap(double[] arrY)
        {
            if (arrY == null)
            {
                return false;
            }
            else
            {
                int len = arrY.Length;           //算该字符串的长度

                double[] sx = new double[len];
                Fourier.Spectrum(arrY, sx, len);

                FreqDemo.Series["Series1"].Points.Clear();
                for (int j = 0; j < 500; j++)
                {
                    double xxx = Convert.ToDouble(j * 2000 / (double)2000);//0.4ms采集22个点-->1s采集55000点
                                                                           //chart3.Series["Series1"].Points.AddXY(xxx, sx[j]);
                    FreqDemo.Series[0].Points.AddXY(xxx, sx[j]);
                }
                TimeDemo.Series["Series1"].Points.Clear();
                for (int j = 0; j < len; j++)
                {
                    double xLable = Convert.ToDouble((j * 64 * 1024) / (double)len);
                    TimeDemo.Series[0].Points.AddY(arrY[j]);
                }
                return true;
            }
        }
    }
}
