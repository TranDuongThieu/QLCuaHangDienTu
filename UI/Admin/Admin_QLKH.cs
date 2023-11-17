
using CuaHangDienTu.Models;
using CuaHangDienTu.UI.ChildForm;
using Microsoft.Data.SqlClient;
using System.Data;

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
        DataSet ds = new DataSet();
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string sql;
        public void Load_Table_KH()
        {

            using (DBConnection db = new DBConnection())
            {
                using (SqlConnection con = db.GetConnection())
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("Select * from KHACH_HANG", con);
                    cmd.CommandType = CommandType.Text;
                    db.OpenConnection();
                    dt.Load(cmd.ExecuteReader());
                    ;
                    dataGridView1.DataSource = dt;
                }
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

        private void xoaKH(string id)
        {
            try
            {
                using (DBConnection db = new DBConnection())
                {
                    using (SqlConnection con = db.GetConnection())
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand("spXoaKH", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Thêm tham số đầu vào cho thủ tục
                            cmd.Parameters.Add("@MaKH", SqlDbType.NVarChar, 10).Value = id;

                            // Thực thi thủ tục
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Xóa khách hàng thành công!");
                    Load_Table_KH();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi xóa khách hàng: " + ex.Message);
            }
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
                xoaKH(id);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void TimKiemKhachHang(string tenKH)
        {
            DataTable resultTable = new DataTable();

            using (DBConnection db = new DBConnection())
            {
                using (SqlConnection con = db.GetConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM timKiemKhachHang(@HoTenKH)", con))
                    {
                        cmd.Parameters.Add("@HoTenKH", SqlDbType.NVarChar, 50).Value = tenKH;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(resultTable);
                        }
                    }
                }

                dataGridView1.DataSource = resultTable;
            }
        }



        private void guna2TextBox1_IconRightClick(object sender, EventArgs e)
        {

            string tenKH = guna2TextBox1.Text.ToString();
            TimKiemKhachHang(tenKH);

        }
    }
}
