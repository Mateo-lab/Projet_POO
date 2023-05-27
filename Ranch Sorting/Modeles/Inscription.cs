using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranch_Sorting.Modeles
{

    public class Inscription
    {
        private int _idInscription;
        private string _nomEpreuve, _dateEpreuve, _nomEquipe, _dateInscription;
        private bool _paye;

        //CONSTRUCTEUR
        public Inscription(int idInscription, string nomEpreuve, string dateEpreuve, string nomEquipe, string dateInscription, bool paye)
        {
            _idInscription = idInscription;
            _nomEpreuve = nomEpreuve;
            _dateEpreuve = dateEpreuve;
            _nomEquipe = nomEquipe;
            _dateInscription = dateInscription;
            _paye = paye;
        }

        public int IdInscription
        {
            get { return _idInscription; }
            set { _idInscription = value; }
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
                    throw new Exception("Veuillez entrer le nom de l'épreuve");
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
                if (value != "")
                    _dateEpreuve = value;
                else
                    throw new Exception("Veuillez entrer la date de l'épreuve");
            }
        }

        public string NomEquipe
        {
            get
            {
                return _nomEquipe;
            }
            set
            {
                if (value != "")
                    _nomEquipe = value;
                else
                    throw new Exception("Veuillez entrer le nom de l'équipe");
            }
        }

        public string DateInscription
        {
            get
            {
                return _dateInscription;
            }
            set
            {
                if (value != "")
                    _dateInscription = value;
                else
                    throw new Exception("Veuillez entrer la date de l'inscription");
            }
        }

        public bool Paye
        {
            get
            {
                return _paye;
            }
            set
            {
                _paye = value;
            }
        }

    }


}
