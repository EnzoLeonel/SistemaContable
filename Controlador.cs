using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaContable.Vistas;
using SistemaContable.Modelos;
using System.Windows.Forms;

namespace SistemaContable
{
    public class Controlador
    {
        private MenuPrincipal vistaMenuP;
        private LibroDiario vistaLD;
        private NuevoAsiento vistaNA;
        private Asiento asientoNuevo;
        private EliminarAsiento vistaEA;
        public Controlador() { }
        public Controlador(MenuPrincipal vistaMenuP)
        {
            this.vistaMenuP = vistaMenuP;
        }
        public void NuevoLibroDiario()
        {
            if (SQLConexion.Conexion.hayConexion())
            {
                string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                

                LibroDiario vistaLD = new LibroDiario(vistaMenuP, this);
                this.vistaLD = vistaLD;
                vistaLD.Visible = true;
                vistaMenuP.Visible = false;

                RefrescarDataGrip(fecha);
            }
        }
        public void NuevaVistaCrearAsiento()
        {
            if (SQLConexion.Conexion.hayConexion())
            {
                asientoNuevo = new Asiento();
                asientoNuevo.Asiento_movimiento = new List<Movimiento>();
                vistaLD.Dispose();
                vistaNA = new NuevoAsiento(this);
            }
        }
        public void NuevaVistaEliminarAsiento()
        {
            if (SQLConexion.Conexion.hayConexion())
            {
                vistaLD.Dispose();
                vistaEA = new EliminarAsiento(this);
                
                RefrescarDataGripEliminar();
            }
        }
        private string DebeHaberString(Movimiento movi, bool seleccion)
        {
            if(seleccion == movi.Debe_haber)
            {
                return movi.Valor.ToString();
            }
            else
            {
                return null;
            }
        }
        public void RefrescarDataGrip(string fecha)
        {
            List<Asiento> asientos = Asiento.ListarAsientosporFecha(fecha);
            vistaLD.dataGridAsientos.Rows.Clear();
            foreach (Asiento item in asientos)
            {
                vistaLD.dataGridAsientos.Rows.Add(item.Id, item.Numero_asiento, item.Fecha_asiento, "", "", "", "", item.Descripcion_asiento);
                List<Movimiento> movimientos = Movimiento.ListarMovimientos(item.Id);
                foreach (Movimiento movi in movimientos)
                {
                    vistaLD.dataGridAsientos.Rows.Add(item.Id, item.Numero_asiento, "", movi.Cuenta.NombreCuenta, movi.Cuenta.Tipocuenta.DescripcionTipo ,DebeHaberString(movi, true), DebeHaberString(movi, false), "");
                }
            }
        }
        public void RefrescarDataGripEliminar()
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            List<Asiento> asientos = Asiento.ListarAsientosporFecha(fecha);
            vistaEA.dataGridEliminar.Rows.Clear();
            foreach (Asiento item in asientos)
            {
                List<Movimiento> movimientos = Movimiento.ListarMovimientos(item.Id);
                float valor = 0;
                foreach (Movimiento movi in movimientos)
                {
                    valor += movi.Valor;
                }
                try
                {
                    valor = valor / 2;
                }
                catch (Exception) { }
                vistaEA.dataGridEliminar.Rows.Add(item.Fecha_asiento, item.Id, item.Numero_asiento, valor ,item.Descripcion_asiento);
            }
        }
        public void AgregarMovimiento()
        {
            DialogResult result = MessageBox.Show("¿Desea agregar el movimiento?", "Crear Movimiento", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                try
                {
                    int numasiento = Movimiento.TraerUltimoIdMovimiento() + 1 + asientoNuevo.Asiento_movimiento.Count;
                    Movimiento nuevoMovimiento = new Movimiento();
                    nuevoMovimiento.Id = numasiento;
                    nuevoMovimiento.Valor = float.Parse(vistaNA.boxSaldo.Text); //Recupero el saldo del textBox
                    nuevoMovimiento.Debe_haber = Convert.ToBoolean(vistaNA.btnDebe.Checked); //Guardo en true si es debe, false si es haber
                    nuevoMovimiento.Cuenta = new Cuenta();
                    nuevoMovimiento.Cuenta.IdCuenta = ((ComboBoxItem)vistaNA.boxCuenta.SelectedItem).HiddenValue;
                    nuevoMovimiento.Cuenta.NombreCuenta = vistaNA.boxCuenta.SelectedItem.ToString();
                    nuevoMovimiento.Cuenta.Tipocuenta = new TipodeCuenta();
                    nuevoMovimiento.Cuenta.Tipocuenta.Id = ((ComboBoxItem)vistaNA.boxTipoCuenta.SelectedItem).HiddenValue;
                    nuevoMovimiento.Cuenta.Tipocuenta.DescripcionTipo = vistaNA.boxTipoCuenta.SelectedItem.ToString();
                    asientoNuevo.Asiento_movimiento.Add(nuevoMovimiento);
                    RefrescarDataGripMovi();
                    BtnRestablecerMovi();
                }
                catch (Exception)
                {
                    MessageBox.Show("Los datos son incorrectos");
                }
            }
        }
        private void RefrescarDataGripMovi()
        {
            vistaNA.dataGridMovimientos.Rows.Clear();
            foreach (Movimiento item in asientoNuevo.Asiento_movimiento)
            {
                string debehaber = "";
                if (item.Debe_haber) debehaber = "Debe";
                else debehaber = "Haber";
                vistaNA.dataGridMovimientos.Rows.Add(item.Id, item.Cuenta.NombreCuenta, item.Cuenta.Tipocuenta.DescripcionTipo, item.Valor, debehaber);
            }
        }
        public void BtnRestablecerMovi()
        {
            vistaNA.boxTipoCuenta.SelectedIndex = 0;
            vistaNA.boxCuenta.SelectedIndex = 0;
            vistaNA.boxSaldo.Text = "";
        }
        public void EliminarMovimiento(int indice)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar el movimiento?", "Eliminar Movimiento", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                asientoNuevo.Asiento_movimiento.RemoveAt(indice);
                RefrescarDataGripMovi();
            }
        }
        public void EliminarAsiento(int idasiento)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar el Asiento?", "Eliminar Asiento", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                Movimiento.EliminarMovimientoAsiento(idasiento);
                Asiento.borrarAsiento(idasiento);
                RefrescarDataGripEliminar();
            }
        }
        private bool VerPartidaDoble()
        {
            float saldodebe = 0f, saldohaber = 0f;
            foreach (Movimiento item in asientoNuevo.Asiento_movimiento)
            {
                if (item.Debe_haber)
                {
                    saldodebe = saldodebe + item.Valor;
                }
                else
                {
                    saldohaber = saldohaber + item.Valor;
                }

            }
            if (saldodebe == saldohaber) return true;
            else return false;
        }
        public void GuardarAsientoNuevo()
        {
            if (asientoNuevo.Asiento_movimiento.Count >= 2 && VerPartidaDoble())
            {
                DialogResult result = MessageBox.Show("¿Desea crear el asiento?", "Guardar Asiento", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    asientoNuevo.Numero_asiento = int.Parse(vistaNA.boxNumAsiento.Text);
                    asientoNuevo.Descripcion_asiento = vistaNA.boxDescripcion.Text;
                    asientoNuevo.Fecha_asiento = vistaNA.boxFecha.Text;
                    int numAsiento = Asiento.CrearAsiento(asientoNuevo);

                    foreach (Movimiento item in asientoNuevo.Asiento_movimiento)
                    {
                        item.Asiento = asientoNuevo;
                        item.Asiento.Id = numAsiento;
                        Movimiento.CrearMovimiento(item);
                    }
                    asientoNuevo = null;
                    vistaNA.Dispose();
                    NuevoLibroDiario();
                }
            }
            else
            {
                MessageBox.Show("Datos incorrectos, no tienen 2 movimientos o no estan equilibrados", "Datos incorrectos", MessageBoxButtons.OK);
            }
        }
    }
}
