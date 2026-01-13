using ApplicationSoutenance.Models;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationSoutenance.Views
{
    public partial class frmDepartements : Form
    {
        public frmDepartements()
        {
            InitializeComponent();
        }
       BdSoutenanceContext bd = new BdSoutenanceContext();
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Departement d = new Departement();
            d.Libelle = txtLibelle.Text;
           bd.departements.Add(d);
            bd.SaveChanges();
            Effacer();


        }
        private void Effacer()
        {
            dgDepartement.DataSource = bd.departements.ToList();
            txtLibelle.Clear();
            txtLibelle.Focus();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgDepartement.CurrentRow.Cells[0].Value.ToString());
            Departement d = bd.departements.Find(id);
            d.Libelle = txtLibelle.Text;
            bd.SaveChanges();
            Effacer();

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int  id = int.Parse(dgDepartement.CurrentRow.Cells[0].Value.ToString());
            Departement d = bd.departements.Find(id);
            bd.departements.Remove(d);
            bd.SaveChanges();
            Effacer();
        }

        private void btnSlectionner_Click(object sender, EventArgs e)
        {
            int ? id = int.Parse(dgDepartement.CurrentRow.Cells[0].Value.ToString());
            Departement d = bd.departements.Find(id);
            txtLibelle.Text = d.Libelle;

        }

        private void frmDepartements_Load(object sender, EventArgs e)
        {
           Effacer();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            // Récupère toutes les Libelle Departement depuis la base de données
            var liste = bd.departements.ToList();

            // Vérifie si un texte de recherche sur le libellé de la Libelle Departement a été saisi
            if (!string.IsNullOrEmpty(txtRLibelle.Text))
            {
                // Filtre la liste des Libelle Departement dont le libellé contient le texte recherché
                liste = liste
                    .Where(s => s.Libelle.Contains(txtRLibelle.Text))
                    .ToList();
            }

           

            // Affiche la liste filtrée dans le DataGridView
            dgDepartement.DataSource = liste;
        }
    }
}
