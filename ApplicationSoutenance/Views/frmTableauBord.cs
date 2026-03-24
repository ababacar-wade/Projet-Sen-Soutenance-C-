using ApplicationSoutenance.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ApplicationSoutenance.Views
{
    public partial class frmTableauBord : Form
    {
        public string profil;
        BdSoutenanceContext bd = new BdSoutenanceContext();

        public frmTableauBord()
        {
            InitializeComponent();
        }

        private void frmTableauBord_Load(object sender, EventArgs e)
        {
            // Mise à jour de l'en-tête
            lblBienvenue.Text = $"Session active : {profil}";
            
            // Tenter de charger le logo généré
            string logoPath = @"C:\Users\MAIMOUNA SAM\.gemini\antigravity\brain\77517450-a669-4469-a8d7-a853c27599f9\school_logo_modern_1774363874547.png";
            if (File.Exists(logoPath))
            {
                pictureBoxLogo.Image = Image.FromFile(logoPath);
            }

            try
            {
                // Chargement des données
                int nbProfesseurs = bd.professeurs.Count();
                int nbMemoires = bd.memoires.Count();
                int nbSessions = bd.sessions.Count();
                int nbSoutenances = bd.soutenances.Count();

                // Configuration selon le profil
                if (profil == "Admin" || profil == "Chefdepartement")
                {
                    lblProfCount.Text = nbProfesseurs.ToString();
                    lblMemCount.Text = nbMemoires.ToString();
                    lblSessCount.Text = nbSessions.ToString();
                    lblSoutCount.Text = nbSoutenances.ToString();
                }
                else
                {
                    lblProfCount.Text = nbProfesseurs.ToString();
                    lblMemCount.Text = nbMemoires.ToString();
                    panelSess.Visible = false;
                    panelSout.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            // Dégradé pour le header (Bleu Profond vers Bleu Royal)
            using (LinearGradientBrush brush = new LinearGradientBrush(this.panelHeader.ClientRectangle,
                Color.FromArgb(41, 128, 185), Color.FromArgb(44, 62, 80), LinearGradientMode.ForwardDiagonal))
            {
                e.Graphics.FillRectangle(brush, this.panelHeader.ClientRectangle);
            }
        }

        private void CardPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            // Bordure arrondie douce et simulation d'ombre
            using (Pen pen = new Pen(Color.FromArgb(232, 236, 241), 2))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawRectangle(pen, 0, 0, panel.Width - 1, panel.Height - 1);
            }
        }
    }
}
