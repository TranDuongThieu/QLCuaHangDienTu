using CuaHangDienTu.Models;
using CuaHangDienTu.UI.Order;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CuaHangDienTu.UI.ChildForm
{
    public partial class AddOrderForm : Form
    {
        private List<string> _customerNames;
        private List<string> _departmentNames;
        private List<KeyValuePair<string, string>> _productItems;
        private string _currentOrderId;
        private DateTime _currentOrderCreatedDate;
        private bool _orderCreated;
        private int _currentQuantity;
        private string _currentDescription;
        private int _currentPrice;
        private List<OrderDetailsDTO> _orderDetails;
        public AddOrderForm()
        {
            InitializeComponent();
        }

        private List<string> GetCustomerNames()
        {
            List<string> names = new List<string>();

            using (DBConnection db = new DBConnection())
            {
                using (SqlConnection con = db.GetConnection())
                {
                    string query = "SELECT DISTINCT TenKhachHang FROM vwTenKhachHang"; // Assuming the customer name field is 'TenKhachHang'

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        db.OpenConnection();

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string customerName = reader["TenKhachHang"].ToString();
                            names.Add(customerName);
                        }
                    }
                }
            }

            return names;
        }

        private List<string> GetDepartmentNames()
        {
            List<string> names = new List<string>();

            using (DBConnection db = new DBConnection())
            {
                using (SqlConnection con = db.GetConnection())
                {
                    {
                        string query = "SELECT DISTINCT TenChiNhanh FROM vwTenChiNhanh"; // Assuming the department name field is 'TenChiNhanh'

                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            db.OpenConnection();

                            SqlDataReader reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                string departmentName = reader["TenChiNhanh"].ToString();
                                names.Add(departmentName);
                            }
                        }
                    }
                }
            }

            return names;
        }

        private List<KeyValuePair<string, string>> GetProductItems()
        {
            List<KeyValuePair<string, string>> itemNames = new List<KeyValuePair<string, string>>();



            using (DBConnection db = new DBConnection())
            {
                using (SqlConnection con = db.GetConnection())
                {
                    string query = "SELECT MaMatHangSP, TenSP FROM vwMatHangSanPham";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        db.OpenConnection();

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string itemId = reader["MaMatHangSP"].ToString();
                            string itemName = reader["TenSP"].ToString();

                            itemNames.Add(new KeyValuePair<string, string>(itemName, itemId));
                        }
                    }
                }
            }

            return itemNames;
        }

        private void toggleAddProducts()
        {
            orderIdLabel.Visible = _orderCreated;
            orderIdTextbox.Visible = _orderCreated;
            orderCreatedDateLabel.Visible = _orderCreated;
            addProductLabel.Visible = _orderCreated;
            productItemComboBox.Visible = _orderCreated;
            addProductToOrderButton.Visible = _orderCreated;

            orderIdTextbox.Text = _currentOrderId;
            orderIdTextbox.Enabled = false;
            customerComboBox.Enabled = !_orderCreated;
            departmentComboBox.Enabled = !_orderCreated;
            customerNameTextBox.Enabled = !_orderCreated;
            customerPhoneTextBox.Enabled = !_orderCreated;
            addCustomerButton.Enabled = !_orderCreated;
            orderCreatedDateLabel.Text = "Được tạo ngày " + _currentOrderCreatedDate.Day + "/" + _currentOrderCreatedDate.Month + "/" + _currentOrderCreatedDate.Year;
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            _orderCreated = false;
            _currentQuantity = 0;
            flowLayoutPanel1.AutoScroll = true;
            _orderDetails = new List<OrderDetailsDTO>();
            productQuantityTextBox.Text = _currentQuantity.ToString();
            _customerNames = GetCustomerNames();
            _departmentNames = GetDepartmentNames();
            _productItems = GetProductItems();
            customerComboBox.Items.AddRange(_customerNames.ToArray());
            customerComboBox.SelectedItem = null;
            customerComboBox.SelectedText = "--Chọn khách hàng--";

            departmentComboBox.Items.AddRange(_departmentNames.ToArray());
            departmentComboBox.SelectedItem = null;
            departmentComboBox.SelectedText = "--Chọn chi nhánh--";

            foreach (var item in _productItems)
            {
                productItemComboBox.Items.Add(item.Key);
            }

            toggleAddProducts();
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {


            string maDH = "DH" + GenerateRandomID(8); // Tạo mã đơn hàng ngẫu nhiên
            _currentOrderId = maDH;
            int tongGiaTri = 0; // Tính tổng giá trị đơn hàng

            string tenKhachHang = customerComboBox.GetItemText(customerComboBox.SelectedItem);
            string tenChiNhanh = departmentComboBox.GetItemText(departmentComboBox.SelectedItem);

            string maKhachHang = null;
            string maChiNhanh = null;

            using (DBConnection db = new DBConnection())
            {
                using (SqlConnection con = db.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("spLayMaKhachHangTuTen", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add the customer name parameter
                        command.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar, 50).Value = tenKhachHang;

                        // Add the missing @MaKhachHang parameter and specify the ParameterDirection.Output direction
                        command.Parameters.Add("@MaKhachHang", SqlDbType.NVarChar, 10).Direction = ParameterDirection.Output;

                        try
                        {
                            db.OpenConnection();
                            command.ExecuteNonQuery();

                            // Get the output customer ID parameter
                            maKhachHang = command.Parameters["@MaKhachHang"].Value.ToString();
                        }
                        catch (SqlException ex)
                        {
                            // Handle the error
                            MessageBox.Show("Đã xảy ra lỗi khi lấy mã khách hàng: " + ex.Message);
                            return;
                        }
                    }


                    using (SqlCommand command = new SqlCommand("spLayMaChiNhanhTuTen", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add the department name parameter
                        command.Parameters.Add("@TenChiNhanh", SqlDbType.NVarChar, 50).Value = tenChiNhanh;
                        // Add the missing @MaChiNhanh parameter and specify the ParameterDirection.Output direction
                        command.Parameters.Add("@MaChiNhanh", SqlDbType.NVarChar, 10).Direction = ParameterDirection.Output;

                        try
                        {
                            command.ExecuteNonQuery();

                            // Get the output customer ID parameter
                            maChiNhanh = command.Parameters["@MaChiNhanh"].Value.ToString();
                        }
                        catch (SqlException ex)
                        {
                            // Handle the error
                            MessageBox.Show("Đã xảy ra lỗi khi lấy mã chi nhánh: " + ex.Message);
                            return;
                        }
                    }
                }
            }


            if (maKhachHang == null || maChiNhanh == null)
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng hoặc chi nhánh.");
                return;
            }
            // Thực hiện kết nối đến cơ sở dữ liệu
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
                        _currentOrderCreatedDate = DateTime.Today;
                        command.Parameters.Add("@MaKH", SqlDbType.NVarChar, 10).Value = maKhachHang;
                        command.Parameters.Add("@MaCN", SqlDbType.NVarChar, 10).Value = maChiNhanh;

                        try
                        {
                            db.OpenConnection();
                            command.ExecuteNonQuery();
                            _orderCreated = true;
                            toggleAddProducts();
                        }
                        catch (SqlException ex)
                        {
                            // Xử lý lỗi, có thể hiển thị thông báo cho người dùng
                            MessageBox.Show("Đã xảy ra lỗi khi tạo đơn hàng: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            _orderCreated = false;
            toggleAddProducts();

            using (DBConnection db = new DBConnection())
            {
                using (SqlConnection con = db.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("spXoaDonHang", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@MaDH", SqlDbType.NVarChar, 10).Value = _currentOrderId;

                        try
                        {
                            db.OpenConnection();
                            command.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Lỗi khi xóa đơn hàng: " + ex.Message);
                        }
                    }
                }
            }

        }

        private string GenerateRandomID(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; // Define characters to use

            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            string randomID = "KH" + GenerateRandomID(8);
            string customerName = customerNameTextBox.Text;
            string customerPhone = customerPhoneTextBox.Text;
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
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            _customerNames = GetCustomerNames();
            customerComboBox.Items.Clear();
            customerComboBox.Items.AddRange(_customerNames.ToArray());
        }

        private void decreaseQuantityButton_Click(object sender, EventArgs e)
        {
            _currentQuantity--;
            productQuantityTextBox.Text = _currentQuantity.ToString();
        }

        private void increaseQuantityButton_Click(object sender, EventArgs e)
        {
            _currentQuantity++;
            productQuantityTextBox.Text = _currentQuantity.ToString();
        }

        private void addProductToOrderButton_Click(object sender, EventArgs e)
        {
            // Get the current order ID and quantity.
            string currentOrderId = _currentOrderId;
            int currentQuantity = _currentQuantity;

            // Get the selected product item.
            string productName = productItemComboBox.GetItemText(productItemComboBox.SelectedItem);
            string productItemId = null;
            foreach (var item in _productItems.Where(item => item.Key == productName))
            {
                productItemId = item.Value;
            }

            // Create a new SqlCommand object to call the spTaoChiTietDonHang stored procedure.
            using (DBConnection db = new DBConnection())
            {
                using (SqlConnection con = db.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("spTaoChiTietDonHang", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add the order ID, product ID, and quantity parameters.
                        command.Parameters.Add("@MaDH", SqlDbType.NVarChar, 10).Value = currentOrderId;
                        command.Parameters.Add("@MaMatHangSP", SqlDbType.NVarChar, 10).Value = productItemId;
                        command.Parameters.Add("@SoLuong", SqlDbType.Int).Value = currentQuantity;

                        try
                        {
                            db.OpenConnection();
                            command.ExecuteNonQuery();

                            // Show a message to the user indicating that the product item was added to the order.
                            MessageBox.Show("Đã thêm sản phẩm " + productName + " vào đơn hàng.");

                            OrderDetailsDTO orderDetail = new OrderDetailsDTO();
                            UpdateDescriptionAndPrice(productItemId);
                            orderDetail.OrderId = currentOrderId;
                            orderDetail.ProductItemId = productItemId;
                            orderDetail.ProductName = productName;
                            orderDetail.ProductDescription = _currentDescription;
                            orderDetail.Quantity = currentQuantity;
                            orderDetail.Price = _currentPrice;

                            _orderDetails.Add(orderDetail);
                            UpdateOrderDetailsPanel();
                        }
                        catch (SqlException ex)
                        {
                            // Handle the error.
                            MessageBox.Show("Đã xảy ra lỗi khi thêm sản phẩm vào đơn hàng: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void UpdateDescriptionAndPrice(string productItemId)
        {
            using (DBConnection db = new DBConnection())
            {
                using (SqlConnection con = db.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("spLayGiaSanPhamVaMoTa", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add the product ID parameter.
                        command.Parameters.Add("@MaMatHangSP", SqlDbType.NVarChar, 10).Value = productItemId;

                        try
                        {
                            db.OpenConnection();

                            // Execute the stored procedure and get the price and description of the product item.
                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                _currentPrice = reader.GetInt32(0);
                                _currentDescription = reader.GetString(1);

                            }
                            else
                            {
                                // Handle the error.
                                MessageBox.Show("Không tìm thấy sản phẩm với mã " + productItemId + ".");
                            }

                            reader.Close();
                        }
                        catch (SqlException ex)
                        {
                            // Handle the error.
                            MessageBox.Show("Đã xảy ra lỗi khi lấy giá và mô tả sản phẩm: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void UpdateOrderDetailsPanel()
        {
            flowLayoutPanel1.SuspendLayout();

            flowLayoutPanel1.Controls.Clear();

            foreach (OrderDetailsDTO orderDetailsDTO in _orderDetails)
            {
                var orderDetailsControl = new OrderDetailsControl(orderDetailsDTO);
                orderDetailsControl.OrderDetailsDeleted += DeleteOrderDetails;
                // Add the OrderDetailsControl user control to the FlowLayoutPanel control.
                flowLayoutPanel1.Controls.Add(orderDetailsControl);
            }

            flowLayoutPanel1.ResumeLayout();
        }

        private void DeleteOrderDetails(object? sender, string e)
        {
            using (DBConnection db = new DBConnection())
            {
                using (SqlConnection con = db.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("spXoaChiTietDonHang", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.Add("@MaDH", SqlDbType.VarChar, 10).Value = _currentOrderId;
                        command.Parameters.Add("@MaMatHangSP", SqlDbType.VarChar, 10).Value = e;

                        try
                        {
                            db.OpenConnection();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Order details deleted successfully!");

                            // Get the order details to delete.
                            var orderDetailsToDelete = _orderDetails.Where(od => od.OrderId == _currentOrderId && od.ProductItemId == e).FirstOrDefault();
                            // Delete the order details from the list.
                            _orderDetails.Remove(orderDetailsToDelete);
                            UpdateOrderDetailsPanel();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_currentOrderId == null)
            {
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            using (DBConnection db = new DBConnection())
            {
                using (SqlConnection con = db.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("spXoaDonHang", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@MaDH", SqlDbType.NVarChar, 10).Value = _currentOrderId;

                        try
                        {
                            db.OpenConnection();
                            command.ExecuteNonQuery();
                            this.DialogResult = DialogResult.Cancel;
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Lỗi khi xóa đơn hàng: " + ex.Message);
                            this.DialogResult = DialogResult.Cancel;
                        }
                    }
                }
            }
        }
    }
}
