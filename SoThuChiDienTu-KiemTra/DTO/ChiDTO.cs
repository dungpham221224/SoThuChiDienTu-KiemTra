using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoThuChiDienTu_KiemTra.DTO
{
    public class ChiDTO
    {
        int id;
        string tenChi;
        int soTien;
        DateTime thoiGian;
        string loaiChi;
        public int Id { get => id; set => id = value; }
        public string TenChi { get => tenChi; set => tenChi = value; }
        public int SoTien { get => soTien; set => soTien = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }
        public string LoaiChi { get => loaiChi; set => loaiChi = value; }
        public ChiDTO() { }
        public ChiDTO(int id, string tenChi, int soTien, DateTime thoiGian, string loaiChi)
        {
            this.id = id;
            this.tenChi = tenChi;
            this.soTien = soTien;
            this.thoiGian = thoiGian;
            this.loaiChi = loaiChi;
        }
    }
}
