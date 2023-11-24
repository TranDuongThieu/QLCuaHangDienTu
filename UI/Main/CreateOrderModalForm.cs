using CuaHangDienTu.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CuaHangDienTu.UI.Main
{
    public partial class CreateOrderModalForm : Form
    {
        private List<string> customers = new List<string>();
        private List<string> departments = new List<string>();
        public CreateOrderModalForm()
        {
            InitializeComponent();
        }

        private string GetCustomerIdFromName(string customerName)
        {
            string customerId = null;
            try
            {
                using (DBConnection db = new DBConnection())
                {
                    using (SqlConnection con = db.GetConnection())
                    {
                        using (SqlCommand command = new SqlCommand("spLayMaKhachHangTuTen", con))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            // Add the customer name parameter
                            command.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar, 50).Value = customerName;

                            // Add the missing @MaKhachHang parameter and specify the ParameterDirection.Output direction
                            command.Parameters.Add("@MaKhachHang", SqlDbType.NVarChar, 10).Direction = ParameterDirection.Output;


                            db.OpenConnection();
                            command.ExecuteNonQuery();

                            // Get the output customer ID parameter
                            customerId = command.Parameters["@MaKhachHang"].Value.ToString();
                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle the error
                MessageBox.Show("Đã xảy ra lỗi khi lấy mã khách hàng: " + ex.Message);
                return null;
            }
            return customerId;
        }

        private string GetDepartmentIdFromName(string departmentName)
        {
            string departmentId = null;

            try
            {
                using (DBConnection db = new DBConnection())
                {
                    using (SqlConnection con = db.GetConnection())
                    {
                        using (SqlCommand command = new SqlCommand("spLayMaChiNhanhTuTen", con))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            // Add the department name parameter
                            command.Parameters.Add("@TenChiNhanh", SqlDbType.NVarChar, 50).Value = departmentName;
                            // Add the missing @MaChiNhanh parameter and specify the ParameterDirection.Output direction
                            command.Parameters.Add("@MaChiNhanh", SqlDbType.NVarChar, 10).Direction = ParameterDirection.Output;
                            db.OpenConnection();
                            command.ExecuteNonQuery();

                            // Get the output customer ID parameter
                            departmentId = command.Parameters["@MaChiNhanh"].Value.ToString();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi lấy mã chi nhánh: " + ex.Message);
            }
            return departmentId;
        }

        private List<string> GetCustomers()
        {
            List<string> customers = new List<string>();
            try
            {
                using (DBConnection db = new DBConnection())
                {
                    using (SqlConnection connection = db.GetConnection())
                    {
                        using (SqlCommand command = new SqlCommand("SELECT * FROM vwTenKhachHang", connection))
                        {
                            db.OpenConnection();
                            SqlDataReader reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                string customerName = reader.GetString("TenKhachHang");
                                customers.Add(customerName);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi lấy tên khách hàng: " + ex.Message);
            }
            return customers;
        }

        private List<string> GetDepartments()
        {
            List<string> departments = new List<string>();
            try
            {
                using (DBConnection db = new DBConnection())
                {
                    using (SqlConnection connection = db.GetConnection())
                    {
                        using (SqlCommand command = new SqlCommand("SELECT * FROM vwTenChiNhanh", connection))
                        {
                            db.OpenConnection();
                            SqlDataReader reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                string deparmentName = reader.GetString("TenChiNhanh");
                                departments.Add(deparmentName);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi lấy tên chi nhánh: " + ex.Message);
            }
            return departments;
        }

        private string GenerateRandomID(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; // Define characters to use

            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void CreateOrder()
        {
            string maDH = "DH" + GenerateRandomID(8); // Tạo mã đơn hàng ngẫu nhiên

            int tongGiaTri = 0; // Tính tổng giá trị đơn hàng

            string tenKhachHang = customerComboBox.GetItemText(customerComboBox.SelectedItem);
            string tenChiNhanh = departmentComboBox.GetItemText(departmentComboBox.SelectedItem);

            string maKhachHang = GetCustomerIdFromName(tenKhachHang);
            string maChiNhanh = GetDepartmentIdFromName(tenChiNhanh);

            if (maKhachHang == null || maChiNhanh == null)
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng hoặc chi nhánh.");
                GlobalVar.CurrentOrderId = null;
                return;
            }
            try
            {
                using (DBConnection db = new DBConnection())
                {
                    using (SqlConnection con = db.GetConnection())
                    {
                        using (SqlCommand command = new SqlCommand("spTaoDonHang", con))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            // Thêm các tham số cần thiết cho thủ tục
                            command.Parameters.Add("@MaDH", SqlDbType.NVarChar, 10).Value = maDH;
                            command.Parameters.Add("@TongGiaTri", SqlDbType.Int).Value = tongGiaTri;
                            command.Parameters.Add("@NgayDatHang", SqlDbType.Date).Value = DateTime.Today; // Ngày hôm nay
                            command.Parameters.Add("@MaKH", SqlDbType.NVarChar, 10).Value = maKhachHang;
                            command.Parameters.Add("@MaCN", SqlDbType.NVarChar, 10).Value = maChiNhanh;


                            db.OpenConnection();
                            command.ExecuteNonQuery();
                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi, có thể hiển thị thông báo cho người dùng
                MessageBox.Show("Đã xảy ra lỗi khi tạo đơn hàng: " + ex.Message);
                GlobalVar.CurrentOrderId = null;
                return;
            }
            GlobalVar.CurrentOrderId = maDH;
        }



        private void CreateOrderModalForm_Load(object sender, EventArgs e)
        {
            customers = GetCustomers();
            departments = GetDepartments();

            customerComboBox.Items.Clear();
            foreach (var c in customers)
            {
                customerComboBox.Items.Add(c);
            }

            departmentComboBox.Items.Clear();
            foreach (var d in departments)
            {
                departmentComboBox.Items.Add(d);
            }

            customerComboBox.SelectedItem = null;
            customerComboBox.SelectedText = "--Chọn khách hàng--";

            departmentComboBox.SelectedItem = null;
            departmentComboBox.SelectedText = "--Chọn chi nhánh--";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            CreateOrder();
            DialogResult = DialogResult.OK;
        }

        private void createNewCustomerButton_Click(object sender, EventArgs e)
        {
            string randomID = "KH" + GenerateRandomID(8);
            string customerName = newCustomerNameTextBox.Text;
            string customerPhone = newCustomerPhoneTextBox.Text;
            try
            {
                using (DBConnection db = new DBConnection())
                {
                    using (SqlConnection con = db.GetConnection())
                    {
                        using (SqlCommand command = new SqlCommand("spThemKH", con))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            // Add parameters
                            command.Parameters.Add("@MaKH", SqlDbType.VarChar, 10).Value = randomID;
                            command.Parameters.Add("@HoTenKH", SqlDbType.NVarChar, 50).Value = customerName;
                            command.Parameters.Add("@SoDienThoai", SqlDbType.VarChar, 10).Value = customerPhone;

                            db.OpenConnection();
                            command.ExecuteNonQuery();

                            MessageBox.Show("Customer added successfully!");
                            customerComboBox.Items.Clear();
                            customers = GetCustomers();
                            foreach (var c in customers)
                            {
                                customerComboBox.Items.Add(c);
                            }
                            customerComboBox.SelectedItem = null;
                            customerComboBox.SelectedIndex = -1;
                            customerComboBox.Text = "--Chọn khách hàng--";
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message);
            }
        }
    }
}
