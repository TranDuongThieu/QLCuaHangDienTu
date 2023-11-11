namespace CuaHangDienTu.UI.Order
{
    partial class OrderDetailsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetailsControl));
            pictureBox1 = new PictureBox();
            productNameLabel = new Label();
            productDescriptionLabel = new Label();
            increaseQuantityButton = new Button();
            decreaseQuantityButton = new Button();
            label3 = new Label();
            deleteButton = new Button();
            label5 = new Label();
            calculatedValue = new Label();
            productQuantityTextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            productNameLabel.Location = new Point(157, 25);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(126, 30);
            productNameLabel.TabIndex = 1;
            productNameLabel.Text = "Sản phẩm A";
            // 
            // productDescriptionLabel
            // 
            productDescriptionLabel.AutoSize = true;
            productDescriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productDescriptionLabel.Location = new Point(157, 67);
            productDescriptionLabel.Name = "productDescriptionLabel";
            productDescriptionLabel.Size = new Size(343, 21);
            productDescriptionLabel.TabIndex = 2;
            productDescriptionLabel.Text = "Mô tả của sản phẩm A. Mô tả mô tả mô tả mô tả";
            // 
            // increaseQuantityButton
            // 
            increaseQuantityButton.Location = new Point(313, 101);
            increaseQuantityButton.Name = "increaseQuantityButton";
            increaseQuantityButton.Size = new Size(24, 24);
            increaseQuantityButton.TabIndex = 3;
            increaseQuantityButton.Text = "+";
            increaseQuantityButton.UseVisualStyleBackColor = true;
            increaseQuantityButton.Click += increaseQuantityButton_Click;
            // 
            // decreaseQuantityButton
            // 
            decreaseQuantityButton.Location = new Point(236, 101);
            decreaseQuantityButton.Name = "decreaseQuantityButton";
            decreaseQuantityButton.Size = new Size(24, 24);
            decreaseQuantityButton.TabIndex = 4;
            decreaseQuantityButton.Text = "-";
            decreaseQuantityButton.UseVisualStyleBackColor = true;
            decreaseQuantityButton.Click += decreaseQuantityButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(157, 101);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 5;
            label3.Text = "Số lượng";
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.Location = new Point(569, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(25, 23);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "X";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(339, 104);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 8;
            label5.Text = "Thành tiền";
            // 
            // calculatedValue
            // 
            calculatedValue.AutoSize = true;
            calculatedValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            calculatedValue.Location = new Point(427, 104);
            calculatedValue.Name = "calculatedValue";
            calculatedValue.Size = new Size(167, 21);
            calculatedValue.TabIndex = 9;
            calculatedValue.Text = "25.000 x 10 = 250.000";
            // 
            // productQuantityTextbox
            // 
            productQuantityTextbox.Location = new Point(266, 101);
            productQuantityTextbox.Name = "productQuantityTextbox";
            productQuantityTextbox.Size = new Size(41, 23);
            productQuantityTextbox.TabIndex = 10;
            // 
            // OrderDetailsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            Controls.Add(productQuantityTextbox);
            Controls.Add(calculatedValue);
            Controls.Add(label5);
            Controls.Add(deleteButton);
            Controls.Add(label3);
            Controls.Add(decreaseQuantityButton);
            Controls.Add(increaseQuantityButton);
            Controls.Add(productDescriptionLabel);
            Controls.Add(productNameLabel);
            Controls.Add(pictureBox1);
            Name = "OrderDetailsControl";
            Size = new Size(597, 149);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label productNameLabel;
        private Label productDescriptionLabel;
        private Button increaseQuantityButton;
        private Button decreaseQuantityButton;
        private Label label3;
        private Button deleteButton;
        private Label label5;
        private Label calculatedValue;
        private TextBox productQuantityTextbox;
    }
}
