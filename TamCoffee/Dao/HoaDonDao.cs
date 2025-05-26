using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamCoffee.Models;
using TamCoffee.Models.Server;

namespace TamCoffee.Dao
{
    public class HoaDonDao
    {
        HoaDonTam hdtam=new HoaDonTam();
        private static TAMCOFFEEContext _context;
        public HoaDonDao()
        {
            _context = new TAMCOFFEEContext();
        }
        public List<Donhang> GetAllHoaDon()
        {
            try
            {
                return _context.Donhangs
                       .Include(d => d.MaTkNavigation)
                       .Include(d => d.MaPtttNavigation)
                       .Include(d => d.MaTrangThaiDhNavigation)
                       .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách hóa đơn!");
            }
        }
        public bool AddHoaDon(Donhang hoadon)
        {
            try
            {
                _context.Donhangs.Add(hoadon);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm hóa đơn: {ex.Message}");
            }
        }
        public bool AddChiTiethoaDon(Donhang donhang, Chitiethoadon chitiet)
        {
            try
            {
                // Thêm chi tiết hóa đơn vào hóa đơn
                donhang.Chitiethoadons.Add(chitiet);
                // Cập nhật hóa đơn
                _context.Donhangs.Update(donhang);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm chi tiết hóa đơn: {ex.Message}");
            }
        }
        public Donhang LuuHDTVaoDatabase(List<Chitiethoadon> chittiets, int chiphikhac=0, int maTk = 1, int maPtt = 1, int matt = 1)
        {
            try
            {

                Donhang dh = new Donhang
                {
                    NgayLapHoaDon = DateTime.Now,
                    Chitiethoadons = new List<Chitiethoadon>(),
                    ChiPhiKhac = chiphikhac,
                    MaTk = maTk,
                    MaPttt = maPtt,
                    MaTrangThaiDh = matt
                };
                _context.Donhangs.Add(dh);
                _context.SaveChanges() ;
                foreach(var ct in chittiets)
                {
                    ct.MaDonHang = dh.MaDonHang;
                    _context.Chitiethoadons.Add(ct);
                }
                _context.SaveChanges();
                return dh;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lưu hóa đơn vào database: {ex.Message}");
            }
        }
    }
}
