using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaContable.Vistas;
using SistemaContable.Modelos;

namespace SistemaContable
{
    public class Controlador
    {
        private MenuPrincipal vistaMenuP;
        private LibroDiario vistaLD;
        public Controlador() { }
        public Controlador(MenuPrincipal vistaMenuP /*,Modelo modelo*/)
        {
            this.vistaMenuP = vistaMenuP;
        }
        public void nuevoLibroDiario()
        {
            if (SQLConexion.Conexion.hayConexion())
            {
                string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                

                LibroDiario vistaLD = new LibroDiario(vistaMenuP, this);
                this.vistaLD = vistaLD;
                vistaLD.Visible = true;
                vistaMenuP.Visible = false;

                refrescarDataGrip(fecha);
            }
        }
        public void nuevaVistaCrearAsiento()
        {
            if (SQLConexion.Conexion.hayConexion())
            {
                string fecha = DateTime.Now.ToString("yyyy-MM-dd");

                NuevoAsiento vistaNA = new NuevoAsiento(vistaLD, this);
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
        public void refrescarDataGrip(string fecha)
        {
            Asiento asiento = new Asiento();
            List<Asiento> asientos = asiento.ListarAsientosporFecha(fecha);
            vistaLD.dataGridAsientos.Rows.Clear();
            foreach (Asiento item in asientos)
            {
                vistaLD.dataGridAsientos.Rows.Add(item.Id, item.Numero_asiento, item.Fecha_asiento, "", "", "", "", item.Descripcion_asiento);
                List<Movimiento> movimientos = Movimiento.ListarMovimientos(item.Id);
                foreach (Movimiento movi in movimientos)
                {
                    vistaLD.dataGridAsientos.Rows.Add(item.Id, item.Numero_asiento, "", movi.Cuenta.NombreCuenta, movi.Cuenta.Tipocuenta.DescripcionTipo ,DebeHaberString(movi, false), DebeHaberString(movi, true), "");
                }
            }
        }
        public void agregarMovimiento()
        {

        }

    }
}
