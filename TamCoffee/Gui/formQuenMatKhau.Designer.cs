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
            label2 = new Label();
            txtTenTaiKhoan = new TextBox();
            btnDangNhap = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 241);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Email Đăng Ký";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 306);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Location = new Point(332, 238);
            txtTenTaiKhoan.Margin = new Padding(4, 5, 4, 5);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(200, 27);
            txtTenTaiKhoan.TabIndex = 5;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = SystemColors.WindowText;
            btnDangNhap.ForeColor = SystemColors.Menu;
            btnDangNhap.Location = new Point(349, 448);
            btnDangNhap.Margin = new Padding(4, 5, 4, 5);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(149, 35);
            btnDangNhap.TabIndex = 14;
            btnDangNhap.Text = "Xác Nhận Mật Khẩu";
            btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(332, 299);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 302);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 15;
            label3.Text = "Nhập Mật Khẩu Mới";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(332, 362);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 366);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 18;
            label4.Text = "Nhập Lại Mật Khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 370);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(344, 34);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(171, 27);
            label6.TabIndex = 20;
            label6.Text = "Quên Mật Khẩu";
            // 
            // pictureBox1
            // 
            pictureBox1.Image =global::TamCoffee.Properties.Resources.settings;
            pictureBox1.Location = new Point(375, 100);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // QuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 692);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(btnDangNhap);
            Controls.Add(txtTenTaiKhoan);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "QuenMatKhau";
            Text = "QuenMatKhau";
            Load += QuenMatKhau_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}