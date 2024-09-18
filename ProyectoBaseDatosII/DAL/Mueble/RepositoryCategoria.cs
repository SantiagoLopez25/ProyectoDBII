using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mueble
{
    public class RepositoryCategoria
    {
        private readonly Conexion _conexion;

        public RepositoryCategoria()
        {
            _conexion = new Conexion();
        }


        public DataTable ListarCategorias()
        {
            DataTable tablaCategorias = new DataTable();

            using (var connection = _conexion.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("ListarCategoria", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        tablaCategorias.Load(reader);
                    }
                }
            }

            return tablaCategorias;
        }

        public void InsertarCategoria(string Categoria, bool estado)
        {
            using (var connection = _conexion.GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand("InsertarCategoria", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Categoria", Categoria);
                        command.Parameters.AddWithValue("@Estado", estado);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ocurrió un error al registrar la Categoria. \nError: {ex.Message}");
                }
            }
        }

        public void EditarCategoria(int idCategoria, string Categoria, bool estado)
        {
            using (var connection = _conexion.GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand("ActualizarCategoria", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id_Categoria", idCategoria);
                        command.Parameters.AddWithValue("@Categoria", Categoria);
                        command.Parameters.AddWithValue("@Estado", estado);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ocurrió un error al actualizar la Categoria. \nError: {ex.Message}");
                }
            }
        }

        public void EliminarCategoria(int idCategoria)
        {
            using (var connection = _conexion.GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand("EliminarCategoria", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id_Categoria", idCategoria);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ocurrió un error al eliminar la Categoria. \nError: {ex.Message}");
                }
            }
        }
    }
}
