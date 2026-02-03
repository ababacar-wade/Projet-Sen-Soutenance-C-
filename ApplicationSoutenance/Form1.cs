using ApplicationSoutenance.Models;
using ApplicationSoutenance.Shared;
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
namespace ApplicationSoutenance
{
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }
        BdSoutenanceContext bd = new BdSoutenanceContext();
        // la methode pour quitter l'application
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //la methode pour se connecter sur l'application
        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupère le mot de passe hashé de l'utilisateur
                // dont le login correspond à celui saisi dans le champ txtIdentifiant1
                string hash = bd.utilisateurs
                    .Where(a => a.Email == txtIdentifiant.Text)
                    .FirstOrDefault()
                    .MotDePasse;
                // Création d'un objet MD5 pour travailler avec les hash
                using (MD5 md5Hash = MD5.Create())
                {
                    // Vérifie si le hash du mot de passe saisi
                    // correspond au hash stocké dans la base de données
                    if (VerifyMd5Hash(md5Hash, txtMotDePasse.Text, hash))
                    {
                        // Les deux hash sont identiques :
                        // le mot de passe saisi est correct
                        //on se connecte
                        frmMdi f = new frmMdi();
                        f.profil = "Admin";
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Les hash sont différents :
                        // le mot de passe saisi est incorrect
                        MessageBox.Show("Mot de passe incorrect");
                    }
                }
            }
            catch (Exception ex) 
            {
                Logger.WriteDataError("frmConnexion-btnSeConnecter_Click", ex.ToString());
            }
           
        }
        // Méthode qui permet de vérifier si un mot de passe saisi
        // correspond au mot de passe hashé stocké dans la base de données
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Génère le hash MD5 du texte saisi (ex : mot de passe entré par l'utilisateur)
            string hashOfInput = AppSenSoutenance.Shared.Crypted.GetMd5Hash(md5Hash, input);
            // Crée un comparateur de chaînes insensible à la casse
            // (MD5 peut être écrit en majuscules ou minuscules)
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            // Compare le hash calculé avec le hash stocké en base
            // Si les deux sont identiques, Compare retourne 0
            if (0 == comparer.Compare(hashOfInput, hash))
            {
                // Les deux hash sont identiques → mot de passe correct
                return true;
            }
            else
            {
                // Les hash sont différents → mot de passe incorrect
                return false;
            }
        }

        // Effet hover bouton Se connecter - Entrée de la souris
        private void btnSeConnecter_MouseEnter(object sender, EventArgs e)
        {
            btnSeConnecter.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
        }

        // Effet hover bouton Se connecter - Sortie de la souris
        private void btnSeConnecter_MouseLeave(object sender, EventArgs e)
        {
            btnSeConnecter.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
        }

        // Effet hover bouton Quitter - Entrée de la souris
        private void btnQuitter_MouseEnter(object sender, EventArgs e)
        {
            btnQuitter.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
        }

        // Effet hover bouton Quitter - Sortie de la souris
        private void btnQuitter_MouseLeave(object sender, EventArgs e)
        {
            btnQuitter.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
        }
    }
}