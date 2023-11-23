using CuaHangDienTu.Models;
using CuaHangDienTu.UI.Main;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CuaHangDienTu.UI.Product
{
    public partial class ProductCard : UserControl
    {
        ProductModel product;
        public ProductCard(ProductModel product)
        {
            this.product = product;
            InitializeComponent();
        }

        private void ProductCard_Load(object sender, EventArgs e)
        {
            lb_name.Text = product.TenSP;
            lb_price.Text = product.Gia.ToString();

            try
            {
                // Get the file path from the cell
                string filePath = product.HinhAnh;

                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Load the image from the file
                    Image img = Image.FromFile(filePath);
                    pic_product.Image = img;
                }
                else
                {
                    // Handle the case where the file does not exist
                    pic_product.Image = null; // Set a default image or handle the error in a different way
                }
            }
            catch (Exception ex)
            {
                // Handle other exceptions if necessary
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lb_name_Click(object sender, EventArgs e)
        {

        }

        private void productDetailsButton_Click(object sender, EventArgs e)
        {
            DetailProduct detailProduct = new DetailProduct(product);
            detailProduct.Show();
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            if (GlobalVar.CurrentOrderId == null)
            {
                MessageBox.Show("Vui lòng qua tab hóa đơn để tạo hóa đơn trước.");
            }
            else
            {
                int currentQuantity = 0;

                using (var quantityForm = new ChooseQuantityForm())
                {
                    quantityForm.ShowDialog();
                    if (quantityForm.CurrentQuantity == null || quantityForm.CurrentQuantity <= 0)
                    {
                        MessageBox.Show("Số lượng sản phẩm không hợp lệ");
                        return;
                    }
                    currentQuantity = quantityForm.CurrentQuantity;
                }

                // Get the current order ID and quantity.
                string currentOrderId = GlobalVar.CurrentOrderId;

                // Get the selected product item.
                string productName = product.TenSP;
                string productItemId = product.MaMH;
                try
                {

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


                                db.OpenConnection();
                                command.ExecuteNonQuery();

                                // Show a message to the user indicating that the product item was added to the order.
                                MessageBox.Show("Đã thêm sản phẩm " + productName + " vào đơn hàng.");

                                product.SoLuong -= currentQuantity;
                                product.DaBan += currentQuantity;

                            }

                        }
                    }
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
