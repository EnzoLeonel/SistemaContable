using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaContable.Modelos
{
    class Movimiento
    {
        private int id;
        private Asiento asiento;
        private Cuenta cuenta;
        private float valor;
        private bool debe_haber;

        public int Id { get => id; set => id = value; }
        public float Valor { get => valor; set => valor = value; }
        public bool Debe_haber { get => debe_haber; set => debe_haber = value; }
        internal Asiento Asiento { get => asiento; set => asiento = value; }
        internal Cuenta Cuenta { get => cuenta; set => cuenta = value; }

        public Movimiento TraerMovimientosporId(int idmovimiento)
        {
            List<Movimiento> listademovimientos = new List<Movimiento>();
            string query = "SELECT * FROM movimiento m, cuentas c, tipocuenta t WHERE (m.cuenta_id = c.id_cuenta AND c.tipocuenta_id = t.id_tipocuenta AND m.id_movimiento =" + idmovimiento + ")";

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
                        Movimiento movimiento = new Movimiento();
                        Asiento asiento = new Asiento();
                        Cuenta cuenta = new Cuenta();

                        movimiento.Id = reader.GetInt32(0);
                        asiento.Id = reader.GetInt32(1);
                        cuenta.IdCuenta = reader.GetInt32(2);
                        movimiento.Valor = reader.GetFloat(3);
                        movimiento.Debe_haber = reader.GetBoolean(4);
                        cuenta.NombreCuenta = reader.GetString(6);
                        cuenta.Tipocuenta = new TipodeCuenta();
                        cuenta.Tipocuenta.Id = reader.GetInt32(7);
                        cuenta.Tipocuenta.DescripcionTipo = reader.GetString(9);
                        movimiento.Asiento = asiento;
                        movimiento.Cuenta = cuenta;

                        listademovimientos.Add(movimiento);
                    }
                }

                databaseConnection.Close();
                return listademovimientos.First();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listademovimientos.First();
            }
        }
        public static int TraerUltimoIdMovimiento()
        {
            int ultimoId = 0;
            string query = "SELECT id_movimiento FROM movimiento ORDER BY id_movimiento DESC LIMIT 1;";
            MySqlConnection databaseConnection = new MySqlConnection(SQLConexion.Conexion.getDatos());
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                reader.Read();
                ultimoId = reader.GetInt32(0);
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ultimoId;
        }
        
        public static List<Movimiento> ListarMovimientos(int idasiento)
        {
            List<Movimiento> listademovimientos = new List<Movimiento>();
            string query = "SELECT * FROM movimiento m, asiento a, cuentas c, tipocuenta t WHERE (m.asiento_id = a.id_asiento AND m.cuenta_id = c.id_cuenta AND t.id_tipocuenta = c.tipocuenta_id AND m.asiento_id = " + idasiento + ")";

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
                        Movimiento movimiento = new Movimiento();
                        Asiento asiento = new Asiento();
                        Cuenta cuenta = new Cuenta();
                        asiento.Id = reader.GetInt32(1);
                        asiento.Numero_asiento = reader.GetInt32(6);
                        asiento.Fecha_asiento = reader.GetString(7);
                        asiento.Descripcion_asiento = reader.GetString(8);
                        cuenta.IdCuenta = reader.GetInt32(9);
                        cuenta.NombreCuenta = reader.GetString(10);
                        cuenta.Tipocuenta = new TipodeCuenta();
                        cuenta.Tipocuenta.Id = reader.GetInt32(11);
                        cuenta.Tipocuenta.DescripcionTipo = reader.GetString(13);
                        movimiento.Asiento = asiento;
                        movimiento.Cuenta = cuenta;
                        movimiento.Id = reader.GetInt32(0);
                        movimiento.Valor = reader.GetFloat(3);
                        movimiento.Debe_haber = reader.GetBoolean(4);
                        listademovimientos.Add(movimiento);
                    }
                }

                databaseConnection.Close();
                return listademovimientos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listademovimientos;
            }
        }
        public static void CrearMovimiento(Movimiento mov)
        {
            string query = "INSERT INTO movimiento(asiento_id,cuenta_id,valor,debeohaber) VALUES(" + mov.Asiento.Id + ", " + mov.Cuenta.IdCuenta + ", " + mov.Valor + ", " + mov.Debe_haber + ")";

            MySqlConnection databaseConnection = new MySqlConnection(SQLConexion.Conexion.getDatos());
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateMovimiento(Movimiento mov)
        {
            string query =
            "UPDATE movimiento SET asiento_id=" + mov.Asiento.Id + ", cuenta_id=" + mov.Cuenta.IdCuenta + ", valor=" + mov.Valor + ", debeohaber =" + mov.Debe_haber + " WHERE id_movimiento = " + mov.Id;
            MySqlConnection databaseConnection = new MySqlConnection(SQLConexion.Conexion.getDatos());
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                // Actualizado satisfactoriamente

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Ops, quizás el ID no existe
                MessageBox.Show(ex.Message);
            }
        }
    }
}
