namespace TamCoffee.Gui
{
    partial class formQuaLySp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtGiaBan = new TextBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label6 = new Label();
            button2 = new Button();
            button3 = new Button();
            linkThemsp = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkTrangChu = new LinkLabel();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtMaSanPham = new TextBox();
            txtTenSanPham = new TextBox();
            txtMoTa = new TextBox();
            linkThongKe = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(243, 88);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(243, 125);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Giá bán";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 77);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(243, 159);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 3;
            label4.Text = "Mô tả sản phẩm";
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(364, 117);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(247, 23);
            txtGiaBan.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(418, 77);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 247);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(746, 203);
            dataGridView1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Logoquan;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(11, 4);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(640, 44);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(128, 64, 64);
            label6.Location = new Point(301, 9);
            label6.Name = "label6";
            label6.Size = new Size(170, 25);
            label6.TabIndex = 16;
            label6.Text = "Quản lý sản phẩm";
            // 
            // button2
            // 
            button2.Location = new Point(640, 81);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 17;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(640, 119);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 18;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            // 
            // linkThemsp
            // 
            linkThemsp.AutoSize = true;
            linkThemsp.Location = new Point(12, 117);
            linkThemsp.Name = "linkThemsp";
            linkThemsp.Size = new Size(92, 15);
            linkThemsp.TabIndex = 20;
            linkThemsp.TabStop = true;
            linkThemsp.Text = "Thêm sản phẩm";
            linkThemsp.LinkClicked += linkThemsp_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(0, 164);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(95, 15);
            linkLabel3.TabIndex = 21;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Quản lý hóa đơn";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkTrangChu
            // 
            linkTrangChu.AutoSize = true;
            linkTrangChu.Location = new Point(0, 189);
            linkTrangChu.Name = "linkTrangChu";
            linkTrangChu.Size = new Size(59, 15);
            linkTrangChu.TabIndex = 22;
            linkTrangChu.TabStop = true;
            linkTrangChu.Text = "Trang chủ";
            linkTrangChu.LinkClicked += linkTrangChu_LinkClicked;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 74);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 23;
            label7.Text = "Chung";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 144);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 24;
            label8.Text = "Quản lý";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(243, 48);
            label9.Name = "label9";
            label9.Size = new Size(79, 15);
            label9.TabIndex = 25;
            label9.Text = "Mã sản phẩm";
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Location = new Point(364, 44);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.Size = new Size(247, 23);
            txtMaSanPham.TabIndex = 26;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(362, 79);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(251, 23);
            txtTenSanPham.TabIndex = 27;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(364, 156);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(251, 23);
            txtMoTa.TabIndex = 28;
            // 
            // linkThongKe
            // 
            linkThongKe.AutoSize = true;
            linkThongKe.Location = new Point(19, 89);
            linkThongKe.Name = "linkThongKe";
            linkThongKe.Size = new Size(56, 15);
            linkThongKe.TabIndex = 29;
            linkThongKe.TabStop = true;
            linkThongKe.Text = "Thống kê";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(99, 195);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(113, 15);
            linkLabel2.TabIndex = 47;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Trạng thái đơn hàng";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(118, 164);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(87, 15);
            linkLabel1.TabIndex = 46;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Phương thức tt";
            // 
            // formQuaLySp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(746, 450);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(linkThongKe);
            Controls.Add(txtMoTa);
            Controls.Add(txtTenSanPham);
            Controls.Add(txtMaSanPham);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(linkTrangChu);
            Controls.Add(linkLabel3);
            Controls.Add(linkThemsp);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(txtGiaBan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formQuaLySp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formQuanLySp";
            Load += formThemSp_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txtGiaBan;
        private Label label5;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label6;
        private Button button2;
        private Button button3;
        private LinkLabel linkThemsp;
        private LinkLabel linkLabel3;
        private LinkLabel linkTrangChu;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtMaSanPham;
        private TextBox txtTenSanPham;
        private TextBox txtMoTa;
        private LinkLabel linkThongKe;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
    }
}