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
        public string profil;
        public frmProfesseur()
        {
            InitializeComponent();
        }

        BdSoutenanceContext bd = new BdSoutenanceContext();

        private void frmProfesseur_Load(object sender, EventArgs e)
        {
            Effacer();
            if (profil != "Admin" && profil != "Chefdepartement")
            {
                btnAjouter.Enabled = false;
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtPrenom.Text))
            {
                MessageBox.Show("Nom et Prénom sont obligatoires.");
                return;
            }

            Professeur p = new Professeur()
            {
                Nomutilisateur = txtNom.Text,
                PrenomUtilisateur = txtPrenom.Text,
                TelUtilisateur = txtTelephone.Text,
                Email = txtEmail.Text,
                MotDePasse = txtMotDePasse.Text,
                SpecialiteProfesseur = txtSpecialite.Text,
            };

            bd.professeurs.Add(p);
            bd.SaveChanges();
            Effacer();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgProfesseur.CurrentRow == null) return;
            int id = int.Parse(dgProfesseur.CurrentRow.Cells[0].Value.ToString());
            Professeur p = bd.professeurs.Find(id);
            if (p != null)
            {
                p.Nomutilisateur = txtNom.Text;
                p.PrenomUtilisateur = txtPrenom.Text;
                p.TelUtilisateur = txtTelephone.Text;
                p.Email = txtEmail.Text;
                if (!string.IsNullOrEmpty(txtMotDePasse.Text))
                {
                    p.MotDePasse = txtMotDePasse.Text;
                }
                p.SpecialiteProfesseur = txtSpecialite.Text;
                
                bd.SaveChanges();
                Effacer();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgProfesseur.CurrentRow == null) return;
            int id = int.Parse(dgProfesseur.CurrentRow.Cells[0].Value.ToString());
            Professeur p = bd.professeurs.Find(id);
            if (p != null)
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce professeur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bd.professeurs.Remove(p);
                    bd.SaveChanges();
                    Effacer();
                }
            }
        }

        private void btnSlectionner_Click(object sender, EventArgs e)
        {
            if (dgProfesseur.CurrentRow == null) return;
            int id = int.Parse(dgProfesseur.CurrentRow.Cells[0].Value.ToString());
            Professeur p = bd.professeurs.Find(id);
            if (p != null)
            {
                txtNom.Text = p.Nomutilisateur;
                txtPrenom.Text = p.PrenomUtilisateur;
                txtTelephone.Text = p.TelUtilisateur;
                txtEmail.Text = p.Email;
                txtMotDePasse.Text = p.MotDePasse;
                txtSpecialite.Text = p.SpecialiteProfesseur;
            }
        }

        private void Effacer()
        {
            txtNom.Clear();
            txtPrenom.Clear();
            txtTelephone.Clear();
            txtEmail.Clear();
            txtMotDePasse.Clear();
            txtSpecialite.Clear();

            dgProfesseur.DataSource = bd.professeurs.Select(p => new
            {
                ID = p.Idutilisateur,
                Nom = p.Nomutilisateur,
                Prénom = p.PrenomUtilisateur,
                Téléphone = p.TelUtilisateur,
                p.Email,
                Spécialité = p.SpecialiteProfesseur
            }).ToList();

            txtNom.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var liste = bd.professeurs.ToList();

            if (!string.IsNullOrEmpty(txtRNom.Text))
            {
                liste = liste.Where(p => p.Nomutilisateur.ToLower().Contains(txtRNom.Text.ToLower())).ToList();
            }

            if (!string.IsNullOrEmpty(txtRSpecialite.Text))
            {
                liste = liste.Where(p => p.SpecialiteProfesseur.ToLower().Contains(txtRSpecialite.Text.ToLower())).ToList();
            }

            dgProfesseur.DataSource = liste.Select(p => new
            {
                ID = p.Idutilisateur,
                Nom = p.Nomutilisateur,
                Prénom = p.PrenomUtilisateur,
                Téléphone = p.TelUtilisateur,
                p.Email,
                Spécialité = p.SpecialiteProfesseur
            }).ToList();
        }
    }
}
