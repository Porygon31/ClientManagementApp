# Gestionnaire de clientèle - Guide d'utilisation

## Présentation

Le **Gestionnaire de clientèle** est une application de bureau permettant de gérer vos clients et leurs entreprises. Vous pouvez ajouter, consulter, modifier et supprimer des fiches clients et entreprises, rechercher rapidement dans vos données, et accéder en un clic aux sites administratifs (Impôts, Urssaf).

Les données sont stockées localement dans un fichier `clients.db`, créé automatiquement au premier lancement. Aucune installation ou configuration de base de données n'est nécessaire.

---

## Écran principal

L'écran principal est divisé en deux sections :

### Section « Clients » (haut de l'écran)

- Un **tableau** affiche la liste de tous vos clients (nom, prénom, email, téléphone, etc.).
- A droite du tableau se trouvent :
  - Un **champ de recherche** pour filtrer les clients par nom de famille, avec un bouton **Rechercher**. Si vous videz le champ de recherche, la liste complète se réaffiche automatiquement.
  - Les boutons **Ajouter Client**, **Modifier Client** et **Supprimer Client**.

### Section « Entreprises » (bas de l'écran)

- Un **tableau** affiche la liste de toutes les entreprises enregistrées (nom, code APE/NAF, SIRET, SIE, téléphone, etc.).
- A droite du tableau se trouvent :
  - Un **champ de recherche** pour filtrer les entreprises par nom du client associé, avec un bouton **Rechercher**.
  - Les boutons **Ajouter une Entreprise**, **Editer une Entreprise** et **Supprimer une Entreprise**.

> Si la fenêtre est trop petite pour afficher tout le contenu, une barre de défilement apparaît automatiquement.

---

## Comment ajouter un client

1. Sur l'écran principal, cliquez sur le bouton **Ajouter Client**.
2. Un formulaire s'ouvre avec les champs suivants :

| Champ | Obligatoire |
|-------|:-----------:|
| Nom | Oui |
| Prénom | Oui |
| Date de naissance | Non |
| Lieu de naissance | Non |
| Sexe (M / Mme) | Oui |
| Adresse mail | Oui |
| Numéro de téléphone | Non |
| Numéro de téléphone secondaire | Non |
| Numéro de Sécurité Sociale | Non |
| Identifiant SIP | Non |
| Mot de passe SIP | Non |

3. Remplissez au minimum les champs obligatoires.
4. Cliquez sur le bouton rouge **Sauvegarder** pour enregistrer le client.

**Remarques :**
- L'adresse mail doit contenir un `@` et un `.` pour être acceptée.
- Les numéros de téléphone ne doivent contenir que des chiffres et des espaces, avec éventuellement un `+` au début.
- Un lien **Impôt** est disponible dans ce formulaire et ouvre le site `impots.gouv.fr` dans votre navigateur.

---

## Comment créer une entreprise

**Important : une entreprise appartient obligatoirement à un client déjà existant dans la base de données.** Vous devez donc d'abord créer le client avant de pouvoir lui associer une entreprise.

1. Assurez-vous que le client concerné existe déjà (sinon, ajoutez-le d'abord).
2. Sur l'écran principal, cliquez sur le bouton **Ajouter une Entreprise**.
3. Un formulaire s'ouvre avec les champs suivants :

| Champ | Obligatoire |
|-------|:-----------:|
| Nom de l'entreprise | Oui |
| Code APE / NAF | Oui |
| Adresse mail | Oui |
| Numéro SIRET | Oui |
| Date de création | Oui |
| Numéro SIE | Oui |
| Numéro de téléphone | Oui |
| Client associé (liste déroulante) | Oui |
| Identifiant Urssaf | Oui |
| Mot de passe Urssaf | Oui |
| Identifiant SIE | Non |
| Mot de passe SIE | Non |

4. Dans le champ **Client associé**, sélectionnez le client auquel cette entreprise est rattachée via la liste déroulante (qui affiche les clients existants).
5. Remplissez tous les champs obligatoires.
6. Cliquez sur le bouton rouge **Sauvegarder** pour enregistrer l'entreprise.

**Remarques :**
- Le champ **Adresse mail** propose les emails des clients existants.
- Le numéro de téléphone ne doit contenir que des chiffres et des espaces, avec éventuellement un `+` au début.
- Des liens **URSSAF** et **URSSAF ME** sont disponibles dans ce formulaire et ouvrent les portails Urssaf correspondants dans votre navigateur.

---

## Consulter ou modifier les données d'un client ou d'une entreprise

Pour accéder aux informations complètes d'un client ou d'une entreprise :

1. **Sélectionnez** la ligne correspondante dans le tableau en cliquant dessus.
2. Cliquez sur le bouton **Modifier Client** (ou **Editer une Entreprise** pour les entreprises).
3. Le formulaire s'ouvre avec toutes les données pré-remplies. Vous pouvez les consulter ou les modifier.
4. Si vous avez effectué des modifications, cliquez sur **Sauvegarder** pour les enregistrer. Sinon, fermez simplement la fenêtre.

---

## Supprimer un client ou une entreprise

1. Sélectionnez la ligne correspondante dans le tableau.
2. Cliquez sur **Supprimer Client** (ou **Supprimer une Entreprise**).
3. Une fenêtre de confirmation apparaît. Cliquez sur **Oui** pour confirmer la suppression.

---

## Boutons de copie rapide (fiche entreprise)

Dans le formulaire entreprise, plusieurs champs disposent d'un bouton de copie (icône) permettant de copier la valeur dans le presse-papiers en un clic :

- Numéro SIE
- Numéro de téléphone
- Numéro SIRET
- Identifiant Urssaf
- Mot de passe Urssaf
- Identifiant SIE
- Mot de passe SIE

> Si le champ est vide, un message vous prévient qu'il n'y a rien à copier.

---

## Liens externes

L'application donne un accès rapide aux sites administratifs suivants :

| Lien | Accessible depuis |
|------|-------------------|
| **Impôt** (impots.gouv.fr) | Fiche Client |
| **URSSAF** (urssaf.fr) | Fiche Entreprise |
| **URSSAF ME** (autoentrepreneur.urssaf.fr) | Fiche Entreprise |

Il suffit de cliquer sur le lien correspondant dans le formulaire pour ouvrir le site dans votre navigateur.
