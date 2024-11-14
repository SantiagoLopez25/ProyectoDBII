using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Compra
{
    public class CompraRepository
    {
        private readonly Conexion _conexion;
        public CompraRepository() { 
            _conexion = new Conexion();
        }
        public DataTable ListarCompras()
        {
            DataTable tablCompras = new DataTable();

            using (var connection = _conexion.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("ListarCompras", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        tablCompras.Load(reader);
                    }
                }
            }

            return tablCompras;
        }

        public DataTable ListarTiposPago()
        {
            DataTable tablaTiposPago = new DataTable();

            using (var connection = _conexion.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("ListarTiposPago", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        tablaTiposPago.Load(reader);
                    }
                }
            }

            return tablaTiposPago;
        }

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

        public DataTable ListarMuebles()
        {
            DataTable tablaMuebles = new DataTable();

            using (var connection = _conexion.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("ListarMuebles", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        tablaMuebles.Load(reader);
                    }
                }
            }

            return tablaMuebles;
        }

        public void EliminarCompra(int idCompra)
        {
            using (var connection = _conexion.GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand("EliminarCompra", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id_Pedido", idCompra);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ocurrió un error al eliminar la compra. \nError: {ex.Message}");
                }
            }
        }


        public string GenerarCompra(
                    string descripcion,
                    DateTime? fechaPedido,
                    DateTime? fechaRecibido,
                    int cantidadPedido,
                    int? cantidadRecibido,
                    float totalPagar,
                    bool estado,
                    int idEstadoPedido,
                    int idTipoPago,
                    int idProveedor,
                    DataTable detalleTable
                )
        {
            string resultado = string.Empty;
            try
            {
                using (var connection = _conexion.GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("RegistrarCompra", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        var detalleParam = new SqlParameter("@DetallePedido", SqlDbType.Structured);
                        detalleParam.TypeName = "dbo.udt_DetallePedido";
                        detalleParam.Value = detalleTable;
                        command.Parameters.Add(detalleParam);

                        // Parámetros del procedimiento almacenado
                        command.Parameters.AddWithValue("@Descripcion", descripcion);
                        command.Parameters.AddWithValue("@FechaPedido", fechaPedido ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@FechaRecibido", fechaRecibido ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@CantidadPedido", cantidadPedido);
                        command.Parameters.AddWithValue("@CantidadRecibido", cantidadRecibido ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@TotalPagar", totalPagar);
                        command.Parameters.AddWithValue("@Estado", estado);
                        command.Parameters.AddWithValue("@id_EstadoPedido", idEstadoPedido);
                        command.Parameters.AddWithValue("@id_TipoPago", idTipoPago);
                        command.Parameters.AddWithValue("@id_Proveedor", idProveedor);

                        var resultadoParam = new SqlParameter("@resultado", SqlDbType.VarChar, 200);
                        resultadoParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultadoParam);

                        command.ExecuteNonQuery();
                        resultado = resultadoParam.Value.ToString();

                    }
                }
            }
            catch (Exception ex) {
                resultado = "ERROR: " + ex.Message;
            }
            return resultado;
        }

        public string ActualizarCompraYCrearStock(int idPedido, int cantidadRecibido, DateTime? fechaIngreso)
        {
            string resultado = string.Empty;
            try
            {
                using (var connection = _conexion.GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand("ActualizarCompraYCrearStock", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Parámetros de entrada
                        command.Parameters.AddWithValue("@id_Pedido", idPedido);
                        command.Parameters.AddWithValue("@CantidadRecibido", cantidadRecibido);
                        command.Parameters.AddWithValue("@FechaIngreso", fechaIngreso ?? (object)DBNull.Value);

                        var resultadoParam = new SqlParameter("@resultado", SqlDbType.VarChar, 200);
                        resultadoParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultadoParam);

                        command.ExecuteNonQuery();
                        resultado = resultadoParam.Value.ToString();
                    }
                }
            }catch(Exception ex)
            {
                resultado = "ERROR: " + ex.Message;
            }

            return resultado;
        }
    }
}
