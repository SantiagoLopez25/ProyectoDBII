using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Compra
{
    public interface IServiceProveedor
    {


        //CREACIÓN DE PROCESOS QUE SE UTILIZARÁN CON RESPECTO A PROVEEDORES
        DataTable ListarProveedor();
        void AgregarProveedor(string proveedor, string direccion, string telefono, string telefonoExtra, string correo, bool estado);
        void EditarProveedor(int idProveedor, string proveedor, string direccion, string telefono, string telefonoExtra, string correo, bool estado);
        void EliminarProveedor(int idProveedor);
    }
}
