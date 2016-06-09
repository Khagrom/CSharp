using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Etudiant
    {
        public Etudiant(String numero, String nom, float moyenne, String groupe)
        {
            NumeroEtudiant = numero;
            NomEtudiant = nom;
            MoyenneEtudiant = moyenne;
            GroupeEtudiant = groupe;
        }
        public Etudiant() { }

        public String NumeroEtudiant { get; set; }
        public String NomEtudiant { get; set; }
        public float MoyenneEtudiant { get; set; }
        public String GroupeEtudiant { get; set; }
    }
}
