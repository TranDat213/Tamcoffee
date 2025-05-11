using System;
using System.Collections.Generic;

namespace TamCoffee.Models
{
    public partial class Donhang
    {
        public Donhang()
        {
            Chitiethoadons = new HashSet<Chitiethoadon>();
        }

        public int MaDonHang { get; set; }
        public DateTime NgayLapHoaDon { get; set; }
        public float ChiPhiKhac { get; set; }
        public int? MaTk { get; set; }
        public int? MaPttt { get; set; }
        public int? MaTrangThaiDh { get; set; }

        public virtual Phuongthucthanhtoan? MaPtttNavigation { get; set; }
        public virtual Taikhoan? MaTkNavigation { get; set; }
        public virtual Trangthaidonhang? MaTrangThaiDhNavigation { get; set; }
        public virtual ICollection<Chitiethoadon> Chitiethoadons { get; set; }
    }
}
