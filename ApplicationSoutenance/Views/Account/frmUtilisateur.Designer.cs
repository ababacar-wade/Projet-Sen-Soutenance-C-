namespace AppSenSoutenance.Views.Account
{
    partial class frmUtilisateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCandidat = new System.Windows.Forms.TabPage();
            this.tabProfesseur = new System.Windows.Forms.TabPage();
            this.tabChefDepartement = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnPSupprimer = new System.Windows.Forms.Button();
            this.btnPModifier = new System.Windows.Forms.Button();
            this.btnPAjouter = new System.Windows.Forms.Button();
            this.txtPSpecialite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPTel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPPrenom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPNom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCSupprimer = new System.Windows.Forms.Button();
            this.btnCModifier = new System.Windows.Forms.Button();
            this.btnCAjouter = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCTel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCPrenom = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCNom = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgUtilisateur = new System.Windows.Forms.DataGridView();
            this.cbxDepartement = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabCandidat.SuspendLayout();
            this.tabProfesseur.SuspendLayout();
            this.tabChefDepartement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCandidat);
            this.tabControl1.Controls.Add(this.tabProfesseur);
            this.tabControl1.Controls.Add(this.tabChefDepartement);
            this.tabControl1.Location = new System.Drawing.Point(6, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(362, 615);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCandidat
            // 
            this.tabCandidat.Controls.Add(this.btnSupprimer);
            this.tabCandidat.Controls.Add(this.btnModifier);
            this.tabCandidat.Controls.Add(this.btnAjouter);
            this.tabCandidat.Controls.Add(this.txtMatricule);
            this.tabCandidat.Controls.Add(this.label5);
            this.tabCandidat.Controls.Add(this.txtTel);
            this.tabCandidat.Controls.Add(this.label4);
            this.tabCandidat.Controls.Add(this.txtEmail);
            this.tabCandidat.Controls.Add(this.label3);
            this.tabCandidat.Controls.Add(this.txtPrenom);
            this.tabCandidat.Controls.Add(this.label2);
            this.tabCandidat.Controls.Add(this.txtNom);
            this.tabCandidat.Controls.Add(this.label1);
            this.tabCandidat.Location = new System.Drawing.Point(4, 29);
            this.tabCandidat.Name = "tabCandidat";
            this.tabCandidat.Padding = new System.Windows.Forms.Padding(3);
            this.tabCandidat.Size = new System.Drawing.Size(354, 582);
            this.tabCandidat.TabIndex = 0;
            this.tabCandidat.Text = "Candindat";
            this.tabCandidat.UseVisualStyleBackColor = true;
            // 
            // tabProfesseur
            // 
            this.tabProfesseur.Controls.Add(this.btnPSupprimer);
            this.tabProfesseur.Controls.Add(this.btnPModifier);
            this.tabProfesseur.Controls.Add(this.btnPAjouter);
            this.tabProfesseur.Controls.Add(this.txtPSpecialite);
            this.tabProfesseur.Controls.Add(this.label6);
            this.tabProfesseur.Controls.Add(this.txtPTel);
            this.tabProfesseur.Controls.Add(this.label7);
            this.tabProfesseur.Controls.Add(this.txtPEmail);
            this.tabProfesseur.Controls.Add(this.label8);
            this.tabProfesseur.Controls.Add(this.txtPPrenom);
            this.tabProfesseur.Controls.Add(this.label9);
            this.tabProfesseur.Controls.Add(this.txtPNom);
            this.tabProfesseur.Controls.Add(this.label10);
            this.tabProfesseur.Location = new System.Drawing.Point(4, 29);
            this.tabProfesseur.Name = "tabProfesseur";
            this.tabProfesseur.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfesseur.Size = new System.Drawing.Size(354, 582);
            this.tabProfesseur.TabIndex = 1;
            this.tabProfesseur.Text = "Professeur";
            this.tabProfesseur.UseVisualStyleBackColor = true;
            // 
            // tabChefDepartement
            // 
            this.tabChefDepartement.Controls.Add(this.cbxDepartement);
            this.tabChefDepartement.Controls.Add(this.btnCSupprimer);
            this.tabChefDepartement.Controls.Add(this.btnCModifier);
            this.tabChefDepartement.Controls.Add(this.btnCAjouter);
            this.tabChefDepartement.Controls.Add(this.label11);
            this.tabChefDepartement.Controls.Add(this.txtCTel);
            this.tabChefDepartement.Controls.Add(this.label12);
            this.tabChefDepartement.Controls.Add(this.txtCEmail);
            this.tabChefDepartement.Controls.Add(this.label13);
            this.tabChefDepartement.Controls.Add(this.txtCPrenom);
            this.tabChefDepartement.Controls.Add(this.label14);
            this.tabChefDepartement.Controls.Add(this.txtCNom);
            this.tabChefDepartement.Controls.Add(this.label15);
            this.tabChefDepartement.Location = new System.Drawing.Point(4, 29);
            this.tabChefDepartement.Name = "tabChefDepartement";
            this.tabChefDepartement.Padding = new System.Windows.Forms.Padding(3);
            this.tabChefDepartement.Size = new System.Drawing.Size(354, 582);
            this.tabChefDepartement.TabIndex = 2;
            this.tabChefDepartement.Text = "Chef Departement";
            this.tabChefDepartement.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(24, 57);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(305, 26);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(24, 135);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(305, 26);
            this.txtPrenom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenom";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(24, 211);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(305, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(24, 284);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(305, 26);
            this.txtTel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telephone";
            // 
            // txtMatricule
            // 
            this.txtMatricule.Location = new System.Drawing.Point(24, 354);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(305, 26);
            this.txtMatricule.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Matricule";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(227, 415);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(102, 29);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(227, 471);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(102, 29);
            this.btnModifier.TabIndex = 11;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(227, 524);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(102, 29);
            this.btnSupprimer.TabIndex = 12;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnPSupprimer
            // 
            this.btnPSupprimer.Location = new System.Drawing.Point(220, 500);
            this.btnPSupprimer.Name = "btnPSupprimer";
            this.btnPSupprimer.Size = new System.Drawing.Size(102, 29);
            this.btnPSupprimer.TabIndex = 25;
            this.btnPSupprimer.Text = "&Supprimer";
            this.btnPSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnPModifier
            // 
            this.btnPModifier.Location = new System.Drawing.Point(220, 447);
            this.btnPModifier.Name = "btnPModifier";
            this.btnPModifier.Size = new System.Drawing.Size(102, 29);
            this.btnPModifier.TabIndex = 24;
            this.btnPModifier.Text = "&Modifier";
            this.btnPModifier.UseVisualStyleBackColor = true;
            // 
            // btnPAjouter
            // 
            this.btnPAjouter.Location = new System.Drawing.Point(220, 391);
            this.btnPAjouter.Name = "btnPAjouter";
            this.btnPAjouter.Size = new System.Drawing.Size(102, 29);
            this.btnPAjouter.TabIndex = 23;
            this.btnPAjouter.Text = "&Ajouter";
            this.btnPAjouter.UseVisualStyleBackColor = true;
            // 
            // txtPSpecialite
            // 
            this.txtPSpecialite.Location = new System.Drawing.Point(17, 330);
            this.txtPSpecialite.Name = "txtPSpecialite";
            this.txtPSpecialite.Size = new System.Drawing.Size(305, 26);
            this.txtPSpecialite.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Specialite";
            // 
            // txtPTel
            // 
            this.txtPTel.Location = new System.Drawing.Point(17, 260);
            this.txtPTel.Name = "txtPTel";
            this.txtPTel.Size = new System.Drawing.Size(305, 26);
            this.txtPTel.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Telephone";
            // 
            // txtPEmail
            // 
            this.txtPEmail.Location = new System.Drawing.Point(17, 187);
            this.txtPEmail.Name = "txtPEmail";
            this.txtPEmail.Size = new System.Drawing.Size(305, 26);
            this.txtPEmail.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Email";
            // 
            // txtPPrenom
            // 
            this.txtPPrenom.Location = new System.Drawing.Point(17, 111);
            this.txtPPrenom.Name = "txtPPrenom";
            this.txtPPrenom.Size = new System.Drawing.Size(305, 26);
            this.txtPPrenom.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Prenom";
            // 
            // txtPNom
            // 
            this.txtPNom.Location = new System.Drawing.Point(17, 33);
            this.txtPNom.Name = "txtPNom";
            this.txtPNom.Size = new System.Drawing.Size(305, 26);
            this.txtPNom.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Nom";
            // 
            // btnCSupprimer
            // 
            this.btnCSupprimer.Location = new System.Drawing.Point(223, 509);
            this.btnCSupprimer.Name = "btnCSupprimer";
            this.btnCSupprimer.Size = new System.Drawing.Size(102, 29);
            this.btnCSupprimer.TabIndex = 38;
            this.btnCSupprimer.Text = "&Supprimer";
            this.btnCSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnCModifier
            // 
            this.btnCModifier.Location = new System.Drawing.Point(223, 456);
            this.btnCModifier.Name = "btnCModifier";
            this.btnCModifier.Size = new System.Drawing.Size(102, 29);
            this.btnCModifier.TabIndex = 37;
            this.btnCModifier.Text = "&Modifier";
            this.btnCModifier.UseVisualStyleBackColor = true;
            // 
            // btnCAjouter
            // 
            this.btnCAjouter.Location = new System.Drawing.Point(223, 400);
            this.btnCAjouter.Name = "btnCAjouter";
            this.btnCAjouter.Size = new System.Drawing.Size(102, 29);
            this.btnCAjouter.TabIndex = 36;
            this.btnCAjouter.Text = "&Ajouter";
            this.btnCAjouter.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "Departement";
            // 
            // txtCTel
            // 
            this.txtCTel.Location = new System.Drawing.Point(24, 269);
            this.txtCTel.Name = "txtCTel";
            this.txtCTel.Size = new System.Drawing.Size(301, 26);
            this.txtCTel.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Telephone";
            // 
            // txtCEmail
            // 
            this.txtCEmail.Location = new System.Drawing.Point(24, 196);
            this.txtCEmail.Name = "txtCEmail";
            this.txtCEmail.Size = new System.Drawing.Size(301, 26);
            this.txtCEmail.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Email";
            // 
            // txtCPrenom
            // 
            this.txtCPrenom.Location = new System.Drawing.Point(24, 120);
            this.txtCPrenom.Name = "txtCPrenom";
            this.txtCPrenom.Size = new System.Drawing.Size(301, 26);
            this.txtCPrenom.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Prenom";
            // 
            // txtCNom
            // 
            this.txtCNom.Location = new System.Drawing.Point(24, 42);
            this.txtCNom.Name = "txtCNom";
            this.txtCNom.Size = new System.Drawing.Size(301, 26);
            this.txtCNom.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "Nom";
            // 
            // dgUtilisateur
            // 
            this.dgUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUtilisateur.Location = new System.Drawing.Point(389, 30);
            this.dgUtilisateur.Name = "dgUtilisateur";
            this.dgUtilisateur.RowHeadersWidth = 62;
            this.dgUtilisateur.RowTemplate.Height = 28;
            this.dgUtilisateur.Size = new System.Drawing.Size(727, 586);
            this.dgUtilisateur.TabIndex = 1;
            // 
            // cbxDepartement
            // 
            this.cbxDepartement.FormattingEnabled = true;
            this.cbxDepartement.Location = new System.Drawing.Point(24, 339);
            this.cbxDepartement.Name = "cbxDepartement";
            this.cbxDepartement.Size = new System.Drawing.Size(301, 28);
            this.cbxDepartement.TabIndex = 39;
            // 
            // frmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 628);
            this.ControlBox = false;
            this.Controls.Add(this.dgUtilisateur);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmUtilisateur";
            this.Text = "Gestion des utilisateur";
            this.Load += new System.EventHandler(this.frmUtilisateur_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCandidat.ResumeLayout(false);
            this.tabCandidat.PerformLayout();
            this.tabProfesseur.ResumeLayout(false);
            this.tabProfesseur.PerformLayout();
            this.tabChefDepartement.ResumeLayout(false);
            this.tabChefDepartement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCandidat;
        private System.Windows.Forms.TabPage tabProfesseur;
        private System.Windows.Forms.TabPage tabChefDepartement;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnPSupprimer;
        private System.Windows.Forms.Button btnPModifier;
        private System.Windows.Forms.Button btnPAjouter;
        private System.Windows.Forms.TextBox txtPSpecialite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPPrenom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPNom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCSupprimer;
        private System.Windows.Forms.Button btnCModifier;
        private System.Windows.Forms.Button btnCAjouter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCTel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCPrenom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCNom;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbxDepartement;
        private System.Windows.Forms.DataGridView dgUtilisateur;
    }
}