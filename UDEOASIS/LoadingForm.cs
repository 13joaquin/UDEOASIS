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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void BarraForm1_Load(object sender, EventArgs e)
        {

        }

        private void timerBARRA_Tick(object sender, EventArgs e)
        {
            panelbARRA.Width += 3;
            if (panelbARRA.Width >= 525)
            {
                timerBARRA.Stop();
                MenuFrom main = new MenuFrom();
                main.Show();
                this.Hide();
            }
        }
    }
}
