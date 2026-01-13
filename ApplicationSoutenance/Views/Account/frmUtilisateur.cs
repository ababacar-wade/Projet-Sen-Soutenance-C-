
using ApplicationSoutenance.Models;
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
                a => new {a.Idutilisateur,
                    a.Nomutilisateur,
                    a.PrenomUtilisateur,
                    a.TelUtilisateur,
                    a.Email}).ToList();
            txtNom.Clear();
            txtPrenom.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            txtMatricule.Text = GenererMatricule();
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
            candidat.TelUtilisateur= txtTel.Text;
            candidat.MatriculeCandidat = txtMatricule.Text;
            bd.SaveChanges();
            ResetForm();
        }
    }
}
