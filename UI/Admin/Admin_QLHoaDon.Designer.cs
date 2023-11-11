namespace CuaHangDienTu.UI.Admin
{
    partial class Admin_QLHoaDon
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
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            addOrderButton = new Button();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(333, 12);
            guna2HtmlLabel1.Margin = new Padding(2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(176, 34);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Quản lí hóa đơn";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // addOrderButton
            // 
            addOrderButton.BackColor = SystemColors.ActiveCaption;
            addOrderButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addOrderButton.Location = new Point(69, 390);
            addOrderButton.Name = "addOrderButton";
            addOrderButton.Size = new Size(120, 35);
            addOrderButton.TabIndex = 1;
            addOrderButton.Text = "Tạo hóa đơn";
            addOrderButton.UseVisualStyleBackColor = false;
            addOrderButton.Click += addOrderButton_Click;
            // 
            // Admin_QLHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addOrderButton);
            Controls.Add(guna2HtmlLabel1);
            Margin = new Padding(2);
            Name = "Admin_QLHoaDon";
            Size = new Size(880, 428);
            Load += Admin_QLHoaDon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Button addOrderButton;
    }
}
