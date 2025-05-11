using System;
using System.Collections.Generic;

namespace TamCoffee.Models
{
    public partial class Taikhoan
    {
        public Taikhoan()
        {
            Donhangs = new HashSet<Donhang>();
        }

        public int MaTk { get; set; }
        public string HovaTen { get; set; } = null!;
        public string TenTaiKhoan { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public bool GioiTinh { get; set; }
        public string Email { get; set; } = null!;
        public int? MaChucVu { get; set; }

        public virtual Chucvu? MaChucVuNavigation { get; set; }
        public virtual ICollection<Donhang> Donhangs { get; set; }
    }
}
