namespace CuaHangDienTu.UI.Admin
{
    partial class Admin_QLDoanhThu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            incomeChartControl1 = new Income.IncomeChartControl();
            comboBox1 = new ComboBox();
            label2 = new Label();
            startDateLabel = new Label();
            endDateLabel = new Label();
            startDatePicker = new DateTimePicker();
            endDatePicker = new DateTimePicker();
            viewIncomeButton = new Button();
            orderGridView = new DataGridView();
            totalValueLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)orderGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(411, 10);
            label1.Name = "label1";
            label1.Size = new Size(147, 37);
            label1.TabIndex = 0;
            label1.Text = "Doanh Thu";
            // 
            // incomeChartControl1
            // 
            incomeChartControl1.BackColor = SystemColors.ActiveCaption;
            incomeChartControl1.Location = new Point(16, 67);
            incomeChartControl1.Name = "incomeChartControl1";
            incomeChartControl1.Size = new Size(616, 347);
            incomeChartControl1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ngày trong tuần", "Tháng trong năm", "Khoảng thời gian" });
            comboBox1.Location = new Point(797, 67);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(154, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(647, 70);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 3;
            label2.Text = "Xem doanh thu theo";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            startDateLabel.Location = new Point(647, 117);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(99, 20);
            startDateLabel.TabIndex = 4;
            startDateLabel.Text = "Ngày bắt đầu";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            endDateLabel.Location = new Point(647, 152);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(100, 20);
            endDateLabel.TabIndex = 5;
            endDateLabel.Text = "Ngày kết thúc";
            // 
            // startDatePicker
            // 
            startDatePicker.Location = new Point(752, 117);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(200, 23);
            startDatePicker.TabIndex = 6;
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(751, 152);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(200, 23);
            endDatePicker.TabIndex = 7;
            // 
            // viewIncomeButton
            // 
            viewIncomeButton.Location = new Point(836, 181);
            viewIncomeButton.Name = "viewIncomeButton";
            viewIncomeButton.Size = new Size(116, 23);
            viewIncomeButton.TabIndex = 8;
            viewIncomeButton.Text = "Xem doanh thu";
            viewIncomeButton.UseVisualStyleBackColor = true;
            viewIncomeButton.Click += viewIncomeButton_Click;
            // 
            // orderGridView
            // 
            orderGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderGridView.Location = new Point(16, 67);
            orderGridView.Name = "orderGridView";
            orderGridView.RowTemplate.Height = 25;
            orderGridView.Size = new Size(616, 347);
            orderGridView.TabIndex = 9;
            // 
            // totalValueLabel
            // 
            totalValueLabel.AutoSize = true;
            totalValueLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            totalValueLabel.Location = new Point(647, 221);
            totalValueLabel.Name = "totalValueLabel";
            totalValueLabel.Size = new Size(144, 20);
            totalValueLabel.TabIndex = 10;
            totalValueLabel.Text = "Xem doanh thu theo";
            // 
            // Admin_QLDoanhThu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(totalValueLabel);
            Controls.Add(orderGridView);
            Controls.Add(viewIncomeButton);
            Controls.Add(endDatePicker);
            Controls.Add(startDatePicker);
            Controls.Add(endDateLabel);
            Controls.Add(startDateLabel);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(incomeChartControl1);
            Controls.Add(label1);
            Name = "Admin_QLDoanhThu";
            Size = new Size(971, 433);
            ((System.ComponentModel.ISupportInitialize)orderGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Income.IncomeChartControl incomeChartControl1;
        private ComboBox comboBox1;
        private Label label2;
        private Label startDateLabel;
        private Label endDateLabel;
        private DateTimePicker startDatePicker;
        private DateTimePicker endDatePicker;
        private Button viewIncomeButton;
        private DataGridView orderGridView;
        private Label totalValueLabel;
    }
}
