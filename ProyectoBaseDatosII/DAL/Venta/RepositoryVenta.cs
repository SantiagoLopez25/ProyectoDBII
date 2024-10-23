using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

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


    }
}
