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
            components = new System.ComponentModel.Container();
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
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 174);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(323, 274);
            txtMatKhau.Margin = new Padding(4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(176, 23);
            txtMatKhau.TabIndex = 9;
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Location = new Point(323, 244);
            txtTenTaiKhoan.Margin = new Padding(4);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(176, 23);
            txtTenTaiKhoan.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 277);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 7;
            label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 247);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 6;
            label1.Text = "Tên Tài Khoản";
            // 
            // llblQuenMatKhau
            // 
            llblQuenMatKhau.AutoSize = true;
            llblQuenMatKhau.Location = new Point(319, 382);
            llblQuenMatKhau.Margin = new Padding(4, 0, 4, 0);
            llblQuenMatKhau.Name = "llblQuenMatKhau";
            llblQuenMatKhau.Size = new Size(90, 15);
            llblQuenMatKhau.TabIndex = 10;
            llblQuenMatKhau.TabStop = true;
            llblQuenMatKhau.Text = "Quên Mật Khẩu";
            llblQuenMatKhau.LinkClicked += llblQuenMatKhau_LinkClicked;
            // 
            // llblDangKy
            // 
            llblDangKy.AutoSize = true;
            llblDangKy.Location = new Point(435, 382);
            llblDangKy.Margin = new Padding(4, 0, 4, 0);
            llblDangKy.Name = "llblDangKy";
            llblDangKy.Size = new Size(50, 15);
            llblDangKy.TabIndex = 11;
            llblDangKy.TabStop = true;
            llblDangKy.Text = "Đăng Ký";
            llblDangKy.LinkClicked += llblDangKy_LinkClicked;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(371, 320);
            btnDangNhap.Margin = new Padding(4);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(85, 26);
            btnDangNhap.TabIndex = 12;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.login;
            pictureBox3.Location = new Point(154, 277);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(154, 236);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Logoquan;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(319, 38);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // formDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 471);
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
            Margin = new Padding(4);
            Name = "formDangNhap";
            Text = "DangNhap";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private ErrorProvider errorProvider1;
    }
}