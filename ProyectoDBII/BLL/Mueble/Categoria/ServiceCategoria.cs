using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Mueble;

namespace BLL.Mueble.Categoria
{
    public class ServiceCategoria : IServiceCategoria
    {
        private readonly RepositoryCategoria _categoriaDAL;

        public ServiceCategoria()
        {
            _categoriaDAL = new RepositoryCategoria();
        }
        //Para
        public DataTable ListarCategorias()
        {
            return _categoriaDAL.ListarCategorias();
        }

        public void AgregarCategoria(string categoria, bool estado)
        {
            try
            {
                _categoriaDAL.InsertarCategoria(categoria, estado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error al agregar la categoria. \nError: {ex.Message}");
            }
        }

        public void EditarCategoria(int idCategoria, string categoria, bool estado)
        {
            try
            {
                _categoriaDAL.EditarCategoria(idCategoria, categoria, estado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error al actualizar la categoria. \nError: {ex.Message}");
            }
        }

        public void EliminarCategoria(int idCategoria)
        {
            try
            {
                _categoriaDAL.EliminarCategoria(idCategoria);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error al eliminar la categoria. \nError: {ex.Message}");
            }
        }
    }
}
