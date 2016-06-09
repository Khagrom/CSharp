using Oracle.DataAccess.Client;
using Persistance;
using Metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5
{
    public partial class FenetrePrincipale : Form
    {
        private BindingList<Etudiant> leConteneur;
        private DaoOracleEtudiant leDaoEtudiant;

        public FenetrePrincipale()
        {
            InitializeComponent();
            Charger();
        }

        private void Charger()
        {
            try
            {
                leDaoEtudiant = new DaoOracleEtudiant(ConnexionOracle.GetInstance());
                leConteneur = new BindingList<Etudiant>(leDaoEtudiant.LesEtudiants());
                dgrVue.DataSource = leConteneur;
                lbTitre.Text += DateTime.Now.ToString("d");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Problème à la connexion.");
                this.Dispose(true);
            }
        }

        // fermeture de la fenêtre
        private void FenetrePrincipale_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Quitter l'application ?", 
                               "Attention !",
                               MessageBoxButtons.YesNo, 
                               MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;    // l'évènement doit être annulé
        }
    }
}
