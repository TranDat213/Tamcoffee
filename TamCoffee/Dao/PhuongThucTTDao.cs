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
    public class PhuongThucTTDao
    {
          private static TAMCOFFEEContext _context;
        public List<Phuongthucthanhtoan> GetAllPTTT()
        {
            try
            {
                if (_context?.Phuongthucthanhtoans != null)
                {
                    return _context.Phuongthucthanhtoans.Include(t => t.Donhangs).ToList();
                }
                else
                {
                    // Xử lý trường hợp _context hoặc Phuongthucthanhtoans là null
                    return new List<Phuongthucthanhtoan>(); // Hoặc ném một exception khác
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách phương thức thanh toán.", ex);
            }
        }
    }
}
