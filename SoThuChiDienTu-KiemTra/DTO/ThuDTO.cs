using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoThuChiDienTu_KiemTra.DTO
{
    public class ThuDTO
    {
        string taiKhoan;
        string soTaiKhoan;
        string tenThu;
        DateTime thoiGian;
        string loaiThu;

        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string SoTaiKhoan { get => soTaiKhoan; set => soTaiKhoan = value; }
        public string TenThu { get => tenThu; set => tenThu = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }
        public string LoaiThu { get => loaiThu; set => loaiThu = value; }
        public ThuDTO() { }
        public ThuDTO(string taiKhoan, string soTaiKhoan, string tenThu, DateTime thoiGian, string loaiThu)
        {
            this.taiKhoan = taiKhoan;
            this.soTaiKhoan = soTaiKhoan;
            this.tenThu = tenThu;
            this.thoiGian = thoiGian;
            this.loaiThu = loaiThu;
        }
    }
}
