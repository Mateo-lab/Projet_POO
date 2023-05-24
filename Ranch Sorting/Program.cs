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
            Lobby fenetrePrincipale = new Lobby() // création de la fenêtre principale
            {
                //Il faut que la fenêtre principale connaisse le contrôleur 
                //Elle pourra le faire connaître aux autres vues
                Controleur = ctrl // initialisation du contrôleur de la fenêtre principale
            };
            try
            {
                Application.Run(fenetrePrincipale);  // affichage de la fenêtre principale
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur : \n" + exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
