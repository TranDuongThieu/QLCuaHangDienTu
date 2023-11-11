﻿using CuaHangDienTu.Models;

namespace CuaHangDienTu.UI.Order
{
    public partial class OrderDetailsControl : UserControl
    {
        private OrderDetailsDTO _orderDetailsDTO;
        private Image productImage;
        public event EventHandler<string> OrderDetailsDeleted;

        public OrderDetailsControl(OrderDetailsDTO orderDetailsDTO)
        {
            InitializeComponent();
            _orderDetailsDTO = orderDetailsDTO;
            UpdateOrderDetailsControlDisplay();
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
    }
}