using System;

namespace Ranch_Sorting.Modeles
{
    public class Scores
    {
        private string _nomEpreuve, _dateEpreuve, _nomEquipe;
        private int _numRound, _nbrVache;
        private string _tDerniereV, _tV1, _tV2, _tV3, _tV4, _tV5, _tV6, _tV7, _tV8, _tV9, _tV10;

        public Scores(string nomEpreuve, string dateEpreuve, string nomEquipe,int numRound, int nbrVache,
            string tDerniereV, string tV1, string tV2, string tV3, string tV4, string tV5, string tV6, string tV7, string tV8, string tV9, string tV10)
        {
            _nomEpreuve = nomEpreuve;
            _dateEpreuve = dateEpreuve;
            _nomEquipe = nomEquipe;
            _numRound = numRound;
            _nbrVache = nbrVache;
            _tDerniereV = tDerniereV;
            _tV1 = tV1;
            _tV2 = tV2;
            _tV3 = tV3;
            _tV4 = tV4;
            _tV5 = tV5;
            _tV6 = tV6;
            _tV7 = tV7;
            _tV8 = tV8;
            _tV9 = tV9;
            _tV10 = tV10;
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
                _dateEpreuve = value;
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
                    throw new Exception("Veuillez entrer le nom de l'equipe");
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

        public int NbrVache
        {
            get
            {
                return _nbrVache;
            }
            set
            {
                _nbrVache = value;
            }
        }

        public string TDerniereV
        {
            get
            {
                return _tDerniereV;
            }
            set
            {
                _tDerniereV = value;
            }
        }

        public string TV1
        {
            get
            {
                return _tV1;
            }
            set
            {
                _tV1 = value;
            }
        }
        public string TV2
        {
            get
            {
                return _tV2;
            }
            set
            {
                _tV2 = value;
            }
        }

        public string TV3
        {
            get
            {
                return _tV3;
            }
            set
            {
                _tV3 = value;
            }
        }

        public string TV4
        {
            get
            {
                return _tV4;
            }
            set
            {
                _tV4 = value;
            }
        }
        public string TV5
        {
            get
            {
                return _tV5;
            }
            set
            {
                _tV5 = value;
            }
        }
        public string TV6
        {
            get
            {
                return _tV6;
            }
            set
            {
                _tV6 = value;
            }
        }

        public string TV7
        {
            get
            {
                return _tV7;
            }
            set
            {
                _tV7 = value;
            }
        }

        public string TV8
        {
            get
            {
                return _tV8;
            }
            set
            {
                _tV8 = value;
            }
        }

        public string TV9
        {
            get
            {
                return _tV9;
            }
            set
            {
                _tV9 = value;
            }
        }

        public string TV10
        {
            get
            {
                return _tV10;
            }
            set
            {
                _tV10 = value;
            }
        }

    }
    
}
