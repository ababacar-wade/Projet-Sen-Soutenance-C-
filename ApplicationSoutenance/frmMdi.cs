using ApplicationSoutenance.Views.Parametre;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationSoutenance
{
    public partial class frmMdi : Form
    {
        public frmMdi()
        {
            InitializeComponent();
        }
        
        //la methode pour quitter l'application
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // la methode pour se deconnecter 
        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnexion f = new frmConnexion();
            f.Show();
            this.Close();
        }

        /// <summary>
        /// la methode pour afficher le formulaire annee academique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void anneeAcademiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pour fermer tous les autres formulaires ouverts
            fermer();
            // instancifier le formulaire annee academique
            frmAnneeAcademique f = new frmAnneeAcademique();
            //on dit a l'objet f qu'on a cree, voici votre pere (frmMdi)
            f.MdiParent = this;
            // afficher
            f.Show();
            //on demande a l'objet d'occuper tout espace disponible
            f.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// la methode pour afficher la session
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmSession f = new frmSession();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// la methode pour afficher le formulaire du professeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void professeursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmProfesseur f = new frmProfesseur();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// methode permettant de fermer tous les forms dans le parentmdi
        /// </summary>
        private void fermer()
        {
            Form[] charr = this.MdiChildren;

            //For each child form set the window state to Maximized 
            foreach (Form chform in charr)
            {
                //chform.WindowState = FormWindowState.Maximized;
                chform.Close();
            }
        }

        /// <summary>
        /// methode quand le formulaire souvre il prend tout lecran
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMdi_Load(object sender, EventArgs e)
        {
            //si computer n'est pas charge -> reference (chercher visual et importer pour qu'il l prend en compte)
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);
        }
    }
}
