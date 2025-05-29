namespace TamCoffee.Gui.UserConTroll
{
    partial class SanPhamControll
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
            txtTenSanPham = new TextBox();
            txtMaSanPham = new TextBox();
            label9 = new Label();
            btnSuaSP = new Button();
            btnXoaSP = new Button();
            label6 = new Label();
            btnThemSP = new Button();
            dgvSanPham = new DataGridView();
            label5 = new Label();
            txtGiaBan = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            cboLoaiHang = new ComboBox();
            btnRefesh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(248, 84);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(251, 23);
            txtTenSanPham.TabIndex = 61;
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Location = new Point(250, 49);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.ReadOnly = true;
            txtMaSanPham.Size = new Size(247, 23);
            txtMaSanPham.TabIndex = 60;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(129, 53);
            label9.Name = "label9";
            label9.Size = new Size(79, 15);
            label9.TabIndex = 59;
            label9.Text = "Mã sản phẩm";
            // 
            // btnSuaSP
            // 
            btnSuaSP.Location = new Point(526, 124);
            btnSuaSP.Name = "btnSuaSP";
            btnSuaSP.Size = new Size(75, 23);
            btnSuaSP.TabIndex = 58;
            btnSuaSP.Text = "Sửa";
            btnSuaSP.UseVisualStyleBackColor = true;
            btnSuaSP.Click += btnSuaSP_Click;
            // 
            // btnXoaSP
            // 
            btnXoaSP.Location = new Point(526, 86);
            btnXoaSP.Name = "btnXoaSP";
            btnXoaSP.Size = new Size(75, 23);
            btnXoaSP.TabIndex = 57;
            btnXoaSP.Text = "Xóa";
            btnXoaSP.UseVisualStyleBackColor = true;
            btnXoaSP.Click += btnXoaSP_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(128, 64, 64);
            label6.Location = new Point(187, 14);
            label6.Name = "label6";
            label6.Size = new Size(170, 25);
            label6.TabIndex = 56;
            label6.Text = "Quản lý sản phẩm";
            // 
            // btnThemSP
            // 
            btnThemSP.Location = new Point(526, 49);
            btnThemSP.Name = "btnThemSP";
            btnThemSP.Size = new Size(75, 23);
            btnThemSP.TabIndex = 55;
            btnThemSP.Text = "Thêm";
            btnThemSP.UseVisualStyleBackColor = true;
            btnThemSP.Click += btnThemSP_Click;
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Dock = DockStyle.Bottom;
            dgvSanPham.Location = new Point(0, 264);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowTemplate.Height = 25;
            dgvSanPham.Size = new Size(836, 203);
            dgvSanPham.TabIndex = 54;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(304, 82);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 53;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(250, 122);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(247, 23);
            txtGiaBan.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(129, 164);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 51;
            label4.Text = "Loại sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(129, 130);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 50;
            label2.Text = "Giá bán";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(129, 93);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 49;
            label1.Text = "Tên sản phẩm";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Logoquan;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(15, 4);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 68;
            pictureBox1.TabStop = false;
            // 
            // cboLoaiHang
            // 
            cboLoaiHang.FormattingEnabled = true;
            cboLoaiHang.Location = new Point(250, 156);
            cboLoaiHang.Name = "cboLoaiHang";
            cboLoaiHang.Size = new Size(247, 23);
            cboLoaiHang.TabIndex = 69;
            // 
            // btnRefesh
            // 
            btnRefesh.Location = new Point(526, 160);
            btnRefesh.Name = "btnRefesh";
            btnRefesh.Size = new Size(75, 23);
            btnRefesh.TabIndex = 70;
            btnRefesh.Text = "Refesh";
            btnRefesh.UseVisualStyleBackColor = true;
            btnRefesh.Click += btnRefesh_Click;
            // 
            // SanPhamControll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRefesh);
            Controls.Add(cboLoaiHang);
            Controls.Add(pictureBox1);
            Controls.Add(txtTenSanPham);
            Controls.Add(txtMaSanPham);
            Controls.Add(label9);
            Controls.Add(btnSuaSP);
            Controls.Add(btnXoaSP);
            Controls.Add(label6);
            Controls.Add(btnThemSP);
            Controls.Add(dgvSanPham);
            Controls.Add(label5);
            Controls.Add(txtGiaBan);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SanPhamControll";
            Size = new Size(836, 467);
            Load += SanPhamControll_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTenSanPham;
        private TextBox txtMaSanPham;
        private Label label9;
        private Button btnSuaSP;
        private Button btnXoaSP;
        private Label label6;
        private Button btnThemSP;
        private DataGridView dgvSanPham;
        private Label label5;
        private TextBox txtGiaBan;
        private Label label4;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox cboLoaiHang;
        private Button btnRefesh;
    }
}
