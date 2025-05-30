namespace TamCoffee.Gui.UserConTroll
{
    partial class TrangThaiControll
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
            dgvTrangThaiDH = new DataGridView();
            txtTenTTDH = new TextBox();
            txtMaTTDh = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnRefesh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTrangThaiDH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvTrangThaiDH
            // 
            dgvTrangThaiDH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrangThaiDH.Dock = DockStyle.Bottom;
            dgvTrangThaiDH.Location = new Point(0, 205);
            dgvTrangThaiDH.Margin = new Padding(3, 2, 3, 2);
            dgvTrangThaiDH.Name = "dgvTrangThaiDH";
            dgvTrangThaiDH.RowHeadersWidth = 51;
            dgvTrangThaiDH.RowTemplate.Height = 25;
            dgvTrangThaiDH.Size = new Size(924, 254);
            dgvTrangThaiDH.TabIndex = 66;
            dgvTrangThaiDH.CellClick += dgvTrangThaiDH_CellClick;
            // 
            // txtTenTTDH
            // 
            txtTenTTDH.Location = new Point(278, 132);
            txtTenTTDH.Name = "txtTenTTDH";
            txtTenTTDH.Size = new Size(156, 23);
            txtTenTTDH.TabIndex = 65;
            // 
            // txtMaTTDh
            // 
            txtMaTTDh.Location = new Point(278, 87);
            txtMaTTDh.Name = "txtMaTTDh";
            txtMaTTDh.ReadOnly = true;
            txtMaTTDh.Size = new Size(156, 23);
            txtMaTTDh.TabIndex = 64;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 135);
            label3.Name = "label3";
            label3.Size = new Size(133, 30);
            label3.TabIndex = 63;
            label3.Text = "Tên trạng thái đơn hàng\r\n\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 87);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 62;
            label2.Text = "Mã trạng thái đơn hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 64, 64);
            label1.Location = new Point(151, 25);
            label1.Name = "label1";
            label1.Size = new Size(283, 25);
            label1.TabIndex = 61;
            label1.Text = "Quản lý Trạng thái đơn hàng";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Logoquan;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(514, 38);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(66, 25);
            btnThem.TabIndex = 68;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(514, 67);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(66, 22);
            btnXoa.TabIndex = 69;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(514, 93);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(66, 23);
            btnSua.TabIndex = 70;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnRefesh
            // 
            btnRefesh.Location = new Point(514, 120);
            btnRefesh.Margin = new Padding(3, 2, 3, 2);
            btnRefesh.Name = "btnRefesh";
            btnRefesh.Size = new Size(66, 29);
            btnRefesh.TabIndex = 71;
            btnRefesh.Text = "Refesh";
            btnRefesh.UseVisualStyleBackColor = true;
            btnRefesh.Click += btnRefesh_Click;
            // 
            // TrangThaiControll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRefesh);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(pictureBox1);
            Controls.Add(dgvTrangThaiDH);
            Controls.Add(txtTenTTDH);
            Controls.Add(txtMaTTDh);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TrangThaiControll";
            Size = new Size(924, 459);
            Load += TrangThaiControll_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTrangThaiDH).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTrangThaiDH;
        private TextBox txtTenTTDH;
        private TextBox txtMaTTDh;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnRefesh;
    }
}
