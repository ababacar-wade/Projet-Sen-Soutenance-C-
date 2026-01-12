
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
        }
       
    }
}
