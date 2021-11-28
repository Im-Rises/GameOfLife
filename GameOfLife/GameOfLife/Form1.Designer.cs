namespace TP14_JeudelaVie
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
            this.components = new System.ComponentModel.Container();
            this.menuEtatVitesse = new System.Windows.Forms.MenuStrip();
            this.etatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vitesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moyenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrAvanceTemps = new System.Windows.Forms.Timer(this.components);
            this.picInitial = new System.Windows.Forms.PictureBox();
            this.picVivant = new System.Windows.Forms.PictureBox();
            this.menuEtatVitesse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInitial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVivant)).BeginInit();
            this.SuspendLayout();
            // 
            // menuEtatVitesse
            // 
            this.menuEtatVitesse.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuEtatVitesse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etatToolStripMenuItem,
            this.vitesseToolStripMenuItem});
            this.menuEtatVitesse.Location = new System.Drawing.Point(0, 0);
            this.menuEtatVitesse.Name = "menuEtatVitesse";
            this.menuEtatVitesse.Size = new System.Drawing.Size(447, 28);
            this.menuEtatVitesse.TabIndex = 0;
            this.menuEtatVitesse.Text = "menuStrip1";
            // 
            // etatToolStripMenuItem
            // 
            this.etatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.marcheToolStripMenuItem,
            this.arretToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.etatToolStripMenuItem.Name = "etatToolStripMenuItem";
            this.etatToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.etatToolStripMenuItem.Text = "State";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nouveauToolStripMenuItem.Text = "New";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // marcheToolStripMenuItem
            // 
            this.marcheToolStripMenuItem.Name = "marcheToolStripMenuItem";
            this.marcheToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.marcheToolStripMenuItem.Text = "Start";
            this.marcheToolStripMenuItem.Click += new System.EventHandler(this.marcheToolStripMenuItem_Click);
            // 
            // arretToolStripMenuItem
            // 
            this.arretToolStripMenuItem.Name = "arretToolStripMenuItem";
            this.arretToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.arretToolStripMenuItem.Text = "Stop";
            this.arretToolStripMenuItem.Click += new System.EventHandler(this.arretToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quitterToolStripMenuItem.Text = "Exit";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // vitesseToolStripMenuItem
            // 
            this.vitesseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lentToolStripMenuItem,
            this.moyenToolStripMenuItem,
            this.rapideToolStripMenuItem});
            this.vitesseToolStripMenuItem.Name = "vitesseToolStripMenuItem";
            this.vitesseToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.vitesseToolStripMenuItem.Text = "Speed";
            // 
            // lentToolStripMenuItem
            // 
            this.lentToolStripMenuItem.Name = "lentToolStripMenuItem";
            this.lentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lentToolStripMenuItem.Text = "Slow";
            this.lentToolStripMenuItem.Click += new System.EventHandler(this.lentToolStripMenuItem_Click);
            // 
            // moyenToolStripMenuItem
            // 
            this.moyenToolStripMenuItem.Name = "moyenToolStripMenuItem";
            this.moyenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.moyenToolStripMenuItem.Text = "Medium";
            this.moyenToolStripMenuItem.Click += new System.EventHandler(this.moyenToolStripMenuItem_Click);
            // 
            // rapideToolStripMenuItem
            // 
            this.rapideToolStripMenuItem.Name = "rapideToolStripMenuItem";
            this.rapideToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rapideToolStripMenuItem.Text = "Quick";
            this.rapideToolStripMenuItem.Click += new System.EventHandler(this.rapideToolStripMenuItem_Click);
            // 
            // tmrAvanceTemps
            // 
            this.tmrAvanceTemps.Tick += new System.EventHandler(this.tmrAvanceTemps_Tick);
            // 
            // picInitial
            // 
            this.picInitial.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picInitial.Location = new System.Drawing.Point(74, 104);
            this.picInitial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picInitial.Name = "picInitial";
            this.picInitial.Size = new System.Drawing.Size(20, 25);
            this.picInitial.TabIndex = 1;
            this.picInitial.TabStop = false;
            // 
            // picVivant
            // 
            this.picVivant.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picVivant.Location = new System.Drawing.Point(131, 104);
            this.picVivant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picVivant.Name = "picVivant";
            this.picVivant.Size = new System.Drawing.Size(20, 25);
            this.picVivant.TabIndex = 2;
            this.picVivant.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 325);
            this.Controls.Add(this.picVivant);
            this.Controls.Add(this.picInitial);
            this.Controls.Add(this.menuEtatVitesse);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Game of Life";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuEtatVitesse.ResumeLayout(false);
            this.menuEtatVitesse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInitial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVivant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuEtatVitesse;
        private System.Windows.Forms.ToolStripMenuItem etatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arretToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vitesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moyenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapideToolStripMenuItem;
        private System.Windows.Forms.Timer tmrAvanceTemps;
        private System.Windows.Forms.PictureBox picInitial;
        private System.Windows.Forms.PictureBox picVivant;
    }
}

