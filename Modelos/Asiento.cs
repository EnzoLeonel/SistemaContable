using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaContable.Modelos
{
    public class Asiento
    {
        private int id;
        private int numero_asiento;
        private string fecha_asiento;
        private string descripcion_asiento;
        private string conexionDB;
        //private List<Movimiento> asiento_movimiento;
        public Asiento(string conexion)
        {
            this.conexionDB = conexion;
        }
        public int Id { get => id; set => id = value; }
        public int Numero_asiento { get => numero_asiento; set => numero_asiento = value; }
        public string Fecha_asiento { get => fecha_asiento; set => fecha_asiento = value; }
        public string Descripcion_asiento { get => descripcion_asiento; set => descripcion_asiento = value; }
        //internal List<Movimiento> Asiento_movimiento { get => asiento_movimiento; set => asiento_movimiento = value; }

        public List<Asiento> ListarAsientosporFecha(string fecha)
        {
            List<Asiento> listadeasientos = new List<Asiento>();
            string query = "SELECT * FROM asiento a WHERE (a.fecha_asiento = '" + fecha + "')";


            MySqlConnection databaseConnection = new MySqlConnection(conexionDB);
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
                        Asiento asiento = new Asiento(conexionDB);
                        asiento.Id = reader.GetInt32(0);
                        asiento.Numero_asiento = reader.GetInt32(1);
                        asiento.Fecha_asiento = reader.GetDateTime(2).ToShortDateString();
                        asiento.Descripcion_asiento = reader.GetString(3);
                        listadeasientos.Add(asiento);
                    }
                }

                databaseConnection.Close();
                return listadeasientos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listadeasientos;
            }
        }
        public bool hayConexion()
        {
            bool conectado = false;
            try
            {
                MySqlConnection databaseConnection = new MySqlConnection(conexionDB);
                databaseConnection.Open();
                conectado = true;
                databaseConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo conectar al servidor");
            }
            return conectado;
        }
    }
}
