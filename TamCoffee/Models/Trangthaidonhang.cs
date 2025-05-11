using System;
using System.Collections.Generic;

namespace TamCoffee.Models
{
    public partial class Trangthaidonhang
    {
        public Trangthaidonhang()
        {
            Donhangs = new HashSet<Donhang>();
        }

        public int MaTrangThaiDh { get; set; }
        public string TenTrangThai { get; set; } = null!;

        public virtual ICollection<Donhang> Donhangs { get; set; }
    }
}
