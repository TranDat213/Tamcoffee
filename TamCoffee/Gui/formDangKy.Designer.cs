namespace TamCoffee.Gui
{
    partial class DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTenTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            txtXNMK = new TextBox();
            txtEmail = new TextBox();
            btnDangKy = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 238);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Tài Khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 276);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 312);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 2;
            label3.Text = "Xác Nhận Mật Khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 350);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Location = new Point(229, 232);
            txtTenTaiKhoan.Margin = new Padding(4, 5, 4, 5);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(200, 27);
            txtTenTaiKhoan.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(229, 272);
            txtMatKhau.Margin = new Padding(4, 5, 4, 5);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(200, 27);
            txtMatKhau.TabIndex = 5;
            // 
            // txtXNMK
            // 
            txtXNMK.Location = new Point(229, 305);
            txtXNMK.Margin = new Padding(4, 5, 4, 5);
            txtXNMK.Name = "txtXNMK";
            txtXNMK.Size = new Size(200, 27);
            txtXNMK.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(229, 342);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 7;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(277, 399);
            btnDangKy.Margin = new Padding(4, 5, 4, 5);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(97, 35);
            btnDangKy.TabIndex = 8;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(263, 24);
            label5.Name = "label5";
            label5.Size = new Size(111, 31);
            label5.TabIndex = 9;
            label5.Text = "Đăng Ký";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.website;
            pictureBox1.Location = new Point(269, 99);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 692);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(btnDangKy);
            Controls.Add(txtEmail);
            Controls.Add(txtXNMK);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenTaiKhoan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "DangKy";
            Text = "DangKy";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtXNMK;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}