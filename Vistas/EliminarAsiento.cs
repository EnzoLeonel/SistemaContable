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
    public partial class EliminarAsiento : Form
    {
        private readonly Controlador controlador;
        public EliminarAsiento(Controlador controlador)
        {
            this.Visible = true;
            this.controlador = controlador;
            InitializeComponent();
        }
        private void EliminarAsiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlador.NuevoLibroDiario();
            Dispose();

        }

        private void dataGridEliminar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                try
                {
                    int idasiento = Int32.Parse(dataGridEliminar.Rows[e.RowIndex].Cells[1].Value.ToString());
                    controlador.EliminarAsiento(idasiento);
                }
                catch (NullReferenceException) { }
            }
        }
    }
}
