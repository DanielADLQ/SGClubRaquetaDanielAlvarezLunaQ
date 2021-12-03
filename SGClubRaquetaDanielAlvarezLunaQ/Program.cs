using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubRaquetaDanielAlvarezLunaQ
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new ClubPistas());
            //Application.Run(new ClubReservas());
            //Application.Run(new ClubSocios());
            Application.Run(new Menu());
        }
    }
}
