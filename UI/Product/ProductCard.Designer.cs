namespace CuaHangDienTu.UI.Product
{
    partial class ProductCard
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
            productDetailsButton = new Button();
            addToCartButton = new Button();
            pic_product = new PictureBox();
            lb_name = new Label();
            lb_price = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_product).BeginInit();
            SuspendLayout();
            // 
            // productDetailsButton
            // 
            productDetailsButton.Location = new Point(22, 476);
            productDetailsButton.Margin = new Padding(4, 5, 4, 5);
            productDetailsButton.Name = "productDetailsButton";
            productDetailsButton.Size = new Size(133, 38);
            productDetailsButton.TabIndex = 3;
            productDetailsButton.Text = "Xem chi tiết";
            productDetailsButton.UseVisualStyleBackColor = true;
            productDetailsButton.Click += productDetailsButton_Click;
            // 
            // addToCartButton
            // 
            addToCartButton.Location = new Point(180, 476);
            addToCartButton.Margin = new Padding(4, 5, 4, 5);
            addToCartButton.Name = "addToCartButton";
            addToCartButton.Size = new Size(133, 38);
            addToCartButton.TabIndex = 4;
            addToCartButton.Text = "Thêm vào giỏ hàng";
            addToCartButton.UseVisualStyleBackColor = true;
            // 
            // pic_product
            // 
            pic_product.BorderStyle = BorderStyle.FixedSingle;
            pic_product.InitialImage = null;
            pic_product.Location = new Point(9, 11);
            pic_product.Margin = new Padding(4, 5, 4, 5);
            pic_product.Name = "pic_product";
            pic_product.Size = new Size(355, 335);
            pic_product.TabIndex = 5;
            pic_product.TabStop = false;
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_name.Location = new Point(33, 364);
            lb_name.MinimumSize = new Size(280, 0);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(280, 32);
            lb_name.TabIndex = 6;
            lb_name.Text = "name";
            // 
            // lb_price
            // 
            lb_price.AutoSize = true;
            lb_price.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lb_price.Location = new Point(33, 421);
            lb_price.MaximumSize = new Size(280, 0);
            lb_price.Name = "lb_price";
            lb_price.Size = new Size(61, 30);
            lb_price.TabIndex = 8;
            lb_price.Text = "price";
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lb_price);
            Controls.Add(lb_name);
            Controls.Add(pic_product);
            Controls.Add(addToCartButton);
            Controls.Add(productDetailsButton);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ProductCard";
            Size = new Size(375, 536);
            Load += ProductCard_Load;
            ((System.ComponentModel.ISupportInitialize)pic_product).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button productDetailsButton;
        private Button addToCartButton;
        private PictureBox pic_product;
        private Label lb_name;
        private Label lb_price;
    }
}
