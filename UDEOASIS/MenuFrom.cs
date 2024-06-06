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
    public partial class MenuFrom : Form
    {
        public MenuFrom()
        {
            InitializeComponent();
            Titulos();
        }
        public void Titulos()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 300;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(this.btnMinimizar, "Minimizar");
            toolTip.SetToolTip(this.btnMaximizar, "Maximizar");
            toolTip.SetToolTip(this.btnCerrar, "Cerrar");
            toolTip.SetToolTip(this.btnRestablecer, "Restablecer");
            toolTip.SetToolTip(this.btnSalir, "Cerrar Sesión");

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestablecer.Visible = true;
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestablecer.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void AbrirFormularioHija(object formhija)
        {
            if (this.pnl_Contenedor.Controls.Count > 0)
                this.pnl_Contenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnl_Contenedor.Controls.Add(fh);
            this.pnl_Contenedor.Tag = fh;
            fh.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormularioHija(new InicioForm());
        }


        private void MenuFrom_Load(object sender, EventArgs e)
        {
            btnInicio_Click(null, e);
        }

        private void btn_RegistroEstudientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHija(new RegistroFrom());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}
