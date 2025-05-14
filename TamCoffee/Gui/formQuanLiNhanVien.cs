using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamCoffee.Gui
{
    public partial class formQuanLiNhanVien : Form
    {
        public formQuanLiNhanVien()
        {
            InitializeComponent();
        }

        private void formQuanLiNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gui.formQLHoaDon hoaDon = new Gui.formQLHoaDon();
            hoaDon.ShowDialog();
        }

        private void linkTrangChu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
        }

        private void linkThemsp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gui.formQuaLySp formQuaLySp = new Gui.formQuaLySp();
            formQuaLySp.ShowDialog();
        }

        private void linkThongKe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gui.formThongKe formThongKe = new Gui.formThongKe();
            formThongKe.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formPhuongThucTT formPhuongThucTT = new formPhuongThucTT();
            formPhuongThucTT.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formTrangThaiDon f=new Gui.formTrangThaiDon();
            f.ShowDialog();
        }
    }
}
