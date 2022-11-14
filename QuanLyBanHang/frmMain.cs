namespace QuanLyBanHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chấToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuFindBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void trợGiúpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tệpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }

        private void hàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect();
            Application.Exit();
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            frmDMChatLieu frm = new frmDMChatLieu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmDMHangHoa frm = new frmDMHangHoa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanVien frm = new frmDMNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frm = new frmHoaDonBan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmDMKhachHang frm = new frmDMKhachHang();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}