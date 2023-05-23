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
            string req = "SELECT * FROM Equipes"; // Requete SQL pour obtenir les equipes
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

        
        public List<Lieu> ObtienLieu()
        {
            List<Lieu> listeDesLieux = new List<Lieu>(); // Liste des lieux qui sera retournée par la méthode 
            string req = "SELECT * FROM Lieux"; // Requete SQL pour obtenir les lieux
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

    }
}
