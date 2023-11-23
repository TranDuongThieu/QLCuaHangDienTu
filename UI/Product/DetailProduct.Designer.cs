namespace CuaHangDienTu.UI.Product
{
    partial class DetailProduct
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            label4 = new Label();
            name = new Label();
            gia = new Label();
            baohanh = new Label();
            soluong = new Label();
            daban = new Label();
            mota = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(69, 7);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(8, 422);
            flowLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(421, 79);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // guna2Button2
            // 
            guna2Button2.BorderRadius = 30;
            guna2Button2.CustomizableEdges = customizableEdges1;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(102, 504);
            guna2Button2.Margin = new Padding(2, 2, 2, 2);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button2.Size = new Size(243, 41);
            guna2Button2.TabIndex = 8;
            guna2Button2.Text = "Thêm vào hóa đơn";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(8, 346);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 395);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 12;
            label4.Text = "Thông số kỹ thuật :";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            name.Location = new Point(16, 205);
            name.Margin = new Padding(2, 0, 2, 0);
            name.Name = "name";
            name.Size = new Size(70, 30);
            name.TabIndex = 13;
            name.Text = "label1";
            // 
            // gia
            // 
            gia.AutoSize = true;
            gia.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            gia.Location = new Point(76, 244);
            gia.Margin = new Padding(2, 0, 2, 0);
            gia.Name = "gia";
            gia.Size = new Size(53, 21);
            gia.TabIndex = 14;
            gia.Text = "label1";
            // 
            // baohanh
            // 
            baohanh.AutoSize = true;
            baohanh.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            baohanh.Location = new Point(288, 244);
            baohanh.Margin = new Padding(2, 0, 2, 0);
            baohanh.Name = "baohanh";
            baohanh.Size = new Size(53, 21);
            baohanh.TabIndex = 15;
            baohanh.Text = "label1";
            // 
            // soluong
            // 
            soluong.AutoSize = true;
            soluong.Location = new Point(88, 289);
            soluong.Margin = new Padding(2, 0, 2, 0);
            soluong.Name = "soluong";
            soluong.Size = new Size(38, 15);
            soluong.TabIndex = 16;
            soluong.Text = "label1";
            // 
            // daban
            // 
            daban.AutoSize = true;
            daban.Location = new Point(285, 289);
            daban.Margin = new Padding(2, 0, 2, 0);
            daban.Name = "daban";
            daban.Size = new Size(38, 15);
            daban.TabIndex = 17;
            daban.Text = "label1";
            // 
            // mota
            // 
            mota.BackColor = Color.White;
            mota.BorderStyle = BorderStyle.None;
            mota.Enabled = false;
            mota.Location = new Point(8, 335);
            mota.Margin = new Padding(2, 2, 2, 2);
            mota.Name = "mota";
            mota.Size = new Size(421, 44);
            mota.TabIndex = 18;
            mota.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 314);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 19;
            label1.Text = "Mô tả :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(16, 244);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(41, 21);
            label2.TabIndex = 20;
            label2.Text = "Giá :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(197, 244);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 21;
            label5.Text = "Bảo hành :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(338, 244);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 22;
            label6.Text = "tháng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 289);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 23;
            label7.Text = "Số lượng :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(197, 289);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 24;
            label8.Text = "Đã bán :";
            // 
            // DetailProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(439, 552);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mota);
            Controls.Add(daban);
            Controls.Add(soluong);
            Controls.Add(baohanh);
            Controls.Add(gia);
            Controls.Add(name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(guna2Button2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(2, 2, 2, 2);
            Name = "DetailProduct";
            Text = "DetailProduct";
            Load += DetailProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Label label3;
        private Label label4;
        private Label name;
        private Label gia;
        private Label baohanh;
        private Label soluong;
        private Label daban;
        private RichTextBox mota;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}