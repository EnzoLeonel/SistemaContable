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
    public partial class NuevoAsiento : Form
    {
        private Controlador controlador;

        public NuevoAsiento(Form vistaanterior, Controlador controlador)
        {
            vistaanterior.Dispose();
            this.Visible = true;
            this.controlador = controlador;
            InitializeComponent();
            CargadorDeDatos();
        }
        private void NuevoAsiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlador.NuevoLibroDiario();
            Dispose();
        }
        private void comboBoxTipo_load()
        {
            try
            {
                List<TipodeCuenta> lista = TipodeCuenta.TraerTipos();
                foreach (TipodeCuenta i in lista)
                {
                    boxTipoCuenta.Items.Add(new ComboBoxItem(i.DescripcionTipo, i.Id));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar tipo de cuentas. Por favor vuelva a intentarlo mas tarde");
            }
        }
        private void comboBoxNombre_load()
        {
            try
            {
                List<Cuenta> lista = Cuenta.ListarCuentas(1);
                foreach (Cuenta i in lista)
                {
                    this.boxCuenta.Items.Add(new ComboBoxItem(i.NombreCuenta, i.IdCuenta));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar nombre de cuentas. Por favor vuelva a intentarlo mas tarde");
            }
        }
        private void CargadorDeDatos()
        {
            try
            {
                comboBoxTipo_load();
                comboBoxNombre_load();
                boxTipoCuenta.SelectedIndex = 0;
                boxCuenta.SelectedIndex = 0;
                int numasiento = Asiento.TraerUltimoIdAsiento() + 1;
                boxNumAsiento.Text = numasiento.ToString();
                boxFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
                boxNumAsiento.Enabled = false;
                boxFecha.Enabled = false;
                btnDebe.Select();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema. Vuelva a intentarlo mas tarde.");
                this.Close();
                Application.Exit();
            }
        }
        private void boxTipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                boxCuenta.Items.Clear();
                int hValue = ((ComboBoxItem)boxTipoCuenta.SelectedItem).HiddenValue;
                List<Cuenta> lista = Cuenta.ListarCuentas(hValue);
                foreach (Cuenta i in lista)
                {
                    this.boxCuenta.Items.Add(new ComboBoxItem(i.NombreCuenta, i.IdCuenta));
                }
                boxCuenta.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar tipo de cuentas. Por favor vuelva a intentarlo mas tarde.");
            }
        }
        private void btnAgregarMovi_Click(object sender, EventArgs e)
        {
            controlador.AgregarMovimiento();
        }
        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            controlador.BtnRestablecerMovi();
        }
        private void dataGridMovimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                try
                {
                    controlador.EliminarMovimiento(e.RowIndex);
                }catch(Exception) {}
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            controlador.NuevoLibroDiario();
            Dispose();
        }
        private void btnGuardarAsiento_Click(object sender, EventArgs e)
        {
            controlador.GuardarAsientoNuevo();
        }
    }
}
