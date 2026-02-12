using System;
using System.Diagnostics;
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
    }
}
