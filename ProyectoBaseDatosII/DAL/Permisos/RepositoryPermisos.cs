using Dapper;
using System.Collections.Generic;
using System.Data;

namespace DAL.Permisos
{
    public class RepositoryPermisos :IRepositoryPermisos
    {
        
        

        public IEnumerable<dynamic> ListarUsuarios()
        {
            using (var conection = new Conexion().Cadena())
            {
                conection.Open();
                var resultado = conection.Query<dynamic>("select id_Usuario, nombre, usuario, nombre_rol from usuario inner join rol on Usuario.id_Rol = rol.id_Rol inner join Empleado on Empleado.id_Empleado = Usuario.id_Empleado");
                return resultado;
            }
        }

        public IEnumerable<dynamic> ListarRoles()
        {
            using (var conection = new Conexion().Cadena())
            {
                conection.Open();
                var resultado = conection.Query<dynamic>("select nombre_rol from rol");
                return resultado;
            }
        }

        public string ActualizarPermisos(int id_usuario, int id_rol)
        {
            using (var conection = new Conexion().Cadena())
            {
                conection.Open();
                var sql = "update Usuario set id_Rol = @rol where id_Usuario = @usuario";
                conection.Execute(sql, new {usuario = id_usuario, rol = id_rol });
                return "Permisos actualizados";
            }
        }
    }
}
