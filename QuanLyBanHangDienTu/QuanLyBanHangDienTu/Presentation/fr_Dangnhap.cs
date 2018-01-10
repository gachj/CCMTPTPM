using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using QuanLyBanHangDienTu.DataAccess;
using QuanLyBanHangDienTu.Business.EntitiesClass;
using QuanLyBanHangDienTu.Business.Component;
using QuanLyBanHangDienTu.Presentation;
using System.Security.Cryptography;
using System.IO;
using System.Threading;

namespace QuanLyBanHangDienTu.Presentation
{
    public partial class fr_Dangnhap : Form
    {
        public fr_Dangnhap()
        {
            Thread thread1 = new Thread(new ThreadStart(splashScreen));
            thread1.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            thread1.Abort();
            Thread thread2 = new Thread(new ThreadStart(aBout));
            thread2.Start();
            Thread.Sleep(3000);
            thread2.Abort();
        }
        private void splashScreen()
        {
            Application.Run(new fr_SplashScreen());
        }
        private void aBout()
        {
            Application.Run(new fr_About());
        }
        ConnectDB cn = new ConnectDB();
        E_tb_User thucthi = new E_tb_User();
        EC_tb_User ck = new EC_tb_User();
        private void cmddn_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpass.Text;
            try
            {
                ck.USERNAME = user;
                ck.PASSWORD = pass;
                if (!thucthi.kiemtrauser(user, pass))
                {
                    MessageBox.Show("Đăng Nhập Thành Công", "Chúc Mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fr_Main fr = new fr_Main();
                    this.Hide();
                    fr.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản đăng nhập chưa đúng. Vui lòng kiểm tra lại.", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtuser.Text = "";
                    txtpass.Text = "";
                    txtuser.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                SendKeys.Send("{TAB}");
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                cmddn.Enabled = false;
                cmddn_Click(sender, e);
            }
        }
    }
}
