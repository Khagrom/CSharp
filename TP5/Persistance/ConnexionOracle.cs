using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public static class ConnexionOracle
    {
        // chaîne de conexion
        public static String oradb =
            "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)" +
            "(HOST=iutdoua-oracle.univ-lyon1.fr)(PORT=1521))" +
            "(CONNECT_DATA=(SERVICE_NAME=orcl.univ-lyon1.fr)));" +
            " User Id=p1513113;Password=248488;";

        // méthode de connexion
        public static OracleConnection GetInstance()
        {
            OracleConnection connexion = new OracleConnection(oradb);
            connexion.Open();
            return connexion;
        }
    }
}
