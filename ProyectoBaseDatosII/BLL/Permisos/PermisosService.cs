using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Login;
using DAL.Permisos;

namespace BLL.Permisos
{
    public class PermisosService :IPermisosService
    {
        private readonly RepositoryPermisos repositoryPermisos = new RepositoryPermisos();
        public IEnumerable<dynamic> ListaRoles()
        {
            return repositoryPermisos.ListarRoles();
        }

        public DataTable ListaUsuarios()
        {
            return repositoryPermisos.ListarUsuarios();
        }

        public string cambioPermiso(int id_usuairo, int id_rol)
        {
            return repositoryPermisos.ActualizarPermisos(id_usuairo, id_rol);
        }
    }
}
