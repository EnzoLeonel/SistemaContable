using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaContable.Modelos
{
    class TipodeCuenta
    {
        private int id;
        private string descripcionTipo;

        public string DescripcionTipo { get => descripcionTipo; set => descripcionTipo = value; }
        public int Id { get => id; set => id = value; }

        public TipodeCuenta(int id, string descripcion)
        {
            Id = id;
            DescripcionTipo = descripcion;
        }
        public TipodeCuenta(){}

        public List<TipodeCuenta> TraerTipos()
        {
            List<TipodeCuenta> listadetipos = new List<TipodeCuenta>();
            string query = "SELECT * FROM tipocuenta";

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
                        TipodeCuenta tipo = new TipodeCuenta(int.Parse(reader.GetString(0)), reader.GetString(1));
                        listadetipos.Add(tipo);
                    }
                }

                databaseConnection.Close();
                return listadetipos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listadetipos;
            }
        }
    }
}
