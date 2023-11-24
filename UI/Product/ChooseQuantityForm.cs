namespace CuaHangDienTu.UI.Product
{
    public partial class ChooseQuantityForm : Form
    {
        public int CurrentQuantity { get; set; }
        public ChooseQuantityForm()
        {
            InitializeComponent();
        }

        private void quantityConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentQuantity = Convert.ToInt32(quantityTextBox.Text);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn hãy nhập số lượng đúng định dạng.");
                DialogResult = DialogResult.Cancel;
            }
            if (CurrentQuantity == null || CurrentQuantity <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ.");
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
