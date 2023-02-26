using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BenhVienPT.Models
{
    public partial class LichTruc
    {
        public int Id { get; set; }
        public string MaLich { get; set; }
        public DateTime? NgayTruc { get; set; }
        public string CaTruc { get; set; }
        public int? Idnv { get; set; }

        public virtual NhanVien IdnvNavigation { get; set; }
    }
}
