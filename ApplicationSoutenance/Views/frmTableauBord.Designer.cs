namespace ApplicationSoutenance.Views
{
    partial class frmTableauBord
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblHubTitle = new System.Windows.Forms.Label();
            this.lblBienvenue = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelProf = new System.Windows.Forms.Panel();
            this.lblProfIcon = new System.Windows.Forms.Label();
            this.lblProfCount = new System.Windows.Forms.Label();
            this.lblProfTitle = new System.Windows.Forms.Label();
            this.panelMem = new System.Windows.Forms.Panel();
            this.lblMemIcon = new System.Windows.Forms.Label();
            this.lblMemCount = new System.Windows.Forms.Label();
            this.lblMemTitle = new System.Windows.Forms.Label();
            this.panelSess = new System.Windows.Forms.Panel();
            this.lblSessIcon = new System.Windows.Forms.Label();
            this.lblSessCount = new System.Windows.Forms.Label();
            this.lblSessTitle = new System.Windows.Forms.Label();
            this.panelSout = new System.Windows.Forms.Panel();
            this.lblSoutIcon = new System.Windows.Forms.Label();
            this.lblSoutCount = new System.Windows.Forms.Label();
            this.lblSoutTitle = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelProf.SuspendLayout();
            this.panelMem.SuspendLayout();
            this.panelSess.SuspendLayout();
            this.panelSout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.pictureBoxLogo);
            this.panelHeader.Controls.Add(this.lblHubTitle);
            this.panelHeader.Controls.Add(this.lblBienvenue);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1100, 180);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Location = new System.Drawing.Point(40, 30);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblHubTitle
            // 
            this.lblHubTitle.AutoSize = true;
            this.lblHubTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHubTitle.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblHubTitle.ForeColor = System.Drawing.Color.White;
            this.lblHubTitle.Location = new System.Drawing.Point(180, 40);
            this.lblHubTitle.Name = "lblHubTitle";
            this.lblHubTitle.Size = new System.Drawing.Size(515, 70);
            this.lblHubTitle.TabIndex = 1;
            this.lblHubTitle.Text = "Sen Soutenance Hub";
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.AutoSize = true;
            this.lblBienvenue.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenue.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblBienvenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblBienvenue.Location = new System.Drawing.Point(185, 110);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(326, 38);
            this.lblBienvenue.TabIndex = 2;
            this.lblBienvenue.Text = "Bienvenue, [Utilisateur]";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.panelProf);
            this.flowLayoutPanel1.Controls.Add(this.panelMem);
            this.flowLayoutPanel1.Controls.Add(this.panelSess);
            this.flowLayoutPanel1.Controls.Add(this.panelSout);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(40, 210);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1020, 260);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panelProf
            // 
            this.panelProf.BackColor = System.Drawing.Color.White;
            this.panelProf.Controls.Add(this.lblProfIcon);
            this.panelProf.Controls.Add(this.lblProfCount);
            this.panelProf.Controls.Add(this.lblProfTitle);
            this.panelProf.Location = new System.Drawing.Point(15, 15);
            this.panelProf.Margin = new System.Windows.Forms.Padding(15);
            this.panelProf.Name = "panelProf";
            this.panelProf.Size = new System.Drawing.Size(220, 220);
            this.panelProf.TabIndex = 0;
            this.panelProf.Paint += new System.Windows.Forms.PaintEventHandler(this.CardPanel_Paint);
            // 
            // lblProfIcon
            // 
            this.lblProfIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 36F);
            this.lblProfIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblProfIcon.Location = new System.Drawing.Point(0, 20);
            this.lblProfIcon.Name = "lblProfIcon";
            this.lblProfIcon.Size = new System.Drawing.Size(220, 80);
            this.lblProfIcon.TabIndex = 2;
            this.lblProfIcon.Text = "👥";
            this.lblProfIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProfCount
            // 
            this.lblProfCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblProfCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblProfCount.Location = new System.Drawing.Point(0, 100);
            this.lblProfCount.Name = "lblProfCount";
            this.lblProfCount.Size = new System.Drawing.Size(220, 60);
            this.lblProfCount.TabIndex = 1;
            this.lblProfCount.Text = "0";
            this.lblProfCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProfTitle
            // 
            this.lblProfTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblProfTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblProfTitle.Location = new System.Drawing.Point(0, 160);
            this.lblProfTitle.Name = "lblProfTitle";
            this.lblProfTitle.Size = new System.Drawing.Size(220, 40);
            this.lblProfTitle.TabIndex = 0;
            this.lblProfTitle.Text = "Professeurs";
            this.lblProfTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMem
            // 
            this.panelMem.BackColor = System.Drawing.Color.White;
            this.panelMem.Controls.Add(this.lblMemIcon);
            this.panelMem.Controls.Add(this.lblMemCount);
            this.panelMem.Controls.Add(this.lblMemTitle);
            this.panelMem.Location = new System.Drawing.Point(265, 15);
            this.panelMem.Margin = new System.Windows.Forms.Padding(15);
            this.panelMem.Name = "panelMem";
            this.panelMem.Size = new System.Drawing.Size(220, 220);
            this.panelMem.TabIndex = 1;
            this.panelMem.Paint += new System.Windows.Forms.PaintEventHandler(this.CardPanel_Paint);
            // 
            // lblMemIcon
            // 
            this.lblMemIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 36F);
            this.lblMemIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblMemIcon.Location = new System.Drawing.Point(0, 20);
            this.lblMemIcon.Name = "lblMemIcon";
            this.lblMemIcon.Size = new System.Drawing.Size(220, 80);
            this.lblMemIcon.TabIndex = 2;
            this.lblMemIcon.Text = "📚";
            this.lblMemIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMemCount
            // 
            this.lblMemCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblMemCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblMemCount.Location = new System.Drawing.Point(0, 100);
            this.lblMemCount.Name = "lblMemCount";
            this.lblMemCount.Size = new System.Drawing.Size(220, 60);
            this.lblMemCount.TabIndex = 1;
            this.lblMemCount.Text = "0";
            this.lblMemCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMemTitle
            // 
            this.lblMemTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblMemTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblMemTitle.Location = new System.Drawing.Point(0, 160);
            this.lblMemTitle.Name = "lblMemTitle";
            this.lblMemTitle.Size = new System.Drawing.Size(220, 40);
            this.lblMemTitle.TabIndex = 0;
            this.lblMemTitle.Text = "Mémoires";
            this.lblMemTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSess
            // 
            this.panelSess.BackColor = System.Drawing.Color.White;
            this.panelSess.Controls.Add(this.lblSessIcon);
            this.panelSess.Controls.Add(this.lblSessCount);
            this.panelSess.Controls.Add(this.lblSessTitle);
            this.panelSess.Location = new System.Drawing.Point(515, 15);
            this.panelSess.Margin = new System.Windows.Forms.Padding(15);
            this.panelSess.Name = "panelSess";
            this.panelSess.Size = new System.Drawing.Size(220, 220);
            this.panelSess.TabIndex = 2;
            this.panelSess.Paint += new System.Windows.Forms.PaintEventHandler(this.CardPanel_Paint);
            // 
            // lblSessIcon
            // 
            this.lblSessIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 36F);
            this.lblSessIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.lblSessIcon.Location = new System.Drawing.Point(0, 20);
            this.lblSessIcon.Name = "lblSessIcon";
            this.lblSessIcon.Size = new System.Drawing.Size(220, 80);
            this.lblSessIcon.TabIndex = 2;
            this.lblSessIcon.Text = "📅";
            this.lblSessIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSessCount
            // 
            this.lblSessCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblSessCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSessCount.Location = new System.Drawing.Point(0, 100);
            this.lblSessCount.Name = "lblSessCount";
            this.lblSessCount.Size = new System.Drawing.Size(220, 60);
            this.lblSessCount.TabIndex = 1;
            this.lblSessCount.Text = "0";
            this.lblSessCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSessTitle
            // 
            this.lblSessTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblSessTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblSessTitle.Location = new System.Drawing.Point(0, 160);
            this.lblSessTitle.Name = "lblSessTitle";
            this.lblSessTitle.Size = new System.Drawing.Size(220, 40);
            this.lblSessTitle.TabIndex = 0;
            this.lblSessTitle.Text = "Sessions";
            this.lblSessTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSout
            // 
            this.panelSout.BackColor = System.Drawing.Color.White;
            this.panelSout.Controls.Add(this.lblSoutIcon);
            this.panelSout.Controls.Add(this.lblSoutCount);
            this.panelSout.Controls.Add(this.lblSoutTitle);
            this.panelSout.Location = new System.Drawing.Point(765, 15);
            this.panelSout.Margin = new System.Windows.Forms.Padding(15);
            this.panelSout.Name = "panelSout";
            this.panelSout.Size = new System.Drawing.Size(220, 220);
            this.panelSout.TabIndex = 3;
            this.panelSout.Paint += new System.Windows.Forms.PaintEventHandler(this.CardPanel_Paint);
            // 
            // lblSoutIcon
            // 
            this.lblSoutIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 36F);
            this.lblSoutIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblSoutIcon.Location = new System.Drawing.Point(0, 20);
            this.lblSoutIcon.Name = "lblSoutIcon";
            this.lblSoutIcon.Size = new System.Drawing.Size(220, 80);
            this.lblSoutIcon.TabIndex = 2;
            this.lblSoutIcon.Text = "🎓";
            this.lblSoutIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoutCount
            // 
            this.lblSoutCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblSoutCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSoutCount.Location = new System.Drawing.Point(0, 100);
            this.lblSoutCount.Name = "lblSoutCount";
            this.lblSoutCount.Size = new System.Drawing.Size(220, 60);
            this.lblSoutCount.TabIndex = 1;
            this.lblSoutCount.Text = "0";
            this.lblSoutCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoutTitle
            // 
            this.lblSoutTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblSoutTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblSoutTitle.Location = new System.Drawing.Point(0, 160);
            this.lblSoutTitle.Name = "lblSoutTitle";
            this.lblSoutTitle.Size = new System.Drawing.Size(220, 40);
            this.lblSoutTitle.TabIndex = 0;
            this.lblSoutTitle.Text = "Soutenances";
            this.lblSoutTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTableauBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTableauBord";
            this.Text = "Tableau de Bord";
            this.Load += new System.EventHandler(this.frmTableauBord_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelProf.ResumeLayout(false);
            this.panelMem.ResumeLayout(false);
            this.panelSess.ResumeLayout(false);
            this.panelSout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblHubTitle;
        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelProf;
        private System.Windows.Forms.Label lblProfTitle;
        private System.Windows.Forms.Label lblProfCount;
        private System.Windows.Forms.Label lblProfIcon;
        private System.Windows.Forms.Panel panelMem;
        private System.Windows.Forms.Label lblMemIcon;
        private System.Windows.Forms.Label lblMemCount;
        private System.Windows.Forms.Label lblMemTitle;
        private System.Windows.Forms.Panel panelSess;
        private System.Windows.Forms.Label lblSessIcon;
        private System.Windows.Forms.Label lblSessCount;
        private System.Windows.Forms.Label lblSessTitle;
        private System.Windows.Forms.Panel panelSout;
        private System.Windows.Forms.Label lblSoutIcon;
        private System.Windows.Forms.Label lblSoutCount;
        private System.Windows.Forms.Label lblSoutTitle;
    }
}
