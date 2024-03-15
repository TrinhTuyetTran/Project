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

            // Ki?m tra thông tin ðãng nh?p
            if (IsValidLogin(username, password))
            {
                // Ðãng nh?p thành công
                MessageBox.Show("Ðãng nh?p thành công!");
                // Th?c hi?n các hành ð?ng sau khi ðãng nh?p thành công
            }
            else
            {
                // Ðãng nh?p th?t b?i
                MessageBox.Show("Ðãng nh?p không thành công. Vui l?ng ki?m tra l?i tên ðãng nh?p và m?t kh?u.");
            }
        }
    }
}