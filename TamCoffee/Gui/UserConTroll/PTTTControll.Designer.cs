namespace TamCoffee.Gui.UserConTroll
{
    partial class PTTTControll
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
            dgvPTTT = new DataGridView();
            txtTenPTTT = new TextBox();
            txtMAPTTT = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvPTTT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvPTTT
            // 
            dgvPTTT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPTTT.Dock = DockStyle.Bottom;
            dgvPTTT.Location = new Point(0, 231);
            dgvPTTT.Name = "dgvPTTT";
            dgvPTTT.RowTemplate.Height = 25;
            dgvPTTT.Size = new Size(788, 254);
            dgvPTTT.TabIndex = 61;
            // 
            // txtTenPTTT
            // 
            txtTenPTTT.Location = new Point(301, 150);
            txtTenPTTT.Name = "txtTenPTTT";
            txtTenPTTT.Size = new Size(156, 23);
            txtTenPTTT.TabIndex = 60;
            // 
            // txtMAPTTT
            // 
            txtMAPTTT.Location = new Point(301, 105);
            txtMAPTTT.Name = "txtMAPTTT";
            txtMAPTTT.ReadOnly = true;
            txtMAPTTT.Size = new Size(156, 23);
            txtMAPTTT.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 153);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 58;
            label3.Text = "Tên phương thức";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 115);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 57;
            label2.Text = "Mã phương thức";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 64, 64);
            label1.Location = new Point(148, 32);
            label1.Name = "label1";
            label1.Size = new Size(325, 25);
            label1.TabIndex = 56;
            label1.Text = "Quản Lý Phương thức thanh toán";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Logoquan;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(14, 16);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 62;
            pictureBox1.TabStop = false;
            // 
            // PTTTControll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(dgvPTTT);
            Controls.Add(txtTenPTTT);
            Controls.Add(txtMAPTTT);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PTTTControll";
            Size = new Size(788, 485);
            Load += PTTTControll_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPTTT).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPTTT;
        private TextBox txtTenPTTT;
        private TextBox txtMAPTTT;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
