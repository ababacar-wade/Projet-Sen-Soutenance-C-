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

namespace ApplicationSoutenance.Views.Parametre
{
    public partial class frmSoutenance : Form
    {
        public frmSoutenance()
        {
            InitializeComponent();
        }

        BdSoutenanceContext bd = new BdSoutenanceContext();
        private object txtSoutenance;

        private void Effacer()
        {
          
            dgSoutenance.DataSource = bd.soutenances.ToList();
            txtNom.Clear();
            txtPrenom.Clear();
            txtTelephone.Clear();
            txtEmail.Clear();
            txtMotDePass.Clear();
            

        }


        private void frmSoutenance_Load(object sender, EventArgs e)
        {
            Effacer();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            Soutenance soutenance = new Soutenance();
            soutenance.NomUtilisateur = txtNom.Text;
            soutenance.PrenomUtilisateur = txtPrenom.Text;
            soutenance.TelUtilisateur = txtTelephone.Text;
            soutenance.EmailUtilisateur = txtEmail.Text;
            using (MD5 md5Hash = MD5.Create())
            {

                soutenance.MotDePasse = md5Hash.ToString();

            }
            bd.soutenances.Add(soutenance);
            bd.SaveChanges();
            Effacer();


        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgSoutenance.CurrentRow.Cells[0].Value.ToString());
            Soutenance soutenance = bd.soutenances.Find(id);
            soutenance.NomUtilisateur = txtNom.Text;
            soutenance.PrenomUtilisateur = txtPrenom.Text;
            soutenance.TelUtilisateur = txtTelephone.Text;
            soutenance.EmailUtilisateur = txtEmail.Text;
            using (MD5 md5Hash = MD5.Create())
            {
                soutenance.MotDePasse = md5Hash.ToString();
            }
            bd.SaveChanges();
            Effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgSoutenance.CurrentRow.Cells[0].Value.ToString());
            Soutenance soutenance = bd.soutenances.Find(id);
            bd.soutenances.Remove(soutenance);
            bd.SaveChanges();
            Effacer();
        }

        private void btnSlectionner_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgSoutenance.CurrentRow.Cells[0].Value.ToString());
            Soutenance soutenance = bd.soutenances.Find(id);
            txtNom.Text = soutenance.NomUtilisateur;
            txtPrenom.Text = soutenance.PrenomUtilisateur;
            txtTelephone.Text = soutenance.TelUtilisateur;
            txtEmail.Text = soutenance.EmailUtilisateur;

        }
    }
}
