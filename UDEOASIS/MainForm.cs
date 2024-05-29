using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UDEOASIS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pbtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pbtnMaximizar.Visible = false;
            pbtnRestaurar.Visible = false;
        }

        private void pbtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pbtnRestaurar.Visible = false;
            pbtnMaximizar.Visible = true;
        }

        private void pbtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SenMessage")]

        private extern static void SendMessage(System.IntPtr hwmd, int wMsg, int wParam, int lParam);

        private void panel_BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbtnCerrarSesion_Click(object sender, EventArgs e)
        {
            LoginForm mff = new LoginForm();
            this.Hide();
            mff.Show();
        }
        private void AbrirFormulario(object formhija)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            MainForm fh = formhija as MainForm;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(fh);
            this.panel_Contenedor.Tag = fh;
            fh.Show();
        }
        private void AbrirFormHija(object formhija)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(fh);
            this.panel_Contenedor.Tag - fh;
            fh.Show();
        }

        private void pictureInicio_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new InicioForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pictureInicio_Click(null, e);
        }
    }
}
