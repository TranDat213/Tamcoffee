namespace TamCoffee.Gui
{
    partial class formQuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formQuenMatKhau));
            label1 = new Label();
            txtTenTaiKhoan = new TextBox();
            btnDangNhap = new Button();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 319);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Email Đăng Ký";
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Location = new Point(320, 316);
            txtTenTaiKhoan.Margin = new Padding(5, 5, 5, 5);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(201, 27);
            txtTenTaiKhoan.TabIndex = 5;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = SystemColors.WindowText;
            btnDangNhap.ForeColor = SystemColors.Menu;
            btnDangNhap.Location = new Point(349, 448);
            btnDangNhap.Margin = new Padding(5, 5, 5, 5);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(149, 35);
            btnDangNhap.TabIndex = 14;
            btnDangNhap.Text = "Gửi";
            btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(327, 83);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(171, 27);
            label6.TabIndex = 20;
            label6.Text = "Quên Mật Khẩu";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.settings;
            pictureBox1.Location = new Point(358, 148);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(386, 594);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(66, 37);
            btnThoat.TabIndex = 62;
            btnThoat.Text = "Close";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // formQuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 692);
            Controls.Add(btnThoat);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(btnDangNhap);
            Controls.Add(txtTenTaiKhoan);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 5, 5, 5);
            Name = "formQuenMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuenMatKhau";
            Load += QuenMatKhau_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Button btnThoat;
    }
}