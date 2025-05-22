namespace TamCoffee.Gui.UserConTroll
{
    partial class LoaiSanPhamControll
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            txtTenLoaiSP = new TextBox();
            dgvLoaiSanPham = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSanPham).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Logoquan;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(13, 15);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 64, 64);
            label1.Location = new Point(309, 29);
            label1.Name = "label1";
            label1.Size = new Size(233, 25);
            label1.TabIndex = 63;
            label1.Text = "Quản Lý Loại Sản Phẩm\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 92);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 65;
            label2.Text = "Mã loại sản phẩm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 139);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 67;
            label4.Text = "Tên loại sản phẩm";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(328, 85);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 68;
            // 
            // txtTenLoaiSP
            // 
            txtTenLoaiSP.Location = new Point(328, 131);
            txtTenLoaiSP.Name = "txtTenLoaiSP";
            txtTenLoaiSP.Size = new Size(170, 23);
            txtTenLoaiSP.TabIndex = 69;
            // 
            // dgvLoaiSanPham
            // 
            dgvLoaiSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiSanPham.Dock = DockStyle.Bottom;
            dgvLoaiSanPham.Location = new Point(0, 255);
            dgvLoaiSanPham.Name = "dgvLoaiSanPham";
            dgvLoaiSanPham.RowTemplate.Height = 25;
            dgvLoaiSanPham.Size = new Size(905, 237);
            dgvLoaiSanPham.TabIndex = 70;
            // 
            // LoaiSanPhamControll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvLoaiSanPham);
            Controls.Add(txtTenLoaiSP);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "LoaiSanPhamControll";
            Size = new Size(905, 492);
            Load += LoaiSanPhamControll_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox textBox1;
        private TextBox txtTenLoaiSP;
        private DataGridView dgvLoaiSanPham;
    }
}
