using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BenhVienPT.Models
{
    public partial class BenhAn
    {
        public int Id { get; set; }
        public string MaBenhAn { get; set; }
        public int? IdbenhNhan { get; set; }
        public int? Idbenh { get; set; }
        public string GhiChu { get; set; }
        public string TrangThai { get; set; }

        public virtual BenhNhan IdbenhNhanNavigation { get; set; }
    }
}
