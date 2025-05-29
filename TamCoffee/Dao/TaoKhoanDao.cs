using System;
using System.Collections.Generic;
using System.Linq;
using TamCoffee.Models;
using TamCoffee.Models.Server;

namespace TamCoffee.Dao
{
    public class TaiKhoanDao
    {
        private readonly TAMCOFFEEContext _context;

        public TaiKhoanDao()
        {
            _context = new TAMCOFFEEContext();
        }

        public List<Taikhoan> LayTatCaTaiKhoan()
        {
            try
            {
                return _context.Taikhoans.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách tài khoản.", ex);
            }
        }

        public Taikhoan? TimTaiKhoan(int maTk)
        {
            try
            {
                return _context.Taikhoans.FirstOrDefault(tk => tk.MaTk == maTk);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm tài khoản", ex);
            }
        }
        public Taikhoan? TimTaiKhoan_email(String email)
        {
            try
            {
                return _context.Taikhoans.FirstOrDefault(tk => tk.Email == email);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm tài khoản", ex);
            }
        }
        public Taikhoan? TimTaiKhoan(string tentaikhoan)
        {
            try
            {
                return _context.Taikhoans.FirstOrDefault(tk => tk.TenTaiKhoan == tentaikhoan);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm tài khoản", ex);
            }
        }

        public bool ThemTaiKhoan(Taikhoan tk)
        {
            try
            {
                _context.Taikhoans.Add(tk);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm tài khoản.");
            }
        }

        public bool CapNhatTaiKhoan(Taikhoan tk)
        {
            try
            {
                var tkCu = _context.Taikhoans.FirstOrDefault(t => t.MaTk == tk.MaTk);
                if (tkCu == null)
                    throw new KeyNotFoundException("Không tìm thấy tài khoản cần cập nhật.");

                tkCu.HovaTen = tk.HovaTen;
                tkCu.TenTaiKhoan = tk.TenTaiKhoan;
                tkCu.MatKhau = tk.MatKhau;
                tkCu.GioiTinh = tk.GioiTinh;
                tkCu.Email = tk.Email;
                tkCu.MaChucVu = tk.MaChucVu;

                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật tài khoản.", ex);
            }
        }

        public bool XoaTaiKhoan(int maTk)
        {
            try
            {
                var tk = _context.Taikhoans.FirstOrDefault(t => t.MaTk == maTk);
                if (tk == null)
                    throw new KeyNotFoundException("Không tìm thấy tài khoản cần xoá.");

                _context.Taikhoans.Remove(tk);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xoá tài khoản.", ex);
            }
        }
    }
}
