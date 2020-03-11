using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace ClassesADO
{
    class Connexion
    {
        public class connexion {
            public static SqlConnection cn;
            public static string cnxstring = @"Data Source = (LocalDB)\MSSQLLocalDB;Initial Catalog = GestionCommande; Integrated Security = True; ";




        }
    }
}
