using CuaHangDienTu.Models;
using CuaHangDienTu.UI.ChildForm;
using CuaHangDienTu.UI.Order;
using Microsoft.Data.SqlClient;

namespace CuaHangDienTu.UI.Admin
{
    public partial class Admin_QLHoaDon : UserControl
    {
        private DataGridView _orderDataGridView;
        private OrderSummaryCard _orderSummaryCard;
        private List<OrderDTO> _orders;
        private Button _addOrderButton;
        public List<OrderDTO> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }
        public Admin_QLHoaDon()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
        public void InitializeFakeOrderData()
        {
            _orders = new List<OrderDTO>();
            for (int i = 0; i < 10; i++)
            {
                var orderDTO = new OrderDTO();
                orderDTO.OrderId = Guid.NewGuid().ToString();
                orderDTO.CustomerName = Random.Shared.Next(100, 1000).ToString();
                orderDTO.DepartmentName = Random.Shared.Next(100, 1000).ToString();
                orderDTO.TotalValue = Random.Shared.Next(10000, 100000);
                orderDTO.CreatedDate = DateTime.Now.AddDays(-Random.Shared.Next(1, 30));
                _orders.Add(orderDTO);
                Orders = _orders;
            }
        }

        private List<OrderDTO> GetAllOrdersDTO()
        {
            List<OrderDTO> orderDTOs = new List<OrderDTO>();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM vwTatCaDonHang", connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        OrderDTO orderDTO = new OrderDTO();
                        orderDTO.OrderId = reader["MaDH"].ToString();
                        orderDTO.CustomerName = reader["TenKhachHang"].ToString();
                        orderDTO.DepartmentName = reader["TenChiNhanh"].ToString();
                        orderDTO.TotalValue = int.Parse(reader["TongGiaTri"].ToString());
                        orderDTO.CreatedDate = reader.GetDateTime(reader.GetOrdinal("NgayDatHang"));
                        orderDTOs.Add(orderDTO);
                    }
                }
            }

            return orderDTOs;
        }


        private void Admin_QLHoaDon_Load(object sender, EventArgs e)
        {
            //InitializeFakeOrderData();
            _orders = GetAllOrdersDTO();
            _orderDataGridView = new DataGridView();
            _orderDataGridView.Location = new Point(40, 60);
            _orderDataGridView.Width = 530;
            _orderDataGridView.Height = 320;
            _orderDataGridView.MultiSelect = false;
            _orderDataGridView.DataSource = Orders;
            this.Controls.Add(_orderDataGridView);

            _orderSummaryCard = new OrderSummaryCard();
            _orderSummaryCard.Location = new Point(550, 60);
            this.Controls.Add(_orderSummaryCard);

            _addOrderButton = new Button();
            _addOrderButton.Text = "Tạo hóa đơn mới";
            _addOrderButton.Location = new Point(0, 0);


            _orderDataGridView.SelectionChanged += OrderDataGridView_SelectionChanged;
            _addOrderButton.Click += _addOrderButton_Click;
            _orderSummaryCard.OrderDeleted += UpdateGridView;

        }

        private void UpdateGridView(object sender, EventArgs e)
        {
            _orders = GetAllOrdersDTO();
            _orderDataGridView.DataSource = Orders;
        }

        private void _addOrderButton_Click(object? sender, EventArgs e)
        {

        }

        private void OrderDataGridView_SelectionChanged(object? sender, EventArgs e)
        {
            int rowIndex = _orderDataGridView.CurrentCell.RowIndex;
            OrderDTO selectedOrder = (OrderDTO)_orderDataGridView.Rows[rowIndex].DataBoundItem;
            _orderSummaryCard.setSelectedOrder(selectedOrder);
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            using (var f = new AddOrderForm())
            {
                f.ShowDialog();
            }
        }
    }
}
