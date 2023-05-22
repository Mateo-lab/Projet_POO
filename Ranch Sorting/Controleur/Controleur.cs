using Ranch_Sorting_App.Donnees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Ranch_Sorting.Controleur
{
    public class Controle
    {
        private BD _bd;

        public Controle()
        {
            _bd = new BD();   
        }

        public void ouvreBD()
        {
            if (_bd == null)
                _bd = new BD();
        }

        public void fermeBD()
        {
            if (_bd != null)
                _bd.CloseConnexionBD();
            _bd = null;
        }

    }
}
