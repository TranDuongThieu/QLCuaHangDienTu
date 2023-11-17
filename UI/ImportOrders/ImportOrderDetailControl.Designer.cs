﻿namespace CuaHangDienTu.UI.ImportOrder
{
    partial class ImportOrderDetailControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportOrderDetailControl));
            pictureBox1 = new PictureBox();
            productNameLabel = new Label();
            productDescriptionLabel = new Label();
            quantityLabel = new Label();
            priceLabel = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(49, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            productNameLabel.Location = new Point(208, 16);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(142, 30);
            productNameLabel.TabIndex = 1;
            productNameLabel.Text = "Tên sản phẩm";
            // 
            // productDescriptionLabel
            // 
            productDescriptionLabel.AutoSize = true;
            productDescriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productDescriptionLabel.Location = new Point(208, 59);
            productDescriptionLabel.Name = "productDescriptionLabel";
            productDescriptionLabel.Size = new Size(122, 21);
            productDescriptionLabel.TabIndex = 2;
            productDescriptionLabel.Text = "Mô tả sản phẩm";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            quantityLabel.Location = new Point(208, 87);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(73, 21);
            quantityLabel.TabIndex = 3;
            quantityLabel.Text = "Số lượng";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(208, 115);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(63, 21);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "Giá tiền";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(555, 0);
            button2.Name = "button2";
            button2.Size = new Size(32, 150);
            button2.TabIndex = 6;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ImportOrderDetailControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            Controls.Add(button2);
            Controls.Add(priceLabel);
            Controls.Add(quantityLabel);
            Controls.Add(productDescriptionLabel);
            Controls.Add(productNameLabel);
            Controls.Add(pictureBox1);
            Name = "ImportOrderDetailControl";
            Size = new Size(587, 150);
            Load += ImportOrderDetailControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label productNameLabel;
        private Label productDescriptionLabel;
        private Label quantityLabel;
        private Label priceLabel;
        private Button button2;
    }
}
