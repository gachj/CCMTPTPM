﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyBanHangDienTu.DataAccess;
using System.Data.SqlClient;

namespace QuanLyBanHangDienTu.Presentation
{
    public partial class fr_TK : Form
    {
        public fr_TK()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-M5K30I8;Initial Catalog=QL_BanHangDienTu;Integrated Security=True");
        private void txtthongtin_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT mahang, tenhang, manhom, maloai, madonvi, machatlieu, manuoc, soluong, dongianhap, dongiaban, thoigianbh, hinhanh, ghichu FROM tb_Hanghoa",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            msds.DataSource = dt;
            if (cblist.Text=="Mahang")
            {
                string sql = @"SELECT mahang, tenhang, manhom, maloai, madonvi, machatlieu, manuoc, soluong, dongianhap, dongiaban, thoigianbh, hinhanh, ghichu FROM tb_Hanghoa where mahang='"+txtthongtin.Text+"' ";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (cblist.Text=="Tenhang")
            {
                string sql = @"SELECT mahang, tenhang, manhom, maloai, madonvi, machatlieu, manuoc, soluong, dongianhap, dongiaban, thoigianbh, hinhanh, ghichu FROM tb_Hanghoa WHERE tenhang like '" + txtthongtin.Text + "'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if(cblist.Text=="Manhom")
            {
                string sql = @"SELECT mahang, tenhang, manhom, maloai, madonvi, machatlieu, manuoc, soluong, dongianhap, dongiaban, thoigianbh, hinhanh, ghichu FROM tb_Hanghoa WHERE manhom = '" + txtthongtin.Text + "'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (cblist.Text == "Maloai")
            {
                string sql = @"SELECT mahang, tenhang, manhom, maloai, madonvi, machatlieu, manuoc, soluong, dongianhap, dongiaban, thoigianbh, hinhanh, ghichu FROM tb_Hanghoa WHERE maloai = '" + txtthongtin.Text + "'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (cblist.Text == "Madonvi")
            {
                string sql = @"SELECT mahang, tenhang, manhom, maloai, madonvi, machatlieu, manuoc, soluong, dongianhap, dongiaban, thoigianbh, hinhanh, ghichu FROM tb_Hanghoa WHERE madonvi like '" + txtthongtin.Text + "'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (cblist.Text == "Machatlieu")
            {
                string sql = @"SELECT mahang, tenhang, manhom, maloai, madonvi, machatlieu, manuoc, soluong, dongianhap, dongiaban, thoigianbh, hinhanh, ghichu FROM tb_Hanghoa WHERE machatlieu = '" + txtthongtin.Text + "'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (cblist.Text == "Manuoc")
            {
                string sql = @"SELECT mahang, tenhang, manhom, maloai, madonvi, machatlieu, manuoc, soluong, dongianhap, dongiaban, thoigianbh, hinhanh, ghichu FROM tb_Hanghoa WHERE manuoc = '" + txtthongtin.Text + "'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
        }
        public void khoitaoluoi()
        {
            //RepositoryItemPictureEdit image = msds.RepositoryItems.Add("PictureEdit") as RepositoryItemPictureEdit;
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Hàng";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 200;

            msds.Columns[1].HeaderText = "Tên Hàng";
            msds.Columns[1].Width = 200;

            msds.Columns[2].HeaderText = "Mã Nhóm";
            msds.Columns[2].Width = 200;

            msds.Columns[3].HeaderText = "Mã Loại";
            msds.Columns[3].Width = 200;

            msds.Columns[4].HeaderText = "Mã Đơn Vị";
            msds.Columns[4].Width = 200;

            msds.Columns[5].HeaderText = "Mã Chất Liệu";
            msds.Columns[5].Width = 200;

            msds.Columns[6].HeaderText = "Mã Nước";
            msds.Columns[6].Width = 200;

            msds.Columns[7].HeaderText = "Số Lượng";
            msds.Columns[7].Width = 200;

            msds.Columns[8].HeaderText = "Đơn Giá Nhập";
            msds.Columns[8].Width = 200;

            msds.Columns[9].HeaderText = "Đơn Giá Bán";
            msds.Columns[9].Width = 200;

            msds.Columns[10].HeaderText = "Thời Gian Bảo Hành";
            msds.Columns[10].Width = 100;

            msds.Columns[11].HeaderText = "Hình Ảnh";
            msds.Columns[11].Width = 100;

            msds.Columns[12].HeaderText = "Ghi Chú";
            msds.Columns[12].Width = 100;

        }
        public void hienthi()
        {
            string sql = "SELECT mahang, tenhang, manhom, maloai, madonvi, machatlieu, manuoc, soluong, dongianhap, dongiaban, thoigianbh, hinhanh, ghichu FROM tb_Hanghoa";
            msds.DataSource = cn.taobang(sql);
            SqlConnection con = cn.getcon();
            con.Open();
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void fr_TK_Load(object sender, EventArgs e)
        {
            hienthi();
            khoitaoluoi();
        }
    }
}
