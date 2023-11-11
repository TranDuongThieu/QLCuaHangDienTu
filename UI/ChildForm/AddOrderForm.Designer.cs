namespace CuaHangDienTu.UI.ChildForm
{
    partial class AddOrderForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            orderIdLabel = new Label();
            orderIdTextbox = new TextBox();
            orderCreatedDateLabel = new Label();
            label3 = new Label();
            customerComboBox = new ComboBox();
            label4 = new Label();
            departmentComboBox = new ComboBox();
            label5 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            createOrderButton = new Button();
            button2 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            customerPhoneTextBox = new TextBox();
            customerNameTextBox = new TextBox();
            addCustomerButton = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            addProductLabel = new Label();
            productItemComboBox = new ComboBox();
            addProductToOrderButton = new Button();
            button4 = new Button();
            deleteOrderButton = new Button();
            productQuantityTextBox = new TextBox();
            decreaseQuantityButton = new Button();
            increaseQuantityButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // orderIdLabel
            // 
            orderIdLabel.AutoSize = true;
            orderIdLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            orderIdLabel.Location = new Point(15, 253);
            orderIdLabel.Name = "orderIdLabel";
            orderIdLabel.Size = new Size(127, 30);
            orderIdLabel.TabIndex = 0;
            orderIdLabel.Text = "Mã hóa đơn";
            // 
            // orderIdTextbox
            // 
            orderIdTextbox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            orderIdTextbox.Location = new Point(155, 253);
            orderIdTextbox.Name = "orderIdTextbox";
            orderIdTextbox.Size = new Size(247, 35);
            orderIdTextbox.TabIndex = 1;
            // 
            // orderCreatedDateLabel
            // 
            orderCreatedDateLabel.AutoSize = true;
            orderCreatedDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            orderCreatedDateLabel.Location = new Point(20, 291);
            orderCreatedDateLabel.Name = "orderCreatedDateLabel";
            orderCreatedDateLabel.Size = new Size(202, 21);
            orderCreatedDateLabel.TabIndex = 2;
            orderCreatedDateLabel.Text = "Được tạo ngày: 11/10/2023";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 22);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 3;
            label3.Text = "Khách hàng";
            // 
            // customerComboBox
            // 
            customerComboBox.FormattingEnabled = true;
            customerComboBox.Location = new Point(121, 25);
            customerComboBox.Name = "customerComboBox";
            customerComboBox.Size = new Size(182, 23);
            customerComboBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 164);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 5;
            label4.Text = "Chi nhánh";
            // 
            // departmentComboBox
            // 
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Location = new Point(121, 169);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(182, 23);
            departmentComboBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(667, 17);
            label5.Name = "label5";
            label5.Size = new Size(163, 30);
            label5.TabIndex = 7;
            label5.Text = "Chi tiết hóa đơn";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(427, 67);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(619, 397);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // createOrderButton
            // 
            createOrderButton.BackColor = SystemColors.ActiveCaption;
            createOrderButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            createOrderButton.Location = new Point(21, 205);
            createOrderButton.Name = "createOrderButton";
            createOrderButton.Size = new Size(150, 35);
            createOrderButton.TabIndex = 9;
            createOrderButton.Text = "Tạo hóa đơn";
            createOrderButton.UseVisualStyleBackColor = false;
            createOrderButton.Click += createOrderButton_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(231, 429);
            button2.Name = "button2";
            button2.Size = new Size(150, 35);
            button2.TabIndex = 10;
            button2.Text = "Hủy bỏ";
            button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 62);
            label6.Name = "label6";
            label6.Size = new Size(202, 15);
            label6.TabIndex = 11;
            label6.Text = "Nếu là khách hàng mới, thêm tại đây";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(309, 28);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 12;
            label7.Text = "(Chọn khách hàng)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(53, 95);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 13;
            label8.Text = "Họ và tên";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(53, 128);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 14;
            label9.Text = "Số điện thoại";
            // 
            // customerPhoneTextBox
            // 
            customerPhoneTextBox.Location = new Point(135, 125);
            customerPhoneTextBox.Name = "customerPhoneTextBox";
            customerPhoneTextBox.Size = new Size(168, 23);
            customerPhoneTextBox.TabIndex = 15;
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.Location = new Point(135, 92);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.Size = new Size(168, 23);
            customerNameTextBox.TabIndex = 16;
            // 
            // addCustomerButton
            // 
            addCustomerButton.Location = new Point(309, 92);
            addCustomerButton.Name = "addCustomerButton";
            addCustomerButton.Size = new Size(93, 56);
            addCustomerButton.TabIndex = 17;
            addCustomerButton.Text = "THÊM";
            addCustomerButton.UseVisualStyleBackColor = true;
            addCustomerButton.Click += addCustomerButton_Click;
            // 
            // addProductLabel
            // 
            addProductLabel.AutoSize = true;
            addProductLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addProductLabel.Location = new Point(15, 319);
            addProductLabel.Name = "addProductLabel";
            addProductLabel.Size = new Size(267, 25);
            addProductLabel.TabIndex = 18;
            addProductLabel.Text = "Thêm sản phẩm vào đơn hàng";
            // 
            // productItemComboBox
            // 
            productItemComboBox.FormattingEnabled = true;
            productItemComboBox.Location = new Point(21, 352);
            productItemComboBox.Name = "productItemComboBox";
            productItemComboBox.Size = new Size(182, 23);
            productItemComboBox.TabIndex = 19;
            // 
            // addProductToOrderButton
            // 
            addProductToOrderButton.BackColor = Color.MediumSeaGreen;
            addProductToOrderButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addProductToOrderButton.Location = new Point(231, 387);
            addProductToOrderButton.Name = "addProductToOrderButton";
            addProductToOrderButton.Size = new Size(150, 35);
            addProductToOrderButton.TabIndex = 20;
            addProductToOrderButton.Text = "Thêm >>>";
            addProductToOrderButton.UseVisualStyleBackColor = false;
            addProductToOrderButton.Click += addProductToOrderButton_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.ForestGreen;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(37, 429);
            button4.Name = "button4";
            button4.Size = new Size(150, 35);
            button4.TabIndex = 21;
            button4.Text = "Xác nhận";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // deleteOrderButton
            // 
            deleteOrderButton.BackColor = Color.IndianRed;
            deleteOrderButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteOrderButton.Location = new Point(231, 205);
            deleteOrderButton.Name = "deleteOrderButton";
            deleteOrderButton.Size = new Size(150, 35);
            deleteOrderButton.TabIndex = 22;
            deleteOrderButton.Text = "Xóa hóa đơn";
            deleteOrderButton.UseVisualStyleBackColor = false;
            deleteOrderButton.Click += deleteOrderButton_Click;
            // 
            // productQuantityTextBox
            // 
            productQuantityTextBox.Location = new Point(135, 387);
            productQuantityTextBox.Name = "productQuantityTextBox";
            productQuantityTextBox.Size = new Size(53, 23);
            productQuantityTextBox.TabIndex = 23;
            // 
            // decreaseQuantityButton
            // 
            decreaseQuantityButton.Location = new Point(105, 387);
            decreaseQuantityButton.Name = "decreaseQuantityButton";
            decreaseQuantityButton.Size = new Size(24, 24);
            decreaseQuantityButton.TabIndex = 24;
            decreaseQuantityButton.Text = "-";
            decreaseQuantityButton.UseVisualStyleBackColor = true;
            decreaseQuantityButton.Click += decreaseQuantityButton_Click;
            // 
            // increaseQuantityButton
            // 
            increaseQuantityButton.Location = new Point(194, 387);
            increaseQuantityButton.Name = "increaseQuantityButton";
            increaseQuantityButton.Size = new Size(24, 24);
            increaseQuantityButton.TabIndex = 25;
            increaseQuantityButton.Text = "+";
            increaseQuantityButton.UseVisualStyleBackColor = true;
            increaseQuantityButton.Click += increaseQuantityButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 389);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 26;
            label1.Text = "Số lượng";
            // 
            // AddOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 487);
            Controls.Add(label1);
            Controls.Add(increaseQuantityButton);
            Controls.Add(decreaseQuantityButton);
            Controls.Add(productQuantityTextBox);
            Controls.Add(deleteOrderButton);
            Controls.Add(button4);
            Controls.Add(orderIdTextbox);
            Controls.Add(addProductToOrderButton);
            Controls.Add(orderIdLabel);
            Controls.Add(orderCreatedDateLabel);
            Controls.Add(productItemComboBox);
            Controls.Add(addProductLabel);
            Controls.Add(addCustomerButton);
            Controls.Add(customerNameTextBox);
            Controls.Add(customerPhoneTextBox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(createOrderButton);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label5);
            Controls.Add(departmentComboBox);
            Controls.Add(label4);
            Controls.Add(customerComboBox);
            Controls.Add(label3);
            Name = "AddOrderForm";
            Text = "AddOrderForm";
            Load += AddOrderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label orderIdLabel;
        private TextBox orderIdTextbox;
        private Label orderCreatedDateLabel;
        private Label label3;
        private ComboBox customerComboBox;
        private Label label4;
        private ComboBox departmentComboBox;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button createOrderButton;
        private Button button2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox customerPhoneTextBox;
        private TextBox customerNameTextBox;
        private Button addCustomerButton;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Label addProductLabel;
        private ComboBox productItemComboBox;
        private Button addProductToOrderButton;
        private Button button4;
        private Button deleteOrderButton;
        private TextBox productQuantityTextBox;
        private Button decreaseQuantityButton;
        private Button increaseQuantityButton;
        private Label label1;
    }
}