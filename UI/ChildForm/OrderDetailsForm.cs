using CuaHangDienTu.Models;
using CuaHangDienTu.UI.Order;

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
            _flowLayoutPanel.Location = new Point(40, 40);
            _flowLayoutPanel.Width = 660;
            _flowLayoutPanel.Height = 400;

            this.Controls.Add(this._flowLayoutPanel);

            List<OrderDetailsDTO> orderDetailsDTOs = new List<OrderDetailsDTO>();

            for (int i = 0; i < 10; i++)
            {
                var orderDetailsDTO = new OrderDetailsDTO();
                orderDetailsDTO.ProductName = "Product " + i;
                orderDetailsDTO.ProductDescription = "This is a product description.";
                orderDetailsDTO.Quantity = Random.Shared.Next(1, 10);
                orderDetailsDTO.ProductImagePath = "https://example.com/product_image.jpg";
                orderDetailsDTOs.Add(orderDetailsDTO);
            }

            _flowLayoutPanel.SuspendLayout();

            foreach (OrderDetailsDTO orderDetailsDTO in orderDetailsDTOs)
            {
                var orderDetailsControl = new OrderDetailsControl(orderDetailsDTO);
                // Add the OrderDetailsControl user control to the FlowLayoutPanel control.
                _flowLayoutPanel.Controls.Add(orderDetailsControl);
            }

            _flowLayoutPanel.ResumeLayout();

        }
    }
}
