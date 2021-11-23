using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaContable.Modelos;

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
            boxCuentas.SelectedIndex = 0;
        }
        private void LibroMayor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            VistaAnterior.Visible = true;
        }
    }
}
