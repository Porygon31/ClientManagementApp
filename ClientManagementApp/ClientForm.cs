// ClientForm.cs

using System;
using System.Windows.Forms;

namespace ClientManagementApp
{
    // Formulaire pour ajouter ou modifier les informations d'un client
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
            listBoxSexe.Items.Add("M");
            listBoxSexe.Items.Add("Mme");
        }

        // Propriétés pour accéder aux informations du client depuis le formulaire principal
        public string ClientNom
        {
            get { return textBoxNom.Text; }
            set { textBoxNom.Text = value; }
        }

        public string ClientPrenom
        {
            get { return textBoxPrenom.Text; }
            set { textBoxPrenom.Text = value; }
        }

        public string ClientDateDeNaissance
        {
            get { return dateTimePickerDateDeNaissance.Value.ToString("yyyy-MM-dd"); }
            set { dateTimePickerDateDeNaissance.Value = DateTime.Parse(value); }
        }

        public string ClientLieuDeNaissance
        {
            get { return textBoxLieuDeNaissance.Text; }
            set { textBoxLieuDeNaissance.Text = value; }
        }

        public string ClientSexe
        {
            get { return listBoxSexe.SelectedItem.ToString(); }
            set { listBoxSexe.SelectedItem = value; }
        }

        public string AdresseMail
        {
            get { return textBoxAdresseMail.Text; }
            set { textBoxAdresseMail.Text = value; }
        }

        public string NumeroTel
        {
            get { return textBoxNumeroTel.Text; }
            set { textBoxNumeroTel.Text = value; }
        }

        public string NumeroSS
        {
            get { return textBoxNumeroSS.Text; }
            set { textBoxNumeroSS.Text = value; }
        }

        public string NumeroSIP
        {
            get { return textBoxNumeroSIP.Text; }
            set { textBoxNumeroSIP.Text = value; }
        }

        // Gestionnaire d'événements pour le bouton "Enregistrer"
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Valider les entrées (par exemple, vérifier que les champs requis sont remplis)
            if (string.IsNullOrEmpty(ClientNom) || string.IsNullOrEmpty(ClientPrenom) ||
                string.IsNullOrEmpty(ClientDateDeNaissance) || string.IsNullOrEmpty(ClientLieuDeNaissance) ||
                listBoxSexe.SelectedIndex == -1 || string.IsNullOrEmpty(AdresseMail) ||
                string.IsNullOrEmpty(NumeroTel) || string.IsNullOrEmpty(NumeroSS) || string.IsNullOrEmpty(NumeroSIP))
            {
                MessageBox.Show("Veuillez remplir tous les champs requis.");
                return;
            }

            // Si tout est OK, ferme le formulaire avec un DialogResult.OK
            DialogResult = DialogResult.OK;
        }
    }
}
