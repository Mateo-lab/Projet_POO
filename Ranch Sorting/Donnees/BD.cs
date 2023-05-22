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

namespace Ranch_Sorting_App.Donnees
{


    public class BD
    {
        private OleDbConnection _oleConnection;


        public BD()
        {
            string repCourant = Directory.GetCurrentDirectory();  // répertoire de l'exécutable

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;";
            connectionString += @"Data Source =" + repCourant + @"/../../../BD/BaseDeDonnéesProjet.accdb";

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
    }
}
