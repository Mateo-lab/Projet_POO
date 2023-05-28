using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.IO;
using Ranch_Sorting.Modeles;
using System.Linq;

namespace Ranch_Sorting_App.Donnees
{
    public class BD
    {
        private OleDbConnection _oleConnection;

        public BD()
        {
            string repCourant = Directory.GetCurrentDirectory();  // répertoire de l'exécutable

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;";
            connectionString += @"Data Source =" + repCourant + @"/../../BD/BaseDeDonnéesProjet.mdb";

            //Instanciation de l'objet assurant la connexion à la BD
            _oleConnection = new OleDbConnection(connectionString);
            _oleConnection.Open();
        }

        /////////////////// Methode BD/////////////////////
        public void CloseConnexionBD()
        {
            if (_oleConnection != null)
                _oleConnection.Close();
            _oleConnection = null;
        }
        private OleDbCommand ExecuteRequest(string req)
        {
            OleDbCommand cmd = new OleDbCommand(req, _oleConnection);
            return cmd;
        }
        public IDataReader ExecuteReaderRequest(string req)
        {
            OleDbCommand cmd = ExecuteRequest(req);
            return cmd.ExecuteReader();
        }
        public void ExecuteNonQueryRequest(string req)
        {
            OleDbCommand cmd = ExecuteRequest(req);
            cmd.ExecuteNonQuery();
        }

        ///////////////////////////////////////////////////

        public List<Equipe> ObtienEquipe()
        {
            List<Equipe> listeDesEquipes = new List<Equipe>(); // Liste des equipes qui sera retournée par la méthode 
            string req = "SELECT * FROM Equipes ORDER BY [Nom équipe] ASC"; // Requete SQL pour obtenir les equipes
            IDataReader reader = ExecuteReaderRequest(req); // Execute la requete et retourne un IDataReader

            while(reader.Read())
            {
                // Ajoute les equipes dans la liste des equipes 
                // champs : NomEquipe, NomCavalier1, NomCavalier2, NomCheval1, NomCheval2
                
                listeDesEquipes.Add(new Equipe(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4))); // Ajoute les equipes dans la liste des equipes 

            }
            reader.Close(); // Ferme le reader
            return listeDesEquipes; // Retourne la liste des equipes
        }
        public int ObtientNbrIscription(string nomEquipe) 
        {
            int nombreEquipes = 0;

            string req = "SELECT COUNT(*) FROM Inscription WHERE [Nom équipe] = '"+ nomEquipe +"' NombreRound = 1";
            using (IDataReader reader = ExecuteReaderRequest(req))
            {
                if (reader.Read())
                {
                    nombreEquipes = reader.GetInt32(0);
                }
            }
            return nombreEquipes;
        }
        public List<Lieu> ObtienLieu()
        {
            List<Lieu> listeDesLieux = new List<Lieu>(); // Liste des lieux qui sera retournée par la méthode 
            string req = "SELECT * FROM Lieux ORDER BY [Nom lieu] ASC"; // Requete SQL pour obtenir les lieux
            IDataReader reader = ExecuteReaderRequest(req); // Execute la requete et retourne un IDataReader

            while (reader.Read())
            {
                // Ajoute les lieux dans la liste des lieux 
                // champs : NomLieu, Adresse, NomProprietaire

                listeDesLieux.Add(new Lieu(reader.GetString(0), reader.GetString(1), reader.GetString(2))); // Ajoute les lieux dans la liste des lieux 

            }
            reader.Close(); // Ferme le reader
            return listeDesLieux; // Retourne la liste des lieux
        }
        public List<string> ObtienNomLieux()
        {
            string req = "SELECT [Nom Lieu] FROM Lieux";
            IDataReader reader = ExecuteReaderRequest(req);

            List<string> listeDesNomDesLieux = new List<string>();

            while (reader.Read())
            {
                string nomLieu = reader.GetString(0);
                listeDesNomDesLieux.Add(nomLieu);
            }
            reader.Close();
            return listeDesNomDesLieux;
        }
        public List<Inscription> ObtienInscriptions(string nomEpreuve)
        {
            List<Inscription> listeDesInscriptions = new List<Inscription>(); // Liste des inscriptions qui sera retournée par la méthode 
            string req = "SELECT * FROM Inscriptions WHERE [Nom épreuve] = '"+ nomEpreuve +"' ORDER BY [Nom équipe] ASC"; // Requete SQL pour obtenir les inscriptions
            IDataReader reader = ExecuteReaderRequest(req); // Execute la requete et retourne un IDataReader

            while (reader.Read())
            {
                // Ajoute les inscriptions dans la liste des inscriptions

                DateTime dateEpreuve = reader.GetDateTime(2);
                DateTime dateInscription = reader.GetDateTime(4);
                string dateEpreuveEnString = dateEpreuve.ToString("d-MM-yyy");
                string dateInscriptionEnString = dateInscription.ToString("d-MM-yyy");

                listeDesInscriptions.Add(new Inscription(reader.GetInt32(0), reader.GetString(1), dateEpreuveEnString, reader.GetString(3), dateInscriptionEnString, reader.GetBoolean(5))); // Ajoute les inscriptions dans la liste des inscriptions

            }
            reader.Close(); // Ferme le reader
            return listeDesInscriptions; // Retourne la liste des inscriptions
        }

        public int ObtienIDInscription(string nomEpreuve,string nomEquipe)
        {
            int idInscription = 0;
            string req = "SELECT [IDinscription] ";  // mieux : StringBuilder
            req += "FROM Inscriptions ";
            req += "WHERE [Nom épreuve]= '"+ nomEpreuve + "' ";;
            req += "AND [Nom équipe] = '" + nomEquipe + "'";

            IDataReader reader = ExecuteReaderRequest(req); // Execute la requete et retourne un IDataReader
            while (reader.Read())
            {
                // Ajoute les equipes dans la liste des equipes 
                // champs : NomEquipe, NomCavalier1, NomCavalier2, NomCheval1, NomCheval2
                idInscription = reader.GetInt32(0);
            }
            reader.Close(); // Ferme le reader
            return idInscription; // Retourne la liste des equipes
        }
        public List<Epreuve> ObtienEpreuves()
        {
            List<Epreuve> epreuves = new List<Epreuve>(); // Liste des inscriptions qui sera retournée par la méthode 
            string req = "SELECT * FROM Epreuves"; // Requete SQL pour obtenir les inscriptions
            IDataReader reader = ExecuteReaderRequest(req); // Execute la requete et retourne un IDataReader

            while (reader.Read())
            {
                // Ajoute les inscriptions dans la liste des inscriptions

                DateTime dateEpreuve = reader.GetDateTime(1);
                string dateEpreuveEnString = dateEpreuve.ToString("d-M-yyy");;

                epreuves.Add(new Epreuve(reader.GetString(0), dateEpreuveEnString, reader.GetString(2), reader.GetInt32(3))); // Ajoute les inscriptions dans la liste des inscriptions

            }
            reader.Close(); // Ferme le reader
            return epreuves;
        }
        public List<string> ObtienNomEpreuve()
        {
            string req = "SELECT [Nom épreuve] FROM Epreuves";
            req += " ORDER BY [Date épreuve]";
            IDataReader reader = ExecuteReaderRequest(req);

            List<string> listeDesNomDesEpreuves = new List<string>();

            while (reader.Read())
            {
                string nomEpreuve = reader.GetString(0);
                listeDesNomDesEpreuves.Add(nomEpreuve);
            }
            reader.Close();
            return listeDesNomDesEpreuves;
        }

        public List<string> ObtienNbrRound(string nomEpreuve)
        {
            string req = "SELECT [Nombre de round] FROM Epreuves WHERE [Nom épreuve] = '" + nomEpreuve + "' ";
            IDataReader reader = ExecuteReaderRequest(req);

            List<string> nbrRound = new List<string>();

            while (reader.Read())
            {
                string _nbrRound = reader.GetInt32(0).ToString();
                nbrRound.Add(_nbrRound);
            }
            reader.Close();
            return nbrRound;
        }

        public string ObtienDateEpreuve(string nomEpreuve)
        {
            string req = "SELECT [Date épreuve] FROM Epreuves WHERE [Nom épreuve] = '" + nomEpreuve + "'";
            IDataReader reader = ExecuteReaderRequest(req);

            string listeDesDateDesEpreuves = "";

            while (reader.Read())
            {

                DateTime dateEpreuve = reader.GetDateTime(0);
                listeDesDateDesEpreuves = dateEpreuve.ToString("d-MM-yy"); ;
            }
            reader.Close();
            return listeDesDateDesEpreuves;
            
        }
        public List<Scores> ObtienScores(string nomEpreuve, int numRound, out bool sansScore)
        {
            int i = 0;
            bool _sansScore = false;
            List<Scores> listeDesScores = new List<Scores>(); // Liste des scores qui sera retournée par la méthode 
            string req = "SELECT [Scores équipes].[Nom équipe], [Nb vaches validées], [Temps dernière vache]";
            req += ", [Temps vache 0], [Temps vache 1], [Temps vache 2], [Temps vache 3], [Temps vache 4],";
            req += " [Temps vache 5], [Temps vache 6], [Temps vache 7], [Temps vache 8], [Temps vache 9]";
            req += " FROM ([Inscriptions]";
            req += " INNER JOIN [Scores équipes] ON Inscriptions.IDinscription = [Scores équipes].IDinscription)"; 
            req += " WHERE [N° round] = "+ numRound +" AND Inscriptions.[Nom épreuve] = '" + nomEpreuve + "'";
            req += " ORDER BY [Nb vaches validées] DESC, [Temps dernière vache] ASC;";
            
            IDataReader reader = ExecuteReaderRequest(req); 

            while (reader.Read())
            {
                // Ajoute les scores dans la liste des scores 
                // champs : NomEquipe, NumRound, NbrVache, TDerniereV, TV1, TV2, TV3, TV4, TV5, TV6, TV7, TV8, TV9, TV10
                if (i == 0)
                {
                    string check_sansScore = reader.GetString(2);
                    string check_sansInscrit = reader.GetString(0);
                    if (check_sansScore == "" )
                    {
                        _sansScore = true;
                    }
                }
                listeDesScores.Add(new Scores(reader.GetString(0), numRound, reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12)));// Ajoute les scores dans la liste des scores 
                i = 1;
            }
            sansScore = _sansScore;
            reader.Close(); // Ferme le reader
            return listeDesScores; // Retourne la liste des scores
        }

        public List<Inscription> CreateRandomPassageList(string nomEpreuve)
        {
            List<Inscription> listePassage = new List<Inscription>();
            listePassage = ObtienInscriptions(nomEpreuve); // Obtient la liste des inscriptions
            // Mélanger la liste de passage
            Random random = new Random();
            listePassage = listePassage.OrderBy(x => random.Next()).ToList();
            return listePassage;
        }
        public ListeNomsEquipes ObtienOrdreParticipants(string nomEpreuve, int numRound)
        {
            List<Scores> listeDesScores = new List<Scores>();
            string req = "SELECT [Nom équipe] FROM Inscriptions";
            req += " WHERE [Nom épreuve] = '" + nomEpreuve + "'"; // Requete SQL pour obtenir les scores
            IDataReader reader = ExecuteReaderRequest(req); // Execute la requete et retourne un IDataReader

            while (reader.Read())
            {
                // Ajoute les scores dans la liste des scores 
                string nomEquipes = reader.GetString(0);

                listeDesScores.Add(new Scores(reader.GetString(0), 1 , "", "", "", "", "", "", "", "", "", "", "", ""));// Ajoute les scores dans la liste des scores 
            }
            reader.Close(); // Ferme le reader

            ListeNomsEquipes listeNomsEquipesMelangee = new ListeNomsEquipes(listeDesScores.Select(score => score.NomEquipe));

            // Mélanger l'ordre des équipes dans la liste
            listeNomsEquipesMelangee.MelangerEquipes();

            return listeNomsEquipesMelangee; // Retourne la liste des noms des équipes
        }

        public void AjouterEquipe(string nomEquipe, string nomCavalier1, string nomCheval1, string nomCavalier2, string nomCheval2)
        {
            string req = "INSERT INTO Equipes VALUES ('" + nomEquipe + "', '" + nomCavalier1 + "', '" + nomCavalier2 + "', '" + nomCheval1 + "', '" + nomCheval2 + "')";
            ExecuteNonQueryRequest(req);
        }
        public void SupprimerEquipe(string nomEquipe)
        {
            string req = "DELETE FROM Equipes WHERE [Nom équipe] = '" + nomEquipe + "'";
            ExecuteNonQueryRequest(req);
        }
        public void AjouterLieu(string nomLieu, string adresse, string nomProprietaire)
        {
            string req = "INSERT INTO Lieux VALUES ('" + nomLieu + "', '" + adresse + "', '" + nomProprietaire + "')";
            ExecuteNonQueryRequest(req);
        }
        public void SupprimerLieu(string nomLieu)
        {
            
            string req = "DELETE FROM Lieux WHERE [Nom lieu] = '" + nomLieu + "'";
            ExecuteNonQueryRequest(req);
        }   
        public void CreerEpreuve(string nomEpreuve, string dateEpreuve, string nomLieu, int nbrRound)
        {
            string req = "INSERT INTO Epreuves VALUES ('" + nomEpreuve + "', '" + dateEpreuve + "' , '" + nomLieu + "', " + nbrRound +" ) ;";
            ExecuteNonQueryRequest(req);
        }
        public void AjouterEpreuveDansScore(string idInscription, string nomEquipe)
        {
            string req = "INSERT TABLE [Scores équipe] " +
                "'" + idInscription + "', '" + nomEquipe + "', NumRound INTEGER, NbrVache INTEGER, TempsDernieresVache TEXT(255), " +
                "TempsVache0 TEXT(255), TempsVache1 TEXT(255), TempsVache2 TEXT(255), TempsVache3 TEXT(255), TempsVache4 TEXT(255), " +
                "TempsVache5 TEXT(255), TempsVache6 TEXT(255), TempsVache7 TEXT(255), TempsVache8 TEXT(255), TempsVache9 TEXT(255))";
            //Primary key (NomEquipe) represente la clé primaire de la table qui ne peut pas être null ni avoir de doublons
            ExecuteNonQueryRequest(req);

        }
        public bool CheckInscription(string nomEpreuve, string nomEquipe)
        {
            string req = "SELECT * FROM Inscriptions WHERE [Nom épreuve] = '" + nomEpreuve + "' AND [Nom équipe] = '" + nomEquipe + "'";
            IDataReader reader = ExecuteReaderRequest(req);

            bool check = reader.Read();
            reader.Close();
            return check;
        }
        public void AjouterInscriptionEtEquipeScore(string nomEpreuve, string dateEpreuve, string nomEquipe, string dateInscription, bool paye, int nbrRound, int nbrVache, string tDerniereV, string tV1, string tV2, string tV3, string tV4, string tV5, string tV6, string tV7, string tV8, string tV9, string tV10)
        {
            int idInscription = 0; // Déterminez comment générer l'IDInscription ici

            string req = "INSERT INTO Inscriptions ([Nom épreuve], [Date épreuve], [Nom équipe], [Date inscription], [Payé])";
            req += " VALUES ('" + nomEpreuve + "' , '" + dateEpreuve + "', '" + nomEquipe + "', '" + dateInscription + "', " + paye + ") ";
            ExecuteNonQueryRequest(req);

            req = "SELECT IDinscription FROM [Inscriptions] ";
            req += "WHERE [Nom épreuve] = '" + nomEpreuve + "' AND [Nom équipe] = '" + nomEquipe + "';"; // Requete SQL pour obtenir les inscriptions
            IDataReader reader = ExecuteReaderRequest(req); // Execute la requete et retourne un IDataReader

            while (reader.Read())
            {
                idInscription = reader.GetInt32(0);
            }
            reader.Close();

            for (int i = 1; i <= nbrRound; i++)
             {
                string reqScore = "INSERT INTO [Scores équipes] VALUES";
                reqScore += " ('" + idInscription + "', '" + nomEquipe + "', " + i + ", " + nbrVache + ", '" + tDerniereV + "', '" + tV1 + "', '" + tV2 + "', '" + tV3 + "', '" + tV4 + "', '" + tV5 + "', '" + tV6 + "', '" + tV7 + "', '" + tV8 + "', '" + tV9 + "', '" + tV10 + "')";
                ExecuteNonQueryRequest(reqScore);
             }
               
        }
        public void SupprimerUneInscription(int idInscription)
        {
            string req = "DELETE FROM Inscriptions WHERE [IDinscription] = " + idInscription + "";
            ExecuteNonQueryRequest(req);
        }

        public void SupprimerInscriptionDansScore(int idInscription)
        {
            string req = "DELETE FROM [Scores équipes] WHERE [IDinscription] = " + idInscription + "";
            ExecuteNonQueryRequest(req);
        }

        public void SupprimerUneInscriptionEtEquipe(string nomEquipe)
        {
            string req = "DELETE FROM [Scores équipes] WHERE IDinscription IN (SELECT IDinscription   FROM [Inscriptions]";
            req += " WHERE [Nom équipe] = '" + nomEquipe + "')";
         
            ExecuteNonQueryRequest(req);

            req = "DELETE FROM [Inscriptions] WHERE [Nom équipe] = '" + nomEquipe + "'";

            ExecuteNonQueryRequest(req);

            req = "DELETE FROM [Equipes] WHERE [Nom équipe] = '" + nomEquipe + "'";

            ExecuteNonQueryRequest(req);
        }
        public void AjouterTempsVache(string nomEpreuve,string nomEquipe, int numRound, int numVache, string temps)
        {
            int id = ObtienIDInscription(nomEpreuve, nomEquipe);
            string champs = "Temps vache " + numVache;
            string req = "UPDATE [Scores équipes] SET [" + champs + "] = ' " + temps + "', [Temps dernière vache]  = '" + temps + "'"; 
            req += " WHERE [IDinscription] = " + id +" AND [N° round] = " + numRound + " ;";
            ExecuteNonQueryRequest(req);
        }
        public void ResultatsEquipe(string nomEpreuve, string nomEquipe, int numRound, string nbrVache)
        {

            int id = ObtienIDInscription(nomEpreuve, nomEquipe);
            string req = "UPDATE [Scores équipes] SET [Nb vaches validées] = '" + nbrVache + "' ";
            req += " WHERE [IDinscription] = " + id + " AND [N° round] = " + numRound + " ";
            ExecuteNonQueryRequest(req);
        }
    }
}
