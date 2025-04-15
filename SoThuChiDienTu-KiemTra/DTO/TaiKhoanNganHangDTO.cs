using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoThuChiDienTu_KiemTra.DTO
{
    public class TaiKhoanNganHangDTO
    {
        string taiKhoan;
        string tenNganHang;
        string soTaiKhoan;
        int soDu;

        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string TenNganHang { get => tenNganHang; set => tenNganHang = value; }
        public string SoTaiKhoan { get => soTaiKhoan; set => soTaiKhoan = value; }
        public int SoDu { get => soDu; set => soDu = value; }
        public TaiKhoanNganHangDTO() { }
        public TaiKhoanNganHangDTO(string taiKhoan, string tenNganHang, string soTaiKhoan, int soDu)
        {
            this.taiKhoan = taiKhoan;
            this.tenNganHang = tenNganHang;
            this.soTaiKhoan = soTaiKhoan;
            this.soDu = soDu;
        }
    }
}
