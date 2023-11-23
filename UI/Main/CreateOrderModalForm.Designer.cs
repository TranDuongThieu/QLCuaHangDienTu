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
            // CreateOrderModalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 246);
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
    }
}