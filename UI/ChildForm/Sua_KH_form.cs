using CuaHangDienTu.Models;
using CuaHangDienTu.UI.Admin;
using Microsoft.Data.SqlClient;
using System.Data;

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
        string sqlConnectionString = Properties.Settings.Default.connectionString;
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
            try
            {
                using (DBConnection db = new DBConnection())
                {
                    using (SqlConnection con = db.GetConnection())
                    {
                        using (SqlCommand cmd = new SqlCommand("spCapNhatKH", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add(new SqlParameter("@MaKH", SqlDbType.VarChar, 10)).Value = id;
                            cmd.Parameters.Add(new SqlParameter("@HoTenKH", SqlDbType.NVarChar, 255)).Value = guna2TextBox1.Text;
                            cmd.Parameters.Add(new SqlParameter("@SoDienThoai", SqlDbType.VarChar, 10)).Value = guna2TextBox2.Text;
                            cmd.Parameters.Add(new SqlParameter("@DiemThanhVien", SqlDbType.Int)).Value = Int32.Parse(guna2TextBox3.Text);
                            db.OpenConnection();
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
