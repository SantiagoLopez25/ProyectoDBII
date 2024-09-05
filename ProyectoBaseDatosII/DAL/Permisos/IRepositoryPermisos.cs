using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Permisos
{
    internal interface IRepositoryPermisos
    {
        IEnumerable<dynamic> ListarRoles();
        IEnumerable<dynamic> ListarUsuarios();
        string ActualizarPermisos(int id_usuario, int id_rol);
    }
}
