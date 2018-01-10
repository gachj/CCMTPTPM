using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangDienTu.Presentation
{
    public partial class fr_SplashScreen : Form
    {
        public fr_SplashScreen()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pbr.Increment(1);
            if (pbr.Value == 100)
            {
                timer.Stop();
            }
        }
    }
}
