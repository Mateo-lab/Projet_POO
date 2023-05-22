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
    }
}
