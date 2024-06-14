using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using MySql.Data.MySqlClient;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using AForge.Video;
using ZXing.Windows.Compatibility;
using System.Text.RegularExpressions;

namespace UDEOASIS
{
    public partial class ScanQRasistenciaForm : Form

    {
        private VideoCapture _capture;
        private bool _captureInProgress;
        private MySqlConnection cone = new MySqlConnection();
        //private FilterInfoCollection CaptureDevice;
        //private VideoCaptureDevice FinalFrame;

        public ScanQRasistenciaForm()
        {
            InitializeComponent();
            cone.ConnectionString = @"server=localhost;database= udeo_info;userid=root;password=;";
            lbl_Date.Text = DateTime.Now.ToLongDateString();
            lbl_Time.Text = DateTime.Now.ToLongTimeString();
        }
        string Gender;

        private void ScanQRasistenciaForm_Load(object sender, EventArgs e)
        {
            //CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //foreach (FilterInfo item in CaptureDevice)
            //    comboBox_FIL.Items.Add(item.Name);

            //comboBox_FIL.SelectedIndex = 0;
            //FinalFrame = new VideoCaptureDevice();

        }

        private void btn_OpenCamera_Click(object sender, EventArgs e)
        {
            //Abrir Camara
            try
            {
                if (_capture == null)
                {
                    _capture = new VideoCapture();
                    _capture.ImageGrabbed += ProcessFrame;
                }
                _capture.Start();
                _captureInProgress = true;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ProcessFrame(object sender, EventArgs arg)
        {
            Mat frame = new Mat();
            _capture.Retrieve(frame, 0);
            pictureBx_Camara.Image = frame.ToImage<Bgr, Byte>().ToBitmap();
            DecodeQR(frame.ToImage<Bgr, Byte>());
        }

        private void DecodeQR(Image<Bgr, Byte> image)
        {
            try
            {
                // Convert the Image to a Bitmap
                Bitmap bitmap = image.ToBitmap();

                // Initialize the barcode reader
                BarcodeReader reader = new BarcodeReader();

                // Decode the barcode from the bitmap
                Result result = reader.Decode(bitmap);

                // Check if a result was found
                if (result != null)
                {
                    string decodedText = result.Text.Trim();
                    if (!string.IsNullOrEmpty(decodedText))
                    {
                        FetchDataFromDatabase(decodedText);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FetchDataFromDatabase(string qrCode)
        {
            //LIKE '%' " + txt_ID.Text + " %'
            try
            {
                cone.Open();
                string query = "SELECT * FROM registro_tb WHERE ID = @QRCode ";
                MySqlCommand command = new MySqlCommand(query, cone);
                command.Parameters.AddWithValue("@QRCode", qrCode);
                MySqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    txt_ID.Text = dr["ID"].ToString();
                    txtNombre.Text = dr["Nombre"].ToString();
                    txtApellido.Text = dr["Apellido"].ToString();
                    txtEmail.Text = dr["EmailAddress"].ToString();
                    txtCurso.Text = dr["Curso"].ToString();
                    txtTelefono.Text = dr["Telefono"].ToString();

                    byte[] img = (byte[])dr["Photo"];
                    MemoryStream ms = new MemoryStream(img);
                    PicShowPhoto.Image = Image.FromStream(ms);

                    //MarkAttendance(qrCode);
                }
                cone.Close();
                //Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (cone.State == ConnectionState.Open)
                    cone.Close();
            }
        }

        string ASIS;
        private void MarkAttendance(string qrCode)
        {
            try
            {
                cone.Open();
                string query = "INSERT INTO attendance_tbl (ID, Nombre, Apellido, EmailAddress, Curso, Telefono, Hora, Asistencia, Fecha) " +
                               "VALUES (@ID, @Nombre, @Apellido, @EmailAddress, @Curso, @Telefono,  @Hora, @Asistencia, @Fecha)";
                MySqlCommand command = new MySqlCommand(query, cone);
                command.Parameters.AddWithValue("@ID", txt_ID.Text);
                command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                command.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                command.Parameters.AddWithValue("@EmailAddress", txtEmail.Text);
                command.Parameters.AddWithValue("@Curso", txtCurso.Text);
                command.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                command.Parameters.AddWithValue("@Hora", lbl_Time.Text);
                command.Parameters.AddWithValue("@Asistencia", ASIS);
                command.Parameters.AddWithValue("@Fecha", lbl_Date.Text);

                command.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Attendance marked successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (cone.State == ConnectionState.Open)
                    cone.Close();
            }
        }
        //FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox_FIL.SelectedIndex].MonikerString);
        //FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
        //FinalFrame.Start();



        //private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        //{
        //    pictureBx_Camara.Image = (Bitmap)eventArgs.Frame.Clone();
        //}

        private void ScanQRasistenciaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (FinalFrame.IsRunning == true)
            //    FinalFrame.Stop();
            if (_capture != null)
                _capture.Dispose();
        }

        //Metodo
        //private void timerFrom_Tick(object sender, EventArgs e)
        //{
        //var reader = new BarcodeReader();
        //Result result = reader.Decode((Bitmap)pictureBox1.Image);
        //try
        //{
        //    string decode = result.ToString().Trim();
        //    if (decode != null)
        //    {
        //        decode = txt_ID.Text;
        //        cone.Open();
        //        MySqlCommand command = new MySqlCommand();
        //        command.Connection = cone;
        //        command.CommandText = "SELECT * FROM registro_tb WHERE ID LIKE '%' " + txt_ID.Text + " %' ";
        //        MySqlDataReader dr = command.ExecuteReader();
        //        dr.Read();
        //        if (dr.HasRows)
        //        {
        //            txtNombre.Text = dr["Nombre"].ToString();
        //            txtApellido.Text = dr["Apellido"].ToString();
        //            txtEmail.Text = dr["EmailAddress"].ToString();
        //            txt_Fecha.Text = dr["FechaCumpleaños"].ToString();
        //            txtCurso.Text = dr["Curso"].ToString();
        //            txtTelefono.Text = dr["Telefono"].ToString();
        //            txt_Genero.Text = dr["Genero"].ToString();
        //            byte[] img = ((byte[])dr["Photo"]);
        //            MemoryStream ms = new MemoryStream(img);
        //            pictureBox1.Image = Image.FromStream(ms);
        //        }
        //        cone.Close();
        //        timer1.Start();
        //    }
        //}
        //catch (Exception ex)
        //{

        //    throw;
        //}
        //}

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        ////Para Atención
        //try
        //{
        //    MemoryStream memoryStream = new MemoryStream();
        //    pictureBox1.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
        //    byte[] Photo = new byte[memoryStream.Length];
        //    memoryStream.Position = 0;
        //    memoryStream.Read(Photo, 0, Photo.Length);

        //    cone.Open();
        //    MySqlCommand mySqlCommand = new MySqlCommand();
        //    mySqlCommand.Connection = cone;
        //    mySqlCommand.CommandText = "INSERT INTO attendace_tbl (ID,Name,FatherName,EmailAddress,DateOfBirth,Class,PhoneNumber,Gender,InTime,Photo) values ('" + txt_ID.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtEmail.Text + "','" + txt_Fecha.Text + "','" + txtCurso.Text + "','" + txtTelefono.Text + "','" + txt_Genero.Text + "','" + lbl_Time.Text + "',@photo)";
        //    mySqlCommand.Parameters.AddWithValue("@photo", Photo);
        //    mySqlCommand.ExecuteNonQuery();
        //    cone.Close();
        //    MessageBox.Show("DataaSave Successful!");
        //}
        //catch (Exception ex)
        //{

        //    throw;
        //}
        //}

        private void btn_ScanQR_Click(object sender, EventArgs e)
        {
            if (!_captureInProgress)
                btn_OpenCamera_Click(sender, e);
            //timerFrom.Start();
        }
        private void abrir()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog.FileName);
                PicShowPhoto.Image = image;
                DecodeIQR(image);
            }
        }
        private void DecodeIQR(Image image)
        {
            BarcodeReader reader = new BarcodeReader();
            Bitmap bitmap = new Bitmap(image);
            Result result = reader.Decode(bitmap);
            if (result != null)
            {
                string decodedText = result.Text.Trim();
                if (!string.IsNullOrEmpty(decodedText))
                {
                    FetchDataFromDatabase(decodedText);
                }
            }
            else
            {
                MessageBox.Show("No QR code detected.");
            }
        }
        string qrCode;

        private void btn_AbrirIMGQR_Click(object sender, EventArgs e)
        {
            abrir();
        }

        private void btn_UpdateAsis_Click(object sender, EventArgs e)
        {
            MarkAttendance(qrCode);
            Limpiar();
        }
        private void Limpiar()
        {
            txt_ID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtCurso.Clear();
            txtTelefono.Clear();
            PicShowPhoto.Image = null;
        }

        private void radioBtn_Asistencia_CheckedChanged(object sender, EventArgs e)
        {
            ASIS = "Asistencia";
        }

        private void radioBtn_NoAsistencia_CheckedChanged(object sender, EventArgs e)
        {
            ASIS = "Inasistencia";
        }
    }
}
