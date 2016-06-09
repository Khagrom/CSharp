using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    [Serializable]
    public abstract class Compte
    {
        // variable de classe
        private static int numeroAttribue = 100;

        // attributs de la classe
        private String numeroCompte;
        protected float soldeCompte;

        // les propriétés
        public String LeNumero
        {
            get { return numeroCompte; }
        }
        public String LeNom { get; set; }
        public float LeSolde
        {
            get { return soldeCompte; }
        }

        // le constructeur        		
        public Compte(String nomCompte, float soldeCompte)
        {
            numeroCompte = "Cpt" + Convert.ToString(numeroAttribue++);
            LeNom = nomCompte;
            this.soldeCompte = soldeCompte;
        }

        // methodes publiques de mouvement sur le compte
        public abstract void Crediter(float montant);
        public abstract void Debiter(float montant);

        // methode d'affichage des caractéristiques d'un compte
        public virtual void Afficher()
        {
            Console.WriteLine(" - Numero.............: " + LeNumero);
            Console.WriteLine(" - Nom................: " + LeNom);
            Console.WriteLine(" - Solde..............: " + LeSolde);
        }

        // definition de la classe interne Erreur
        public class Erreur : Exception
        {
            public Erreur(string s) : base(s) { }
            public Erreur() : this(" Exception générée dans la classe Compte Bancaire ") { }
            public override string Message
            {
                get { return " --> " + base.Message; }
            }
        } // class Erreur

    } // fin class
}
