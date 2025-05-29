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
        public bool ThemTT(Trangthaidonhang tt)
        {
            try
            {
                _context.Trangthaidonhangs.Add(tt);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm trạng thái đơn hàng.", ex);
            }
        }
        public bool XoaTrangThai(int maTT)
        {
            try
            {
                var trangThai = _context.Trangthaidonhangs.FirstOrDefault(l => l.MaTrangThaiDh == maTT);
                if (trangThai == null)
                    throw new KeyNotFoundException("Không tìm thấy trạng thái đơn hàng cần xoá.");

                _context.Trangthaidonhangs.Remove(trangThai);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xoá trạng thái đơn hàng.", ex);
            }
        }
        public bool CapNhatTT(Trangthaidonhang tt)
        {
            try
            {
                var ttcu = _context.Trangthaidonhangs.FirstOrDefault(l => l.MaTrangThaiDh==tt.MaTrangThaiDh);
                if (ttcu == null)
                    throw new KeyNotFoundException("Không tìm thấy trạng thái đơn hàng cần cập nhật.");

                ttcu.TenTrangThai = tt.TenTrangThai;
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật trạng thái đơn hàng.", ex);
            }
        }
    }
}
