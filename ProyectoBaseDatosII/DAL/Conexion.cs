using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL
{
    public class Conexion
    {
        private readonly string connectionString;
        static string server = "COMPUSAQS\\SQLEXPRESS";
        static string user = "sa";
        static string password = "database";
        public Conexion ()
        {
            connectionString = "Server = "+server +"; Database = VentaMuebles; User Id = "+user+"; Password = "+password+"; Encrypt = True; TrustServerCertificate = True; ";
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
