using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TamCoffee.Models;
using TamCoffee.Models.Server;

namespace TamCoffee.Gui.UserConTroll
{
    public partial class NhanVienControll : UserControl
    {
        private static TAMCOFFEEContext _context;
        public NhanVienControll()
        {
            InitializeComponent();
        }

        private void NhanVienControll_Load(object sender, EventArgs e)
        {
            LoadDSTaiKhoan();
        }
        private void LoadDSTaiKhoan()
        {
            Dao.TaiKhoanDao dao=new Dao.TaiKhoanDao();
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
            dgvDSTaiKhoan.DataSource=viewlist;
        }
    }
}
