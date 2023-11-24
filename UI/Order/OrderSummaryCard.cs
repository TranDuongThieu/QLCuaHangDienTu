using CuaHangDienTu.Models;
using CuaHangDienTu.UI.ChildForm;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CuaHangDienTu.UI.Order
{
    public partial class OrderSummaryCard : UserControl
    {
        private OrderDTO _selectedOrder;
        public event EventHandler OrderDeleted;

        public OrderSummaryCard()
        {
            InitializeComponent();
        }

        public void setSelectedOrder(OrderDTO selectedOrder)
        {
            _selectedOrder = selectedOrder;
            UpdateOrderSummaryCard();
        }

        public void DisableButtons()
        {
            deleteOrderButton.Visible = false;
            viewOrderDetailsButton.Visible = false;
        }

        public void UpdateOrderSummaryCard()
        {
            if (_selectedOrder != null)
            {
                orderIdLabel.Text = _selectedOrder.OrderId;
                customerNameLabel.Text = _selectedOrder.CustomerName;
                departmentNameLabel.Text = _selectedOrder.DepartmentName;
                orderValueLabel.Text = _selectedOrder.TotalValue.ToString();
                orderCreatedDateLabel.Text = _selectedOrder.CreatedDate.ToString();
            }
        }

        private void viewOrderDetailsButton_Click(object sender, EventArgs e)
        {
            using (var f = new OrderDetailsForm(_selectedOrder.OrderId))
            {
                f.ShowDialog();
            }
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

                            command.Parameters.Add("@MaDH", SqlDbType.NVarChar, 10).Value = _selectedOrder.OrderId;

                            db.OpenConnection();

                            command.ExecuteNonQuery();

                            MessageBox.Show("Đã xóa đơn hàng thành công!");
                            OnOrderDeleted(EventArgs.Empty);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
        }

        protected virtual void OnOrderDeleted(EventArgs e)
        {
            OrderDeleted?.Invoke(this, e);
        }

    }
}
