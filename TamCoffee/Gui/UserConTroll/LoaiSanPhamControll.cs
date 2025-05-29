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
    public partial class LoaiSanPhamControll : UserControl
    {
        private static TAMCOFFEEContext _context;
        private int vt = 0;
        public LoaiSanPhamControll()
        {
            InitializeComponent();
        }

        private void LoaiSanPhamControll_Load(object sender, EventArgs e)
        {
            LoadDSLoaiSP();
        }
        private void LoadDSLoaiSP()
        {
            LoaiSanPhamDao dao = new LoaiSanPhamDao();
            List<Loaisanpham> list = dao.LayTatCaLoai();
            var viewlist = list.Select(l => new
            {
                l.MaLoaiSanPham,
                l.TenLoaiSanPham
            }).ToList();
            dgvLoaiSanPham.DataSource = viewlist;

            dgvLoaiSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLoaiSanPham.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvLoaiSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenloai = txtTenLoaiSP.Text.Trim();
                if (string.IsNullOrEmpty(tenloai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin loại sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Loaisanpham loainew = new Loaisanpham
                {
                    TenLoaiSanPham = tenloai
                };
                LoaiSanPhamDao loaidao = new LoaiSanPhamDao();
                if (loaidao.ThemLoai(loainew))
                {
                    MessageBox.Show("Thêm loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSLoaiSP();
                }
                else
                {
                    MessageBox.Show("Thêm loại sản phẩm thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                int maloai = Convert.ToInt32(txtMaLoai.Text);

                LoaiSanPhamDao dao = new LoaiSanPhamDao();
                if (dao.XoaLoai(maloai))
                {
                    MessageBox.Show("Xóa loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSLoaiSP();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy loại sản phẩm để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vt = e.RowIndex;
                DataGridViewRow r = new DataGridViewRow();
                r = dgvLoaiSanPham.Rows[vt];
                int maloai = Int32.Parse(r.Cells[0].Value.ToString());
                string tenloai = r.Cells[1].Value.ToString();

                txtMaLoai.Text = maloai.ToString();
                txtTenLoaiSP.Text = tenloai;
            }
            catch (Exception ex)
            {
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int maloai = Int32.Parse(txtMaLoai.Text);
                string tenloai = txtTenLoaiSP.Text.Trim();
                Loaisanpham loai = new Loaisanpham
                {
                    MaLoaiSanPham = maloai,
                    TenLoaiSanPham = tenloai
                };
                LoaiSanPhamDao dao = new LoaiSanPhamDao();
                if (dao.CapNhatLoai(loai))
                {
                    MessageBox.Show("Cập nhật loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSLoaiSP();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật loại sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadDSLoaiSP();
        }
    }
}
