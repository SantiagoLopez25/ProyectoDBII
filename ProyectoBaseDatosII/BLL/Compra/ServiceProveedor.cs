using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Compra;

namespace BLL.Compra
{
    public class ServiceProveedor : IServiceProveedor
    {

        //Declaración para utilizar la clase que se comunica con la BD (RepositoryProveedor) 
        private readonly RepositoryProveedor _proveedorDAL;

        public ServiceProveedor()
        {
            _proveedorDAL = new RepositoryProveedor();
        }

        //Función para crear y retornar un Datatable para listar Proveedores
        public DataTable ListarProveedor()
        {
            return _proveedorDAL.ListarProveedor();
        }

        //Función para Agregar Proveedores
        public void AgregarProveedor(string proveedor, string direccion, string telefono, string telefonoExtra, string correo, bool estado)
        {
            try
            {
                _proveedorDAL.InsertarProveedor(proveedor, direccion, telefono, telefonoExtra, correo, estado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error al agregar el proveedor. \nError: {ex.Message}");
            }
        }

        //Función para Editar Proveedores
        public void EditarProveedor(int idProveedor, string proveedor, string direccion, string telefono, string telefonoExtra, string correo, bool estado)
        {
            try
            {
                _proveedorDAL.EditarProveedor(idProveedor, proveedor, direccion, telefono, telefonoExtra, correo, estado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error al actualizar el proveedor. \nError: {ex.Message}");
            }
        }

        //Función para Eliminar Proveedores
        public void EliminarProveedor(int idProveedor)
        {
            try
            {
                _proveedorDAL.EliminarProveedor(idProveedor);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error al eliminar el proveedor. \nError: {ex.Message}");
            }
        }

    }
}
