namespace CuaHangDienTu.UI.Admin
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Admin_QLKH admin_QLKH = new Admin_QLKH();
            Admin_QLHoaDon admin_QLHoaDon = new Admin_QLHoaDon();
            Admin_QLDNH admin_QLDNH = new Admin_QLDNH();
            Admin_QLMatHang admin_QLMatHang = new Admin_QLMatHang();
            tabKH.Controls.Add(admin_QLKH);
            tabSP.Controls.Add(admin_QLMatHang);
            tabHD.Controls.Add(admin_QLHoaDon);
            tabDNH.Controls.Add(admin_QLDNH);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabKH_Click(object sender, EventArgs e)
        {

        }
    }
}
