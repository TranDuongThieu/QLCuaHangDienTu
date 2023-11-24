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
            productDetailsButton.Location = new Point(15, 286);
            productDetailsButton.Name = "productDetailsButton";
            productDetailsButton.Size = new Size(93, 23);
            productDetailsButton.TabIndex = 3;
            productDetailsButton.Text = "Xem chi tiết";
            productDetailsButton.UseVisualStyleBackColor = true;
            productDetailsButton.Click += productDetailsButton_Click;
            // 
            // addToCartButton
            // 
            addToCartButton.Location = new Point(126, 286);
            addToCartButton.Name = "addToCartButton";
            addToCartButton.Size = new Size(93, 23);
            addToCartButton.TabIndex = 4;
            addToCartButton.Text = "Thêm vào giỏ hàng";
            addToCartButton.UseVisualStyleBackColor = true;
            addToCartButton.Click += addToCartButton_Click;
            // 
            // pic_product
            // 
            pic_product.BorderStyle = BorderStyle.FixedSingle;
            pic_product.InitialImage = null;
            pic_product.Location = new Point(6, 7);
            pic_product.Name = "pic_product";
            pic_product.Size = new Size(249, 202);
            pic_product.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_product.TabIndex = 5;
            pic_product.TabStop = false;
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_name.Location = new Point(23, 218);
            lb_name.Margin = new Padding(2, 0, 2, 0);
            lb_name.MinimumSize = new Size(196, 0);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(196, 21);
            lb_name.TabIndex = 6;
            lb_name.Text = "name";
            lb_name.Click += lb_name_Click;
            // 
            // lb_price
            // 
            lb_price.AutoSize = true;
            lb_price.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lb_price.Location = new Point(23, 253);
            lb_price.Margin = new Padding(2, 0, 2, 0);
            lb_price.MaximumSize = new Size(196, 0);
            lb_price.Name = "lb_price";
            lb_price.Size = new Size(42, 20);
            lb_price.TabIndex = 8;
            lb_price.Text = "price";
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lb_price);
            Controls.Add(lb_name);
            Controls.Add(pic_product);
            Controls.Add(addToCartButton);
            Controls.Add(productDetailsButton);
            Name = "ProductCard";
            Size = new Size(262, 322);
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
