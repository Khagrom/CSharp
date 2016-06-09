using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace TP1Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly leProgramme;
            try
            {
                leProgramme = Assembly.LoadFrom("C:\\Temp\\TP1\\TP1\\bin\\Debug\\TP1.exe");
                // nom complet de l'assemblage
                System.Console.WriteLine("--- Nom de l'assemblage ---");
                System.Console.WriteLine(leProgramme.FullName);

                System.Console.WriteLine("--- Les types exportés ---");
                // les types exposés par l'assemblage
                Type[] lesTypes = leProgramme.GetExportedTypes();
                foreach (Type unType in lesTypes)
                {
                    // les membres publics du type
                    MemberInfo[] membresDuType = unType.GetMembers();

                    Console.WriteLine("\n-- Méthodes présentes dans la classe: " + unType.FullName);
                    foreach (MemberInfo unMembre in membresDuType)
                    {
                        if (unMembre.MemberType == MemberTypes.Method)
                        {
                            Console.Write("Methode : " + unMembre.Name + " \t\t : ");
                            Console.WriteLine(unMembre.ToString());
                        }
                    }

                    Console.WriteLine("\n-- Propriétés présentes dans la classe: " + unType.FullName);
                    foreach (MemberInfo unMembre in membresDuType)
                    {
                        if (unMembre.MemberType == MemberTypes.Property)
                        {
                            Console.Write("Propriété : " + unMembre.Name + " \t\t : ");
                            Console.WriteLine(unMembre.ToString());
                        }
                    }
                }
                System.Console.ReadKey();

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

           



        }
    }
}
