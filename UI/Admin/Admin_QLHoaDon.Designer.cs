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
            addOrderButton = new Button();
            SuspendLayout();
            // 
            // addOrderButton
            // 
            addOrderButton.BackColor = SystemColors.ActiveCaption;
            addOrderButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addOrderButton.Location = new Point(99, 650);
            addOrderButton.Margin = new Padding(4, 5, 4, 5);
            addOrderButton.Name = "addOrderButton";
            addOrderButton.Size = new Size(171, 58);
            addOrderButton.TabIndex = 1;
            addOrderButton.Text = "Tạo hóa đơn";
            addOrderButton.UseVisualStyleBackColor = false;
            addOrderButton.Click += addOrderButton_Click;
            // 
            // Admin_QLHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addOrderButton);
            Name = "Admin_QLHoaDon";
            Size = new Size(1257, 713);
            Load += Admin_QLHoaDon_Load;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Button addOrderButton;
    }
}
