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
    internal class HoaDonDao
    {
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
    }
}
