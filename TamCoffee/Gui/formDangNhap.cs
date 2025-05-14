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

namespace TamCoffee.Gui
{
    public partial class formDangNhap : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
          int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
          int nWidthEllipse, int nHeightEllipse);

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

<<<<<<< HEAD
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
=======
        private void formDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void txtTenTaiKhoan_TextChanged(object sender, EventArgs e)
        {
>>>>>>> 1a2d677 ( Quan Li Nhan Vien + Hoa Don)
        }
    }
}
