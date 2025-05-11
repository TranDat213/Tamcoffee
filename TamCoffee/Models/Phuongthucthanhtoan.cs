using System;
using System.Collections.Generic;

namespace TamCoffee.Models
{
    public partial class Phuongthucthanhtoan
    {
        public Phuongthucthanhtoan()
        {
            Donhangs = new HashSet<Donhang>();
        }

        public int MaPttt { get; set; }
        public string TenPhuongThuc { get; set; } = null!;

        public virtual ICollection<Donhang> Donhangs { get; set; }
    }
}
