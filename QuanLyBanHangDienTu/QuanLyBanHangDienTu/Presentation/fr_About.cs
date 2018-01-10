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
    public partial class fr_About : Form
    {
        public fr_About()
        {
            InitializeComponent();
        }

        private void timer_About_Tick(object sender, EventArgs e)
        {
            timer_About.Stop();
        }
    }
}
