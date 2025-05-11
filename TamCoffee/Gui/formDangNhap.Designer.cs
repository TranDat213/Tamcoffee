namespace TamCoffee.Gui
{
    partial class formDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDangNhap));
            label3 = new Label();
            txtMatKhau = new TextBox();
            txtTenTaiKhoan = new TextBox();
            label2 = new Label();
            label1 = new Label();
            llblQuenMatKhau = new LinkLabel();
            llblDangKy = new LinkLabel();
            btnDangNhap = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 232);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(369, 365);
            txtMatKhau.Margin = new Padding(4, 5, 4, 5);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(200, 27);
            txtMatKhau.TabIndex = 9;
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Location = new Point(369, 325);
            txtTenTaiKhoan.Margin = new Padding(4, 5, 4, 5);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(200, 27);
            txtTenTaiKhoan.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 369);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 7;
            label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 329);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 6;
            label1.Text = "Tên Tài Khoản";
            // 
            // llblQuenMatKhau
            // 
            llblQuenMatKhau.AutoSize = true;
            llblQuenMatKhau.Location = new Point(365, 509);
            llblQuenMatKhau.Margin = new Padding(4, 0, 4, 0);
            llblQuenMatKhau.Name = "llblQuenMatKhau";
            llblQuenMatKhau.Size = new Size(111, 20);
            llblQuenMatKhau.TabIndex = 10;
            llblQuenMatKhau.TabStop = true;
            llblQuenMatKhau.Text = "Quên Mật Khẩu";
            llblQuenMatKhau.LinkClicked += llblQuenMatKhau_LinkClicked;
            // 
            // llblDangKy
            // 
            llblDangKy.AutoSize = true;
            llblDangKy.Location = new Point(497, 509);
            llblDangKy.Margin = new Padding(4, 0, 4, 0);
            llblDangKy.Name = "llblDangKy";
            llblDangKy.Size = new Size(64, 20);
            llblDangKy.TabIndex = 11;
            llblDangKy.TabStop = true;
            llblDangKy.Text = "Đăng Ký";
            llblDangKy.LinkClicked += llblDangKy_LinkClicked;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(424, 426);
            btnDangNhap.Margin = new Padding(4, 5, 4, 5);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(97, 35);
            btnDangNhap.TabIndex = 12;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = global::TamCoffee.Properties.Resources.login;
            pictureBox3.Location = new Point(176, 369);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = global::TamCoffee.Properties.Resources.user;
            pictureBox2.Location = new Point(176, 315);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = global::TamCoffee.Properties.Resources.Logoquan;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(365, 51);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // formDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 628);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnDangNhap);
            Controls.Add(llblDangKy);
            Controls.Add(llblQuenMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenTaiKhoan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "formDangNhap";
            Text = "DangNhap";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llblQuenMatKhau;
        private System.Windows.Forms.LinkLabel llblDangKy;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}