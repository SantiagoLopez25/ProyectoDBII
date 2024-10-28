using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mueble
{
    public interface IServiceMarca
    {
        //Para
        DataTable ListarMarcas();
        void AgregarMarca(string marca, bool estado);
        void EditarMarca(int idMarca, string marca, bool estado);
        void EliminarMarca(int idMarca);
    }
}
