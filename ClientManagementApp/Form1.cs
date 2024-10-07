using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ClientManagementApp
{
    public partial class Form1 : Form
    {
        private DataTable clientsTable;
        private DatabaseHelper dbHelper;

        public Form1()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper("clients.db");
            LoadClients();
            LoadEntreprises();

            // Attacher l'événement CellClick aux deux DataGridView
            dataGridViewClients.CellClick += dataGridViewClients_CellClick;
            dataGridViewEntreprises.CellClick += dataGridViewEntreprises_CellClick;
        }

        // Charge les clients depuis la base de données et les affiche dans le DataGridView
        private void LoadClients()
        {
            clientsTable = dbHelper.GetClients();
            dataGridViewClients.DataSource = clientsTable;

            if (dataGridViewClients.Columns.Count > 0)
            {
                dataGridViewClients.Columns[0].Visible = false;
            }
        }

        // Charge les entreprises depuis la base de données et les affiche dans le DataGridView
        private void LoadEntreprises()
        {
            DataTable entreprisesTable = dbHelper.GetEntreprises();
            dataGridViewEntreprises.DataSource = entreprisesTable;

            if (dataGridViewEntreprises.Columns.Count > 0)
            {
                dataGridViewEntreprises.Columns[0].Visible = false;
                dataGridViewEntreprises.Columns[1].Visible = false;
                //dataGridViewEntreprises.Rows[1].Visible = false;
            }
        }

        // Récupère la liste des clients depuis la base de données
        private List<Client> GetClientList()
        {
            List<Client> clients = new List<Client>();
            foreach (DataRow row in dbHelper.GetClients().Rows)
            {
                clients.Add(new Client
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Nom = row["Nom"].ToString(),
                    Prenom = row["Prenom"].ToString(),
                    AdresseMail = row["AdresseMail"].ToString() // Ajouter la récupération de l'email depuis la base de données
                });
            }
            return clients;
        }

        // Gestionnaire de l'événement CellClick pour sélectionner la ligne entière dans dataGridViewClients
        private void dataGridViewClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // S'assurer que l'index de la ligne est valide
            {
                dataGridViewClients.Rows[e.RowIndex].Selected = true;
            }
        }

        // Gestionnaire de l'événement CellClick pour sélectionner la ligne entière dans dataGridViewEntreprises
        private void dataGridViewEntreprises_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // S'assurer que l'index de la ligne est valide
            {
                dataGridViewEntreprises.Rows[e.RowIndex].Selected = true;
            }
        }

        // Gestionnaire d'événements pour le bouton "Ajouter Client"
        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            if (clientForm.ShowDialog() == DialogResult.OK)
            {
                int newClientId = dbHelper.AddClient(clientForm.ClientNom, clientForm.ClientPrenom, clientForm.ClientDateDeNaissance, clientForm.ClientLieuDeNaissance, clientForm.ClientSexe, clientForm.AdresseMail, clientForm.NumeroTel, clientForm.NumeroTelSecondaire, clientForm.NumeroSS, clientForm.IdentifiantSIP, clientForm.MotDePasseSIP, null);
                LoadClients();
            }
        }

        // Gestionnaire d'événements pour le bouton "Modifier Client"
        private void buttonEditClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewClients.SelectedRows[0];
                int clientId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                ClientForm clientForm = new ClientForm();
                clientForm.ClientNom = selectedRow.Cells["Nom"].Value.ToString();
                clientForm.ClientPrenom = selectedRow.Cells["Prenom"].Value.ToString();
                clientForm.ClientDateDeNaissance = selectedRow.Cells["DateDeNaissance"].Value.ToString();
                clientForm.ClientLieuDeNaissance = selectedRow.Cells["LieuDeNaissance"].Value.ToString();
                clientForm.ClientSexe = selectedRow.Cells["Sexe"].Value.ToString();
                clientForm.AdresseMail = selectedRow.Cells["AdresseMail"].Value.ToString();
                clientForm.NumeroTel = selectedRow.Cells["NumeroTel"].Value.ToString();
                clientForm.NumeroTelSecondaire = selectedRow.Cells["NumeroTelSecondaire"].Value.ToString();
                clientForm.NumeroSS = selectedRow.Cells["NumeroSS"].Value.ToString();
                clientForm.IdentifiantSIP = selectedRow.Cells["IdentifiantSIP"].Value.ToString();
                clientForm.MotDePasseSIP = selectedRow.Cells["MotDePasseSIP"].Value.ToString();

                if (clientForm.ShowDialog() == DialogResult.OK)
                {
                    dbHelper.UpdateClient(clientId, clientForm.ClientNom, clientForm.ClientPrenom, clientForm.ClientDateDeNaissance, clientForm.ClientLieuDeNaissance, clientForm.ClientSexe, clientForm.AdresseMail, clientForm.NumeroTel, clientForm.NumeroTelSecondaire, clientForm.NumeroSS, clientForm.IdentifiantSIP, clientForm.MotDePasseSIP, null);
                    LoadClients();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un client à modifier.");
            }
        }

        // Gestionnaire d'événements pour le bouton "Supprimer Client"
        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewClients.SelectedRows[0];
                int clientId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                dbHelper.DeleteClient(clientId);
                LoadClients();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un client à supprimer.");
            }
        }

        // Gestionnaire d'événements pour le bouton "Ajouter Entreprise"
        private void buttonAddEntreprise_Click(object sender, EventArgs e)
        {
            List<Client> clients = GetClientList();
            EntrepriseForm entrepriseForm = new EntrepriseForm(clients);
            if (entrepriseForm.ShowDialog() == DialogResult.OK)
            {
                dbHelper.AddEntreprise(entrepriseForm.EntrepriseNom, entrepriseForm.EntrepriseFonction, entrepriseForm.EntrepriseCodeAPEandNAF, entrepriseForm.EntrepriseNumeroSIRE, entrepriseForm.EntrepriseDateDeCreation, entrepriseForm.NumeroSIE, entrepriseForm.NumeroTel, entrepriseForm.IdentifiantUrssaf, entrepriseForm.MotDePasseUrssaf, entrepriseForm.ClientId);
                LoadEntreprises();
            }
        }

        // Gestionnaire d'événements pour le bouton "Modifier Entreprise"
        private void buttonEditEntreprise_Click(object sender, EventArgs e)
        {
            if (dataGridViewEntreprises.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewEntreprises.SelectedRows[0];
                int entrepriseId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                List<Client> clients = GetClientList();
                EntrepriseForm entrepriseForm = new EntrepriseForm(clients);
                entrepriseForm.EntrepriseNom = selectedRow.Cells["NomEntreprise"].Value.ToString();
                entrepriseForm.EntrepriseFonction = selectedRow.Cells["Fonction"].Value.ToString();
                entrepriseForm.EntrepriseCodeAPEandNAF = selectedRow.Cells["CodeAPEandNAF"].Value.ToString();
                entrepriseForm.EntrepriseNumeroSIRE = selectedRow.Cells["NumeroSIRE"].Value.ToString();
                entrepriseForm.EntrepriseDateDeCreation = selectedRow.Cells["DateDeCreation"].Value.ToString();
                entrepriseForm.NumeroSIE = selectedRow.Cells["NumeroSIE"].Value.ToString();
                entrepriseForm.NumeroTel = selectedRow.Cells["NumeroTel"].Value.ToString();
                entrepriseForm.IdentifiantUrssaf = selectedRow.Cells["IdentifiantUrssaf"].Value.ToString();
                entrepriseForm.MotDePasseUrssaf = selectedRow.Cells["MotDePasseUrssaf"].Value.ToString();
                entrepriseForm.ClientId = Convert.ToInt32(selectedRow.Cells["ClientId"].Value);

                if (entrepriseForm.ShowDialog() == DialogResult.OK)
                {
                    dbHelper.UpdateEntreprise(entrepriseId, entrepriseForm.EntrepriseNom, entrepriseForm.EntrepriseFonction, entrepriseForm.EntrepriseCodeAPEandNAF, entrepriseForm.EntrepriseNumeroSIRE, entrepriseForm.EntrepriseDateDeCreation, entrepriseForm.NumeroSIE, entrepriseForm.NumeroTel, entrepriseForm.IdentifiantUrssaf, entrepriseForm.MotDePasseUrssaf, entrepriseForm.ClientId);
                    LoadEntreprises();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une entreprise à modifier.");
            }
        }

        // Gestionnaire d'événements pour le bouton "Supprimer Entreprise"
        private void buttonDeleteEntreprise_Click(object sender, EventArgs e)
        {
            if (dataGridViewEntreprises.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewEntreprises.SelectedRows[0];
                int entrepriseId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                dbHelper.DeleteEntreprise(entrepriseId);
                LoadEntreprises();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une entreprise à supprimer.");
            }
        }

        // Gestionnaire d'événements pour le bouton "Rechercher"
        private void buttonSearchClientByName_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearchClientByName.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                DataTable clientsTable = dbHelper.GetClients();
                DataView dv = clientsTable.DefaultView;
                dv.RowFilter = $"Nom LIKE '%{searchTerm}%'";
                dataGridViewClients.DataSource = dv.ToTable();
            }
            else
            {
                LoadClients();
            }
        }

        // Gestionnaire d'événements pour le changement de texte dans la TextBox de recherche
        private void textBoxSearchClientByName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearchClientByName.Text.Trim()))
            {
                // Recharge la liste complète des clients si la TextBox est vide
                LoadClients();
            }
        }

        private void buttonSearchEntrepriseByClientName_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearchEntrepriseByClientName.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                DataTable entreprisesTable = dbHelper.GetEntreprises();
                DataView dv = entreprisesTable.DefaultView;
                dv.RowFilter = $"NomClient LIKE '%{searchTerm}%'";
                dataGridViewEntreprises.DataSource = dv.ToTable();
            }
            else
            {
                LoadEntreprises();
            }
        }

        // Méthode pour libérer les ressources à la fermeture du formulaire
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            dbHelper.Dispose();
            base.OnFormClosed(e);
        }
    }
}
