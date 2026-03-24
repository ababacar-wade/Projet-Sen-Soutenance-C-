using ApplicationSoutenance.Models;
using ApplicationSoutenance.Views.Parametre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationSoutenance
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitAdmin();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmConnexion());
        }

        static void InitAdmin()
        {
            BdSoutenanceContext bd = new BdSoutenanceContext();

            // On s'assure que ibou@gmail.com existe et a le bon mot de passe, peu importe son type
            var userIbou = bd.utilisateurs.FirstOrDefault(u => u.Email == "ibou@gmail.com");
            if (userIbou == null)
            {
                Admin a = new Admin();
                a.Nomutilisateur = "Ibou";
                a.PrenomUtilisateur = "ID";
                a.TelUtilisateur = "+221770000000";
                a.Email = "ibou@gmail.com";
                using (MD5 md5Hash = MD5.Create())
                {
                    a.MotDePasse = Shared.Crypted.GetMd5Hash(md5Hash, "passer1234");
                }
                bd.admins.Add(a);
                bd.SaveChanges();
            }
            else
            {
                using (MD5 md5Hash = MD5.Create())
                {
                    userIbou.MotDePasse = Shared.Crypted.GetMd5Hash(md5Hash, "passer1234");
                }
                bd.SaveChanges();
            }

            // S'assurer qu'il y a au moins un compte administrateur 
            if (bd.admins.Count() == 0)
            {
                Admin a = new Admin();
                a.Nomutilisateur = "Admin";
                a.PrenomUtilisateur = "Admin";
                a.TelUtilisateur = "+221770000000";
                a.Email = "admin@gmail.com";
                using (MD5 md5Hash = MD5.Create())
                {
                    a.MotDePasse = Shared.Crypted.GetMd5Hash(md5Hash, "passer1234");
                }
                bd.admins.Add(a);
                bd.SaveChanges();
            }
        }
    }
}