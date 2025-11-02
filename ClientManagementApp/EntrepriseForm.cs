using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace ClientManagementApp
{
    public partial class EntrepriseForm : Form
    {
        private void EntrepriseForm_Load(object sender, EventArgs e)
        {
            // Charger l'image depuis les ressources intégrées
            Image _iconBig = Properties.Resources.copy_icon_png;
            Image iconCopy = ResizeImage(_iconBig, 29, 29);

            // Assigner l'image aux boutons
            buttonCopySIE.Image = iconCopy;
            buttonCopySIE.ImageAlign = ContentAlignment.MiddleCenter;

            buttonCopySiret.Image = iconCopy;
            buttonCopySiret.ImageAlign = ContentAlignment.MiddleCenter;

            buttonCopyTelephone.Image = iconCopy;
            buttonCopyTelephone.ImageAlign = ContentAlignment.MiddleCenter;

            buttonCopyIdentUrssaf.Image = iconCopy;
            buttonCopyIdentUrssaf.ImageAlign = ContentAlignment.MiddleCenter;

            buttonCopyMdpUrssaf.Image = iconCopy;
            buttonCopyMdpUrssaf.ImageAlign = ContentAlignment.MiddleCenter;
        }


        public EntrepriseForm(List<Client> clients)
        {
            InitializeComponent();
            comboBoxClients.DisplayMember = "NomComplet"; // Affiche le nom complet du client
            comboBoxClients.ValueMember = "Id"; // Utilise l'ID du client comme valeur
            comboBoxClients.DataSource = clients; // Remplit la ComboBox avec la liste des clients

            comboBoxAdresseMail.DisplayMember = "Email"; // Affiche l'adresse mail du client
            comboBoxAdresseMail.ValueMember = "Id"; // Utilise l'ID du client comme valeur
            comboBoxAdresseMail.DataSource = clients; // Remplit la ComboBox avec la liste des clients

            linkLabelUrssafME.Links.Add(0, linkLabelUrssafME.Text.Length, "https://autoentrepreneur.urssaf.fr/services/");
            linkLabelUrssafME.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabelUrssafME_LinkClicked);

            linkLabelUrssaf.Links.Add(0, linkLabelUrssaf.Text.Length, "https://www.urssaf.fr/accueil/se-connecter.html");
            linkLabelUrssaf.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabelUrssaf_LinkClicked);
        }

        // Propriétés pour accéder aux informations de l'entreprise depuis le formulaire principal
        public string EntrepriseNom
        {
            get { return textBoxNomEntreprise.Text; }
            set { textBoxNomEntreprise.Text = value; }
        }

        public string EntrepriseCodeAPEandNAF
        {
            get { return textBoxCodeAPEandNAF.Text; }
            set { textBoxCodeAPEandNAF.Text = value; }
        }

        public string EntrepriseAdresseMail
        {
            get { return comboBoxAdresseMail.Text; }
            set { comboBoxAdresseMail.Text = value; }
        }

        public string EntrepriseNumeroSIRE
        {
            get { return textBoxNumeroSIRE.Text; }
            set { textBoxNumeroSIRE.Text = value; }
        }

        public string EntrepriseDateDeCreation
        {
            get { return dateTimePickerDateDeCreation.Value.ToString("yyyy-MM-dd"); }
            set { dateTimePickerDateDeCreation.Value = DateTime.Parse(value); }
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
            if (string.IsNullOrEmpty(EntrepriseNom) || string.IsNullOrEmpty(EntrepriseCodeAPEandNAF) || string.IsNullOrEmpty(EntrepriseAdresseMail) ||
                string.IsNullOrEmpty(EntrepriseNumeroSIRE) || comboBoxClients.SelectedIndex == -1 ||
                string.IsNullOrEmpty(NumeroSIE) || string.IsNullOrEmpty(NumeroTel) || string.IsNullOrEmpty(IdentifiantUrssaf) || string.IsNullOrEmpty(MotDePasseUrssaf))
            {
                MessageBox.Show("Veuillez remplir tous les champs requis.");
                return;
            }

            // Si tout est OK, ferme le formulaire avec un DialogResult.OK
            DialogResult = DialogResult.OK;
        }



        private void linkLabelUrssafME_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = e.Link.LinkData as string;
            if (!string.IsNullOrEmpty(target))
            {
                Process.Start(new ProcessStartInfo(target));
            }

        }

        private void linkLabelUrssaf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = e.Link.LinkData as string;
            if (!string.IsNullOrEmpty(target))
            {
                Process.Start(new ProcessStartInfo(target));
            }

        }

        private Image ResizeImage(Image image, int widht, int height)
        {
            Bitmap resizedImage = new Bitmap(widht, height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.DrawImage(image, 0, 0, widht, height);
            }

            return resizedImage; ;
        }

        private void buttonCopySIE_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NumeroSIE))
            {
                Clipboard.SetText(NumeroSIE);
            }
            else
            {
                MessageBox.Show("Le numéro SIE est vide.");
            }
        }

        private void buttonCopyTelephone_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NumeroTel))
            {
                Clipboard.SetText(NumeroTel);
            }
            else
            {
                MessageBox.Show("Le numéro de téléphone est vide.");
            }
        }

        private void buttonCopySiret_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EntrepriseNumeroSIRE))
            {
                Clipboard.SetText(EntrepriseNumeroSIRE);
            }
            else
            {
                MessageBox.Show("Le numéro SIRET est vide.");
            }
        }

        private void buttonCopyIdentUrssaf_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IdentifiantUrssaf))
            {
                Clipboard.SetText(IdentifiantUrssaf);
            }
            else
            {
                MessageBox.Show("L'identifiant Urssaf est vide.");
            }
        }

        private void buttonCopyMdpUrssaf_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MotDePasseUrssaf))
            {
                Clipboard.SetText(MotDePasseUrssaf);
            }
            else
            {
                MessageBox.Show("Le mot de passe Urssaf est vide.");
            }
        }

        private void linkLblSIE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
