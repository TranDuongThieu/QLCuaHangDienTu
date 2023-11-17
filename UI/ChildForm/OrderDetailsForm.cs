using CuaHangDienTu.Models;
using CuaHangDienTu.UI.Order;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CuaHangDienTu.UI.ChildForm
{
    public partial class OrderDetailsForm : Form
    {
        private FlowLayoutPanel _flowLayoutPanel;
        private string _orderId;
        public OrderDetailsForm(string orderId)
        {
            InitializeComponent();
            _orderId = orderId;
        }

        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {
            _flowLayoutPanel = new FlowLayoutPanel();
            _flowLayoutPanel.AutoScroll = true;
            _flowLayoutPanel.Location = new Point(100, 40);
            _flowLayoutPanel.Width = 660;
            _flowLayoutPanel.Height = 400;

            this.Controls.Add(this._flowLayoutPanel);

            List<OrderDetailsDTO> orderDetailsDTOs = new List<OrderDetailsDTO>();

            orderDetailsDTOs = GetOrderDetailsListOfOrder(_orderId);

            _flowLayoutPanel.SuspendLayout();

            foreach (OrderDetailsDTO orderDetailsDTO in orderDetailsDTOs)
            {
                var orderDetailsControl = new OrderDetailsControl(orderDetailsDTO, false);
                // Add the OrderDetailsControl user control to the FlowLayoutPanel control.
                _flowLayoutPanel.Controls.Add(orderDetailsControl);
            }

            _flowLayoutPanel.ResumeLayout();

        }

        private List<OrderDetailsDTO> GetOrderDetailsListOfOrder(string orderId)
        {
            List<OrderDetailsDTO> details = new List<OrderDetailsDTO>();
            try
            {
                using (DBConnection db = new DBConnection())
                {
                    using (SqlConnection con = db.GetConnection())
                    {
                        using (SqlCommand command = new SqlCommand("GetChiTietDonHang", con))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@MaDH", orderId);

                            db.OpenConnection();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string maDH = reader["MaDH"].ToString();
                                    string maMatHangSP = reader["MaMatHangSP"].ToString();
                                    int soLuong = reader.GetInt32(reader.GetOrdinal("SoLuong"));
                                    using (DBConnection db2 = new DBConnection())
                                    {
                                        using (SqlConnection con2 = db.GetConnection())
                                        {
                                            using (SqlCommand nestedCommand = new SqlCommand("spLayGiaSanPhamVaMoTa", con2))
                                            {
                                                nestedCommand.CommandType = CommandType.StoredProcedure;
                                                nestedCommand.Parameters.AddWithValue("@MaMatHangSP", maMatHangSP);
                                                db2.OpenConnection();
                                                using (SqlDataReader nestedReader = nestedCommand.ExecuteReader())
                                                {
                                                    if (nestedReader.Read())
                                                    {
                                                        int giaSP = nestedReader.GetInt32(nestedReader.GetOrdinal("Gia"));
                                                        string motaSP = nestedReader.GetString(nestedReader.GetOrdinal("MoTaSP"));
                                                        string tenSP = nestedReader.GetString(nestedReader.GetOrdinal("TenSP"));
                                                        OrderDetailsDTO orderDetailsDTO = new OrderDetailsDTO();
                                                        orderDetailsDTO.OrderId = orderId;
                                                        orderDetailsDTO.ProductItemId = maMatHangSP;
                                                        orderDetailsDTO.ProductDescription = motaSP;
                                                        orderDetailsDTO.ProductName = tenSP;
                                                        orderDetailsDTO.Quantity = soLuong;
                                                        orderDetailsDTO.Price = giaSP;
                                                        details.Add(orderDetailsDTO);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi lấy chi tiết đơn hàng: " + ex.Message);
            }
            return details;
        }
    }
}
