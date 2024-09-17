using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Compra
{
    public class RepositoryProveedor
    {
        //Declarar conexión a la BD
        private readonly Conexion _conexion;

        public RepositoryProveedor()
        {
            _conexion = new Conexion();
        }

        //Llamar a Proc almacenado para listar proveedores
        public DataTable ListarProveedor()
        {
            DataTable tablaProveedor = new DataTable();

            using (var connection = _conexion.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("ListarProveedor", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        tablaProveedor.Load(reader);
                    }
                }
            }

            return tablaProveedor;
        }

        //Llamar proc almacenado para insertar un nuevo proveedor
        public void InsertarProveedor(string proveedor, string direccion, string telefono, string telefonoExtra, string correo, bool estado)
        {
            using (var connection = _conexion.GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand("InsertarProveedor", connection))
                    {
                        //Se específica el tipo de consulta (Procedimiento Almacenado)
                        command.CommandType = CommandType.StoredProcedure;
                        //Se deben declarar los parámetros como está en el script de la BD
                        command.Parameters.AddWithValue("@Proveedor", proveedor);
                        command.Parameters.AddWithValue("@Direccion", direccion);
                        command.Parameters.AddWithValue("@Telefono", telefono);
                        command.Parameters.AddWithValue("@TelefonoExtra", telefonoExtra);
                        command.Parameters.AddWithValue("@Correo", correo);
                        command.Parameters.AddWithValue("@Estado", estado);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ocurrió un error al registrar el proveedor. \nError: {ex.Message}");
                }
            }
        }

        //Lllamar proc Almacenado para editar Proveedor
        public void EditarProveedor(int idProveedor, string proveedor, string direccion, string telefono, string telefonoExtra, string correo, bool estado)
        {
            using (var connection = _conexion.GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand("ActualizarProveedor", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id_Proveedor", idProveedor);
                        command.Parameters.AddWithValue("@Proveedor", proveedor);
                        command.Parameters.AddWithValue("@Direccion", direccion);
                        command.Parameters.AddWithValue("@Telefono", telefono);
                        command.Parameters.AddWithValue("@TelefonoExtra", telefonoExtra);
                        command.Parameters.AddWithValue("@Correo", correo);
                        command.Parameters.AddWithValue("@Estado", estado);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ocurrió un error al actualizar el proveedor. \nError: {ex.Message}");
                }
            }
        }

        //Llamar Proc Almacenado para Eliminar Proveedor
        public void EliminarProveedor(int idProveedor)
        {
            using (var connection = _conexion.GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand("EliminarProveedor", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id_Proveedor", idProveedor);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ocurrió un error al eliminar el proveedor. \nError: {ex.Message}");
                }
            }
        }
    }
}
