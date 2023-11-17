using CuaHangDienTu.Models;
using CuaHangDienTu.UI.Admin;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CuaHangDienTu.UI.ChildForm
{
    public partial class ThemMatHangForm : Form
    {
        private Admin_QLMatHang adminQlspInstance;
        private class ThongSoKyThuat
        {
            public string maLoaiThongSo;
            public string giaTriThongSo;
        }

        public ThemMatHangForm(Admin_QLMatHang adminQlspInstance)
        {
            InitializeComponent();
            this.adminQlspInstance = adminQlspInstance;
        }
        string madanhmuc;
        List<string> madanhmuccon = new List<string>();
        private void guna2ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedItem != null)
            {
                panel_thongso.Controls.Clear();
                string selectedValue = guna2ComboBox1.SelectedItem.ToString();

                string madanhmuccha;
                if (selectedValue == "Điện thoại") madanhmuccha = "PHONE";
                else if (selectedValue == "Laptop") madanhmuccha = "LAPTOP";
                else madanhmuccha = "TABLET";

                setThuongHieu(madanhmuccha);
                setComboBoxThongSo(madanhmuccha);



            }
        }



        private void setThuongHieu(string madanhmuccha)
        {
            using (DBConnection db = new DBConnection())
            {
                using (SqlConnection con = db.GetConnection())
                {
                    // Construct the SQL query using a parameterized query to prevent SQL injection
                    string sqlQuery = "SELECT MaDanhMuc, TenDanhMuc FROM DANH_MUC_SAN_PHAM WHERE MaDanhMucCha = @madanhmuccha";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    cmd.Parameters.AddWithValue("@madanhmuccha", madanhmuccha);

                    db.OpenConnection();

                    SqlDataReader reader = cmd.ExecuteReader();

                    List<string> danhMucList = new List<string>();

                    // Read the values and add them to the list
                    while (reader.Read())
                    {
                        danhMucList.Add(reader["TenDanhMuc"].ToString());
                        madanhmuccon.Add(reader["MaDanhMuc"].ToString());
                    }


                    // Set the list as the data source for guna2ComboBox2
                    guna2ComboBox2.DataSource = danhMucList;
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

                    CheckedListBox checkedList = new CheckedListBox();
                    giatrithongso.ForEach(gi => { checkedList.Items.Add(gi.ToString()); });
                    checkedList.Location = new Point(105, 10);

                        label.Width = 100; // Set width as needed
                        combobox.Width = 300;

                        Panel panel = new Panel();
                        panel.Controls.Add(label);
                        panel.Controls.Add(combobox);

                        panel_thongso.Controls.Add(panel);
                    });
                }
            }
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

        private void btn_themAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.png;*.gif|All Files(*.*)|*.*";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                filename.Text = openFileDialog1.FileName;
                openFileDialog1.Dispose();
            }
        }
        private void themSanPham(string spId, string tenSP, string moTa, string imgFileName, int thoiHanBaoHanh, SqlConnection con1, SqlTransaction transaction)
        {
            using (SqlCommand cmd = new SqlCommand("spThemSanPham", con1, transaction))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaSP", SqlDbType.NVarChar, 10)).Value = spId;
                cmd.Parameters.Add(new SqlParameter("@MaDanhMuc", SqlDbType.NVarChar, 10)).Value = madanhmuc;
                cmd.Parameters.Add(new SqlParameter("@TenSP", SqlDbType.NVarChar, 50)).Value = tenSP;
                cmd.Parameters.Add(new SqlParameter("@MoTaSP", SqlDbType.NVarChar, 5000)).Value = moTa;
                cmd.Parameters.Add(new SqlParameter("@HinhAnhSP", SqlDbType.NVarChar, 255)).Value = imgFileName;
                cmd.Parameters.Add(new SqlParameter("@ThoiHanBaoHanh", SqlDbType.VarChar, 10)).Value = thoiHanBaoHanh;
                cmd.ExecuteNonQuery();
            }
        }

        private void themMatHang(string matHangId, string spId, int Gia, int soLuong, SqlConnection con1, SqlTransaction transaction)
        {

            try
            {
                using (SqlCommand cmd = new SqlCommand("spThemMatHang", con1, transaction))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MaMatHangSP", SqlDbType.NVarChar, 10)).Value = matHangId;
                    cmd.Parameters.Add(new SqlParameter("@MaSP", SqlDbType.NVarChar, 10)).Value = spId;
                    cmd.Parameters.Add(new SqlParameter("@Gia", SqlDbType.Int)).Value = Gia;
                    cmd.Parameters.Add(new SqlParameter("@SoLuongTrongKho", SqlDbType.Int)).Value = soLuong;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., display an error message).
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }
        private void themThongSoMatHang(string matHangId, SqlConnection con1, SqlTransaction transaction)
        {
            List<ThongSoKyThuat> listThongSo = new List<ThongSoKyThuat>();
            foreach (Control panelControl in panel_thongso.Controls)
            {
                if (panelControl is Panel)
                {
                    Panel panel = (Panel)panelControl;


                    string tenthongso = "";
                    foreach (Control control in panel.Controls)
                    {
                        if (control is Label)
                        {
                            tenthongso = control.Text.ToString().ToLower();
                        }
                        //if (control is Guna2ComboBox)
                        //{
                        //    Guna2ComboBox combobox = (Guna2ComboBox)control;
                        //    thongSo.giaTriThongSo = combobox.SelectedValue.ToString();
                        //}
                        if (control is CheckedListBox)
                        {
                            CheckedListBox checkedListBox = (CheckedListBox)control;
                            foreach (var item in checkedListBox.CheckedItems)
                            {
                                ThongSoKyThuat thongSo = new ThongSoKyThuat();
                                thongSo.maLoaiThongSo = tenthongso;
                                thongSo.giaTriThongSo = item.ToString();
                                listThongSo.Add(thongSo);

                            }
                        }
                    }

                }
            }

            foreach (var thongso in listThongSo)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.GetMaThongSoKiThuat(@MaLoaiThongSo, @GiaTriThongSo)", con1, transaction))
                    {
                        // Thêm các tham số cần thiết
                        cmd.Parameters.AddWithValue("@MaLoaiThongSo", thongso.maLoaiThongSo);
                        cmd.Parameters.AddWithValue("@GiaTriThongSo", thongso.giaTriThongSo);

                        // Thực hiện truy vấn
                        var result = cmd.ExecuteScalar();

                        // Kiểm tra xem result có giá trị hay không
                        if (result != null)
                        {
                            string maThongSoKiThuat = result.ToString();
                            using (SqlCommand cmd2 = new SqlCommand("spThemThongSoMatHang", con1, transaction))
                            {
                                // Fix the command type here
                                cmd2.CommandType = CommandType.StoredProcedure;
                                cmd2.Parameters.Add(new SqlParameter("@MaMatHangSP", SqlDbType.NVarChar, 10)).Value = matHangId;
                                cmd2.Parameters.Add(new SqlParameter("@MaThongSoKiThuat", SqlDbType.NVarChar, 10)).Value = maThongSoKiThuat;

                                // Fix the execution command here
                                cmd2.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No result returned from the function.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ (ví dụ: hiển thị thông báo lỗi)
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }



        }

        private void btn_addSP_Click(object sender, EventArgs e)
        {


            string tenSP = txt_name.Text.ToString();
            String imgFileName = filename.Text.ToString();
            int thoiHanBaoHanh = Int32.Parse(txt_baohanh.Text);
            int soLuong = Int32.Parse(txt_soluong.Text);
            string moTa = txt_mota.Text.ToString();
            int Gia = Int32.Parse(txt_gia.Text);
            if (madanhmuc == "" || tenSP == "" || imgFileName == "" || txt_baohanh.Text == "" || txt_soluong.Text == "" || moTa == "")
            {
                MessageBox.Show("Thiếu thông tin !");
            }
            else
            {

                string spId = RandomIdGenerator.GenerateRandomId();
                string matHangId = RandomIdGenerator.GenerateRandomId();

                using (DBConnection db = new DBConnection())
                {
                    using (SqlConnection con1 = db.GetConnection())
                    {
                        db.OpenConnection();

                        SqlTransaction transaction = con1.BeginTransaction();

                        try
                        {
                            // Sử dụng SqlCommand để thực hiện các lệnh SQL trong giao dịch
                            themSanPham(spId, tenSP, moTa, imgFileName, thoiHanBaoHanh, con1, transaction);
                            themMatHang(matHangId, spId, Gia, soLuong, con1, transaction); ;
                            themThongSoMatHang(matHangId, con1, transaction);


                            // Nếu mọi thứ đều ổn, commit giao dịch
                            transaction.Commit();
                            MessageBox.Show("Inserted.");
                            this.Hide();
                            adminQlspInstance.load_Table();
                        }
                        catch (Exception ex)
                        {
                            // Nếu có lỗi, rollback giao dịch
                            transaction.Rollback();
                            MessageBox.Show("Transaction rolled back. Reason: " + ex.Message);
                        }
                    }
                }
            }

        }


        private void ThemMatHangForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedValueChanged(object sender, EventArgs e)
        {

            madanhmuc = madanhmuccon[guna2ComboBox2.SelectedIndex];
        }
    }
}
