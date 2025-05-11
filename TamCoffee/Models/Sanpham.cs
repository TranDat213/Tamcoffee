using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace TamCoffee.Models
{
    public partial class Sanpham
    {
        public Sanpham()
        {
            Chitiethoadons = new HashSet<Chitiethoadon>();
        }

        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; } = null!;
        public decimal GiaSp { get; set; }
        public int? MaLoaiSanPham { get; set; }

        public virtual Loaisanpham? MaLoaiSanPhamNavigation { get; set; }
        public virtual ICollection<Chitiethoadon> Chitiethoadons { get; set; }
        public String printinfo() => ($"MaSanPham: {MaSanPham} TenSanPham: {TenSanPham} GiaSp: {GiaSp} MaLoaiSanPham: {MaLoaiSanPham}");

    }
}
