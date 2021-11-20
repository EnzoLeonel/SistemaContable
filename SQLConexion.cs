using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaContable
{
    class SQLConexion
    {
        private static SQLConexion conexion = null;
        private string datos = "";

        private SQLConexion()
        {
            //Conexion predeterminada
            datos = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
        }
        public static SQLConexion Conexion
        {
            get
            {
                if (conexion == null)
                    conexion = new SQLConexion();
                return conexion;
            }
        }
        public void setDatos (string datos)
        {
            this.datos = datos;
        }
        public string getDatos()
        {
            return datos;
        }
        public bool hayConexion()
        {
            bool conectado = false;
            try
            {
                MySqlConnection databaseConnection = new MySqlConnection(datos);
                databaseConnection.Open();
                conectado = true;
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar al servidor");
            }
            return conectado;
        }
    }
}
