using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranch_Sorting.Modeles
{
    public class Equipe
    {
        private string _nomEquipe, _nomCavalier1, _nomCavalier2, _nomCheval1, _nomCheval2;// Les infos que chaque equipe doit avoir


        //CONSTRUCTEUR
        public Equipe(string nomEquipe, string nomCavalier1, string nomCavalier2, string nomCheval1, string nomCheval2)
        {
            _nomEquipe = nomEquipe;
            _nomCavalier1 = nomCavalier1;
            _nomCavalier2 = nomCavalier2;
            _nomCheval1 = nomCheval1;
            _nomCheval2 = nomCheval2;
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
        
        public string NomCavalier1
        {
            get 
            { 
                return _nomCavalier1;
            } 
            set 
            {
                if (value != "")
                    _nomCavalier1 = value;
                else
                    throw new Exception("Veuillez entrer le nom du Cavalier 1");
            }   
        
        }
        public string NomCavalier2
        {
            get
            {
                return _nomCavalier2;
            }
            set
            {
                if (value != "")
                    _nomCavalier2 = value;
                else
                    throw new Exception("Veuillez entrer le nom du Cavalier 2");
            }

        }
        public string NomCheval1
        {
            get
            {
                return _nomCheval1;
            }
            set
            {
                if (value != "")
                    _nomCheval1 = value;
                else
                    throw new Exception("Veuillez entrer le nom du Cheval 1");
            }

        }
        public string NomCheval2
        {
            get
            {
                return _nomCheval2;
            }
            set
            {
                if (value != "")
                    _nomCheval2 = value;
                else
                    throw new Exception("Veuillez entrer le nom du Cheval 2");
            }

        }
    }
    public class ListeNomsEquipes : List<string>
    //Liste des noms des equipes participantes à l'epreuve en cours herite de la classe List<string> 
    //List<string> est une classe generique
    // L'avantage de cette façon de faire est que l'on peut utiliser toutes les methodes de List<string>
    // comme Add, Remove, Clear, etc.
    {
        public ListeNomsEquipes(IEnumerable<string> collection) : base(collection)
        {
        }
        public string GetNomEquipeEnCours(int numeroDePassage)
        {
            if (Count > 0)
            {
                return this[numeroDePassage]; //Attention numero de passage commence à 0
            }
            else
            {
                // Gérer le cas où la liste est vide
                return string.Empty;
            }
        }
        public string GetNomEquipeSuivante(int numeroDePassage)
        {
            if (Count > 0)
            {
                return this[numeroDePassage+1];
            }
            else
            {
                // Gérer le cas où la liste est vide
                return string.Empty;
            }
        }
        public void MelangerEquipes()
        {
            Random random = new Random();
            int count = Count; // Count permet de compter le nombre d'éléments dans la liste (ici le nombre d'équipes)
            while (count > 1)
            {
                count--;
                int index = random.Next(count + 1);
                string temp = this[index];
                this[index] = this[count];
                this[count] = temp;
            }
        }
        public int CompterEquipes()
        {
            return Count;
        }
    }
}
