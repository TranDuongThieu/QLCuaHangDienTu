using CuaHangDienTu.Models;

using Microsoft.Data.SqlClient;

namespace CuaHangDienTu.UI.Product
{
    public partial class ProductView : UserControl
    {
        string madanhmuc;
        string sqlConnectionString = Properties.Settings.Default.connectionString;
        private class DanhMuc
        {
            public string maDanhMuc;
            public string tenDanhMuc;
        }
        public ProductView(string madanhmuc)
        {
            InitializeComponent();
            this.madanhmuc = madanhmuc;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private List<DanhMuc> getMaDanhMuc()
        {
            List<DanhMuc> listMaDanhMuc = new List<DanhMuc>();
            using (SqlConnection con1 = new SqlConnection(sqlConnectionString))
            {
                con1.Open();

                // Create a SqlCommand object to execute the function
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.LayMaDanhMucTuDanhMucCha(@InputMaDanhMuc)", con1))
                {
                    // Add the input parameter to the command
                    cmd.Parameters.AddWithValue("@InputMaDanhMuc", madanhmuc);

                    // Execute the command and retrieve the results
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DanhMuc danhmuc = new DanhMuc();
                            danhmuc.maDanhMuc = reader["MaDanhMuc"].ToString();
                            danhmuc.tenDanhMuc = reader["TenDanhMuc"].ToString();
                            listMaDanhMuc.Add(danhmuc);
                        }
                    }
                }
                con1.Close();
            }
            return listMaDanhMuc;
        }


        private void ProductView_Load(object sender, EventArgs e)
        {
            List<DanhMuc> listMaDanhmuc = getMaDanhMuc();
            foreach (DanhMuc danhmuc in listMaDanhmuc)
            {
                // Create a new tab with the name from the list
                TabPage newTab = new TabPage(danhmuc.tenDanhMuc);
                guna2TabControl1.TabPages.Add(newTab);
                ProductContrainer productContainer = new ProductContrainer(madanhmuc, danhmuc.maDanhMuc);
                newTab.Controls.Add(productContainer);


            }
        }


    }
    //IProductService productService = new FakeProductService();
    //List<Models.Product> products = productService.GetAllProducts();
    //ProductCard[] listProduct = new ProductCard[products.Count];

    //for (int i = 0; i < products.Count; i++)
    //{
    //    ProductCard newProduct = new ProductCard(products[i].ProductName, products[i].Description, products[i].Price);

    //    listProduct[i] = newProduct;
    //    flowLayoutPanel1.Controls.Add(newProduct);
    //}



}
