﻿namespace CuaHangDienTu.UI.Admin
{
    partial class AdminForm
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
            tabControl = new Guna.UI2.WinForms.Guna2TabControl();
            tabKH = new TabPage();
            tabSP = new TabPage();
            tabHD = new TabPage();
            tabDNH = new TabPage();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Alignment = TabAlignment.Left;
            tabControl.Controls.Add(tabKH);
            tabControl.Controls.Add(tabSP);
            tabControl.Controls.Add(tabHD);
            tabControl.Controls.Add(tabDNH);
            tabControl.Dock = DockStyle.Fill;
            tabControl.ItemSize = new Size(180, 40);
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1528, 778);
            tabControl.TabButtonHoverState.BorderColor = Color.Empty;
            tabControl.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            tabControl.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl.TabButtonHoverState.ForeColor = Color.White;
            tabControl.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            tabControl.TabButtonIdleState.BorderColor = Color.Empty;
            tabControl.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            tabControl.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            tabControl.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            tabControl.TabButtonSelectedState.BorderColor = Color.Empty;
            tabControl.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            tabControl.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl.TabButtonSelectedState.ForeColor = Color.White;
            tabControl.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            tabControl.TabButtonSize = new Size(180, 40);
            tabControl.TabIndex = 4;
            tabControl.TabMenuBackColor = Color.FromArgb(33, 42, 57);
            // 
            // tabKH
            // 
            tabKH.Location = new Point(184, 4);
            tabKH.Name = "tabKH";
            tabKH.Padding = new Padding(3);
            tabKH.Size = new Size(1340, 770);
            tabKH.TabIndex = 0;
            tabKH.Text = "Khách Hàng";
            tabKH.UseVisualStyleBackColor = true;
            // 
            // tabSP
            // 
            tabSP.Location = new Point(184, 4);
            tabSP.Name = "tabSP";
            tabSP.Padding = new Padding(3);
            tabSP.Size = new Size(1417, 749);
            tabSP.TabIndex = 1;
            tabSP.Text = "Sản Phẩm";
            tabSP.UseVisualStyleBackColor = true;
            // 
            // tabHD
            // 
            tabHD.Location = new Point(184, 4);
            tabHD.Name = "tabHD";
            tabHD.Size = new Size(1417, 749);
            tabHD.TabIndex = 2;
            tabHD.Text = "Hóa Đơn";
            tabHD.UseVisualStyleBackColor = true;
            // 
            // tabDNH
            // 
            tabDNH.Location = new Point(184, 4);
            tabDNH.Name = "tabDNH";
            tabDNH.Size = new Size(1417, 749);
            tabDNH.TabIndex = 3;
            tabDNH.Text = "Đơn Nhập Hàng";
            tabDNH.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1528, 778);
            Controls.Add(tabControl);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabControl;
        private TabPage tabKH;
        private TabPage tabSP;
        private TabPage tabHD;
        private TabPage tabDNH;
    }
}