// Form1.cs

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ClientManagementApp
{
    public partial class Form1 : Form
    {
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
            DataTable clientsTable = dbHelper.GetClients();
            dataGridViewClients.DataSource = clientsTable;
        }

        // Charge les entreprises depuis la base de données et les affiche dans le DataGridView
        private void LoadEntreprises()
        {
            DataTable entreprisesTable = dbHelper.GetEntreprises();
            dataGridViewEntreprises.DataSource = entreprisesTable;
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
                    Prenom = row["Prenom"].ToString()
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
                int newClientId = dbHelper.AddClient(clientForm.ClientNom, clientForm.ClientPrenom, clientForm.ClientDateDeNaissance, clientForm.ClientLieuDeNaissance, clientForm.ClientSexe, clientForm.AdresseMail, clientForm.NumeroTel, clientForm.NumeroSS, clientForm.NumeroSIP, null);
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
                clientForm.NumeroSS = selectedRow.Cells["NumeroSS"].Value.ToString();
                clientForm.NumeroSIP = selectedRow.Cells["NumeroSIP"].Value.ToString();

                if (clientForm.ShowDialog() == DialogResult.OK)
                {
                    dbHelper.UpdateClient(clientId, clientForm.ClientNom, clientForm.ClientPrenom, clientForm.ClientDateDeNaissance, clientForm.ClientLieuDeNaissance, clientForm.ClientSexe, clientForm.AdresseMail, clientForm.NumeroTel, clientForm.NumeroSS, clientForm.NumeroSIP, null);
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
                dbHelper.AddEntreprise(entrepriseForm.EntrepriseNom, entrepriseForm.EntrepriseFonction, entrepriseForm.EntrepriseCodeAPE, entrepriseForm.EntrepriseCodeNAFFE, entrepriseForm.EntrepriseNumeroSIREN, entrepriseForm.EntrepriseDateDeCreation, entrepriseForm.NumeroUrssaf, entrepriseForm.NumeroSIE, entrepriseForm.NumeroTel, entrepriseForm.ClientId);
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
                entrepriseForm.EntrepriseCodeAPE = selectedRow.Cells["CodeAPE"].Value.ToString();
                entrepriseForm.EntrepriseCodeNAFFE = selectedRow.Cells["CodeNAFFE"].Value.ToString();
                entrepriseForm.EntrepriseNumeroSIREN = selectedRow.Cells["NumeroSIREN"].Value.ToString();
                entrepriseForm.EntrepriseDateDeCreation = selectedRow.Cells["DateDeCreation"].Value.ToString();
                entrepriseForm.NumeroUrssaf = selectedRow.Cells["NumeroUrssaf"].Value.ToString();
                entrepriseForm.NumeroSIE = selectedRow.Cells["NumeroSIE"].Value.ToString();
                entrepriseForm.NumeroTel = selectedRow.Cells["NumeroTel"].Value.ToString();
                entrepriseForm.ClientId = Convert.ToInt32(selectedRow.Cells["ClientId"].Value);

                if (entrepriseForm.ShowDialog() == DialogResult.OK)
                {
                    dbHelper.UpdateEntreprise(entrepriseId, entrepriseForm.EntrepriseNom, entrepriseForm.EntrepriseFonction, entrepriseForm.EntrepriseCodeAPE, entrepriseForm.EntrepriseCodeNAFFE, entrepriseForm.EntrepriseNumeroSIREN, entrepriseForm.EntrepriseDateDeCreation, entrepriseForm.NumeroUrssaf, entrepriseForm.NumeroSIE, entrepriseForm.NumeroTel, entrepriseForm.ClientId);
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

        // Méthode pour libérer les ressources à la fermeture du formulaire
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            dbHelper.Dispose();
            base.OnFormClosed(e);
        }
    }
}
