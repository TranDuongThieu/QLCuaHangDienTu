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
            SuspendLayout();
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(12, 15);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(76, 23);
            quantityTextBox.TabIndex = 0;
            // 
            // quantityConfirmButton
            // 
            quantityConfirmButton.Location = new Point(125, 15);
            quantityConfirmButton.Name = "quantityConfirmButton";
            quantityConfirmButton.Size = new Size(75, 23);
            quantityConfirmButton.TabIndex = 1;
            quantityConfirmButton.Text = "OK";
            quantityConfirmButton.UseVisualStyleBackColor = true;
            quantityConfirmButton.Click += quantityConfirmButton_Click;
            // 
            // ChooseQuantityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 50);
            Controls.Add(quantityConfirmButton);
            Controls.Add(quantityTextBox);
            Name = "ChooseQuantityForm";
            Text = "Nhập số lượng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox quantityTextBox;
        private Button quantityConfirmButton;
    }
}