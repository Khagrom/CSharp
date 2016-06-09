using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Metier;

namespace Persistance
{
    public class DaoOracleEtudiant
    {
        private OracleConnection cnx;

        public DaoOracleEtudiant(OracleConnection cnx)
        {
            this.cnx = cnx;
        }

        public List<Etudiant> LesEtudiants()
        {
            List<Etudiant> listeEtudiants = new List<Etudiant>();
            OracleCommand cmd = cnx.CreateCommand();
            cmd.CommandText = "SELECT numetu, nometu, moyenne, groupe FROM etudiant";
            OracleDataReader odr = cmd.ExecuteReader();
            while (odr.Read() == true)
            {
                Etudiant etu = new Etudiant(odr[0].ToString(),
                                            odr[1].ToString(),
                                            Single.Parse(odr[2].ToString()),
                                            odr[3].ToString());
                listeEtudiants.Add(etu);
            }
            return listeEtudiants;
        }
    }
}
