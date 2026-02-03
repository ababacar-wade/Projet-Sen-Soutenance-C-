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
            this.dgCandidats = new System.Windows.Forms.DataGridView();
            this.panelLeftCandidat = new System.Windows.Forms.Panel();
            this.panelFormCandidat = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.panelButtonsCandidat = new System.Windows.Forms.Panel();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.tabProfesseur = new System.Windows.Forms.TabPage();
            this.dgProfesseurs = new System.Windows.Forms.DataGridView();
            this.panelLeftProfesseur = new System.Windows.Forms.Panel();
            this.panelFormProfesseur = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPNom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPPrenom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPSpecialite = new System.Windows.Forms.TextBox();
            this.panelButtonsProfesseur = new System.Windows.Forms.Panel();
            this.btnPAjouter = new System.Windows.Forms.Button();
            this.btnPModifier = new System.Windows.Forms.Button();
            this.btnPSupprimer = new System.Windows.Forms.Button();
            this.btnPSelectionne = new System.Windows.Forms.Button();
            this.tabChefDepartement = new System.Windows.Forms.TabPage();
            this.dgChefDepartements = new System.Windows.Forms.DataGridView();
            this.panelLeftChef = new System.Windows.Forms.Panel();
            this.panelFormChef = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCNom = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCPrenom = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCTel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxDepartement = new System.Windows.Forms.ComboBox();
            this.panelButtonsChef = new System.Windows.Forms.Panel();
            this.btnCAjouter = new System.Windows.Forms.Button();
            this.btnCModifier = new System.Windows.Forms.Button();
            this.btnCSupprimer = new System.Windows.Forms.Button();
            this.btnCSelectionner = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabCandidat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCandidats)).BeginInit();
            this.panelLeftCandidat.SuspendLayout();
            this.panelFormCandidat.SuspendLayout();
            this.panelButtonsCandidat.SuspendLayout();
            this.tabProfesseur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesseurs)).BeginInit();
            this.panelLeftProfesseur.SuspendLayout();
            this.panelFormProfesseur.SuspendLayout();
            this.panelButtonsProfesseur.SuspendLayout();
            this.tabChefDepartement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChefDepartements)).BeginInit();
            this.panelLeftChef.SuspendLayout();
            this.panelFormChef.SuspendLayout();
            this.panelButtonsChef.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCandidat);
            this.tabControl1.Controls.Add(this.tabProfesseur);
            this.tabControl1.Controls.Add(this.tabChefDepartement);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 123);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1924, 700);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabCandidat
            // 
            this.tabCandidat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabCandidat.Controls.Add(this.dgCandidats);
            this.tabCandidat.Controls.Add(this.panelLeftCandidat);
            this.tabCandidat.Location = new System.Drawing.Point(4, 37);
            this.tabCandidat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabCandidat.Name = "tabCandidat";
            this.tabCandidat.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabCandidat.Size = new System.Drawing.Size(1916, 659);
            this.tabCandidat.TabIndex = 0;
            this.tabCandidat.Text = "Candidat";
            // 
            // dgCandidats
            // 
            this.dgCandidats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCandidats.BackgroundColor = System.Drawing.Color.White;
            this.dgCandidats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCandidats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCandidats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCandidats.Location = new System.Drawing.Point(649, 5);
            this.dgCandidats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgCandidats.Name = "dgCandidats";
            this.dgCandidats.RowHeadersWidth = 62;
            this.dgCandidats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCandidats.Size = new System.Drawing.Size(1263, 649);
            this.dgCandidats.TabIndex = 1;
            // 
            // panelLeftCandidat
            // 
            this.panelLeftCandidat.Controls.Add(this.panelFormCandidat);
            this.panelLeftCandidat.Controls.Add(this.panelButtonsCandidat);
            this.panelLeftCandidat.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftCandidat.Location = new System.Drawing.Point(4, 5);
            this.panelLeftCandidat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLeftCandidat.Name = "panelLeftCandidat";
            this.panelLeftCandidat.Size = new System.Drawing.Size(645, 649);
            this.panelLeftCandidat.TabIndex = 4;
            // 
            // panelFormCandidat
            // 
            this.panelFormCandidat.BackColor = System.Drawing.Color.White;
            this.panelFormCandidat.Controls.Add(this.label1);
            this.panelFormCandidat.Controls.Add(this.txtNom);
            this.panelFormCandidat.Controls.Add(this.label2);
            this.panelFormCandidat.Controls.Add(this.txtPrenom);
            this.panelFormCandidat.Controls.Add(this.label3);
            this.panelFormCandidat.Controls.Add(this.txtEmail);
            this.panelFormCandidat.Controls.Add(this.label4);
            this.panelFormCandidat.Controls.Add(this.txtTel);
            this.panelFormCandidat.Controls.Add(this.label5);
            this.panelFormCandidat.Controls.Add(this.txtMatricule);
            this.panelFormCandidat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormCandidat.Location = new System.Drawing.Point(0, 0);
            this.panelFormCandidat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFormCandidat.Name = "panelFormCandidat";
            this.panelFormCandidat.Size = new System.Drawing.Size(645, 513);
            this.panelFormCandidat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(32, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNom.Location = new System.Drawing.Point(32, 46);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(532, 34);
            this.txtNom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(32, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrenom.Location = new System.Drawing.Point(32, 146);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(532, 34);
            this.txtPrenom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(32, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(32, 246);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(532, 34);
            this.txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(32, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telephone";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTel.Location = new System.Drawing.Point(32, 346);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(532, 34);
            this.txtTel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label5.Location = new System.Drawing.Point(32, 408);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Matricule";
            // 
            // txtMatricule
            // 
            this.txtMatricule.Enabled = false;
            this.txtMatricule.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatricule.Location = new System.Drawing.Point(32, 446);
            this.txtMatricule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(532, 34);
            this.txtMatricule.TabIndex = 9;
            // 
            // panelButtonsCandidat
            // 
            this.panelButtonsCandidat.BackColor = System.Drawing.Color.White;
            this.panelButtonsCandidat.Controls.Add(this.btnAjouter);
            this.panelButtonsCandidat.Controls.Add(this.btnModifier);
            this.panelButtonsCandidat.Controls.Add(this.btnSupprimer);
            this.panelButtonsCandidat.Controls.Add(this.btnSelectionner);
            this.panelButtonsCandidat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtonsCandidat.Location = new System.Drawing.Point(0, 513);
            this.panelButtonsCandidat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelButtonsCandidat.Name = "panelButtonsCandidat";
            this.panelButtonsCandidat.Size = new System.Drawing.Size(645, 136);
            this.panelButtonsCandidat.TabIndex = 3;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(36, 10);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(240, 62);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            this.btnAjouter.MouseEnter += new System.EventHandler(this.btnAjouter_MouseEnter);
            this.btnAjouter.MouseLeave += new System.EventHandler(this.btnAjouter_MouseLeave);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(324, 10);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(240, 62);
            this.btnModifier.TabIndex = 11;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            this.btnModifier.MouseEnter += new System.EventHandler(this.btnModifier_MouseEnter);
            this.btnModifier.MouseLeave += new System.EventHandler(this.btnModifier_MouseLeave);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(36, 83);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(240, 62);
            this.btnSupprimer.TabIndex = 12;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            this.btnSupprimer.MouseEnter += new System.EventHandler(this.btnSupprimer_MouseEnter);
            this.btnSupprimer.MouseLeave += new System.EventHandler(this.btnSupprimer_MouseLeave);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSelectionner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectionner.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSelectionner.ForeColor = System.Drawing.Color.White;
            this.btnSelectionner.Location = new System.Drawing.Point(324, 83);
            this.btnSelectionner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(240, 62);
            this.btnSelectionner.TabIndex = 2;
            this.btnSelectionner.Text = "Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = false;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            this.btnSelectionner.MouseEnter += new System.EventHandler(this.btnSelectionner_MouseEnter);
            this.btnSelectionner.MouseLeave += new System.EventHandler(this.btnSelectionner_MouseLeave);
            // 
            // tabProfesseur
            // 
            this.tabProfesseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabProfesseur.Controls.Add(this.dgProfesseurs);
            this.tabProfesseur.Controls.Add(this.panelLeftProfesseur);
            this.tabProfesseur.Location = new System.Drawing.Point(4, 37);
            this.tabProfesseur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabProfesseur.Name = "tabProfesseur";
            this.tabProfesseur.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabProfesseur.Size = new System.Drawing.Size(1916, 659);
            this.tabProfesseur.TabIndex = 1;
            this.tabProfesseur.Text = "Professeur";
            // 
            // dgProfesseurs
            // 
            this.dgProfesseurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProfesseurs.BackgroundColor = System.Drawing.Color.White;
            this.dgProfesseurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProfesseurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProfesseurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProfesseurs.Location = new System.Drawing.Point(649, 5);
            this.dgProfesseurs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgProfesseurs.Name = "dgProfesseurs";
            this.dgProfesseurs.RowHeadersWidth = 62;
            this.dgProfesseurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProfesseurs.Size = new System.Drawing.Size(1263, 649);
            this.dgProfesseurs.TabIndex = 27;
            // 
            // panelLeftProfesseur
            // 
            this.panelLeftProfesseur.Controls.Add(this.panelFormProfesseur);
            this.panelLeftProfesseur.Controls.Add(this.panelButtonsProfesseur);
            this.panelLeftProfesseur.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftProfesseur.Location = new System.Drawing.Point(4, 5);
            this.panelLeftProfesseur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLeftProfesseur.Name = "panelLeftProfesseur";
            this.panelLeftProfesseur.Size = new System.Drawing.Size(645, 649);
            this.panelLeftProfesseur.TabIndex = 1;
            // 
            // panelFormProfesseur
            // 
            this.panelFormProfesseur.BackColor = System.Drawing.Color.White;
            this.panelFormProfesseur.Controls.Add(this.label10);
            this.panelFormProfesseur.Controls.Add(this.txtPNom);
            this.panelFormProfesseur.Controls.Add(this.label9);
            this.panelFormProfesseur.Controls.Add(this.txtPPrenom);
            this.panelFormProfesseur.Controls.Add(this.label8);
            this.panelFormProfesseur.Controls.Add(this.txtPEmail);
            this.panelFormProfesseur.Controls.Add(this.label7);
            this.panelFormProfesseur.Controls.Add(this.txtPTel);
            this.panelFormProfesseur.Controls.Add(this.label6);
            this.panelFormProfesseur.Controls.Add(this.txtPSpecialite);
            this.panelFormProfesseur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormProfesseur.Location = new System.Drawing.Point(0, 0);
            this.panelFormProfesseur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFormProfesseur.Name = "panelFormProfesseur";
            this.panelFormProfesseur.Size = new System.Drawing.Size(645, 513);
            this.panelFormProfesseur.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label10.Location = new System.Drawing.Point(32, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 28);
            this.label10.TabIndex = 13;
            this.label10.Text = "Nom";
            // 
            // txtPNom
            // 
            this.txtPNom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPNom.Location = new System.Drawing.Point(32, 47);
            this.txtPNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPNom.Name = "txtPNom";
            this.txtPNom.Size = new System.Drawing.Size(532, 34);
            this.txtPNom.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label9.Location = new System.Drawing.Point(32, 109);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 28);
            this.label9.TabIndex = 15;
            this.label9.Text = "Prenom";
            // 
            // txtPPrenom
            // 
            this.txtPPrenom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPPrenom.Location = new System.Drawing.Point(32, 147);
            this.txtPPrenom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPPrenom.Name = "txtPPrenom";
            this.txtPPrenom.Size = new System.Drawing.Size(532, 34);
            this.txtPPrenom.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label8.Location = new System.Drawing.Point(32, 209);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 28);
            this.label8.TabIndex = 17;
            this.label8.Text = "Email";
            // 
            // txtPEmail
            // 
            this.txtPEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPEmail.Location = new System.Drawing.Point(32, 247);
            this.txtPEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPEmail.Name = "txtPEmail";
            this.txtPEmail.Size = new System.Drawing.Size(532, 34);
            this.txtPEmail.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label7.Location = new System.Drawing.Point(32, 309);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "Telephone";
            // 
            // txtPTel
            // 
            this.txtPTel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPTel.Location = new System.Drawing.Point(32, 347);
            this.txtPTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPTel.Name = "txtPTel";
            this.txtPTel.Size = new System.Drawing.Size(532, 34);
            this.txtPTel.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label6.Location = new System.Drawing.Point(32, 409);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 28);
            this.label6.TabIndex = 21;
            this.label6.Text = "Specialite";
            // 
            // txtPSpecialite
            // 
            this.txtPSpecialite.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPSpecialite.Location = new System.Drawing.Point(32, 447);
            this.txtPSpecialite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPSpecialite.Name = "txtPSpecialite";
            this.txtPSpecialite.Size = new System.Drawing.Size(532, 34);
            this.txtPSpecialite.TabIndex = 22;
            // 
            // panelButtonsProfesseur
            // 
            this.panelButtonsProfesseur.BackColor = System.Drawing.Color.White;
            this.panelButtonsProfesseur.Controls.Add(this.btnPAjouter);
            this.panelButtonsProfesseur.Controls.Add(this.btnPModifier);
            this.panelButtonsProfesseur.Controls.Add(this.btnPSupprimer);
            this.panelButtonsProfesseur.Controls.Add(this.btnPSelectionne);
            this.panelButtonsProfesseur.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtonsProfesseur.Location = new System.Drawing.Point(0, 513);
            this.panelButtonsProfesseur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelButtonsProfesseur.Name = "panelButtonsProfesseur";
            this.panelButtonsProfesseur.Size = new System.Drawing.Size(645, 136);
            this.panelButtonsProfesseur.TabIndex = 1;
            // 
            // btnPAjouter
            // 
            this.btnPAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnPAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPAjouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPAjouter.ForeColor = System.Drawing.Color.White;
            this.btnPAjouter.Location = new System.Drawing.Point(36, 10);
            this.btnPAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPAjouter.Name = "btnPAjouter";
            this.btnPAjouter.Size = new System.Drawing.Size(240, 62);
            this.btnPAjouter.TabIndex = 23;
            this.btnPAjouter.Text = "Ajouter";
            this.btnPAjouter.UseVisualStyleBackColor = false;
            this.btnPAjouter.Click += new System.EventHandler(this.btnPAjouter_Click);
            this.btnPAjouter.MouseEnter += new System.EventHandler(this.btnPAjouter_MouseEnter);
            this.btnPAjouter.MouseLeave += new System.EventHandler(this.btnPAjouter_MouseLeave);
            // 
            // btnPModifier
            // 
            this.btnPModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnPModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPModifier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPModifier.ForeColor = System.Drawing.Color.White;
            this.btnPModifier.Location = new System.Drawing.Point(324, 10);
            this.btnPModifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPModifier.Name = "btnPModifier";
            this.btnPModifier.Size = new System.Drawing.Size(240, 62);
            this.btnPModifier.TabIndex = 24;
            this.btnPModifier.Text = "Modifier";
            this.btnPModifier.UseVisualStyleBackColor = false;
            this.btnPModifier.Click += new System.EventHandler(this.btnPModifier_Click);
            this.btnPModifier.MouseEnter += new System.EventHandler(this.btnPModifier_MouseEnter);
            this.btnPModifier.MouseLeave += new System.EventHandler(this.btnPModifier_MouseLeave);
            // 
            // btnPSupprimer
            // 
            this.btnPSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnPSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPSupprimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnPSupprimer.Location = new System.Drawing.Point(36, 83);
            this.btnPSupprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPSupprimer.Name = "btnPSupprimer";
            this.btnPSupprimer.Size = new System.Drawing.Size(240, 62);
            this.btnPSupprimer.TabIndex = 25;
            this.btnPSupprimer.Text = "Supprimer";
            this.btnPSupprimer.UseVisualStyleBackColor = false;
            this.btnPSupprimer.Click += new System.EventHandler(this.btnPSupprimer_Click);
            this.btnPSupprimer.MouseEnter += new System.EventHandler(this.btnPSupprimer_MouseEnter);
            this.btnPSupprimer.MouseLeave += new System.EventHandler(this.btnPSupprimer_MouseLeave);
            // 
            // btnPSelectionne
            // 
            this.btnPSelectionne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnPSelectionne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPSelectionne.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPSelectionne.ForeColor = System.Drawing.Color.White;
            this.btnPSelectionne.Location = new System.Drawing.Point(324, 83);
            this.btnPSelectionne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPSelectionne.Name = "btnPSelectionne";
            this.btnPSelectionne.Size = new System.Drawing.Size(240, 62);
            this.btnPSelectionne.TabIndex = 26;
            this.btnPSelectionne.Text = "Selectionner";
            this.btnPSelectionne.UseVisualStyleBackColor = false;
            this.btnPSelectionne.Click += new System.EventHandler(this.btnPSelectionne_Click);
            this.btnPSelectionne.MouseEnter += new System.EventHandler(this.btnPSelectionne_MouseEnter);
            this.btnPSelectionne.MouseLeave += new System.EventHandler(this.btnPSelectionne_MouseLeave);
            // 
            // tabChefDepartement
            // 
            this.tabChefDepartement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabChefDepartement.Controls.Add(this.dgChefDepartements);
            this.tabChefDepartement.Controls.Add(this.panelLeftChef);
            this.tabChefDepartement.Location = new System.Drawing.Point(4, 37);
            this.tabChefDepartement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabChefDepartement.Name = "tabChefDepartement";
            this.tabChefDepartement.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabChefDepartement.Size = new System.Drawing.Size(1916, 659);
            this.tabChefDepartement.TabIndex = 2;
            this.tabChefDepartement.Text = "Chef Departement";
            // 
            // dgChefDepartements
            // 
            this.dgChefDepartements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChefDepartements.BackgroundColor = System.Drawing.Color.White;
            this.dgChefDepartements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgChefDepartements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChefDepartements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgChefDepartements.Location = new System.Drawing.Point(649, 5);
            this.dgChefDepartements.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgChefDepartements.Name = "dgChefDepartements";
            this.dgChefDepartements.RowHeadersWidth = 62;
            this.dgChefDepartements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChefDepartements.Size = new System.Drawing.Size(1263, 649);
            this.dgChefDepartements.TabIndex = 41;
            // 
            // panelLeftChef
            // 
            this.panelLeftChef.Controls.Add(this.panelFormChef);
            this.panelLeftChef.Controls.Add(this.panelButtonsChef);
            this.panelLeftChef.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftChef.Location = new System.Drawing.Point(4, 5);
            this.panelLeftChef.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLeftChef.Name = "panelLeftChef";
            this.panelLeftChef.Size = new System.Drawing.Size(645, 649);
            this.panelLeftChef.TabIndex = 1;
            // 
            // panelFormChef
            // 
            this.panelFormChef.BackColor = System.Drawing.Color.White;
            this.panelFormChef.Controls.Add(this.label15);
            this.panelFormChef.Controls.Add(this.txtCNom);
            this.panelFormChef.Controls.Add(this.label14);
            this.panelFormChef.Controls.Add(this.txtCPrenom);
            this.panelFormChef.Controls.Add(this.label13);
            this.panelFormChef.Controls.Add(this.txtCEmail);
            this.panelFormChef.Controls.Add(this.label12);
            this.panelFormChef.Controls.Add(this.txtCTel);
            this.panelFormChef.Controls.Add(this.label11);
            this.panelFormChef.Controls.Add(this.cbxDepartement);
            this.panelFormChef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormChef.Location = new System.Drawing.Point(0, 0);
            this.panelFormChef.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelFormChef.Name = "panelFormChef";
            this.panelFormChef.Size = new System.Drawing.Size(645, 515);
            this.panelFormChef.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label15.Location = new System.Drawing.Point(30, 9);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 28);
            this.label15.TabIndex = 26;
            this.label15.Text = "Nom";
            // 
            // txtCNom
            // 
            this.txtCNom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCNom.Location = new System.Drawing.Point(30, 47);
            this.txtCNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCNom.Name = "txtCNom";
            this.txtCNom.Size = new System.Drawing.Size(532, 34);
            this.txtCNom.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label14.Location = new System.Drawing.Point(30, 109);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 28);
            this.label14.TabIndex = 28;
            this.label14.Text = "Prenom";
            // 
            // txtCPrenom
            // 
            this.txtCPrenom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCPrenom.Location = new System.Drawing.Point(30, 147);
            this.txtCPrenom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCPrenom.Name = "txtCPrenom";
            this.txtCPrenom.Size = new System.Drawing.Size(532, 34);
            this.txtCPrenom.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label13.Location = new System.Drawing.Point(30, 209);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 28);
            this.label13.TabIndex = 30;
            this.label13.Text = "Email";
            // 
            // txtCEmail
            // 
            this.txtCEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCEmail.Location = new System.Drawing.Point(30, 247);
            this.txtCEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCEmail.Name = "txtCEmail";
            this.txtCEmail.Size = new System.Drawing.Size(532, 34);
            this.txtCEmail.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label12.Location = new System.Drawing.Point(30, 309);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 28);
            this.label12.TabIndex = 32;
            this.label12.Text = "Telephone";
            // 
            // txtCTel
            // 
            this.txtCTel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCTel.Location = new System.Drawing.Point(30, 347);
            this.txtCTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCTel.Name = "txtCTel";
            this.txtCTel.Size = new System.Drawing.Size(532, 34);
            this.txtCTel.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label11.Location = new System.Drawing.Point(30, 409);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 28);
            this.label11.TabIndex = 34;
            this.label11.Text = "Departement";
            // 
            // cbxDepartement
            // 
            this.cbxDepartement.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxDepartement.FormattingEnabled = true;
            this.cbxDepartement.Location = new System.Drawing.Point(30, 447);
            this.cbxDepartement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxDepartement.Name = "cbxDepartement";
            this.cbxDepartement.Size = new System.Drawing.Size(532, 36);
            this.cbxDepartement.TabIndex = 39;
            // 
            // panelButtonsChef
            // 
            this.panelButtonsChef.BackColor = System.Drawing.Color.White;
            this.panelButtonsChef.Controls.Add(this.btnCAjouter);
            this.panelButtonsChef.Controls.Add(this.btnCModifier);
            this.panelButtonsChef.Controls.Add(this.btnCSupprimer);
            this.panelButtonsChef.Controls.Add(this.btnCSelectionner);
            this.panelButtonsChef.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtonsChef.Location = new System.Drawing.Point(0, 515);
            this.panelButtonsChef.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelButtonsChef.Name = "panelButtonsChef";
            this.panelButtonsChef.Size = new System.Drawing.Size(645, 134);
            this.panelButtonsChef.TabIndex = 1;
            // 
            // btnCAjouter
            // 
            this.btnCAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnCAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCAjouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCAjouter.ForeColor = System.Drawing.Color.White;
            this.btnCAjouter.Location = new System.Drawing.Point(35, 10);
            this.btnCAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCAjouter.Name = "btnCAjouter";
            this.btnCAjouter.Size = new System.Drawing.Size(240, 62);
            this.btnCAjouter.TabIndex = 36;
            this.btnCAjouter.Text = "Ajouter";
            this.btnCAjouter.UseVisualStyleBackColor = false;
            this.btnCAjouter.Click += new System.EventHandler(this.btnCAjouter_Click);
            this.btnCAjouter.MouseEnter += new System.EventHandler(this.btnCAjouter_MouseEnter);
            this.btnCAjouter.MouseLeave += new System.EventHandler(this.btnCAjouter_MouseLeave);
            // 
            // btnCModifier
            // 
            this.btnCModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnCModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCModifier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCModifier.ForeColor = System.Drawing.Color.White;
            this.btnCModifier.Location = new System.Drawing.Point(323, 10);
            this.btnCModifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCModifier.Name = "btnCModifier";
            this.btnCModifier.Size = new System.Drawing.Size(240, 62);
            this.btnCModifier.TabIndex = 37;
            this.btnCModifier.Text = "Modifier";
            this.btnCModifier.UseVisualStyleBackColor = false;
            this.btnCModifier.Click += new System.EventHandler(this.btnCModifier_Click);
            this.btnCModifier.MouseEnter += new System.EventHandler(this.btnCModifier_MouseEnter);
            this.btnCModifier.MouseLeave += new System.EventHandler(this.btnCModifier_MouseLeave);
            // 
            // btnCSupprimer
            // 
            this.btnCSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCSupprimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnCSupprimer.Location = new System.Drawing.Point(34, 82);
            this.btnCSupprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCSupprimer.Name = "btnCSupprimer";
            this.btnCSupprimer.Size = new System.Drawing.Size(240, 62);
            this.btnCSupprimer.TabIndex = 38;
            this.btnCSupprimer.Text = "Supprimer";
            this.btnCSupprimer.UseVisualStyleBackColor = false;
            this.btnCSupprimer.Click += new System.EventHandler(this.btnCSupprimer_Click);
            this.btnCSupprimer.MouseEnter += new System.EventHandler(this.btnCSupprimer_MouseEnter);
            this.btnCSupprimer.MouseLeave += new System.EventHandler(this.btnCSupprimer_MouseLeave);
            // 
            // btnCSelectionner
            // 
            this.btnCSelectionner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCSelectionner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCSelectionner.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCSelectionner.ForeColor = System.Drawing.Color.White;
            this.btnCSelectionner.Location = new System.Drawing.Point(322, 82);
            this.btnCSelectionner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCSelectionner.Name = "btnCSelectionner";
            this.btnCSelectionner.Size = new System.Drawing.Size(240, 62);
            this.btnCSelectionner.TabIndex = 40;
            this.btnCSelectionner.Text = "Selectionner";
            this.btnCSelectionner.UseVisualStyleBackColor = false;
            this.btnCSelectionner.Click += new System.EventHandler(this.button2_Click);
            this.btnCSelectionner.MouseEnter += new System.EventHandler(this.btnCSelectionner_MouseEnter);
            this.btnCSelectionner.MouseLeave += new System.EventHandler(this.btnCSelectionner_MouseLeave);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.lblTitre);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1924, 123);
            this.panelHeader.TabIndex = 1;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(45, 31);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(467, 54);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Gestion des Utilisateurs";
            // 
            // frmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 823);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUtilisateur";
            this.Text = "Gestion des Utilisateurs";
            this.Load += new System.EventHandler(this.frmUtilisateur_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCandidat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCandidats)).EndInit();
            this.panelLeftCandidat.ResumeLayout(false);
            this.panelFormCandidat.ResumeLayout(false);
            this.panelFormCandidat.PerformLayout();
            this.panelButtonsCandidat.ResumeLayout(false);
            this.tabProfesseur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesseurs)).EndInit();
            this.panelLeftProfesseur.ResumeLayout(false);
            this.panelFormProfesseur.ResumeLayout(false);
            this.panelFormProfesseur.PerformLayout();
            this.panelButtonsProfesseur.ResumeLayout(false);
            this.tabChefDepartement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgChefDepartements)).EndInit();
            this.panelLeftChef.ResumeLayout(false);
            this.panelFormChef.ResumeLayout(false);
            this.panelFormChef.PerformLayout();
            this.panelButtonsChef.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCandidat;
        private System.Windows.Forms.TabPage tabProfesseur;
        private System.Windows.Forms.TabPage tabChefDepartement;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitre;

        // Candidat Controls
        private System.Windows.Forms.Panel panelLeftCandidat;
        private System.Windows.Forms.Panel panelFormCandidat;
        private System.Windows.Forms.Panel panelButtonsCandidat;
        private System.Windows.Forms.DataGridView dgCandidats;
        
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
        private System.Windows.Forms.Button btnSelectionner;

        // Professeur Controls
        private System.Windows.Forms.Panel panelLeftProfesseur;
        private System.Windows.Forms.Panel panelFormProfesseur;
        private System.Windows.Forms.Panel panelButtonsProfesseur;
        private System.Windows.Forms.DataGridView dgProfesseurs;

        private System.Windows.Forms.Button btnPSupprimer;
        private System.Windows.Forms.Button btnPModifier;
        private System.Windows.Forms.Button btnPAjouter;
        private System.Windows.Forms.Button btnPSelectionne;
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

        // Chef Departement Controls
        private System.Windows.Forms.Panel panelLeftChef;
        private System.Windows.Forms.Panel panelFormChef;
        private System.Windows.Forms.Panel panelButtonsChef;
        private System.Windows.Forms.DataGridView dgChefDepartements;

        private System.Windows.Forms.Button btnCSupprimer;
        private System.Windows.Forms.Button btnCModifier;
        private System.Windows.Forms.Button btnCAjouter;
        private System.Windows.Forms.Button btnCSelectionner;
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
    }
}