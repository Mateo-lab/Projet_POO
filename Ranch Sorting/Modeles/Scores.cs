using System;
using System.Collections.Generic;

namespace Ranch_Sorting.Modeles
{
    public class Scores
    {
        private string _nomEquipe;
        private int _numRound;
        private string _nbrVache,_tDerniereV, _tV1, _tV2, _tV3, _tV4, _tV5, _tV6, _tV7, _tV8, _tV9, _tV0;

        public Scores(string nomEquipe,int numRound, string nbrVache,
            string tDerniereV, string tV0, string tV1, string tV2, string tV3, string tV4, string tV5, string tV6, string tV7, string tV8, string tV9)
        {
            _nomEquipe = nomEquipe;
            _numRound = numRound;
            _nbrVache = nbrVache;
            _tDerniereV = tDerniereV;
            _tV0 = tV0;
            _tV1 = tV1;
            _tV2 = tV2;
            _tV3 = tV3;
            _tV4 = tV4;
            _tV5 = tV5;
            _tV6 = tV6;
            _tV7 = tV7;
            _tV8 = tV8;
            _tV9 = tV9;
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

        public string NbrVache
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

        public string TV0
        {
            get
            {
                return _tV0;
            }
            set
            {
                _tV0 = value;
            }
        }

    }
    
    
}
