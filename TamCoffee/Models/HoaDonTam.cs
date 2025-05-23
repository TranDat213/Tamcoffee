using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamCoffee.Models
{
    public partial class HoaDonTam
    {
        public List<Chitiethoadon> DanhSachChiTiet {  get; set; }=new List<Chitiethoadon>();
        public Donhang DonHangTam { get; set; }=new Donhang();
    }
}
