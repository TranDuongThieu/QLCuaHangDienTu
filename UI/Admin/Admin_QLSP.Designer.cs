namespace CuaHangDienTu.UI.Admin
{
    partial class Admin_QLSP
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
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            table_SP = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pic_SanPham = new PictureBox();
            txt_Ten = new TextBox();
            txt_Gia = new TextBox();
            txt_SL = new TextBox();
            txt_DaBan = new TextBox();
            btn_Update = new Button();
            btn_Xoa = new Button();
            btn_add = new Guna.UI2.WinForms.Guna2Button();
            filename = new Label();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)table_SP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_SanPham).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(12, 20);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(684, 72);
            guna2HtmlLabel1.TabIndex = 5;
            guna2HtmlLabel1.Text = "Quản lý mặt hàng sản phẩm";
            // 
            // table_SP
            // 
            table_SP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_SP.Location = new Point(23, 163);
            table_SP.Name = "table_SP";
            table_SP.RowHeadersWidth = 62;
            table_SP.RowTemplate.Height = 33;
            table_SP.Size = new Size(601, 362);
            table_SP.TabIndex = 6;
            table_SP.SelectionChanged += table_SP_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(760, 78);
            label1.Name = "label1";
            label1.Size = new Size(312, 45);
            label1.TabIndex = 7;
            label1.Text = "Thông Tin Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(642, 509);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 8;
            label2.Text = "Tên Sản Phẩm :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(727, 556);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 9;
            label3.Text = "Giá :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(670, 607);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 10;
            label4.Text = "Số Lượng : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(977, 613);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 11;
            label5.Text = "Đã bán : ";
            // 
            // pic_SanPham
            // 
            pic_SanPham.BorderStyle = BorderStyle.Fixed3D;
            pic_SanPham.Location = new Point(685, 163);
            pic_SanPham.Name = "pic_SanPham";
            pic_SanPham.Size = new Size(542, 273);
            pic_SanPham.TabIndex = 12;
            pic_SanPham.TabStop = false;
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(788, 506);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.ReadOnly = true;
            txt_Ten.Size = new Size(439, 31);
            txt_Ten.TabIndex = 17;
            // 
            // txt_Gia
            // 
            txt_Gia.Location = new Point(788, 556);
            txt_Gia.Name = "txt_Gia";
            txt_Gia.Size = new Size(182, 31);
            txt_Gia.TabIndex = 18;
            // 
            // txt_SL
            // 
            txt_SL.Location = new Point(788, 607);
            txt_SL.Name = "txt_SL";
            txt_SL.Size = new Size(153, 31);
            txt_SL.TabIndex = 19;
            // 
            // txt_DaBan
            // 
            txt_DaBan.Location = new Point(1066, 607);
            txt_DaBan.Name = "txt_DaBan";
            txt_DaBan.Size = new Size(161, 31);
            txt_DaBan.TabIndex = 20;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.Lime;
            btn_Update.Location = new Point(787, 664);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(143, 50);
            btn_Update.TabIndex = 21;
            btn_Update.Text = "Cập nhật";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.BackColor = Color.Red;
            btn_Xoa.Location = new Point(1013, 664);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(143, 50);
            btn_Xoa.TabIndex = 22;
            btn_Xoa.Text = "Xóa Sản Phẩm";
            btn_Xoa.UseVisualStyleBackColor = false;
            btn_Xoa.Click += btn_Xoa_Click;
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
            btn_add.Location = new Point(175, 603);
            btn_add.Name = "btn_add";
            btn_add.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_add.Size = new Size(270, 68);
            btn_add.TabIndex = 23;
            btn_add.Text = "Thêm Mặt Hàng";
            btn_add.Click += btn_add_Click;
            // 
            // filename
            // 
            filename.AutoSize = true;
            filename.Location = new Point(803, 448);
            filename.Name = "filename";
            filename.Size = new Size(79, 25);
            filename.TabIndex = 24;
            filename.Text = "filename";
            filename.Click += filename_Click;
            // 
            // button1
            // 
            button1.Location = new Point(685, 443);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 25;
            button1.Text = "chọn ảnh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Admin_QLSP
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
            Name = "Admin_QLSP";
            Size = new Size(1268, 798);
            Load += Admin_QLSP_Load;
            ((System.ComponentModel.ISupportInitialize)table_SP).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_SanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private DataGridView table_SP;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pic_SanPham;
        private TextBox txt_Ten;
        private TextBox txt_Gia;
        private TextBox txt_SL;
        private TextBox txt_DaBan;
        private Button btn_Update;
        private Button btn_Xoa;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Label filename;
        private Button button1;
        private OpenFileDialog openFileDialog1;
    }
}
