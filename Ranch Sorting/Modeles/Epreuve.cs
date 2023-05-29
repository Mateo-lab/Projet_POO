using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ranch_Sorting.Modeles
{
    public class Epreuve
    {
        private string _nomEpreuve, _dateEpreuve, _nomLieu;// Les infos que chaque epreuve doit avoir
        private int _numRound;

        //CONSTRUCTEUR
        public Epreuve(string nomEpreuve, string date, string nomLieu, int numRound)
        {
            _nomEpreuve = nomEpreuve;
            _dateEpreuve = date;
            _nomLieu = nomLieu;
            _numRound = numRound;
        }
        public string NomEpreuve
        {
            get
            {
                return _nomEpreuve;
            }
            set
            {
                if (value != "")
                    _nomEpreuve = value;
                else
                    throw new Exception("Veuillez entrer le nom de l'epreuve");
            }
        }
        public string DateEpreuve
        {
            get
            {
                return _dateEpreuve;
            }
            set
            {
                if (value != "") // si il n'y a pas de date
                    _dateEpreuve = value;
                else
                    throw new Exception("Veuillez entrer la date de l'epreuve");
            }
        }
        public string NomLieu 
        {
            get
            {
                return _nomLieu;
            }
            set
            {
                if (value != "")
                    _nomLieu = value;
                else
                    throw new Exception("Veuillez choisir le lieu de l'epreuve");
            }
        }
        public int NumRound
        {
            get
            {
                return _numRound;
            }
            set
            {
                _numRound = value;
            }
        }
        public static List<string> GetNomEpreuve(List<Ranch_Sorting.Modeles.Epreuve> epreuves)
        {
            List<string> listeDesNomDesEpreuves = new List<string>();
            foreach (var epreuve in epreuves)
            {
                listeDesNomDesEpreuves.Add(epreuve.NomEpreuve);
            }
            return listeDesNomDesEpreuves;
        }
        public static int GetNbrRound(List<Ranch_Sorting.Modeles.Epreuve> epreuves, string nomEpreuve)
        {
            int nbrRound = 1;
            foreach (var epreuve in epreuves)
            {
                if (nomEpreuve == epreuve.NomEpreuve)
                {
                    nbrRound = epreuve.NumRound;
                    break;  
                }
            }
            return nbrRound;
        }

        public static string GetDateEpreuve(List<Ranch_Sorting.Modeles.Epreuve> epreuves ,  string nomEpreuve)
        {
            string dateEpreuve = "";
            foreach (var epreuve in epreuves)
            {
                if (nomEpreuve == epreuve.NomEpreuve)
                {
                    dateEpreuve = epreuve.DateEpreuve;
                    break;
                }
            }
            return dateEpreuve;
        }
    }
}