using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoThuChiDienTu_KiemTra.DTO
{
    public class TaiKhoanNganHangDTO
    {
        int id;
        string tenNganHang;
        string soTaiKhoan;
        int soDu;

        public int Id { get => id; set => id = value; }
        public string TenNganHang { get => tenNganHang; set => tenNganHang = value; }
        public string SoTaiKhoan { get => soTaiKhoan; set => soTaiKhoan = value; }
        public int SoDu { get => soDu; set => soDu = value; }
        public TaiKhoanNganHangDTO() { }
        public TaiKhoanNganHangDTO(int id, string tenNganHang, string soTaiKhoan, int soDu)
        {
            this.id = id;
            this.tenNganHang = tenNganHang;
            this.soTaiKhoan = soTaiKhoan;
            this.soDu = soDu;
        }
    }
}
