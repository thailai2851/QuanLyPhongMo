using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BenhVienPT.Models
{
    public partial class Benh
    {
        public Benh()
        {
            ChiTietBenhAn = new HashSet<ChiTietBenhAn>();
        }

        public int Id { get; set; }
        public string MaBenh { get; set; }
        public string TenBenh { get; set; }
        public int? MucDo { get; set; }
        public int? IdphongMo { get; set; }

        public virtual PhongMo IdphongMoNavigation { get; set; }
        public virtual ICollection<ChiTietBenhAn> ChiTietBenhAn { get; set; }
    }
}
