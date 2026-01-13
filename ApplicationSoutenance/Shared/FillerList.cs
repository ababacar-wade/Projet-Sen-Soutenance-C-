using ApplicationSoutenance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

// Déclaration du namespace Shared pour les classes utilitaires partagées dans l'application
namespace AppSenSoutenance.Shared
{
    // Classe utilitaire pour remplir des listes déroulantes avec des données de la base
    public class FillerList
    {
        // Création d'une instance du contexte de base de données pour accéder aux tables
        BdSoutenanceContext bd = new BdSoutenanceContext();

        // Méthode qui remplit une liste de ListItem (souvent utilisée pour ComboBox / DropDown)
        // Retourne une liste d'éléments représentant les années académiques
        public List<ListItem> fillAnneeAcademique()
        {
            // Initialisation d'une nouvelle liste vide de ListItem
            List<ListItem> laListe = new List<ListItem>();

            // Récupération de toutes les années académiques depuis la base de données
            var liste = bd.anneeAcademiques.ToList();

            // Ajout d'un premier élément par défaut "Sélectionner" avec la valeur 0
            laListe.Add(new ListItem
            {
                // Value à 0 indique qu'aucune année académique n'est sélectionnée
                Value = 0,
                // Texte affiché par défaut dans la liste déroulante
                Text = "Sélectionner"
            });

            // Boucle parcourant chaque année académique de la liste récupérée
            foreach (var t in liste)
            {
                // Ajout de chaque année académique à la liste
                laListe.Add(new ListItem
                {
                    // ⚠️ OBLIGATOIRE : clé primaire
                    // Value contient l'ID de l'année académique (clé primaire)
                    Value = t.IdAnneeAcademique,
                    // Text contient le libellé affiché à l'utilisateur (ex: "2023-2024")
                    Text = t.LibelleAnneeAcademique
                });
            }

            // Retourne la liste complète avec toutes les années académiques
            return laListe;
        }



        public List<ListItem> fillDepartement()
        {
            // Initialisation d'une nouvelle liste vide de ListItem
            List<ListItem> laListe = new List<ListItem>();

            // Récupération de toutes les années académiques depuis la base de données
            var liste = bd.departements.ToList();

            // Ajout d'un premier élément par défaut "Sélectionner" avec la valeur 0
            laListe.Add(new ListItem
            {
                // Value à 0 indique qu'aucune année académique n'est sélectionnée
                Value = 0,
                // Texte affiché par défaut dans la liste déroulante
                Text = "Sélectionner"
            });

            // Boucle parcourant chaque année académique de la liste récupérée
            foreach (var t in liste)
            {
                // Ajout de chaque année académique à la liste
                laListe.Add(new ListItem
                {
                    // ⚠️ OBLIGATOIRE : clé primaire
                    // Value contient l'ID de l'année académique (clé primaire)
                    Value = t.IdDepartement,
                    // Text contient le libellé affiché à l'utilisateur (ex: "2023-2024")
                    Text = t.Libelle
                });
            }

            // Retourne la liste complète avec toutes les années académiques
            return laListe;
        }
    }
}
