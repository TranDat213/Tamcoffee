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
    public partial class FormChonMon : Form
    {
        public FormChonMon()
        {
            InitializeComponent();
        }

        private void FormChonMon_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gui.FormMain formMain = new Gui.FormMain();
            formMain.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gui.formQuaLySp quaLySp = new Gui.formQuaLySp();
            quaLySp.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ShowDialog();
        }
    }
}
