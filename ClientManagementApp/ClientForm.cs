// ClientForm.cs

using System;
using System.Diagnostics;
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
            listBoxSexe.SelectedIndex = 0;

            linkLabelImpot.Links.Add(0, linkLabelImpot.Text.Length, "https://www.impots.gouv.fr/portail/");
            linkLabelImpot.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabelImpot_LinkClicked);
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

        public string NumeroTelSecondaire
        {
            get { return textBoxNumeroTelSecondaire.Text; }
            set { textBoxNumeroTelSecondaire.Text = value; }
        }

        public string NumeroSS
        {
            get { return textBoxNumeroSS.Text; }
            set { textBoxNumeroSS.Text = value; }
        }

        public string IdentifiantSIP
        {
            get { return textBoxIdentifiantSIP.Text; }
            set { textBoxIdentifiantSIP.Text = value; }
        }

        public string MotDePasseSIP
        {
            get { return textBoxMotDePasseSIP.Text; }
            set { textBoxMotDePasseSIP.Text = value; }
        }


        // Gestionnaire d'événements pour le bouton "Enregistrer"
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Valider les entrées (par exemple, vérifier que les champs requis sont remplis)
            if (string.IsNullOrEmpty(ClientNom) || string.IsNullOrEmpty(ClientPrenom) ||
                listBoxSexe.SelectedIndex == -1 || string.IsNullOrEmpty(AdresseMail))
            {
                MessageBox.Show("Vous devez au moins saisir un Nom, un Prénom et un Genre (Sexe) ainsi qu'une adresse mail");
                return;
            }

            // Si tout est OK, ferme le formulaire avec un DialogResult.OK
            DialogResult = DialogResult.OK;
        }

        private void linkLabelImpot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = e.Link.LinkData as string;
            if (!string.IsNullOrEmpty(target))
            {
                Process.Start(new ProcessStartInfo(target));

            }
        }
    }
}
