namespace CuaHangDienTu.UI.ChildForm
{
    partial class AddImportOrderForm
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
            importOrderIdLabel = new Label();
            button1 = new Button();
            label1 = new Label();
            productItemCombobox = new ComboBox();
            deleteImportOrder = new Button();
            label2 = new Label();
            quantityTextBox = new TextBox();
            decreaseQuantityButton = new Button();
            increaseQuantityButton = new Button();
            addProductItemButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            importPriceTextBox = new TextBox();
            SuspendLayout();
            // 
            // importOrderIdLabel
            // 
            importOrderIdLabel.AutoSize = true;
            importOrderIdLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            importOrderIdLabel.Location = new Point(124, 9);
            importOrderIdLabel.Name = "importOrderIdLabel";
            importOrderIdLabel.Size = new Size(252, 32);
            importOrderIdLabel.TabIndex = 0;
            importOrderIdLabel.Text = "Đơn nhập hàng mã số";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Location = new Point(55, 387);
            button1.Name = "button1";
            button1.Size = new Size(148, 23);
            button1.TabIndex = 1;
            button1.Text = "XÁC NHẬN ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 76);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 3;
            label1.Text = "Sản phẩm";
            // 
            // productItemCombobox
            // 
            productItemCombobox.FormattingEnabled = true;
            productItemCombobox.Location = new Point(141, 76);
            productItemCombobox.Name = "productItemCombobox";
            productItemCombobox.Size = new Size(235, 23);
            productItemCombobox.TabIndex = 4;
            // 
            // deleteImportOrder
            // 
            deleteImportOrder.BackColor = Color.FromArgb(255, 128, 128);
            deleteImportOrder.Location = new Point(228, 387);
            deleteImportOrder.Name = "deleteImportOrder";
            deleteImportOrder.Size = new Size(148, 23);
            deleteImportOrder.TabIndex = 5;
            deleteImportOrder.Text = "HỦY ĐƠN";
            deleteImportOrder.UseVisualStyleBackColor = false;
            deleteImportOrder.Click += deleteImportOrder_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 106);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 6;
            label2.Text = "Số lượng";
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(192, 108);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(63, 23);
            quantityTextBox.TabIndex = 9;
            // 
            // decreaseQuantityButton
            // 
            decreaseQuantityButton.Location = new Point(161, 108);
            decreaseQuantityButton.Name = "decreaseQuantityButton";
            decreaseQuantityButton.Size = new Size(20, 23);
            decreaseQuantityButton.TabIndex = 10;
            decreaseQuantityButton.Text = "-";
            decreaseQuantityButton.UseVisualStyleBackColor = true;
            decreaseQuantityButton.Click += decreaseQuantityButton_Click;
            // 
            // increaseQuantityButton
            // 
            increaseQuantityButton.Location = new Point(270, 108);
            increaseQuantityButton.Name = "increaseQuantityButton";
            increaseQuantityButton.Size = new Size(20, 23);
            increaseQuantityButton.TabIndex = 11;
            increaseQuantityButton.Text = "+";
            increaseQuantityButton.UseVisualStyleBackColor = true;
            increaseQuantityButton.Click += increaseQuantityButton_Click;
            // 
            // addProductItemButton
            // 
            addProductItemButton.Location = new Point(55, 137);
            addProductItemButton.Name = "addProductItemButton";
            addProductItemButton.Size = new Size(143, 23);
            addProductItemButton.TabIndex = 12;
            addProductItemButton.Text = "Chọn sản phẩm >>>";
            addProductItemButton.UseVisualStyleBackColor = true;
            addProductItemButton.Click += addProductItemButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(416, 76);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(643, 362);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(628, 9);
            label3.Name = "label3";
            label3.Size = new Size(262, 32);
            label3.TabIndex = 14;
            label3.Text = "Chi tiết đơn nhập hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(55, 173);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 15;
            label4.Text = "Giá nhập";
            // 
            // importPriceTextBox
            // 
            importPriceTextBox.Location = new Point(135, 175);
            importPriceTextBox.Name = "importPriceTextBox";
            importPriceTextBox.Size = new Size(88, 23);
            importPriceTextBox.TabIndex = 16;
            // 
            // AddImportOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 450);
            Controls.Add(importPriceTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(addProductItemButton);
            Controls.Add(increaseQuantityButton);
            Controls.Add(decreaseQuantityButton);
            Controls.Add(quantityTextBox);
            Controls.Add(label2);
            Controls.Add(deleteImportOrder);
            Controls.Add(productItemCombobox);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(importOrderIdLabel);
            Name = "AddImportOrderForm";
            Text = "AddImportOrderForm";
            Load += AddImportOrderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label importOrderIdLabel;
        private Button button1;
        private Label label1;
        private ComboBox productItemCombobox;
        private Button deleteImportOrder;
        private Label label2;
        private TextBox quantityTextBox;
        private Button decreaseQuantityButton;
        private Button increaseQuantityButton;
        private Button addProductItemButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private Label label4;
        private TextBox importPriceTextBox;
    }
}