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
    public partial class DetailProduct : Form
    {
        ProductModel product;
        public DetailProduct(ProductModel product)
        {
            InitializeComponent();
            this.product = product;
        }

        private void DetailProduct_Load(object sender, EventArgs e)
        {
            name.Text = product.TenSP;
            gia.Text = product.Gia.ToString();
            mota.Text = product.MoTa.ToString();
            soluong.Text = product.SoLuong.ToString();
            daban.Text = product.DaBan.ToString();
            baohanh.Text = product.ThoiHanBaoHanh.ToString();
            try
            {
                // Get the file path from the cell
                string filePath = product.HinhAnh;

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
