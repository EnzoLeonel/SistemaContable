using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaContable.Vistas;

namespace SistemaContable
{
    static class MVC
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            MenuPrincipal vistaMenuP = new MenuPrincipal();
            Controlador controlador = new Controlador(vistaMenuP/*, modelo*/);
            vistaMenuP.setControlador(controlador);
            Application.EnableVisualStyles();
            Application.Run(vistaMenuP);
        }
    }
}
