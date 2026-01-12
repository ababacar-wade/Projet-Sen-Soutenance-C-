// Importation des modèles (entités) de l’application
using ApplicationSoutenance.Models;

// Importation des bibliothèques système nécessaires
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationSoutenance.Views.Parametre
{
    // Formulaire de gestion des années académiques
    public partial class frmAnneeAcademique : Form
    {
        // Constructeur du formulaire
        public frmAnneeAcademique()
        {
            // Initialisation des composants graphiques
            InitializeComponent();
        }

        // Création du contexte de base de données (Entity Framework)
        BdSoutenanceContext bd = new BdSoutenanceContext();

        // Méthode pour vider les champs et rafraîchir le DataGridView
        public void effacer()
        {
            // Vider le champ Libellé
            txtLibelleAnneeAcademique.Clear();

            // Vider le champ Année académique
            txtAnneeAcademiqueVal.Clear();

            // Recharger les données dans le DataGridView
            dgAnneeAcademique.DataSource = bd.anneeAcademiques.ToList();

            // Mettre le curseur sur le premier champ
            txtLibelleAnneeAcademique.Focus();
        }

        // Événement du bouton Ajouter
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Création d’un nouvel objet AnneeAcademique
            AnneeAcademique anneeAcademique = new AnneeAcademique()
            {
                // Récupération du libellé depuis le TextBox
                LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text,

                // Conversion du texte en entier pour l’année
                AnneeAcademiqueVal = int.Parse(txtAnneeAcademiqueVal.Text)
            };

            // Ajout de l’objet dans la base de données
            bd.anneeAcademiques.Add(anneeAcademique);

            // Enregistrement des modifications
            bd.SaveChanges();

            // Réinitialisation des champs et du tableau
            effacer();
        }

        // Événement déclenché au chargement du formulaire
        private void frmAnneeAcademique_Load(object sender, EventArgs e)
        {
            // Chargement des données dans le DataGridView
            dgAnneeAcademique.DataSource = bd.anneeAcademiques.ToList();
        }

        // Événement du bouton Sélectionner
        private void btnSlectionner_Click(object sender, EventArgs e)
        {
            // Récupération des valeurs de la ligne sélectionnée
            txtLibelleAnneeAcademique.Text =
                dgAnneeAcademique.CurrentRow.Cells[1].Value.ToString();

            txtAnneeAcademiqueVal.Text =
                dgAnneeAcademique.CurrentRow.Cells[2].Value.ToString();
        }

        // Événement du bouton Supprimer
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Récupération de l’ID de la ligne sélectionnée
            int id = int.Parse(
                dgAnneeAcademique.CurrentRow.Cells[0].Value.ToString()
            );

            // Recherche de l’objet dans la base de données
            AnneeAcademique anneeAcademique = bd.anneeAcademiques.Find(id);

            // Suppression de l’objet
            bd.anneeAcademiques.Remove(anneeAcademique);

            // Validation de la suppression
            bd.SaveChanges();

            // Rafraîchissement de l’interface
            effacer();
        }

        // Événement du bouton Modifier
        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Récupération de l’ID de la ligne sélectionnée
            int id = int.Parse(
                dgAnneeAcademique.CurrentRow.Cells[0].Value.ToString()
            );

            // Recherche de l’enregistrement dans la base
            AnneeAcademique anneeAcademique = bd.anneeAcademiques.Find(id);

            // Mise à jour des valeurs
            anneeAcademique.LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text;
            anneeAcademique.AnneeAcademiqueVal = int.Parse(txtAnneeAcademiqueVal.Text);

            // Enregistrement des modifications
            bd.SaveChanges();

            // Rafraîchissement des champs et du tableau
            effacer();
        }
    }
}
