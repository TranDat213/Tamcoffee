namespace TamCoffee.Gui
{
    partial class formPhuongThucTT
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
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label8 = new Label();
            label9 = new Label();
            linkTrangChu = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkThemsp = new LinkLabel();
            linkThongKe = new LinkLabel();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            txtTenPTTT = new TextBox();
            txtMAPTTT = new TextBox();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 64, 64);
            label1.Location = new Point(233, 18);
            label1.Name = "label1";
            label1.Size = new Size(325, 25);
            label1.TabIndex = 1;
            label1.Text = "Quản Lý Phương thức thanh toán";
            label1.Click += label1_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(3, 303);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(113, 15);
            linkLabel2.TabIndex = 45;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Trạng thái đơn hàng";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(22, 272);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(87, 15);
            linkLabel1.TabIndex = 44;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Phương thức tt";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 193);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 43;
            label8.Text = "Quản lý";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 108);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 42;
            label9.Text = "Chung";
            // 
            // linkTrangChu
            // 
            linkTrangChu.AutoSize = true;
            linkTrangChu.Location = new Point(24, 241);
            linkTrangChu.Name = "linkTrangChu";
            linkTrangChu.Size = new Size(59, 15);
            linkTrangChu.TabIndex = 41;
            linkTrangChu.TabStop = true;
            linkTrangChu.Text = "Trang chủ";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(24, 214);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(95, 15);
            linkLabel3.TabIndex = 40;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Quản lý hóa đơn";
            // 
            // linkThemsp
            // 
            linkThemsp.AutoSize = true;
            linkThemsp.Location = new Point(24, 161);
            linkThemsp.Name = "linkThemsp";
            linkThemsp.Size = new Size(92, 15);
            linkThemsp.TabIndex = 39;
            linkThemsp.TabStop = true;
            linkThemsp.Text = "Thêm sản phẩm";
            // 
            // linkThongKe
            // 
            linkThongKe.AutoSize = true;
            linkThongKe.Location = new Point(24, 135);
            linkThongKe.Name = "linkThongKe";
            linkThongKe.Size = new Size(56, 15);
            linkThongKe.TabIndex = 38;
            linkThongKe.TabStop = true;
            linkThongKe.Text = "Thống kê";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Logoquan;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(13, 38);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(153, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(653, 254);
            dataGridView1.TabIndex = 55;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã phương thức thanh toán";
            Column1.Name = "Column1";
            Column1.Width = 300;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên phương thức thanh toán";
            Column2.Name = "Column2";
            Column2.Width = 300;
            // 
            // txtTenPTTT
            // 
            txtTenPTTT.Location = new Point(386, 136);
            txtTenPTTT.Name = "txtTenPTTT";
            txtTenPTTT.Size = new Size(156, 23);
            txtTenPTTT.TabIndex = 54;
            // 
            // txtMAPTTT
            // 
            txtMAPTTT.Location = new Point(386, 91);
            txtMAPTTT.Name = "txtMAPTTT";
            txtMAPTTT.Size = new Size(156, 23);
            txtMAPTTT.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 139);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 52;
            label3.Text = "Tên phương thức";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 101);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 51;
            label2.Text = "Mã phương thức";
            // 
            // formPhuongThucTT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(txtTenPTTT);
            Controls.Add(txtMAPTTT);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(linkTrangChu);
            Controls.Add(linkLabel3);
            Controls.Add(linkThemsp);
            Controls.Add(linkThongKe);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "formPhuongThucTT";
            Text = "formPhuongThucTT";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Label label8;
        private Label label9;
        private LinkLabel linkTrangChu;
        private LinkLabel linkLabel3;
        private LinkLabel linkThemsp;
        private LinkLabel linkThongKe;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private TextBox txtTenPTTT;
        private TextBox txtMAPTTT;
        private Label label3;
        private Label label2;
    }
}