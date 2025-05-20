using TamCoffee.Gui.UserConTroll;

namespace TamCoffee.Gui
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private PictureBox pictureBox18;
        private LinkLabel linkLabel1;
        private Panel panelContainer;
        private Button btnQLNV;
        private Button btnQLHD;
        private Button btnQLSP;
        private Button btnThongKE;
        private Button btnQLPTTT;
        private Button btnQLTT;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private LinkLabel linkLabel3;

        private void InitializeComponent()
        {
            linkLabel3 = new LinkLabel();
            pictureBox18 = new PictureBox();
            linkLabel1 = new LinkLabel();
            panelContainer = new Panel();
            pictureBox1 = new PictureBox();
            btnQLNV = new Button();
            btnQLHD = new Button();
            btnQLSP = new Button();
            btnThongKE = new Button();
            btnQLPTTT = new Button();
            btnQLTT = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.ForeColor = SystemColors.ActiveBorder;
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(108, 9);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(38, 15);
            linkLabel3.TabIndex = 17;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Menu";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // pictureBox18
            // 
            pictureBox18.Location = new Point(0, 749);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(1242, 156);
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox18.TabIndex = 27;
            pictureBox18.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(189, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(61, 15);
            linkLabel1.TabIndex = 28;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đăng xuất";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(pictureBox1);
            panelContainer.Location = new Point(189, 61);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1027, 532);
            panelContainer.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Logoquan;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1027, 532);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnQLNV
            // 
            btnQLNV.Location = new Point(12, 72);
            btnQLNV.Name = "btnQLNV";
            btnQLNV.Size = new Size(122, 37);
            btnQLNV.TabIndex = 0;
            btnQLNV.Text = "Quản lý Nhân viên";
            btnQLNV.UseVisualStyleBackColor = true;
            btnQLNV.Click += button1_Click_1;
            // 
            // btnQLHD
            // 
            btnQLHD.Location = new Point(12, 158);
            btnQLHD.Name = "btnQLHD";
            btnQLHD.Size = new Size(122, 37);
            btnQLHD.TabIndex = 30;
            btnQLHD.Text = "Quản lý Hóa đơn";
            btnQLHD.UseVisualStyleBackColor = true;
            btnQLHD.Click += btnQLHD_Click;
            // 
            // btnQLSP
            // 
            btnQLSP.Location = new Point(12, 115);
            btnQLSP.Name = "btnQLSP";
            btnQLSP.Size = new Size(122, 37);
            btnQLSP.TabIndex = 31;
            btnQLSP.Text = "Quản lý Sản phẩm\r\n";
            btnQLSP.UseVisualStyleBackColor = true;
            btnQLSP.Click += btnQLSP_Click;
            // 
            // btnThongKE
            // 
            btnThongKE.Location = new Point(12, 201);
            btnThongKE.Name = "btnThongKE";
            btnThongKE.Size = new Size(122, 37);
            btnThongKE.TabIndex = 32;
            btnThongKE.Text = "Thống kê";
            btnThongKE.UseVisualStyleBackColor = true;
            btnThongKE.Click += btnThongKE_Click;
            // 
            // btnQLPTTT
            // 
            btnQLPTTT.Location = new Point(12, 244);
            btnQLPTTT.Name = "btnQLPTTT";
            btnQLPTTT.Size = new Size(122, 37);
            btnQLPTTT.TabIndex = 33;
            btnQLPTTT.Text = "Quản lý PTTT";
            btnQLPTTT.UseVisualStyleBackColor = true;
            btnQLPTTT.Click += btnQLPTTT_Click;
            // 
            // btnQLTT
            // 
            btnQLTT.Location = new Point(12, 287);
            btnQLTT.Name = "btnQLTT";
            btnQLTT.Size = new Size(122, 37);
            btnQLTT.TabIndex = 1;
            btnQLTT.Text = "Quản lýTrạng thái ĐH";
            btnQLTT.UseVisualStyleBackColor = true;
            btnQLTT.Click += btnQLTT_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = Properties.Resources.Logoquan;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(8, 6);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 68;
            pictureBox2.TabStop = false;
            // 
            // FormMain
            // 
            ClientSize = new Size(1260, 605);
            Controls.Add(pictureBox2);
            Controls.Add(btnQLTT);
            Controls.Add(btnQLPTTT);
            Controls.Add(btnThongKE);
            Controls.Add(btnQLSP);
            Controls.Add(btnQLHD);
            Controls.Add(btnQLNV);
            Controls.Add(panelContainer);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox18);
            Controls.Add(linkLabel3);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterParent;
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gui.FormMain formMain = new Gui.FormMain();
            formMain.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { }
          

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gui.FormChonMon fChonMon = new Gui.FormChonMon();
            fChonMon.ShowDialog();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Gui.formDangNhap f = new formDangNhap();
            f.ShowDialog();
        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            addUserControl(new NhanVienControll());
        }


        private void btnQLSP_Click(object sender, EventArgs e)
        {
            addUserControl(new SanPhamControll());
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            addUserControl(new HoaDonControll());
        }

        private void btnThongKE_Click(object sender, EventArgs e)
        {
            addUserControl(new ThongKeControll());
        }

        private void btnQLTT_Click(object sender, EventArgs e)
        {
            addUserControl(new TrangThaiControll());
        }

        private void btnQLPTTT_Click(object sender, EventArgs e)
        {
            addUserControl(new PTTTControll());
        }
    }
}
