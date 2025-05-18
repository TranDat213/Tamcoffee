using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TamCoffee.Bus;
using TamCoffee.Models;
using TamCoffee.Models.Dto;

namespace TamCoffee.Gui
{
    public partial class DangKy : Form
    {
        private readonly loginnBus _login;
        public DangKy()
        {
            _login = new loginnBus();
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string pwd = txtPwd.Text;
            string xacnhanpwd = txtValiPwd.Text;
            string email = txtEmail.Text.Trim();

            
            if (!KiemTra.KiemTraChuoi(username))
            {
                MessageBox.Show("Tên đăng nhập không hợp lệ! Chỉ bao gồm chữ và số, không chứa dấu cách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }

            
            if (string.IsNullOrWhiteSpace(pwd) || pwd.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPwd.Focus();
                return;
            }

            
            if (pwd != xacnhanpwd)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValiPwd.Focus();
                return;
            }

            
            if (!KiemTra.IsEmail(email))
            {
                MessageBox.Show("Email không hợp lệ! Phải đúng định dạng email hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            Taikhoan tk = new Taikhoan {
                HovaTen = "",
                TenTaiKhoan = username,
                MatKhau = pwd,
                GioiTinh = true,
                Email = email,
                MaChucVu = null
            };
        
            var result = _login.addTaikhoan(tk);

            if (result)
            {
                MessageBox.Show("Đăng ký thành công!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

    }
}
