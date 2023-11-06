namespace CuaHangDienTu.UI.Admin
{
    partial class Admin_QLKH
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            MaKH = new DataGridViewTextBoxColumn();
            tenKH = new DataGridViewTextBoxColumn();
            sdt = new DataGridViewTextBoxColumn();
            diemThanhVien = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaKH, tenKH, sdt, diemThanhVien });
            dataGridView1.Location = new Point(57, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1276, 460);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(57, 154);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(202, 154);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(347, 154);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 3;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(57, 23);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(483, 72);
            guna2HtmlLabel1.TabIndex = 4;
            guna2HtmlLabel1.Text = "Quản lý khách hàng";
            // 
            // MaKH
            // 
            MaKH.DataPropertyName = "MaKH";
            MaKH.HeaderText = "Mã Khách Hàng";
            MaKH.MinimumWidth = 8;
            MaKH.Name = "MaKH";
            // 
            // tenKH
            // 
            tenKH.DataPropertyName = "HoTenKH";
            tenKH.HeaderText = "Họ Tên Khách Hàng";
            tenKH.MinimumWidth = 8;
            tenKH.Name = "tenKH";
            // 
            // sdt
            // 
            sdt.DataPropertyName = "SoDienThoai";
            sdt.HeaderText = "Số Điện Thoại";
            sdt.MinimumWidth = 8;
            sdt.Name = "sdt";
            // 
            // diemThanhVien
            // 
            diemThanhVien.DataPropertyName = "DiemThanhVien";
            diemThanhVien.HeaderText = "Điểm Thành Viên";
            diemThanhVien.MinimumWidth = 8;
            diemThanhVien.Name = "diemThanhVien";
            // 
            // Admin_QLKH
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Admin_QLKH";
            Size = new Size(1485, 820);
            Load += Admin_QLKH_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn tenKH;
        private DataGridViewTextBoxColumn sdt;
        private DataGridViewTextBoxColumn diemThanhVien;
    }
}
