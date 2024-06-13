
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
            connection.ConnectionString = @"server=localhost;database= udeo_info;userid=root;password=;";
            Titulos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        string Genero;
        public void Titulos()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 300;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(this.btnGuardar, "Guardar");
            toolTip.SetToolTip(this.btnUpdate, "Update");
            toolTip.SetToolTip(this.btnEliminar, "Eliminar");
            toolTip.SetToolTip(this.btnBuscarPerfil, "Buscar fotografía del estudiante");

        }
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
                picUP.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] Photo = new byte[ms.Length];
                ms.Read(Photo, 0, Photo.Length);

                //Connect DB connection
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO registro_tb (ID,Nombre,Apellido,EmailAddress,FechaCumpleaños,Curso,Telefono,Genero,Photo) " +
                    "values ('" + txt_ID.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtEmail.Text + "','" + dateTime1.Text + "','" + txtCurso.Text + "','" + txtTelefono.Text + "','" + Genero + "',@foto)";
                command.Parameters.AddWithValue("@Photo", Photo);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
            //Para Guardar Folder del Generador de QRCODE imagen
            string inititialDIR = @"C:\Users\juaqu\Proyecto Feria\ProyectoSEMI\UDEOASIS\UDEOASIS\Imgs\QRfile";
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = inititialDIR;
            dialog.Filter = "PNG|*.png|JPEG|*.jpeg|BMP|*.bmp|GIF|*.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picBxQR.Image.Save(dialog.FileName);
            }
            Limpiar();
        }
        private void Limpiar()
        {
            txt_ID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtCurso.Clear();
        }

        private void radioBtnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            Genero = "Masculino";
        }

        private void radioBtnFemenino_CheckedChanged(object sender, EventArgs e)
        {
            Genero = "Femenino";
        }

        private void btnBuscarPerfil_Click(object sender, EventArgs e)
        {
            //Para Upload image
            OpenFileDialog fg = new OpenFileDialog();
            if (fg.ShowDialog() == DialogResult.OK)
            {
                picUP.Image = Image.FromFile(fg.FileName);
            }
        }
    }
}