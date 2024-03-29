﻿using MySql.Data.MySqlClient;
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
        private List<Movimiento> asiento_movimiento;

        public int Id { get => id; set => id = value; }
        public int Numero_asiento { get => numero_asiento; set => numero_asiento = value; }
        public string Fecha_asiento { get => fecha_asiento; set => fecha_asiento = value; }
        public string Descripcion_asiento { get => descripcion_asiento; set => descripcion_asiento = value; }
        internal List<Movimiento> Asiento_movimiento { get => asiento_movimiento; set => asiento_movimiento = value; }

        public static List<Asiento> ListarAsientosporFecha(string fecha)
        {
            List<Asiento> listadeasientos = new List<Asiento>();
            string query = "SELECT * FROM asiento a WHERE (a.fecha_asiento = '" + fecha + "')";


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
                        Asiento asiento = new Asiento();
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
        public static List<Asiento> ListarAsientos()
        {
            List<Asiento> listadeasiento = new List<Asiento>();
            string query = "SELECT * FROM asiento";


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
                        Asiento asiento = new Asiento();
                        asiento.Id = reader.GetInt32(0);
                        asiento.Numero_asiento = reader.GetInt32(1);
                        asiento.Fecha_asiento = reader.GetString(2);
                        asiento.Descripcion_asiento = reader.GetString(3);
                        listadeasiento.Add(asiento);
                    }
                }

                databaseConnection.Close();
                return listadeasiento;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return listadeasiento;
            }
        }
        public static int TraerUltimoIdAsiento()
        {
            int ultimoId = 0;
            string query = "SELECT id_asiento FROM asiento ORDER BY id_asiento DESC LIMIT 1;";
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
        public static string TraerUltimaFecha()
        {
            string ultimaFecha = "";
            string query = "SELECT fecha_asiento FROM asiento ORDER BY fecha_asiento DESC LIMIT 1;";
            MySqlConnection databaseConnection = new MySqlConnection(SQLConexion.Conexion.getDatos());
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                reader.Read();
                ultimaFecha = reader.GetString(0);
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ultimaFecha;
        }
        public static string TraerPrimeraFecha()
        {
            string primeraFecha = "";
            string query = "SELECT fecha_asiento FROM asiento ORDER BY fecha_asiento ASC LIMIT 1;";
            MySqlConnection databaseConnection = new MySqlConnection(SQLConexion.Conexion.getDatos());
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                reader.Read();
                primeraFecha = reader.GetString(0);
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return primeraFecha;
        }
        public static int CrearAsiento(Asiento asi)
        {
            string query = "INSERT INTO asiento(numero_asiento, fecha_asiento, descr_asiento) VALUES(" + asi.Numero_asiento + ", '" + asi.Fecha_asiento + "', '" + asi.Descripcion_asiento + "')";

            MySqlConnection databaseConnection = new MySqlConnection(SQLConexion.Conexion.getDatos());
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Asiento creado satisfactoriamente");

                databaseConnection.Close();

                return Convert.ToInt32(commandDatabase.LastInsertedId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public static void borrarAsiento(int idasiento)
        {
            string query = "DELETE FROM asiento WHERE id_asiento = " + idasiento;

            MySqlConnection databaseConnection = new MySqlConnection(SQLConexion.Conexion.getDatos());
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static List<Asiento> ListarAsientosporMes(int mes, int anio)
        {
            List<Asiento> listadeasientos = new List<Asiento>();
            string[] fechas = Convertirmesanio(mes, anio);
            string query = "SELECT * FROM asiento a WHERE (a.fecha_asiento >= '" + fechas[0] + "' AND a.fecha_asiento < '" + fechas[1] + "')";

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
                        Asiento asiento = new Asiento();
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
        public static string[] Convertirmesanio(int mes, int anio)
        {
            string[] resultado = new string[2];
            if (mes == 12)
            {
                resultado[0] = anio + "-" + mes + "-" + "01";
                anio = anio + 1;
                resultado[1] = anio + "-01-01";
            }
            else if (mes >= 1 && mes < 9)
            {
                resultado[0] = anio + "-" + 0 + mes + "-" + "01";
                mes = mes + 1;
                resultado[1] = anio + "-" + 0 + mes + "-" + "01";
            }
            else if (mes == 9)
            {
                resultado[0] = anio + "-" + 0 + mes + "-" + "01";
                resultado[1] = anio + "-10-01";
            }
            else
            {
                resultado[0] = anio + "-" + mes + "-" + "01";
                mes = mes + 1;
                resultado[1] = anio + "-" + mes + "-" + "01";
            }

            return resultado;
        }
    }
}
