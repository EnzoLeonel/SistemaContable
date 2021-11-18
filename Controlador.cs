using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaContable.Vistas;

namespace SistemaContable
{
    public class Controlador
    {
        private string conexionDB = "datasource=127.0.0.1;port=3306;username=root;password=;database=librodiario;";
        private AjustesMenu vistaAJ;
        private MenuPrincipal vistaMenuP;
        //Modelo modelo;
        public Controlador() { }
        public Controlador(MenuPrincipal vistaMenuP /*,Modelo modelo*/)
        {
            this.vistaMenuP = vistaMenuP;
            //this.modelo = modelo;
        }
        public void setConexionDB(string conexionDB)
        {
            this.conexionDB = conexionDB;
        }

    }
}
