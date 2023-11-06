
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

        string sqlConnectionString = "Data Source=LAPTOP-6280OKSE\\SQLEXPRESS;Initial Catalog=CuaHangDienTu;Integrated Security=True ;TrustServerCertificate=true";
        DataSet ds = new DataSet();
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string sql;
        private void Admin_QLKH_Load(object sender, EventArgs e)
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
    }
}