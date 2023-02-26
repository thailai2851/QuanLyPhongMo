using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BenhVienPT.Models
{
    public partial class PhongMo
    {
        public PhongMo()
        {
            Benh = new HashSet<Benh>();
            CaMo = new HashSet<CaMo>();
            Tgmo = new HashSet<Tgmo>();
            VatTuYte = new HashSet<VatTuYte>();
        }

        public int Id { get; set; }
        public string MaPhongMo { get; set; }
        public string TenPhongMo { get; set; }
        public string TrangThai { get; set; }
        public string Loai { get; set; }
        public DateTime? Ngay { get; set; }
        public int? Idnv { get; set; }

        public virtual NhanVien IdnvNavigation { get; set; }
        public virtual ICollection<Benh> Benh { get; set; }
        public virtual ICollection<CaMo> CaMo { get; set; }
        public virtual ICollection<Tgmo> Tgmo { get; set; }
        public virtual ICollection<VatTuYte> VatTuYte { get; set; }
    }
}
