using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ClientManagementApp
{
    public partial class MainForm : Form
    {
        private DataTable clientsTable;
        private DatabaseHelper dbHelper;

        public MainForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper(Constantes.NomBaseDeDonnees);
            LoadClients();
            LoadEntreprises();
        }

        private void LoadClients()
        {
            clientsTable = dbHelper.GetClients();
            dataGridViewClients.DataSource = clientsTable;

            if (dataGridViewClients.Columns.Count > 0)
            {
                dataGridViewClients.Columns[0].Visible = false;
            }
        }

        private void LoadEntreprises()
        {
            DataTable entreprisesTable = dbHelper.GetEntreprises();
            dataGridViewEntreprises.DataSource = entreprisesTable;

            if (dataGridViewEntreprises.Columns.Count > 0)
            {
                dataGridViewEntreprises.Columns[0].Visible = false;
                dataGridViewEntreprises.Columns[1].Visible = false;
            }
        }

        private List<Client> GetClientList()
        {
            var clients = new List<Client>();
            foreach (DataRow row in dbHelper.GetClients().Rows)
            {
                clients.Add(new Client
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Nom = row["Nom"].ToString(),
                    Prenom = row["Prenom"].ToString(),
                    AdresseMail = row["AdresseMail"].ToString()
                });
            }
            return clients;
        }

        private void dataGridViewClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridViewClients.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dataGridViewEntreprises_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridViewEntreprises.Rows[e.RowIndex].Selected = true;
            }
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            var clientForm = new ClientForm();
            if (clientForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dbHelper.AddClient(
                        clientForm.ClientNom, clientForm.ClientPrenom,
                        clientForm.ClientDateDeNaissance, clientForm.ClientLieuDeNaissance,
                        clientForm.ClientSexe, clientForm.AdresseMail,
                        clientForm.NumeroTel, clientForm.NumeroTelSecondaire,
                        clientForm.NumeroSS, clientForm.IdentifiantSIP,
                        clientForm.MotDePasseSIP, null);
                    LoadClients();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(Constantes.ErreurBaseDeDonnees, ex.Message));
                }
            }
        }

        private void buttonEditClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count == 0)
            {
                MessageBox.Show(Constantes.ErreurSelectionClient);
                return;
            }

            DataGridViewRow selectedRow = dataGridViewClients.SelectedRows[0];
            int clientId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            var clientForm = new ClientForm();
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
                try
                {
                    dbHelper.UpdateClient(clientId,
                        clientForm.ClientNom, clientForm.ClientPrenom,
                        clientForm.ClientDateDeNaissance, clientForm.ClientLieuDeNaissance,
                        clientForm.ClientSexe, clientForm.AdresseMail,
                        clientForm.NumeroTel, clientForm.NumeroTelSecondaire,
                        clientForm.NumeroSS, clientForm.IdentifiantSIP,
                        clientForm.MotDePasseSIP, null);
                    LoadClients();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(Constantes.ErreurBaseDeDonnees, ex.Message));
                }
            }
        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count == 0)
            {
                MessageBox.Show(Constantes.ErreurSelectionClient);
                return;
            }

            var result = MessageBox.Show(
                Constantes.ConfirmationSuppressionClient,
                Constantes.TitreConfirmation,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridViewClients.SelectedRows[0];
                    int clientId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    dbHelper.DeleteClient(clientId);
                    LoadClients();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(Constantes.ErreurBaseDeDonnees, ex.Message));
                }
            }
        }

        private void buttonAddEntreprise_Click(object sender, EventArgs e)
        {
            List<Client> clients = GetClientList();
            var entrepriseForm = new EntrepriseForm(clients);
            if (entrepriseForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dbHelper.AddEntreprise(
                        entrepriseForm.EntrepriseNom, entrepriseForm.EntrepriseCodeAPEandNAF,
                        entrepriseForm.EntrepriseNumeroSIRE, entrepriseForm.EntrepriseDateDeCreation,
                        entrepriseForm.NumeroSIE, entrepriseForm.NumeroTel,
                        entrepriseForm.IdentifiantUrssaf, entrepriseForm.MotDePasseUrssaf,
                        entrepriseForm.ClientId);
                    LoadEntreprises();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(Constantes.ErreurBaseDeDonnees, ex.Message));
                }
            }
        }

        private void buttonEditEntreprise_Click(object sender, EventArgs e)
        {
            if (dataGridViewEntreprises.SelectedRows.Count == 0)
            {
                MessageBox.Show(Constantes.ErreurSelectionEntreprise);
                return;
            }

            DataGridViewRow selectedRow = dataGridViewEntreprises.SelectedRows[0];
            int entrepriseId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            List<Client> clients = GetClientList();
            var entrepriseForm = new EntrepriseForm(clients);
            entrepriseForm.EntrepriseNom = selectedRow.Cells["NomEntreprise"].Value.ToString();
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
                try
                {
                    dbHelper.UpdateEntreprise(entrepriseId,
                        entrepriseForm.EntrepriseNom, entrepriseForm.EntrepriseCodeAPEandNAF,
                        entrepriseForm.EntrepriseNumeroSIRE, entrepriseForm.EntrepriseDateDeCreation,
                        entrepriseForm.NumeroSIE, entrepriseForm.NumeroTel,
                        entrepriseForm.IdentifiantUrssaf, entrepriseForm.MotDePasseUrssaf,
                        entrepriseForm.ClientId);
                    LoadEntreprises();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(Constantes.ErreurBaseDeDonnees, ex.Message));
                }
            }
        }

        private void buttonDeleteEntreprise_Click(object sender, EventArgs e)
        {
            if (dataGridViewEntreprises.SelectedRows.Count == 0)
            {
                MessageBox.Show(Constantes.ErreurSelectionEntreprise);
                return;
            }

            var result = MessageBox.Show(
                Constantes.ConfirmationSuppressionEntreprise,
                Constantes.TitreConfirmation,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridViewEntreprises.SelectedRows[0];
                    int entrepriseId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    dbHelper.DeleteEntreprise(entrepriseId);
                    LoadEntreprises();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(Constantes.ErreurBaseDeDonnees, ex.Message));
                }
            }
        }

        private void buttonSearchClientByName_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearchClientByName.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                DataTable table = dbHelper.GetClients();
                DataView dv = table.DefaultView;
                dv.RowFilter = $"Nom LIKE '%{searchTerm}%'";
                dataGridViewClients.DataSource = dv.ToTable();
            }
            else
            {
                LoadClients();
            }
        }

        private void textBoxSearchClientByName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearchClientByName.Text.Trim()))
            {
                LoadClients();
            }
        }

        private void buttonSearchEntrepriseByClientName_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearchEntrepriseByClientName.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                DataTable table = dbHelper.GetEntreprises();
                DataView dv = table.DefaultView;
                dv.RowFilter = $"NomClient LIKE '%{searchTerm}%'";
                dataGridViewEntreprises.DataSource = dv.ToTable();
            }
            else
            {
                LoadEntreprises();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            dbHelper.Dispose();
            base.OnFormClosed(e);
        }
    }
}
