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
                // Vérifie si l'identifiant ou le mot de passe est vide ou contient uniquement des espaces
                if (string.IsNullOrWhiteSpace(txtIdentifiant.Text) ||
                    string.IsNullOrWhiteSpace(txtMotDePasse.Text))
                {
                    // Message d’avertissement si un champ n’est pas rempli
                    MessageBox.Show(
                        "Veuillez renseigner tous les champs.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return; // Arrête l’exécution de la méthode
                }

                // Recherche de l’utilisateur dans la base de données à partir de l’email
                var utilisateur = bd.utilisateurs
                    .FirstOrDefault(a => a.Email == txtIdentifiant.Text);

                // Si aucun utilisateur n’est trouvé
                if (utilisateur == null)
                {
                    // Message générique pour éviter de révéler si l’email existe ou non
                    MessageBox.Show("Email ou Mot de passe incorrect");
                    return;
                }

                // Création d’un objet MD5 pour vérifier le mot de passe chiffré
                using (MD5 md5Hash = MD5.Create())
                {
                    // Vérifie si le mot de passe saisi correspond au mot de passe stocké
                    if (VerifyMd5Hash(md5Hash, txtMotDePasse.Text, utilisateur.MotDePasse))
                    {
                        // Ouverture de la fenêtre principale après authentification réussie
                        frmMdi f = new frmMdi();

                        // Définition du profil utilisateur
                        f.profil = "Admin";

                        // Affichage du formulaire principal
                        f.Show();

                        // Masque la fenêtre de connexion
                        this.Hide();
                    }
                    else
                    {
                        // Mot de passe incorrect
                        MessageBox.Show("Email ou Mot de passe incorrect");
                    }
                }
            }
            catch (Exception ex)
            {
                // Message générique pour l’utilisateur en cas d’erreur technique
                MessageBox.Show("Erreur technique, voir le log");

                // Enregistrement de l’erreur dans le fichier de log
                Logger.WriteDataError(
                    "frmConnexion-btnSeConnecter_Click",
                    ex.ToString()
                );
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