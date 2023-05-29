using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.IO;
using Ranch_Sorting.Modeles;
using System.Linq;
using System.Security.Cryptography;
using System.Data.SqlClient;

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
        }// Execute une requete qui ne retourne pas de resultat

        ///////////////////////////////////////////////////
        public List<Equipe> ObtienEquipe()// Retourne la liste des equipes
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
        public List<Inscription> ObtienInscriptions(string nomEpreuve)// Retourne la liste des inscriptions
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
        public List<Epreuve> ObtienEpreuves()// Retourne la liste des epreuves
        {
            List<Epreuve> epreuves = new List<Epreuve>(); // Liste des inscriptions qui sera retournée par la méthode 
            string req = "SELECT * FROM Epreuves ORDER BY [Date épreuve] DESC"; // Requete SQL pour obtenir les inscriptions
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
        public List<Scores> ObtienScores(string nomEpreuve, int numRound, out bool sansScore)// Retourne la liste des scores
        {
            int i = 0;
            bool _sansScore = false;
            List<Scores> listeDesScores = new List<Scores>(); // Liste des scores qui sera retournée par la méthode 
            string req = "SELECT [Scores équipes].[Nom équipe], [Nb vaches validées], [Temps dernière vache]";
            req += ", [Temps vache 0], [Temps vache 1], [Temps vache 2], [Temps vache 3], [Temps vache 4],";
            req += " [Temps vache 5], [Temps vache 6], [Temps vache 7], [Temps vache 8], [Temps vache 9]";
            req += " FROM ([Inscriptions]";
            req += " INNER JOIN [Scores équipes] ON Inscriptions.IDinscription = [Scores équipes].IDinscription)";
            req += " WHERE [N° round] = " + numRound + " AND Inscriptions.[Nom épreuve] = '" + nomEpreuve + "'";
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
                    if (check_sansScore == "")
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
        public List<Inscription> CreateRandomPassageList(string nomEpreuve)// Créer une liste de passage aléatoire
        {
            List<Inscription> listePassage = new List<Inscription>();
            listePassage = ObtienInscriptions(nomEpreuve); // Obtient la liste des inscriptions
            // Mélanger la liste de passage
            Random random = new Random();
            listePassage = listePassage.OrderBy(x => random.Next()).ToList();
            return listePassage;
        }
        public List<Lieu> ObtienLieux()// Retourne la liste des lieux
        {
            string req = "SELECT * FROM Lieux";
            IDataReader reader = ExecuteReaderRequest(req);

            List<Lieu> listeDesLieux = new List<Lieu>();

            while (reader.Read())
            {

                listeDesLieux.Add(new Lieu(reader.GetString(0), reader.GetString(1), reader.GetString(2)));
            }
            reader.Close();
            return listeDesLieux;
        }
        public bool CheckInscription(string nomEpreuve, string nomEquipe)// Vérifie si l'équipe est inscrite à l'épreuve
        {
            string req = "SELECT * FROM Inscriptions WHERE [Nom épreuve] = '" + nomEpreuve + "' AND [Nom équipe] = '" + nomEquipe + "'";
            IDataReader reader = ExecuteReaderRequest(req);

            bool check = reader.Read();
            reader.Close();
            return check;
        }
        public void AjouterEquipe(string nomEquipe, string nomCavalier1, string nomCheval1, string nomCavalier2, string nomCheval2)// Ajoute une équipe
        {
            string req = "INSERT INTO Equipes VALUES ('" + nomEquipe + "', '" + nomCavalier1 + "', '" + nomCavalier2 + "', '" + nomCheval1 + "', '" + nomCheval2 + "')";
            ExecuteNonQueryRequest(req);
        }
        public void SupprimerEquipe(string nomEquipe)// Supprime une équipe
        {
            string req = "DELETE FROM Equipes WHERE [Nom équipe] = '" + nomEquipe + "'";
            ExecuteNonQueryRequest(req);
        }
        public void AjouterLieu(string nomLieu, string adresse, string nomProprietaire)// Ajoute un lieu
        {
            string req = "INSERT INTO Lieux VALUES ('" + nomLieu + "', '" + adresse + "', '" + nomProprietaire + "')";
            ExecuteNonQueryRequest(req);
        }
        public void SupprimerLieu(string nomLieu)// Supprime un lieu
        {
            
            string req = "DELETE FROM Lieux WHERE [Nom lieu] = '" + nomLieu + "'";
            ExecuteNonQueryRequest(req);
        }   
        public void CreerEpreuve(string nomEpreuve, string dateEpreuve, string nomLieu, int nbrRound)// Créer une épreuve
        {
            string req = "INSERT INTO Epreuves VALUES ('" + nomEpreuve + "', '" + dateEpreuve + "' , '" + nomLieu + "', " + nbrRound +" ) ;";
            ExecuteNonQueryRequest(req);
        }
        public void AjouterInscriptionEtEquipeScore(string nomEpreuve, string dateEpreuve, string nomEquipe, string dateInscription, bool paye, int nbrRound, int nbrVache, string tDerniereV, string tV1, string tV2, string tV3, string tV4, string tV5, string tV6, string tV7, string tV8, string tV9, string tV10)
        // Ajoute une inscription et une équipe dans la table des scores
        {
            int idInscription = 0; // Déterminez comment générer l'IDInscription ici

            string req = "INSERT INTO Inscriptions ([Nom épreuve], [Date épreuve], [Nom équipe], [Date inscription], [Payé])";
            req += $" VALUES ('{nomEpreuve}', '{dateEpreuve}', '{nomEquipe}', '{dateInscription}', {paye})";

            ExecuteNonQueryRequest(req); // Execute la requete
            
            List<Inscription> listeInscription = ObtienInscriptions(nomEpreuve);
            idInscription = Inscription.GetIDInscription(listeInscription, nomEpreuve, nomEquipe);

            for (int i = 1; i <= nbrRound; i++)
             {
                string reqScore = "INSERT INTO [Scores équipes] VALUES";
                reqScore += " ('" + idInscription + "', '" + nomEquipe + "', " + i + ", " + nbrVache + ", '" + tDerniereV + "', '" + tV1 + "', '" + tV2 + "', '" + tV3 + "', '" + tV4 + "', '" + tV5 + "', '" + tV6 + "', '" + tV7 + "', '" + tV8 + "', '" + tV9 + "', '" + tV10 + "')";
                ExecuteNonQueryRequest(reqScore);
             }
               
        }
        public void SupprimerUneInscription(int idInscription)// Supprime une inscription
        {
            string req = "DELETE FROM Inscriptions WHERE [IDinscription] = " + idInscription + "";
            ExecuteNonQueryRequest(req);
        }
        public void SupprimerInscriptionDansScore(int idInscription)// Supprime une inscription dans la table des scores
        {
            string req = "DELETE FROM [Scores équipes] WHERE [IDinscription] = " + idInscription + "";
            ExecuteNonQueryRequest(req);
            //ExecuteNonQueryRequest(req);//une deuxieme fois pour supprimer le possible deuxieme round
        }
        public void SupprimerUneInscriptionEtEquipe(string nomEquipe)// Supprime une inscription et une équipe
        {
            string req = "DELETE FROM [Scores équipes] WHERE IDinscription IN (SELECT IDinscription   FROM [Inscriptions]";
            req += " WHERE [Nom équipe] = '" + nomEquipe + "')";
         
            ExecuteNonQueryRequest(req);

            req = "DELETE FROM [Inscriptions] WHERE [Nom équipe] = '" + nomEquipe + "'";

            ExecuteNonQueryRequest(req);

            req = "DELETE FROM [Equipes] WHERE [Nom équipe] = '" + nomEquipe + "'";

            ExecuteNonQueryRequest(req);
        }
        public void AjouterTempsVache(string nomEpreuve,string nomEquipe, int numRound, int numVache, string temps)// Ajoute un temps de vache
        {
            List<Inscription> listeInscription = ObtienInscriptions(nomEpreuve);
            int id = Inscription.GetIDInscription(listeInscription, nomEpreuve, nomEquipe);
            string champs = "Temps vache " + numVache;
            string req = "UPDATE [Scores équipes] SET [" + champs + "] = ' " + temps + "', [Temps dernière vache]  = '" + temps + "'"; 
            req += " WHERE [IDinscription] = " + id +" AND [N° round] = " + numRound + " ;";
            ExecuteNonQueryRequest(req);
        }
        public void ResultatsEquipe(string nomEpreuve, string nomEquipe, int numRound, string nbrVache)// Ajoute un temps de vache
        {
            List<Inscription> listeInscription = ObtienInscriptions(nomEpreuve);
            int id = Inscription.GetIDInscription(listeInscription, nomEpreuve, nomEquipe);
            string req = "UPDATE [Scores équipes] SET [Nb vaches validées] = '" + nbrVache + "' ";
            req += " WHERE [IDinscription] = " + id + " AND [N° round] = " + numRound + " ";
            ExecuteNonQueryRequest(req);
        }
    }
}
