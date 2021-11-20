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
    public partial class LibroDiario : Form
    {
        private Controlador controlador;
        private Form vistaAnterior;

        public Form VistaAnterior { get => vistaAnterior; set => vistaAnterior = value; }

        public LibroDiario(Form vistaanterior,Controlador controlador)
        {
            VistaAnterior = vistaanterior;
            this.controlador = controlador;
            InitializeComponent();
        }
        private void LibroDiario_FormClosing(object sender, FormClosingEventArgs e)
        {
            VistaAnterior.Visible = true;
            this.Dispose();
        }

        private void selectorFecha_ValueChanged(object sender, EventArgs e)
        {
            string fecha = selectorFecha.Value.ToString("yyyy-MM-dd");
            controlador.refrescarDataGrip(fecha);

        }
        private void BotonNuevo_Click(object sender, EventArgs e)
        {
            controlador.nuevaVistaCrearAsiento();
        }
    }
}
