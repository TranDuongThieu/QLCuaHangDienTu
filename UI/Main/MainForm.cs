using CuaHangDienTu.UI.Login;
using CuaHangDienTu.UI.Product;

namespace CuaHangDienTu.UI.Main
{
    public partial class MainForm : Form
    {
        private RealLoginForm _loginFormReference;
        private OrderForm orderForm;
        public MainForm(RealLoginForm realLoginForm)
        {
            InitializeComponent();
            _loginFormReference = realLoginForm;

        }

        public event Action LogoutClicked;



        public void CloseForm()
        {
            this.Close();
        }
        //private void ClearPanel()
        //{
        //    Control[] controls = panel1.Controls.OfType<Control>().ToArray();

        //    // Dispose and remove the controls from the copy
        //    foreach (Control control in controls)
        //    {
        //        control.Dispose();
        //        panel1.Controls.Remove(control);
        //    }
        //}



        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            ProductView phone = new ProductView("PHONE");
            ProductView tablet = new ProductView("TABLET");
            ProductView laptop = new ProductView("LAPTOP");
            orderForm = new OrderForm();

            tab_phone.Controls.Add(phone);
            tab_tablet.Controls.Add(tablet);
            tab_laptop.Controls.Add(laptop);
            tab_hoadon.Controls.Add(orderForm);


        }

        private void btn__logout_Click(object sender, EventArgs e)
        {
            //this.CloseForm();
            //LoginForm loginForm = new LoginForm();
            //loginForm.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tab_phone_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserLoginInfomation.Username = "";
            UserLoginInfomation.Password = "";
            _loginFormReference.Show();
        }

        private void orderTabClick(object sender, EventArgs e)
        {
            if (GlobalVar.CurrentOrderId != null)
            {
                orderForm.UpdateOrderDetails();
                orderForm.ShowDetails();
            }
            else
            {
                orderForm.HideDetails();
            }
        }
    }
}
