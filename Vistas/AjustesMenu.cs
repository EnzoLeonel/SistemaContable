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
                conexionDB += "datasource=" + boxIP + ";port=" + boxPuerto + ";username=" + boxUsuario + ";password=" + boxContrasena + ";database=librodiario;";
                controlador.setConexionDB(conexionDB);
                MessageBox.Show("Ajustes guardados correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
