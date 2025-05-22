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
    public partial class SanPhamControll : UserControl
    {
        private static TAMCOFFEEContext _context;
        public SanPhamControll()
        {
            InitializeComponent();
        }

        private void SanPhamControll_Load(object sender, EventArgs e)
        {
            LoadDSSanPham();
        }
        private void LoadDSSanPham()
        {
            SanphamDao dao=new SanphamDao();
            var list =dao.GetAllSanphams();
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
        }
    }
}
