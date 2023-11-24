namespace CuaHangDienTu.UI.Product
{
    partial class ChooseQuantityForm
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
            quantityTextBox = new TextBox();
            quantityConfirmButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(100, 95);
            quantityTextBox.Margin = new Padding(4, 5, 4, 5);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(213, 31);
            quantityTextBox.TabIndex = 0;
            // 
            // quantityConfirmButton
            // 
            quantityConfirmButton.Location = new Point(100, 158);
            quantityConfirmButton.Margin = new Padding(4, 5, 4, 5);
            quantityConfirmButton.Name = "quantityConfirmButton";
            quantityConfirmButton.Size = new Size(168, 38);
            quantityConfirmButton.TabIndex = 1;
            quantityConfirmButton.Text = "OK";
            quantityConfirmButton.UseVisualStyleBackColor = true;
            quantityConfirmButton.Click += quantityConfirmButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(100, 49);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 2;
            label1.Text = "Nhập số lượng :";
            // 
            // ChooseQuantityForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 239);
            Controls.Add(label1);
            Controls.Add(quantityConfirmButton);
            Controls.Add(quantityTextBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ChooseQuantityForm";
            Text = "Nhập số lượng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox quantityTextBox;
        private Button quantityConfirmButton;
        private Label label1;
    }
}