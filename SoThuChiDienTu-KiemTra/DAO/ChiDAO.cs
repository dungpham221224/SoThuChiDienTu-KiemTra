using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoThuChiDienTu_KiemTra.DTO;

namespace SoThuChiDienTu_KiemTra.DAO
{
    public class ChiDAO
    {
        private static ChiDAO instance;
        public static ChiDAO Instance
        {
            get { if (instance == null) instance = new ChiDAO(); return instance; }
            private set { instance = value; }
        }
        // thêm chi bằng số tài khoản 
        public bool ThemDanhMucChi(string soTaiKhoan, string taiKhoan, string loaiChi, int tienChi, DateTime thoiGian)
        {
            string query = "INSERT INTO Chi (SoTaiKhoan, TaiKhoan, LoaiChi, TienChi, ThoiGian) VALUES (@SoTaiKhoan, @TaiKhoan, @LoaiChi, @TienChi, @ThoiGian)";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { soTaiKhoan, taiKhoan, loaiChi, tienChi, thoiGian });
            return result > 0;
        }
        // xuất danh sách chi theo số tài khoản và taikhoan
        public DataTable XuatDanhSachChi(string soTaiKhoan, string taiKhoan)
        {
            string query = "SELECT * FROM Chi WHERE SoTaiKhoan = @soTaiKhoan AND TaiKhoan = @taiKhoan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { soTaiKhoan, taiKhoan });
            return data;
        }
        //cập nhật chi theo số tài khoản và taikhoan
        public bool CapNhatChi(string soTaiKhoan, string taiKhoan, string loaiChi, int tienChi, DateTime thoiGian)
        {
            string query = "UPDATE Chi SET LoaiChi = @loaiChi, TienChi = @tienChi, ThoiGian = @thoiGian WHERE SoTaiKhoan = @soTaiKhoan AND TaiKhoan = @taiKhoan";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { soTaiKhoan, taiKhoan, loaiChi, tienChi, thoiGian });
            return result > 0;
        }
        // xóa chi theo số tài khoản và taikhoan
        public bool XoaChi(string loaiChi)
        {
            string query = "DELETE FROM Chi WHERE LoaiChi = @loaiChi";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { loaiChi});
            return result > 0;
        }
        //xuất danh sách chi theo tháng 
        public DataTable XuatDanhSachChiTheoThang(string SoTaiKhoan, int Thang, int Nam)
        {
            string query = "EXEC XuatDanhSachChiTheoThang @SoTaiKhoan, @Thang, @Nam";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { SoTaiKhoan, Thang, Nam });
            return data;
        }
        public DataTable XuatDanhSachChi7NgayGanNhat(string SoTaiKhoan)
        {
            string query = "EXEC XuatDanhSachChi7NgayGanNhat @SoTaiKhoan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { SoTaiKhoan });
            return data;
        }
        public DataTable XuatDanhSachChi30NgayGanNhat(string SoTaiKhoan)
        {
            string query = "EXEC XuatDanhSachChi30NgayGanNhat @SoTaiKhoan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { SoTaiKhoan });
            return data;
        }
    }
}