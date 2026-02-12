using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClientManagementApp
{
    public partial class EntrepriseForm : Form
    {
        public EntrepriseForm(List<Client> clients)
        {
            InitializeComponent();
            comboBoxClients.DisplayMember = "NomComplet";
            comboBoxClients.ValueMember = "Id";
            comboBoxClients.DataSource = clients;

            comboBoxAdresseMail.DisplayMember = "Email";
            comboBoxAdresseMail.ValueMember = "Id";
            comboBoxAdresseMail.DataSource = clients;

            linkLabelUrssafME.Links.Add(0, linkLabelUrssafME.Text.Length, Constantes.UrlUrssafME);
            linkLabelUrssafME.LinkClicked += OuvrirLien;

            linkLabelUrssaf.Links.Add(0, linkLabelUrssaf.Text.Length, Constantes.UrlUrssaf);
            linkLabelUrssaf.LinkClicked += OuvrirLien;
        }

        private void EntrepriseForm_Load(object sender, EventArgs e)
        {
            Image iconBig = Properties.Resources.copy_icon_png;
            Image iconCopy = RedimensionnerImage(iconBig, 29, 29);

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

        #region Propriétés

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
            get { return dateTimePickerDateDeCreation.Value.ToString(Constantes.FormatDate); }
            set
            {
                if (DateTime.TryParse(value, out DateTime date))
                    dateTimePickerDateDeCreation.Value = date;
            }
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

        #endregion

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EntrepriseNom) || string.IsNullOrEmpty(EntrepriseCodeAPEandNAF) ||
                string.IsNullOrEmpty(EntrepriseAdresseMail) || string.IsNullOrEmpty(EntrepriseNumeroSIRE) ||
                comboBoxClients.SelectedIndex == -1 || string.IsNullOrEmpty(NumeroSIE) ||
                string.IsNullOrEmpty(NumeroTel) || string.IsNullOrEmpty(IdentifiantUrssaf) ||
                string.IsNullOrEmpty(MotDePasseUrssaf))
            {
                MessageBox.Show(Constantes.ErreurChampsRequisEntreprise);
                return;
            }

            if (!EstTelephoneValide(NumeroTel))
            {
                MessageBox.Show(Constantes.ErreurFormatTelephone);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        #region Copier dans le presse-papier

        private void CopierDansPressePapier(string valeur, string nomChamp)
        {
            if (!string.IsNullOrEmpty(valeur))
            {
                Clipboard.SetText(valeur);
            }
            else
            {
                MessageBox.Show(string.Format(Constantes.ErreurChampVide, nomChamp));
            }
        }

        private void buttonCopySIE_Click(object sender, EventArgs e)
        {
            CopierDansPressePapier(NumeroSIE, "numéro SIE");
        }

        private void buttonCopyTelephone_Click(object sender, EventArgs e)
        {
            CopierDansPressePapier(NumeroTel, "numéro de téléphone");
        }

        private void buttonCopySiret_Click(object sender, EventArgs e)
        {
            CopierDansPressePapier(EntrepriseNumeroSIRE, "numéro SIRET");
        }

        private void buttonCopyIdentUrssaf_Click(object sender, EventArgs e)
        {
            CopierDansPressePapier(IdentifiantUrssaf, "identifiant Urssaf");
        }

        private void buttonCopyMdpUrssaf_Click(object sender, EventArgs e)
        {
            CopierDansPressePapier(MotDePasseUrssaf, "mot de passe Urssaf");
        }

        #endregion

        #region Utilitaires

        private static void OuvrirLien(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = e.Link.LinkData as string;
            if (!string.IsNullOrEmpty(target))
            {
                Process.Start(new ProcessStartInfo(target));
            }
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

        private static bool EstTelephoneValide(string telephone)
        {
            return Regex.IsMatch(telephone, @"^\+?[0-9\s]+$");
        }

        #endregion

        private void linkLblSIE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Handler requis par le Designer - pas d'action
        }
    }
}
