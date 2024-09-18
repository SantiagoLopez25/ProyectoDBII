using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Persona.Empleado
{
    public class RepositoryEmpleado
    {
        //Declarar conexión a la BD
        private readonly Conexion _conexion;
        public RepositoryEmpleado()
        {
            _conexion = new Conexion();
        }

        //Llamar a Proc almacenado para listar empleados
        public DataTable ListarEmpleado()
        {
            DataTable tablaEmpleado = new DataTable();

            using (var connection = _conexion.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("ListarEmpleado", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        tablaEmpleado.Load(reader);
                    }
                }
            }

            return tablaEmpleado;
        }

        //Llamar proc almacenado para insertar un nuevo empleado
        public void InsertarEmpleado(string nombre, string telefono, string correo, bool estado)
        {
            using (var connection = _conexion.GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand("InsertarEmpleado", connection))
                    {
                        //Se específica el tipo de consulta (Procedimiento Almacenado)
                        command.CommandType = CommandType.StoredProcedure;
                        //Se deben declarar los parámetros como está en el script de la BD
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Telefono", telefono);
                        command.Parameters.AddWithValue("@Correo", correo);
                        command.Parameters.AddWithValue("@Estado", estado);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ocurrió un error al registrar el empleado. \nError: {ex.Message}");
                }
            }
        }

        //Lllamar proc Almacenado para editar Empleado
        public void EditarEmpleado(int idEmpleado, string nombre, string telefono, string correo, bool estado)
        {
            using (var connection = _conexion.GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand("ActualizarEmpleado", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id_Empleado", idEmpleado);
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Telefono", telefono);
                        command.Parameters.AddWithValue("@Correo", correo);
                        command.Parameters.AddWithValue("@Estado", estado);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ocurrió un error al actualizar el empleado. \nError: {ex.Message}");
                }
            }
        }

        //Llamar Proc Almacenado para Eliminar Empleado
        public void EliminarEmpleado(int idEmpleado)
        {
            using (var connection = _conexion.GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand("EliminarEmpleado", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id_Empleado", idEmpleado);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ocurrió un error al eliminar el empleado. \nError: {ex.Message}");
                }
            }
        }
    }
}
