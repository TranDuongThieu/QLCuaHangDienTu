using CuaHangDienTu.Models;
using CuaHangDienTu.Services;

namespace CuaHangDienTu.UI.Product
{
    public partial class ProductView : UserControl
    {
        public ProductView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            IProductService productService = new FakeProductService();
            List<Models.Product> products = productService.GetAllProducts();
            ProductCard[] listProduct = new ProductCard[products.Count];

            for (int i = 0; i < products.Count; i++)
            {
                ProductCard newProduct = new ProductCard(products[i].ProductName, products[i].Description, products[i].Price);
                listProduct[i] = newProduct;
                flowLayoutPanel1.Controls.Add(newProduct);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
