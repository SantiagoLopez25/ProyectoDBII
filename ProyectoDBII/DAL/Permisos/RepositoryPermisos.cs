using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace DAL.Permisos
{
    public class RepositoryPermisos :IRepositoryPermisos
    {

        private readonly Conexion _conexion;
        public RepositoryPermisos()
        {
            _conexion = new Conexion();
        }

        public DataTable ListarUsuarios()
        {
            DataTable resultado = new DataTable();
            using (var connection = _conexion.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("ListarUsuarios", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        resultado.Load(reader);
                        return resultado;
                    }
                }
            }
        }

        public IEnumerable<dynamic> ListarRoles()
        {
            using (var conection = _conexion.GetConnection())
            {
                conection.Open();
                var resultado = conection.Query<dynamic>("select nombre_rol from rol");
                return resultado;
            }
        }

        public string ActualizarPermisos(int id_usuario, int id_rol)
        {
            using (var conection = _conexion.GetConnection())
            {
                conection.Open();
                var sql = "update Usuario set id_Rol = @rol where id_Usuario = @usuario";
                conection.Execute(sql, new {usuario = id_usuario, rol = id_rol });
                return "Permisos actualizados";
            }
        }
    }
}
