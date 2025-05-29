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

    public partial class TrangThaiControll : UserControl
    {
        private static TAMCOFFEEContext _context;
        private int vt = 0;
        public TrangThaiControll()
        {
            InitializeComponent();
        }

        private void TrangThaiControll_Load(object sender, EventArgs e)
        {
            LoadTTDH();
        }
        private void LoadTTDH()
        {
            TrangThaiDonHangDao dao = new TrangThaiDonHangDao();
            List<Trangthaidonhang> list = dao.GetAllTrangThaiDH();
            var viewlist = list.Select(s => new
            {
                s.MaTrangThaiDh,
                s.TenTrangThai
            }).ToList();
            dgvTrangThaiDH.DataSource = viewlist;

            dgvTrangThaiDH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrangThaiDH.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTrangThaiDH.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvTrangThaiDH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenTt = txtTenTTDH.Text.Trim();
                if (string.IsNullOrEmpty(tenTt))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin trạng thái đơn hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Trangthaidonhang ttnew = new Trangthaidonhang
                {
                    TenTrangThai = tenTt
                };
                TrangThaiDonHangDao dao = new TrangThaiDonHangDao();
                if (dao.ThemTT(ttnew))
                {
                    MessageBox.Show("Thêm trạng thái đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTTDH();
                }
                else
                {
                    MessageBox.Show("Thêm trạng thái đơn hàng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                int maTT = Convert.ToInt32(txtMaTTDh.Text);

                TrangThaiDonHangDao dao = new TrangThaiDonHangDao();
                if (dao.XoaTrangThai(maTT))
                {
                    MessageBox.Show("Xóa trạng thái đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTTDH();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy trạng thái đơn hàng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTrangThaiDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vt = e.RowIndex;
                DataGridViewRow r = new DataGridViewRow();
                r = dgvTrangThaiDH.Rows[vt];
                int maTT = Int32.Parse(r.Cells[0].Value.ToString());
                string tenTT = r.Cells[1].Value.ToString();

                txtMaTTDh.Text = maTT.ToString();
                txtTenTTDH.Text = tenTT;
            }
            catch (Exception ex)
            {
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int maTT = Int32.Parse(txtMaTTDh.Text);
                string tenTT = txtTenTTDH.Text.Trim();
                Trangthaidonhang tt = new Trangthaidonhang
                {
                    MaTrangThaiDh = maTT,
                    TenTrangThai = tenTT
                };
                TrangThaiDonHangDao dao = new TrangThaiDonHangDao();
                if (dao.CapNhatTT(tt))
                {
                    MessageBox.Show("Cập nhật trạng thái đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTTDH();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật trạng thái đơn hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadTTDH();
        }
    }

}
