using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BenhVienPT.Models
{
    public partial class CaMo
    {
        public int Id { get; set; }
        public string MaCaMo { get; set; }
        public string TenCaMo { get; set; }
        public DateTime? ThoiGian { get; set; }
        public int? Idnv { get; set; }
        public int? Idbenh { get; set; }
    }
}
