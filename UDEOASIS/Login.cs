
namespace UDEOASIS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm mff = new LoginForm();
            this.Hide();
            mff.Show();
        }
    }
}