namespace TamCoffee.Gui.UserConTroll
{
    partial class NhanVienControll
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboMaChucVu = new ComboBox();
            label7 = new Label();
            gBGioiTinh = new GroupBox();
            radNu = new RadioButton();
            radNam = new RadioButton();
            pictureBox1 = new PictureBox();
            txtTim = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            btnTim = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtEmail = new TextBox();
            txtMatKhau = new TextBox();
            txtTenTK = new TextBox();
            txtTenNhanVien = new TextBox();
            txtMaNhanVien = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gBGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cboMaChucVu
            // 
            cboMaChucVu.FormattingEnabled = true;
            cboMaChucVu.Location = new Point(210, 290);
            cboMaChucVu.Name = "cboMaChucVu";
            cboMaChucVu.Size = new Size(212, 23);
            cboMaChucVu.TabIndex = 76;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(132, 293);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 75;
            label7.Text = "Mã chức vụ:";
            // 
            // gBGioiTinh
            // 
            gBGioiTinh.Controls.Add(radNu);
            gBGioiTinh.Controls.Add(radNam);
            gBGioiTinh.Location = new Point(124, 194);
            gBGioiTinh.Name = "gBGioiTinh";
            gBGioiTinh.Size = new Size(284, 46);
            gBGioiTinh.TabIndex = 74;
            gBGioiTinh.TabStop = false;
            gBGioiTinh.Text = "Giới tính";
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(150, 19);
            radNu.Name = "radNu";
            radNu.Size = new Size(41, 19);
            radNu.TabIndex = 1;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(29, 21);
            radNam.Name = "radNam";
            radNam.Size = new Size(51, 19);
            radNam.TabIndex = 0;
            radNam.TabStop = true;
            radNam.Text = "Nam\r\n";
            radNam.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Logoquan;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // txtTim
            // 
            txtTim.Location = new Point(151, 392);
            txtTim.Margin = new Padding(3, 2, 3, 2);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(213, 23);
            txtTim.TabIndex = 66;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(485, 0);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(521, 475);
            dataGridView1.TabIndex = 65;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã Nhân Viên";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên Nhân Viên";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Tên Tài Khoản";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Mật Khẩu";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Giới tính";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Email";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "MÃ chức vụ";
            Column7.Name = "Column7";
            // 
            // btnTim
            // 
            btnTim.Location = new Point(54, 391);
            btnTim.Margin = new Padding(3, 2, 3, 2);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(82, 22);
            btnTim.TabIndex = 64;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(281, 344);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(82, 22);
            btnSua.TabIndex = 63;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(167, 344);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 22);
            btnXoa.TabIndex = 62;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(54, 344);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 22);
            btnThem.TabIndex = 61;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(210, 256);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(213, 23);
            txtEmail.TabIndex = 60;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(209, 166);
            txtMatKhau.Margin = new Padding(3, 2, 3, 2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(213, 23);
            txtMatKhau.TabIndex = 59;
            // 
            // txtTenTK
            // 
            txtTenTK.Location = new Point(210, 139);
            txtTenTK.Margin = new Padding(3, 2, 3, 2);
            txtTenTK.Name = "txtTenTK";
            txtTenTK.Size = new Size(213, 23);
            txtTenTK.TabIndex = 58;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(210, 112);
            txtTenNhanVien.Margin = new Padding(3, 2, 3, 2);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(213, 23);
            txtTenNhanVien.TabIndex = 57;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(210, 83);
            txtMaNhanVien.Margin = new Padding(3, 2, 3, 2);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.ReadOnly = true;
            txtMaNhanVien.Size = new Size(213, 23);
            txtMaNhanVien.TabIndex = 56;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(135, 259);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 55;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(114, 168);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 54;
            label5.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 139);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 53;
            label4.Text = "Tên Tài Khoản\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 112);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 52;
            label3.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 85);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 51;
            label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 64, 64);
            label1.Location = new Point(209, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 50;
            label1.Text = "Quản Lý Nhân Viên";
            // 
            // NhanVienControll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cboMaChucVu);
            Controls.Add(label7);
            Controls.Add(gBGioiTinh);
            Controls.Add(pictureBox1);
            Controls.Add(txtTim);
            Controls.Add(dataGridView1);
            Controls.Add(btnTim);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtEmail);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenTK);
            Controls.Add(txtTenNhanVien);
            Controls.Add(txtMaNhanVien);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NhanVienControll";
            Size = new Size(1006, 475);
            gBGioiTinh.ResumeLayout(false);
            gBGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cboMaChucVu;
        private Label label7;
        private GroupBox gBGioiTinh;
        private RadioButton radNu;
        private RadioButton radNam;
        private PictureBox pictureBox1;
        private TextBox txtTim;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button btnTim;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtEmail;
        private TextBox txtMatKhau;
        private TextBox txtTenTK;
        private TextBox txtTenNhanVien;
        private TextBox txtMaNhanVien;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
