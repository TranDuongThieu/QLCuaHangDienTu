namespace CuaHangDienTu.UI.Admin
{
    partial class Admin_QLDNH
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
            dataGridView2 = new DataGridView();
            DaBan = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            Gia = new DataGridViewTextBoxColumn();
            Ten = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { id, Ten, Gia, SoLuong, DaBan });
            dataGridView2.Location = new Point(39, 136);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(883, 225);
            dataGridView2.TabIndex = 11;
            // 
            // DaBan
            // 
            DaBan.HeaderText = "Đã Bán";
            DaBan.MinimumWidth = 8;
            DaBan.Name = "DaBan";
            // 
            // SoLuong
            // 
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.MinimumWidth = 8;
            SoLuong.Name = "SoLuong";
            // 
            // Gia
            // 
            Gia.HeaderText = "Giá";
            Gia.MinimumWidth = 8;
            Gia.Name = "Gia";
            // 
            // Ten
            // 
            Ten.HeaderText = "Tên Mặt Hàng";
            Ten.MinimumWidth = 8;
            Ten.Name = "Ten";
            // 
            // id
            // 
            id.HeaderText = "Mã Mặt Hàng";
            id.MinimumWidth = 8;
            id.Name = "id";
            // 
            // Admin_QLDNH
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView2);
            Name = "Admin_QLDNH";
            Size = new Size(945, 595);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DaBan;
    }
}
