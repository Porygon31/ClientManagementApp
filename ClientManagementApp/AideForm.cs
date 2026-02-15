using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClientManagementApp
{
    public partial class AideForm : Form
    {
        public AideForm()
        {
            InitializeComponent();
            ChargerContenuAide();
        }

        private void ChargerContenuAide()
        {
            richTextBoxAide.Clear();

            AjouterTitre("Gestionnaire de clientèle - Guide d'utilisation");

            AjouterSousTitre("Présentation");
            AjouterParagraphe(
                "Le Gestionnaire de clientèle est une application de bureau permettant de gérer vos clients " +
                "et leurs entreprises. Vous pouvez ajouter, consulter, modifier et supprimer des fiches clients " +
                "et entreprises, rechercher rapidement dans vos données, et accéder en un clic aux sites " +
                "administratifs (Impôts, Urssaf).\n\n" +
                "Les données sont stockées localement dans un fichier clients.db, créé automatiquement au " +
                "premier lancement. Aucune installation ou configuration de base de données n'est nécessaire.");

            AjouterSousTitre("Écran principal");
            AjouterParagraphe("L'écran principal est divisé en deux sections :");

            AjouterSousTitre3("Section « Clients » (haut de l'écran)");
            AjouterParagraphe(
                "  • Un tableau affiche la liste de tous vos clients (nom, prénom, email, téléphone, etc.).\n" +
                "  • À droite du tableau :\n" +
                "      - Un champ de recherche pour filtrer les clients par nom de famille + bouton Rechercher.\n" +
                "        Si vous videz le champ, la liste complète se réaffiche automatiquement.\n" +
                "      - Les boutons Ajouter Client, Modifier Client et Supprimer Client.");

            AjouterSousTitre3("Section « Entreprises » (bas de l'écran)");
            AjouterParagraphe(
                "  • Un tableau affiche la liste de toutes les entreprises enregistrées.\n" +
                "  • À droite du tableau :\n" +
                "      - Un champ de recherche pour filtrer les entreprises par nom du client associé.\n" +
                "      - Les boutons Ajouter une Entreprise, Editer une Entreprise et Supprimer une Entreprise.");

            AjouterSousTitre("Comment ajouter un client");
            AjouterParagraphe(
                "1. Cliquez sur le bouton Ajouter Client.\n" +
                "2. Un formulaire s'ouvre avec les champs suivants :\n\n" +
                "   Champs obligatoires : Nom, Prénom, Sexe (M / Mme), Adresse mail\n" +
                "   Champs facultatifs : Date de naissance, Lieu de naissance, Numéro de téléphone,\n" +
                "   Numéro de téléphone secondaire, Numéro de Sécurité Sociale, Identifiant SIP,\n" +
                "   Mot de passe SIP\n\n" +
                "3. Remplissez au minimum les champs obligatoires.\n" +
                "4. Cliquez sur le bouton rouge Sauvegarder pour enregistrer le client.");

            AjouterNote(
                "L'adresse mail doit contenir un @ et un point.\n" +
                "Les numéros de téléphone ne doivent contenir que des chiffres et des espaces " +
                "(éventuellement un + au début).\n" +
                "Un lien Impôt est disponible dans ce formulaire et ouvre impots.gouv.fr.");

            AjouterSousTitre("Comment créer une entreprise");
            AjouterImportant(
                "Une entreprise appartient obligatoirement à un client déjà existant dans la base de données. " +
                "Vous devez donc d'abord créer le client avant de pouvoir lui associer une entreprise.");

            AjouterParagraphe(
                "1. Assurez-vous que le client concerné existe déjà (sinon, ajoutez-le d'abord).\n" +
                "2. Cliquez sur le bouton Ajouter une Entreprise.\n" +
                "3. Un formulaire s'ouvre avec les champs suivants :\n\n" +
                "   Champs obligatoires : Nom de l'entreprise, Code APE / NAF, Adresse mail,\n" +
                "   Numéro SIRET, Date de création, Numéro SIE, Numéro de téléphone,\n" +
                "   Client associé (liste déroulante), Identifiant Urssaf, Mot de passe Urssaf\n" +
                "   Champs facultatifs : Identifiant SIE, Mot de passe SIE\n\n" +
                "4. Dans le champ Client associé, sélectionnez le client rattaché via la liste déroulante.\n" +
                "5. Remplissez tous les champs obligatoires.\n" +
                "6. Cliquez sur le bouton rouge Sauvegarder.");

            AjouterNote(
                "Le champ Adresse mail propose les emails des clients existants.\n" +
                "Des liens URSSAF et URSSAF ME sont disponibles et ouvrent les portails Urssaf.");

            AjouterSousTitre("Consulter ou modifier les données");
            AjouterParagraphe(
                "Pour accéder aux informations complètes d'un client ou d'une entreprise :\n\n" +
                "1. Sélectionnez la ligne correspondante dans le tableau en cliquant dessus.\n" +
                "2. Cliquez sur Modifier Client (ou Editer une Entreprise).\n" +
                "3. Le formulaire s'ouvre avec toutes les données pré-remplies.\n" +
                "4. Modifiez si nécessaire puis cliquez sur Sauvegarder, ou fermez simplement la fenêtre.");

            AjouterSousTitre("Supprimer un client ou une entreprise");
            AjouterParagraphe(
                "1. Sélectionnez la ligne correspondante dans le tableau.\n" +
                "2. Cliquez sur Supprimer Client (ou Supprimer une Entreprise).\n" +
                "3. Une fenêtre de confirmation apparaît. Cliquez sur Oui pour confirmer.");

            AjouterSousTitre("Boutons de copie rapide (fiche entreprise)");
            AjouterParagraphe(
                "Dans le formulaire entreprise, plusieurs champs disposent d'un bouton de copie (icône) " +
                "permettant de copier la valeur dans le presse-papiers en un clic :\n\n" +
                "  • Numéro SIE\n" +
                "  • Numéro de téléphone\n" +
                "  • Numéro SIRET\n" +
                "  • Identifiant Urssaf\n" +
                "  • Mot de passe Urssaf\n" +
                "  • Identifiant SIE\n" +
                "  • Mot de passe SIE\n\n" +
                "Si le champ est vide, un message vous prévient qu'il n'y a rien à copier.");

            AjouterSousTitre("Liens externes");
            AjouterParagraphe(
                "L'application donne un accès rapide aux sites administratifs suivants :\n\n" +
                "  • Impôt (impots.gouv.fr) — accessible depuis la fiche Client\n" +
                "  • URSSAF (urssaf.fr) — accessible depuis la fiche Entreprise\n" +
                "  • URSSAF ME (autoentrepreneur.urssaf.fr) — accessible depuis la fiche Entreprise\n\n" +
                "Cliquez sur le lien correspondant dans le formulaire pour ouvrir le site dans votre navigateur.");

            richTextBoxAide.SelectionStart = 0;
            richTextBoxAide.ScrollToCaret();
        }

        private void AjouterTitre(string texte)
        {
            richTextBoxAide.SelectionFont = new Font("Segoe UI", 16F, FontStyle.Bold);
            richTextBoxAide.SelectionColor = Color.FromArgb(50, 50, 50);
            richTextBoxAide.AppendText(texte + "\n\n");
        }

        private void AjouterSousTitre(string texte)
        {
            richTextBoxAide.SelectionFont = new Font("Segoe UI", 12F, FontStyle.Bold);
            richTextBoxAide.SelectionColor = Color.FromArgb(0, 102, 153);
            richTextBoxAide.AppendText("\n" + texte + "\n\n");
        }

        private void AjouterSousTitre3(string texte)
        {
            richTextBoxAide.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            richTextBoxAide.SelectionColor = Color.FromArgb(80, 80, 80);
            richTextBoxAide.AppendText(texte + "\n");
        }

        private void AjouterParagraphe(string texte)
        {
            richTextBoxAide.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            richTextBoxAide.SelectionColor = Color.Black;
            richTextBoxAide.AppendText(texte + "\n");
        }

        private void AjouterNote(string texte)
        {
            richTextBoxAide.SelectionFont = new Font("Segoe UI", 9F, FontStyle.Italic);
            richTextBoxAide.SelectionColor = Color.FromArgb(100, 100, 100);
            richTextBoxAide.AppendText("Note : " + texte + "\n");
        }

        private void AjouterImportant(string texte)
        {
            richTextBoxAide.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            richTextBoxAide.SelectionColor = Color.FromArgb(180, 0, 0);
            richTextBoxAide.AppendText("Important : " + texte + "\n\n");
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
