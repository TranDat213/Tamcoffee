using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TamCoffee.Models.Server;

namespace TamCoffee.Gui
{
    public partial class formHoaDon : Form
    {
        private int maDonhang;
        public formHoaDon(int maDonhang)
        {
            InitializeComponent();
            this.maDonhang = maDonhang;
        }




        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formHoaDon_Load(object sender, EventArgs e)
        {
            LoadThongTinDonHang(maDonhang);
        }
        private void LoadThongTinDonHang(int madh)
        {
            var _context = new TAMCOFFEEContext();
            var hoadon = _context.Donhangs
                .Include(h => h.MaTkNavigation)
                .Include(h => h.MaPtttNavigation)
                .Include(h => h.MaTrangThaiDhNavigation)
                .Include(h => h.Chitiethoadons)
                    .ThenInclude(ct => ct.MaSanPhamNavigation)
                .FirstOrDefault(h => h.MaDonHang == madh);
            if (hoadon == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            // Gán thông tin hóa đơn vào các Label/TextBox
            lbMaHD.Text = hoadon.MaDonHang.ToString();
            lbNgayLap.Text = hoadon.NgayLapHoaDon.ToString("dd/MM/yyyy HH:mm:ss");
            lbTaiKhoan.Text = hoadon.MaTkNavigation?.TenTaiKhoan ?? "Nguyễn Đạt";
            lbPhuongThuc.Text = hoadon.MaPtttNavigation?.TenPhuongThuc ?? "Tiền mặt";
            lbTrangThai.Text = hoadon.MaTrangThaiDhNavigation?.TenTrangThai ?? "Đã mua";
            

            // Xóa danh sách món cũ nếu có
            flpChiTiet.Controls.Clear();
            decimal tongTien = 0;
            // Duyệt danh sách món và thêm vào FlowLayoutPanel
            foreach (var ct in hoadon.Chitiethoadons)
            {
                string ten = ct.MaSanPhamNavigation?.TenSanPham ?? "Cà phê đen";
                int soluong = Int32.Parse(ct.SoLuong.ToString());
                decimal gia = ct.MaSanPhamNavigation?.GiaSp ?? 0;
                decimal thanhtien = soluong * gia;
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Font = new Font("Courier New", 10, FontStyle.Regular);
                lbl.Text = $"{ten,-20} {soluong,3} {gia,12:N0}  {thanhtien,12:N0} VNĐ";
                flpChiTiet.Controls.Add(lbl);

                tongTien += thanhtien;
            }

            lblTongTien.Text = $"{tongTien:N0}VNĐ";
        }

        private void flpChiTiet_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
