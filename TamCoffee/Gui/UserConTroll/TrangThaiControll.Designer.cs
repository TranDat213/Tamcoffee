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
            ((System.ComponentModel.ISupportInitialize)dgvTrangThaiDH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvTrangThaiDH
            // 
            dgvTrangThaiDH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrangThaiDH.Location = new Point(45, 180);
            dgvTrangThaiDH.Name = "dgvTrangThaiDH";
            dgvTrangThaiDH.RowTemplate.Height = 25;
            dgvTrangThaiDH.Size = new Size(653, 254);
            dgvTrangThaiDH.TabIndex = 66;
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
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // TrangThaiControll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(dgvTrangThaiDH);
            Controls.Add(txtTenTTDH);
            Controls.Add(txtMaTTDh);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TrangThaiControll";
            Size = new Size(742, 459);
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
    }
}
