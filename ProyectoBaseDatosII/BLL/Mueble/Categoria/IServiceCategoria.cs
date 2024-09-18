using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mueble.Categoria
{
    public interface IServiceCategoria
    {
        DataTable ListarCategorias();
        void AgregarCategoria(string Categoria, bool estado);
        void EditarCategoria(int idCategoria, string Categoria, bool estado);
        void EliminarCategoria(int idCategoria);
    }
}
