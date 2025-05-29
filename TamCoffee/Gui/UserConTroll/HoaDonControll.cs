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

namespace TamCoffee.Gui.UserConTroll
{
    public partial class HoaDonControll : UserControl
    {
        private HoaDonDao hddao;
        public HoaDonControll()
        {
            InitializeComponent();
        }

        private void HoaDonControll_Load(object sender, EventArgs e)
        {
            hddao = new HoaDonDao();
            LoadDSHoaDon();
            LoadTaiKhoan();
        }
        private void LoadDSHoaDon()
        {
            HoaDonDao dao = new HoaDonDao();
            var list = dao.GetAllHoaDon();
            var viewList = list.Select(l => new
            {
                l.MaDonHang,
                l.NgayLapHoaDon,
                l.MaTk,
                l.ChiPhiKhac,
                l.MaPttt,
                l.MaTrangThaiDh
            }).ToList();
            dgvDSHoaDon.DataSource = viewList;

            dgvDSHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSHoaDon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDSHoaDon.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvDSHoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public void LoadTaiKhoan()
        {
            TaiKhoanDao tkdao = new TaiKhoanDao();
            List<Taikhoan> dstk = tkdao.LayTatCaTaiKhoan();

            cboMaTK.DataSource= dstk;
            cboMaTK.DisplayMember = "MaTk";
            cboMaTK.ValueMember= "MaTk";
        }
        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDSHoaDon.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maHD = Convert.ToInt32(dgvDSHoaDon.CurrentRow.Cells["MaDonHang"].Value);

                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    HoaDonDao dao = new HoaDonDao();
                    bool isSuccess = dao.DeleteHoaDon(maHD);

                    if (isSuccess)
                    {
                        MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDSHoaDon();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadDSHoaDon();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                List<Donhang> dsHD = new List<Donhang>();

                if (radTimNgayLap.Checked)
                {
                    DateTime ngayLap = dtpNgayLap.Value.Date; // Giả sử bạn có DateTimePicker tên là dtpNgayLap
                    dsHD = hddao.TimDonHangTheoNgay(ngayLap);
                }
                else if (radTimMaTK.Checked) // Radio tìm theo mã tài khoản
                {
                    if (int.TryParse(cboMaTK.Text, out int maTK))
                    {
                        dsHD = hddao.TimDonHangTheoTK(maTK);
                    }
                    else
                    {
                        MessageBox.Show("Mã tài khoản không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Hiển thị dữ liệu lên DataGridView
                dgvDSHoaDon.DataSource = dsHD;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
