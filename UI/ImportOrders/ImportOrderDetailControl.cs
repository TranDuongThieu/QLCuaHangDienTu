﻿using CuaHangDienTu.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CuaHangDienTu.UI.ImportOrder
{
    public partial class ImportOrderDetailControl : UserControl, IDisposable
    {
        public event EventHandler<string> ImportOrderDetailDeleted;
        private ImportOrderDetailDTO _importOrderDetail;
        private bool _canDel = true;
        public ImportOrderDetailControl(ImportOrderDetailDTO importOrderDetailDTO, bool canDel = true)
        {
            InitializeComponent();
            _importOrderDetail = importOrderDetailDTO;
            _canDel = canDel;
            if (!_canDel)
            {
                button2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (DBConnection db = new DBConnection())
            {
                using (SqlConnection con = db.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("spXoaChiTietDonNhapHang", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.Add("@MaDNH", SqlDbType.VarChar, 10).Value = _importOrderDetail.ImportOrderId;
                        command.Parameters.Add("@MaMatHangSP", SqlDbType.VarChar, 10).Value = _importOrderDetail.ProductItemId;

                        try
                        {
                            db.OpenConnection();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Order details deleted successfully!");

                            // Get the order details to delete.
                            //var orderDetailsToDelete = _orderDetails.Where(od => od.OrderId == _currentOrderId && od.ProductItemId == e).FirstOrDefault();
                            // Delete the order details from the list.
                            //_orderDetails.Remove(orderDetailsToDelete);
                            //UpdateOrderDetailsPanel();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }
            }
            ImportOrderDetailDeleted?.Invoke(this, _importOrderDetail.ProductItemId);
        }

        public void Dispose()
        {
            ImportOrderDetailDeleted = null;
        }

        public void UnRegister()
        {
            ImportOrderDetailDeleted = null;
        }

        private void ImportOrderDetailControl_Load(object sender, EventArgs e)
        {
            productNameLabel.Text = _importOrderDetail.ProductName;
            productDescriptionLabel.Text = _importOrderDetail.ProductDescription;
            quantityLabel.Text = "Số lượng: " + _importOrderDetail.Quantity.ToString();
            priceLabel.Text = "Giá: " + (_importOrderDetail.Quantity * _importOrderDetail.Price).ToString();
            try
            {
                // Get the file path from the cell
                string filePath = _importOrderDetail.ProductImageLink;

                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Load the image from the file
                    Image img = Image.FromFile(filePath);
                    pictureBox1.Image = img;
                }
                else
                {
                    // Handle the case where the file does not exist
                    pictureBox1.Image = null; // Set a default image or handle the error in a different way
                }
            }
            catch (Exception ex)
            {
                // Handle other exceptions if necessary
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
