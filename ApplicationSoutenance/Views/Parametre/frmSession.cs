using ApplicationSoutenance.Models;
using AppSenSoutenance.Shared;
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
    public partial class frmSession : Form
    {
        public frmSession()
        {
            InitializeComponent();
        }

        BdSoutenanceContext bd =   new BdSoutenanceContext();

        //instancier la classe fillerList
        FillerList Filler = new FillerList();

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Vérifie si l'utilisateur a sélectionné une année académique valide
            // Ici, on suppose que la valeur 0 signifie "aucune sélection"
            if ((int)cbxAnneeAcademique.SelectedValue == 0)
            {
                // Affiche un message d'erreur à l'utilisateur
                MessageBox.Show("Veuillez sélectionner une année académique.");

                // Arrête l'exécution du code pour éviter l'insertion invalide
                return;
            }

            // Création d'un nouvel objet Session
            Session session = new Session()
            {
                // Récupère le libellé de la session depuis le champ texte
                LibelleSession = txtSession.Text,

                // Associe la session à l'année académique sélectionnée
                IdAnneeAcademique = (int)cbxAnneeAcademique.SelectedValue
            };

            // Ajoute la session au contexte de base de données
            bd.sessions.Add(session);

            // Enregistre les changements dans la base de données
            bd.SaveChanges();

            // Vide les champs du formulaire après l'enregistrement
            Effacer();

        }

        // Méthode exécutée lorsque l'utilisateur clique sur le bouton "Modifier"
        private void btnModifier_Click(object sender, EventArgs e)
        {
            // Récupère l'identifiant de la session sélectionnée dans le DataGridView
            // La première colonne (index 0) est supposée contenir l'ID
            int? id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());

            // Recherche la session correspondante dans la base de données à partir de son ID
            Session session = bd.sessions.Find(id);

            // Met à jour le libellé de la session avec la valeur saisie dans le champ texte
            session.LibelleSession = txtSession.Text;

            // Met à jour l'année académique associée à la session sélectionnée
            session.IdAnneeAcademique = (int?)cbxAnneeAcademique.SelectedValue;

            // Enregistre les modifications dans la base de données
            bd.SaveChanges();

            // Vide les champs du formulaire après la modification
            Effacer();
        }


        // Méthode exécutée lorsque l'utilisateur clique sur le bouton "Supprimer"
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Récupère l'identifiant de la session sélectionnée dans le DataGridView
            // La première colonne (index 0) est supposée contenir l'ID
            int? id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());

            // Recherche la session correspondante dans la base de données à partir de son ID
            Session session = bd.sessions.Find(id);

            // Supprime la session sélectionnée du contexte de base de données
            bd.sessions.Remove(session);

            // Enregistre la suppression dans la base de données
            bd.SaveChanges();

            // Vide les champs du formulaire après la suppression
            Effacer();
        }


        // Méthode exécutée lorsque l'utilisateur clique sur le bouton "Sélectionner"
        private void btnSlectionner_Click(object sender, EventArgs e)
        {
            // Récupère l'identifiant de la session sélectionnée dans le DataGridView
            // La première colonne (index 0) est supposée contenir l'ID
            int? id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());

            // Recherche la session correspondante dans la base de données à partir de son ID
            Session session = bd.sessions.Find(id);

            // Remplit le champ texte avec le libellé de la session sélectionnée
            txtSession.Text = session.LibelleSession;

            // Sélectionne automatiquement l'année académique associée à cette session
            cbxAnneeAcademique.SelectedValue = session.IdAnneeAcademique;
        }


        /// <summary>
        /// methode pour vider les champs 
        /// </summary>
        private void Effacer()
        {
            txtSession.Clear();
            cbxAnneeAcademique.SelectedValue = 0;
            dgSession.DataSource = bd.sessions.ToList();
            cbxAnneeAcademique.DataSource = Filler.fillAnneeAcademique();
            cbxAnneeAcademique.DisplayMember = "Text";
            cbxAnneeAcademique.ValueMember = "value";
            txtSession.Focus();
        }

        /// <summary>
        /// methode pour charger le formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSession_Load(object sender, EventArgs e)
        {
            Effacer();
        }

        /// <summary>
        /// methode pour rechercher 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Récupère toutes les sessions depuis la base de données
            var liste = bd.sessions.ToList();

            // Vérifie si un texte de recherche sur le libellé de la session a été saisi
            if (!string.IsNullOrEmpty(txtRSession.Text))
            {
                // Filtre la liste des sessions dont le libellé contient le texte recherché
                liste = liste
                    .Where(s => s.LibelleSession.Contains(txtRSession.Text))
                    .ToList();
            }

            // Vérifie si un texte de recherche sur l'année académique a été saisi
            if (txtRAnneeAcademique.Text != "")
            {
                // Filtre la liste des sessions selon le libellé de l'année académique associée
                liste = liste
                    .Where(s => s.AnneeAcademique.LibelleAnneeAcademique
                    .Contains(txtRAnneeAcademique.Text))
                    .ToList();
            }

            // Affiche la liste filtrée dans le DataGridView
            dgSession.DataSource = liste;

        }
    }
}
