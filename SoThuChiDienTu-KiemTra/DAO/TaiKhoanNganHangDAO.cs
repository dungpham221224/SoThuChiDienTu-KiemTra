using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using SoThuChiDienTu_KiemTra.DTO;

namespace SoThuChiDienTu_KiemTra.DAO
{
    public class TaiKhoanNganHangDAO
    {
        private DataTable Table(string query)
        {
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable LayDanhSachTaiKhoanNganHangTheoLuaChon(string taiKhoan, string tenNganHang, string soTaiKhoan)
        {
            string query = "select * from TaiKhoanNganHang where TaiKhoan like '%" + taiKhoan + "%' and TenNganHang like N'%" + tenNganHang + "%' and SoTaiKhoan like N'%" + soTaiKhoan + "%'";
            return Table(query);
        }
        public bool XoaTaiKhoanNganHang(string taiKhoan)
        {
            var query = "delete from TaiKhoanNganHang where TaiKhoan = @taiKhoan";
            var count = DataProvider.Instance.ExecuteReader(query, new object[] { taiKhoan });
            bool hasRows = false;
            if (count.Read())
            {
                hasRows = true;
            }
            return hasRows;
        }
        public bool ThemTaiKhoanNganHang(string taiKhoan, string tenNganHang, string soTaiKhoan)
        {
            string query = "INSERT INTO TaiKhoanNganHang (TaiKhoan, TenNganHang, SoTaiKhoan) VALUES (@taiKhoan, @tenNganHang, @soTaiKhoan)";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { taiKhoan, tenNganHang, soTaiKhoan });
            return result > 0;
        }
        public bool CapNhatSoTaiKhoan(string taiKhoan, string tenNganHang, string soTaiKhoan)
        {
            string query = "UPDATE TaiKhoanNganHang WHERE TenNganHang = @tenNganHang, SoTaiKhoan = @soTaiKhoan WHERE TaiKhoan = @taiKhoan";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { taiKhoan, tenNganHang, soTaiKhoan });
            return result > 0;
        }
    }
}
