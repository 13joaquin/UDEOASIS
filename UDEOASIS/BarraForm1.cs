using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDEOASIS
{
    public partial class BarraForm1 : Form
    {
        public BarraForm1()
        {
            InitializeComponent();
        }

        private void BarraForm1_Load(object sender, EventArgs e)
        {

        }

        private void timerBARRA_Tick(object sender, EventArgs e)
        {
            panelbARRA.Width += 3;
            if (panelbARRA.Width >= 600)
            {
                timerBARRA.Stop();
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
        }
    }
}
