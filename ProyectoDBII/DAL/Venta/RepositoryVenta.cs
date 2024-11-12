using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;

namespace DAL.Venta
{
    public class RepositoryVenta
    {
        private readonly Conexion _conexion;

        public RepositoryVenta()
        {
            _conexion = new Conexion();
        }

        public DataTable ListarMuebles()
        {
            DataTable tablaMuebles = new DataTable();

            using (var connection = _conexion.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("ExistenciasMuebles", connection))
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


        public DataSet DatosImprimir(int idFactura)
        {
            DataSet dataSetFactura = new DataSet();

            using (var connection = _conexion.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("datosFactura", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@idFactura", SqlDbType.Int).Value = idFactura;

                    using (var reader = command.ExecuteReader())
                    {
                       
                        DataTable encabezadoFactura = new DataTable();
                        encabezadoFactura.Load(reader);
                        dataSetFactura.Tables.Add(encabezadoFactura);

                        DataTable detalleFactura = new DataTable();
                        detalleFactura.Load(reader);
                        dataSetFactura.Tables.Add(detalleFactura);
                        DataTable pagoFactura = new DataTable();
                        pagoFactura.Load(reader);
                        dataSetFactura.Tables.Add(pagoFactura);

                        //if (reader.NextResult())
                        //{

                        //    DataTable pagoFactura = new DataTable();
                        //    pagoFactura.Load(reader);
                        //    dataSetFactura.Tables.Add(pagoFactura);
                        //}


                        /* if (reader.NextResult())
                         {

                         }*/


                    }
                }
            }

            return dataSetFactura;
        }

        public DataTable ListarVentas()
        {
            DataTable tablaVentas = new DataTable();

            using (var connection = _conexion.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("ListarVentas", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        tablaVentas.Load(reader);
                    }
                }
            }

            return tablaVentas;
        }

        public DataTable BuscarNit(string nit)
        {
            DataTable tablaCliente = new DataTable();
            using (var connection = _conexion.GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand("BuscarClientePorNit", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@nit", nit);

                        using (var reader = command.ExecuteReader())
                        {
                            tablaCliente.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ocurrió un error al buscar el cliente. \nError: {ex.Message}");
                }
            }
            return tablaCliente;
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

        public DataTable ListarSeriesFacturas()
        {
            DataTable tablaTiposPago = new DataTable();

            using (var connection = _conexion.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("ListarSeriesDeFactura", connection))
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

        public DataTable BuscarDireccionesEntregaCliente(int id_Cliente)
        {
            DataTable tablaDirecciones = new DataTable();
            using (var connection = _conexion.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("BuscarDireccionesEntregaCliente", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id_cliente", id_Cliente);

                    using (var reader = command.ExecuteReader())
                    {
                        tablaDirecciones.Load(reader);
                    }

                }
            }
            return tablaDirecciones;
        }
        public DataTable BuscarClientePorNombre(string nombreCliente)
        {
            DataTable tablaCliente = new DataTable();
            using (var connection = _conexion.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("BuscarClientePorNombre", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombre_cliente", nombreCliente);

                    using (var reader = command.ExecuteReader())
                    {
                        tablaCliente.Load(reader);
                    }

                }
            }
            return tablaCliente;
        }
        public DataTable BuscarDireccionesEntregaClientePorNombre(string nombreCliente)
        {
            DataTable tablaDirecciones = new DataTable();
            using (var connection = _conexion.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("BuscarDireccionesEntregaClientePorNombre", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombre_cliente", nombreCliente);

                    using (var reader = command.ExecuteReader())
                    {
                        tablaDirecciones.Load(reader);
                    }

                }
            }
            return tablaDirecciones;
        }

        public string GenerarFactura(DataTable detalle, string serie, int? idCliente, string nombreCliente,
    string direccionFacturacion, string telefono, string correo, string nit, int? idDireccionEntrega,
    string direccionEntrega, string descripcionEntrega, string telefonoReferencia, DateTime fechaEntrega,
    TimeSpan horaEntrega, int idTipoPago1, int? idTipoPago2, int? idTipoPago3,
    float? porcentajePago1, float? porcentajePago2, float? porcentajePago3, int idUsuario)
        {
            string resultado = string.Empty;

            try
            {
                using (var connection = _conexion.GetConnection())
                {
                    connection.Open();

                    using (var command = new SqlCommand("GenerarFactura", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        var detalleParam = new SqlParameter("@detalle", SqlDbType.Structured);
                        detalleParam.TypeName = "dbo.udt_DetalleFactura";
                        detalleParam.Value = detalle;
                        command.Parameters.Add(detalleParam);

                        command.Parameters.AddWithValue("@serie", serie);
                        command.Parameters.AddWithValue("@id_cliente", idCliente);
                        command.Parameters.AddWithValue("@nombre_cliente", nombreCliente ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@direccion_Facturacion", direccionFacturacion ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@telefono", telefono ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@correo", correo ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@nit", nit);
                        command.Parameters.AddWithValue("@id_DireccionEntrega", idDireccionEntrega);
                        command.Parameters.AddWithValue("@direccionEntrega", direccionEntrega ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@descripcionEntrega", descripcionEntrega);
                        command.Parameters.AddWithValue("@telefonoReferencia", telefonoReferencia);
                        command.Parameters.AddWithValue("@fechaEntrega", fechaEntrega);
                        command.Parameters.AddWithValue("@horaEntrega", horaEntrega);
                        command.Parameters.AddWithValue("@idTTipoPago1", idTipoPago1);
                        command.Parameters.AddWithValue("@idTTipoPago2", idTipoPago2 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@idTipoPago3", idTipoPago3 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@cantidad1", porcentajePago1 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@cantidad2", porcentajePago2 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@cantidad3", porcentajePago3 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@id_Usuario", idUsuario);

                        var resultadoParam = new SqlParameter("@resultado", SqlDbType.VarChar, 200);
                        resultadoParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(resultadoParam);

                        command.ExecuteNonQuery();
                        resultado = resultadoParam.Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                resultado = "Error: " + ex.Message;
            }

            return resultado;
        }


        
    }
}
