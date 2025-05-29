using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using TamCoffee.Models.Dto;
using TamCoffee.Bus;

namespace TamCoffee.Gui
{
    public partial class formQuenMatKhau : Form
    {
        private QuenMatkhauBus qmk;
        public formQuenMatKhau()
        {
            InitializeComponent();
        }

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {
            qmk = new QuenMatkhauBus();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String email = txEmail.Text;
            if (!KiemTra.IsEmail(email))
            {
                MessageBox.Show("Email không hợp lệ! Phải đúng định dạng email hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txEmail.Focus();
                return;
            }

            try
            {
                qmk.guiEmail(email);
                MessageBox.Show("Gửi thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
