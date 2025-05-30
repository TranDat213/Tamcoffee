using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TamCoffee.Bus;

namespace TamCoffee.Gui
{
    public partial class formDangNhap : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
          int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
          int nWidthEllipse, int nHeightEllipse);
        private loginnBus login = new loginnBus();
        bool isPasswordShown = false;
        public formDangNhap()
        {
            InitializeComponent();
        }

        private void llblQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formQuenMatKhau quenmatkhau = new formQuenMatKhau();
            quenmatkhau.ShowDialog();
        }
        private void llblDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }
        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String tentk = txtTenTaiKhoan.Text;
            String matkhau = txtMatKhau.Text;

            if (tentk.Trim().IsNullOrEmpty())
            {
                MessageBox.Show("Tên tài khoản Trống");
                return;
            }
            if (matkhau.Trim().IsNullOrEmpty())
            {
                MessageBox.Show("Mật khẩu Trống");
                return;
            }
            if (login.dangNhap(tentk, matkhau))
            {
                MessageBox.Show("Đăng nhập thành công");
                Gui.FormMain frmMain = new Gui.FormMain();
                frmMain.ShowDialog();

            }
            else
            {
                MessageBox.Show("Đăng nhập Thất Bại");
            }

        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;

        }

        private void checkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar=!checkHienMK.Checked;
        }
    }
}
