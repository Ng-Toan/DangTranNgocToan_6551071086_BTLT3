namespace Cau5
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
            txtNhapTen = new TextBox();
            gbColor = new GroupBox();
            radBlack = new RadioButton();
            radBlue = new RadioButton();
            radGreen = new RadioButton();
            radRed = new RadioButton();
            gbFont = new GroupBox();
            chkGachChan = new CheckBox();
            chkItalic = new CheckBox();
            chkBold = new CheckBox();
            label2 = new Label();
            lblLapTrinh = new Label();
            btnExit = new Button();
            gbColor.SuspendLayout();
            gbFont.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlText;
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(166, 33);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhap ten :";
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(240, 30);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(398, 27);
            txtNhapTen.TabIndex = 1;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // gbColor
            // 
            gbColor.BackColor = SystemColors.GradientActiveCaption;
            gbColor.Controls.Add(radBlack);
            gbColor.Controls.Add(radBlue);
            gbColor.Controls.Add(radGreen);
            gbColor.Controls.Add(radRed);
            gbColor.Location = new Point(166, 92);
            gbColor.Name = "gbColor";
            gbColor.Size = new Size(171, 193);
            gbColor.TabIndex = 2;
            gbColor.TabStop = false;
            gbColor.Text = "Color";
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radBlack.Location = new Point(13, 130);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(67, 24);
            radBlack.TabIndex = 3;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += radBlack_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(13, 100);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(61, 24);
            radBlue.TabIndex = 2;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += radBlue_CheckedChanged;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radGreen.ForeColor = Color.DarkGreen;
            radGreen.Location = new Point(13, 70);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(72, 24);
            radGreen.TabIndex = 1;
            radGreen.TabStop = true;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            radGreen.CheckedChanged += radGreen_CheckedChanged;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(13, 40);
            radRed.Name = "radRed";
            radRed.Size = new Size(57, 24);
            radRed.TabIndex = 0;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radRed_CheckedChanged;
            // 
            // gbFont
            // 
            gbFont.BackColor = Color.AntiqueWhite;
            gbFont.Controls.Add(chkGachChan);
            gbFont.Controls.Add(chkItalic);
            gbFont.Controls.Add(chkBold);
            gbFont.Location = new Point(450, 92);
            gbFont.Name = "gbFont";
            gbFont.Size = new Size(188, 193);
            gbFont.TabIndex = 3;
            gbFont.TabStop = false;
            gbFont.Text = "Font";
            // 
            // chkGachChan
            // 
            chkGachChan.AutoSize = true;
            chkGachChan.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            chkGachChan.ForeColor = Color.Blue;
            chkGachChan.Location = new Point(21, 140);
            chkGachChan.Name = "chkGachChan";
            chkGachChan.Size = new Size(103, 24);
            chkGachChan.TabIndex = 2;
            chkGachChan.Text = "Gach chan";
            chkGachChan.UseVisualStyleBackColor = true;
            chkGachChan.CheckedChanged += chkGachChan_CheckedChanged;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            chkItalic.ForeColor = Color.Blue;
            chkItalic.Location = new Point(21, 91);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(133, 24);
            chkItalic.TabIndex = 1;
            chkItalic.Text = "Nghieng Italic";
            chkItalic.UseVisualStyleBackColor = true;
            chkItalic.CheckedChanged += chkItalic_CheckedChanged;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkBold.ForeColor = Color.Blue;
            chkBold.Location = new Point(21, 43);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(100, 24);
            chkBold.TabIndex = 0;
            chkBold.Text = "Dam Bold";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += chkBold_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(214, 327);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 4;
            label2.Text = "Lap trinh boi :";
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.BorderStyle = BorderStyle.Fixed3D;
            lblLapTrinh.Location = new Point(326, 326);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(204, 35);
            lblLapTrinh.TabIndex = 5;
            lblLapTrinh.TextChanged += txtNhapTen_TextChanged;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(547, 310);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(91, 60);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoat";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(lblLapTrinh);
            Controls.Add(label2);
            Controls.Add(gbFont);
            Controls.Add(gbColor);
            Controls.Add(txtNhapTen);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Dinh dang";
            Load += formEvent_Load;
            gbColor.ResumeLayout(false);
            gbColor.PerformLayout();
            gbFont.ResumeLayout(false);
            gbFont.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNhapTen;
        private GroupBox gbColor;
        private RadioButton radBlack;
        private RadioButton radBlue;
        private RadioButton radGreen;
        private RadioButton radRed;
        private GroupBox gbFont;
        private CheckBox chkGachChan;
        private CheckBox chkItalic;
        private CheckBox chkBold;
        private Label label2;
        private Label lblLapTrinh;
        private Button btnExit;
    }
}
