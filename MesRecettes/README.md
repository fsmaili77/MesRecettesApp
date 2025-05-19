# MesRecettes

MesRecettes est une application web ASP.NET Core (C#) permettant de gérer et consulter des recettes de cuisine, avec gestion des ingrédients, des unités de mesure, des origines et des types d'aliments. L'application utilise Entity Framework Core avec SQL Server pour la persistance des données et l'authentification basée sur ASP.NET Identity.

## Fonctionnalités principales
- Affichage de la liste des recettes avec leurs ingrédients, type et origine
- Gestion des ingrédients, unités de mesure, types et origines d'aliments
- Authentification et gestion des utilisateurs (ASP.NET Identity)
- Interface web moderne avec Bootstrap

## Structure des données
- **Recette** : nom, instructions, température/temps de cuisson, type et origine, ingrédients
- **Ingrédient** : nom, quantité, unité de mesure
- **Unité de mesure** : nom, système (métrique/impérial)
- **Type/Origine d'aliment** : nom
- **Relation** : une recette possède plusieurs ingrédients (relation many-to-many via `IngredientRecette`)

## Technologies utilisées
- .NET 6 / ASP.NET Core MVC
- Entity Framework Core (SQL Server)
- ASP.NET Core Identity
- Bootstrap 5, jQuery

## Prérequis
- .NET 6 SDK
- SQL Server (LocalDB ou autre)

## Installation et lancement
1. **Cloner le dépôt**
   ```powershell
   git clone <url-du-repo>
   cd MesRecettesApp/MesRecettes
   ```
2. **Configurer la base de données**
   - La chaîne de connexion se trouve dans `appsettings.json` (par défaut LocalDB)
   - Pour initialiser la base :
     ```powershell
     dotnet ef database update
     ```
3. **Lancer l'application**
   ```powershell
   dotnet run
   ```
   Accéder à [https://localhost:7116](https://localhost:7116) ou [http://localhost:5262](http://localhost:5262)

## Structure du projet
- `Controllers/` : Contrôleurs MVC (logique métier)
- `Models/` : Modèles de données (Recette, Ingrédient, etc.)
- `Data/` : Contexte EF Core, migrations
- `Views/` : Vues Razor (UI)
- `wwwroot/` : Fichiers statiques (CSS, JS, images)

## Scripts utiles
- Mettre à jour la base :
  ```powershell
  dotnet ef database update
  ```
- Ajouter une migration :
  ```powershell
  dotnet ef migrations add <NomMigration>
  ```

## Sécurité
- Authentification ASP.NET Identity (inscription, connexion, gestion de compte)
- Les mots de passe ne sont jamais stockés en clair

## Personnalisation
- Les styles sont dans `wwwroot/css/StyleSheet.css`
- Les vues principales sont dans `Views/Home/`

## Licence
Ce projet utilise des bibliothèques tierces sous licence MIT (Bootstrap, jQuery, etc.).


