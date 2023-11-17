namespace CuaHangDienTu.UI.Income
{
    public partial class IncomeChartControl : UserControl
    {
        private Dictionary<DateTime, int> incomeData;
        private Dictionary<string, int> incomeDataYear;
        public string drawMode = "week";
        public IncomeChartControl()
        {
            InitializeComponent();
            incomeData = new Dictionary<DateTime, int>
            {
                { new DateTime(2023, 1, 1), 1500 },
                { new DateTime(2023, 2, 1), 1300 },
                { new DateTime(2023, 3, 1), 1100 },
                { new DateTime(2023, 4, 1), 1600 },
                { new DateTime(2023, 5, 1), 1700 },
                { new DateTime(2023, 6, 1), 1400 },
                { new DateTime(2023, 7, 1), 1200 },
                { new DateTime(2023, 8, 1), 1350 },
                { new DateTime(2023, 9, 1), 1250 },
                { new DateTime(2023, 10, 1), 1400 },
                { new DateTime(2023, 11, 1), 1500 },
                { new DateTime(2023, 12, 1), 1600 }
                // Add more months if needed...
            };
            Invalidate();
        }

        public void SetIncomeData(Dictionary<DateTime, int> data)
        {
            incomeData = data;
            Invalidate(); // Invalidate the control to trigger repainting
        }

        public void SetIncomeDataYear(Dictionary<string, int> data)
        {
            incomeDataYear = data;
            Invalidate(); // Invalidate the control to trigger repainting
        }

        private void IncomeChartControl_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int chartNum = 0;
            if (drawMode == "week")
            {
                chartNum = incomeData.Count;
            }
            else if (drawMode == "year")
            {
                chartNum = incomeDataYear.Count;
            }
            int paddingX = 40;
            int barWidth;
            int spacing;
            if (chartNum > 7)
            {
                barWidth = (4 * Width - 8 * paddingX) / (5 * chartNum - 1);
                spacing = barWidth / 4;
            }
            else
            {
                barWidth = 40;
                spacing = (Width - paddingX * 2 - barWidth * chartNum) / (chartNum - 1);
            }

            int startX = paddingX; // X-coordinate to start drawing bars
            int startY = Height - 100; // Y-coordinate to start drawing bars



            if (drawMode == "week")
            {
                int max = incomeData.Values.Max();

                double scale = (180.0 / max);
                if (max == 0) scale = 0;
                for (int i = 0; i < incomeData.Count; i++)
                {
                    DateTime date = incomeData.Keys.ElementAt(i);
                    int income = incomeData.Values.ElementAt(i);

                    int barHeight = (int)(income * scale); // Calculate bar height based on income (adjust scaling factor as needed)

                    // Draw rectangle representing income
                    Rectangle bar = new Rectangle(startX, startY - barHeight, barWidth, barHeight);
                    g.FillRectangle(Brushes.Blue, bar);

                    // Draw income value on top of the bar
                    string incomeLabel = income.ToString(); // Convert income to string
                    SizeF incomeSize = g.MeasureString(incomeLabel, Font);
                    g.DrawString(incomeLabel, Font, Brushes.Black, startX - incomeSize.Width / 2 + barWidth / 2, startY - barHeight - incomeSize.Height);

                    // Draw date label below or above the bar based on odd or even index
                    string dateLabel = date.ToShortDateString();
                    SizeF stringSize = g.MeasureString(dateLabel, Font);
                    float labelY = startY; // Default Y-coordinate for labels

                    if (i % 2 == 0) // Even index
                    {
                        labelY += stringSize.Height - 5; // Move the label slightly below the bar
                    }
                    else // Odd index
                    {
                        labelY += stringSize.Height + 10; // Move the label slightly below the bar
                    }

                    g.DrawString(dateLabel, Font, Brushes.Black, startX - stringSize.Width / 2 + barWidth / 2, labelY);

                    startX += barWidth + spacing; // Move to the next position for the next bar
                }
            }
            else if (drawMode == "year")
            {
                int paddingY = 5;
                int max = incomeDataYear.Values.Max();
                double scale = (180.0 / max);

                for (int i = 0; i < incomeDataYear.Count; i++)
                {
                    string month = incomeDataYear.Keys.ElementAt(i);
                    int income = incomeDataYear.Values.ElementAt(i);



                    // Adjust the bar height using the scale factor
                    int barHeight = (int)(income * scale); // Adjust padding as needed

                    // Draw rectangle representing income
                    Rectangle bar = new Rectangle(startX, startY - barHeight, barWidth, barHeight);
                    g.FillRectangle(Brushes.Blue, bar);

                    // Draw income value on top of the bar
                    string incomeLabel = income.ToString(); // Convert income to string
                    SizeF incomeSize = g.MeasureString(incomeLabel, Font);
                    g.DrawString(incomeLabel, Font, Brushes.Black, startX - incomeSize.Width / 2 + barWidth / 2, startY - barHeight - incomeSize.Height);

                    // Draw date label below or above the bar based on odd or even index
                    string dateLabel = month;
                    SizeF stringSize = g.MeasureString(dateLabel, Font);
                    float labelY = startY; // Default Y-coordinate for labels

                    if (i % 2 == 0) // Even index
                    {
                        labelY += stringSize.Height - 5; // Move the label slightly below the bar
                    }
                    else // Odd index
                    {
                        labelY += stringSize.Height + 10; // Move the label slightly below the bar
                    }

                    g.DrawString(dateLabel, Font, Brushes.Black, startX - stringSize.Width / 2 + barWidth / 2, labelY);

                    startX += barWidth + spacing; // Move to the next position for the next bar
                }
            }

        }
    }
}
