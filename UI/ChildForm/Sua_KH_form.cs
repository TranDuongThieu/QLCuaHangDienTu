using CuaHangDienTu.UI.Admin;
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

namespace CuaHangDienTu.UI.ChildForm
{
    public partial class Sua_KH_form : Form
    {
        string id, hoten, sdt;
        int diem;
        private Admin_QLKH parentForm;
        public Sua_KH_form(Admin_QLKH parent, string id, string Hoten, string Sdt, int Diem)
        {
            InitializeComponent();
            parentForm = parent;
            this.id = id;
            this.hoten = Hoten;
            this.sdt = Sdt;
            this.diem = Diem;
        }
        string sqlConnectionString = "Data Source=LAPTOP-6280OKSE\\SQLEXPRESS;Initial Catalog=CuaHangDienTu;Integrated Security=True ;TrustServerCertificate=true";
        DataSet ds = new DataSet();
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string sql;
        public Sua_KH_form()
        {
            InitializeComponent();
        }

        private void Sua_KH_form_Load(object sender, EventArgs e)
        {

            guna2TextBox1.Text = hoten;
            guna2TextBox2.Text = sdt;
            guna2TextBox3.Text = diem.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection(sqlConnectionString))
            {
                try
                {
                    con1.Open();
                    using (SqlCommand cmd = new SqlCommand("updateKH", con1))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@MaKH", SqlDbType.NChar, 10)).Value = id;
                        cmd.Parameters.Add(new SqlParameter("@HoTenKH", SqlDbType.NVarChar, 255)).Value = guna2TextBox1.Text;
                        cmd.Parameters.Add(new SqlParameter("@SoDienThoai", SqlDbType.NChar, 10)).Value = guna2TextBox2.Text;
                        cmd.Parameters.Add(new SqlParameter("@DiemThanhVien", SqlDbType.Int)).Value = Int32.Parse(guna2TextBox3.Text);
                        cmd.ExecuteNonQuery();
                        //Admin_QLKH.
                        // If the execution didn't throw an exception, it was successful.
                        MessageBox.Show("Update successful");
                        if (parentForm != null)
                        {
                            parentForm.Load_Table_KH(); // Call the method on the parent form instance
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception (e.g., display an error message).
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
