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
        public List<string> ObtienNomEpreuve()
        {
            string req = "SELECT [Nom épreuve] FROM Epreuves";
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

        public string ObtienDateEpreuve(string nomEpreuve)
        {
            string req = "SELECT [Date épreuve] FROM Epreuves WHERE [Nom épreuve] = '" + nomEpreuve + "'";
            IDataReader reader = ExecuteReaderRequest(req);

            string listeDesDateDesEpreuves = "";

            while (reader.Read())
            {
                string dateEpreuve = reader.GetString(0); //GetString(0) car il n'y a qu'une seule colonne indexée
                listeDesDateDesEpreuves = dateEpreuve;
            }
            reader.Close();
            return listeDesDateDesEpreuves;
        }
        public List<Scores> ObtienScores(string nomEpreuve, string dateEpreuve, int numRound)
        {
            List<Scores> listeDesScores = new List<Scores>(); // Liste des scores qui sera retournée par la méthode 
            string req = "SELECT * FROM [Scores de l'épreuve : " + nomEpreuve + " du " + dateEpreuve + "] WHERE [N°round] = '"+ numRound +"'"; // Requete SQL pour obtenir les scores
            IDataReader reader = ExecuteReaderRequest(req); // Execute la requete et retourne un IDataReader

            while (reader.Read())
            {
                // Ajoute les scores dans la liste des scores 
                // champs : NomEquipe, NumRound, NbrVache, TDerniereV, TV1, TV2, TV3, TV4, TV5, TV6, TV7, TV8, TV9, TV10

                listeDesScores.Add(new Scores(reader.GetString(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13)));// Ajoute les scores dans la liste des scores 
                Console.WriteLine(listeDesScores);
            }
            reader.Close(); // Ferme le reader
            return listeDesScores; // Retourne la liste des scores
        }

        // Méthode qui retourne la liste mélangée des noms des équipes participantes à l'epreuve : nomEpreuve,
        // à la date : dateEpreuve. Elle permet de définir l'ordre de pasage des équipes
        public ListeNomsEquipes ObtienOrdreParticipants(string nomEpreuve, string dateEpreuve, int numRound)
        {
            List<Scores> listeDesScores = new List<Scores>(); 
            string req = "SELECT * FROM [Scores de l'épreuve : " + nomEpreuve + " du " + dateEpreuve + "] WHERE [N°round] = '" + numRound + "'"; // Requete SQL pour obtenir les scores
            IDataReader reader = ExecuteReaderRequest(req); // Execute la requete et retourne un IDataReader

            while (reader.Read())
            {
                // Ajoute les scores dans la liste des scores 
                listeDesScores.Add(new Scores(reader.GetString(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13)));// Ajoute les scores dans la liste des scores 
                Console.WriteLine(listeDesScores);
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
            string req = "INSERT INTO Epreuves VALUES ('" + nomEpreuve + "', '" + dateEpreuve + "', '" + nomLieu + "', '" + nbrRound + "')";
            ExecuteNonQueryRequest(req);
        }
        public void CreationNouvelleTableScore(string nomEpreuve, string dateEpreuve)
        {
            string req = "CREATE TABLE [Scores de l'épreuve : " + nomEpreuve + " du " + dateEpreuve + "] " +
                "(NomEquipe TEXT(255), NumRound INTEGER, NbrVache INTEGER, TempsDernieresVache TEXT(255), " +
                "TempsVache0 TEXT(255), TempsVache1 TEXT(255), TempsVache2 TEXT(255), TempsVache3 TEXT(255), TempsVache4 TEXT(255), " +
                "TempsVache5 TEXT(255), TempsVache6 TEXT(255), TempsVache7 TEXT(255), TempsVache8 TEXT(255), TempsVache9 TEXT(255))";
            //Primary key (NomEquipe) represente la clé primaire de la table qui ne peut pas être null ni avoir de doublons
            ExecuteNonQueryRequest(req);

        }
        public void AjouterUneInscription(string nomEpreuve, string dateEpreuve, string nomEquipe, string dateInscription, bool payé)
        {
            string req = "INSERT INTO Inscriptions VALUES ('" + nomEpreuve + "', '" + dateEpreuve + "', '" + nomEquipe + "', '" + dateInscription + "', " + payé + ")";
            ExecuteNonQueryRequest(req);
        }
        public void SupprimerUneInscription(string nomEquipe)
        {
            string req = "DELETE FROM Inscriptions WHERE [Nom équipe] = '" + nomEquipe + "'";
            ExecuteNonQueryRequest(req);
        }
        public void AjouterUneEquipeInscriteDansScore(string nomEpreuve, string dateEpreuve, string nomEquipe, int nbrRound, int nbrVache,string tDerniereV, string tV1, string tV2, string tV3, string tV4, string tV5, string tV6, string tV7, string tV8, string tV9, string tV10)
        {
            for (int i = 1; i != nbrRound+1; i++)
            {
                string req = "INSERT INTO [Scores de l'épreuve : " + nomEpreuve + " du " + dateEpreuve + "] VALUES ('" + nomEquipe + "', " + i + ", " + nbrVache + ", '" + tDerniereV + "', '" + tV1 + "', '" + tV2 + "', '" + tV3 + "', '" + tV4 + "', '" + tV5 + "', '" + tV6 + "', '" + tV7 + "', '" + tV8 + "', '" + tV9 + "', '" + tV10 + "')";
                ExecuteNonQueryRequest(req);
            }
            
        }

        public void SupprimerInscriptionDansScore(string nomEpreuve, string dateEpreuve, string nomEquipe)
        {
            string req = "DELETE FROM [Scores de l'épreuve : " + nomEpreuve + " du " + dateEpreuve + "] WHERE [Nom équipe] = '" + nomEquipe + "'";
            ExecuteNonQueryRequest(req);
        }
        public void AjouterTempsVache(string nomEpreuve, string dateEpreuve, string nomEquipe, int numRound, int numVache, string temps)
        {
            string champs = "Temps vache " + numVache;  
            string req = "UPDATE [Scores de l'épreuve : " + nomEpreuve + " du " + dateEpreuve + "] SET [" + champs + "] = ' " + temps + "'  WHERE [Nom équipe] = '" + nomEquipe + 
                         "' AND [N° round] = '" + numRound + "'";
            ExecuteNonQueryRequest(req);
        }
        public void ResultatsEquipe(string nomEpreuve, string dateEpreuve, string nomEquipe, int numRound, int nbrVache, string tempsDerniereVache)
        {
            string req = "UPDATE [Scores de l'épreuve : " + nomEpreuve + " du " + dateEpreuve + "] SET [Temps dernière vache]  = ' " + tempsDerniereVache + "' AND [Nb vaches validées] = ' " + nbrVache + "' WHERE [Nom équipe] = '" + nomEquipe +
                         "' AND [N° round] = '" + numRound + "'";
            ExecuteNonQueryRequest(req);
        }
    }
}
