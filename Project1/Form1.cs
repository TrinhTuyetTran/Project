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

            // Ki?m tra th�ng tin ��ng nh?p
            if (IsValidLogin(username, password))
            {
                // ��ng nh?p th�nh c�ng
                MessageBox.Show("��ng nh?p th�nh c�ng!");
                // Th?c hi?n c�c h�nh �?ng sau khi ��ng nh?p th�nh c�ng
            }
            else
            {
                // ��ng nh?p th?t b?i
                MessageBox.Show("��ng nh?p kh�ng th�nh c�ng. Vui l?ng ki?m tra l?i t�n ��ng nh?p v� m?t kh?u.");
            }
        }
    }
}