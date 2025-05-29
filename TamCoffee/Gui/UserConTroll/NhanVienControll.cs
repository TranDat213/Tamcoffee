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
    public partial class NhanVienControll : UserControl
    {
        private static TAMCOFFEEContext _context;
        private int vt = 0;
        public NhanVienControll()
        {
            InitializeComponent();
        }

        private void NhanVienControll_Load(object sender, EventArgs e)
        {
            LoadDSTaiKhoan();
            LoadChucVu();
            LoadTImChucVu();
        }
        private void LoadDSTaiKhoan()
        {
            Dao.TaiKhoanDao dao = new Dao.TaiKhoanDao();
            List<Taikhoan> list = dao.LayTatCaTaiKhoan();
            var viewlist = list.Select(l => new
            {
                l.MaTk,
                l.HovaTen,
                l.TenTaiKhoan,
                l.MatKhau,
                l.GioiTinh,
                l.Email,
                l.MaChucVu
            }).ToList();
            dgvDSTaiKhoan.DataSource = viewlist;
            dgvDSTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSTaiKhoan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDSTaiKhoan.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvDSTaiKhoan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void LoadChucVu()
        {
            ChucVuDao chucVuDao = new ChucVuDao();
            List<Chucvu> list = chucVuDao.LayTatCaChucVu();

            cboChucVu.DataSource = list;
            cboChucVu.DisplayMember = "TenChucVu";
            cboChucVu.ValueMember = "MaChucVu";


        }
        private void LoadTImChucVu()
        {
            ChucVuDao chucVuDao = new ChucVuDao();
            List<Chucvu> list = chucVuDao.LayTatCaChucVu();

            cboTimChucVu.DataSource = list;
            cboTimChucVu.DisplayMember = "TenChucVu";
            cboTimChucVu.ValueMember = "MaChucVu";


        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // B1: Lấy dữ liệu từ giao diện
                string hoTen = txtTenNhanVien.Text.Trim();
                string tenTK = txtTenTK.Text.Trim();
                string matKhau = txtMatKhau.Text.Trim();
                bool gioiTinh = radNam.Checked;
                string email = txtEmail.Text.Trim();
                int maChucVu = Convert.ToInt32(cboChucVu.SelectedValue); // Giả sử cbChucVu là ComboBox chứa chức vụ

                // B2: Kiểm tra hợp lệ
                if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(tenTK) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // B3: Tạo đối tượng tài khoản
                Taikhoan tk = new Taikhoan
                {
                    HovaTen = hoTen,
                    TenTaiKhoan = tenTK,
                    MatKhau = matKhau,
                    GioiTinh = gioiTinh,
                    Email = email,
                    MaChucVu = maChucVu
                };

                TaiKhoanDao dao = new TaiKhoanDao();
                if (dao.ThemTaiKhoan(tk))
                {
                    MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSTaiKhoan();
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                int matk = Convert.ToInt32(txtMaNhanVien.Text);

                TaiKhoanDao dao = new TaiKhoanDao();
                if (dao.XoaTaiKhoan(matk))
                {
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSTaiKhoan();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDSTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                vt = e.RowIndex;
                DataGridViewRow r = new DataGridViewRow();
                r = dgvDSTaiKhoan.Rows[vt];
                int matk = Int32.Parse(r.Cells[0].Value.ToString());
                string tennv = r.Cells[1].Value.ToString();
                string tentk = r.Cells[2].Value.ToString();
                string matkhau = r.Cells[3].Value.ToString();
                bool gioiTinh = bool.Parse(r.Cells[4].Value.ToString()); // Cột giới tính
                string email = r.Cells[5].Value.ToString();
                int maChucVu = int.Parse(r.Cells[6].Value.ToString());

                // Đẩy lên giao diện
                txtMaNhanVien.Text = matk.ToString();
                txtTenNhanVien.Text = tennv;
                txtTenTK.Text = tentk;
                txtMatKhau.Text = matkhau;
                txtEmail.Text = email;

                // RadioButton cho giới tính
                radNam.Checked = gioiTinh;
                radNu.Checked = !gioiTinh;

                // ComboBox chức vụ
                cboChucVu.SelectedValue = maChucVu;

            }
            catch (Exception ex) { }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int maTK = Convert.ToInt32(txtMaNhanVien.Text);
                string hoTen = txtTenNhanVien.Text.Trim();
                string tenTK = txtTenTK.Text.Trim();
                string matKhau = txtMatKhau.Text.Trim();
                bool gioiTinh = radNam.Checked;
                string email = txtEmail.Text.Trim();
                int maChucVu = Convert.ToInt32(cboChucVu.SelectedValue);

                Taikhoan tk = new Taikhoan
                {
                    MaTk = maTK,
                    HovaTen = hoTen,
                    TenTaiKhoan = tenTK,
                    MatKhau = matKhau,
                    GioiTinh = gioiTinh,
                    Email = email,
                    MaChucVu = maChucVu
                };

                TaiKhoanDao dao = new TaiKhoanDao();
                if (dao.CapNhatTaiKhoan(tk))
                {
                    MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSTaiKhoan();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimChucvu_Click(object sender, EventArgs e)
        {
            try
            {
                int maChucVu = Convert.ToInt32(cboTimChucVu.SelectedValue);

                Dao.TaiKhoanDao dao = new Dao.TaiKhoanDao();
                List<Taikhoan> list = dao.LayTatCaTaiKhoan(); // hoặc viết hàm riêng trong DAO để lọc từ DB

                var filteredList = list
                    .Where(tk => tk.MaChucVu == maChucVu)
                    .Select(tk => new
                    {
                        tk.MaTk,
                        tk.HovaTen,
                        tk.TenTaiKhoan,
                        tk.MatKhau,
                        tk.GioiTinh,
                        tk.Email,
                        tk.MaChucVu
                    }).ToList();

                dgvDSTaiKhoan.DataSource = filteredList;

                if (filteredList.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy tài khoản nào với chức vụ đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadDSTaiKhoan();
        }
    }
}
