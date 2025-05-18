using System.Reflection.Metadata.Ecma335;
using TamCoffee.Dao;
using TamCoffee.Models;

namespace TamCoffee.Bus
{
    public class loginnBus
    {
        private readonly TaiKhoanDao _taikhoan;
        public loginnBus()
        {
            _taikhoan = new TaiKhoanDao();
        }

        public bool dangNhap(string username, string pwd)
        {
            Taikhoan tk = _taikhoan.TimTaiKhoan(username);
            if (tk == null) return false;

            return tk.MatKhau.Equals(pwd);
        }

        public bool addTaikhoan(Taikhoan tk)
        {
            if(_taikhoan.TimTaiKhoan(tk.TenTaiKhoan) != null)
            {
                MessageBox.Show("Tài Khoản đã tồn tại!");
                return false;
            }
            return _taikhoan.ThemTaiKhoan(tk);
        }
    }
}