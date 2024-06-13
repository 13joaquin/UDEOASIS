using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DGVPrinterHelper;

namespace UDEOASIS
{

    public partial class ListaRegistroAsisForm : Form
    {
        private MySqlConnection con = new MySqlConnection();
        public ListaRegistroAsisForm()
        {
            InitializeComponent();
            con.ConnectionString = @"server=localhost;database=udeo_info;userid=root;password=;";
        }

        private void ListaRegistroAsisForm_Load_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                string query = "select * from registroasis";
                cmd.CommandText = query;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                datagridRecord.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex);
            }
        }

        private void datagridRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_PrintData_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Registro de Asistencia QR de Estudiantes";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Footer";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(datagridRecord);
        }
    }
}
