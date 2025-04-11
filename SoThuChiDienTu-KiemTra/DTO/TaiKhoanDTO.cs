﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoThuChiDienTu_KiemTra.DTO
{
    public class TaiKhoanDTO
    {
        int userId;
        public string tendangnhap;

        public string matkhau;

        public string gioitinh;

        public string sdt;

        public string diachi;

        public string loaitaikhoan;

        public DateTime ngaysinh;

        public string huyen;

        public string tinh;

        public int userId1 { get => userId; set => userId = value; }
        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Loaitaikhoan { get => loaitaikhoan; set => loaitaikhoan = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }

        public string Huyen { get => huyen; set => huyen = value; }
        public string Tinh { get => tinh; set => tinh = value; }


        public TaiKhoanDTO() { }

        public TaiKhoanDTO(int userId, string tendangnhap, string matkhau, string hoten, string gioitinh, string sdt, string diachi, string loaitaikhoan, DateTime ngaysinh, string huyen, string tinh)
        {
            this.userId = userId;
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.gioitinh = gioitinh;
            this.sdt = sdt;
            this.diachi = diachi;
            this.loaitaikhoan = loaitaikhoan;
            this.ngaysinh = ngaysinh;
            this.huyen = huyen;
            this.tinh = tinh;
        }

        public TaiKhoanDTO(string tendangnhap, string hoten, string gioitinh, string sdt, string diachi, string loaitaikhoan, DateTime ngaysinh)
        {
            this.tendangnhap = tendangnhap;
            this.gioitinh = gioitinh;
            this.sdt = sdt;
            this.diachi = diachi;
            this.loaitaikhoan = loaitaikhoan;
            this.ngaysinh = ngaysinh;
        }
    }
}
