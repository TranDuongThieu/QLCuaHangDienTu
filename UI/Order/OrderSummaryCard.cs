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

        private void UpdateOrderSummaryCard()
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
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("spXoaDonHang", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@MaDH", SqlDbType.NVarChar, 10).Value = _selectedOrder.OrderId;

                        connection.Open();

                        command.ExecuteNonQuery();

                        MessageBox.Show("Đã xóa đơn hàng thành công!");
                        OnOrderDeleted(EventArgs.Empty);
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
