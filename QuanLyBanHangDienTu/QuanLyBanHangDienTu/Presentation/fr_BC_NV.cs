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
    public partial class fr_BC_NV : Form
    {
        public fr_BC_NV()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        E_tb_HDB thucthi = new E_tb_HDB();
        E_tb_Nhanvien nv = new E_tb_Nhanvien();

        private void button1_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "BÁO CÁO";
            //Lấy thông tin các mặt hàng
            sql = @"SELECT tb_CongViec.tencv,tb_Nhanvien.tennv,tb_HDB.manv,tb_Hanghoa.tenhang,tb_CTHDB.soluong AS T FROM tb_HDB INNER JOIN tb_CTHDB ON tb_HDB.sohdb = tb_CTHDB.sohdb INNER JOIN tb_Nhanvien on tb_HDB.manv=tb_Nhanvien.manv INNER JOIN tb_Congviec on tb_Nhanvien.macv = tb_Congviec.macv INNER JOIN tb_Hanghoa on tb_CTHDB.mahang=tb_Hanghoa.mahang where tb_HDB.manv='" + cbnv.Text + "'";
            tblThongtinHang = cn.taobang(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 14;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Chức Vụ";
            exRange.Range["C11:C11"].Value = "Tên NV";
            exRange.Range["D11:D11"].Value = "Mã NV";
            exRange.Range["E11:E11"].Value = "Tên Hàng";
            exRange.Range["F11:F11"].Value = "Số Lượng Nhập";

            for (hang = 0; hang <= tblThongtinHang.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblThongtinHang.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
            }
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = DateTime.Now;
            exRange.Range["A1:C1"].Value = "Ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exSheet.Name = "Báo Cáo";
            exApp.Visible = true;
        }

        private void fr_BC_NV_Load(object sender, EventArgs e)
        {
            thucthi.loadmanv(cbnv);
        }

        private void cbnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbnv.Text = thucthi.loadtennv(lbnv.Text, cbnv.Text);
        }
    }
}
