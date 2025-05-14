using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using TamCoffee.Models.Server;

namespace TamCoffee.Models
{
    public class SanphamDao
    {
        private static TAMCOFFEEContext _context;

        public SanphamDao()
        {
            _context = new TAMCOFFEEContext();
        }

        public bool AddSanpham(Sanpham sanpham)
        {
            try
            {
                _context.Sanphams.Add(sanpham);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm sản phẩm: {ex.Message}");
            }
        }

        public bool UpdateSanpham(Sanpham sanpham)
        {
            try
            {
                _context.Sanphams.Update(sanpham);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật sản phẩm: {ex.Message}");
            }
        }

        public bool DeleteSanpham(int maSanPham)
        {
            try
            {
                var sanpham = _context.Sanphams.FirstOrDefault(s => s.MaSanPham == maSanPham);
                if (sanpham != null)
                {
                    _context.Sanphams.Remove(sanpham);
                    return _context.SaveChanges() > 0;
                }
                else
                {
                    throw new Exception("Sản phẩm không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa sản phẩm: {ex.Message}");
            }
        }

        public List<Sanpham>? GetAllSanphams()
        {
            try
            {
                return _context.Sanphams.Include(s => s.MaLoaiSanPhamNavigation)
                                        .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy tất cả sản phẩm: {ex.Message}");
            }
        }

        public Sanpham GetSanphamById(int maSanPham)
        {
            try
            {
                var sanpham = _context.Sanphams.Include(s => s.MaLoaiSanPhamNavigation)
                                               .FirstOrDefault(s => s.MaSanPham == maSanPham);
                if (sanpham == null)
                {
                    throw new Exception("Sản phẩm không tồn tại.");
                }
                return sanpham;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy sản phẩm theo mã: {ex.Message}");
            }
        }

        public List<Sanpham> GetSanphamsByLoaiSanPham(int maLoaiSanPham)
        {
            try
            {
                return _context.Sanphams.Where(s => s.MaLoaiSanPham == maLoaiSanPham)
                                        .Include(s => s.MaLoaiSanPhamNavigation)
                                        .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy sản phẩm theo mã loại sản phẩm: {ex.Message}");
            }
        }


        //public List<Sanpham> GetSanphamsByLoaiSanPham(int maLoaiSanPham)
        //{
        //    try
        //    {
        //        var sanphams = new List<Sanpham>();

        //        using var conn = new MySqlConnection(_context.getConnection());
        //        conn.Open();

        //        using var cmd = new MySqlCommand("GetSanphamsByLoaiSanPham", conn)
        //        {
        //            CommandType = CommandType.StoredProcedure
        //        };
        //        cmd.Parameters.AddWithValue("@maLoaiSanPham", maLoaiSanPham);
        //        using var reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            var sanpham = new Sanpham
        //            {
        //                MaSanPham = reader.GetInt32("MaSanPham"),
        //                TenSanPham = reader.GetString("TenSanPham"),
        //                GiaSp = reader.GetDecimal("GiaSp"),
        //                MaLoaiSanPham = reader.IsDBNull(reader.GetOrdinal("MaLoaiSanPham")) ? (int?)null : reader.GetInt32("MaLoaiSanPham")
        //            };
        //            sanphams.Add(sanpham);
        //        }

        //        if (sanphams.Count == 0)
        //        {
        //            throw new Exception("Không có sản phẩm nào thuộc loại này.");
        //        }

        //        return sanphams;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Lỗi khi lấy sản phẩm theo mã loại sản phẩm: {ex.Message}");
        //    }
        //}

        public List<Sanpham> GetSanphamsByLoaiSanPham(Loaisanpham loaisanpham)
            {
                try
                {
                    return _context.Sanphams.Where(s => s.MaLoaiSanPham == loaisanpham.MaLoaiSanPham)
                                            .Include(s => s.MaLoaiSanPhamNavigation)
                                            .ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Lỗi khi lấy sản phẩm theo loại sản phẩm: {ex.Message}");
                }
            }
        }
}
