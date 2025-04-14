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
    public class ThuDAO
    {
        private static ThuDAO instance;
        public static ThuDAO Instance
        {
            get { if (instance == null) instance = new ThuDAO(); return instance; }
            private set { instance = value; }
        }
        public bool ThemDanhMucChi(string soTaiKhoan, string taiKhoan, string loaiThu, int tienThu, DateTime thoiGian)
        {
            string query = "INSERT INTO Thu (SoTaiKhoan, TaiKhoan, LoaiThu, TienThu, ThoiGian) VALUES (@SoTaiKhoan, @TaiKhoan, @LoaiThu, @TienThu, @ThoiGian)";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { soTaiKhoan, taiKhoan, loaiThu, tienThu, thoiGian });
            return result > 0;
        }
        public DataTable XuatDanhSachThu(string soTaiKhoan, string taiKhoan)
        {
            string query = "SELECT * FROM Thu WHERE SoTaiKhoan = @soTaiKhoan AND TaiKhoan = @taiKhoan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { soTaiKhoan, taiKhoan });
            return data;
        }

        public bool CapNhatThu(string soTaiKhoan, string taiKhoan, string loaiThu, int tienThu, DateTime thoiGian)
        {
            string query = "UPDATE Chi SET LoaiThu = @loaiThu, TienChi = @tienThu, ThoiGian = @thoiGian WHERE SoTaiKhoan = @soTaiKhoan AND TaiKhoan = @taiKhoan";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { soTaiKhoan, taiKhoan, loaiThu, tienThu, thoiGian });
            return result > 0;
        }

        public bool XoaThu(string loaiThu)
        {
            string query = "DELETE FROM Chi WHERE LoaiThu = @loaiThu";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { loaiThu });
            return result > 0;
        }

        public DataTable XuatDanhSachThuTheoThang(string SoTaiKhoan, int Thang, int Nam)
        {
            string query = "EXEC XuatDanhSachThuTheoThang @SoTaiKhoan, @Thang, @Nam";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { SoTaiKhoan, Thang, Nam });
            return data;
        }
        public DataTable XuatDanhSachThu7NgayGanNhat(string SoTaiKhoan)
        {
            string query = "EXEC XuatDanhSachThu7NgayGanNhat @SoTaiKhoan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { SoTaiKhoan });
            return data;
        }
        public DataTable XuatDanhSachThu30NgayGanNhat(string SoTaiKhoan)
        {
            string query = "EXEC XuatDanhSachThu30NgayGanNhat @SoTaiKhoan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { SoTaiKhoan });
            return data;
        }
    }
}