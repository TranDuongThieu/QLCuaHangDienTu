namespace CuaHangDienTu.UI.Main
{
    partial class CreateOrderModalForm
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
            label1 = new Label();
            customerComboBox = new ComboBox();
            label2 = new Label();
            departmentComboBox = new ComboBox();
            confirmButton = new Button();
            cancelButton = new Button();
            newCustomerNameTextBox = new TextBox();
            newCustomerPhoneTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            createNewCustomerButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 25);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 0;
            label1.Text = "Chọn khách hàng";
            // 
            // customerComboBox
            // 
            customerComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerComboBox.FormattingEnabled = true;
            customerComboBox.Location = new Point(41, 53);
            customerComboBox.Name = "customerComboBox";
            customerComboBox.Size = new Size(228, 29);
            customerComboBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 101);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 2;
            label2.Text = "Chọn chi nhánh";
            // 
            // departmentComboBox
            // 
            departmentComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Location = new Point(41, 129);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(228, 29);
            departmentComboBox.TabIndex = 3;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.Lime;
            confirmButton.Location = new Point(41, 181);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(75, 32);
            confirmButton.TabIndex = 4;
            confirmButton.Text = "Xác nhận";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.LightCoral;
            cancelButton.Location = new Point(194, 181);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 32);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Hủy";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // newCustomerNameTextBox
            // 
            newCustomerNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newCustomerNameTextBox.Location = new Point(451, 76);
            newCustomerNameTextBox.Name = "newCustomerNameTextBox";
            newCustomerNameTextBox.Size = new Size(243, 29);
            newCustomerNameTextBox.TabIndex = 6;
            // 
            // newCustomerPhoneTextBox
            // 
            newCustomerPhoneTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newCustomerPhoneTextBox.Location = new Point(451, 129);
            newCustomerPhoneTextBox.Name = "newCustomerPhoneTextBox";
            newCustomerPhoneTextBox.Size = new Size(243, 29);
            newCustomerPhoneTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(451, 25);
            label3.Name = "label3";
            label3.Size = new Size(165, 21);
            label3.TabIndex = 8;
            label3.Text = "Thêm khách hàng mới";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(369, 84);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 9;
            label4.Text = "Họ và tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(344, 137);
            label5.Name = "label5";
            label5.Size = new Size(101, 21);
            label5.TabIndex = 10;
            label5.Text = "Số điện thoại";
            // 
            // createNewCustomerButton
            // 
            createNewCustomerButton.Location = new Point(451, 181);
            createNewCustomerButton.Name = "createNewCustomerButton";
            createNewCustomerButton.Size = new Size(243, 23);
            createNewCustomerButton.TabIndex = 11;
            createNewCustomerButton.Text = "Thêm khách hàng mới";
            createNewCustomerButton.UseVisualStyleBackColor = true;
            createNewCustomerButton.Click += createNewCustomerButton_Click;
            // 
            // CreateOrderModalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 246);
            Controls.Add(createNewCustomerButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(newCustomerPhoneTextBox);
            Controls.Add(newCustomerNameTextBox);
            Controls.Add(cancelButton);
            Controls.Add(confirmButton);
            Controls.Add(departmentComboBox);
            Controls.Add(label2);
            Controls.Add(customerComboBox);
            Controls.Add(label1);
            Name = "CreateOrderModalForm";
            Text = "CreateOrderModalForm";
            Load += CreateOrderModalForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox customerComboBox;
        private Label label2;
        private ComboBox departmentComboBox;
        private Button confirmButton;
        private Button cancelButton;
        private TextBox newCustomerNameTextBox;
        private TextBox newCustomerPhoneTextBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button createNewCustomerButton;
    }
}