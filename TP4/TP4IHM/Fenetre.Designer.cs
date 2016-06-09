namespace TP4IHM
{
    partial class Fenetre
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAPropos = new System.Windows.Forms.ToolStripMenuItem();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lbNom = new System.Windows.Forms.Label();
            this.tbSolde = new System.Windows.Forms.TextBox();
            this.lbSolde = new System.Windows.Forms.Label();
            this.tbDecouvert = new System.Windows.Forms.TextBox();
            this.lbDecouvert = new System.Windows.Forms.Label();
            this.gbNavigation = new System.Windows.Forms.GroupBox();
            this.btFin = new System.Windows.Forms.Button();
            this.btSuiv = new System.Windows.Forms.Button();
            this.btPrec = new System.Windows.Forms.Button();
            this.btDebut = new System.Windows.Forms.Button();
            this.lbTitre = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.gbNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFichier,
            this.menuAPropos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(272, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFichier
            // 
            this.menuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemOuvrir,
            this.toolStripSeparator1,
            this.itemQuitter});
            this.menuFichier.Name = "menuFichier";
            this.menuFichier.Size = new System.Drawing.Size(54, 20);
            this.menuFichier.Text = "Fichier";
            // 
            // itemOuvrir
            // 
            this.itemOuvrir.Name = "itemOuvrir";
            this.itemOuvrir.Size = new System.Drawing.Size(111, 22);
            this.itemOuvrir.Text = "Ouvrir";
            this.itemOuvrir.Click += new System.EventHandler(this.itemOuvrir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(108, 6);
            // 
            // itemQuitter
            // 
            this.itemQuitter.Name = "itemQuitter";
            this.itemQuitter.Size = new System.Drawing.Size(111, 22);
            this.itemQuitter.Text = "Quitter";
            this.itemQuitter.Click += new System.EventHandler(this.itemQuitter_Click);
            // 
            // menuAPropos
            // 
            this.menuAPropos.Name = "menuAPropos";
            this.menuAPropos.Size = new System.Drawing.Size(24, 20);
            this.menuAPropos.Text = "?";
            this.menuAPropos.Click += new System.EventHandler(this.menuAPropos_Click);
            // 
            // pbImage
            // 
            this.pbImage.Image = global::TP4IHM.Properties.Resources.logo1;
            this.pbImage.Location = new System.Drawing.Point(23, 43);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(111, 74);
            this.pbImage.TabIndex = 2;
            this.pbImage.TabStop = false;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(30, 138);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(82, 13);
            this.lbNumero.TabIndex = 4;
            this.lbNumero.Text = "Numéro compte";
            // 
            // tbNumero
            // 
            this.tbNumero.Enabled = false;
            this.tbNumero.Location = new System.Drawing.Point(133, 135);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(100, 20);
            this.tbNumero.TabIndex = 5;
            // 
            // tbNom
            // 
            this.tbNom.Enabled = false;
            this.tbNom.Location = new System.Drawing.Point(133, 165);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 20);
            this.tbNom.TabIndex = 7;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(30, 168);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(82, 13);
            this.lbNom.TabIndex = 6;
            this.lbNom.Text = "Nom du compte";
            // 
            // tbSolde
            // 
            this.tbSolde.Enabled = false;
            this.tbSolde.Location = new System.Drawing.Point(133, 196);
            this.tbSolde.Name = "tbSolde";
            this.tbSolde.Size = new System.Drawing.Size(100, 20);
            this.tbSolde.TabIndex = 9;
            // 
            // lbSolde
            // 
            this.lbSolde.AutoSize = true;
            this.lbSolde.Location = new System.Drawing.Point(30, 199);
            this.lbSolde.Name = "lbSolde";
            this.lbSolde.Size = new System.Drawing.Size(87, 13);
            this.lbSolde.TabIndex = 8;
            this.lbSolde.Text = "Solde du compte";
            // 
            // tbDecouvert
            // 
            this.tbDecouvert.Enabled = false;
            this.tbDecouvert.Location = new System.Drawing.Point(133, 227);
            this.tbDecouvert.Name = "tbDecouvert";
            this.tbDecouvert.Size = new System.Drawing.Size(100, 20);
            this.tbDecouvert.TabIndex = 11;
            // 
            // lbDecouvert
            // 
            this.lbDecouvert.AutoSize = true;
            this.lbDecouvert.Location = new System.Drawing.Point(30, 230);
            this.lbDecouvert.Name = "lbDecouvert";
            this.lbDecouvert.Size = new System.Drawing.Size(57, 13);
            this.lbDecouvert.TabIndex = 10;
            this.lbDecouvert.Text = "Découvert";
            // 
            // gbNavigation
            // 
            this.gbNavigation.Controls.Add(this.btFin);
            this.gbNavigation.Controls.Add(this.btSuiv);
            this.gbNavigation.Controls.Add(this.btPrec);
            this.gbNavigation.Controls.Add(this.btDebut);
            this.gbNavigation.Location = new System.Drawing.Point(40, 267);
            this.gbNavigation.Name = "gbNavigation";
            this.gbNavigation.Size = new System.Drawing.Size(193, 79);
            this.gbNavigation.TabIndex = 12;
            this.gbNavigation.TabStop = false;
            this.gbNavigation.Text = "Navigation";
            // 
            // btFin
            // 
            this.btFin.Enabled = false;
            this.btFin.Location = new System.Drawing.Point(142, 32);
            this.btFin.Name = "btFin";
            this.btFin.Size = new System.Drawing.Size(36, 23);
            this.btFin.TabIndex = 3;
            this.btFin.Text = ">>";
            this.btFin.UseVisualStyleBackColor = true;
            this.btFin.Click += new System.EventHandler(this.btFin_Click);
            // 
            // btSuiv
            // 
            this.btSuiv.Enabled = false;
            this.btSuiv.Location = new System.Drawing.Point(100, 32);
            this.btSuiv.Name = "btSuiv";
            this.btSuiv.Size = new System.Drawing.Size(36, 23);
            this.btSuiv.TabIndex = 2;
            this.btSuiv.Text = ">";
            this.btSuiv.UseVisualStyleBackColor = true;
            this.btSuiv.Click += new System.EventHandler(this.btSuiv_Click);
            // 
            // btPrec
            // 
            this.btPrec.Enabled = false;
            this.btPrec.Location = new System.Drawing.Point(58, 32);
            this.btPrec.Name = "btPrec";
            this.btPrec.Size = new System.Drawing.Size(36, 23);
            this.btPrec.TabIndex = 1;
            this.btPrec.Text = "<";
            this.btPrec.UseVisualStyleBackColor = true;
            this.btPrec.Click += new System.EventHandler(this.btPrec_Click);
            // 
            // btDebut
            // 
            this.btDebut.Enabled = false;
            this.btDebut.Location = new System.Drawing.Point(15, 32);
            this.btDebut.Name = "btDebut";
            this.btDebut.Size = new System.Drawing.Size(36, 23);
            this.btDebut.TabIndex = 0;
            this.btDebut.Text = "<<";
            this.btDebut.UseVisualStyleBackColor = true;
            this.btDebut.Click += new System.EventHandler(this.btDebut_Click);
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Location = new System.Drawing.Point(148, 76);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(0, 13);
            this.lbTitre.TabIndex = 13;
            // 
            // Fenetre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 358);
            this.Controls.Add(this.lbTitre);
            this.Controls.Add(this.gbNavigation);
            this.Controls.Add(this.tbDecouvert);
            this.Controls.Add(this.lbDecouvert);
            this.Controls.Add(this.tbSolde);
            this.Controls.Add(this.lbSolde);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fenetre";
            this.Text = "Affichage des comptes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fenetre_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.gbNavigation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFichier;
        private System.Windows.Forms.ToolStripMenuItem itemOuvrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemQuitter;
        private System.Windows.Forms.ToolStripMenuItem menuAPropos;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox tbSolde;
        private System.Windows.Forms.Label lbSolde;
        private System.Windows.Forms.TextBox tbDecouvert;
        private System.Windows.Forms.Label lbDecouvert;
        private System.Windows.Forms.GroupBox gbNavigation;
        private System.Windows.Forms.Button btFin;
        private System.Windows.Forms.Button btSuiv;
        private System.Windows.Forms.Button btPrec;
        private System.Windows.Forms.Button btDebut;
        private System.Windows.Forms.Label lbTitre;
    }
}

