# ClientManagementApp

Application Windows de gestion de clients et d'entreprises. Elle permet de centraliser les informations personnelles et professionnelles de vos clients, ainsi que les données de leurs entreprises.

## Fonctionnalités

- Ajouter, modifier et supprimer des clients
- Ajouter, modifier et supprimer des entreprises (chaque entreprise est liée à un client existant)
- Copier facilement les informations d'un champ en un clic
- Accéder directement aux sites Impôts, Urssaf et SIE depuis l'application
- Rechercher un client ou une entreprise par nom
- Aide intégrée accessible via le menu **Aide** ou la touche **F1**

## Stack technique

- **.NET Framework 4.8** — Windows Forms
- **SQLite** — base de données locale (via System.Data.SQLite)

## Prérequis

- Windows 10 ou supérieur
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (ou plus récent)
- .NET Framework 4.8

## Installation

1. Cloner le dépôt :
   ```bash
   git clone https://github.com/Porygon31/ClientManagementApp.git
   ```
2. Ouvrir `ClientManagementApp.sln` dans Visual Studio
3. Restaurer les packages NuGet (clic droit sur la solution → *Restaurer les packages NuGet*)
4. Compiler et lancer le projet (**F5**)

## Structure du projet

| Fichier | Description |
|---|---|
| `MainForm.cs` | Fenêtre principale avec les tableaux clients et entreprises |
| `ClientForm.cs` | Formulaire d'ajout / modification d'un client |
| `EntrepriseForm.cs` | Formulaire d'ajout / modification d'une entreprise |
| `AideForm.cs` | Fenêtre d'aide intégrée |
| `DatabaseHelper.cs` | Gestion de la base de données SQLite (création, lecture, écriture) |
| `Constantes.cs` | Constantes de l'application (URLs, messages, formats) |
| `Client.cs` / `Entreprise.cs` | Modèles de données |

## Licence

Voir le fichier [LICENSE](LICENSE).
