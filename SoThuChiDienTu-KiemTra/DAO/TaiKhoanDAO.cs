﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoThuChiDienTu_KiemTra.DTO;

namespace SoThuChiDienTu_KiemTra.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return TaiKhoanDAO.instance; }
            private set { TaiKhoanDAO.instance = value; }
        }
        public bool DangNhap(string username, string password, out string userNameOut)
        {
            string query = "SELECT TaiKhoan FROM Users WHERE TaiKhoan=@username AND MatKhau=@password";

            using (SqlDataReader reader = DataProvider.Instance.ExecuteReader(query, new object[] { username, password }))
            {
                if (reader.Read()) 
                {
                    userNameOut = reader.GetString(0); 
                    return true;
                }
            }

            userNameOut = null;
            return false;
        }

        public bool ThayDoiMatKhau(string taiKhoan, string matKhauMoi)
        {
            string query = string.Format("UPDATE Users WHERE TaiKhoan = N'" + taiKhoan + "SET MatKhau = N'" + matKhauMoi);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        private DataTable Table(string query)
        {
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable LayDanhSachTaiKhoanTheoLuaChon(string taiKhoan, string gioiTinhNam, string gioiTinhNu, string DiaChi)
        {
            string query = "select * from Users where TaiKhoan like '%" + taiKhoan + "%' and GioiTinh in (N'" + gioiTinhNam + "',N'" + gioiTinhNu + "') and DiaChi like N'%" + DiaChi + "%'";
            return Table(query);
        }

        public bool XoaTaiKhoan(string taiKhoan)
        {
            var query = "delete from Users where TaiKhoan = @taiKhoan";
            var count = DataProvider.Instance.ExecuteReader(query, new object[] { taiKhoan });
            bool hasRows = false;
            if (count.Read())
            {
                hasRows = true;
            }
            return hasRows;
        }
        public bool DangKy(string taiKhoan, string matKhau, string gioiTinh, string sdt, string diaChi, DateTime ngaySinh)
        {
            string query = "INSERT INTO Users (TaiKhoan, MatKhau, GioiTinh, SDT, DiaChi, NgaySinh, HoTen) VALUES (@taiKhoan, @matKhau, @gioiTinh, @sdt, @diaChi, @ngaySinh, @hoTen)";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { taiKhoan, matKhau, gioiTinh, sdt, diaChi, ngaySinh, hoTen });
            return result > 0;
        }
    }
}
