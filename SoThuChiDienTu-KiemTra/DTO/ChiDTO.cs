using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoThuChiDienTu_KiemTra.DTO
{
    public class ChiDTO
    {
        string taiKhoan;
        int soTaiKhoan;
        string loaiChi;
        int soTien;
        DateTime thoiGian;
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public int SoTaiKhoan { get => soTaiKhoan; set => soTaiKhoan = value; }
        public string LoaiChi { get => loaiChi; set => loaiChi = value; }
        public int SoTien { get => soTien; set => soTien = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }
        public ChiDTO() { }
        public ChiDTO(string taiKhoan, int soTaiKhoan, string loaiChi, int soTien, DateTime thoiGian)
        {
            this.taiKhoan = taiKhoan;
            this.soTaiKhoan = soTaiKhoan;
            this.loaiChi = loaiChi;
            this.soTien = soTien;
            this.thoiGian = thoiGian;
        }

    }
}
