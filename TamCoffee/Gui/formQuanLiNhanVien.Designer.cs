namespace TamCoffee.Gui
{
    partial class formQuanLiNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formQuanLiNhanVien));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMaNhanVien = new TextBox();
            txtTenNhanVien = new TextBox();
            txtSoDienThoai = new TextBox();
            txtCCCD = new TextBox();
            txtDiaChi = new TextBox();
            dateNgayVaoLam = new DateTimePicker();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnTim = new Button();
            dataGridView1 = new DataGridView();
            txtTim = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 64, 64);
            label1.Location = new Point(361, 9);
            label1.Name = "label1";
            label1.Size = new Size(229, 31);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã Nhân Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên Nhân Viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 131);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 3;
            label4.Text = "Số Điện Thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 172);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 4;
            label5.Text = "CCCD/CMND";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 215);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 5;
            label6.Text = "Địa Chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 253);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 6;
            label7.Text = "Ngày Vào Làm";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(120, 56);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(243, 27);
            txtMaNhanVien.TabIndex = 7;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(120, 95);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(243, 27);
            txtTenNhanVien.TabIndex = 8;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(120, 131);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(243, 27);
            txtSoDienThoai.TabIndex = 9;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(120, 169);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(243, 27);
            txtCCCD.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(120, 208);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(243, 27);
            txtDiaChi.TabIndex = 11;
            // 
            // dateNgayVaoLam
            // 
            dateNgayVaoLam.Location = new Point(120, 246);
            dateNgayVaoLam.Name = "dateNgayVaoLam";
            dateNgayVaoLam.Size = new Size(243, 27);
            dateNgayVaoLam.TabIndex = 12;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(9, 294);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(138, 294);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(269, 294);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(9, 356);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 16;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(392, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(595, 329);
            dataGridView1.TabIndex = 17;
            // 
            // txtTim
            // 
            txtTim.Location = new Point(120, 358);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(243, 27);
            txtTim.TabIndex = 18;
            // 
            // formQuanLiNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1013, 450);
            Controls.Add(txtTim);
            Controls.Add(dataGridView1);
            Controls.Add(btnTim);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(dateNgayVaoLam);
            Controls.Add(txtDiaChi);
            Controls.Add(txtCCCD);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtTenNhanVien);
            Controls.Add(txtMaNhanVien);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formQuanLiNhanVien";
            Text = "formQuanLiNhanVien";
            Load += formQuanLiNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtMaNhanVien;
        private TextBox txtTenNhanVien;
        private TextBox txtSoDienThoai;
        private TextBox txtCCCD;
        private TextBox txtDiaChi;
        private DateTimePicker dateNgayVaoLam;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnTim;
        private DataGridView dataGridView1;
        private TextBox txtTim;
    }
}