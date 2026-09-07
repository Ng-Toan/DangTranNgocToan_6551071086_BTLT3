namespace BTChuong3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtNhapPass.Text;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtNhapPass.Clear();
            txtHienThi.Clear();

            txtNhapPass.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
