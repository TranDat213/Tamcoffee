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
            LoaiSanPhamDao dao= new LoaiSanPhamDao();
            List<Loaisanpham> list = dao.LayTatCaLoai();
            var viewlist = list.Select(l => new
            {
                l.MaLoaiSanPham,
                l.TenLoaiSanPham
            }).ToList();
            dgvLoaiSanPham.DataSource = viewlist;
        }
    }
}
