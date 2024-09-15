
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Mueble;

namespace BLL.Mueble
{
    public class ServiceMarca : IServiceMarca
    {
        private readonly RepositoryMarca _marcaDAL;

        public ServiceMarca()
        {
            _marcaDAL = new RepositoryMarca();
        }

        public DataTable ListarMarcas()
        {
            return _marcaDAL.ListarMarcas();
        }

        public void AgregarMarca(string marca, bool estado)
        {
            try
            {
                _marcaDAL.InsertarMarca(marca, estado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error al agregar la marca. \nError: {ex.Message}");
            }
        }

        public void EditarMarca(int idMarca, string marca, bool estado)
        {
            try
            {
                _marcaDAL.EditarMarca(idMarca, marca, estado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error al actualizar la marca. \nError: {ex.Message}");
            }
        }

        public void EliminarMarca(int idMarca)
        {
            try
            {
                _marcaDAL.EliminarMarca(idMarca);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error al eliminar la marca. \nError: {ex.Message}");
            }
        }
    }

}
