using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TamCoffee.Gui
{
    public partial class formQuaLySp : Form
    {
        public formQuaLySp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //formHome home=new formHome();
            //home.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.ShowDialog();
        }

        private void formThemSp_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gui.formQLHoaDon formHoaDon = new Gui.formQLHoaDon();
            formHoaDon.ShowDialog();
        }

        private void linkTrangChu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gui.FormMain formMain = new Gui.FormMain();
            formMain.ShowDialog();
        }

        private void linkThemsp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formQuaLySp formQuaLySp = new formQuaLySp();
            formQuaLySp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
