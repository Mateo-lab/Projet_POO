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
        public List<Inscription> CreateRandomPassageList(string nomEpreuve)
        {
            return _bd.CreateRandomPassageList(nomEpreuve);
        }
        public List<Inscription> GetInscriptions(string nomEpreuve)
        {
            //if ( _bd == null) return null;
            return _bd.ObtienInscriptions(nomEpreuve);
        }
        public int GetIdInscription(string nomEpreuve, string nomEquipe)
        {
            return _bd.ObtienIDInscription(nomEpreuve, nomEquipe);
        }
        public int GetNbrInscription(string nomEpreuve)
        {
            return _bd.ObtientNbrIscription(nomEpreuve);
        }
        public List<string> GetNbrRound(string nomEpreuve)
        {
            return _bd.ObtienNbrRound(nomEpreuve);
        }
        public List<Scores> GetScores(string nomEpreuve, int numRound, out bool sansScore)
        {
            //if ( _bd == null) return null;
            return _bd.ObtienScores(nomEpreuve, numRound, out sansScore);
        }
        public List<Epreuve> GetEpreuves()
        {
            //if ( _bd == null) return null;
            return _bd.ObtienEpreuves();
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
        public string GetInitiales(string phrase)
        {
            string[] mots = phrase.Split(' ');
            string initiales = "";

            foreach (string mot in mots)
            {
                if (!string.IsNullOrEmpty(mot))
                {
                    initiales += char.ToUpper(mot[0]);
                }
            }

            return initiales;
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
        public void CreerEpreuve(string nomEpreuve, string dateEpreuve, string nomLieu, int nbrRound)
        {
            _bd.CreerEpreuve(nomEpreuve, dateEpreuve, nomLieu, nbrRound);
        }
        public bool CheckInscription(string nomEpreuve, string nomEquipe)
        {
            return _bd.CheckInscription(nomEpreuve, nomEquipe);
        }
        public void AjouterInscriptionEtEquipeScore(string nomEpreuve, string dateEpreuve, string nomEquipe, string dateInscription, bool paye, int nbrRound, int nbrVache, string tDerniereV, string tV1, string tV2, string tV3, string tV4, string tV5, string tV6, string tV7, string tV8, string tV9, string tV10)
        {
           _bd.AjouterInscriptionEtEquipeScore(nomEpreuve, dateEpreuve, nomEquipe, dateInscription, paye, nbrRound, nbrVache, tDerniereV, tV1, tV2, tV3, tV4, tV5, tV6, tV7, tV8, tV9, tV10) ;
        }
        public void SupprimerUneInscription(int idInscription)
        {
            _bd.SupprimerUneInscription(idInscription);
        }
        public void SupprimerInscriptionDansScore(int idInscription)
        {
            _bd.SupprimerInscriptionDansScore(idInscription);
        }
        public void SupprimerUneInscriptionEtEquipe(string nomEquipe)
        {
            _bd.SupprimerUneInscriptionEtEquipe(nomEquipe);
        }
        public void AjouterTempsVache(string nomEpreuve, string nomEquipe, int numRound, int numVache, string tempsVache)
        {
            _bd.AjouterTempsVache(nomEpreuve, nomEquipe, numRound, numVache, tempsVache);
        }
        public void ResultatsEquipe(string nomEpreuve, string nomEquipe, int numRound, string nbrVache)
        {
            _bd.ResultatsEquipe(nomEpreuve, nomEquipe, numRound, nbrVache);
        }
    }
}
