using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientManagementApp
{
    public partial class EntrepriseForm : Form
    {
        public EntrepriseForm(List<Client> clients)
        {
            InitializeComponent();
            comboBoxClients.DisplayMember = "NomComplet"; // Affiche le nom complet du client
            comboBoxClients.ValueMember = "Id"; // Utilise l'ID du client comme valeur
            comboBoxClients.DataSource = clients; // Remplit la ComboBox avec la liste des clients
        }

        // Propriétés pour accéder aux informations de l'entreprise depuis le formulaire principal
        public string EntrepriseNom
        {
            get { return textBoxNomEntreprise.Text; }
            set { textBoxNomEntreprise.Text = value; }
        }

        public string EntrepriseCodeAPE
        {
            get { return textBoxCodeAPE.Text; }
            set { textBoxCodeAPE.Text = value; }
        }

        public string EntrepriseNumeroSIREN
        {
            get { return textBoxNumeroSIREN.Text; }
            set { textBoxNumeroSIREN.Text = value; }
        }

        public string EntrepriseDateDeCreation
        {
            get { return dateTimePickerDateDeCreation.Value.ToString("yyyy-MM-dd"); }
            set { dateTimePickerDateDeCreation.Value = DateTime.Parse(value); }
        }

        public string NumeroURSSAF
        {
            get { return textBoxNumeroURSSAF.Text; }
            set { textBoxNumeroURSSAF.Text = value; }
        }

        public string IdentifiantUrssaf
        {
            get { return textBoxIdentifiantUrssaf.Text; }
            set { textBoxIdentifiantUrssaf.Text = value; }
        }

        public string MotDePasseUrssaf
        {
            get { return textBoxMotDePasseUrssaf.Text; }
            set { textBoxMotDePasseUrssaf.Text = value; }
        }

        public string NumeroSIE
        {
            get { return textBoxNumeroSIE.Text; }
            set { textBoxNumeroSIE.Text = value; }
        }

        public string NumeroTel
        {
            get { return textBoxNumeroTel.Text; }
            set { textBoxNumeroTel.Text = value; }
        }

        public int ClientId
        {
            get { return (int)comboBoxClients.SelectedValue; }
            set { comboBoxClients.SelectedValue = value; }
        }

        // Gestionnaire d'événements pour le bouton "Enregistrer"
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Valider les entrées (par exemple, vérifier que les champs requis sont remplis)
            if (string.IsNullOrEmpty(EntrepriseNom) || string.IsNullOrEmpty(EntrepriseCodeAPE) ||
                string.IsNullOrEmpty(EntrepriseNumeroSIREN) || comboBoxClients.SelectedIndex == -1 ||
                string.IsNullOrEmpty(NumeroSIE) || string.IsNullOrEmpty(NumeroTel) || string.IsNullOrEmpty(NumeroURSSAF) || string.IsNullOrEmpty(IdentifiantUrssaf) || string.IsNullOrEmpty(MotDePasseUrssaf))
            {
                MessageBox.Show("Veuillez remplir tous les champs requis.");
                return;
            }

            // Si tout est OK, ferme le formulaire avec un DialogResult.OK
            DialogResult = DialogResult.OK;
        }
    }
}
