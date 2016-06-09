using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP3
{
    public sealed class CompteBancaire : Compte
    {
        // attribut
        private float decouvertMax;

        // propriétés
        public float LeDecouvert
        {
            get { return decouvertMax; }
        }

        // le constructeur
        public CompteBancaire(String nomCompte, float montant, float decouvert)
            : base(nomCompte, montant)
        {
            decouvertMax = decouvert;
        }

        // methodes publiques de mouvement sur le compte
        public override void Crediter(float montant)
        {
            if (montant <= 0)
            {
                throw new Compte.Erreur(" Opération incorrecte sur le CB: " + LeNumero + "\n");
            }
            soldeCompte += montant;
        }

        public override void Debiter(float montant)
        {
            if (montant <= 0)
            {
                throw new Compte.Erreur(" Opération incorrecte sur un CB: " + LeNumero + "\n");
            }
            if (soldeCompte - montant < -decouvertMax)
            {
                throw new Compte.Erreur(" Decouvert max depasse sur un CB: " + LeNumero + "\n");
            }
            else
            {
                soldeCompte -= montant;
            }
        }

        // méthode Afficher de la classe CompteBancaire
        public override void Afficher()
        {
            Console.WriteLine(" ---- Compte Bancaire ----");
            base.Afficher();
            Console.WriteLine(" - Decouvert autorisé.: " + LeDecouvert);
            Console.WriteLine(" -------------------------");
        }

    }
}
