using CuaHangDienTu.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CuaHangDienTu.UI.Admin
{
    public partial class Admin_QLDoanhThu : UserControl
    {
        private Dictionary<DateTime, int> incomeData;
        private Dictionary<string, int> incomeDataYear;
        private List<Models.Order> orders;
        public Admin_QLDoanhThu()
        {
            InitializeComponent();
            incomeData = GetIncomeWeek(DateTime.Now);
            incomeDataYear = GetIncomeYear(DateTime.Now);
            orderGridView.Visible = false;
            totalValueLabel.Visible = false;
        }

        private Dictionary<string, int> GetIncomeYear(DateTime startDate)
        {
            Dictionary<string, int> incomeResult = new Dictionary<string, int>();
            DateTime endDate = startDate.AddMonths(11);

            try
            {
                using (DBConnection db = new DBConnection())
                {
                    using (SqlConnection con = db.GetConnection())
                    {
                        using (SqlCommand command = new SqlCommand("SELECT * FROM fnLayDoanhThuTheoThang(@NgayBatDau, @NgayKetThuc);", con))
                        {
                            command.Parameters.Add("@NgayBatDau", SqlDbType.Date).Value = startDate;
                            command.Parameters.Add("@NgayKetThuc", SqlDbType.Date).Value = endDate;
                            db.OpenConnection();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        string month = reader.GetString(0);
                                        int income = reader.GetInt32(1);
                                        incomeResult.Add(month, income);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lấy doanh thu: " + ex.Message);
            }
            return incomeResult;
        }

        private Dictionary<DateTime, int> GetIncomeWeek(DateTime startDate)
        {
            Dictionary<DateTime, int> incomeResult = new Dictionary<DateTime, int>();
            DateTime endDate = startDate.AddDays(6);
            try
            {
                using (DBConnection db = new DBConnection())
                {
                    using (SqlConnection con = db.GetConnection())
                    {
                        using (SqlCommand command = new SqlCommand("SELECT * FROM fnLayDoanhThuTheoNgay(@NgayBatDau, @NgayKetThuc);", con))
                        {
                            command.Parameters.Add("@NgayBatDau", SqlDbType.Date).Value = startDate;
                            command.Parameters.Add("@NgayKetThuc", SqlDbType.Date).Value = endDate;
                            db.OpenConnection();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        DateTime date = reader.GetDateTime(0);
                                        int income = reader.GetInt32(1);
                                        incomeResult.Add(date, income);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lấy doanh thu: " + ex.Message);
            }
            return incomeResult;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string currentChoosing = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (currentChoosing == "Ngày trong tuần")
            {
                incomeChartControl1.Visible = true;
                endDateLabel.Visible = false;
                endDatePicker.Visible = false;
                orderGridView.Visible = false;
                totalValueLabel.Visible = false;
            }
            else if (currentChoosing == "Tháng trong năm")
            {
                incomeChartControl1.Visible = true;
                endDateLabel.Visible = false;
                endDatePicker.Visible = false;
                orderGridView.Visible = false;
                totalValueLabel.Visible = false;


            }
            else if (currentChoosing == "Khoảng thời gian")
            {
                incomeChartControl1.Visible = false;
                endDateLabel.Visible = true;
                endDatePicker.Visible = true;
                orderGridView.Visible = true;
            }
        }

        private void viewIncomeButton_Click(object sender, EventArgs e)
        {
            DateTime choosingStartTime = startDatePicker.Value;
            string currentChoosing = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (currentChoosing == "Ngày trong tuần")
            {
                incomeData = GetIncomeWeek(choosingStartTime);
                incomeChartControl1.SetIncomeData(incomeData);
                incomeChartControl1.drawMode = "week";
                incomeChartControl1.Invalidate();
            }
            else if (currentChoosing == "Tháng trong năm")
            {
                incomeDataYear = GetIncomeYear(choosingStartTime);
                incomeChartControl1.SetIncomeDataYear(incomeDataYear);
                incomeChartControl1.drawMode = "year";
                incomeChartControl1.Invalidate();
            }
            else if (currentChoosing == "Khoảng thời gian")
            {
                DateTime choosingEndTime = endDatePicker.Value;
                if (choosingStartTime.Date > choosingEndTime.Date)
                {
                    MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc");
                }
                else
                {
                    orderGridView.DataSource = GetOrders(choosingStartTime, choosingEndTime);
                    totalValueLabel.Text = "Tổng doanh thu là: " + GetTotalIncome(choosingStartTime, choosingEndTime).ToString();
                    totalValueLabel.Visible = true;

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chế độ xem doanh thu theo...");
            }
        }

        private int GetTotalIncome(DateTime choosingStartTime, DateTime choosingEndTime)
        {
            int totalValue = 0;
            try
            {
                using (DBConnection db = new DBConnection())
                {
                    using (SqlConnection con = db.GetConnection())
                    {
                        using (SqlCommand command = new SqlCommand("SELECT dbo.fnTongThuNhapTrongKhoangThoiGian(@NgayBatdau, @NgayKetThuc)", con))
                        {
                            command.Parameters.Add("@NgayBatDau", SqlDbType.Date).Value = choosingStartTime.Date;
                            command.Parameters.Add("@NgayKetThuc", SqlDbType.Date).Value = choosingEndTime.Date;
                            db.OpenConnection();
                            totalValue = (int)command.ExecuteScalar();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi lấy tổng doanh thu: " + ex.Message);
            }
            return totalValue;
        }

        List<Models.Order> GetOrders(DateTime startDate, DateTime endDate)
        {
            List<Models.Order> result = new List<Models.Order>();
            try
            {
                using (DBConnection db = new DBConnection())
                {
                    using (SqlConnection con = db.GetConnection())
                    {
                        using (SqlCommand command = new SqlCommand("SELECT * FROM fnLayDonHangTrongKhoangThoiGian(@NgayBatDau, @NgayKetThuc);", con))
                        {
                            command.Parameters.Add("@NgayBatDau", SqlDbType.Date).Value = startDate;
                            command.Parameters.Add("@NgayKetThuc", SqlDbType.Date).Value = endDate;
                            db.OpenConnection();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        Models.Order order = new Models.Order();
                                        order.CustomerId = reader.GetString("MaKH");
                                        order.OrderId = reader.GetString("MaDH");
                                        order.DepartmentId = reader.GetString("MaCN");
                                        order.TotalValue = reader.GetInt32("TongGiaTri");
                                        order.CreatedDate = reader.GetDateTime("NgayDatHang");
                                        result.Add(order);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi lấy đơn hàng: " + ex.Message);
            }
            return result;
        }
    }
}
