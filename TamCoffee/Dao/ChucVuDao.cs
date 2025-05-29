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
    public class ChucVuDao
    {

        private readonly TAMCOFFEEContext _context;

        public ChucVuDao()
        {
            _context = new TAMCOFFEEContext();
        }
        public List<Chucvu>? LayTatCaChucVu()
        {
            try
            {
                return _context.Chucvus.Include(c=>c.Taikhoans).ToList();
                
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách chức vụ.", ex);
            }
        }
        public bool ThemChucVu(Chucvu chucVu)
        {
            try
            {
                _context.Chucvus.Add(chucVu);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm chức vụ.", ex);
            }
        }

        public bool CapNhatChucVu(Chucvu chucVu)
        {
            try
            {
                var chucVuCu = _context.Chucvus.FirstOrDefault(c => c.MaChucVu == chucVu.MaChucVu);
                if (chucVuCu == null)
                    throw new KeyNotFoundException("Không tìm thấy chức vụ cần cập nhật.");

                chucVuCu.TenChucVu = chucVu.TenChucVu;
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật chức vụ.", ex);
            }
        }

        public bool XoaChucVu(int maChucVu)
        {
            try
            {
                var chucVu = _context.Chucvus.FirstOrDefault(c => c.MaChucVu == maChucVu);
                if (chucVu == null)
                    throw new KeyNotFoundException("Không tìm thấy chức vụ cần xoá.");

                _context.Chucvus.Remove(chucVu);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xoá chức vụ.", ex);
            }
        }

    }
}
