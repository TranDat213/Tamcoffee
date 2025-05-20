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
            label9 = new Label();
            label1 = new Label();
            button2 = new Button();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            label2 = new Label();
            label3 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtMaHoaDon = new TextBox();
            label7 = new Label();
            label14 = new Label();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logoquan;
            pictureBox1.Location = new Point(287, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(317, 190);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(287, 77);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Hóa Đơn";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(584, 401);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 19;
            button2.Text = "In Hóa Đơn";
            button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(222, 177);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 21;
            label8.Text = "Mã đơn hàng";
            label8.Click += label8_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(317, 177);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 22;
            label10.Text = "Tên sản phẩm";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(138, 370);
            label11.Name = "label11";
            label11.Size = new Size(60, 15);
            label11.TabIndex = 23;
            label11.Text = "Tổng tiền:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(328, 441);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Địa chỉ :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(378, 441);
            label3.Name = "label3";
            label3.Size = new Size(270, 15);
            label3.TabIndex = 3;
            label3.Text = "180 Cao Lỗ,Phường 4,Quận 8,Thành Phố Hồ Chí Minh";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(127, 131);
            label12.Name = "label12";
            label12.Size = new Size(71, 15);
            label12.TabIndex = 24;
            label12.Text = "Mã hóa đơn";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(483, 177);
            label13.Name = "label13";
            label13.Size = new Size(63, 15);
            label13.TabIndex = 25;
            label13.Text = "Thành tiền";
            label13.Click += label13_Click;
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(212, 127);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.ReadOnly = true;
            txtMaHoaDon.Size = new Size(88, 23);
            txtMaHoaDon.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(119, 177);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 20;
            label7.Text = "Mã sản phẩm";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(413, 177);
            label14.Name = "label14";
            label14.Size = new Size(54, 15);
            label14.TabIndex = 28;
            label14.Text = "Số lượng";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(17, 413);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(58, 28);
            btnThoat.TabIndex = 50;
            btnThoat.Text = "Close";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // formHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 484);
            Controls.Add(btnThoat);
            Controls.Add(label14);
            Controls.Add(txtMaHoaDon);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "formHoaDon";
            Text = "formHoaDon";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label9;
        private Label label1;
        private Button button2;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label2;
        private Label label3;
        private Label label12;
        private Label label13;
        private TextBox txtMaHoaDon;
        private Label label7;
        private Label label14;
        private Button btnThoat;
    }
}