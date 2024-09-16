using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Permisos
{
    internal interface IPermisosService
    {
        IEnumerable<dynamic> ListaRoles();
        DataTable ListaUsuarios();

        string cambioPermiso(int id_usuairo, int id_rol);
    }
}
