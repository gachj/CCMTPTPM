using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using QuanLyBanHangDienTu.Business.Component;
using QuanLyBanHangDienTu.DataAccess;


namespace QuanLyBanHangDienTu.Presentation
{
    public partial class fr_HDN : Form
    {
        public fr_HDN()
        {
            InitializeComponent();
        }
        E_tb_HDN thucthi = new E_tb_HDN();
        ConnectDB cn = new ConnectDB();
        EC_tb_HDN ck = new EC_tb_HDN();
        bool themmoi;
        int dong = 0;

        public void setnull()
        {
            txtma.Text = "";
            txtngay.Text = DateTime.Now.ToShortTimeString();
            cbncc.Text = "";
            cbnv.Text = "";
            txttt.Text = "0";
        }
        public void locktext()
        {
            txtma.Enabled = false;
            txtngay.Enabled = false;
            cbncc.Enabled = false;
            cbnv.Enabled = false;

            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtma.Enabled = true;
            txtngay.Enabled = true;
            cbncc.Enabled = true;
            cbnv.Enabled = true;

            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
    }
}
