namespace TamCoffee.Gui
{
    partial class formQLHoaDon
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
            label8 = new Label();
            label7 = new Label();
            linkTrangChu = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkThemsp = new LinkLabel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            txtMaHoaDon = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            linkThongKe = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 168);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 31;
            label8.Text = "Quản lý";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 83);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 30;
            label7.Text = "Chung";
            // 
            // linkTrangChu
            // 
            linkTrangChu.AutoSize = true;
            linkTrangChu.Location = new Point(15, 216);
            linkTrangChu.Name = "linkTrangChu";
            linkTrangChu.Size = new Size(59, 15);
            linkTrangChu.TabIndex = 29;
            linkTrangChu.TabStop = true;
            linkTrangChu.Text = "Trang chủ";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(15, 189);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(95, 15);
            linkLabel3.TabIndex = 28;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Quản lý hóa đơn";
            // 
            // linkThemsp
            // 
            linkThemsp.AutoSize = true;
            linkThemsp.Location = new Point(15, 136);
            linkThemsp.Name = "linkThemsp";
            linkThemsp.Size = new Size(92, 15);
            linkThemsp.TabIndex = 27;
            linkThemsp.TabStop = true;
            linkThemsp.Text = "Thêm sản phẩm";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Logoquan;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(4, 13);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(128, 64, 64);
            label6.Location = new Point(316, 13);
            label6.Name = "label6";
            label6.Size = new Size(157, 25);
            label6.TabIndex = 32;
            label6.Text = "Quản lý hóa đơn";
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(140, 34);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(133, 23);
            txtMaHoaDon.TabIndex = 34;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 234);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 216);
            dataGridView1.TabIndex = 35;
            // 
            // Column1
            // 
            Column1.HeaderText = "MaNhanVien";
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Mã Hóa Đơn";
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Thời gian";
            Column3.Name = "Column3";
            Column3.Width = 250;
            // 
            // Column4
            // 
            Column4.HeaderText = "Tổng tiền";
            Column4.Name = "Column4";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 23);
            textBox1.TabIndex = 37;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(txtMaHoaDon);
            groupBox1.Location = new Point(424, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 142);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm Hóa Đơn";
            // 
            // button1
            // 
            button1.Location = new Point(23, 102);
            button1.Name = "button1";
            button1.Size = new Size(91, 35);
            button1.TabIndex = 38;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(18, 74);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(120, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Tìm mã nhân viên";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(18, 38);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(115, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tìm mã Hóa Đơn";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // linkThongKe
            // 
            linkThongKe.AutoSize = true;
            linkThongKe.Location = new Point(15, 114);
            linkThongKe.Name = "linkThongKe";
            linkThongKe.Size = new Size(56, 15);
            linkThongKe.TabIndex = 39;
            linkThongKe.TabStop = true;
            linkThongKe.Text = "Thống kê";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(118, 127);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(113, 15);
            linkLabel2.TabIndex = 47;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Trạng thái đơn hàng";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(137, 96);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(87, 15);
            linkLabel1.TabIndex = 46;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Phương thức tt";
            // 
            // formQLHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(linkThongKe);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(linkTrangChu);
            Controls.Add(linkLabel3);
            Controls.Add(linkThemsp);
            Controls.Add(pictureBox1);
            Name = "formQLHoaDon";
            Text = "formQLHoaDon";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label7;
        private LinkLabel linkTrangChu;
        private LinkLabel linkLabel3;
        private LinkLabel linkThemsp;
        private PictureBox pictureBox1;
        private Label label6;
        private TextBox txtMaHoaDon;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button1;
        private LinkLabel linkThongKe;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
    }
}