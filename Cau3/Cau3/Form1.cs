namespace Cau3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHoLot_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHoLot.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtTen.Text;
        }

        private void btnHoVaTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHoLot.Text + " " + txtTen.Text;
        }

        private void lblHoTen_DoubleClick(object sender, EventArgs e)
        {
            lblHoTen.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
