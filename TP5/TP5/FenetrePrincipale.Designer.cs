namespace TP5
{
    partial class FenetrePrincipale
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitre = new System.Windows.Forms.Label();
            this.dgrVue = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrVue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Location = new System.Drawing.Point(215, 20);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(63, 13);
            this.lbTitre.TabIndex = 1;
            this.lbTitre.Text = "Edition du : ";
            // 
            // dgrVue
            // 
            this.dgrVue.AllowUserToAddRows = false;
            this.dgrVue.AllowUserToDeleteRows = false;
            this.dgrVue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrVue.Location = new System.Drawing.Point(37, 52);
            this.dgrVue.MultiSelect = false;
            this.dgrVue.Name = "dgrVue";
            this.dgrVue.ReadOnly = true;
            this.dgrVue.Size = new System.Drawing.Size(460, 220);
            this.dgrVue.TabIndex = 2;
            // 
            // FenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 306);
            this.Controls.Add(this.dgrVue);
            this.Controls.Add(this.lbTitre);
            this.Controls.Add(this.label1);
            this.Name = "FenetrePrincipale";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FenetrePrincipale_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgrVue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.DataGridView dgrVue;
    }
}

