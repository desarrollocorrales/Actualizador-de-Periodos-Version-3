using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ActualizadorDePeriodos3.DAL;

namespace ActualizadorDePeriodos3
{
    public partial class Frm_Principal : Form
    {
        private int minutos = 0;
        private DateTime dtHoy = DateTime.Today.Date;
        private bool seMinimiza = true;

        public Frm_Principal(bool seMinimiza)
        {
            InitializeComponent();
            this.seMinimiza = seMinimiza;
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            CargarDatos();            
        }
        private void CargarDatos()
        {
            var Config = Properties.Settings.Default;
            
            txbServidor.Text = Config.Servidor;
            txbBaseDeDatos.Text = Config.BaseDeDatos;
            txbUsuario.Text = Config.Usuario;
            txbContrasenia.Text = Config.Password;
            nudPuerto.Value = Config.Puerto;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            this.WindowState = FormWindowState.Minimized;

            ActualizarPeriodos();
            timerEjecutar.Start();
            
        }
        private void Guardar()
        {
            var Config = Properties.Settings.Default;
            
            Config.Servidor = txbServidor.Text;
            Config.BaseDeDatos = txbBaseDeDatos.Text;
            Config.Usuario = txbUsuario.Text;
            Config.Password = txbContrasenia.Text;
            Config.Puerto = (int)nudPuerto.Value;

            Config.Save();
        }
        private void Ejecutar()
        {
            if (dtHoy != DateTime.Today.Date)
            {
                dtHoy = DateTime.Today.Date;
                ActualizarPeriodos();
            }
        }

        private void niActualizador_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void Frm_Principal_Shown(object sender, EventArgs e)
        {
            if (seMinimiza == true)
            {
                this.Hide();
                ActualizarPeriodos();
                timerEjecutar.Start();
            }            
        }

        private void Frm_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Principal_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void timerEjecutar_Tick(object sender, EventArgs e)
        {
            if (minutos == 60)
            {
                Ejecutar();
                minutos = 0;
            }
            else
            {
                minutos++;
            }
        }

        private void ActualizarPeriodos()
        {
            try
            {
                FBDAL fbDal = new FBDAL();
                fbDal.ActualizarPeridoInicio(dtHoy.AddDays(-2), "Compras");
                fbDal.ActualizarPeridoFin(dtHoy, "Compras");
                fbDal.ActualizarPeridoInicio(dtHoy.AddDays(-2), "Cuentas por pagar");
                fbDal.ActualizarPeridoFin(dtHoy, "Cuentas por pagar");

                fbDal.ActualizarPeridos(dtHoy, "Cuentas por cobrar");
                fbDal.ActualizarPeridos(dtHoy, "Inventarios");
                fbDal.ActualizarPeridos(dtHoy, "Ventas");
            }
            catch
            {

            }
        }
    }
}
