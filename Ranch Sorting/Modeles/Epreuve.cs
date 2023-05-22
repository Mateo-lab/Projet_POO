using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranch_Sorting.Modeles
{
    public class Epreuve
    {
        private string _nomEpreuve, _dateEpreuve, _nomLieu;// Les infos que chaque epreuve doit avoir


        //CONSTRUCTEUR
        public Epreuve(string nomEpreuve, string date, string nomLieu)
        {
            _nomEpreuve = nomEpreuve;
            _dateEpreuve = date;
            _nomLieu = nomLieu;
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
                //if (value != "") // si la date est dans le futur
                    _dateEpreuve = value;
                //else
                //    throw new Exception("Veuillez entrer le nom de l'epreuve");
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
    }
}