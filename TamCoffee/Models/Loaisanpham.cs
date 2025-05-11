using System;
using System.Collections.Generic;

namespace TamCoffee.Models
{
    public partial class Loaisanpham
    {
        public Loaisanpham()
        {
            Sanphams = new HashSet<Sanpham>();
        }

        public int MaLoaiSanPham { get; set; }
        public string TenLoaiSanPham { get; set; } = null!;

        public virtual ICollection<Sanpham> Sanphams { get; set; }
        public void printinfo() => Console.WriteLine($"MaLoaiSanPham: {MaLoaiSanPham} TenLoaiSanPham: {TenLoaiSanPham}");

    }
}
