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

namespace TamCoffee.Gui.UserConTroll
{
    public partial class SanPhamControll : UserControl
    {
        private static TAMCOFFEEContext _context;
        private SanphamDao spdao;
        private int vt = 0;

        public SanPhamControll()
        {
            InitializeComponent();
        }

        private void SanPhamControll_Load(object sender, EventArgs e)
        {
            spdao = new SanphamDao();
            LoadDSSanPham();
            LoadLoaiSanPham();
        }
        private void LoadDSSanPham()
        {
            SanphamDao dao = new SanphamDao();
            var list = dao.GetAllSanphams();
            var viewlist = list
                                 .Select(s => new
                                 {
                                     s.MaSanPham,
                                     s.TenSanPham,
                                     s.GiaSp,
                                     s.MaLoaiSanPham
                                 })
                                 .ToList();
            dgvSanPham.DataSource = viewlist;

            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSanPham.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void LoadLoaiSanPham()
        {

            LoaiSanPhamDao loaiDao = new LoaiSanPhamDao();
            List<Loaisanpham> list = loaiDao.LayTatCaLoai();

            cboLoaiHang.DataSource = list;
            cboLoaiHang.DisplayMember = "TenLoaiSanPham";
            cboLoaiHang.ValueMember = "MaLoaiSanPham";


        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            try
            {
                // B1: Lấy thông tin từ giao diện
                string tenSP = txtTenSanPham.Text.Trim();
                string giaStr = txtGiaBan.Text.Trim();
                object selectedLoai = cboLoaiHang.SelectedItem;

                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(giaStr) || selectedLoai == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(giaStr, out decimal giaSP))
                {
                    MessageBox.Show("Giá sản phẩm không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Giả sử cbLoaiSanPham đang bind danh sách Loaisanpham và ValueMember = MaLoaiSanPham
                int maLoaiSP = Convert.ToInt32(cboLoaiHang.SelectedValue);

                // B2: Tạo đối tượng Sanpham
                Sanpham sp = new Sanpham
                {
                    TenSanPham = tenSP,
                    GiaSp = giaSP,
                    MaLoaiSanPham = maLoaiSP
                };

                // B3: Gọi DAO để thêm vào DB
                SanphamDao dao = new SanphamDao();
                bool isSuccess = dao.AddSanpham(sp);

                if (isSuccess)
                {
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSSanPham(); // Refresh lại danh sách
                }
                else
                {
                    MessageBox.Show("Không thể thêm sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSanPham.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maSP = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["MaSanPham"].Value);

                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    SanphamDao dao = new SanphamDao();
                    bool isSuccess = dao.DeleteSanpham(maSP);

                    if (isSuccess)
                    {
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDSSanPham();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSanPham.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // B1: Lấy thông tin từ giao diện
                int maSP = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["MaSanPham"].Value);
                string tenSP = txtTenSanPham.Text.Trim();
                string giaStr = txtGiaBan.Text.Trim();
                object selectedLoai = cboLoaiHang.SelectedItem;

                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(giaStr) || selectedLoai == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(giaStr, out decimal giaSP))
                {
                    MessageBox.Show("Giá sản phẩm không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int maLoaiSP = Convert.ToInt32(cboLoaiHang.SelectedValue);

                // B2: Tạo đối tượng sản phẩm để cập nhật
                Sanpham sp = new Sanpham
                {
                    MaSanPham = maSP,
                    TenSanPham = tenSP,
                    GiaSp = giaSP,
                    MaLoaiSanPham = maLoaiSP
                };

                // B3: Gọi DAO để cập nhật DB
                SanphamDao dao = new SanphamDao();
                bool isSuccess = dao.UpdateSanpham(sp);

                if (isSuccess)
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSSanPham(); // Refresh lại danh sách
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                vt = e.RowIndex;
                DataGridViewRow r = new DataGridViewRow();
                r = dgvSanPham.Rows[vt];
                int masp = Int32.Parse(r.Cells[0].Value.ToString());
                string tensp = r.Cells[1].Value.ToString();
                decimal gia = Decimal.Parse(r.Cells[2].Value.ToString());
                string tenloai = r.Cells[3].Displayed.ToString();
                Sanpham sp = spdao.GetSanphamById(masp);

                txtMaSanPham.Text = masp.ToString();
                txtTenSanPham.Text = tensp;
                txtGiaBan.Text = gia.ToString();

            }
            catch (Exception ex) { }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadDSSanPham();
        }
    }
}
