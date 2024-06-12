using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDEOASIS
{
    public partial class ListInfoEstudianteForm : Form
    {
        private MySqlConnection _connection = new MySqlConnection();
        public ListInfoEstudianteForm()
        {
            InitializeComponent();
            _connection.ConnectionString = @"server=localhost;database=udeo_info;userid=root;password=;";
        }

        private void ListInfoEstudianteForm_Load(object sender, EventArgs e)
        {
            try
            {
                _connection.Open();
                MySqlCommand mySql = new MySqlCommand();
                mySql.Connection = _connection;
                string query = "SELECT * FROM registro_tb";
                mySql.CommandText = query;
                MySqlDataAdapter da = new MySqlDataAdapter(mySql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewBD.DataSource = dt;
                _connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
        }

        private void dataGridViewBD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewBD.Rows[e.RowIndex];
                txt_ID.Text = row.Cells["ID"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value.ToString();
                txtEmail.Text = row.Cells["EmailAddress"].Value.ToString();
                txt_Fecha.Text = row.Cells["FechaCumpleaños"].Value.ToString();
                txtCurso.Text = row.Cells["Curso"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txt_Genero.Text = row.Cells["Genero"].Value.ToString();
                //display image
                try
                {
                    byte[] bytes = (byte[])dataGridViewBD.CurrentRow.Cells["Photo"].Value;
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        pictureIMG.Image = Image.FromStream(ms);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                    pictureIMG.Image = null;
                }
                

            }
        }

    }
}
