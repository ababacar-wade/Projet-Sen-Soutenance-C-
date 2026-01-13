namespace ApplicationSoutenance
{
    partial class frmConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            // Déclaration des contrôles du formulaire
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnSeConnecter = new System.Windows.Forms.Button();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();

            // Suspension de la mise en page pendant la configuration
            this.panelHeader.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelHeader - Panel d'en-tête (bandeau bleu en haut)
            // 
            // Couleur de fond bleu (RGB: 41, 128, 185)
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            // Ajoute le label titre dans le panel
            this.panelHeader.Controls.Add(this.lblTitre);
            // Ancre le panel en haut du formulaire (toute la largeur)
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            // Position du panel
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            // Taille du panel : largeur 810px, hauteur 100px
            this.panelHeader.Size = new System.Drawing.Size(810, 100);
            this.panelHeader.TabIndex = 11;

            // 
            // lblTitre - Label du titre "Sen Soutenance"
            // 
            this.lblTitre.AutoSize = true;
            // Police Segoe UI, taille 24, gras
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            // Couleur du texte : blanc
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            // Position du titre (centré horizontalement)
            this.lblTitre.Location = new System.Drawing.Point(220, 25);
            this.lblTitre.Name = "lblTitre";
            // Taille calculée automatiquement pour le texte
            this.lblTitre.Size = new System.Drawing.Size(370, 54);
            this.lblTitre.TabIndex = 0;
            // Texte affiché
            this.lblTitre.Text = "Sen Soutenance";

            // 
            // panelLogin - Panel blanc contenant le formulaire de connexion
            // 
            // Couleur de fond : blanc
            this.panelLogin.BackColor = System.Drawing.Color.White;
            // Ajout des contrôles dans le panel (labels, textbox, boutons)
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.txtIdentifiant);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.txtMotDePasse);
            this.panelLogin.Controls.Add(this.btnSeConnecter);
            this.panelLogin.Controls.Add(this.btnQuitter);
            // Position du panel (centré dans le formulaire)
            this.panelLogin.Location = new System.Drawing.Point(155, 150);
            this.panelLogin.Name = "panelLogin";
            // Taille du panel : 500x450 pixels
            this.panelLogin.Size = new System.Drawing.Size(500, 450);
            this.panelLogin.TabIndex = 12;

            // 
            // btnQuitter - Bouton Quitter (rouge)
            // 
            // Couleur de fond rouge (RGB: 231, 76, 60)
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            // Supprime la bordure du bouton
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            // Style plat (moderne, sans effet 3D)
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // Police Segoe UI, taille 12, gras
            this.btnQuitter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            // Couleur du texte : blanc
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            // Position du bouton (en bas à droite du panel)
            this.btnQuitter.Location = new System.Drawing.Point(270, 350);
            this.btnQuitter.Name = "btnQuitter";
            // Taille du bouton : 180x50 pixels
            this.btnQuitter.Size = new System.Drawing.Size(180, 50);
            this.btnQuitter.TabIndex = 10;
            // Texte affiché sur le bouton
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            // Événement Click : quitte l'application
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // Événement MouseEnter : change la couleur au survol
            this.btnQuitter.MouseEnter += new System.EventHandler(this.btnQuitter_MouseEnter);
            // Événement MouseLeave : restaure la couleur d'origine
            this.btnQuitter.MouseLeave += new System.EventHandler(this.btnQuitter_MouseLeave);

            // 
            // btnSeConnecter - Bouton Se connecter (vert)
            // 
            // Couleur de fond vert (RGB: 46, 204, 113)
            this.btnSeConnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            // Supprime la bordure du bouton
            this.btnSeConnecter.FlatAppearance.BorderSize = 0;
            // Style plat (moderne)
            this.btnSeConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // Police Segoe UI, taille 12, gras
            this.btnSeConnecter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            // Couleur du texte : blanc
            this.btnSeConnecter.ForeColor = System.Drawing.Color.White;
            // Position du bouton (en bas à gauche du panel)
            this.btnSeConnecter.Location = new System.Drawing.Point(50, 350);
            this.btnSeConnecter.Name = "btnSeConnecter";
            // Taille du bouton : 180x50 pixels
            this.btnSeConnecter.Size = new System.Drawing.Size(180, 50);
            this.btnSeConnecter.TabIndex = 9;
            // Texte affiché sur le bouton
            this.btnSeConnecter.Text = "Se connecter";
            this.btnSeConnecter.UseVisualStyleBackColor = false;
            // Événement Click : vérifie les identifiants et connecte l'utilisateur
            this.btnSeConnecter.Click += new System.EventHandler(this.btnSeConnecter_Click);
            // Événement MouseEnter : effet hover au survol
            this.btnSeConnecter.MouseEnter += new System.EventHandler(this.btnSeConnecter_MouseEnter);
            // Événement MouseLeave : restaure la couleur
            this.btnSeConnecter.MouseLeave += new System.EventHandler(this.btnSeConnecter_MouseLeave);

            // 
            // txtMotDePasse - Champ de saisie du mot de passe
            // 
            // Bordure simple et fine
            this.txtMotDePasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // Police Segoe UI, taille 12
            this.txtMotDePasse.Font = new System.Drawing.Font("Segoe UI", 12F);
            // Position du champ
            this.txtMotDePasse.Location = new System.Drawing.Point(50, 240);
            this.txtMotDePasse.Name = "txtMotDePasse";
            // Taille du champ : largeur 400px, hauteur 34px
            this.txtMotDePasse.Size = new System.Drawing.Size(400, 34);
            this.txtMotDePasse.TabIndex = 7;
            // Masque les caractères saisis (affiche des points ou étoiles)
            this.txtMotDePasse.UseSystemPasswordChar = true;

            // 
            // label2 - Label "Mot de passe"
            // 
            this.label2.AutoSize = true;
            // Police Segoe UI, taille 11
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            // Couleur du texte gris foncé (RGB: 52, 73, 94)
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            // Position du label (au-dessus du champ mot de passe)
            this.label2.Location = new System.Drawing.Point(46, 205);
            this.label2.Name = "label2";
            // Taille calculée automatiquement
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 8;
            // Texte affiché
            this.label2.Text = "Mot de passe";

            // 
            // txtIdentifiant - Champ de saisie de l'identifiant
            // 
            // Bordure simple et fine
            this.txtIdentifiant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // Police Segoe UI, taille 12
            this.txtIdentifiant.Font = new System.Drawing.Font("Segoe UI", 12F);
            // Position du champ
            this.txtIdentifiant.Location = new System.Drawing.Point(50, 130);
            this.txtIdentifiant.Name = "txtIdentifiant";
            // Taille du champ : largeur 400px, hauteur 34px
            this.txtIdentifiant.Size = new System.Drawing.Size(400, 34);
            this.txtIdentifiant.TabIndex = 6;

            // 
            // label1 - Label "Identifiant"
            // 
            this.label1.AutoSize = true;
            // Police Segoe UI, taille 11
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            // Couleur du texte gris foncé (RGB: 52, 73, 94)
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            // Position du label (au-dessus du champ identifiant)
            this.label1.Location = new System.Drawing.Point(46, 95);
            this.label1.Name = "label1";
            // Taille calculée automatiquement
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 5;
            // Texte affiché
            this.label1.Text = "Identifiant";

            // 
            // frmConnexion - Configuration du formulaire principal
            // 
            // Dimensions de mise à l'échelle automatique
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // Couleur de fond du formulaire gris clair (RGB: 236, 240, 241)
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            // Taille du formulaire : 810x650 pixels
            this.ClientSize = new System.Drawing.Size(810, 650);
            // Désactive les boutons minimiser/maximiser/fermer
            this.ControlBox = false;
            // Ajout des panels au formulaire
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelHeader);
            // Supprime la bordure du formulaire (pour un look moderne)
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConnexion";
            // Centre le formulaire à l'écran au démarrage
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            // Titre de la fenêtre (barre de titre)
            this.Text = "Sen Soutenance :: Connexion";

            // Reprise de la mise en page après configuration
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        // Déclaration des variables membres (contrôles)
        private System.Windows.Forms.Button btnQuitter;           // Bouton pour quitter l'application
        private System.Windows.Forms.Button btnSeConnecter;       // Bouton pour se connecter
        private System.Windows.Forms.TextBox txtMotDePasse;       // Champ de saisie du mot de passe
        private System.Windows.Forms.Label label2;                // Label "Mot de passe"
        private System.Windows.Forms.TextBox txtIdentifiant;      // Champ de saisie de l'identifiant
        private System.Windows.Forms.Label label1;                // Label "Identifiant"
        private System.Windows.Forms.Panel panelHeader;           // Panel d'en-tête (bandeau bleu)
        private System.Windows.Forms.Label lblTitre;              // Label du titre principal
        private System.Windows.Forms.Panel panelLogin;            // Panel blanc du formulaire de connexion
    }
}