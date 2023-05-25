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
        public List<Inscription> GetInscriptions(string nomEpreuve)
        {
            //if ( _bd == null) return null;
            return _bd.ObtienInscriptions(nomEpreuve);
        }
        public List<Scores> GetScores(string nomEpreuve, string dateEpreuve, int numRound)
        {
            //if ( _bd == null) return null;
            return _bd.ObtienScores(nomEpreuve, dateEpreuve, numRound);
        }
        public List<Epreuve> GetEpreuves(string nomEpreuve)
        {
            //if ( _bd == null) return null;
            return _bd.ObtienEpreuves(nomEpreuve);
        }
        public List<string> GetNomEpreuve()
        {
            if ( _bd == null) return null;
            return _bd.ObtienNomEpreuve();
        }
        public string GetDateEpreuve(string nomEpreuve)
        {
            //if ( _bd == null) return null;
            return _bd.ObtienDateEpreuve(nomEpreuve);
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
        public void SupprimerLieu(string nomLieuASupprimer)
        {
            _bd.SupprimerLieu(nomLieuASupprimer);
        }
        public void CreerEpreuve(string nomEpreuve, string dateEpreuve, string nomLieu)
        {
            _bd.CreerEpreuve(nomEpreuve, dateEpreuve, nomLieu);
        }

        public void CreationNouvelleTableScore(string nomEpreuve, string dateEpreuve)
        {
            _bd.CreationNouvelleTableScore(nomEpreuve, dateEpreuve);
        }
        public void AjouterUneInscription(string nomEpreuve, string dateEpreuve, string nomEquipe, string dateInscription, bool payé )
        {
            _bd.AjouterUneInscription(nomEpreuve, dateEpreuve, nomEquipe, dateInscription, payé);
        }

        public void SupprimerUneInscription(string nomEquipe)
        {
            _bd.SupprimerUneInscription(nomEquipe);
        }

        public  void AjouterInscriptionDansScore(string nomEpreuve, string dateEpreuve, string nomEquipe, int numRound, int nbrVache, string tDerniereV, string tV1, string tV2, string tV3, string tV4, string tV5, string tV6, string tV7, string tV8, string tV9, string tV10)
        {
            _bd.AjouterInscriptionDansScore(nomEpreuve, dateEpreuve, nomEquipe, numRound, nbrVache, tDerniereV, tV1, tV2, tV3, tV4, tV5, tV6, tV7, tV8, tV9, tV10);
        }

        public void SupprimerInscriptionDansScore(string nomEquipe)
        {
            _bd.SupprimerInscriptionDansScore(nomEquipe);
        }

        public void AjouterTempsVache(string nomEpreuve, string dateEpreuve, string nomEquipe, int numRound, int numVache, string tempsVache)
        {
            _bd.AjouterTempsVache(nomEpreuve, dateEpreuve, nomEquipe, numRound, numVache, tempsVache);
        }
    }
}
