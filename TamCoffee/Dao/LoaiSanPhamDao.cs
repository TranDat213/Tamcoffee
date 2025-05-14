using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TamCoffee.Models;
using TamCoffee.Models.Server;

namespace TamCoffee.Dao
{
    public class LoaiSanPhamDao
    {
        private readonly TAMCOFFEEContext _context;

        public LoaiSanPhamDao()
        {
            _context = new TAMCOFFEEContext();
        }

        public List<Loaisanpham>? LayTatCaLoai()
        {
            try
            {
                //return _context.Loaisanphams.Include(l => l.Sanphams).ToList();
                return _context.Loaisanphams.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách loại sản phẩm.", ex);
            }
        }

        public Loaisanpham? TimTheoMa(int maLoai)
        {
            try
            {
                return _context.Loaisanphams.FirstOrDefault(l => l.MaLoaiSanPham == maLoai);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm loại sản phẩm theo mã.", ex);
            }
        }

        public bool ThemLoai(Loaisanpham loai)
        {
            try
            {
                _context.Loaisanphams.Add(loai);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm loại sản phẩm.", ex);
            }
        }

        public bool CapNhatLoai(Loaisanpham loai)
        {
            try
            {
                var loaiCu = _context.Loaisanphams.FirstOrDefault(l => l.MaLoaiSanPham == loai.MaLoaiSanPham);
                if (loaiCu == null)
                    throw new KeyNotFoundException("Không tìm thấy loại sản phẩm cần cập nhật.");

                loaiCu.TenLoaiSanPham = loai.TenLoaiSanPham;
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật loại sản phẩm.", ex);
            }
        }

        public bool XoaLoai(int maLoai)
        {
            try
            {
                var loai = _context.Loaisanphams.FirstOrDefault(l => l.MaLoaiSanPham == maLoai);
                if (loai == null)
                    throw new KeyNotFoundException("Không tìm thấy loại sản phẩm cần xoá.");

                _context.Loaisanphams.Remove(loai);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xoá loại sản phẩm.", ex);
            }
        }
    }
}
