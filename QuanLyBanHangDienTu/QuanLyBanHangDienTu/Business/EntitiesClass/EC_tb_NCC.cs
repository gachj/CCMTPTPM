﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace QuanLyBanHangDienTu.Business.EntitiesClass
{
    class EC_tb_NCC
    {
        private string mancc;
        private string tenncc;
        private string diachi;
        private string dienthoai;

        public string MANCC
        {
            get
            {
                return mancc;
            }
            set
            {
                mancc = value;
                if (mancc == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string TENNCC
        {
            get
            {
                return tenncc;
            }
            set
            {
                tenncc = value;
                if (tenncc == "")
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
