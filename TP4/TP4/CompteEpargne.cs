using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    [Serializable]
    public class CompteEpargne : Compte
    {
        // attribut
        private float plafondMax;

        // les propriétés
        public float LePlafond
        {
            get { return plafondMax; }
        }

        // le constructeur
        public CompteEpargne(string client, float montant, float plafond)
            : base(client, montant)
        {
            plafondMax = plafond;
        }

        // méthode Afficher de la classe CompteEpargne
        public override void Afficher()
        {
            Console.WriteLine(" ---- Compte Epargne  ----");
            base.Afficher();
            Console.WriteLine(" - Depot maximum......: " + LePlafond);
            Console.WriteLine(" -------------------------");
        }

        // méthode Crediter de la clase CompteEpargne
        public override void Crediter(float montant)
        {
            if (montant <= 0)
            {
                throw new Compte.Erreur(" Opération incorrecte sur un CE: " + LeNumero + "\n");
            }
            if (LeSolde + montant > plafondMax)
            {
                // on vérifie que le futur solde n'est pas > plafond autorisé
                throw new Erreur(" Depassement du plafond sur un CE: " + LeNumero + "\n");
            }
            else
            {
                soldeCompte += montant;
            }
        }

        // méthode Debiter de la classe CompteEpargne
        public override void Debiter(float montant)
        {
            if (montant <= 0)
            {
                throw new Compte.Erreur(" Opération incorrecte sur un CE: " + LeNumero + "\n");
            }
            if (LeSolde - montant < 0)
            {
                // on vérifie que le futur solde n'est pas <0 car dans un  compte
                // épargne on a pas de découvert autorisé 
                throw new Erreur(" Manque de liquidités sur un CE : " + LeNumero + "\n");
            }
            else
            {
                soldeCompte -= montant; ;
            }
        }
    }
}
