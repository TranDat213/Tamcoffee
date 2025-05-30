using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamCoffee.Dao;
using TamCoffee.Models;
using TamCoffee.Models.Dto;

namespace TamCoffee.Bus
{
    public class QuenMatkhauBus
    {
        TaiKhoanDao tkdao = new TaiKhoanDao();
        public void guiEmail(string email)
        {
            Taikhoan tk = tkdao.TimTaiKhoan_email(email);
            if(tk == null)
            {
                throw new Exception("Tài khoản không tồn tại");
            }
            else
            {
                MessageBox.Show("Hệ thống đang gửi thông tin đến email bạn đăng kí");
                MailService.SendEmail(email,"Thông Báo","Tài khoản: "+ tk.TenTaiKhoan+"\n Mật khẩu: " +tk.MatKhau);
            }
        }
    }
}
