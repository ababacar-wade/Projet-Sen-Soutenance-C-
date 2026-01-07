using System;
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
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }
        // la methode pour quitter l'application
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //la methode pour se connecter sur l'application
        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            frmMdi f = new frmMdi();
            f.Show();
            this.Hide();
        }
    }
}
