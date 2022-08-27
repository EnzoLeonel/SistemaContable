using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaContable.Vistas
{
    public partial class AjustesMenu : Form
    {
        private Controlador controlador;
        private Form vistaAnterior;
        public Form VistaAnterior { get => vistaAnterior; set => vistaAnterior = value; }
        public AjustesMenu(Form vistaanterior,Controlador controlador)
        {
            VistaAnterior = vistaanterior;
            this.controlador = controlador;
            InitializeComponent();
        }
        private void AjustesMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            VistaAnterior.Visible = true;
            this.Dispose();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            string conexionDB = "";
            try
            {
                conexionDB += "datasource=" + boxIP.Text + ";port=" + boxPuerto.Text + ";username=" + boxUsuario.Text + ";password=" + boxContrasena.Text + ";database=" + boxBaseDatos.Text + ";";
                SQLConexion.Conexion.setDatos(conexionDB);
                MessageBox.Show("Ajustes guardados correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void datosPrueba_Click(object sender, EventArgs e)
        {
            //Se utiliza el servicio de CleverCloud para proporcionar una Base de datos de prueba
            try
            {
                boxIP.Text = "IP/HOST DE LA BASE DE DATOS";
                boxPuerto.Text = "PUERTO";
                boxUsuario.Text = "USUARIO";
                boxContrasena.Text = "CONTRASEÑA";
                boxBaseDatos.Text = "NOMBRE DE LA BASE DE DATOS";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
