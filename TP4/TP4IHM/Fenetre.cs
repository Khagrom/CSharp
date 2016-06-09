using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP4;

namespace TP4IHM
{
    public partial class Fenetre : Form
    {
        // la lise doublement chaînée
        private LinkedList<KeyValuePair<String, Compte>>  listeComptes = null;
        // un maillon de la liste
        private LinkedListNode<KeyValuePair<String, Compte>> courant = null;

        public Fenetre()
        {
            InitializeComponent();
        }

        private void Fenetre_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Voulez-vous vraiment quitter ?", "Gestion des comptes",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;    // l'évènement doit être annulé
        }

        private void itemQuitter_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez-vous vraiment quitter ?", "Gestion des comptes",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose(); // Application.Exit();
            }
        }

        private void menuAPropos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Win Comptes - Version 1.0", "A propos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Afficher(Compte cpt)
        {
            tbNumero.Text = cpt.LeNumero;
            tbNom.Text = cpt.LeNom;
            tbSolde.Text = cpt.LeSolde.ToString();
            if (cpt is CompteBancaire)
            {
                lbTitre.Text = "Compte Bancaire";
                lbDecouvert.Text = "Découvert";
                tbDecouvert.Text = ((CompteBancaire)cpt).LeDecouvert.ToString();
            }
            else
            {
                lbTitre.Text = "Compte Epargne";
                lbDecouvert.Text = "Limite plafond";
                tbDecouvert.Text = ((CompteEpargne)cpt).LePlafond.ToString();
            }
        }

        private void itemOuvrir_Click(object sender, EventArgs e)
        {
            // on crée un contrôle pour choisir le fichier à lire
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.DefaultExt = "dat";
            oFD.InitialDirectory = ".";
            oFD.Filter = "txt files (*.dat)|*.dat|All files (*.*)|*.*";
            oFD.FilterIndex = 2;

            if (oFD.ShowDialog() == DialogResult.OK)
            {
                // définition d'un objet de sérialisation-désérialisation
                BinaryFormatter obSer = new BinaryFormatter();
                // définition d'un fichier en lecture
                FileStream fi = new FileStream(oFD.FileName, FileMode.Open, FileAccess.Read);
                // désérialisation dans le contenur
                IDictionary<String, Compte> lesComptes =
                               (IDictionary<String, Compte>)obSer.Deserialize(fi);
                // récupération d'une liste doublement chaînée des comptes triés par nom
                listeComptes = new LinkedList<KeyValuePair<string, Compte>>
                                (lesComptes.OrderBy(x => x.Value.LeNumero));
                // fermeture du fichier
                fi.Close();
                if (lesComptes.Count != 0)
                {
                    courant = listeComptes.First;
                    Afficher(courant.Value.Value);
                    btDebut.Enabled = true;
                    btFin.Enabled = true;
                    btPrec.Enabled = true;
                    btSuiv.Enabled = true;
                }
            }
        }

        private void btDebut_Click(object sender, EventArgs e)
        {
            if (listeComptes != null && listeComptes.Count != 0)
            {
                courant = listeComptes.First;
                Afficher(courant.Value.Value);
            }
        }

        private void btFin_Click(object sender, EventArgs e)
        {
            if (listeComptes != null && listeComptes.Count != 0)
            {
                courant = listeComptes.Last;
                Afficher(courant.Value.Value);
            }
        }

        private void btPrec_Click(object sender, EventArgs e)
        {
            if (listeComptes != null && listeComptes.Count != 0)
            {
                if (courant != null & courant.Previous != null)
                {
                    courant = courant.Previous;
                    Afficher(courant.Value.Value);
                }
            }
        }

        private void btSuiv_Click(object sender, EventArgs e)
        {
            if (listeComptes != null && listeComptes.Count != 0)
            {
                if (courant != null & courant.Next != null)
                {
                    courant = courant.Next;
                    Afficher(courant.Value.Value);
                }
            }
        }
    }
}
