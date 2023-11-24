namespace CuaHangDienTu.UI.Main
{
    partial class OrderForm
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
            noOrderLabel = new Label();
            createOrderInstructLabel = new Label();
            createOrderButton = new Button();
            orderTitleLabel = new Label();
            deleteOrderButton = new Button();
            createNewOrderButton = new Button();
            orderSummaryCard1 = new Order.OrderSummaryCard();
            SuspendLayout();
            // 
            // noOrderLabel
            // 
            noOrderLabel.AutoSize = true;
            noOrderLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            noOrderLabel.Location = new Point(264, 148);
            noOrderLabel.Name = "noOrderLabel";
            noOrderLabel.Size = new Size(247, 40);
            noOrderLabel.TabIndex = 0;
            noOrderLabel.Text = "Chưa tạo hóa đơn";
            // 
            // createOrderInstructLabel
            // 
            createOrderInstructLabel.AutoSize = true;
            createOrderInstructLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createOrderInstructLabel.Location = new Point(304, 198);
            createOrderInstructLabel.Name = "createOrderInstructLabel";
            createOrderInstructLabel.Size = new Size(166, 21);
            createOrderInstructLabel.TabIndex = 1;
            createOrderInstructLabel.Text = "(Vui lòng tạo hóa đơn)";
            // 
            // createOrderButton
            // 
            createOrderButton.BackColor = Color.FromArgb(128, 255, 128);
            createOrderButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            createOrderButton.Location = new Point(314, 231);
            createOrderButton.Name = "createOrderButton";
            createOrderButton.Size = new Size(129, 39);
            createOrderButton.TabIndex = 2;
            createOrderButton.Text = "Tạo hóa đơn";
            createOrderButton.UseVisualStyleBackColor = false;
            createOrderButton.Click += createOrderButton_Click;
            // 
            // orderTitleLabel
            // 
            orderTitleLabel.AutoSize = true;
            orderTitleLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            orderTitleLabel.Location = new Point(264, 35);
            orderTitleLabel.Name = "orderTitleLabel";
            orderTitleLabel.Size = new Size(141, 37);
            orderTitleLabel.TabIndex = 3;
            orderTitleLabel.Text = "Đơn hàng ";
            // 
            // deleteOrderButton
            // 
            deleteOrderButton.Location = new Point(490, 383);
            deleteOrderButton.Name = "deleteOrderButton";
            deleteOrderButton.Size = new Size(121, 32);
            deleteOrderButton.TabIndex = 4;
            deleteOrderButton.Text = "Xóa hóa đơn";
            deleteOrderButton.UseVisualStyleBackColor = true;
            deleteOrderButton.Click += deleteOrderButton_Click;
            // 
            // createNewOrderButton
            // 
            createNewOrderButton.Location = new Point(640, 383);
            createNewOrderButton.Name = "createNewOrderButton";
            createNewOrderButton.Size = new Size(121, 32);
            createNewOrderButton.TabIndex = 5;
            createNewOrderButton.Text = "Tạo hóa đơn mới";
            createNewOrderButton.UseVisualStyleBackColor = true;
            createNewOrderButton.Click += createNewOrderButton_Click;
            // 
            // orderSummaryCard1
            // 
            orderSummaryCard1.Location = new Point(654, 18);
            orderSummaryCard1.Name = "orderSummaryCard1";
            orderSummaryCard1.Size = new Size(348, 359);
            orderSummaryCard1.TabIndex = 6;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(orderSummaryCard1);
            Controls.Add(createNewOrderButton);
            Controls.Add(deleteOrderButton);
            Controls.Add(orderTitleLabel);
            Controls.Add(createOrderButton);
            Controls.Add(createOrderInstructLabel);
            Controls.Add(noOrderLabel);
            Name = "OrderForm";
            Size = new Size(1027, 442);
            Load += OrderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label noOrderLabel;
        public Label createOrderInstructLabel;
        private Button createOrderButton;
        private Label orderTitleLabel;
        private Button deleteOrderButton;
        private Button createNewOrderButton;
        private Order.OrderSummaryCard orderSummaryCard1;
    }
}
