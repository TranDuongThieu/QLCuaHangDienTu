namespace CuaHangDienTu.UI.Login
{
    partial class RealLoginForm
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
            tabControl1 = new TabControl();
            loginTab = new TabPage();
            loginButton = new Button();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            registerTab = new TabPage();
            registerButton = new Button();
            regPasswordTextBox = new TextBox();
            regUsernameTexBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            tabControl1.SuspendLayout();
            loginTab.SuspendLayout();
            registerTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(loginTab);
            tabControl1.Controls.Add(registerTab);
            tabControl1.Location = new Point(55, 113);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(682, 331);
            tabControl1.TabIndex = 0;
            // 
            // loginTab
            // 
            loginTab.Controls.Add(loginButton);
            loginTab.Controls.Add(passwordTextBox);
            loginTab.Controls.Add(usernameTextBox);
            loginTab.Controls.Add(label2);
            loginTab.Controls.Add(label1);
            loginTab.Location = new Point(4, 34);
            loginTab.Margin = new Padding(4, 5, 4, 5);
            loginTab.Name = "loginTab";
            loginTab.Padding = new Padding(4, 5, 4, 5);
            loginTab.Size = new Size(674, 293);
            loginTab.TabIndex = 0;
            loginTab.Text = "Đăng nhập";
            loginTab.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(243, 199);
            loginButton.Margin = new Padding(4, 5, 4, 5);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(185, 38);
            loginButton.TabIndex = 4;
            loginButton.Text = "Đăng nhập";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(243, 134);
            passwordTextBox.Margin = new Padding(4, 5, 4, 5);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(352, 31);
            passwordTextBox.TabIndex = 3;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(243, 65);
            usernameTextBox.Margin = new Padding(4, 5, 4, 5);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(352, 31);
            usernameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 129);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // registerTab
            // 
            registerTab.Controls.Add(registerButton);
            registerTab.Controls.Add(regPasswordTextBox);
            registerTab.Controls.Add(regUsernameTexBox);
            registerTab.Controls.Add(label3);
            registerTab.Controls.Add(label4);
            registerTab.Location = new Point(4, 34);
            registerTab.Margin = new Padding(4, 5, 4, 5);
            registerTab.Name = "registerTab";
            registerTab.Padding = new Padding(4, 5, 4, 5);
            registerTab.Size = new Size(674, 293);
            registerTab.TabIndex = 1;
            registerTab.Text = "Đăng kí";
            registerTab.UseVisualStyleBackColor = true;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(224, 195);
            registerButton.Margin = new Padding(4, 5, 4, 5);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(209, 38);
            registerButton.TabIndex = 9;
            registerButton.Text = "Đăng kí";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // regPasswordTextBox
            // 
            regPasswordTextBox.Location = new Point(224, 125);
            regPasswordTextBox.Margin = new Padding(4, 5, 4, 5);
            regPasswordTextBox.Name = "regPasswordTextBox";
            regPasswordTextBox.Size = new Size(346, 31);
            regPasswordTextBox.TabIndex = 8;
            // 
            // regUsernameTexBox
            // 
            regUsernameTexBox.Location = new Point(224, 52);
            regUsernameTexBox.Margin = new Padding(4, 5, 4, 5);
            regUsernameTexBox.Name = "regUsernameTexBox";
            regUsernameTexBox.Size = new Size(346, 31);
            regUsernameTexBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 126);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 6;
            label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 58);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 5;
            label4.Text = "Tên đăng nhập";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(248, 40);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(317, 38);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "CỬA HÀNG ĐIỆN TỬ";
            // 
            // RealLoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 484);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "RealLoginForm";
            Text = "RealLoginForm";
            tabControl1.ResumeLayout(false);
            loginTab.ResumeLayout(false);
            loginTab.PerformLayout();
            registerTab.ResumeLayout(false);
            registerTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage loginTab;
        private Label label2;
        private Label label1;
        private TabPage registerTab;
        private Button loginButton;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Button registerButton;
        private TextBox regPasswordTextBox;
        private TextBox regUsernameTexBox;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}