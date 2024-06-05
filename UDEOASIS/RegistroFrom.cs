
using MySql.Data.MySqlClient;
using QRCoder;

namespace UDEOASIS
{
    public partial class RegistroFrom : Form
    {
        private MySqlConnection connection = new MySqlConnection();

        public RegistroFrom()
        {
            InitializeComponent();
            connection.ConnectionString = @"server=localhost;database=udeo_info;userid=root;password=;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        string Genero;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Para QRCoder Generator
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(txt_ID.Text, QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            picBxQR.Image = code.GetGraphic(100);
            try
            {
                //Para Image
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] Photo = new byte[ms.Length];
                ms.Read(Photo, 0, Photo.Length);

                //Connect DB connection
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO registration_tb (ID,Nombre,Apellido,EmailAddress,FechaDeCumpleaños,Curso,Telefono,Genero,Foto) values ('" + txt_ID.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtEmail.Text + "','" + dateTime1.Text + "','" + txtCurso.Text + "','" + txtTelefono.Text + "','" + Genero + "',@photo)";
                command.Parameters.AddWithValue("@photo", Photo);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
            //Para Guardar Folder del Generador de QRCODE imagen
            string inititialDIR = @"\QRfile";
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = inititialDIR;
            dialog.Filter = "PNG|*.png|JPEG|*.jpeg|BMP|*.bmp|GIF|*.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picBxQR.Image.Save(dialog.FileName);
            }
        }

        private void radioBtnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            Genero = "Masculino";
        }

        private void radioBtnFemenino_CheckedChanged(object sender, EventArgs e)
        {
            Genero = "Femenino";
        }

        /* private void button1_Click(object sender, EventArgs e)
        {
            LoginForm mff = new LoginForm();
            this.Hide();
            mff.Show();
        }*/
    }
}