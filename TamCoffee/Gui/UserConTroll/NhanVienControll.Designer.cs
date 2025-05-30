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
            label7 = new Label();
            gBGioiTinh = new GroupBox();
            radNu = new RadioButton();
            radNam = new RadioButton();
            pictureBox1 = new PictureBox();
            dgvDSTaiKhoan = new DataGridView();
            btnTimChucvu = new Button();
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
            cboTimChucVu = new ComboBox();
            btnRefesh = new Button();
            cboChucVu = new ComboBox();
            gBGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDSTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(132, 293);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 75;
            label7.Text = "Chức vụ";
            // 
            // gBGioiTinh
            // 
            gBGioiTinh.Controls.Add(radNu);
            gBGioiTinh.Controls.Add(radNam);
            gBGioiTinh.Location = new Point(124, 194);
            gBGioiTinh.Name = "gBGioiTinh";
            gBGioiTinh.Size = new Size(254, 46);
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
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // dgvDSTaiKhoan
            // 
            dgvDSTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSTaiKhoan.Dock = DockStyle.Right;
            dgvDSTaiKhoan.Location = new Point(671, 0);
            dgvDSTaiKhoan.Margin = new Padding(3, 2, 3, 2);
            dgvDSTaiKhoan.Name = "dgvDSTaiKhoan";
            dgvDSTaiKhoan.RowHeadersWidth = 51;
            dgvDSTaiKhoan.RowTemplate.Height = 29;
            dgvDSTaiKhoan.Size = new Size(462, 475);
            dgvDSTaiKhoan.TabIndex = 65;
            dgvDSTaiKhoan.CellClick += dgvDSTaiKhoan_CellClick;
            // 
            // btnTimChucvu
            // 
            btnTimChucvu.Location = new Point(33, 401);
            btnTimChucvu.Margin = new Padding(3, 2, 3, 2);
            btnTimChucvu.Name = "btnTimChucvu";
            btnTimChucvu.Size = new Size(72, 23);
            btnTimChucvu.TabIndex = 64;
            btnTimChucvu.Text = "Tìm";
            btnTimChucvu.UseVisualStyleBackColor = true;
            btnTimChucvu.Click += btnTimChucvu_Click;
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
            btnSua.Click += btnSua_Click;
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
            btnXoa.Click += btnXoa_Click;
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
            btnThem.Click += btnThem_Click;
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
            // cboTimChucVu
            // 
            cboTimChucVu.FormattingEnabled = true;
            cboTimChucVu.Location = new Point(111, 401);
            cboTimChucVu.Margin = new Padding(3, 2, 3, 2);
            cboTimChucVu.Name = "cboTimChucVu";
            cboTimChucVu.Size = new Size(172, 23);
            cboTimChucVu.TabIndex = 77;
            // 
            // btnRefesh
            // 
            btnRefesh.Location = new Point(411, 401);
            btnRefesh.Margin = new Padding(3, 2, 3, 2);
            btnRefesh.Name = "btnRefesh";
            btnRefesh.Size = new Size(72, 23);
            btnRefesh.TabIndex = 78;
            btnRefesh.Text = "Refesh";
            btnRefesh.UseVisualStyleBackColor = true;
            btnRefesh.Click += btnRefesh_Click;
            // 
            // cboChucVu
            // 
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Location = new Point(209, 293);
            cboChucVu.Margin = new Padding(3, 2, 3, 2);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(186, 23);
            cboChucVu.TabIndex = 76;
            // 
            // NhanVienControll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRefesh);
            Controls.Add(cboTimChucVu);
            Controls.Add(cboChucVu);
            Controls.Add(label7);
            Controls.Add(gBGioiTinh);
            Controls.Add(pictureBox1);
            Controls.Add(dgvDSTaiKhoan);
            Controls.Add(btnTimChucvu);
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
            Size = new Size(1133, 475);
            Load += NhanVienControll_Load;
            gBGioiTinh.ResumeLayout(false);
            gBGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDSTaiKhoan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private GroupBox gBGioiTinh;
        private RadioButton radNu;
        private RadioButton radNam;
        private PictureBox pictureBox1;
        private DataGridView dgvDSTaiKhoan;
        private Button btnTimChucvu;
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
        private ComboBox cboTimChucVu;
        private Button btnRefesh;
        private ComboBox cboChucVu;
    }
}
