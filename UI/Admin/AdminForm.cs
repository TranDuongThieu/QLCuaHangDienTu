using CuaHangDienTu.UI.Login;

namespace CuaHangDienTu.UI.Admin
{
    public partial class AdminForm : Form
    {
        private RealLoginForm loginFormReference;
        public AdminForm(RealLoginForm realLoginForm)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            loginFormReference = realLoginForm;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Admin_QLKH admin_QLKH = new Admin_QLKH();
            Admin_QLHoaDon admin_QLHoaDon = new Admin_QLHoaDon();
            Admin_QLDNH admin_QLDNH = new Admin_QLDNH();
            Admin_QLMatHang admin_QLMatHang = new Admin_QLMatHang();
            Admin_QLDoanhThu admin_QLDoanhThu = new Admin_QLDoanhThu();
            tabKH.Controls.Add(admin_QLKH);
            tabSP.Controls.Add(admin_QLMatHang);
            tabHD.Controls.Add(admin_QLHoaDon);
            tabDNH.Controls.Add(admin_QLDNH);
            tabDoanhThu.Controls.Add(admin_QLDoanhThu);
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserLoginInfomation.Username = "";
            UserLoginInfomation.Password = "";
            loginFormReference.Show();
        }
    }
}
