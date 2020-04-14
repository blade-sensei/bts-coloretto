using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Coloretto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            ///Partie de Tests 

            Partie maPartie = new Partie("2");
            maPartie.NomGagnant = "Pierre";
            Console.WriteLine(maPartie.GetGagnant());

            ///Fin de Partie de Tests
            Application.Run(new Home());
        }
    }
}
