namespace TamCoffee.Gui
{
    partial class formHoaDon
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button2 = new Button();
            label11 = new Label();
            label3 = new Label();
            label12 = new Label();
            btnThoat = new Button();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lbMaHD = new Label();
            lbNgayLap = new Label();
            lbTaiKhoan = new Label();
            lbPhuongThuc = new Label();
            lbTrangThai = new Label();
            flpChiTiet = new FlowLayoutPanel();
            lblTongTien = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logoquan;
            pictureBox1.Location = new Point(201, 7);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(184, 85);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Hóa Đơn";
            // 
            // button2
            // 
            button2.Location = new Point(404, 648);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 28);
            button2.TabIndex = 19;
            button2.Text = "In Hóa Đơn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 591);
            label11.Name = "label11";
            label11.Size = new Size(60, 15);
            label11.TabIndex = 23;
            label11.Text = "Tổng tiền:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(87, 70);
            label3.Name = "label3";
            label3.Size = new Size(270, 15);
            label3.TabIndex = 3;
            label3.Text = "180 Cao Lỗ,Phường 4,Quận 8,Thành Phố Hồ Chí Minh";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(87, 127);
            label12.Name = "label12";
            label12.Size = new Size(71, 15);
            label12.TabIndex = 24;
            label12.Text = "Mã hóa đơn";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(19, 648);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(58, 28);
            btnThoat.TabIndex = 50;
            btnThoat.Text = "Close";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 156);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 51;
            label2.Text = "Ngày";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 185);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 52;
            label4.Text = "Tài khoản";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 210);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 53;
            label5.Text = "Phương thức tt";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 242);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 54;
            label6.Text = "Trạng thái hóa đơn";
            // 
            // lbMaHD
            // 
            lbMaHD.AutoSize = true;
            lbMaHD.Location = new Point(207, 127);
            lbMaHD.Name = "lbMaHD";
            lbMaHD.Size = new Size(38, 15);
            lbMaHD.TabIndex = 55;
            lbMaHD.Text = "label7";
            // 
            // lbNgayLap
            // 
            lbNgayLap.AutoSize = true;
            lbNgayLap.Location = new Point(207, 156);
            lbNgayLap.Name = "lbNgayLap";
            lbNgayLap.Size = new Size(38, 15);
            lbNgayLap.TabIndex = 56;
            lbNgayLap.Text = "label8";
            // 
            // lbTaiKhoan
            // 
            lbTaiKhoan.AutoSize = true;
            lbTaiKhoan.Location = new Point(207, 185);
            lbTaiKhoan.Name = "lbTaiKhoan";
            lbTaiKhoan.Size = new Size(38, 15);
            lbTaiKhoan.TabIndex = 57;
            lbTaiKhoan.Text = "label9";
            // 
            // lbPhuongThuc
            // 
            lbPhuongThuc.AutoSize = true;
            lbPhuongThuc.Location = new Point(207, 210);
            lbPhuongThuc.Name = "lbPhuongThuc";
            lbPhuongThuc.Size = new Size(44, 15);
            lbPhuongThuc.TabIndex = 58;
            lbPhuongThuc.Text = "label10";
            // 
            // lbTrangThai
            // 
            lbTrangThai.AutoSize = true;
            lbTrangThai.Location = new Point(207, 242);
            lbTrangThai.Name = "lbTrangThai";
            lbTrangThai.Size = new Size(44, 15);
            lbTrangThai.TabIndex = 59;
            lbTrangThai.Text = "label13";
            // 
            // flpChiTiet
            // 
            flpChiTiet.AutoScroll = true;
            flpChiTiet.BorderStyle = BorderStyle.FixedSingle;
            flpChiTiet.Location = new Point(22, 343);
            flpChiTiet.Name = "flpChiTiet";
            flpChiTiet.Size = new Size(546, 234);
            flpChiTiet.TabIndex = 60;
            flpChiTiet.Paint += flpChiTiet_Paint;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(80, 591);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(38, 15);
            lblTongTien.TabIndex = 61;
            lblTongTien.Text = "label7";
            // 
            // formHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 725);
            Controls.Add(lblTongTien);
            Controls.Add(flpChiTiet);
            Controls.Add(lbTrangThai);
            Controls.Add(lbPhuongThuc);
            Controls.Add(lbTaiKhoan);
            Controls.Add(lbNgayLap);
            Controls.Add(lbMaHD);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnThoat);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "formHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hoa Don";
            Load += formHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Button button2;
        private Label label11;
        private Label label3;
        private Label label12;
        private Button btnThoat;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbMaHD;
        private Label lbNgayLap;
        private Label lbTaiKhoan;
        private Label lbPhuongThuc;
        private Label lbTrangThai;
        private FlowLayoutPanel flpChiTiet;
        private Label lblTongTien;
    }
}