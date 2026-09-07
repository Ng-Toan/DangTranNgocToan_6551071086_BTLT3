namespace BTChuong3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTiep = new Button();
            label1 = new Label();
            btnHienThi = new Button();
            label2 = new Label();
            btnDong = new Button();
            txtNhapPass = new TextBox();
            txtHienThi = new TextBox();
            SuspendLayout();
            // 
            // btnTiep
            // 
            btnTiep.Location = new Point(351, 271);
            btnTiep.Name = "btnTiep";
            btnTiep.Size = new Size(93, 41);
            btnTiep.TabIndex = 0;
            btnTiep.Text = "Tiep";
            btnTiep.UseVisualStyleBackColor = true;
            btnTiep.Click += btnTiep_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(249, 111);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 1;
            label1.Text = "Nhap Password";
            label1.Click += label1_Click;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(174, 271);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(101, 41);
            btnHienThi.TabIndex = 2;
            btnHienThi.Text = "HienThi";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(287, 181);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 3;
            label2.Text = "HienThi";
            // 
            // btnDong
            // 
            btnDong.Location = new Point(512, 271);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(84, 41);
            btnDong.TabIndex = 4;
            btnDong.Text = "Dong";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // txtNhapPass
            // 
            txtNhapPass.ForeColor = SystemColors.WindowText;
            txtNhapPass.Location = new Point(369, 108);
            txtNhapPass.Name = "txtNhapPass";
            txtNhapPass.PasswordChar = '*';
            txtNhapPass.Size = new Size(146, 27);
            txtNhapPass.TabIndex = 5;
            // 
            // txtHienThi
            // 
            txtHienThi.Location = new Point(369, 181);
            txtHienThi.Name = "txtHienThi";
            txtHienThi.Size = new Size(146, 27);
            txtHienThi.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtHienThi);
            Controls.Add(txtNhapPass);
            Controls.Add(btnDong);
            Controls.Add(label2);
            Controls.Add(btnHienThi);
            Controls.Add(label1);
            Controls.Add(btnTiep);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTiep;
        private Label label1;
        private Button btnHienThi;
        private Label label2;
        private Button btnDong;
        private TextBox txtNhapPass;
        private TextBox txtHienThi;
    }
}
