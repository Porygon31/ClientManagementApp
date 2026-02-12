using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace ClientManagementApp
{
    public class DatabaseHelper : IDisposable
    {
        private SQLiteConnection connection;
        private bool disposed = false;

        public DatabaseHelper(string databaseFile)
        {
            if (!File.Exists(databaseFile))
            {
                SQLiteConnection.CreateFile(databaseFile);
            }

            connection = new SQLiteConnection($"Data Source={databaseFile};Version=3;");
            connection.Open();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            string createClientTable = @"
                CREATE TABLE IF NOT EXISTS Client (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nom TEXT NOT NULL,
                    Prenom TEXT NOT NULL,
                    DateDeNaissance TEXT,
                    LieuDeNaissance TEXT,
                    Sexe TEXT NOT NULL,
                    AdresseMail TEXT,
                    NumeroTel TEXT,
                    NumeroTelSecondaire TEXT,
                    NumeroSS TEXT,
                    IdentifiantSIP TEXT,
                    MotDePasseSIP TEXT,
                    EntrepriseId INTEGER
                );";

            string createEntrepriseTable = @"
                CREATE TABLE IF NOT EXISTS Entreprise (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ClientId INTEGER NOT NULL,
                    NomEntreprise TEXT NOT NULL,
                    CodeAPEandNAF TEXT NOT NULL,
                    NumeroSIRE TEXT NOT NULL,
                    DateDeCreation TEXT NOT NULL,
                    NumeroSIE TEXT,
                    NumeroTel TEXT,
                    IdentifiantUrssaf TEXT,
                    MotDePasseUrssaf TEXT,
                    FOREIGN KEY(ClientId) REFERENCES Client(Id)
                );";

            using (var command = new SQLiteCommand(createClientTable, connection))
            {
                command.ExecuteNonQuery();
            }

            using (var command = new SQLiteCommand(createEntrepriseTable, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        #region Client

        public DataTable GetClients()
        {
            string query = "SELECT * FROM Client";
            using (var adapter = new SQLiteDataAdapter(query, connection))
            {
                var clientsTable = new DataTable();
                adapter.Fill(clientsTable);
                return clientsTable;
            }
        }

        public int AddClient(string nom, string prenom, string dateDeNaissance, string lieuDeNaissance,
            string sexe, string adresseMail, string numeroTel, string numeroTelSecond,
            string numeroSS, string identifiantSIP, string motDePasseSIP, int? entrepriseId)
        {
            string query = @"INSERT INTO Client
                (Nom, Prenom, DateDeNaissance, LieuDeNaissance, Sexe, AdresseMail,
                 NumeroTel, NumeroTelSecondaire, NumeroSS, IdentifiantSIP, MotDePasseSIP, EntrepriseId)
                VALUES (@Nom, @Prenom, @DateDeNaissance, @LieuDeNaissance, @Sexe, @AdresseMail,
                        @NumeroTel, @NumeroTelSecondaire, @NumeroSS, @IdentifiantSIP, @MotDePasseSIP, @EntrepriseId)";

            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nom", nom);
                command.Parameters.AddWithValue("@Prenom", prenom);
                command.Parameters.AddWithValue("@DateDeNaissance", dateDeNaissance);
                command.Parameters.AddWithValue("@LieuDeNaissance", lieuDeNaissance);
                command.Parameters.AddWithValue("@Sexe", sexe);
                command.Parameters.AddWithValue("@AdresseMail", adresseMail);
                command.Parameters.AddWithValue("@NumeroTel", numeroTel);
                command.Parameters.AddWithValue("@NumeroTelSecondaire", string.IsNullOrWhiteSpace(numeroTelSecond) ? (object)DBNull.Value : numeroTelSecond);
                command.Parameters.AddWithValue("@NumeroSS", numeroSS);
                command.Parameters.AddWithValue("@IdentifiantSIP", identifiantSIP);
                command.Parameters.AddWithValue("@MotDePasseSIP", motDePasseSIP);
                command.Parameters.AddWithValue("@EntrepriseId", entrepriseId.HasValue ? (object)entrepriseId.Value : DBNull.Value);
                command.ExecuteNonQuery();
            }

            return (int)connection.LastInsertRowId;
        }

        public void UpdateClient(int id, string nom, string prenom, string dateDeNaissance, string lieuDeNaissance,
            string sexe, string adresseMail, string numeroTel, string numeroTelSec,
            string numeroSS, string identifiantSIP, string motDePasseSIP, int? entrepriseId)
        {
            string query = @"UPDATE Client SET
                Nom = @Nom, Prenom = @Prenom, DateDeNaissance = @DateDeNaissance,
                LieuDeNaissance = @LieuDeNaissance, Sexe = @Sexe, AdresseMail = @AdresseMail,
                NumeroTel = @NumeroTel, NumeroTelSecondaire = @NumeroTelSecondaire,
                NumeroSS = @NumeroSS, IdentifiantSIP = @IdentifiantSIP,
                MotDePasseSIP = @MotDePasseSIP, EntrepriseId = @EntrepriseId
                WHERE Id = @Id";

            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Nom", nom);
                command.Parameters.AddWithValue("@Prenom", prenom);
                command.Parameters.AddWithValue("@DateDeNaissance", dateDeNaissance);
                command.Parameters.AddWithValue("@LieuDeNaissance", lieuDeNaissance);
                command.Parameters.AddWithValue("@Sexe", sexe);
                command.Parameters.AddWithValue("@AdresseMail", adresseMail);
                command.Parameters.AddWithValue("@NumeroTel", numeroTel);
                command.Parameters.AddWithValue("@NumeroTelSecondaire", string.IsNullOrWhiteSpace(numeroTelSec) ? (object)DBNull.Value : numeroTelSec);
                command.Parameters.AddWithValue("@NumeroSS", numeroSS);
                command.Parameters.AddWithValue("@IdentifiantSIP", identifiantSIP);
                command.Parameters.AddWithValue("@MotDePasseSIP", motDePasseSIP);
                command.Parameters.AddWithValue("@EntrepriseId", entrepriseId.HasValue ? (object)entrepriseId.Value : DBNull.Value);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteClient(int id)
        {
            string query = "DELETE FROM Client WHERE Id = @Id";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }

        #endregion

        #region Entreprise

        public DataTable GetEntreprises()
        {
            string query = "SELECT * FROM Entreprise";
            using (var adapter = new SQLiteDataAdapter(query, connection))
            {
                var entreprisesTable = new DataTable();
                adapter.Fill(entreprisesTable);
                return entreprisesTable;
            }
        }

        public int AddEntreprise(string nomEntreprise, string codeAPEandNAF, string numeroSIRE,
            string dateDeCreation, string numeroSIE, string numeroTel,
            string identifiantUrssaf, string motDePasseUrssaf, int clientId)
        {
            string query = @"INSERT INTO Entreprise
                (NomEntreprise, CodeAPEandNAF, NumeroSIRE, DateDeCreation,
                 NumeroSIE, NumeroTel, IdentifiantUrssaf, MotDePasseUrssaf, ClientId)
                VALUES (@NomEntreprise, @CodeAPEandNAF, @NumeroSIRE, @DateDeCreation,
                        @NumeroSIE, @NumeroTel, @IdentifiantUrssaf, @MotDePasseUrssaf, @ClientId)";

            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NomEntreprise", nomEntreprise);
                command.Parameters.AddWithValue("@CodeAPEandNAF", codeAPEandNAF);
                command.Parameters.AddWithValue("@NumeroSIRE", numeroSIRE);
                command.Parameters.AddWithValue("@DateDeCreation", dateDeCreation);
                command.Parameters.AddWithValue("@NumeroSIE", numeroSIE);
                command.Parameters.AddWithValue("@NumeroTel", numeroTel);
                command.Parameters.AddWithValue("@IdentifiantUrssaf", identifiantUrssaf);
                command.Parameters.AddWithValue("@MotDePasseUrssaf", motDePasseUrssaf);
                command.Parameters.AddWithValue("@ClientId", clientId);
                command.ExecuteNonQuery();
            }

            return (int)connection.LastInsertRowId;
        }

        public void UpdateEntreprise(int id, string nomEntreprise, string codeAPEandNAF, string numeroSIRE,
            string dateDeCreation, string numeroSIE, string numeroTel,
            string identifiantUrssaf, string motDePasseUrssaf, int clientId)
        {
            string query = @"UPDATE Entreprise SET
                NomEntreprise = @NomEntreprise, CodeAPEandNAF = @CodeAPEandNAF,
                NumeroSIRE = @NumeroSIRE, DateDeCreation = @DateDeCreation,
                NumeroSIE = @NumeroSIE, NumeroTel = @NumeroTel,
                IdentifiantUrssaf = @IdentifiantUrssaf, MotDePasseUrssaf = @MotDePasseUrssaf,
                ClientId = @ClientId
                WHERE Id = @Id";

            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@NomEntreprise", nomEntreprise);
                command.Parameters.AddWithValue("@CodeAPEandNAF", codeAPEandNAF);
                command.Parameters.AddWithValue("@NumeroSIRE", numeroSIRE);
                command.Parameters.AddWithValue("@DateDeCreation", dateDeCreation);
                command.Parameters.AddWithValue("@NumeroSIE", numeroSIE);
                command.Parameters.AddWithValue("@NumeroTel", numeroTel);
                command.Parameters.AddWithValue("@IdentifiantUrssaf", identifiantUrssaf);
                command.Parameters.AddWithValue("@MotDePasseUrssaf", motDePasseUrssaf);
                command.Parameters.AddWithValue("@ClientId", clientId);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteEntreprise(int id)
        {
            string query = "DELETE FROM Entreprise WHERE Id = @Id";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }

        #endregion

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing && connection != null)
                {
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                }
                disposed = true;
            }
        }
    }
}
