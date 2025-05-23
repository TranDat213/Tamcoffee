namespace TamCoffee.Gui
{
    partial class FormChonMon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            btnXemHD = new Button();
            dgvDSMon = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dgvChiTietGIoHang = new DataGridView();
            label4 = new Label();
            txtSoLuong = new TextBox();
            btnChonSP = new Button();
            btnXoaSP = new Button();
            btnThoat = new Button();
            btnLuu = new Button();
            cboTimLoaiMon = new ComboBox();
            label3 = new Label();
            txtChiPhiKhac = new TextBox();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDSMon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietGIoHang).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.FromArgb(255, 192, 128);
            linkLabel1.ForeColor = Color.Brown;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(304, 15);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(61, 15);
            linkLabel1.TabIndex = 31;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Trang Chủ";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Logoquan;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(178, 0);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1167, 24);
            menuStrip1.TabIndex = 38;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnXemHD
            // 
            btnXemHD.Location = new Point(967, 541);
            btnXemHD.Name = "btnXemHD";
            btnXemHD.Size = new Size(139, 42);
            btnXemHD.TabIndex = 49;
            btnXemHD.Text = "Xem hóa đơn";
            btnXemHD.UseVisualStyleBackColor = true;
            btnXemHD.Click += button15_Click;
            // 
            // dgvDSMon
            // 
            dgvDSMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSMon.Location = new Point(44, 110);
            dgvDSMon.Name = "dgvDSMon";
            dgvDSMon.RowTemplate.Height = 25;
            dgvDSMon.Size = new Size(848, 193);
            dgvDSMon.TabIndex = 50;
            dgvDSMon.CellClick += dgvDSMon_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(69, 73);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 51;
            label1.Text = "Danh sách món";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(782, 73);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 52;
            label2.Text = "Lọc loại món";
            // 
            // dgvChiTietGIoHang
            // 
            dgvChiTietGIoHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietGIoHang.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7, Column8, Column1, Column9 });
            dgvChiTietGIoHang.Location = new Point(44, 414);
            dgvChiTietGIoHang.Name = "dgvChiTietGIoHang";
            dgvChiTietGIoHang.RowTemplate.Height = 25;
            dgvChiTietGIoHang.Size = new Size(848, 150);
            dgvChiTietGIoHang.TabIndex = 54;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 354);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 56;
            label4.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(104, 351);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(100, 23);
            txtSoLuong.TabIndex = 57;
            // 
            // btnChonSP
            // 
            btnChonSP.Location = new Point(703, 351);
            btnChonSP.Name = "btnChonSP";
            btnChonSP.Size = new Size(78, 23);
            btnChonSP.TabIndex = 58;
            btnChonSP.Text = "Chọn";
            btnChonSP.UseVisualStyleBackColor = true;
            btnChonSP.Click += btnChonSP_Click;
            // 
            // btnXoaSP
            // 
            btnXoaSP.Location = new Point(706, 571);
            btnXoaSP.Name = "btnXoaSP";
            btnXoaSP.Size = new Size(75, 23);
            btnXoaSP.TabIndex = 59;
            btnXoaSP.Text = "Xóa";
            btnXoaSP.UseVisualStyleBackColor = true;
            btnXoaSP.Click += btnXoaSP_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(0, 571);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(58, 28);
            btnThoat.TabIndex = 60;
            btnThoat.Text = "Close";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(635, 571);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(65, 23);
            btnLuu.TabIndex = 61;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // cboTimLoaiMon
            // 
            cboTimLoaiMon.FormattingEnabled = true;
            cboTimLoaiMon.Location = new Point(887, 70);
            cboTimLoaiMon.Name = "cboTimLoaiMon";
            cboTimLoaiMon.Size = new Size(121, 23);
            cboTimLoaiMon.TabIndex = 62;
            cboTimLoaiMon.SelectedIndexChanged += cboTimLoaiMon_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 354);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 63;
            label3.Text = "Chi phí khác";
            // 
            // txtChiPhiKhac
            // 
            txtChiPhiKhac.Location = new Point(342, 351);
            txtChiPhiKhac.Name = "txtChiPhiKhac";
            txtChiPhiKhac.Size = new Size(100, 23);
            txtChiPhiKhac.TabIndex = 64;
            // 
            // Column5
            // 
            Column5.HeaderText = "Mã sản phẩm";
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // Column6
            // 
            Column6.HeaderText = "Tên sản phẩm";
            Column6.Name = "Column6";
            Column6.Width = 200;
            // 
            // Column7
            // 
            Column7.HeaderText = "Giá";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Số lượng";
            Column8.Name = "Column8";
            // 
            // Column1
            // 
            Column1.HeaderText = "Chi phí khác";
            Column1.Name = "Column1";
            // 
            // Column9
            // 
            Column9.HeaderText = "Thành tiền";
            Column9.Name = "Column9";
            Column9.Width = 200;
            // 
            // FormChonMon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 606);
            Controls.Add(txtChiPhiKhac);
            Controls.Add(label3);
            Controls.Add(cboTimLoaiMon);
            Controls.Add(btnLuu);
            Controls.Add(btnThoat);
            Controls.Add(btnXoaSP);
            Controls.Add(btnChonSP);
            Controls.Add(txtSoLuong);
            Controls.Add(label4);
            Controls.Add(dgvChiTietGIoHang);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDSMon);
            Controls.Add(btnXemHD);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormChonMon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += FormChonMon_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDSMon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietGIoHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private Button btnXemHD;
        private DataGridView dgvDSMon;
        private Label label1;
        private Label label2;
        private DataGridView dgvChiTietGIoHang;
        private Label label4;
        private TextBox txtSoLuong;
        private Button btnChonSP;
        private Button btnXoaSP;
        private Button btnThoat;
        private Button btnLuu;
        private ComboBox cboTimLoaiMon;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column9;
        private Label label3;
        private TextBox txtChiPhiKhac;
    }
}