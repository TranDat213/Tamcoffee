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
    public class TrangThaiDonHangDao
    {
        private static TAMCOFFEEContext _context;
        public TrangThaiDonHangDao() { 
            _context = new TAMCOFFEEContext();
        }
        public List<Trangthaidonhang>? GetAllTrangThaiDH()
        {
            try
            {
                return _context.Trangthaidonhangs.Include(t=>t.Donhangs).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách loại sản phẩm.", ex);
            }
        }
    }
}
