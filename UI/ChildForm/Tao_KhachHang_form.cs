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
    public partial class Tao_KhachHang_form : Form
    {
        private Admin_QLKH parentForm; // A reference to the parent form

        public Tao_KhachHang_form(Admin_QLKH parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        public Tao_KhachHang_form()
        {
            InitializeComponent();
        }
        string sqlConnectionString = Properties.Settings.Default.connectionString;
        DataSet ds = new DataSet();
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string sql;
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string hotenKH = guna2TextBox1.Text;
            string sodienthoai = guna2TextBox2.Text;
            string id = RandomIdGenerator.GenerateUniqueIdentifier();


            using (SqlConnection con1 = new SqlConnection(sqlConnectionString))
            {
                try
                {
                    con1.Open();
                    using (SqlCommand cmd = new SqlCommand("spThemKH", con1))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@MaKH", SqlDbType.VarChar, 10)).Value = id;
                        cmd.Parameters.Add(new SqlParameter("@HoTenKH", SqlDbType.NVarChar, 255)).Value = hotenKH;
                        cmd.Parameters.Add(new SqlParameter("@SoDienThoai", SqlDbType.VarChar, 10)).Value = sodienthoai;
                        cmd.ExecuteNonQuery();
                        //Admin_QLKH.
                        // If the execution didn't throw an exception, it was successful.
                        
                        MessageBox.Show("Insert successful");
                        if (parentForm != null)
                        {
                            parentForm.Load_Table_KH(); // Call the method on the parent form instance
                        }
                    }
                    con1.Close();
                }
                catch (Exception ex)
                {
                    // Handle the exception (e.g., display an error message).
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void Tao_KhachHang_form_Load(object sender, EventArgs e)
        {

        }
    }
}
