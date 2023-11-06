
using CuaHangDienTu.UI.ChildForm;
using Microsoft.Data.SqlClient;
using System;

using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangDienTu.UI.Admin
{
    public partial class Admin_QLKH : UserControl
    {
        public Admin_QLKH()
        {
            InitializeComponent();
        }
        string id, hoten, sodienthoai;
        int diem;

        string sqlConnectionString = "Data Source=LAPTOP-6280OKSE\\SQLEXPRESS;Initial Catalog=CuaHangDienTu;Integrated Security=True ;TrustServerCertificate=true";
        DataSet ds = new DataSet();
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string sql;
        public void Load_Table_KH()
        {
            using (SqlConnection con1 = new SqlConnection(sqlConnectionString))
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from KHACH_HANG", con1);
                cmd.CommandType = CommandType.Text;
                con1.Open();
                dt.Load(cmd.ExecuteReader());
                con1.Close();
                dataGridView1.DataSource = dt;
            }
        }
        private void Admin_QLKH_Load(object sender, EventArgs e)
        {
            Load_Table_KH();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tao_KhachHang_form tao_KhachHang_Form = new Tao_KhachHang_form(this); // Pass 'this' as the parent form
            tao_KhachHang_Form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //hoten = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //sodienthoai = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //diem = Int32.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string hoten = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string sodienthoai = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            int diem = Int32.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());

            Sua_KH_form tao_KhachHang_Form = new Sua_KH_form(this, id, hoten, sodienthoai, diem); // Pass 'this' as the parent form
            tao_KhachHang_Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the selected MaKH (ID) from the DataGridView
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            // Prompt the user for confirmation before deleting
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Attempt to delete the record
                using (SqlConnection con1 = new SqlConnection(sqlConnectionString))
                {
                    con1.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM KHACH_HANG WHERE MaKH = @MaKH", con1))
                    {
                        cmd.Parameters.Add(new SqlParameter("@MaKH", SqlDbType.NChar, 10)).Value = id;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.");
                            Load_Table_KH(); // Refresh the DataGridView after deletion
                        }
                        else
                        {
                            MessageBox.Show("No record was deleted. MaKH not found.");
                        }
                    }
                }
            }
        }

    }
}
