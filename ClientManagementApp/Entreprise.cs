namespace ClientManagementApp
{
    public class Entreprise
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string NomEntreprise { get; set; }
        public string CodeAPEandNAF { get; set; }
        public string NumeroSIRE { get; set; }
        public string DateDeCreation { get; set; }
        public string NumeroSIE { get; set; }
        public string NumeroTel { get; set; }
        public string IdentifiantUrssaf { get; set; }
        public string MotDePasseUrssaf { get; set; }
    }
}
