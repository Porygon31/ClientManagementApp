﻿namespace ClientManagementApp
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public string NomComplet => $"{Nom} {Prenom}"; // Propriété pour afficher le nom complet
    }
}