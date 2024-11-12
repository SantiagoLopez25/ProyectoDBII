using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Conexion
    {

        

        private readonly string connectionString;
        static string server = "localhost"; //No cambiar
        static string database = "VentaMuebles";
        static string user = "sa";
        static string password = "1234";


        public Conexion()
        {
           connectionString = "Server = " + server + "; Database = " + database +"; User Id = " + user + "; Password = " + password + "; Encrypt = True; TrustServerCertificate = True; ";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

       
    }
}
