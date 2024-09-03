using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Permisos
{
    internal interface IPermisosService
    {
        IEnumerable<dynamic> ListaRoles();
        IEnumerable<dynamic> ListaUsuarios();

        string cambioPermiso(int id_usuairo, int id_rol);
    }
}
