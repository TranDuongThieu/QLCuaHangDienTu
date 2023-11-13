namespace CuaHangDienTu.UI.Admin
{
    partial class Admin_QLMatHang
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            button1 = new Button();
            filename = new Label();
            btn_add = new Guna.UI2.WinForms.Guna2Button();
            btn_Xoa = new Button();
            btn_Update = new Button();
            txt_DaBan = new TextBox();
            txt_SL = new TextBox();
            txt_Gia = new TextBox();
            txt_Ten = new TextBox();
            pic_SanPham = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            table_SP = new DataGridView();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pic_SanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)table_SP).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(752, 429);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 42;
            button1.Text = "chọn ảnh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // filename
            // 
            filename.AutoSize = true;
            filename.Location = new Point(870, 434);
            filename.Name = "filename";
            filename.Size = new Size(79, 25);
            filename.TabIndex = 41;
            filename.Text = "filename";
            // 
            // btn_add
            // 
            btn_add.BorderRadius = 30;
            btn_add.CustomizableEdges = customizableEdges1;
            btn_add.DisabledState.BorderColor = Color.DarkGray;
            btn_add.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_add.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_add.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_add.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(242, 589);
            btn_add.Name = "btn_add";
            btn_add.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_add.Size = new Size(270, 68);
            btn_add.TabIndex = 40;
            btn_add.Text = "Thêm Mặt Hàng";
            btn_add.Click += btn_add_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.BackColor = Color.Red;
            btn_Xoa.Location = new Point(1080, 650);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(143, 50);
            btn_Xoa.TabIndex = 39;
            btn_Xoa.Text = "Xóa Sản Phẩm";
            btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.Lime;
            btn_Update.Location = new Point(854, 650);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(143, 50);
            btn_Update.TabIndex = 38;
            btn_Update.Text = "Cập nhật";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // txt_DaBan
            // 
            txt_DaBan.Location = new Point(1133, 593);
            txt_DaBan.Name = "txt_DaBan";
            txt_DaBan.Size = new Size(161, 31);
            txt_DaBan.TabIndex = 37;
            // 
            // txt_SL
            // 
            txt_SL.Location = new Point(855, 593);
            txt_SL.Name = "txt_SL";
            txt_SL.Size = new Size(153, 31);
            txt_SL.TabIndex = 36;
            // 
            // txt_Gia
            // 
            txt_Gia.Location = new Point(855, 542);
            txt_Gia.Name = "txt_Gia";
            txt_Gia.Size = new Size(182, 31);
            txt_Gia.TabIndex = 35;
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(855, 492);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.ReadOnly = true;
            txt_Ten.Size = new Size(439, 31);
            txt_Ten.TabIndex = 34;
            // 
            // pic_SanPham
            // 
            pic_SanPham.BorderStyle = BorderStyle.Fixed3D;
            pic_SanPham.Location = new Point(752, 149);
            pic_SanPham.Name = "pic_SanPham";
            pic_SanPham.Size = new Size(542, 273);
            pic_SanPham.TabIndex = 33;
            pic_SanPham.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1044, 599);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 32;
            label5.Text = "Đã bán : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(737, 593);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 31;
            label4.Text = "Số Lượng : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(794, 542);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 30;
            label3.Text = "Giá :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(709, 495);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 29;
            label2.Text = "Tên Sản Phẩm :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(827, 64);
            label1.Name = "label1";
            label1.Size = new Size(312, 45);
            label1.TabIndex = 28;
            label1.Text = "Thông Tin Sản Phẩm";
            // 
            // table_SP
            // 
            table_SP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_SP.Location = new Point(90, 149);
            table_SP.Name = "table_SP";
            table_SP.RowHeadersWidth = 62;
            table_SP.RowTemplate.Height = 33;
            table_SP.Size = new Size(601, 362);
            table_SP.TabIndex = 27;
            table_SP.SelectionChanged += table_SP_SelectionChanged;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(79, 6);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(684, 72);
            guna2HtmlLabel1.TabIndex = 26;
            guna2HtmlLabel1.Text = "Quản lý mặt hàng sản phẩm";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Admin_QLMatHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(filename);
            Controls.Add(btn_add);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Update);
            Controls.Add(txt_DaBan);
            Controls.Add(txt_SL);
            Controls.Add(txt_Gia);
            Controls.Add(txt_Ten);
            Controls.Add(pic_SanPham);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(table_SP);
            Controls.Add(guna2HtmlLabel1);
            Name = "Admin_QLMatHang";
            Size = new Size(1408, 742);
            Load += Admin_QLMatHang_Load;
            ((System.ComponentModel.ISupportInitialize)pic_SanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)table_SP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label filename;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Button btn_Xoa;
        private Button btn_Update;
        private TextBox txt_DaBan;
        private TextBox txt_SL;
        private TextBox txt_Gia;
        private TextBox txt_Ten;
        private PictureBox pic_SanPham;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView table_SP;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private OpenFileDialog openFileDialog1;
    }
}
