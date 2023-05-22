using Ranch_Sorting.Vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ranch_Sorting.Controleur;



namespace Ranch_Sorting
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Controle ctrl = new Controle(); // création du contrôleur

            Application.Run(new Lobby());
        }
    }
}
