using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyBanHangDienTu.Business.Component;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using QuanLyBanHangDienTu.DataAccess;
using COMExcel = Microsoft.Office.Interop.Excel;


namespace QuanLyBanHangDienTu.Presentation
{
    public partial class fr_CTHDN : Form
    {
        public fr_CTHDN()
        {
            InitializeComponent();
        }
        E_tb_CTHDN thucthi = new E_tb_CTHDN();
        ConnectDB cn = new ConnectDB();
        EC_tb_CTHDN ck = new EC_tb_CTHDN();
        bool themmoi;
        int dong = 0;

        private string sohdn;
        public string SOHDN
        {
            get
            {
                return sohdn;
            }
            set
            {
                sohdn = value;
            }
        }
    }
}
