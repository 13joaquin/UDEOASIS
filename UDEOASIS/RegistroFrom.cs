
namespace UDEOASIS
{
    public partial class RegistroFrom : Form
    {
        public RegistroFrom()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
        }

        /* private void button1_Click(object sender, EventArgs e)
        {
            LoginForm mff = new LoginForm();
            this.Hide();
            mff.Show();
        }*/
    }
}