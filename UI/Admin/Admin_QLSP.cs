using CuaHangDienTu.UI.ChildForm;
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

namespace CuaHangDienTu.UI.Admin
{
    public partial class Admin_QLSP : UserControl
    {
        public Admin_QLSP()
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
        private void Admin_QLSP_Load(object sender, EventArgs e)
        {
            load_Table();
        }
        public Image Chuyen(byte[] imageData)
        {
            MemoryStream ms = new MemoryStream(imageData);
            Image returnIMG = Image.FromStream(ms);
            return returnIMG;
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            ThemMatHangForm themMatHangForm = new ThemMatHangForm(this);
            themMatHangForm.ShowDialog();
        }


    }
}
