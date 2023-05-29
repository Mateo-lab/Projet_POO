using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranch_Sorting.Modeles
{
    public class Lieu
    {
        private string _nomLieu, _adresse, _proprietaire;// Les infos que chaque lieu doit avoir

        //CONSTRUCTEUR
        public Lieu(string nomLieu, string adresse, string proprietaire)
        {
            _nomLieu = nomLieu;
            _adresse = adresse;
            _proprietaire = proprietaire;
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
                    throw new Exception("Veuillez entrer le nom du lieu");
            }
        }
        public string Adresse
        {
            get
            {
                return _adresse;
            }
            set
            {
                if (value != "")
                    _adresse = value;
                else
                    throw new Exception("Veuillez entrer l'adresse du lieu");
            }
        }
        public string Propriétaire
        {
            get
            {
                return _proprietaire;
            }
            set
            {
                if (value != "")
                    _proprietaire = value;
                else
                    throw new Exception("Veuillez entrer le nom du proprietaire du lieu");
            }
        }
        public static List<string> GetNomLieu(List<Ranch_Sorting.Modeles.Lieu> lieux)
        {
            List<string> listeDesNomsDesLieux = new List<string>();
            foreach (var Lieu in lieux)
            {
                listeDesNomsDesLieux.Add(Lieu.NomLieu);
            }
            return listeDesNomsDesLieux;
        }
    }
}
