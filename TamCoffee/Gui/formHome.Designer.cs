namespace WindowsFormsApp1
{
    partial class formHome
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
            btnDangXuat = new Button();
            SuspendLayout();
            // 
            // btnDangXuat
            // 
            btnDangXuat.Location = new Point(905, 638);
            btnDangXuat.Margin = new Padding(4, 5, 4, 5);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(100, 35);
            btnDangXuat.TabIndex = 1;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // formHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 692);
            Controls.Add(btnDangXuat);
            Margin = new Padding(4, 5, 4, 5);
            Name = "formHome";
            Text = "Home";
            Load += formHome_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDangXuat;
    }
}