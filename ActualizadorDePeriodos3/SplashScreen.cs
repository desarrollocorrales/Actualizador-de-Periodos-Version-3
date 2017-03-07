using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ActualizadorDePeriodos3
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timerEjecutar_Tick(object sender, EventArgs e)
        {
            timerEjecutar.Stop();
            this.Hide();
            new Frm_Principal(true).ShowDialog();
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            timerEjecutar.Start();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            timerEjecutar.Stop();
            this.Hide();
            new Frm_Principal(false).ShowDialog();
        }
    }
}
