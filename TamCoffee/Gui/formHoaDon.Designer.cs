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
            label2 = new Label();
            label3 = new Label();
            label12 = new Label();
            txtMaHoaDon = new TextBox();
            btnThoat = new Button();
            dgvHoaDon = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(287, 77);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Hóa Đơn";
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(48, 384);
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
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(212, 127);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.ReadOnly = true;
            txtMaHoaDon.Size = new Size(88, 23);
            txtMaHoaDon.TabIndex = 26;
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
            // dgvHoaDon
            // 
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4, Column3, Column5 });
            dgvHoaDon.Location = new Point(90, 169);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowTemplate.Height = 25;
            dgvHoaDon.Size = new Size(543, 212);
            dgvHoaDon.TabIndex = 51;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã Sản Phẩm";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên Sản Phẩm";
            Column2.Name = "Column2";
            // 
            // Column4
            // 
            Column4.HeaderText = "Giá";
            Column4.Name = "Column4";
            // 
            // Column3
            // 
            Column3.HeaderText = "Số lượng";
            Column3.Name = "Column3";
            // 
            // Column5
            // 
            Column5.HeaderText = "Thành tiền";
            Column5.Name = "Column5";
            // 
            // formHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 484);
            Controls.Add(dgvHoaDon);
            Controls.Add(btnThoat);
            Controls.Add(txtMaHoaDon);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "formHoaDon";
            Text = "formHoaDon";
            Load += formHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Button button2;
        private Label label11;
        private Label label2;
        private Label label3;
        private Label label12;
        private TextBox txtMaHoaDon;
        private Button btnThoat;
        private DataGridView dgvHoaDon;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
    }
}