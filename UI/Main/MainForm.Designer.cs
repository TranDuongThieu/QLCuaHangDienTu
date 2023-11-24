namespace CuaHangDienTu.UI.Main
{
    partial class MainForm
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
            guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            tab_phone = new TabPage();
            tab_tablet = new TabPage();
            tab_laptop = new TabPage();
            tab_hoadon = new TabPage();
            guna2TabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2TabControl1
            // 
            guna2TabControl1.Alignment = TabAlignment.Left;
            guna2TabControl1.Controls.Add(tab_phone);
            guna2TabControl1.Controls.Add(tab_tablet);
            guna2TabControl1.Controls.Add(tab_laptop);
            guna2TabControl1.Controls.Add(tab_hoadon);
            guna2TabControl1.Dock = DockStyle.Fill;
            guna2TabControl1.ItemSize = new Size(180, 40);
            guna2TabControl1.Location = new Point(0, 0);
            guna2TabControl1.Margin = new Padding(2);
            guna2TabControl1.Name = "guna2TabControl1";
            guna2TabControl1.SelectedIndex = 0;
            guna2TabControl1.Size = new Size(986, 450);
            guna2TabControl1.TabButtonHoverState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TabControl1.TabButtonHoverState.ForeColor = Color.White;
            guna2TabControl1.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonIdleState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TabControl1.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            guna2TabControl1.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabButtonSelectedState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            guna2TabControl1.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TabControl1.TabButtonSelectedState.ForeColor = Color.White;
            guna2TabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            guna2TabControl1.TabButtonSize = new Size(180, 40);
            guna2TabControl1.TabIndex = 0;
            guna2TabControl1.TabMenuBackColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.Click += orderTabClick;
            // 
            // tab_phone
            // 
            tab_phone.Location = new Point(184, 4);
            tab_phone.Margin = new Padding(2);
            tab_phone.Name = "tab_phone";
            tab_phone.Padding = new Padding(2);
            tab_phone.Size = new Size(798, 442);
            tab_phone.TabIndex = 0;
            tab_phone.Text = "Điện Thoại";
            tab_phone.UseVisualStyleBackColor = true;
            tab_phone.Click += tab_phone_Click;
            // 
            // tab_tablet
            // 
            tab_tablet.Location = new Point(184, 4);
            tab_tablet.Margin = new Padding(2);
            tab_tablet.Name = "tab_tablet";
            tab_tablet.Padding = new Padding(2);
            tab_tablet.Size = new Size(798, 442);
            tab_tablet.TabIndex = 1;
            tab_tablet.Text = "Tablet";
            tab_tablet.UseVisualStyleBackColor = true;
            // 
            // tab_laptop
            // 
            tab_laptop.Location = new Point(184, 4);
            tab_laptop.Margin = new Padding(2);
            tab_laptop.Name = "tab_laptop";
            tab_laptop.Size = new Size(798, 442);
            tab_laptop.TabIndex = 2;
            tab_laptop.Text = "Laptop";
            tab_laptop.UseVisualStyleBackColor = true;
            // 
            // tab_hoadon
            // 
            tab_hoadon.Location = new Point(184, 4);
            tab_hoadon.Margin = new Padding(2);
            tab_hoadon.Name = "tab_hoadon";
            tab_hoadon.Padding = new Padding(2);
            tab_hoadon.Size = new Size(798, 442);
            tab_hoadon.TabIndex = 3;
            tab_hoadon.Text = "Hóa Đơn";
            tab_hoadon.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 450);
            Controls.Add(guna2TabControl1);
            Name = "MainForm";
            Text = "MainForm";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            guna2TabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button logoutButton;
        private Button view1Button;
        private Button view2Button;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private TabPage tab_phone;
        private TabPage tab_tablet;
        private TabPage tab_laptop;
        private TabPage tab_hoadon;
    }
}