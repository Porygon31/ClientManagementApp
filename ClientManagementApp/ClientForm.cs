using System;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClientManagementApp
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
            listBoxSexe.Items.Add("M");
            listBoxSexe.Items.Add("Mme");
            listBoxSexe.SelectedIndex = 0;

            linkLabelImpot.Links.Add(0, linkLabelImpot.Text.Length, Constantes.UrlImpots);
            linkLabelImpot.LinkClicked += OuvrirLien;
        }

        #region Propriétés

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
            get { return dateTimePickerDateDeNaissance.Value.ToString(Constantes.FormatDate); }
            set
            {
                if (DateTime.TryParse(value, out DateTime date))
                    dateTimePickerDateDeNaissance.Value = date;
            }
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

        #endregion

        private void ClientForm_Load(object sender, EventArgs e)
        {
            Image iconCopy = RedimensionnerImage(Properties.Resources.copy_icon_png, 24, 24);

            buttonCopyNom.Image = iconCopy;
            buttonCopyPrenom.Image = iconCopy;
            buttonCopyLieuDeNaissance.Image = iconCopy;
            buttonCopyAdresseMail.Image = iconCopy;
            buttonCopyNumeroTel.Image = iconCopy;
            buttonCopyNumeroTelSecondaire.Image = iconCopy;
            buttonCopyNumeroSS.Image = iconCopy;
            buttonCopyIdentifiantSIP.Image = iconCopy;
            buttonCopyMotDePasseSIP.Image = iconCopy;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ClientNom) || string.IsNullOrEmpty(ClientPrenom) ||
                listBoxSexe.SelectedIndex == -1 || string.IsNullOrEmpty(AdresseMail))
            {
                MessageBox.Show(Constantes.ErreurChampsRequisClient);
                return;
            }

            if (!EstEmailValide(AdresseMail))
            {
                MessageBox.Show(Constantes.ErreurFormatEmail);
                return;
            }

            if (!string.IsNullOrEmpty(NumeroTel) && !EstTelephoneValide(NumeroTel))
            {
                MessageBox.Show(Constantes.ErreurFormatTelephone);
                return;
            }

            if (!string.IsNullOrEmpty(NumeroTelSecondaire) && !EstTelephoneValide(NumeroTelSecondaire))
            {
                MessageBox.Show(Constantes.ErreurFormatTelephone);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private static void OuvrirLien(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = e.Link.LinkData as string;
            if (!string.IsNullOrEmpty(target))
            {
                Process.Start(new ProcessStartInfo(target));
            }
        }

        private static bool EstEmailValide(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }

        private static bool EstTelephoneValide(string telephone)
        {
            return Regex.IsMatch(telephone, @"^\+?[0-9\s]+$");
        }

        private void CopierDansPressePapier(string valeur, string nomChamp)
        {
            if (!string.IsNullOrEmpty(valeur))
                Clipboard.SetText(valeur);
            else
                MessageBox.Show(string.Format(Constantes.ErreurChampVide, nomChamp));
        }

        private static Image RedimensionnerImage(Image image, int width, int height)
        {
            var resizedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

        private void buttonCopyNom_Click(object sender, EventArgs e)
        {
            CopierDansPressePapier(ClientNom, "Nom");
        }

        private void buttonCopyPrenom_Click(object sender, EventArgs e)
        {
            CopierDansPressePapier(ClientPrenom, "Prénom");
        }

        private void buttonCopyLieuDeNaissance_Click(object sender, EventArgs e)
        {
            CopierDansPressePapier(ClientLieuDeNaissance, "Lieu de Naissance");
        }

        private void buttonCopyAdresseMail_Click(object sender, EventArgs e)
        {
            CopierDansPressePapier(AdresseMail, "Adresse Mail");
        }

        private void buttonCopyNumeroTel_Click(object sender, EventArgs e)
        {
            CopierDansPressePapier(NumeroTel, "Numéro de Téléphone");
        }

        private void buttonCopyNumeroTelSecondaire_Click(object sender, EventArgs e)
        {
            CopierDansPressePapier(NumeroTelSecondaire, "Téléphone Secondaire");
        }

        private void buttonCopyNumeroSS_Click(object sender, EventArgs e)
        {
            CopierDansPressePapier(NumeroSS, "Numéro SS");
        }

        private void buttonCopyIdentifiantSIP_Click(object sender, EventArgs e)
        {
            CopierDansPressePapier(IdentifiantSIP, "Identifiant SIP");
        }

        private void buttonCopyMotDePasseSIP_Click(object sender, EventArgs e)
        {
            CopierDansPressePapier(MotDePasseSIP, "Mot de Passe SIP");
        }
    }
}
