using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Compra;
using DAL.Persona.Empleado;

namespace BLL.Persona.Empleado
{
    public class ServiceEmpleado : IServiceEmpleado
    {
        //Declaración para utilizar la clase que se comunica con la BD (RepositoryEmpleado)
        private readonly RepositoryEmpleado _empleadoDAL;
        public ServiceEmpleado()
        {
            _empleadoDAL = new RepositoryEmpleado();
        }

        //Función para crear y retornar un Datatable para listar Empleadoes
        public DataTable ListarEmpleado()
        {
            return _empleadoDAL.ListarEmpleado();
        }

        //Función para Agregar Empleadoes
        public void AgregarEmpleado(string nombre, string telefono, string correo, bool estado)
        {
            try
            {
                _empleadoDAL.InsertarEmpleado(nombre, telefono, correo, estado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error al agregar el empleado. \nError: {ex.Message}");
            }
        }

        //Función para Editar Empleadoes
        public void EditarEmpleado(int idEmpleado, string nombre, string telefono, string correo, bool estado)
        {
            try
            {
                _empleadoDAL.EditarEmpleado(idEmpleado, nombre, telefono, correo, estado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error al actualizar el empleado. \nError: {ex.Message}");
            }
        }

        //Función para Eliminar Empleadoes
        public void EliminarEmpleado(int idEmpleado)
        {
            try
            {
                _empleadoDAL.EliminarEmpleado(idEmpleado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error al eliminar el empleado. \nError: {ex.Message}");
            }
        }
    }
}
