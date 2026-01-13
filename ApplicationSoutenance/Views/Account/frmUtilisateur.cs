
using ApplicationSoutenance.Models;
using AppSenSoutenance.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenSoutenance.Views.Account
{
    public partial class frmUtilisateur : Form
    {
        public frmUtilisateur()
        {
            InitializeComponent();
        }

        BdSoutenanceContext bd = new BdSoutenanceContext();

        //instancier la classe fillerList
        FillerList Filler = new FillerList();

        private void frmUtilisateur_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            

            Candidat candidat = new Candidat();
            candidat.Nomutilisateur = txtNom.Text;
            candidat.PrenomUtilisateur = txtPrenom.Text;
            candidat.TelUtilisateur = txtTel.Text;
            candidat.Email = txtEmail.Text;
            using (MD5 md5Hash = MD5.Create())
            {

                candidat.MotDePasse = Shared.Crypted.GetMd5Hash(md5Hash, "passer1234");

            }
            candidat.MatriculeCandidat = txtMatricule.Text;
            bd.candidats.Add(candidat);
            bd.SaveChanges();
            ResetForm();
        }

        private void ResetForm()
        {
           
            dgUtilisateur.DataSource = bd.utilisateurs.Select(
                a => new
                {
                    a.Idutilisateur,
                    a.Nomutilisateur,
                    a.PrenomUtilisateur,
                    a.TelUtilisateur,
                    a.Email
                }).ToList();
            // Nettoyer les champs pour Candidat
            txtNom.Clear();
            txtPrenom.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            txtMatricule.Text = GenererMatricule();
            // Nettoyer les champs pour Professeur
            txtPNom.Clear();
            txtPPrenom.Clear();
            txtPEmail.Clear();
            txtPTel.Clear();
            txtPSpecialite.Clear();
            txtPEmail.Clear();
            txtPSpecialite.Clear();
            // Nettoyer les champs pour Chef de Departement
            txtCNom.Clear();
            txtCPrenom.Clear();
            txtCEmail.Clear();
            txtCTel.Clear();
            cbxDepartement.DataSource = Filler.fillDepartement();
            cbxDepartement.DisplayMember = "Text";
            cbxDepartement.ValueMember = "Value";

        }


        // Méthode pour générer le matricule automatiquement
        private string GenererMatricule()
        {
            int dernierId = 0;

            // Vérifie si la table candidats contient déjà des enregistrements
            if (bd.candidats.Any())
            {
                // Récupère le plus grand ID existant
                dernierId = bd.candidats.Max(c => c.Idutilisateur);
            }

            // Nouvel ID = dernier ID + 1
            int nouveauId = dernierId + 1;

            // Génère le matricule au format CAN-0001
            // "D4" signifie que le nombre aura toujours 4 chiffres, avec des zéros devant
            string matricule = string.Concat("CAN-", nouveauId.ToString("D4"));


            return matricule;
        }

        /// <summary>
        /// methode pour selectionner  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            Candidat candidat = bd.candidats.Find(id);
            txtNom.Text = candidat.Nomutilisateur;
            txtPrenom.Text = candidat.PrenomUtilisateur;
            txtEmail.Text = candidat.Email;
            txtTel.Text = candidat.TelUtilisateur;
            txtMatricule.Text = candidat.MatriculeCandidat;
        }


        /// <summary>
        /// methode pour supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            Candidat candidat = bd.candidats.Find(id);
            bd.candidats.Remove(candidat);
            bd.SaveChanges();
            ResetForm();
        }

        /// <summary>
        /// methode pour ajouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            Candidat candidat = bd.candidats.Find(id);
            candidat.Nomutilisateur = txtNom.Text;
            candidat.PrenomUtilisateur = txtPrenom.Text;
            candidat.Email = txtEmail.Text;
            candidat.TelUtilisateur = txtTel.Text;
            candidat.MatriculeCandidat = txtMatricule.Text;
            bd.SaveChanges();
            ResetForm();
        }

        private void btnPAjouter_Click(object sender, EventArgs e)
        {
            Professeur professeur = new Professeur();
            professeur.Nomutilisateur = txtPNom.Text;
            professeur.PrenomUtilisateur = txtPPrenom.Text;
            professeur.Email = txtPEmail.Text;
            professeur.TelUtilisateur = txtPTel.Text;
            using (MD5 md5hash = MD5.Create())
            {
                professeur.MotDePasse = Shared.Crypted.GetMd5Hash(md5hash, "passer1234");
            }
            professeur.SpecialiteProfesseur = txtPSpecialite.Text;
            bd.professeurs.Add(professeur);
            bd.SaveChanges();
            ResetForm();
        }

        private void btnPModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            Professeur professeur = bd.professeurs.Find(id);
            professeur.Nomutilisateur = txtPNom.Text;
            professeur.PrenomUtilisateur = txtPPrenom.Text;
            professeur.TelUtilisateur = txtPTel.Text;
            professeur.Email = txtPEmail.Text;
            professeur.SpecialiteProfesseur = txtPSpecialite.Text;
            bd.SaveChanges();
            ResetForm();
        }

        private void btnPSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            Professeur professeur = bd.professeurs.Find(id);
            bd.professeurs.Remove(professeur);
            bd.SaveChanges();
            ResetForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int? id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            Professeur professeur = bd.professeurs.Find(id);
            txtPNom.Text = professeur.Nomutilisateur;
            txtPPrenom.Text = professeur.PrenomUtilisateur;
            txtPEmail.Text = professeur.Email;
            txtPTel.Text = professeur.TelUtilisateur;
            txtPSpecialite.Text = professeur.SpecialiteProfesseur;
        }

        private void btnCAjouter_Click(object sender, EventArgs e)
        {
            // Vérifie si l'utilisateur a sélectionné un Departement valide
            // Ici, on suppose que la valeur 0 signifie "aucune sélection"
            if ((int)cbxDepartement.SelectedValue == 0)
            {
                // Affiche un message d'erreur à l'utilisateur
                MessageBox.Show("Veuillez sélectionner un Departement.");

                // Arrête l'exécution du code pour éviter l'insertion invalide
                return;
            }

            ChefDepartement chefDepartement = new ChefDepartement();

            chefDepartement.DepartementId = (int)cbxDepartement.SelectedValue;

            chefDepartement.Nomutilisateur = txtCNom.Text;
            chefDepartement.PrenomUtilisateur = txtCPrenom.Text.Trim();
            chefDepartement.Email = txtCEmail.Text;
            chefDepartement.TelUtilisateur = txtCTel.Text;
            using (MD5 md5hash = MD5.Create())
            {
                chefDepartement.MotDePasse = Shared.Crypted.GetMd5Hash(md5hash, "passer1234");
            }
            bd.chefDepartements.Add(chefDepartement);
            bd.SaveChanges();
            ResetForm();
        }

        private void btnCModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            ChefDepartement chefDepartement = bd.chefDepartements.Find(id);
            chefDepartement.Nomutilisateur = txtCNom.Text;
            chefDepartement.PrenomUtilisateur = txtCPrenom.Text;
            chefDepartement.TelUtilisateur = txtCTel.Text;
            chefDepartement.Email = txtCEmail.Text;
            chefDepartement.DepartementId = (int)cbxDepartement.SelectedValue;
            bd.SaveChanges();
            ResetForm();

        }

        private void btnCSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            ChefDepartement chefDepartement = bd.chefDepartements.Find(id);
            bd.chefDepartements.Remove(chefDepartement);
            bd.SaveChanges();
            ResetForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            ChefDepartement chefDepartement = bd.chefDepartements.Find(id);
            txtCNom.Text = chefDepartement.Nomutilisateur;
            txtCPrenom.Text = chefDepartement.PrenomUtilisateur;
            txtCEmail.Text = chefDepartement.Email;
            txtCTel.Text = chefDepartement.TelUtilisateur;
            cbxDepartement.SelectedValue = chefDepartement.DepartementId;

        }
    }
}
