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
using TamCoffee.Models.Server;

namespace TamCoffee.Gui
{
    public partial class formHoaDon : Form
    {
        private int maDonhang;
        public formHoaDon(int maDonhang)
        {
            InitializeComponent();
            this.maDonhang = maDonhang;
        }
        public formHoaDon()
        {
            InitializeComponent();
        }

      

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formHoaDon_Load(object sender, EventArgs e)
        {
            using (var context = new TAMCOFFEEContext())
            {
                var donhang=context.Donhangs
                    .Include(d=>d.Chitiethoadons)
                    .FirstOrDefault(d=>d.MaDonHang==maDonhang);

                if (donhang != null) 
                {
                    txtMaHoaDon.Text=donhang.MaDonHang.ToString();
                    float tongTien=0;
                    foreach(var item in donhang.Chitiethoadons)
                    {
                        var sanPham = context.Sanphams.Find(item.MaSanPham);
                        dgvHoaDon.Rows.Add(item.MaSanPham);
                    }
                }
            }
        }
    }
}
