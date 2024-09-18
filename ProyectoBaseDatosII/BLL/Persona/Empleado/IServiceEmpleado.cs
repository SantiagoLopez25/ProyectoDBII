using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Persona.Empleado
{
    public interface IServiceEmpleado
    {
        DataTable ListarEmpleado();
        void AgregarEmpleado(string nombre, string telefono, string correo, bool estado);
        void EditarEmpleado(int idEmpleado, string nombre, string telefono, string correo, bool estado);
        void EliminarEmpleado(int idEmpleado);
    }
}
