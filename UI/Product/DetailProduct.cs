using CuaHangDienTu.Models;
using CuaHangDienTu.UI.Main;
using Microsoft.Data.SqlClient;
using System.Data;

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
        string sqlConnectionString = Properties.Settings.Default.connectionString;

        public class ThongSo
        {
            public string maThongSo { get; set; }
            public string loaiThongSo { get; set; }
            public string giaTriThongSo { get; set; }

            public ThongSo(string maThongSo, string loaiThongSo, string giaTriThongSo)
            {
                this.maThongSo = maThongSo;
                this.loaiThongSo = loaiThongSo;
                this.giaTriThongSo = giaTriThongSo;
            }
        }

        private List<ThongSo> LayThongSoMatHang(string maMatHangSP)
        {
            List<ThongSo> listThongSo = new List<ThongSo>();

            using (DBConnection db = new DBConnection())
            {
                using (SqlConnection con = db.GetConnection())
                {
                    db.OpenConnection();

                    string query = "SELECT * FROM dbo.layThongSoMatHangTuMaMatHang(@MaMatHangSP)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Thêm tham số cho hàm
                        cmd.Parameters.AddWithValue("@MaMatHangSP", maMatHangSP);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string maThongSo = reader["MaThongSoKiThuat"].ToString();
                                string loaiThongSo = reader["MaLoaiThongSo"].ToString();
                                string giaTriThongSo = reader["GiaTriThongSo"].ToString();
                                ThongSo thongso = new ThongSo(maThongSo, loaiThongSo, giaTriThongSo);
                                listThongSo.Add(thongso);
                            }
                        }
                    }

                    return listThongSo;
                }
            }
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

            List<ThongSo> listThongSo = LayThongSoMatHang(product.MaMH);

            int index = 0;
            foreach (ThongSo thongso in listThongSo)
            {
                Label label = new Label();
                label.Text = thongso.loaiThongSo.ToUpper() + " :";
                label.Location = new Point(10, 10);
                label.Width = 100;
                label.Height = 30;

                Label label1 = new Label();
                label1.Text = thongso.giaTriThongSo.ToUpper();
                label1.Location = new Point(120, 10);
                label1.Width = 150;
                label1.Height = 30;

                Panel panel = new Panel();
                panel.Height = 50;
                panel.Controls.Add(label);
                panel.Controls.Add(label1);

                flowLayoutPanel1.Controls.Add(panel);
                index++;
            }


        }
        // Them sp vao don hang
        private void guna2Button2_Click(object sender, EventArgs e)
        {

            if (GlobalVar.CurrentOrderId == null)
            {
                MessageBox.Show("Vui lòng qua tab hóa đơn để tạo hóa đơn trước.");
            }
            else
            {
                int currentQuantity = 0;

                using (var quantityForm = new ChooseQuantityForm())
                {
                    quantityForm.ShowDialog();
                    if (quantityForm.CurrentQuantity == null || quantityForm.CurrentQuantity <= 0)
                    {
                        MessageBox.Show("Số lượng sản phẩm không hợp lệ");
                        return;
                    }
                    currentQuantity = quantityForm.CurrentQuantity;
                }

                // Get the current order ID and quantity.
                string currentOrderId = GlobalVar.CurrentOrderId;

                // Get the selected product item.
                string productName = product.TenSP;
                string productItemId = product.MaMH;
                try
                {

                    // Create a new SqlCommand object to call the spTaoChiTietDonHang stored procedure.
                    using (DBConnection db = new DBConnection())
                    {
                        using (SqlConnection con = db.GetConnection())
                        {
                            using (SqlCommand command = new SqlCommand("spTaoChiTietDonHang", con))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                // Add the order ID, product ID, and quantity parameters.
                                command.Parameters.Add("@MaDH", SqlDbType.NVarChar, 10).Value = currentOrderId;
                                command.Parameters.Add("@MaMatHangSP", SqlDbType.NVarChar, 10).Value = productItemId;
                                command.Parameters.Add("@SoLuong", SqlDbType.Int).Value = currentQuantity;


                                db.OpenConnection();
                                command.ExecuteNonQuery();

                                // Show a message to the user indicating that the product item was added to the order.
                                MessageBox.Show("Đã thêm sản phẩm " + productName + " vào đơn hàng.");

                                product.SoLuong -= currentQuantity;
                                product.DaBan += currentQuantity;
                                soluong.Text = product.SoLuong.ToString();
                                daban.Text = product.DaBan.ToString();
                            }

                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Handle the error.
                    MessageBox.Show("Đã xảy ra lỗi khi thêm sản phẩm vào đơn hàng: " + ex.Message);
                }
            }
        }
    }
}
