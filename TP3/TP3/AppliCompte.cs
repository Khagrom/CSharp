using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP3
{
    class AppliCompte
    {
        static void Main(string[] args)
        {
            // création des comptesF
            Compte cpt1 = new CompteBancaire("Brad",15000.20F,5000);
            Compte cpt2 = new CompteEpargne("Angelina",1500.50f,22950);
            Compte cpt3 = new CompteBancaire("Djamal",75000,5000);
            Compte cpt4 = new CompteEpargne("Salma",18500,22950);
            Compte cpt5 = new CompteBancaire("George",34500,5000);
            Compte cpt7 = new CompteBancaire("Toto",150,50);
           
            // création du conteneur associatif et remplissage
            IDictionary<String, Compte> leConteneur = new SortedDictionary<String,Compte>();
            leConteneur.Add(cpt7.LeNumero, cpt7);
            leConteneur.Add(cpt2.LeNumero, cpt2);
            leConteneur.Add(cpt5.LeNumero, cpt5);
            leConteneur.Add(cpt4.LeNumero, cpt4);
            leConteneur.Add(cpt3.LeNumero, cpt3);
            leConteneur.Add(cpt1.LeNumero, cpt1);

            // affichage du contenu
            //foreach (Compte cpt in leConteneur.Values)
            //{
            //    cpt.Afficher();
            //}
            foreach (KeyValuePair<String, Compte> paire in leConteneur)
            {
                paire.Value.Afficher();
            }

            // Affichage des comptes triés par nom
            Console.WriteLine("\n -- Affichage des comptes triés par nom--\n");
            IEnumerable<KeyValuePair<String, Compte>> resultat =
                leConteneur.OrderBy(x => x.Value.LeNom);
            foreach (KeyValuePair<String, Compte> paire in resultat)
            {
                paire.Value.Afficher();
            }

            // Recherche à l'aide d'une méthode d'extension avec lambda expression
            Console.Write("\n Saisir le nom du compte à rechercher : ");
            String nomCompte = Console.ReadLine();
            try
            {
                KeyValuePair<String, Compte> paire =
                    resultat.First(x => x.Value.LeNom.CompareTo(nomCompte) == 0);
                Console.WriteLine("\n Affichage du compte trouvé : ");
                paire.Value.Afficher();
            }
            catch (Exception e)
            {
                Console.WriteLine("\n Compte absent de la liste " + e.Message + "\n");
            }

            //-----------------------------------------------------------------------
            // Recherche des comptes dont le solde est supérieur à une valeur saisie
            Console.Write("\n Saisir le solde du seuil: ");
            try
            {
                float seuil = Convert.ToSingle(Console.ReadLine());
                resultat = leConteneur.Where(x => x.Value.LeSolde > seuil);
                foreach (KeyValuePair<String, Compte> paire in resultat)
                {
                    paire.Value.Afficher();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n Compte absent de la liste " + e.Message + "\n");
            }

        }
    }
}
