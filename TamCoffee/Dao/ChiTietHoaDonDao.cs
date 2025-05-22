using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamCoffee.Models;
using TamCoffee.Models.Server;

namespace TamCoffee.Dao
{
    public class ChiTietHoaDonDao
    {
        private static TAMCOFFEEContext _context;
           public ChiTietHoaDonDao()
        {
            _context = new TAMCOFFEEContext();
        }
        public bool AddChiTietHoaDon(Chitiethoadon chitiet)
        {
            try
            {
                _context.Chitiethoadons.Add(chitiet);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm chi tiết hóa đơn: {ex.Message}");
            }

        }

    }
 
}
