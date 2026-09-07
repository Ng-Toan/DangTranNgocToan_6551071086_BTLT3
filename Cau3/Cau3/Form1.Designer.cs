namespace Cau3
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
            label1 = new Label();
            label2 = new Label();
            txtHoLot = new TextBox();
            txtTen = new TextBox();
            btnHoLot = new Button();
            btnTen = new Button();
            btnHoVaTen = new Button();
            btnExit = new Button();
            lblHoTen = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 110);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Ho lot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 160);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 1;
            label2.Text = "Ten";
            // 
            // txtHoLot
            // 
            txtHoLot.Location = new Point(266, 110);
            txtHoLot.Name = "txtHoLot";
            txtHoLot.Size = new Size(338, 27);
            txtHoLot.TabIndex = 2;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.LightCoral;
            txtTen.Location = new Point(266, 157);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(338, 27);
            txtTen.TabIndex = 3;
            // 
            // btnHoLot
            // 
            btnHoLot.Location = new Point(142, 225);
            btnHoLot.Name = "btnHoLot";
            btnHoLot.Size = new Size(106, 51);
            btnHoLot.TabIndex = 4;
            btnHoLot.Text = "Ho lot";
            btnHoLot.UseVisualStyleBackColor = true;
            btnHoLot.Click += btnHoLot_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(346, 225);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(106, 51);
            btnTen.TabIndex = 5;
            btnTen.Text = "Ten";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoVaTen
            // 
            btnHoVaTen.Location = new Point(537, 225);
            btnHoVaTen.Name = "btnHoVaTen";
            btnHoVaTen.Size = new Size(106, 51);
            btnHoVaTen.TabIndex = 6;
            btnHoVaTen.Text = "Ho va Ten";
            btnHoVaTen.UseVisualStyleBackColor = true;
            btnHoVaTen.Click += btnHoVaTen_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(312, 308);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(173, 52);
            btnExit.TabIndex = 7;
            btnExit.Text = "ThoatChuongTrinh";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblHoTen
            // 
            lblHoTen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblHoTen.BackColor = SystemColors.MenuHighlight;
            lblHoTen.Font = new Font("Segoe UI", 30F);
            lblHoTen.ForeColor = SystemColors.Control;
            lblHoTen.Location = new Point(1, -3);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(799, 86);
            lblHoTen.TabIndex = 8;
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            lblHoTen.DoubleClick += lblHoTen_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 372);
            Controls.Add(lblHoTen);
            Controls.Add(btnExit);
            Controls.Add(btnHoVaTen);
            Controls.Add(btnTen);
            Controls.Add(btnHoLot);
            Controls.Add(txtTen);
            Controls.Add(txtHoLot);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Hien thi ho ten";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHoLot;
        private TextBox txtTen;
        private Button btnHoLot;
        private Button btnTen;
        private Button btnHoVaTen;
        private Button btnExit;
        private Label lblHoTen;
    }
}
