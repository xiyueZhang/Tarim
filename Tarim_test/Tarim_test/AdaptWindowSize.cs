using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarim_test
{
    public partial class Tarim : Form
    {
        private void AptWindowSize()
        {
            try
            {
                InfoShow.Location = new System.Drawing.Point(4, Size.Height - 55);

                Tarim_TreeList.Size = new System.Drawing.Size(169, Size.Height - Tarim_TreeList.Location.Y - 70);

                FreqDemo.Size = new System.Drawing.Size(Size.Width - this.FreqDemo.Location.X - 20,
                    Size.Height / 2 - FreqDemo.Location.Y - 30);
                if (Size.Height > (FreqDemo.Size.Height + FreqDemo.Location.Y + 5))
                {
                    TimeDemo.Location = new System.Drawing.Point(FreqDemo.Location.X,
                        FreqDemo.Location.Y + FreqDemo.Size.Height);
                    TimeDemo.Size = new System.Drawing.Size(Size.Width - this.FreqDemo.Location.X - 20,
                        Size.Height - TimeDemo.Location.Y - 55);
                }


                InfoShow.Text = "hight: " + Size.Height.ToString() + "width:" + Size.Width.ToString() + "  Layout change";
            }
            catch
            {
                InfoShow.Text = "不要太小";
            }

        }
        
    }
}
