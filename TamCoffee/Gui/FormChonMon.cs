﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TamCoffee.Dao;
using TamCoffee.Models;
using TamCoffee.Models.Server;

namespace TamCoffee.Gui
{
    public partial class FormChonMon : Form
    {
        private readonly TAMCOFFEEContext _context;
        private int vtri = 0;
        SanphamDao spDao = new SanphamDao();
        Sanpham sp = new Sanpham();
        private HoaDonTamDao hdtamdao = new HoaDonTamDao();
        private HoaDonTam _hdtam = new HoaDonTam();
        public FormChonMon()
        {
            InitializeComponent();
            _context = new TAMCOFFEEContext();
        }

        private void FormChonMon_Load(object sender, EventArgs e)
        {
            LoadLoaiMon();
            LoadSanPham();

        }
        private void LoadSanPham()
        {
            try
            {
                // Lấy danh sách từ DB và gán vào DataGridView
                SanphamDao dao = new SanphamDao();
                var list = dao.GetAllSanphams();
                // Chuyển danh sách sản phẩm sang danh sách ẩn danh để hiển thị đẹp
                var viewlist = list
                                  .Select(s => new
                                  {
                                      s.MaSanPham,
                                      s.TenSanPham,
                                      s.GiaSp,
                                      Loai = s.MaLoaiSanPhamNavigation.TenLoaiSanPham
                                  })
                                  .ToList();

                dgvDSMon.DataSource = viewlist;
                dgvDSMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDSMon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvDSMon.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                dgvDSMon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private void LoadLoaiMon()
        {

            LoaiSanPhamDao loaiDao = new LoaiSanPhamDao();
            List<Loaisanpham> list = loaiDao.LayTatCaLoai();

            cboTimLoaiMon.DataSource = list;
            cboTimLoaiMon.DisplayMember = "TenLoaiSanPham";
            cboTimLoaiMon.ValueMember = "MaLoaiSanPham";


        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gui.FormMain formMain = new Gui.FormMain();
            formMain.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Mã đơn hàng là:" + _hdtam.DonHangTam.MaDonHang);
            Gui.formHoaDon hoaDon = new Gui.formHoaDon(_hdtam.DonHangTam.MaDonHang);
            hoaDon.ShowDialog();
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {

        }

        private void cboTimLoaiMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboTimLoaiMon.SelectedItem is Loaisanpham loai)
                {
                    int maLoai = loai.MaLoaiSanPham;
                    SanphamDao dao = new SanphamDao();
                    var list = dao.GetSanphamsByLoaiSanPham(maLoai);

                    var viewlist = list.Select(sp => new
                    {
                        sp.MaSanPham,
                        sp.TenSanPham,
                        sp.GiaSp,
                        Loai = sp.MaLoaiSanPhamNavigation?.TenLoaiSanPham ?? "(Không xác định)"
                    }).ToList();

                    dgvDSMon.DataSource = viewlist;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một loại món!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDSMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                vtri = e.RowIndex;
                DataGridViewRow r = new DataGridViewRow();
                r = dgvDSMon.Rows[vtri];
                int masp = Int32.Parse(r.Cells[0].Value.ToString());
                string tensp = r.Cells[1].Value.ToString();
                decimal gia = Decimal.Parse(r.Cells[2].Value.ToString());
                int maloai = Int32.Parse(r.Cells[3].Value.ToString());
                sp = spDao.GetSanphamById(masp);
            }
            catch (Exception ex) { }
        }

        private void btnChonSP_Click(object sender, EventArgs e)
        {
            if (dgvDSMon.CurrentRow != null && !string.IsNullOrEmpty(txtSoLuong.Text))
            {
                var row = dgvDSMon.CurrentRow;
                int maSp = Convert.ToInt32(row.Cells["MaSanPham"].Value);
                string tenSp = row.Cells["TenSanPham"].Value.ToString();
                decimal gia = decimal.Parse(row.Cells["GiaSp"].Value.ToString());
                int soluong = int.Parse(txtSoLuong.Text);

                decimal thanhTien = gia * soluong;

                var chiTiet = new Chitiethoadon(maSp, 0, soluong);
                hdtamdao.ThemMonTam(chiTiet);
                dgvChiTietGIoHang.Rows.Add(maSp, tenSp, gia, soluong, thanhTien);

                dgvChiTietGIoHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvChiTietGIoHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvChiTietGIoHang.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                dgvChiTietGIoHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
        }

        //private void btnLuu_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        HoaDonDao hddao = new HoaDonDao();

        //        var dschitiethd = _hdtam.DanhSachChiTiet;
        //        var donhangMoi = hddao.LuuHDTVaoDatabase(dschitiethd);

        //        if (donhangMoi != null)
        //        {
        //            _hdtam.DonHangTam = donhangMoi;
        //            MessageBox.Show("Lưu hóa đơn thành công!");

        //        }
        //        else
        //            MessageBox.Show("Lưu hóa đơn thất bại!");

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDonDao hddao = new HoaDonDao();

                var dschitiethd = hdtamdao.LayDSTam(); // Get the list from dao instead
                if (dschitiethd.Count == 0)
                {
                    MessageBox.Show("Giỏ hàng đang trống!");
                    return;
                }

                //Console.WriteLine($"Đang lưu hóa đơn với {dschitiethd.Count} chi tiết");
                foreach (var item in dschitiethd)
                {
                    Console.WriteLine($"Chi tiết: MaSP={item.MaSanPham}, SL={item.SoLuong}");
                }

                var donhangMoi = hddao.LuuHDTVaoDatabase(dschitiethd);

                if (donhangMoi != null)
                {
                    _hdtam.DonHangTam = donhangMoi;
                    MessageBox.Show("Lưu hóa đơn thành công! ");

                    // Xóa danh sách tạm sau khi đã lưu thành công
                    hdtamdao.XoaDSTam();

                    // Xóa dữ liệu hiển thị trong DataGridView
                    dgvChiTietGIoHang.Rows.Clear();

                    // Reset tổng tiền về 0


                    // Mở form hóa đơn ngay sau khi lưu thành công
                    var hoaDonForm = new formHoaDon(donhangMoi.MaDonHang);
                    hoaDonForm.ShowDialog();
                }
                else
                    MessageBox.Show("Lưu hóa đơn thất bại!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu hóa đơn: {ex.Message}");
                Console.WriteLine($"Exception: {ex.ToString()}");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
