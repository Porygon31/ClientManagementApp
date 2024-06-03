using System;
using System.IO;
using System.Data;
using System.Data.SQLite;

namespace ClientManagementApp
{
    // Classe pour gérer les opérations de la base de données
    public class DatabaseHelper : IDisposable
    {
        private SQLiteConnection connection;
        private string databaseFile;

        // Constructeur qui vérifie l'existence du fichier de base de données et l'initialise si nécessaire
        public DatabaseHelper(string databaseFile)
        {
            this.databaseFile = databaseFile;

            // Vérifie si le fichier de base de données existe
            if (!File.Exists(databaseFile))
            {
                // Crée le fichier de base de données
                SQLiteConnection.CreateFile(databaseFile);
            }

            // Ouvre la connexion à la base de données
            connection = new SQLiteConnection($"Data Source={databaseFile};Version=3;");
            connection.Open();

            // Initialise la base de données (crée les tables si elles n'existent pas)
            InitializeDatabase();
        }

        // Méthode pour initialiser la base de données en créant les tables si elles n'existent pas
        private void InitializeDatabase()
        {
            string checkClientTableQuery = "SELECT name FROM sqlite_master WHERE type='table' AND name='Client';";
            string checkEntrepriseTableQuery = "SELECT name FROM sqlite_master WHERE type='table' AND name='Entreprise';";

            bool clientTableExists = false;
            bool entrepriseTableExists = false;

            // Vérifie si la table Client existe
            using (var command = new SQLiteCommand(checkClientTableQuery, connection))
            using (var reader = command.ExecuteReader())
            {
                clientTableExists = reader.HasRows;
            }

            // Vérifie si la table Entreprise existe
            using (var command = new SQLiteCommand(checkEntrepriseTableQuery, connection))
            using (var reader = command.ExecuteReader())
            {
                entrepriseTableExists = reader.HasRows;
            }

            // Crée la table Client si elle n'existe pas
            if (!clientTableExists)
            {
                CreateClientTable();
            }

            // Crée la table Entreprise si elle n'existe pas
            if (!entrepriseTableExists)
            {
                CreateEntrepriseTable();
            }
        }

        // Méthode pour créer la table Client
        private void CreateClientTable()
        {
            string createClientTableQuery = @"
                CREATE TABLE Client (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nom TEXT NOT NULL,
                    Prenom TEXT NOT NULL,
                    DateDeNaissance TEXT NOT NULL,
                    LieuDeNaissance TEXT NOT NULL,
                    Sexe TEXT NOT NULL,
                    AdresseMail TEXT,
                    NumeroTel TEXT,
                    NumeroSS TEXT,
                    NumeroSIP TEXT,
                    EntrepriseId INTEGER
                );";

            using (var command = new SQLiteCommand(createClientTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        // Méthode pour créer la table Entreprise
        private void CreateEntrepriseTable()
        {
            string createEntrepriseTableQuery = @"
                CREATE TABLE Entreprise (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ClientId INTEGER NOT NULL,
                    NomEntreprise TEXT NOT NULL,
                    CodeAPE TEXT NOT NULL,
                    NumeroSIREN TEXT NOT NULL,
                    DateDeCreation TEXT NOT NULL,
                    NumeroUrssaf TEXT,
                    NumeroSIE TEXT,
                    NumeroTel TEXT,
                    FOREIGN KEY(ClientId) REFERENCES Client(Id)
                );";

            using (var command = new SQLiteCommand(createEntrepriseTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        // Méthode pour récupérer les clients de la base de données
        public DataTable GetClients()
        {
            string query = "SELECT * FROM Client";
            using (var adapter = new SQLiteDataAdapter(query, connection))
            {
                DataTable clientsTable = new DataTable();
                adapter.Fill(clientsTable);
                return clientsTable;
            }
        }

        // Méthode pour ajouter un client à la base de données
        public int AddClient(string nom, string prenom, string dateDeNaissance, string lieuDeNaissance, string sexe, string adresseMail, string numeroTel, string numeroSS, string numeroSIP, int? entrepriseId)
        {
            string query = "INSERT INTO Client (Nom, Prenom, DateDeNaissance, LieuDeNaissance, Sexe, AdresseMail, NumeroTel, NumeroSS, NumeroSIP, EntrepriseId) VALUES (@Nom, @Prenom, @DateDeNaissance, @LieuDeNaissance, @Sexe, @AdresseMail, @NumeroTel, @NumeroSS, @NumeroSIP, @EntrepriseId)";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nom", nom);
                command.Parameters.AddWithValue("@Prenom", prenom);
                command.Parameters.AddWithValue("@DateDeNaissance", dateDeNaissance);
                command.Parameters.AddWithValue("@LieuDeNaissance", lieuDeNaissance);
                command.Parameters.AddWithValue("@Sexe", sexe);
                command.Parameters.AddWithValue("@AdresseMail", adresseMail);
                command.Parameters.AddWithValue("@NumeroTel", numeroTel);
                command.Parameters.AddWithValue("@NumeroSS", numeroSS);
                command.Parameters.AddWithValue("@NumeroSIP", numeroSIP);
                command.Parameters.AddWithValue("@EntrepriseId", entrepriseId.HasValue ? (object)entrepriseId.Value : DBNull.Value);
                command.ExecuteNonQuery();
            }

            int newClientId = (int)connection.LastInsertRowId;
            return newClientId;
        }

        // Méthode pour mettre à jour les informations d'un client
        public void UpdateClient(int id, string nom, string prenom, string dateDeNaissance, string lieuDeNaissance, string sexe, string adresseMail, string numeroTel, string numeroSS, string numeroSIP, int? entrepriseId)
        {
            string query = "UPDATE Client SET Nom = @Nom, Prenom = @Prenom, DateDeNaissance = @DateDeNaissance, LieuDeNaissance = @LieuDeNaissance, Sexe = @Sexe, AdresseMail = @AdresseMail, NumeroTel = @NumeroTel, NumeroSS = @NumeroSS, NumeroSIP = @NumeroSIP, EntrepriseId = @EntrepriseId WHERE Id = @Id";
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
                command.Parameters.AddWithValue("@NumeroSS", numeroSS);
                command.Parameters.AddWithValue("@NumeroSIP", numeroSIP);
                command.Parameters.AddWithValue("@EntrepriseId", entrepriseId.HasValue ? (object)entrepriseId.Value : DBNull.Value);
                command.ExecuteNonQuery();
            }
        }

        // Méthode pour supprimer un client de la base de données
        public void DeleteClient(int id)
        {
            string query = "DELETE FROM Client WHERE Id = @Id";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }

        // Méthode pour récupérer les entreprises de la base de données
        public DataTable GetEntreprises()
        {
            string query = "SELECT * FROM Entreprise";
            using (var adapter = new SQLiteDataAdapter(query, connection))
            {
                DataTable entreprisesTable = new DataTable();
                adapter.Fill(entreprisesTable);
                return entreprisesTable;
            }
        }

        // Méthode pour ajouter une entreprise à la base de données
        public int AddEntreprise(string nomEntreprise, string codeAPE, string numeroSIREN, string dateDeCreation, string numeroUrssaf, string numeroSIE, string numeroTel, int clientId)
        {
            string query = "INSERT INTO Entreprise (NomEntreprise, CodeAPE, NumeroSIREN, DateDeCreation, NumeroUrssaf, NumeroSIE, NumeroTel, ClientId) VALUES (@NomEntreprise, @CodeAPE, @NumeroSIREN, @DateDeCreation, @NumeroUrssaf, @NumeroSIE, @NumeroTel, @ClientId)";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NomEntreprise", nomEntreprise);
                command.Parameters.AddWithValue("@CodeAPE", codeAPE);
                command.Parameters.AddWithValue("@NumeroSIREN", numeroSIREN);
                command.Parameters.AddWithValue("@DateDeCreation", dateDeCreation);
                command.Parameters.AddWithValue("@NumeroUrssaf", numeroUrssaf);
                command.Parameters.AddWithValue("@NumeroSIE", numeroSIE);
                command.Parameters.AddWithValue("@NumeroTel", numeroTel);
                command.Parameters.AddWithValue("@ClientId", clientId);
                command.ExecuteNonQuery();
            }

            int newEntrepriseId = (int)connection.LastInsertRowId;
            return newEntrepriseId;
        }

        // Méthode pour mettre à jour les informations d'une entreprise
        public void UpdateEntreprise(int id, string nomEntreprise, string codeAPE, string numeroSIREN, string dateDeCreation, string numeroUrssaf, string numeroSIE, string numeroTel, int clientId)
        {
            string query = "UPDATE Entreprise SET NomEntreprise = @NomEntreprise, CodeAPE = @CodeAPE, NumeroSIREN = @NumeroSIREN, DateDeCreation = @DateDeCreation, NumeroUrssaf = @NumeroUrssaf, NumeroSIE = @NumeroSIE, NumeroTel = @NumeroTel, ClientId = @ClientId WHERE Id = @Id";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@NomEntreprise", nomEntreprise);
                command.Parameters.AddWithValue("@CodeAPE", codeAPE);
                command.Parameters.AddWithValue("@NumeroSIREN", numeroSIREN);
                command.Parameters.AddWithValue("@DateDeCreation", dateDeCreation);
                command.Parameters.AddWithValue("@NumeroUrssaf", numeroUrssaf);
                command.Parameters.AddWithValue("@NumeroSIE", numeroSIE);
                command.Parameters.AddWithValue("@NumeroTel", numeroTel);
                command.Parameters.AddWithValue("@ClientId", clientId);
                command.ExecuteNonQuery();
            }
        }

        // Méthode pour supprimer une entreprise de la base de données
        public void DeleteEntreprise(int id)
        {
            string query = "DELETE FROM Entreprise WHERE Id = @Id";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }

        // Méthode pour libérer les ressources de la connexion à la base de données
        public void Dispose()
        {
            connection.Close();
        }
    }
}
