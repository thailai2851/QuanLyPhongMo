using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BenhVienPT.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            BenhAn = new HashSet<BenhAn>();
            LichTruc = new HashSet<LichTruc>();
            PhongHoiTinh = new HashSet<PhongHoiTinh>();
            PhongMo = new HashSet<PhongMo>();
        }

        public int Id { get; set; }
        public string MaNv { get; set; }
        public string TenNv { get; set; }
        public string GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public int? IdcaMo { get; set; }
        public int? IdtaiKhoan { get; set; }

        public virtual CaMo IdcaMoNavigation { get; set; }
        public virtual TaiKhoan IdtaiKhoanNavigation { get; set; }
        public virtual ICollection<BenhAn> BenhAn { get; set; }
        public virtual ICollection<LichTruc> LichTruc { get; set; }
        public virtual ICollection<PhongHoiTinh> PhongHoiTinh { get; set; }
        public virtual ICollection<PhongMo> PhongMo { get; set; }
    }
}
