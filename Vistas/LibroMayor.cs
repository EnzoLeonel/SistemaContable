using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaContable.Vistas
{
    public partial class LibroMayor : Form
    {
        private readonly Controlador controlador;
        private Form vistaAnterior;
        public Form VistaAnterior { get => vistaAnterior; set => vistaAnterior = value; }

        public LibroMayor(Form vistaanterior, Controlador controlador)
        {
            VistaAnterior = vistaanterior;
            this.controlador = controlador;
            InitializeComponent();
        }
        private void LibroMayor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            VistaAnterior.Visible = true;
        }

        private void checkAnio_CheckedChanged(object sender, EventArgs e)
        {
            controlador.RefrescarDataGripLM();
        }
        
        public void boxMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            controlador.RefrescarDataGripLM();
        }

        public void boxAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            controlador.RefrescarDataGripLM();
        }

        public void boxCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            controlador.RefrescarDataGripLM();
        }
    }
}
