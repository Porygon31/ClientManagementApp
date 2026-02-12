namespace ClientManagementApp
{
    public static class Constantes
    {
        // Base de données
        public const string NomBaseDeDonnees = "clients.db";
        public const string FormatDate = "yyyy-MM-dd";

        // URLs
        public const string UrlImpots = "https://www.impots.gouv.fr/portail/";
        public const string UrlUrssafME = "https://autoentrepreneur.urssaf.fr/services/";
        public const string UrlUrssaf = "https://www.urssaf.fr/accueil/se-connecter.html";

        // Messages d'erreur - Validation
        public const string ErreurChampsRequisClient = "Vous devez au moins saisir un Nom, un Prénom et un Genre (Sexe) ainsi qu'une adresse mail.";
        public const string ErreurChampsRequisEntreprise = "Veuillez remplir tous les champs requis.";
        public const string ErreurFormatEmail = "L'adresse mail saisie n'est pas valide.";
        public const string ErreurFormatTelephone = "Le numéro de téléphone doit contenir uniquement des chiffres (et éventuellement un + au début).";

        // Messages d'erreur - Sélection
        public const string ErreurSelectionClient = "Veuillez sélectionner un client.";
        public const string ErreurSelectionEntreprise = "Veuillez sélectionner une entreprise.";

        // Messages de confirmation
        public const string ConfirmationSuppressionClient = "Êtes-vous sûr de vouloir supprimer ce client ?";
        public const string ConfirmationSuppressionEntreprise = "Êtes-vous sûr de vouloir supprimer cette entreprise ?";
        public const string TitreConfirmation = "Confirmation";

        // Messages d'erreur - Copier
        public const string ErreurChampVide = "Le champ {0} est vide.";

        // Messages d'erreur - Base de données
        public const string ErreurBaseDeDonnees = "Erreur lors de l'opération en base de données : {0}";
    }
}
