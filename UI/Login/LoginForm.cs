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
        string sqlConnectionString = Properties.Settings.Default.connectionString;
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
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            using (SqlConnection con = new SqlConnection(sqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUserLogin", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@username", username));
                    cmd.Parameters.Add(new SqlParameter("@password", password));

                    try
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                int resultCode = Convert.ToInt32(reader["ResultCode"]);
                                string resultMessage = reader["ResultMessage"].ToString();

                                if (resultCode == 0)
                                {
                                    // Login successful
                                    MessageBox.Show(resultMessage);
                                    // Open the appropriate form for the user
                                    if (username == "admin")
                                    {
                                        AdminForm adminForm = new AdminForm();
                                        adminForm.Show();
                                    }
                                    else
                                    {
                                        MainForm mainForm = new MainForm();
                                        mainForm.Show();
                                    }
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show(resultMessage);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Tài khoản không tồn tại");
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}