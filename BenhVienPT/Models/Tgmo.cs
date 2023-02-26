using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BenhVienPT.Models
{
    public partial class Tgmo
    {
        public int Id { get; set; }
        public string MaTgmo { get; set; }
        public string TenTgmo { get; set; }
        public DateTime? TgbatDau { get; set; }
        public DateTime? TgketThuc { get; set; }
        public int? IdphongMo { get; set; }

        public virtual PhongMo IdphongMoNavigation { get; set; }
    }
}
