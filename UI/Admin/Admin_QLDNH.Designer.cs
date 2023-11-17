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
            label1 = new Label();
            importOrderDataGridView = new DataGridView();
            createImportOrderButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            importOrderIdLabel = new Label();
            distributorIdLabel = new Label();
            departmentIdLabel = new Label();
            totalValueLabel = new Label();
            createdDateLabel = new Label();
            viewImportOrderDetailsButton = new Button();
            deleteImportOrderButton = new Button();
            distributorComboBox = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            departmentComboBox = new ComboBox();
            addDistributorButton = new Button();
            ((System.ComponentModel.ISupportInitialize)importOrderDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(148, 13);
            label1.Name = "label1";
            label1.Size = new Size(136, 32);
            label1.TabIndex = 12;
            label1.Text = "Nhập Hàng";
            label1.Click += label1_Click;
            // 
            // importOrderDataGridView
            // 
            importOrderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            importOrderDataGridView.Location = new Point(36, 65);
            importOrderDataGridView.Name = "importOrderDataGridView";
            importOrderDataGridView.RowTemplate.Height = 25;
            importOrderDataGridView.Size = new Size(415, 175);
            importOrderDataGridView.TabIndex = 13;
            // 
            // createImportOrderButton
            // 
            createImportOrderButton.Location = new Point(36, 318);
            createImportOrderButton.Name = "createImportOrderButton";
            createImportOrderButton.Size = new Size(129, 23);
            createImportOrderButton.TabIndex = 14;
            createImportOrderButton.Text = "Tạo đơn nhập hàng";
            createImportOrderButton.UseVisualStyleBackColor = true;
            createImportOrderButton.Click += createImportOrderButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(600, 13);
            label2.Name = "label2";
            label2.Size = new Size(91, 32);
            label2.TabIndex = 15;
            label2.Text = "Chi tiết";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(505, 65);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 16;
            label3.Text = "Mã đơn nhập hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(505, 100);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 17;
            label4.Text = "Mã nhà cung cấp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(505, 136);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 18;
            label5.Text = "Mã chi nhánh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(505, 175);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 19;
            label6.Text = "Tổng giá trị";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(505, 213);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 20;
            label7.Text = "Ngày nhập hàng";
            // 
            // importOrderIdLabel
            // 
            importOrderIdLabel.AutoSize = true;
            importOrderIdLabel.Location = new Point(643, 65);
            importOrderIdLabel.Name = "importOrderIdLabel";
            importOrderIdLabel.Size = new Size(108, 15);
            importOrderIdLabel.TabIndex = 21;
            importOrderIdLabel.Text = "Mã đơn nhập hàng";
            // 
            // distributorIdLabel
            // 
            distributorIdLabel.AutoSize = true;
            distributorIdLabel.Location = new Point(643, 100);
            distributorIdLabel.Name = "distributorIdLabel";
            distributorIdLabel.Size = new Size(108, 15);
            distributorIdLabel.TabIndex = 22;
            distributorIdLabel.Text = "Mã đơn nhập hàng";
            // 
            // departmentIdLabel
            // 
            departmentIdLabel.AutoSize = true;
            departmentIdLabel.Location = new Point(643, 136);
            departmentIdLabel.Name = "departmentIdLabel";
            departmentIdLabel.Size = new Size(108, 15);
            departmentIdLabel.TabIndex = 23;
            departmentIdLabel.Text = "Mã đơn nhập hàng";
            // 
            // totalValueLabel
            // 
            totalValueLabel.AutoSize = true;
            totalValueLabel.Location = new Point(643, 175);
            totalValueLabel.Name = "totalValueLabel";
            totalValueLabel.Size = new Size(108, 15);
            totalValueLabel.TabIndex = 24;
            totalValueLabel.Text = "Mã đơn nhập hàng";
            // 
            // createdDateLabel
            // 
            createdDateLabel.AutoSize = true;
            createdDateLabel.Location = new Point(643, 213);
            createdDateLabel.Name = "createdDateLabel";
            createdDateLabel.Size = new Size(108, 15);
            createdDateLabel.TabIndex = 25;
            createdDateLabel.Text = "Mã đơn nhập hàng";
            // 
            // viewImportOrderDetailsButton
            // 
            viewImportOrderDetailsButton.Location = new Point(505, 257);
            viewImportOrderDetailsButton.Name = "viewImportOrderDetailsButton";
            viewImportOrderDetailsButton.Size = new Size(99, 23);
            viewImportOrderDetailsButton.TabIndex = 26;
            viewImportOrderDetailsButton.Text = "Xem chi tiết";
            viewImportOrderDetailsButton.UseVisualStyleBackColor = true;
            viewImportOrderDetailsButton.Click += viewImportOrderDetailsButton_Click;
            // 
            // deleteImportOrderButton
            // 
            deleteImportOrderButton.Location = new Point(652, 257);
            deleteImportOrderButton.Name = "deleteImportOrderButton";
            deleteImportOrderButton.Size = new Size(99, 23);
            deleteImportOrderButton.TabIndex = 27;
            deleteImportOrderButton.Text = "Xóa";
            deleteImportOrderButton.UseVisualStyleBackColor = true;
            deleteImportOrderButton.Click += deleteImportOrderButton_Click;
            // 
            // distributorComboBox
            // 
            distributorComboBox.FormattingEnabled = true;
            distributorComboBox.Location = new Point(135, 258);
            distributorComboBox.Name = "distributorComboBox";
            distributorComboBox.Size = new Size(181, 23);
            distributorComboBox.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 261);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 29;
            label8.Text = "Nhà cung cấp";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 289);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 30;
            label9.Text = "Chi nhánh";
            // 
            // departmentComboBox
            // 
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Location = new Point(135, 289);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(181, 23);
            departmentComboBox.TabIndex = 31;
            // 
            // addDistributorButton
            // 
            addDistributorButton.Location = new Point(322, 257);
            addDistributorButton.Name = "addDistributorButton";
            addDistributorButton.Size = new Size(129, 23);
            addDistributorButton.TabIndex = 32;
            addDistributorButton.Text = "Thêm nhà cung cấp mới";
            addDistributorButton.UseVisualStyleBackColor = true;
            // 
            // Admin_QLDNH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addDistributorButton);
            Controls.Add(departmentComboBox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(distributorComboBox);
            Controls.Add(deleteImportOrderButton);
            Controls.Add(viewImportOrderDetailsButton);
            Controls.Add(createdDateLabel);
            Controls.Add(totalValueLabel);
            Controls.Add(departmentIdLabel);
            Controls.Add(distributorIdLabel);
            Controls.Add(importOrderIdLabel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(createImportOrderButton);
            Controls.Add(importOrderDataGridView);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Admin_QLDNH";
            Size = new Size(840, 357);
            Load += Admin_QLDNH_Load;
            ((System.ComponentModel.ISupportInitialize)importOrderDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView importOrderDataGridView;
        private Button createImportOrderButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label importOrderIdLabel;
        private Label distributorIdLabel;
        private Label departmentIdLabel;
        private Label totalValueLabel;
        private Label createdDateLabel;
        private Button viewImportOrderDetailsButton;
        private Button deleteImportOrderButton;
        private ComboBox distributorComboBox;
        private Label label8;
        private Label label9;
        private ComboBox departmentComboBox;
        private Button addDistributorButton;
    }
}
