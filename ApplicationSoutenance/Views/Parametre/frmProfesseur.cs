using ApplicationSoutenance.Models;
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
    public partial class frmProfesseur : Form
    {
        // Constructeur du formulaire
        public frmProfesseur()
        {
            // Initialisation des composants graphiques
            InitializeComponent();

            // Liaison manuelle des événements Click
            btnModifier.Click += btnModifier_Click;
            btnSupprimer.Click += btnSupprimer_Click;
            btnSlectionner.Click += btnSlectionner_Click;
        }

        // Création du contexte de base de données (Entity Framework)
        BdSoutenanceContext bd = new BdSoutenanceContext();

        // Événement du bouton Ajouter
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Création d’un nouvel objet professeur
            Professeur professeur = new Professeur()
            {
                // Récupération les variable depuis le TextBox
                Nomutilisateur = txtNom.Text,
                PrenomUtilisateur = txtPrenom.Text,
                TelUtilisateur = txtTelephone.Text,
                Email = txtEmail.Text,
                MotDePasse = txtMotDePasse.Text,
                SpecialiteProfesseur = txtSpecialite.Text,
            };

            // Ajout de l’objet dans la base de données
            bd.professeurs.Add(professeur);

            // Enregistrement des modifications
            bd.SaveChanges();

            // Réinitialisation des champs et du tableau
            Effacer();

        }

        // Événement déclenché au chargement du formulaire
        private void frmProfesseur_Load(object sender, EventArgs e)
        {
            dgProfesseur.DataSource = bd.professeurs.ToList();
        }

        // Événement du bouton modifier
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgProfesseur.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un professeur !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            object cellValue = dgProfesseur.CurrentRow.Cells["Idutilisateur"].Value;
            if (cellValue == null || !int.TryParse(cellValue.ToString(), out int id))
            {
                MessageBox.Show("Impossible de récupérer l'ID du professeur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Professeur professeur = bd.professeurs.Find(id);
            if (professeur == null)
            {
                MessageBox.Show("Professeur introuvable !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            professeur.Nomutilisateur = txtNom.Text;
            professeur.PrenomUtilisateur = txtPrenom.Text;
            professeur.TelUtilisateur = txtTelephone.Text;
            professeur.Email = txtEmail.Text;
            professeur.MotDePasse = txtMotDePasse.Text;
            professeur.SpecialiteProfesseur = txtSpecialite.Text;

            // Sauvegarde les modifications avec gestion des erreurs de validation
            try
            {
                bd.SaveChanges();
                Effacer();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                // Parcours toutes les erreurs de validation et les affiche
                foreach (var error in ex.EntityValidationErrors)
                    foreach (var detail in error.ValidationErrors)
                        MessageBox.Show(detail.PropertyName + " : " + detail.ErrorMessage, "Erreur Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Événement du bouton supprimer
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Vérifier qu’une ligne est sélectionnée
            if (dgProfesseur.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un professeur !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Récupérer l'ID de la ligne sélectionnée en utilisant le nom de la colonne
            object cellValue = dgProfesseur.CurrentRow.Cells["Idutilisateur"].Value;
            if (cellValue == null || !int.TryParse(cellValue.ToString(), out int id))
            {
                MessageBox.Show("Impossible de récupérer l'ID du professeur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Chercher le professeur correspondant dans la base
            Professeur professeur = bd.professeurs.Find(id);
            if (professeur == null)
            {
                MessageBox.Show("Professeur introuvable !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmation avant suppression
            DialogResult result = MessageBox.Show(
                "Voulez-vous vraiment supprimer ce professeur ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );


            // Si l'utilisateur confirme
            if (result == DialogResult.Yes)
            {
                // Supprimer le professeur
                bd.professeurs.Remove(professeur);

                // Sauvegarde les modifications et gère les erreurs de validation
                try
                {
                    bd.SaveChanges();
                    Effacer(); // Rafraîchir les données et vider les champs
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    foreach (var error in ex.EntityValidationErrors)
                        foreach (var detail in error.ValidationErrors)
                            MessageBox.Show(detail.PropertyName + " : " + detail.ErrorMessage, "Erreur Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Événement du bouton supprimer
        private void btnSlectionner_Click(object sender, EventArgs e)
        {
            txtNom.Text = dgProfesseur.CurrentRow.Cells["Nomutilisateur"].Value.ToString();
            txtPrenom.Text = dgProfesseur.CurrentRow.Cells["PrenomUtilisateur"].Value.ToString();
            txtTelephone.Text = dgProfesseur.CurrentRow.Cells["TelUtilisateur"].Value.ToString();
            txtEmail.Text = dgProfesseur.CurrentRow.Cells["Email"].Value.ToString();
            txtMotDePasse.Text = dgProfesseur.CurrentRow.Cells["MotDePasse"].Value.ToString();
            txtSpecialite.Text = dgProfesseur.CurrentRow.Cells["SpecialiteProfesseur"].Value.ToString();
        }

        // methode d'effacement 
        // Méthode pour vider les champs et rafraîchir le DataGridView
        private void Effacer()
        {
            // Vider le champ nom
            txtNom.Clear();

            // Vider le champ prenom
            txtPrenom.Clear();

            // Vider le champ telephone
            txtTelephone.Clear();

            // Vider le champ email
            txtEmail.Clear();

            // Vider le champ mot de passe 
            txtMotDePasse.Clear();

            // Vider le champ specialite
            txtSpecialite.Clear();


            // Recharger les données dans le DataGridView
            dgProfesseur.DataSource = bd.professeurs.ToList();

            // Mettre le curseur sur le premier champ
            txtNom.Focus();
        }
    }
}
