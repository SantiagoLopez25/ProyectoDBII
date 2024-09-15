using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Login
{
    public class RepositoryLogin : IRepositoryLogin
    {
        
        private readonly Conexion _conexion;
        public RepositoryLogin()
        {
            _conexion = new Conexion();
        }

        public string InicioDeSesion(string user, string password)
        {
            using (var connection = _conexion.GetConnection())
            {
                connection.Open();
                string sql = "select dbo.f_login(@usuario, @contrasennia)";
                return connection.ExecuteScalar<string>(sql, new { usuario = user, contrasennia = password });
              

            }
        }

    }
}
