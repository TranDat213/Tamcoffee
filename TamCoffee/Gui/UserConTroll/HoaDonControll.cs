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

namespace TamCoffee.Gui.UserConTroll
{
    public partial class HoaDonControll : UserControl
    {
        public HoaDonControll()
        {
            InitializeComponent();
        }

        private void HoaDonControll_Load(object sender, EventArgs e)
        {
            LoadDSHoaDon();
        }
        private void LoadDSHoaDon()
        {
            HoaDonDao dao=new HoaDonDao();
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
                        
        }
    }
}
