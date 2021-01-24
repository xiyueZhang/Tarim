using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarim_test
{
    public partial class Navicat : Form
    {
        private void AptWindowSize()
        {
            GridDdatalabel.Location = new System.Drawing.Point(10, Size.Height-60);
            MySQLdataGridView.Size = new System.Drawing.Size(Size.Width - this.MySQLdataGridView.Location.X - 20,
                Size.Height  - MySQLdataGridView.Location.Y - 60);
            NavicattreeView.Size = new System.Drawing.Size(380, Size.Height - NavicattreeView.Location.Y - 60);
        }
    }
}
