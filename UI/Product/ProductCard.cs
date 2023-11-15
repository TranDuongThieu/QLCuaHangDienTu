using CuaHangDienTu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
