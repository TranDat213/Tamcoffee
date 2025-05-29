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
        public HoaDonTamDao()
        {
            if (_context == null)
            {
                _context = new TAMCOFFEEContext();
            }
        }
        public void ThemMonTam(Chitiethoadon chitiet)
        {
            _hoaDonTam.DanhSachChiTiet.Add(chitiet);
        }
        public List<Chitiethoadon> LayDSTam()
        {
            return _hoaDonTam.DanhSachChiTiet;
        }
        //public bool LuuHDTVaoDatabase(List<Chitiethoadon> chittiets,int chiphikhac=0,int maTk=1,int maPtt=1,int matt=1)
        //{
        //    try
        //    {
        //        Donhang dh = new Donhang
        //        {
        //            NgayLapHoaDon = DateTime.Now,
        //            Chitiethoadons = chittiets,
        //            ChiPhiKhac=chiphikhac,
        //            MaTk=maTk,
        //            MaPttt=maPtt,
        //            MaTrangThaiDh=matt
        //        };
        //        _context.Donhangs.Add(dh);
        //        return _context.SaveChanges() > 0;
        //    }
        //    catch (Exception ex) {
        //        throw new Exception($"Lỗi khi lưu hóa đơn vào database: {ex.Message}");
        //    }
        //}
        public void XoaDSTam()
        {
            Console.WriteLine($"HoaDonTamDao: Xóa {_hoaDonTam.DanhSachChiTiet.Count} chi tiết hóa đơn tạm.");
            _hoaDonTam.DanhSachChiTiet.Clear();
        }
        public bool LuuHDTVaoDatabase(List<Chitiethoadon> chittiets, int chiphikhac = 0, int maTk = 1, int maPtt = 1, int matt = 1)
        {
            try
            {
                Console.WriteLine($"HoaDonTamDao: Đang lưu {chittiets.Count} chi tiết hóa đơn vào database.");

                // Tạo hóa đơn mới
                Donhang dh = new Donhang
                {
                    NgayLapHoaDon = DateTime.Now,
                    Chitiethoadons = new List<Chitiethoadon>(),
                    ChiPhiKhac = chiphikhac,
                    MaTk = maTk,
                    MaPttt = maPtt,
                    MaTrangThaiDh = matt
                };

                // Thêm đơn hàng trước
                _context.Donhangs.Add(dh);
                _context.SaveChanges();

                Console.WriteLine($"HoaDonTamDao: Đã tạo hóa đơn mới với mã: {dh.MaDonHang}");

                // Thêm chi tiết hóa đơn với mã đơn hàng đã tạo
                foreach (var ct in chittiets)
                {
                    var newChiTiet = new Chitiethoadon(ct.MaSanPham, dh.MaDonHang, ct.SoLuong);
                    _context.Chitiethoadons.Add(newChiTiet);
                    Console.WriteLine($"HoaDonTamDao: Đã thêm chi tiết: SP={ct.MaSanPham}, SL={ct.SoLuong}");
                }

                int changes = _context.SaveChanges();
                Console.WriteLine($"HoaDonTamDao: Đã lưu {changes} chi tiết hóa đơn.");
                return changes > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"HoaDonTamDao: Lỗi khi lưu hóa đơn vào database: {ex.Message}");
                throw new Exception($"Lỗi khi lưu hóa đơn vào database: {ex.Message}");
            }
        }
    }
}
