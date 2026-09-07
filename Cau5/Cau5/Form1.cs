namespace Cau5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void formEvent_Load(object sender, EventArgs e)
        {
            txtNhapTen.Focus();
            radRed.Checked = true;
        }
        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapTen.Text;
        }
        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Red;
            txtNhapTen.ForeColor = Color.Red;
        }
        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Green;
            txtNhapTen.ForeColor = Color.Green;
        }
        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Blue;
            txtNhapTen.ForeColor = Color.Blue;
        }
        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Black;
            txtNhapTen.ForeColor = Color.Black;
        }
        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name,
            lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Bold);
        }
        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name,
            lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Italic);
        }
        private void chkGachChan_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name,
            lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Underline);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
