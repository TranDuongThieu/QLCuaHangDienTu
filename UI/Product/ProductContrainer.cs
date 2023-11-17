using CuaHangDienTu.Models;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;
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
    public partial class ProductContrainer : UserControl
    {
        string maDanhMucCha;
        string maDanhMucCon;

        public ProductContrainer(string maDanhMucCha, string maDanhMucCon)
        {
            InitializeComponent();
            this.maDanhMucCha = maDanhMucCha;
            this.maDanhMucCon = maDanhMucCon;
        }
        public List<ProductModel> getListSanPham()
        {
            List<ProductModel> productList = new List<ProductModel>();
            using (DBConnection db = new DBConnection())
            {
                using (SqlConnection con = db.GetConnection())
                {
                    db.OpenConnection();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.LayMatHangTuMaDanhMuc(@InputMaDanhMuc)", con))
                    {
                        cmd.Parameters.AddWithValue("@InputMaDanhMuc", maDanhMucCon);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string maMatHang = reader["MaMatHangSP"].ToString();
                                string maSP = reader["MaSP"].ToString();
                                string tenSP = reader["TenSP"].ToString();
                                int gia = Convert.ToInt32(reader["Gia"]);
                                string hinhAnh = reader["HinhAnhSP"].ToString();
                                int soLuong = Convert.ToInt32(reader["SoLuongTrongKho"]);
                                int daBan = Convert.ToInt32(reader["SoLuongDaBan"]);
                                int thoiHanBaoHanh = Convert.ToInt32(reader["ThoiHanBaoHanh"]);
                                string mota = reader["MoTaSP"].ToString();
                                ProductModel product = new ProductModel(maMatHang, maSP, tenSP, gia, hinhAnh, soLuong, daBan, thoiHanBaoHanh, mota);
                                productList.Add(product);
                            }
                        }
                    }
                }

            }
            return productList;
        }
        private List<string> getThongSo(string MaLoaiThongSo)
        {
            using (DBConnection db = new DBConnection())
            {
                using (SqlConnection con = db.GetConnection())
                {
                    // Construct the SQL query using a parameterized query to prevent SQL injection
                    string sqlQuery = "SELECT GiaTriThongSo FROM THONG_SO_KI_THUAT WHERE MaLoaiThongSo = @MaLoaiThongSo";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@MaLoaiThongSo", MaLoaiThongSo);

                    db.OpenConnection();

                    SqlDataReader reader = cmd.ExecuteReader();

                    List<string> danhMucList = new List<string>();

                    // Read the values and add them to the list
                    while (reader.Read())
                    {
                        danhMucList.Add(reader["GiaTriThongSo"].ToString());
                    }
                    return danhMucList;
                }
            }
        }

        private void setComboBoxThongSo(string madanhmuccha)
        {
            using (DBConnection db = new DBConnection())
            {
                using (SqlConnection con = db.GetConnection())
                {
                    // Construct the SQL query using a parameterized query to prevent SQL injection
                    string sqlQuery2 = "SELECT MaLoaiThongSo FROM LoaiThongSoDanhMuc WHERE MaDanhMuc = @madanhmuccha";
                    SqlCommand cmd2 = new SqlCommand(sqlQuery2, con);
                    cmd2.Parameters.AddWithValue("@madanhmuccha", madanhmuccha);
                    db.OpenConnection();
                    SqlDataReader reader = cmd2.ExecuteReader();
                    List<string> thongSoList = new List<string>();
                    while (reader.Read())
                    {
                        thongSoList.Add(reader["MaLoaiThongSo"].ToString());
                    }
                    thongSoList.ForEach(thongso =>
                    {
                        Label label = new Label();
                        label.Text = thongso.ToUpper();
                        label.Location = new Point(10, 10);

                        Guna2ComboBox combobox = new Guna2ComboBox();
                        List<string> giatrithongso = getThongSo(thongso);
                        combobox.DataSource = giatrithongso;
                        combobox.Location = new Point(110, 10);


                        label.Width = 100; // Set width as needed
                        combobox.Width = 300;

                        Panel panel = new Panel();
                        panel.Controls.Add(label);
                        panel.Controls.Add(combobox);

                        flowPanel.Controls.Add(panel);
                    });
                }
            }
        }

        private void LoadListSP(List<ProductModel> list)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (ProductModel product in list)
            {
                ProductCard newProduct = new ProductCard(product);
                flowLayoutPanel1.Controls.Add(newProduct);
            }
        }

        private void ProductContrainer_Load(object sender, EventArgs e)
        {
            List<ProductModel> productList = getListSanPham();
            setComboBoxThongSo(maDanhMucCha);

            // Now you can use the productList as needed (e.g., display in the UI)
            LoadListSP(productList);
        }

        public List<ProductModel> getSanPhamTuTen(string name)
        {
            List<ProductModel> productList = new List<ProductModel>();
            using (DBConnection db = new DBConnection())
            {
                using (SqlConnection con = db.GetConnection())
                {
                    db.OpenConnection();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.LayMatHangTuTenSP(@TenSP,@InputMaDanhMuc)", con))
                    {
                        cmd.Parameters.AddWithValue("@TenSP", name);
                        cmd.Parameters.AddWithValue("@InputMaDanhMuc", maDanhMucCon);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string maMatHang = reader["MaMatHangSP"].ToString();
                                string maSP = reader["MaSP"].ToString();
                                string tenSP = reader["TenSP"].ToString();
                                int gia = Convert.ToInt32(reader["Gia"]);
                                string hinhAnh = reader["HinhAnhSP"].ToString();
                                int soLuong = Convert.ToInt32(reader["SoLuongTrongKho"]);
                                int daBan = Convert.ToInt32(reader["SoLuongDaBan"]);
                                int thoiHanBaoHanh = Convert.ToInt32(reader["ThoiHanBaoHanh"]);
                                string mota = reader["MoTaSP"].ToString();
                                ProductModel product = new ProductModel(maMatHang, maSP, tenSP, gia, hinhAnh, soLuong, daBan, thoiHanBaoHanh, mota);
                                productList.Add(product);
                            }
                        }
                    }
                }
            }
            return productList;
        }

        private void guna2TextBox1_IconRightClick(object sender, EventArgs e)
        {
            string productName = guna2TextBox1.Text.ToString();
            List<ProductModel> productList = getSanPhamTuTen(productName);
            LoadListSP(productList);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

