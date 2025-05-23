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
        private HoaDonTam _hdtam=new HoaDonTam();
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
                float gia = float.Parse(row.Cells["GiaSp"].Value.ToString());
                int soluong = int.Parse(txtSoLuong.Text);
                int chiphikhac= string.IsNullOrWhiteSpace(txtChiPhiKhac.Text) ? 0 : Convert.ToInt32(txtChiPhiKhac.Text);
                float thanhTien = gia * soluong+chiphikhac;

                var chiTiet = new Chitiethoadon(maSp, 0, soluong);
                hdtamdao.ThemMonTam(chiTiet);
                dgvChiTietGIoHang.Rows.Add(maSp, tenSp, gia, soluong,chiphikhac, thanhTien);

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDonDao hddao= new HoaDonDao();
                int chiphikhac = 0;
                int.TryParse(txtChiPhiKhac.Text, out chiphikhac);
                var dschitiethd = _hdtam.DanhSachChiTiet;
                bool result=hddao.LuuHDTVaoDatabase(dschitiethd, chiphikhac);
                if (result)
                    MessageBox.Show("Lưu hóa đơn thành công!");
                else
                    MessageBox.Show("Lưu hóa đơn thất bại!");

            }
            catch (Exception ex) {
               
            }
        }
    }
}
