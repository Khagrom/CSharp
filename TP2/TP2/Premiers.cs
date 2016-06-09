using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP2
{
    public class Premiers
    {
        private static int nbElem;
        private static int[] tabPremiers;

        public static int Nombre
        {
            get { return nbElem; }
            set { nbElem = value > 0 ? value : 0; }
        }

        public static void Main(string[] args)
        {
            // saisie
            Console.Write("\n Saisir le nombre de premiers voulus : ");
            Nombre = Convert.ToInt32(Console.ReadLine());

            // on définit un tableau d'entiers
            tabPremiers = new int[Nombre];

            // déclaration des variables locales
            int compteur = 0;   // compte le nombre de premiers trouvés
            int courant = 1;    // représente l'entier naturel courant
            try
            {
                while (compteur < Nombre)
                {
                    if (Premiers.EstPremier(courant) == true)
                    {
                        tabPremiers[compteur] = courant;
                        compteur++;
                    }
                    courant++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (int element in tabPremiers)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();

        }

        public static bool EstPremier(int n)
        {
            if (n < 0)
            {
                throw new Exception("entier non naturel");
            }
            if (n <= 1)
            {
                return false;
            }
            if (n == 2)
            {
                return true;
            }
            if (n % 2 == 0)
            {
                return false;
            }                
            int racine = (int)Math.Sqrt(n);
            for (int i = 3; i <= racine; i += 2)
            {
                if (n % i == 0)
                {	// il y a un diviseur non pair
                    return false;	// donc n n'est pas premier
                }
            }
            return true;
        }
    }
}
