using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BenhVienPT.Models
{
    public partial class PhongMo
    {
        public int Id { get; set; }
        public string MaPhongMo { get; set; }
        public string TenPhongMo { get; set; }
        public string TrangThai { get; set; }
        public int? Idbenh { get; set; }
        public string IdcaMo { get; set; }
    }
}
