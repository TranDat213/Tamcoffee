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
    public partial class PTTTControll : UserControl
    {
        private static TAMCOFFEEContext _context;
        public PTTTControll()
        {
            InitializeComponent();
        }

        private void PTTTControll_Load(object sender, EventArgs e)
        {
            LoadDataPTTT();
        }
        private void LoadDataPTTT()
        {
            PhuongThucTTDao dao = new PhuongThucTTDao();
            List<Phuongthucthanhtoan> list = dao.GetAllPTTT();
            var viewlist = list.Select(l => new
            {
                l.MaPttt,
                l.TenPhuongThuc
            }).ToList();
            dgvPTTT.DataSource = viewlist;
        }
    }
}
