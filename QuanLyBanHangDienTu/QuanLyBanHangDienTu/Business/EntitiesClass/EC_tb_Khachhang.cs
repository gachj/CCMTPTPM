using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHangDienTu.Business.EntitiesClass
{
    class EC_tb_Khachhang
    {
        private string makh;
        private string tenkh;
        private string diachi;
        private string dienthoai;

        public string MAKH
        {
            get
            {
                return makh;
            }
            set
            {
                makh = value;
                if (makh == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string TENKH
        {
            get
            {
                return tenkh;
            }
            set
            {
                tenkh = value;
                if (tenkh == "")
                {
                    throw new Exception("không được bỏ trống");
                }
            }
        }
        public string DIACHI
        {
            get
            {
                return diachi;
            }
            set
            {
                diachi = value;
                if (diachi == "")
                {
                    throw new Exception("không được bỏ trống");
                }
            }
        }
        public string DIENTHOAI
        {
            get
            {
                return dienthoai;
            }
            set
            {
                dienthoai = value;
                if (dienthoai == "")
                {
                    throw new Exception("không được bỏ trống");
                }
            }
        }
    }
}
