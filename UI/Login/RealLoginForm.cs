using CuaHangDienTu.Models;
using CuaHangDienTu.UI.Admin;
using Microsoft.Data.SqlClient;

namespace CuaHangDienTu.UI.Login
{
    public partial class RealLoginForm : Form
    {
        public RealLoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            UserLoginInfomation.Username = username;
            UserLoginInfomation.Password = password;
            try
            {
                using (DBConnection db = new DBConnection())
                {
                    using (SqlConnection connection = db.GetConnection())
                    {
                        db.OpenConnection();
                    }
                }
                MessageBox.Show("Đăng nhập thành công");
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đăng nhập thất bại với lỗi : " + ex.Message);
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBConnection db = new DBConnection())
                {
                    using (SqlConnection connection = db.GetConnectionAdmin())
                    {
                        using (SqlCommand command = new SqlCommand("spDangKiTaiKhoan", connection))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@username", regUsernameTexBox.Text);
                            command.Parameters.AddWithValue("@password", regPasswordTextBox.Text);
                            db.OpenConnectionAdmin();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Đăng kí tài khoản thành công");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đăng kí tài khoản thất bại, lỗi: " + ex.Message);
            }

        }
    }
}
