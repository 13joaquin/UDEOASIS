using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using MySql.Data.MySqlClient;

namespace UDEOASIS
{
    public partial class ScanQRasistenciaForm : Form
    {
        private MySqlConnection cone = new MySqlConnection();
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        public ScanQRasistenciaForm()
        {
            InitializeComponent();
            cone.ConnectionString = @"server=localhost;database=udeo_info;userid=root;password=;";
        }
        string Gender;

        private void ScanQRasistenciaForm_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in CaptureDevice)
                comboBox_FIL.Items.Add(item.Name);
            comboBox_FIL.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();

            lbl_Date.Text = DateTime.Now.ToLongDateString();
            lbl_Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_OpenCamera_Click(object sender, EventArgs e)
        {
            //Abrir Camara
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox_FIL.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBx_Camara.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void ScanQRasistenciaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
                FinalFrame.Stop();
        }

        private void timerFrom_Tick(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode((Bitmap)pictureBox1.Image);
            try
            {
                string decode = result.ToString().Trim();
                txt_ID.Text = decode;
                if (decode != null)
                {
                    cone.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = cone;
                    command.CommandText = "SELECT * FROM registro_tb WHERE ID LIKE '%' " + txt_ID.Text + " %' ";
                    MySqlDataReader dr = command.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        txtNombre.Text = dr["Nombre"].ToString();
                        txtApellido.Text = dr["Apellido"].ToString();
                        txtEmail.Text = dr["EmailAddress"].ToString();
                        txt_Fecha.Text = dr["FechaCumpleaños"].ToString();
                        txtCurso.Text = dr["Curso"].ToString();
                        txtTelefono.Text = dr["Telefono"].ToString();
                        txt_Genero.Text = dr["Genero"].ToString();
                        byte[] img = ((byte[])dr["Photo"]);
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                    cone.Close();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Para Atención
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                pictureBox1.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] Photo = new byte[memoryStream.Length];
                memoryStream.Position = 0;
                memoryStream.Read(Photo, 0, Photo.Length);

                cone.Open();
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = cone;
                mySqlCommand.CommandText = "INSERT INTO ()";
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
