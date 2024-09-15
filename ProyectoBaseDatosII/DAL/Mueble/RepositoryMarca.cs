using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mueble
{
    public class RepositoryMarca
    {
        private readonly Conexion _conexion;

        public RepositoryMarca()
        {
            _conexion = new Conexion();
        }

        public DataTable ListarMarcas()
        {
            DataTable tablaMarcas = new DataTable();

            using (var connection = _conexion.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("ListarMarca", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        tablaMarcas.Load(reader);
                    }
                }
            }

            return tablaMarcas;
        }

        public void InsertarMarca(string marca, bool estado)
        {
            using (var connection = _conexion.GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand("InsertarMarca", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Marca", marca);
                        command.Parameters.AddWithValue("@Estado", estado);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ocurrió un error al registrar la marca. \nError: {ex.Message}");
                }
            }
        }

        public void EditarMarca(int idMarca, string marca, bool estado)
        {
            using (var connection = _conexion.GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand("ActualizarMarca", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id_Marca", idMarca);
                        command.Parameters.AddWithValue("@Marca", marca);
                        command.Parameters.AddWithValue("@Estado", estado);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ocurrió un error al actualizar la marca. \nError: {ex.Message}");
                }
            }
        }

        public void EliminarMarca(int idMarca)
        {
            using (var connection = _conexion.GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand("EliminarMarca", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id_Marca", idMarca);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ocurrió un error al eliminar la marca. \nError: {ex.Message}");
                }
            }
        }
    }

}
