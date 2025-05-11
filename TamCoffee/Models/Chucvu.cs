using System;
using System.Collections.Generic;

namespace TamCoffee.Models
{
    public partial class Chucvu
    {
        public Chucvu()
        {
            Taikhoans = new HashSet<Taikhoan>();
        }

        public int MaChucVu { get; set; }
        public string TenChucVu { get; set; } = null!;

        public virtual ICollection<Taikhoan> Taikhoans { get; set; }
    }
}
