using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaContable.Modelos
{
    class Cuenta
    {
        private int idCuenta;
        private string nombreCuenta;
        private TipodeCuenta tipocuenta;
        private List<Movimiento> movimientosdebe;
        private List<Movimiento> movimientoshaber;

        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public string NombreCuenta { get => nombreCuenta; set => nombreCuenta = value; }
        internal TipodeCuenta Tipocuenta { get => tipocuenta; set => tipocuenta = value; }
        internal List<Movimiento> Movimientosdebe { get => movimientosdebe; set => movimientosdebe = value; }
        internal List<Movimiento> Movimientoshaber { get => movimientoshaber; set => movimientoshaber = value; }
        public Cuenta() { }

        public static List<Cuenta> ListarCuentas(int idtipocuenta)
        {
            List<Cuenta> listadecuentas = new List<Cuenta>();
            string query = "SELECT * FROM cuentas c, tipocuenta t WHERE(c.tipocuenta_id = t.id_tipocuenta AND t.id_tipocuenta = " + idtipocuenta + ")";


            MySqlConnection databaseConnection = new MySqlConnection(SQLConexion.Conexion.getDatos());
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Cuenta cuenta = new Cuenta();
                        cuenta.IdCuenta = reader.GetInt32(0);
                        cuenta.NombreCuenta = reader.GetString(1);
                        TipodeCuenta tipo = new TipodeCuenta();
                        tipo.Id = reader.GetInt32(3);
                        tipo.DescripcionTipo = reader.GetString(4);
                        cuenta.Tipocuenta = tipo;
                        listadecuentas.Add(cuenta);
                    }
                }

                databaseConnection.Close();
                return listadecuentas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listadecuentas;
            }
        }
    }
}
