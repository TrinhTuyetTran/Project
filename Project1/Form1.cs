namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Kiểm tra thông tin đăng nhập
            if (IsValidLogin(username, password))
            {
                // Đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!");
                // Thực hiện các hành động sau khi đăng nhập thành công
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.");
            }
        }
        private bool IsValidLogin(string username, string password)
        {
            // Kiểm tra tên đăng nhập và mật khẩu
            if (username == "admin" && password == "admin")
            {
                return true; // Thông tin đăng nhập hợp lệ nhahah
            }
            else
            {
                return false; // Thông tin đăng nhập không hợp lệ
            }
        }
    }
}