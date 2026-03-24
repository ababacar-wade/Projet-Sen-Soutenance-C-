using ApplicationSoutenance.Models;
using ApplicationSoutenance.Shared;
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
    public partial class frmMemoire : Form
    {
        public frmMemoire()
        {
            InitializeComponent();
        }

        BdSoutenanceContext bd = new BdSoutenanceContext();
        FillerList Filler = new FillerList();

        private void frmMemoire_Load(object sender, EventArgs e)
        {
            Effacer();
        }

        private void Effacer()
        {
            txtSujetMemoire.Clear();
            cbxAnneeAcademique.DataSource = Filler.fillAnneeAcademique();
            cbxAnneeAcademique.DisplayMember = "Text";
            cbxAnneeAcademique.ValueMember = "Value";
            cbxAnneeAcademique.SelectedValue = 0;

            cbxSession.DataSource = Filler.fillSession();
            cbxSession.DisplayMember = "Text";
            cbxSession.ValueMember = "Value";
            cbxSession.SelectedValue = 0;

            dgMemoire.DataSource = bd.memoires.Select(m => new
            {
                ID = m.IdMemoire,
                Sujet = m.SujetMemoire,
                Année = m.AnneeAcademique.LibelleAnneeAcademique,
                Session = m.Session != null ? m.Session.LibelleSession : ""
            }).ToList();
            txtSujetMemoire.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSujetMemoire.Text))
            {
                MessageBox.Show("Le sujet est obligatoire.");
                return;
            }
            if ((int)cbxAnneeAcademique.SelectedValue == 0)
            {
                MessageBox.Show("Veuillez sélectionner une année académique.");
                return;
            }

            Memoire m = new Memoire();
            m.SujetMemoire = txtSujetMemoire.Text;
            m.IdAnneeAcademique = (int)cbxAnneeAcademique.SelectedValue;
            int sessionId = (int)cbxSession.SelectedValue;
            if (sessionId != 0)
            {
                m.IdSession = sessionId;
            }
            else
            {
                m.IdSession = null;
            }

            bd.memoires.Add(m);
            bd.SaveChanges();
            Effacer();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgMemoire.CurrentRow == null) return;
            int id = int.Parse(dgMemoire.CurrentRow.Cells[0].Value.ToString());
            Memoire m = bd.memoires.Find(id);
            if (m != null)
            {
                m.SujetMemoire = txtSujetMemoire.Text;
                m.IdAnneeAcademique = (int)cbxAnneeAcademique.SelectedValue;
                int sessionId = (int)cbxSession.SelectedValue;
                if (sessionId != 0)
                {
                    m.IdSession = sessionId;
                }
                else
                {
                    m.IdSession = null;
                }
                bd.SaveChanges();
                Effacer();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgMemoire.CurrentRow == null) return;
            int id = int.Parse(dgMemoire.CurrentRow.Cells[0].Value.ToString());
            Memoire m = bd.memoires.Find(id);
            if (m != null)
            {
                bd.memoires.Remove(m);
                bd.SaveChanges();
                Effacer();
            }
        }

        private void btnSlectionner_Click(object sender, EventArgs e)
        {
            if (dgMemoire.CurrentRow == null) return;
            int id = int.Parse(dgMemoire.CurrentRow.Cells[0].Value.ToString());
            Memoire m = bd.memoires.Find(id);
            if (m != null)
            {
                txtSujetMemoire.Text = m.SujetMemoire;
                cbxAnneeAcademique.SelectedValue = m.IdAnneeAcademique;
                cbxSession.SelectedValue = m.IdSession ?? 0;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var liste = bd.memoires.ToList();

            if (!string.IsNullOrEmpty(txtRSujetMemoire.Text))
            {
                liste = liste.Where(m => m.SujetMemoire.ToLower().Contains(txtRSujetMemoire.Text.ToLower())).ToList();
            }

            if (!string.IsNullOrEmpty(txtRSession.Text))
            {
                liste = liste.Where(m => m.Session != null && m.Session.LibelleSession.ToLower().Contains(txtRSession.Text.ToLower())).ToList();
            }

            if (!string.IsNullOrEmpty(txtRAnneeAcademique.Text))
            {
                liste = liste.Where(m => m.AnneeAcademique.LibelleAnneeAcademique.ToLower().Contains(txtRAnneeAcademique.Text.ToLower())).ToList();
            }

            dgMemoire.DataSource = liste.Select(m => new
            {
                ID = m.IdMemoire,
                Sujet = m.SujetMemoire,
                Année = m.AnneeAcademique.LibelleAnneeAcademique,
                Session = m.Session != null ? m.Session.LibelleSession : ""
            }).ToList();
        }
    }
}
