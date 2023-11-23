using CuaHangDienTu.Models;
using CuaHangDienTu.UI.ImportOrder;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CuaHangDienTu.UI.ChildForm
{
    public partial class ImportOrderDetailsForm : Form
    {
        private FlowLayoutPanel _flowLayoutPanel;
        private string _importOrderId;
        public ImportOrderDetailsForm(string importOrderId)
        {
            InitializeComponent();
            _importOrderId = importOrderId;
        }

        private void ImportOrderDetailsForm_Load(object sender, EventArgs e)
        {
            _flowLayoutPanel = new FlowLayoutPanel();
            _flowLayoutPanel.AutoScroll = true;
            _flowLayoutPanel.Location = new Point(100, 40);
            _flowLayoutPanel.Width = 660;
            _flowLayoutPanel.Height = 400;

            this.Controls.Add(this._flowLayoutPanel);

            List<ImportOrderDetailDTO> orderDetailsDTOs = new List<ImportOrderDetailDTO>();

            orderDetailsDTOs = GetImportOrderDetailsListOfOrder(_importOrderId);

            _flowLayoutPanel.SuspendLayout();

            foreach (ImportOrderDetailDTO importOrderDetailsDTO in orderDetailsDTOs)
            {
                var orderDetailsControl = new ImportOrderDetailControl(importOrderDetailsDTO, false);
                // Add the OrderDetailsControl user control to the FlowLayoutPanel control.
                _flowLayoutPanel.Controls.Add(orderDetailsControl);
            }

            _flowLayoutPanel.ResumeLayout();
        }

        private List<ImportOrderDetailDTO> GetImportOrderDetailsListOfOrder(string importOrderId)
        {
            List<ImportOrderDetailDTO> details = new List<ImportOrderDetailDTO>();
            try
            {
                using (DBConnection db = new DBConnection())
                {
                    using (SqlConnection con = db.GetConnection())
                    {
                        using (SqlCommand command = new SqlCommand("GetChiTietDonNhapHang", con))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@MaDNN", _importOrderId);

                            db.OpenConnection();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string maDNH = reader["MaDNN"].ToString();
                                    string maMatHangSP = reader["MaMatHangSP"].ToString();
                                    int soLuong = reader.GetInt32(reader.GetOrdinal("SoLuong"));
                                    using (DBConnection db2 = new DBConnection())
                                    {
                                        using (SqlConnection con2 = db2.GetConnection())
                                        {
                                            using (SqlCommand nestedCommand = new SqlCommand("spLayGiaSanPhamVaMoTa", con2))
                                            {
                                                nestedCommand.CommandType = CommandType.StoredProcedure;
                                                nestedCommand.Parameters.AddWithValue("@MaMatHangSP", maMatHangSP);
                                                db2.OpenConnection();
                                                using (SqlDataReader nestedReader = nestedCommand.ExecuteReader())
                                                {
                                                    if (nestedReader.Read())
                                                    {
                                                        int giaSP = reader.GetInt32("DonGia");
                                                        string motaSP = nestedReader.GetString(nestedReader.GetOrdinal("MoTaSP"));
                                                        string tenSP = nestedReader.GetString(nestedReader.GetOrdinal("TenSP"));
                                                        ImportOrderDetailDTO orderDetailsDTO = new ImportOrderDetailDTO();
                                                        orderDetailsDTO.ImportOrderId = importOrderId;
                                                        orderDetailsDTO.ProductItemId = maMatHangSP;
                                                        orderDetailsDTO.ProductDescription = motaSP;
                                                        orderDetailsDTO.ProductName = tenSP;
                                                        orderDetailsDTO.Quantity = soLuong;
                                                        orderDetailsDTO.Price = giaSP;
                                                        details.Add(orderDetailsDTO);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi lấy chi tiết đơn hàng: " + ex.Message);
            }
            return details;
        }
    }
}
