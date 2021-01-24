using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarim_test
{
    class Fourier
    {

        public static void FFT(double[] fr, double[] fi, int n, int flag)
        /*flag=0 for forward,flag=1 for backward*/
        {
            int mp, arg, cntr, p1, p2, i, j, a, b, k;
            double sign, pr, pi, harm, t;
            double[] ca = new double[n];
            double[] sa = new double[n];
            j = 0;
            if (flag != 0)
            {
                sign = 1.0;
                for (i = 0; i <= n - 1; ++i)
                {
                    fr[i] = fr[i] / n;
                    fi[i] = fi[i] / n;
                }
            }
            else sign = -1.0;
            try
            {
                for (i = 0; i <= n - 2; ++i)
                {
                    if (i < j)
                    {
                        t = fr[i];
                        fr[i] = fr[j];
                        fr[j] = t;
                        t = fi[i];
                        fi[i] = fi[j];
                        fi[j] = t;
                    }
                    k = n / 2;
                    while (k <= j)
                    {
                        j -= k;
                        k /= 2;
                    }
                    j += k;
                }
            }
            catch (Exception ex)
            {
                //System.InvalidOperationException.Equals
                MessageBox.Show(ex.Message);
                return;
            }
            mp = 0;
            i = n;
            while (i != 1)
            {
                mp += 1;
                i /= 2;
            }
            harm = 2 * 3.14 / n;
            for (i = 0; i <= n - 1; ++i)
            {
                sa[i] = sign * Math.Sin(harm * i);
                ca[i] = Math.Cos(harm * i);
            }
            a = 2; b = 1;
            for (cntr = 1; cntr <= mp; ++cntr)
            {
                p1 = n / a;
                p2 = 0;
                for (k = 0; k <= b - 1; ++k)
                {
                    i = k;
                    while (i < n)
                    {
                        arg = i + b;
                        if (k == 0)
                        {
                            pr = fr[arg];
                            pi = fi[arg];
                        }
                        else
                        {
                            pr = fr[arg] * ca[p2] - fi[arg] * sa[p2];
                            pi = fr[arg] * sa[p2] + fi[arg] * ca[p2];
                        }
                        fr[arg] = fr[i] - pr;
                        fi[arg] = fi[i] - pi;
                        fr[i] += pr;
                        fi[i] += pi;
                        i += a;
                    }
                    p2 += p1;
                }
                a *= 2;
                b *= 2;
            }
        }

        //=====================FFT==============
        public static void Spectrum(double[] X, double[] S, int length)
        {
            double sum = X[0];
            double mean;
            double[] fr = new double[length];
            double[] fi = new double[length];
            for (int i = 1; i < length; i++)
            {
                sum = sum + X[i];
            }
            mean = sum / length;
            for (int i = 0; i < length; i++)
            {
                fr[i] = X[i] - mean;
                fi[i] = 0;
            }
            Fourier.FFT(fr, fi, length, 0);

            for (int i = 0; i < length; i++)
            {
                S[i] = Math.Sqrt(fr[i] * fr[i] + fi[i] * fi[i]) / length;

            }
        }
    }
}
