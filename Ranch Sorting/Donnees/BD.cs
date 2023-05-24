using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.ComponentModel;
using Ranch_Sorting.Modeles;
using Ranch_Sorting.Vue;
using System.Collections.Specialized;

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

        public List<Inscription> ObtienInscriptions(string nomEpreuve)
        {
            List<Inscription> listeDesInscriptions = new List<Inscription>(); // Liste des inscriptions qui sera retournée par la méthode 
            string req = "SELECT * FROM Inscriptions WHERE [Nom épreuve] = '"+ nomEpreuve +"' ORDER BY [Nom équipe] ASC"; // Requete SQL pour obtenir les inscriptions
            IDataReader reader = ExecuteReaderRequest(req); // Execute la requete et retourne un IDataReader

            while (reader.Read())
            {
                // Ajoute les inscriptions dans la liste des inscriptions

                DateTime dateEpreuve = reader.GetDateTime(1);
                DateTime dateInscription = reader.GetDateTime(3);
                string dateEpreuveEnString = dateEpreuve.ToString("yyyy-MM-dd");
                string dateInscriptionEnString = dateInscription.ToString("yyyy-MM-dd");

                listeDesInscriptions.Add(new Inscription(reader.GetString(0), dateEpreuveEnString, reader.GetString(2), dateInscriptionEnString, reader.GetBoolean(4))); // Ajoute les inscriptions dans la liste des inscriptions

            }
            reader.Close(); // Ferme le reader
            return listeDesInscriptions; // Retourne la liste des inscriptions
        }

        public List<Epreuve> ObtienEpreuves(string nomEpreuve)
        {
            List<Epreuve> epreuves = new List<Epreuve>(); // Liste des inscriptions qui sera retournée par la méthode 
            string req = "SELECT * FROM Epreuves WHERE [Nom épreuve] = '" + nomEpreuve + "' "; // Requete SQL pour obtenir les inscriptions
            IDataReader reader = ExecuteReaderRequest(req); // Execute la requete et retourne un IDataReader

            while (reader.Read())
            {
                // Ajoute les inscriptions dans la liste des inscriptions

                DateTime dateEpreuve = reader.GetDateTime(1);
                string dateEpreuveEnString = dateEpreuve.ToString("yyyy-MM-dd");;

                epreuves.Add(new Epreuve(reader.GetString(0), dateEpreuveEnString, reader.GetString(1))); // Ajoute les inscriptions dans la liste des inscriptions

            }
            reader.Close(); // Ferme le reader
            return epreuves;
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

        public void CreerEpreuve(string nomEpreuve, string dateEpreuve, string nomLieu)
        {
            string req = "INSERT INTO Epreuves VALUES ('" + nomEpreuve + "', '" + dateEpreuve + "', '" + nomLieu + "')";
            ExecuteNonQueryRequest(req);
        }

        public void CreationNouvelleTableScore(string nomEpreuve, string dateEpreuve)
        {
            string req = "CREATE TABLE [Scores de l'épreuve : " + nomEpreuve + " du " + dateEpreuve + "] " +
                "(NomEpreuve TEXT(255), DateEpreuve TEXT(255), NomEquipe TEXT(255), NumRound INTEGER, NbrVache INTEGER, TempsDernieresVache TEXT(255), TempsVache0 TEXT(255), TempsVache1 TEXT(255), TempsVache2 TEXT(255), TempsVache3 TEXT(255), TempsVache4 TEXT(255), TempsVache5 TEXT(255), TempsVache6 TEXT(255), TempsVache7 TEXT(255), TempsVache8 TEXT(255), TempsVache9 TEXT(255), PRIMARY KEY(NomEquipe))";
            //Primary key (NomEquipe) represente la clé primaire de la table qui ne peut pas être null ni avoir de doublons
            ExecuteNonQueryRequest(req);
        }
        public void AjouterUneInscription(string nomEpreuve, string dateEpreuve, string nomEquipe, string dateInscription, bool payé)
        {
            string req = "INSERT INTO Inscriptions VALUES ('" + nomEpreuve + "', '" + dateEpreuve + "', '" + nomEquipe + "', '" + dateInscription + "', " + payé + ")";
            ExecuteNonQueryRequest(req);
        }

        public void SupprimerUneInscription( string nomEquipe)
        {
            string req = "DELETE FROM Inscriptions WHERE [Nom équipe] = '" + nomEquipe + "'";
            ExecuteNonQueryRequest(req);
        }

        public void AjouterInscriptionDansScore(string nomEpreuve, string dateEpreuve, string nomEquipe, int numRound, int nbrVache,string tDerniereV, string tV1, string tV2, string tV3, string tV4, string tV5, string tV6, string tV7, string tV8, string tV9, string tV10)
        {
            string req = "INSERT INTO [Scores de l'épreuve : " + nomEpreuve + " du " + dateEpreuve + "] VALUES ('" + nomEpreuve + "', '" + dateEpreuve + "', '" + nomEquipe + "', " + numRound + ", " + nbrVache + ", '" + tDerniereV + "', '" + tV1 + "', '" + tV2 + "', '" + tV3 + "', '" + tV4 + "', '" + tV5 + "', '" + tV6 + "', '" + tV7 + "', '" + tV8 + "', '" + tV9 + "', '" + tV10 + "')";
            ExecuteNonQueryRequest(req);
        }

        public void SupprimerInscriptionDansScore(string nomEquipe)
        {
            string req = "DELETE FROM [Scores équipes] WHERE [Nom équipe] = '" + nomEquipe + "'";
            ExecuteNonQueryRequest(req);
        }

        public List<Scores> ObtienScores(string nomEpreuve, string dateEpreuve)
        {
            List<Scores> listeDesScores = new List<Scores>(); // Liste des scores qui sera retournée par la méthode 
            string req = "SELECT * FROM [Scores de l'épreuve : " + nomEpreuve + " du " + dateEpreuve + "]"; // Requete SQL pour obtenir les scores
            IDataReader reader = ExecuteReaderRequest(req); // Execute la requete et retourne un IDataReader

            while (reader.Read())
            {
                // Ajoute les scores dans la liste des scores 
                // champs : NomEpreuve, DateEpreuve, NomEquipe, NumRound, NbrVache, TDerniereV, TV1, TV2, TV3, TV4, TV5, TV6, TV7, TV8, TV9, TV10

                listeDesScores.Add(new Scores(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), reader.GetString(15)));// Ajoute les scores dans la liste des scores 
                Console.WriteLine(listeDesScores);
            }
            reader.Close(); // Ferme le reader
            return listeDesScores; // Retourne la liste des scores
        }

        public void AjouterTempsVache(string nomEpreuve, string dateEpreuve, string nomEquipe, int numRound, int numVache, string temps)
        {
            string champs = "Temps vache " + numVache;  
            string req = "UPDATE [Scores équipes] SET " + champs +" = ' " + temps + "'  WHERE [Nom épreuve] = '" + nomEpreuve + "' AND [Nom équipe] = '" + nomEquipe + 
                         "' AND [Date épreuve] = '" + dateEpreuve + "' AND [N° round] = '" + numRound + "'";
            ExecuteNonQueryRequest(req);
        }
    }
}
