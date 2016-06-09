using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP1
{
    public class Hello
    {
        public static String Mesg{get; set;}

        public static void Main(String[] args)
        {
            Hello.LaDate();
            Hello.Afficher();
            Console.WriteLine("\n\n Au Revoir ...\n\n");
            System.Console.ReadKey();
        }

        public static void Afficher() {
            // on saisit le prénom
            Console.Write("Saisir votre prénom : ");
            String prenom = Console.ReadLine();
            Mesg += " Hello " + prenom;
            // affichage du prénom
            Console.WriteLine("\n" + Mesg);
        }

        public static void LaDate()
        {
            // on récupère une structure DateTime correspondant à aujourd'hui
            DateTime moment = DateTime.Now;
            // format de la date jj/mm/aaaa
            String strDate = moment.ToString("d");
            // format de l'heure hh:mm
            String strHeure = moment.ToString("t");
            // affectation de la propriété
            Mesg = strDate + " -- " + strHeure + " -- ";
        }
    }
}
