using Ranch_Sorting.Modeles;
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

        public List<Equipe> GetEquipe()
        {
            //if ( _bd == null) return null;
            return _bd.ObtienEquipe();
        }

        public List<Lieu> GetLieu()
        {
            //if ( _bd == null) return null;
            return _bd.ObtienLieu();
        }

        public List<string> GetNomLieux()
        {
            return _bd.ObtienNomLieux();
        }
        public void AjouterEquipe(string nomEquipe, string nomCavalier1, string nomCheval1, string nomCavalier2, string nomCheval21)
        {
            _bd.AjouterEquipe(nomEquipe, nomCavalier1, nomCheval1, nomCavalier2, nomCheval21);
        }
        public void SupprimerEquipe(string nomEquipe)
        {
            _bd.SupprimerEquipe(nomEquipe);
        }

        public void AjouterLieu(string nomLieu, string adresse, string nomProprietaire)
        {
            _bd.AjouterLieu(nomLieu, adresse, nomProprietaire);
        }
    }
}
