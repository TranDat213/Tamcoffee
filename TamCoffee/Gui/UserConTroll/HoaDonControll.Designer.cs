namespace TamCoffee.Gui.UserConTroll
{
    partial class HoaDonControll
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
            groupBox1 = new GroupBox();
            cboMaTK = new ComboBox();
            btnTimKiem = new Button();
            radTimMaTK = new RadioButton();
            radTimNgayLap = new RadioButton();
            dgvDSHoaDon = new DataGridView();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            btnXoaHD = new Button();
            button3 = new Button();
            dtpNgayLap = new DateTimePicker();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpNgayLap);
            groupBox1.Controls.Add(cboMaTK);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(radTimMaTK);
            groupBox1.Controls.Add(radTimNgayLap);
            groupBox1.Location = new Point(140, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(399, 142);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm Hóa Đơn";
            // 
            // cboMaTK
            // 
            cboMaTK.FormattingEnabled = true;
            cboMaTK.Location = new Point(173, 74);
            cboMaTK.Name = "cboMaTK";
            cboMaTK.Size = new Size(121, 23);
            cboMaTK.TabIndex = 52;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(23, 102);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(91, 35);
            btnTimKiem.TabIndex = 38;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // radTimMaTK
            // 
            radTimMaTK.AutoSize = true;
            radTimMaTK.Location = new Point(18, 74);
            radTimMaTK.Name = "radTimMaTK";
            radTimMaTK.Size = new Size(117, 19);
            radTimMaTK.TabIndex = 1;
            radTimMaTK.TabStop = true;
            radTimMaTK.Text = "Tìm mã tài khoản\r\n";
            radTimMaTK.UseVisualStyleBackColor = true;
            // 
            // radTimNgayLap
            // 
            radTimNgayLap.AutoSize = true;
            radTimNgayLap.Location = new Point(18, 38);
            radTimNgayLap.Name = "radTimNgayLap";
            radTimNgayLap.Size = new Size(148, 19);
            radTimNgayLap.TabIndex = 0;
            radTimNgayLap.TabStop = true;
            radTimNgayLap.Text = "Tìm hóa đơn theo ngày";
            radTimNgayLap.UseVisualStyleBackColor = true;
            // 
            // dgvDSHoaDon
            // 
            dgvDSHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSHoaDon.Dock = DockStyle.Bottom;
            dgvDSHoaDon.Location = new Point(0, 248);
            dgvDSHoaDon.Name = "dgvDSHoaDon";
            dgvDSHoaDon.RowTemplate.Height = 25;
            dgvDSHoaDon.Size = new Size(768, 226);
            dgvDSHoaDon.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(128, 64, 64);
            label6.Location = new Point(316, 7);
            label6.Name = "label6";
            label6.Size = new Size(157, 25);
            label6.TabIndex = 39;
            label6.Text = "Quản lý hóa đơn";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Logoquan;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(4, 7);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 68;
            pictureBox1.TabStop = false;
            // 
            // btnXoaHD
            // 
            btnXoaHD.Location = new Point(584, 57);
            btnXoaHD.Name = "btnXoaHD";
            btnXoaHD.Size = new Size(91, 35);
            btnXoaHD.TabIndex = 69;
            btnXoaHD.Text = "Xóa";
            btnXoaHD.UseVisualStyleBackColor = true;
            btnXoaHD.Click += btnXoaHD_Click;
            // 
            // button3
            // 
            button3.Location = new Point(584, 115);
            button3.Name = "button3";
            button3.Size = new Size(91, 35);
            button3.TabIndex = 70;
            button3.Text = "Refesh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Location = new Point(176, 34);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(200, 23);
            dtpNgayLap.TabIndex = 53;
            // 
            // HoaDonControll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(btnXoaHD);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(dgvDSHoaDon);
            Controls.Add(label6);
            Name = "HoaDonControll";
            Size = new Size(768, 474);
            Load += HoaDonControll_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnTimKiem;
        private RadioButton radTimMaTK;
        private RadioButton radTimNgayLap;
        private DataGridView dgvDSHoaDon;
        private Label label6;
        private PictureBox pictureBox1;
        private ComboBox cboMaTK;
        private Button btnXoaHD;
        private Button button3;
        private DateTimePicker dtpNgayLap;
    }
}
