namespace CuaHangDienTu.UI.Order
{
    partial class OrderSummaryCard
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            orderIdLabel = new Label();
            customerNameLabel = new Label();
            departmentNameLabel = new Label();
            orderValueLabel = new Label();
            orderCreatedDateLabel = new Label();
            viewOrderDetailsButton = new Button();
            deleteOrderButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 0);
            label1.Name = "label1";
            label1.Size = new Size(253, 40);
            label1.TabIndex = 0;
            label1.Text = "Thông tin hóa đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 115);
            label2.Name = "label2";
            label2.Size = new Size(98, 17);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 157);
            label3.Name = "label3";
            label3.Size = new Size(87, 17);
            label3.TabIndex = 2;
            label3.Text = "Tên chi nhánh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(55, 76);
            label4.Name = "label4";
            label4.Size = new Size(98, 17);
            label4.TabIndex = 3;
            label4.Text = "Mã số hóa đơn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(55, 195);
            label5.Name = "label5";
            label5.Size = new Size(76, 17);
            label5.TabIndex = 4;
            label5.Text = "Tổng giá trị";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(55, 237);
            label6.Name = "label6";
            label6.Size = new Size(114, 17);
            label6.TabIndex = 5;
            label6.Text = "Ngày lập hóa đơn";
            // 
            // orderIdLabel
            // 
            orderIdLabel.AutoSize = true;
            orderIdLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            orderIdLabel.Location = new Point(193, 76);
            orderIdLabel.Name = "orderIdLabel";
            orderIdLabel.Size = new Size(43, 17);
            orderIdLabel.TabIndex = 6;
            orderIdLabel.Text = "label7";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            customerNameLabel.Location = new Point(193, 115);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(43, 17);
            customerNameLabel.TabIndex = 7;
            customerNameLabel.Text = "label8";
            // 
            // departmentNameLabel
            // 
            departmentNameLabel.AutoSize = true;
            departmentNameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            departmentNameLabel.Location = new Point(193, 157);
            departmentNameLabel.Name = "departmentNameLabel";
            departmentNameLabel.Size = new Size(43, 17);
            departmentNameLabel.TabIndex = 8;
            departmentNameLabel.Text = "label9";
            // 
            // orderValueLabel
            // 
            orderValueLabel.AutoSize = true;
            orderValueLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            orderValueLabel.Location = new Point(193, 195);
            orderValueLabel.Name = "orderValueLabel";
            orderValueLabel.Size = new Size(50, 17);
            orderValueLabel.TabIndex = 9;
            orderValueLabel.Text = "label10";
            // 
            // orderCreatedDateLabel
            // 
            orderCreatedDateLabel.AutoSize = true;
            orderCreatedDateLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            orderCreatedDateLabel.Location = new Point(193, 237);
            orderCreatedDateLabel.Name = "orderCreatedDateLabel";
            orderCreatedDateLabel.Size = new Size(50, 17);
            orderCreatedDateLabel.TabIndex = 10;
            orderCreatedDateLabel.Text = "label11";
            // 
            // viewOrderDetailsButton
            // 
            viewOrderDetailsButton.Location = new Point(57, 300);
            viewOrderDetailsButton.Name = "viewOrderDetailsButton";
            viewOrderDetailsButton.Size = new Size(96, 23);
            viewOrderDetailsButton.TabIndex = 11;
            viewOrderDetailsButton.Text = "Xem chi tiết";
            viewOrderDetailsButton.UseVisualStyleBackColor = true;
            viewOrderDetailsButton.Click += viewOrderDetailsButton_Click;
            // 
            // deleteOrderButton
            // 
            deleteOrderButton.Location = new Point(193, 300);
            deleteOrderButton.Name = "deleteOrderButton";
            deleteOrderButton.Size = new Size(96, 23);
            deleteOrderButton.TabIndex = 12;
            deleteOrderButton.Text = "Xóa";
            deleteOrderButton.UseVisualStyleBackColor = true;
            deleteOrderButton.Click += deleteOrderButton_Click;
            // 
            // OrderSummaryCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(deleteOrderButton);
            Controls.Add(viewOrderDetailsButton);
            Controls.Add(orderCreatedDateLabel);
            Controls.Add(orderValueLabel);
            Controls.Add(departmentNameLabel);
            Controls.Add(customerNameLabel);
            Controls.Add(orderIdLabel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OrderSummaryCard";
            Size = new Size(348, 359);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label orderIdLabel;
        private Label customerNameLabel;
        private Label departmentNameLabel;
        private Label orderValueLabel;
        private Label orderCreatedDateLabel;
        private Button viewOrderDetailsButton;
        private Button deleteOrderButton;
    }
}
