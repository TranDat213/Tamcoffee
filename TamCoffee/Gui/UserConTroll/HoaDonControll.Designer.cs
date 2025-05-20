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
            cboMaHoaDon = new ComboBox();
            button1 = new Button();
            radioButton2 = new RadioButton();
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboMaHoaDon);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(209, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 142);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm Hóa Đơn";
            // 
            // cboMaHoaDon
            // 
            cboMaHoaDon.FormattingEnabled = true;
            cboMaHoaDon.Location = new Point(152, 34);
            cboMaHoaDon.Name = "cboMaHoaDon";
            cboMaHoaDon.Size = new Size(121, 23);
            cboMaHoaDon.TabIndex = 51;
            // 
            // button1
            // 
            button1.Location = new Point(23, 102);
            button1.Name = "button1";
            button1.Size = new Size(91, 35);
            button1.TabIndex = 38;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(18, 74);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(120, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Tìm mã nhân viên";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 23);
            textBox1.TabIndex = 37;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(18, 38);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(115, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tìm mã Hóa Đơn";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(768, 216);
            dataGridView1.TabIndex = 40;
            // 
            // Column1
            // 
            Column1.HeaderText = "MaNhanVien";
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Mã Hóa Đơn";
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Thời gian";
            Column3.Name = "Column3";
            Column3.Width = 250;
            // 
            // Column4
            // 
            Column4.HeaderText = "Tổng tiền";
            Column4.Name = "Column4";
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
            // HoaDonControll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Name = "HoaDonControll";
            Size = new Size(768, 474);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboMaHoaDon;
        private Button button1;
        private RadioButton radioButton2;
        private TextBox textBox1;
        private RadioButton radioButton1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label6;
        private PictureBox pictureBox1;
    }
}
