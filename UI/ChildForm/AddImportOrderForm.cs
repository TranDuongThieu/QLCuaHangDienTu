using CuaHangDienTu.Models;
using CuaHangDienTu.UI.ImportOrder;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CuaHangDienTu.UI.ChildForm
{
    public partial class AddImportOrderForm : Form
    {
        private string _importOrderId;
        private int _currentQuantity = 0;
        private int _currentPrice;
        private string _currentDescription;
        private string _currentProductItemId;
        private List<ImportOrderDetailDTO> _importOrderDetailDTOs;
        public AddImportOrderForm(string maDNH)
        {
            InitializeComponent();
            _importOrderId = maDNH;
        }

        private void AddImportOrderForm_Load(object sender, EventArgs e)
        {
            importOrderIdLabel.Text += " " + _importOrderId;
            _importOrderDetailDTOs = new List<ImportOrderDetailDTO>();
            UpdateProductComboBox();
            productItemCombobox.SelectedText = "--Chọn sản phẩm--";
            quantityTextBox.Text = _currentQuantity.ToString();
        }

        private void UpdateProductComboBox()
        {
            productItemCombobox.Items.Clear();
            foreach (string productName in GetProductNames())
            {
                productItemCombobox.Items.Add(productName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void deleteImportOrder_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("spXoaDonNhapHang", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cần thiết cho thủ tục
                        command.Parameters.Add("@MaDNH", SqlDbType.NVarChar, 10).Value = _importOrderId;

                        connection.Open();
                        command.ExecuteNonQuery();

                        //_orderCreated = true;
                        //toggleAddProducts();
                        DialogResult = DialogResult.OK;

                    }
                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi, có thể hiển thị thông báo cho người dùng
                MessageBox.Show("Đã xảy ra lỗi khi xóa đơn hàng: " + ex.Message);
            }
        }

        private List<string> GetProductNames()
        {
            List<string> productNames = new List<string>();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                string query = "SELECT MaMatHangSP, TenSP FROM vwMatHangSanPham";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string itemName = reader.GetString("TenSP");

                        productNames.Add(itemName);
                    }
                }
            }
            return productNames;
        }

        private void decreaseQuantityButton_Click(object sender, EventArgs e)
        {
            _currentQuantity--;
            quantityTextBox.Text = _currentQuantity.ToString();
        }

        private void increaseQuantityButton_Click(object sender, EventArgs e)
        {
            _currentQuantity++;
            quantityTextBox.Text = _currentQuantity.ToString();
        }

        private void GetProductDetails(string productName)
        {
            string productItemId = GetProductItemId(productName);
            _currentProductItemId = productItemId;
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                using (SqlCommand command = new SqlCommand("spLayGiaSanPhamVaMoTa", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add the product ID parameter.
                    command.Parameters.Add("@MaMatHangSP", SqlDbType.NVarChar, 10).Value = productItemId;

                    try
                    {
                        connection.Open();

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

        private string GetProductItemId(string productName)
        {
            string maSP = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("SELECT dbo.fnLayMaSanPhamTuTenSanPham(@TenSP)", connection))
                    {
                        command.Parameters.AddWithValue("@TenSP", productName);
                        connection.Open();
                        maSP = (string)command.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi gọi hàm: " + ex.Message);
            }
            return maSP;
        }



        private void addProductItemButton_Click(object sender, EventArgs e)
        {
            ImportOrderDetailDTO importOrderDetailDTO = new ImportOrderDetailDTO();
            importOrderDetailDTO.ProductItemId = _currentProductItemId;
            importOrderDetailDTO.ProductName = productItemCombobox.GetItemText(productItemCombobox.SelectedItem);
            GetProductDetails(productItemCombobox.GetItemText(productItemCombobox.SelectedItem));
            importOrderDetailDTO.ProductDescription = _currentDescription;
            importOrderDetailDTO.Price = int.Parse(importPriceTextBox.Text);
            importOrderDetailDTO.Quantity = _currentQuantity;

            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("spTaoChiTietDonNhapHang", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MaDNH", _importOrderId);
                        command.Parameters.AddWithValue("@MaMatHangSP", _currentProductItemId);
                        command.Parameters.AddWithValue("@SoLuong", _currentQuantity);
                        command.Parameters.AddWithValue("@GiaNhap", importPriceTextBox.Text);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                _importOrderDetailDTOs.Add(importOrderDetailDTO);
                UpdateFlowLayoutPanel();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi tạo chi tiết đơn nhập hàng: " + ex.Message);
            }


        }

        private void UpdateFlowLayoutPanel()
        {
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.Controls.Clear();

            foreach (ImportOrderDetailDTO importOrderDetailDTO in _importOrderDetailDTOs)
            {
                importOrderDetailDTO.ImportOrderId = _importOrderId;
                importOrderDetailDTO.ProductItemId = _currentProductItemId;
                var orderDetailsControl = new ImportOrderDetailControl(importOrderDetailDTO);
                orderDetailsControl.ImportOrderDetailDeleted += UpdateImportOrderDetailLayout;
                // Add the OrderDetailsControl user control to the FlowLayoutPanel control.
                flowLayoutPanel1.Controls.Add(orderDetailsControl);
            }

            flowLayoutPanel1.ResumeLayout();
        }

        private void UpdateImportOrderDetailLayout(object? sender, string e)
        {
            var importOrderDetailsToDelete = _importOrderDetailDTOs.Where(od => od.ImportOrderId == _importOrderId && od.ProductItemId == e).FirstOrDefault();
            // Delete the order details from the list.
            _importOrderDetailDTOs.Remove(importOrderDetailsToDelete);
            UpdateFlowLayoutPanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }


    }
}
