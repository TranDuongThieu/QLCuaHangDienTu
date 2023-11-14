using CuaHangDienTu.UI.ChildForm;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CuaHangDienTu.UI.Admin
{
    public partial class Admin_QLMatHang : UserControl
    {
        public Admin_QLMatHang()
        {
            InitializeComponent();
        }

        string sqlConnectionString = Properties.Settings.Default.connectionString;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void load_Table()
        {
            using (SqlConnection con1 = new SqlConnection(sqlConnectionString))
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from vwDanhSachMatHangSanPham", con1);
                cmd.CommandType = CommandType.Text;
                con1.Open();
                dt.Load(cmd.ExecuteReader());
                con1.Close();
                table_SP.DataSource = dt;

            }

        }

        public Image Chuyen(byte[] imageData)
        {
            MemoryStream ms = new MemoryStream(imageData);
            Image returnIMG = Image.FromStream(ms);
            return returnIMG;
        }



        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection(sqlConnectionString))
            {
                string id = table_SP.CurrentRow.Cells[0].Value.ToString();
                SqlCommand cmd = new SqlCommand("", con1);
                cmd.CommandType = CommandType.Text;
                con1.Open();


            }
        }
        private void filename_Click(object sender, EventArgs e)
        {

        }

        private void Admin_QLMatHang_Load(object sender, EventArgs e)
        {
            load_Table();
        }

        private void table_SP_SelectionChanged(object sender, EventArgs e)
        {
            txt_Ten.Text = table_SP.CurrentRow.Cells[1].Value.ToString();
            txt_Gia.Text = table_SP.CurrentRow.Cells[4].Value.ToString();
            txt_SL.Text = table_SP.CurrentRow.Cells[5].Value.ToString();
            txt_DaBan.Text = table_SP.CurrentRow.Cells[6].Value.ToString();
            filename.Text = table_SP.CurrentRow.Cells[3].Value.ToString();
            try
            {
                // Get the file path from the cell
                string filePath = table_SP.CurrentRow.Cells[3].Value.ToString();

                // Check if the file exists
                if (File.Exists(filePath))
                {
                    // Load the image from the file
                    Image img = Image.FromFile(filePath);
                    pic_SanPham.Image = img;
                }
                else
                {
                    // Handle the case where the file does not exist
                    pic_SanPham.Image = null; // Set a default image or handle the error in a different way
                }
            }
            catch (Exception ex)
            {
                // Handle other exceptions if necessary
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //txt_Gia.Text
            //txt_SL.Text
            //txt_DaBan.Text 
            //filename.Text
            string matHangId = table_SP.CurrentRow.Cells[0].Value.ToString();
            string tenSP = txt_Ten.Text.ToString();
            string hinhAnh = filename.Text.ToString();
            int gia = Int32.Parse(txt_Gia.Text);
            int sl = Int32.Parse(txt_SL.Text);
            int daban = Int32.Parse(txt_DaBan.Text);
            using (SqlConnection con1 = new SqlConnection(sqlConnectionString))
            {
                try
                {
                    con1.Open();
                    using (SqlCommand cmd = new SqlCommand("spCapNhatMatHangSP", con1))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@MaMatHang", SqlDbType.VarChar, 10)).Value = matHangId;
                        cmd.Parameters.Add(new SqlParameter("@Gia", SqlDbType.Int)).Value = gia;
                        cmd.Parameters.Add(new SqlParameter("@SoLuongDaBan", SqlDbType.Int)).Value = daban;
                        cmd.Parameters.Add(new SqlParameter("@SoLuongTrongKho", SqlDbType.Int)).Value = sl;
                        cmd.Parameters.Add(new SqlParameter("@TenSanPham", SqlDbType.NVarChar, 50)).Value = tenSP;
                        cmd.Parameters.Add(new SqlParameter("@HinhAnh", SqlDbType.NVarChar, 255)).Value = hinhAnh;
                        cmd.ExecuteNonQuery();
                        //Admin_QLKH.
                        // If the execution didn't throw an exception, it was successful.

                        MessageBox.Show("Update successful");
                        load_Table();
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

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.png;*.gif|All Files(*.*)|*.*";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pic_SanPham.ImageLocation = openFileDialog1.FileName;
                filename.Text = openFileDialog1.FileName;
                openFileDialog1.Dispose();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ThemMatHangForm themMatHangForm = new ThemMatHangForm(this);
            themMatHangForm.ShowDialog();
        }
    }
}
