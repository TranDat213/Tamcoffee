using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TamCoffee.Gui
{
    public partial class formThongKe : Form
    {
        public formThongKe()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void formThongKe_Load(object sender, EventArgs e)
        {

            Chart chart = new Chart();

            chart.Dock = DockStyle.Bottom;

            ChartArea area = new ChartArea("MainArea");
            chart.ChartAreas.Add(area);

            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column;
            series.Points.AddXY("01/05", 1500000);
            series.Points.AddXY("02/05", 1800000);

            chart.Series.Add(series);

            this.Controls.Add(chart);
            chart.Size = new Size(400, 300);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

