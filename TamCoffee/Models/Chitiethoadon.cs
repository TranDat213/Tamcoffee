using System;
using System.Collections.Generic;

namespace TamCoffee.Models
{
    public partial class Chitiethoadon
    {
        public int MaSanPham { get; set; }
        public int MaDonHang { get; set; }
        public int SoLuong { get; set; }

        public Chitiethoadon(int maSanPham, int maDonHang, int soLuong)
        {
            MaSanPham = maSanPham;
            MaDonHang = maDonHang;
            SoLuong = soLuong;
        }
        public virtual Donhang MaDonHangNavigation { get; set; } = null!;
        public virtual Sanpham MaSanPhamNavigation { get; set; } = null!;
    }
}
