using CuaHangDienTu.Models;
using CuaHangDienTu.UI.ChildForm;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CuaHangDienTu.UI.Admin
{
    public partial class Admin_QLDNH : UserControl
    {
        private ImportOrderModel _currentImportOrder = new ImportOrderModel();
        private DateTime _currentImportOrderCreatedDate;

        public Admin_QLDNH()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private List<string> GetDepartmentNames()
        {
            List<string> departmentNames = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("SELECT * FROM vwTenChiNhanh", connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string tenChiNhanh = reader.GetString("TenChiNhanh");
                                departmentNames.Add(tenChiNhanh);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi lấy tên chi nhánh: " + ex.Message);
            }

            return departmentNames;
        }

        private void UpdateDepartmentComboBox()
        {
            departmentComboBox.Items.Clear();
            foreach (string departmentName in GetDepartmentNames())
            {
                departmentComboBox.Items.Add(departmentName);
            }
        }

        private List<Distributor> GetDistributors()
        {
            List<Distributor> distributors = new List<Distributor>();

            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("SELECT * FROM vwLayTatCaNhaCungCap", connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string maNCC = reader.GetString("MaNCC");
                                string tenNCC = reader.GetString("TenNCC");
                                string diachi = reader.GetString("DiaChi");
                                string soDienThoai = reader.GetString("SoDienThoai");

                                Distributor distributor = new Distributor();
                                distributor.DistributorId = maNCC;
                                distributor.DistributorName = tenNCC;
                                distributor.DistributorAddress = diachi;
                                distributor.DistributorPhone = soDienThoai;

                                distributors.Add(distributor);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi lấy nhà cung cấp: " + ex.Message);
            }

            return distributors;
        }

        private void UpdateDistributorComboBox()
        {
            distributorComboBox.Items.Clear();
            List<Distributor> distributors = GetDistributors();
            foreach (Distributor distributor in distributors)
            {
                distributorComboBox.Items.Add(distributor.DistributorName);
            }
        }

        private List<ImportOrderModel> GetImportOrders()
        {
            List<ImportOrderModel> importOrders = new List<ImportOrderModel>();
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("SELECT * FROM vwLayTatCaDonNhapHang", connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string maDNH = reader["MaDNN"].ToString();
                                string maNhaCungCap = reader["MaNCC"].ToString();
                                string maChiNhanh = reader["MaCN"].ToString();
                                int tongGiaTri = reader.GetInt32("TongGiaTri");
                                DateTime ngayNhapHang = reader.GetDateTime("NgayNhapHang");


                                ImportOrderModel importOrder = new ImportOrderModel();
                                importOrder.ImportOrderId = maDNH;
                                importOrder.DistributorId = maNhaCungCap;
                                importOrder.DepartmentId = maChiNhanh;
                                importOrder.TotalValue = tongGiaTri;
                                importOrder.CreatedDate = ngayNhapHang;

                                importOrders.Add(importOrder);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi lấy đơn nhập hàng: " + ex.Message);
            }
            return importOrders;
        }

        private string GetDeparmentId(string deparmentName)
        {
            string maChiNhanh = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("SELECT dbo.fnLayMaChiNhanhTuTenChiNhanh(@TenChiNhanh)", connection))
                    {
                        command.Parameters.AddWithValue("@TenChiNhanh", deparmentName);
                        connection.Open();
                        maChiNhanh = (string)command.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi gọi hàm: " + ex.Message);
            }
            return maChiNhanh;
        }

        private string GetDistributorId(string distributorName)
        {
            string maNCC = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("SELECT dbo.fnLayMaNhaCungCapTuTenNhaCungCap(@TenNCC)", connection))
                    {
                        command.Parameters.AddWithValue("@TenNCC", distributorName);
                        connection.Open();
                        maNCC = (string)command.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi gọi hàm: " + ex.Message);
            }
            return maNCC;
        }

        private void UpdateImportOrderDataGridView()
        {
            importOrderDataGridView.DataSource = GetImportOrders();
        }

        private void Admin_QLDNH_Load(object sender, EventArgs e)
        {
            UpdateImportOrderDataGridView();
            UpdateImportOrderDetailsPanel();
            UpdateDistributorComboBox();
            UpdateDepartmentComboBox();
            distributorComboBox.SelectedText = "--Chọn nhà cung cấp--";
            departmentComboBox.SelectedText = "--Chọn chi nhánh--";
            importOrderDataGridView.SelectionChanged += ImportOrderDataGridView_SelectionChanged;

        }

        private void UpdateImportOrderDetailsPanel()
        {
            if (_currentImportOrder == null) return;
            importOrderIdLabel.Text = _currentImportOrder.ImportOrderId;
            distributorIdLabel.Text = _currentImportOrder.DistributorId;
            departmentIdLabel.Text = _currentImportOrder.DepartmentId;
            totalValueLabel.Text = _currentImportOrder.TotalValue.ToString();
            createdDateLabel.Text = _currentImportOrder.CreatedDate.ToString();
        }

        private void ImportOrderDataGridView_SelectionChanged(object? sender, EventArgs e)
        {
            int rowIndex = importOrderDataGridView.CurrentCell.RowIndex;
            ImportOrderModel importOrder = (ImportOrderModel)importOrderDataGridView.Rows[rowIndex].DataBoundItem;
            _currentImportOrder = importOrder;
            UpdateImportOrderDetailsPanel();
        }

        private void deleteImportOrderButton_Click(object sender, EventArgs e)
        {
            DeleteImportOrderButton(_currentImportOrder.ImportOrderId);
        }

        private void DeleteImportOrderButton(string importOrderId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("spXoaDonNhapHang", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MaDNH", importOrderId);
                        connection.Open();
                        command.ExecuteNonQuery();
                        UpdateImportOrderDataGridView();
                        UpdateImportOrderDetailsPanel();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi xóa đơn nhập hàng: " + ex.Message);
            }
        }

        private void viewImportOrderDetailsButton_Click(object sender, EventArgs e)
        {

        }

        private string GenerateRandomID(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; // Define characters to use

            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        private void CreateImportOrder(string maNCC, string maChiNhanh)
        {
            string maDNH = "DNH" + GenerateRandomID(7); // Tạo mã đơn hàng ngẫu nhiên
            // Thực hiện kết nối đến cơ sở dữ liệu
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("spTaoDonNhapHang", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cần thiết cho thủ tục
                        command.Parameters.Add("@MaDNH", SqlDbType.NVarChar, 10).Value = maDNH;
                        command.Parameters.Add("@TongGiaTri", SqlDbType.Int).Value = 0;
                        command.Parameters.Add("@NgayNhapHang", SqlDbType.Date).Value = DateTime.Today; // Ngày hôm nay
                        _currentImportOrderCreatedDate = DateTime.Today;
                        command.Parameters.Add("@MaNCC", SqlDbType.NVarChar, 10).Value = maNCC;
                        command.Parameters.Add("@MaCN", SqlDbType.NVarChar, 10).Value = maChiNhanh;


                        connection.Open();
                        command.ExecuteNonQuery();
                        UpdateImportOrderDataGridView();
                        OpenAddImportOrderDetailsForm(maDNH);
                        //_orderCreated = true;
                        //toggleAddProducts();

                    }
                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi, có thể hiển thị thông báo cho người dùng
                MessageBox.Show("Đã xảy ra lỗi khi tạo đơn hàng: " + ex.Message);
            }
        }

        private void OpenAddImportOrderDetailsForm(string maDNH)
        {
            using (var f = new AddImportOrderForm(maDNH))
            {
                f.ShowDialog();
            }
            UpdateImportOrderDataGridView();
        }

        private void createImportOrderButton_Click(object sender, EventArgs e)
        {

            CreateImportOrder(GetDistributorId(distributorComboBox.GetItemText(distributorComboBox.SelectedItem)), GetDeparmentId(departmentComboBox.GetItemText(departmentComboBox.SelectedItem)));
        }
    }
}
