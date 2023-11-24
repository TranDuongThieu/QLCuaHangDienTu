using CuaHangDienTu.Models;
using CuaHangDienTu.UI.Order;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CuaHangDienTu.UI.Main
{
    public partial class OrderForm : UserControl
    {
        private List<OrderDetailsDTO> orderDetailsList;
        private FlowLayoutPanel flowLayoutPanel;
        public OrderForm()
        {
            InitializeComponent();
            flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Location = new Point(50, 110);
            flowLayoutPanel.Size = new Size(1000, 280);
            this.Controls.Add(flowLayoutPanel);
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            using (var fillInfo = new CreateOrderModalForm())
            {
                fillInfo.ShowDialog();
                if (GlobalVar.CurrentOrderId != null)
                {
                    orderTitleLabel.Text = "HÓA ĐƠN " + GlobalVar.CurrentOrderId;
                    HideAll();
                    orderTitleLabel.Visible = true;
                    deleteOrderButton.Visible = true;
                    createNewOrderButton.Visible = true;
                }
            }
        }

        private void HideAll()
        {
            noOrderLabel.Visible = false;
            createOrderInstructLabel.Visible = false;
            createOrderButton.Visible = false;
            orderTitleLabel.Visible = false;
            deleteOrderButton.Visible = false;
            createNewOrderButton.Visible = false;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            orderTitleLabel.Visible = false;
            deleteOrderButton.Visible = false;
            createNewOrderButton.Visible = false;
            orderSummaryCard1.Visible = false;
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBConnection db = new DBConnection())
                {
                    using (SqlConnection con = db.GetConnection())
                    {
                        using (SqlCommand command = new SqlCommand("spXoaDonHang", con))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Add("@MaDH", SqlDbType.NVarChar, 10).Value = GlobalVar.CurrentOrderId;

                            db.OpenConnection();
                            command.ExecuteNonQuery();
                            GlobalVar.CurrentOrderId = null;
                            orderTitleLabel.Text = GlobalVar.CurrentOrderId;
                            HideAll();
                            noOrderLabel.Visible = true;
                            createOrderInstructLabel.Visible = true;
                            createOrderButton.Visible = true;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi xóa đơn hàng: " + ex.Message);
            }
            HideDetails();
        }

        private void createNewOrderButton_Click(object sender, EventArgs e)
        {
            GlobalVar.CurrentOrderId = null;
            HideAll();
            noOrderLabel.Visible = true;
            createOrderInstructLabel.Visible = true;
            createOrderButton.Visible = true;
            HideDetails();
        }

        private List<OrderDetailsDTO> GetAllOrderDetails()
        {
            List<OrderDetailsDTO> orderDetailsDTOs = new List<OrderDetailsDTO>();
            try
            {
                using (DBConnection db = new DBConnection())
                {
                    using (SqlConnection connection = db.GetConnection())
                    {
                        using (SqlCommand command = new SqlCommand("spLayTatCaChiTietHoaDon", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@MaDH", GlobalVar.CurrentOrderId);
                            db.OpenConnection();
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                string orderId = reader.GetString("MaHoaDon");
                                string productItemId = reader.GetString("MaMatHang");
                                int quantity = reader.GetInt32("SoLuong");
                                string productName = reader.GetString("TenSP");
                                string productDescription = reader.GetString("MoTaSP");
                                int price = reader.GetInt32("Gia");
                                string imageLink = reader.GetString("HinhAnhSP");
                                OrderDetailsDTO orderDetails = new OrderDetailsDTO
                                {
                                    OrderId = orderId,
                                    ProductItemId = productItemId,
                                    Quantity = quantity,
                                    ProductName = productName,
                                    ProductDescription = productDescription,
                                    Price = price,
                                    ProductImagePath = imageLink
                                };
                                orderDetailsDTOs.Add(orderDetails);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi lấy chi tiết hóa đơn: " + ex.Message);
            }

            return orderDetailsDTOs;
        }

        private void DeleteOrderDetails(object? sender, string e)
        {
            try
            {
                using (DBConnection db = new DBConnection())
                {
                    using (SqlConnection con = db.GetConnection())
                    {
                        using (SqlCommand command = new SqlCommand("spXoaChiTietDonHang", con))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            // Add parameters
                            command.Parameters.Add("@MaDH", SqlDbType.VarChar, 10).Value = GlobalVar.CurrentOrderId;
                            command.Parameters.Add("@MaMatHangSP", SqlDbType.VarChar, 10).Value = e;


                            db.OpenConnection();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Order details deleted successfully!");

                            UpdateOrderDetails();
                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateOrderDetails()
        {
            flowLayoutPanel.SuspendLayout();
            flowLayoutPanel.Controls.Clear();
            orderDetailsList = GetAllOrderDetails();
            foreach (var orderDetails in orderDetailsList)
            {
                var orderDetailControl = new OrderDetailsControl(orderDetails, false);
                orderDetailControl.ShowDeleteButton();
                orderDetailControl.OrderDetailsDeleted += DeleteOrderDetails;
                flowLayoutPanel.Controls.Add(orderDetailControl);
            }
            flowLayoutPanel.ResumeLayout();
            flowLayoutPanel.Show();

            if (GlobalVar.CurrentOrderId == null)
            {
                orderSummaryCard1.Visible = false;
            }
            else
            {
                try
                {
                    using (DBConnection db = new DBConnection())
                    {
                        using (SqlConnection connection = db.GetConnection())
                        {
                            using (SqlCommand command = new SqlCommand("SELECT * FROM DON_HANG WHERE MADH = @MaDH", connection))
                            {
                                command.Parameters.AddWithValue("@MaDH", GlobalVar.CurrentOrderId);
                                db.OpenConnection();
                                SqlDataReader reader = command.ExecuteReader();
                                if (reader.Read())
                                {
                                    string maDH = reader.GetString("MaDH");
                                    string maKH = reader.GetString("MaKH");
                                    string maCN = reader.GetString("MaCN");
                                    int tongGiaTri = reader.GetInt32("TongGiaTri");
                                    DateTime ngayDatHang = reader.GetDateTime("NgayDatHang");
                                    OrderDTO orderDTO = new OrderDTO
                                    {
                                        OrderId = maDH,
                                        CustomerName = GetCustomerName(maKH),
                                        DepartmentName = GetDepartmentName(maCN),
                                        TotalValue = tongGiaTri,
                                        CreatedDate = ngayDatHang,
                                    };
                                    orderSummaryCard1.setSelectedOrder(orderDTO);
                                    orderSummaryCard1.UpdateOrderSummaryCard();
                                    orderSummaryCard1.DisableButtons();
                                }
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {

                }
                orderSummaryCard1.Visible = true;
            }
        }

        private string GetDepartmentName(string maCN)
        {
            string tenCN = null;
            try
            {
                using (DBConnection db = new DBConnection())
                {
                    using (SqlConnection connection = db.GetConnection())
                    {
                        using (SqlCommand command = new SqlCommand("SELECT TenCN FROM CHI_NHANH WHERE MaCN = @MaCN", connection))
                        {
                            command.Parameters.AddWithValue("@MaCN", maCN);
                            db.OpenConnection();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                tenCN = reader.GetString("TenCN");

                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Xảy ra lỗi khi lấy tên chi nhánh: " + ex.Message);
            }
            return tenCN;
        }

        private string GetCustomerName(string maKH)
        {
            string tenKH = null;
            try
            {
                using (DBConnection db = new DBConnection())
                {
                    using (SqlConnection connection = db.GetConnection())
                    {
                        using (SqlCommand command = new SqlCommand("SELECT HoTenKH FROM KHACH_HANG WHERE MaKH = @MaKH", connection))
                        {
                            command.Parameters.AddWithValue("@MaKH", maKH);
                            db.OpenConnection();
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                tenKH = reader.GetString(0);

                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Xảy ra lỗi khi lấy tên khách hàng: " + ex.Message);
            }
            return tenKH;
        }

        internal void ShowDetails()
        {
            flowLayoutPanel.Visible = true;
        }

        internal void HideDetails()
        {
            flowLayoutPanel.Visible = false;
        }
    }
}
