using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mueble
{
    public interface IRepositoryMarca
    {
        DataTable ListarMarcas();
        void AgregarMarca(string marca, bool estado);
        void ActualizarMarca(int idMarca, string marca, bool estado);
        void EliminarMarca(int idMarca);

    }
}
