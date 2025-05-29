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
        //private void LoadThongTinDonHang(int madh)
        //{
        //    var _context = new TAMCOFFEEContext();
        //    var hoadon = _context.Donhangs
        //        .Include(h => h.MaTkNavigation)
        //        .Include(h => h.MaPtttNavigation)
        //        .Include(h => h.MaTrangThaiDhNavigation)
        //        .Include(h => h.Chitiethoadons)
        //            .ThenInclude(ct => ct.MaSanPhamNavigation)
        //        .FirstOrDefault(h => h.MaDonHang == madh);
        //    //MessageBox.Show(hoadon.Chitiethoadons.Count.ToString(), "Số lượng chi tiết hóa đơn");
        //    if (hoadon == null)
        //    {
        //        MessageBox.Show("Không tìm thấy hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    // Gán thông tin hóa đơn vào các Label/TextBox
        //    lbMaHD.Text = hoadon.MaDonHang.ToString();
        //    lbNgayLap.Text = hoadon.NgayLapHoaDon.ToString("dd/MM/yyyy HH:mm:ss");
        //    lbTaiKhoan.Text = hoadon.MaTkNavigation?.TenTaiKhoan ?? "Nguyễn Đạt";
        //    lbPhuongThuc.Text = hoadon.MaPtttNavigation?.TenPhuongThuc ?? "Tiền mặt";
        //    lbTrangThai.Text = hoadon.MaTrangThaiDhNavigation?.TenTrangThai ?? "Đã mua";


        //    // Xóa danh sách món cũ nếu có
        //    flpChiTiet.Controls.Clear();
        //    decimal tongTien = 0;

        //    Label header = new Label();
        //    header.AutoSize = true;
        //    header.Font = new Font("Courier New", 10, FontStyle.Bold);
        //    header.Text = "Tên sản phẩm      SL     Đơn giá     Thành tiền";
        //    header.Width = flpChiTiet.Width - 20;
        //    flpChiTiet.Controls.Add(header);

        //    if(hoadon.Chitiethoadons !=null&&hoadon.Chitiethoadons.Count>0)
        //    {
        //        // Duyệt danh sách món và thêm vào FlowLayoutPanel
        //        foreach (var ct in hoadon.Chitiethoadons)
        //        {
        //            try
        //            {
        //                var sanPham = ct.MaSanPhamNavigation;
        //                if (sanPham != null)
        //                {
        //                    sanPham = _context.Sanphams.FirstOrDefault(s => s.MaSanPham == ct.MaSanPham);
        //                }
        //                string ten = ct.MaSanPhamNavigation?.TenSanPham ?? "Cà phê đen";
        //                int soluong = Int32.Parse(ct.SoLuong.ToString());
        //                decimal gia = ct.MaSanPhamNavigation?.GiaSp ?? 0;
        //                decimal thanhtien = soluong * gia;

        //                Label lbl = new Label();
        //                lbl.AutoSize = true;
        //                lbl.Font = new Font("Courier New", 10, FontStyle.Regular);
        //                lbl.Text = String.Format("{0,-20} {1.3} {2,12:N0} {3,12:N0} VNĐ",
        //                    ten.PadRight(20).Substring(0, 20),
        //                    soluong,
        //                    gia,
        //                    thanhtien);
        //                flpChiTiet.Controls.Add(lbl);

        //                tongTien += thanhtien;
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show($"Lỗi khi hiển thị chi tiết: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Label noItems = new Label();
        //        noItems.AutoSize = true;
        //        noItems.Font = new Font("Courier New", 10, FontStyle.Italic);
        //        noItems.Text = "Không có chi tiết hóa đơn";
        //        flpChiTiet.Controls.Add(noItems);
        //    }

        //        lblTongTien.Text = $"{tongTien:N0}VNĐ";
        //}

        private void LoadThongTinDonHang(int madh)
        {
            try
            {
                Console.WriteLine($"Đang tải hóa đơn mã: {madh}");
                var _context = new TAMCOFFEEContext();

                // Truy vấn trực tiếp vào bảng chi tiết hóa đơn để kiểm tra
                var chiTietCount = _context.Chitiethoadons.Count(c => c.MaDonHang == madh);
                Console.WriteLine($"Số lượng chi tiết của hóa đơn {madh} trong bảng Chitiethoadon: {chiTietCount}");

                // Reset tracking để đảm bảo lấy dữ liệu mới từ database
                _context.ChangeTracker.Clear();

                // Tải hóa đơn với các thông tin liên quan
                var hoadon = _context.Donhangs
                    .AsNoTracking() // Không theo dõi để tránh conflict
                    .Include(h => h.MaTkNavigation)
                    .Include(h => h.MaPtttNavigation)
                    .Include(h => h.MaTrangThaiDhNavigation)
                    .Include(h => h.Chitiethoadons)
                        .ThenInclude(ct => ct.MaSanPhamNavigation)
                    .FirstOrDefault(h => h.MaDonHang == madh);

                if (hoadon == null)
                {
                    Console.WriteLine("Không tìm thấy hóa đơn trong database.");
                    MessageBox.Show("Không tìm thấy hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Log số lượng chi tiết hóa đơn để debug
                Console.WriteLine($"Hóa đơn {hoadon.MaDonHang} có {(hoadon.Chitiethoadons?.Count ?? 0)} chi tiết.");

                // Gán thông tin hóa đơn vào các Label/TextBox
                lbMaHD.Text = hoadon.MaDonHang.ToString();
                lbNgayLap.Text = hoadon.NgayLapHoaDon.ToString("dd/MM/yyyy HH:mm:ss");
                lbTaiKhoan.Text = hoadon.MaTkNavigation?.TenTaiKhoan ?? "Nguyễn Đạt";
                lbPhuongThuc.Text = hoadon.MaPtttNavigation?.TenPhuongThuc ?? "Tiền mặt";
                lbTrangThai.Text = hoadon.MaTrangThaiDhNavigation?.TenTrangThai ?? "Đã mua";

                // Xóa danh sách món cũ nếu có
                flpChiTiet.Controls.Clear();
                decimal tongTien = 0;

                // Thêm header cho các cột
                Label header = new Label();
                header.AutoSize = true;
                header.Font = new Font("Courier New", 10, FontStyle.Bold);
                header.Text = "Tên sản phẩm      SL     Đơn giá     Thành tiền";
                header.Width = flpChiTiet.Width - 20;
                flpChiTiet.Controls.Add(header);

                // Nếu không lấy được chi tiết hóa đơn từ Include, truy vấn trực tiếp
                var chiTietHoaDon = hoadon.Chitiethoadons;
                if ((chiTietHoaDon == null || !chiTietHoaDon.Any()) && chiTietCount > 0)
                {
                    Console.WriteLine("Lấy chi tiết hóa đơn từ truy vấn trực tiếp.");
                    chiTietHoaDon = _context.Chitiethoadons
                        .Include(ct => ct.MaSanPhamNavigation)
                        .Where(ct => ct.MaDonHang == madh)
                        .ToList();
                }

                // Kiểm tra danh sách chi tiết hóa đơn
                if (chiTietHoaDon != null && chiTietHoaDon.Any())
                {
                    foreach (var ct in chiTietHoaDon)
                    {
                        try
                        {
                            // Lấy thông tin sản phẩm
                            var sanPham = ct.MaSanPhamNavigation;
                            if (sanPham == null)
                            {
                                // Tải lại thông tin sản phẩm nếu chưa có
                                sanPham = _context.Sanphams.FirstOrDefault(s => s.MaSanPham == ct.MaSanPham);
                            }

                            string tenSP = sanPham?.TenSanPham ?? "Sản phẩm #" + ct.MaSanPham;
                            int soLuong = ct.SoLuong;
                            decimal giaSP = sanPham?.GiaSp ?? 0;
                            decimal thanhTien = soLuong * giaSP;

                            Console.WriteLine($"Hiển thị chi tiết: {tenSP}, SL={soLuong}, Giá={giaSP}, Thành tiền={thanhTien}");

                            // Tạo label hiển thị thông tin
                            Label lbl = new Label();
                            lbl.AutoSize = true;
                            lbl.Font = new Font("Courier New", 10, FontStyle.Regular);
                            // Improve formatting for better readability
                            string formattedName;
                            if (tenSP.Length > 20)
                            {
                                formattedName = tenSP.Substring(0, 17) + "...";
                            }
                            else
                            {
                                formattedName = tenSP.PadRight(20);
                            }

                            lbl.Text = String.Format("{0,-20} {1,3} {2,12:N0} {3,12:N0} VNĐ",
                                formattedName,
                                soLuong,
                                giaSP,
                                thanhTien);

                            // Add tooltip for long product names
                            if (tenSP.Length > 20)
                            {
                                ToolTip tip = new ToolTip();
                                tip.SetToolTip(lbl, tenSP);
                            }
                            lbl.Width = flpChiTiet.Width - 20;
                            flpChiTiet.Controls.Add(lbl);

                            tongTien += thanhTien;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Lỗi khi hiển thị chi tiết: {ex.Message} - {ex.StackTrace}");
                            MessageBox.Show($"Lỗi khi hiển thị chi tiết: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Không có chi tiết hóa đơn để hiển thị.");
                    Label noItems = new Label();
                    noItems.AutoSize = true;
                    noItems.Font = new Font("Courier New", 10, FontStyle.Italic);
                    noItems.Text = "Không có chi tiết hóa đơn";
                    flpChiTiet.Controls.Add(noItems);
                }

                // Thêm dòng tổng tiền với định dạng rõ ràng hơn
                lblTongTien.Text = $"{tongTien:N0} VNĐ";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi trong LoadThongTinDonHang: {ex.Message} - {ex.StackTrace}");
                MessageBox.Show($"Lỗi khi tải thông tin hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void flpChiTiet_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
