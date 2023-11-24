using CuaHangDienTu.Models;

namespace CuaHangDienTu.UI.Order
{
    public partial class OrderDetailsControl : UserControl, IDisposable
    {
        private OrderDetailsDTO _orderDetailsDTO;
        private Image productImage;
        public event EventHandler<string> OrderDetailsDeleted;

        public OrderDetailsControl(OrderDetailsDTO orderDetailsDTO, bool canEdit = true)
        {
            InitializeComponent();
            _orderDetailsDTO = orderDetailsDTO;
            UpdateOrderDetailsControlDisplay();
            if (!canEdit)
            {
                productQuantityTextbox.Enabled = false;
                increaseQuantityButton.Visible = false;
                decreaseQuantityButton.Visible = false;
                deleteButton.Visible = false;
            }
        }

        private void UpdateOrderDetailsControlDisplay()
        {
            productNameLabel.Text = _orderDetailsDTO.ProductName;
            productDescriptionLabel.Text = _orderDetailsDTO.ProductDescription;
            productQuantityTextbox.Text = _orderDetailsDTO.Quantity.ToString();
            int total = _orderDetailsDTO.Price * _orderDetailsDTO.Quantity;
            calculatedValue.Text = _orderDetailsDTO.Price + " x " + _orderDetailsDTO.Quantity + " = " + total;
        }

        private void increaseQuantityButton_Click(object sender, EventArgs e)
        {
            _orderDetailsDTO.Quantity++;
            UpdateOrderDetailsControlDisplay();
        }

        private void decreaseQuantityButton_Click(object sender, EventArgs e)
        {
            _orderDetailsDTO.Quantity--;
            UpdateOrderDetailsControlDisplay();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            OrderDetailsDeleted?.Invoke(this, _orderDetailsDTO.ProductItemId);
        }

        public void Dispose()
        {
            OrderDetailsDeleted = null; // Unregister the event handler
        }

        public void ShowDeleteButton()
        {
            this.deleteButton.Visible = true;
        }

        private void OrderDetailsControl_Load(object sender, EventArgs e)
        {
            try
            {
                // Get the file path from the cell
                string filePath = _orderDetailsDTO.ProductImagePath;

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
