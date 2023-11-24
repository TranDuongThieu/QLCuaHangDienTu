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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_QLMatHang));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            button1 = new Button();
            filename = new Label();
            btn_add = new Guna.UI2.WinForms.Guna2Button();
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
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)pic_SanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)table_SP).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1381, 542);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(160, 57);
            button1.TabIndex = 42;
            button1.Text = "chọn ảnh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // filename
            // 
            filename.AutoSize = true;
            filename.Location = new Point(893, 603);
            filename.Margin = new Padding(4, 0, 4, 0);
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
            btn_add.Location = new Point(227, 870);
            btn_add.Margin = new Padding(4, 5, 4, 5);
            btn_add.Name = "btn_add";
            btn_add.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_add.Size = new Size(366, 93);
            btn_add.TabIndex = 40;
            btn_add.Text = "Thêm Mặt Hàng";
            btn_add.Click += btn_add_Click;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.Lime;
            btn_Update.Location = new Point(894, 870);
            btn_Update.Margin = new Padding(4, 5, 4, 5);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(204, 83);
            btn_Update.TabIndex = 38;
            btn_Update.Text = "Cập nhật";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // txt_DaBan
            // 
            txt_DaBan.Location = new Point(1460, 803);
            txt_DaBan.Margin = new Padding(4, 5, 4, 5);
            txt_DaBan.Name = "txt_DaBan";
            txt_DaBan.Size = new Size(228, 31);
            txt_DaBan.TabIndex = 37;
            // 
            // txt_SL
            // 
            txt_SL.Location = new Point(1063, 803);
            txt_SL.Margin = new Padding(4, 5, 4, 5);
            txt_SL.Name = "txt_SL";
            txt_SL.Size = new Size(217, 31);
            txt_SL.TabIndex = 36;
            // 
            // txt_Gia
            // 
            txt_Gia.Location = new Point(1063, 718);
            txt_Gia.Margin = new Padding(4, 5, 4, 5);
            txt_Gia.Name = "txt_Gia";
            txt_Gia.Size = new Size(258, 31);
            txt_Gia.TabIndex = 35;
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(1063, 648);
            txt_Ten.Margin = new Padding(4, 5, 4, 5);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.ReadOnly = true;
            txt_Ten.Size = new Size(625, 31);
            txt_Ten.TabIndex = 34;
            // 
            // pic_SanPham
            // 
            pic_SanPham.BorderStyle = BorderStyle.Fixed3D;
            pic_SanPham.Location = new Point(893, 187);
            pic_SanPham.Margin = new Padding(4, 5, 4, 5);
            pic_SanPham.Name = "pic_SanPham";
            pic_SanPham.Size = new Size(478, 409);
            pic_SanPham.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_SanPham.TabIndex = 33;
            pic_SanPham.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1333, 813);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 32;
            label5.Text = "Đã bán : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(893, 803);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 31;
            label4.Text = "Số Lượng : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(894, 718);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 30;
            label3.Text = "Giá :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(894, 653);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 29;
            label2.Text = "Tên Sản Phẩm :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(893, 110);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(312, 45);
            label1.TabIndex = 28;
            label1.Text = "Thông Tin Sản Phẩm";
            // 
            // table_SP
            // 
            table_SP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_SP.Location = new Point(113, 302);
            table_SP.Margin = new Padding(4, 5, 4, 5);
            table_SP.Name = "table_SP";
            table_SP.RowHeadersWidth = 62;
            table_SP.RowTemplate.Height = 33;
            table_SP.Size = new Size(683, 525);
            table_SP.TabIndex = 27;
            table_SP.SelectionChanged += table_SP_SelectionChanged;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(113, 10);
            guna2HtmlLabel1.Margin = new Padding(4, 5, 4, 5);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(684, 72);
            guna2HtmlLabel1.TabIndex = 26;
            guna2HtmlLabel1.Text = "Quản lý mặt hàng sản phẩm";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.CustomizableEdges = customizableEdges3;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.IconLeftSize = new Size(32, 32);
            guna2TextBox1.IconRight = (Image)resources.GetObject("guna2TextBox1.IconRight");
            guna2TextBox1.IconRightCursor = Cursors.Hand;
            guna2TextBox1.IconRightSize = new Size(32, 32);
            guna2TextBox1.Location = new Point(113, 187);
            guna2TextBox1.Margin = new Padding(6, 8, 6, 8);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "Tìm kiếm sản phẩm";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBox1.Size = new Size(683, 73);
            guna2TextBox1.TabIndex = 43;
            // 
            // Admin_QLMatHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2TextBox1);
            Controls.Add(button1);
            Controls.Add(filename);
            Controls.Add(btn_add);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "Admin_QLMatHang";
            Size = new Size(2477, 1428);
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
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}
