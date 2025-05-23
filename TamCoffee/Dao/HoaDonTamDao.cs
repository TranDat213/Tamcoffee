using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamCoffee.Models;
using TamCoffee.Models.Server;

namespace TamCoffee.Dao
{
    public class HoaDonTamDao
    {
        private static TAMCOFFEEContext _context;
        private HoaDonTam _hoaDonTam=new HoaDonTam();
        public void ThemMonTam(Chitiethoadon chitiet)
        {
            _hoaDonTam.DanhSachChiTiet.Add(chitiet);
        }
        public List<Chitiethoadon> LayDSTam()
        {
            return _hoaDonTam.DanhSachChiTiet;
        }
        public bool LuuHDTVaoDatabase(List<Chitiethoadon> chittiets,int chiphikhac,int maTk=1,int maPtt=1,int matt=1)
        {
            try
            {
                Donhang dh = new Donhang
                {
                    NgayLapHoaDon = DateTime.Now,
                    Chitiethoadons = chittiets,
                    ChiPhiKhac=chiphikhac,
                    MaTk=maTk,
                    MaPttt=maPtt,
                    MaTrangThaiDh=matt
                };
                _context.Donhangs.Add(dh);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex) {
                throw new Exception($"Lỗi khi lưu hóa đơn vào database: {ex.Message}");
            }
        }
    }
}
