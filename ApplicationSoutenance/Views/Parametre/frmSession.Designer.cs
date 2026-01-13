using System;

namespace ApplicationSoutenance.Views.Parametre
{
    partial class frmSession
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtRAnneeAcademique = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRSession = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxAnneeAcademique = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSlectionner = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgSession = new System.Windows.Forms.DataGridView();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgSession)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.lblTitre);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1170, 80);
            this.panelHeader.TabIndex = 34;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(30, 20);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(134, 46);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Session";
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.BackColor = System.Drawing.Color.White;
            this.panelSearch.Controls.Add(this.label3);
            this.panelSearch.Controls.Add(this.txtRSession);
            this.panelSearch.Controls.Add(this.label4);
            this.panelSearch.Controls.Add(this.txtRAnneeAcademique);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Location = new System.Drawing.Point(450, 110);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(690, 120);
            this.panelSearch.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(30, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Session";
            // 
            // txtRSession
            // 
            this.txtRSession.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRSession.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtRSession.Location = new System.Drawing.Point(30, 55);
            this.txtRSession.Name = "txtRSession";
            this.txtRSession.Size = new System.Drawing.Size(220, 32);
            this.txtRSession.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(270, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Année Académique";
            // 
            // txtRAnneeAcademique
            // 
            this.txtRAnneeAcademique.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRAnneeAcademique.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtRAnneeAcademique.Location = new System.Drawing.Point(270, 55);
            this.txtRAnneeAcademique.Name = "txtRAnneeAcademique";
            this.txtRAnneeAcademique.Size = new System.Drawing.Size(220, 32);
            this.txtRAnneeAcademique.TabIndex = 31;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(510, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 50);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseEnter += new System.EventHandler(this.btnSearch_MouseEnter);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            // 
            // panelForm
            // 
            this.panelForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.txtSession);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.cbxAnneeAcademique);
            this.panelForm.Location = new System.Drawing.Point(30, 110);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(400, 250);
            this.panelForm.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Session";
            // 
            // txtSession
            // 
            this.txtSession.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSession.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSession.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSession.Location = new System.Drawing.Point(30, 65);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(340, 32);
            this.txtSession.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(30, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Année Académique";
            // 
            // cbxAnneeAcademique
            // 
            this.cbxAnneeAcademique.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAnneeAcademique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAnneeAcademique.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbxAnneeAcademique.FormattingEnabled = true;
            this.cbxAnneeAcademique.Location = new System.Drawing.Point(30, 165);
            this.cbxAnneeAcademique.Name = "cbxAnneeAcademique";
            this.cbxAnneeAcademique.Size = new System.Drawing.Size(340, 33);
            this.cbxAnneeAcademique.TabIndex = 28;
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelButtons.BackColor = System.Drawing.Color.White;
            this.panelButtons.Controls.Add(this.btnSlectionner);
            this.panelButtons.Controls.Add(this.btnAjouter);
            this.panelButtons.Controls.Add(this.btnModifier);
            this.panelButtons.Controls.Add(this.btnSupprimer);
            this.panelButtons.Location = new System.Drawing.Point(30, 380);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(400, 250);
            this.panelButtons.TabIndex = 37;
            // 
            // btnSlectionner
            // 
            this.btnSlectionner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSlectionner.FlatAppearance.BorderSize = 0;
            this.btnSlectionner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlectionner.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSlectionner.ForeColor = System.Drawing.Color.White;
            this.btnSlectionner.Location = new System.Drawing.Point(210, 170);
            this.btnSlectionner.Name = "btnSlectionner";
            this.btnSlectionner.Size = new System.Drawing.Size(160, 50);
            this.btnSlectionner.TabIndex = 24;
            this.btnSlectionner.Text = "Sélectionner";
            this.btnSlectionner.UseVisualStyleBackColor = false;
            this.btnSlectionner.Click += new System.EventHandler(this.btnSlectionner_Click);
            this.btnSlectionner.MouseEnter += new System.EventHandler(this.btnSlectionner_MouseEnter);
            this.btnSlectionner.MouseLeave += new System.EventHandler(this.btnSlectionner_MouseLeave);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(30, 30);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(160, 50);
            this.btnAjouter.TabIndex = 21;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            this.btnAjouter.MouseEnter += new System.EventHandler(this.btnAjouter_MouseEnter);
            this.btnAjouter.MouseLeave += new System.EventHandler(this.btnAjouter_MouseLeave);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(210, 30);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(160, 50);
            this.btnModifier.TabIndex = 22;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            this.btnModifier.MouseEnter += new System.EventHandler(this.btnModifier_MouseEnter);
            this.btnModifier.MouseLeave += new System.EventHandler(this.btnModifier_MouseLeave);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(30, 170);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(160, 50);
            this.btnSupprimer.TabIndex = 23;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            this.btnSupprimer.MouseEnter += new System.EventHandler(this.btnSupprimer_MouseEnter);
            this.btnSupprimer.MouseLeave += new System.EventHandler(this.btnSupprimer_MouseLeave);
            // 
            // dgSession
            // 
            this.dgSession.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSession.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSession.BackgroundColor = System.Drawing.Color.White;
            this.dgSession.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSession.Location = new System.Drawing.Point(450, 250);
            this.dgSession.Name = "dgSession";
            this.dgSession.RowHeadersWidth = 62;
            this.dgSession.RowTemplate.Height = 28;
            this.dgSession.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSession.Size = new System.Drawing.Size(690, 380);
            this.dgSession.TabIndex = 20;
            // 
            // frmSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1170, 648);
            this.ControlBox = false;
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.dgSession);
            this.MinimumSize = new System.Drawing.Size(1170, 648);
            this.Name = "frmSession";
            this.Text = "Session";
            this.Load += new System.EventHandler(this.frmSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSession)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        // Événements hover pour le bouton Ajouter
        private void btnAjouter_MouseEnter(object sender, EventArgs e)
        {
            btnAjouter.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
        }

        private void btnAjouter_MouseLeave(object sender, EventArgs e)
        {
            btnAjouter.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
        }

        // Événements hover pour le bouton Modifier
        private void btnModifier_MouseEnter(object sender, EventArgs e)
        {
            btnModifier.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
        }

        private void btnModifier_MouseLeave(object sender, EventArgs e)
        {
            btnModifier.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
        }

        // Événements hover pour le bouton Supprimer
        private void btnSupprimer_MouseEnter(object sender, EventArgs e)
        {
            btnSupprimer.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
        }

        private void btnSupprimer_MouseLeave(object sender, EventArgs e)
        {
            btnSupprimer.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
        }

        // Événements hover pour le bouton Sélectionner
        private void btnSlectionner_MouseEnter(object sender, EventArgs e)
        {
            btnSlectionner.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
        }

        private void btnSlectionner_MouseLeave(object sender, EventArgs e)
        {
            btnSlectionner.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
        }

        // Événements hover pour le bouton Rechercher
        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.BackColor = System.Drawing.Color.FromArgb(142, 68, 173);
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtRAnneeAcademique;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRSession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxAnneeAcademique;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSlectionner;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dgSession;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelButtons;
    }
}