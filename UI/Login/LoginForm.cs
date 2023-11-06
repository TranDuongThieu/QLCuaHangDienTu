using CuaHangDienTu.UI.Admin;
using CuaHangDienTu.UI.Main;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CuaHangDienTu
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();

        }
        string sqlConnectionString = "Data Source=localhost, 1433;Initial Catalog=CuaHangDienTu;TrustServerCertificate=True";
        DataSet ds = new DataSet();
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string sql;

        public event Action LoginClicked;

        public void CloseForm()
        {
            this.Hide();
        }

        public void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.ToString();
            string password = passwordTextBox.Text.ToString();
            if (username == "admin")
            {
                if (password == "admin")
                {
                    AdminForm adminform = new AdminForm();
                    adminform.Show();
                    this.Hide();
                }
                else MessageBox.Show("Sai mật khẩu");
            }
            else
            {
                using (SqlConnection con1 = new SqlConnection(sqlConnectionString))
                {
                    con1.Open();
                    SqlCommand cmd = new SqlCommand("Select * from ACCOUNT where username = @username", con1);

                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters["@username"].Direction = ParameterDirection.Input;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string storedPassword = reader["password"].ToString();
                        MessageBox.Show(storedPassword == password ? "true" : "false");
                        if (storedPassword == password)
                        {
                            MainForm mainform = new MainForm();
                            mainform.Show();
                            this.Hide();
                        }
                        else MessageBox.Show("Sai mật khẩu");
                    }
                    else MessageBox.Show("Tài khoản không tồn tại");

                }
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}