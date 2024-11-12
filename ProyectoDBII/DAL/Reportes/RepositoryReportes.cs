using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Reportes
{
    public class RepositoryReportes
    {

        private readonly Conexion _conexion;

        public RepositoryReportes()
        {
            _conexion = new Conexion();
        }

        /*
         * Reporte 1: Métodos de pago que más generan entre 2 fechas
         * */
        public DataTable ReporteMetodosPago(DateOnly fechaInicio, DateOnly fechaFinal)
        {
            DataTable tablaReporte = new DataTable();

            using (var connection = _conexion.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("totalFactura", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@fehcaInicio", SqlDbType.Date).Value = fechaInicio;

                    command.Parameters.Add("@fechaFinal", SqlDbType.Date).Value = fechaFinal;

                    using (var reader = command.ExecuteReader())
                    {
                        tablaReporte.Load(reader);
                    }
                }
            }

            return tablaReporte;
        }

        /*
         * Reporte 2: Productos que más generan entre 2 fechas
         */

        public DataTable ReporteProductosMasVendidos(DateOnly fechaInicio, DateOnly fechaFinal)
        {
            DataTable tablaReporte = new DataTable();

            using (var connection = _conexion.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("productosMasVendidosPorFecha", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@fehcaInicio", SqlDbType.Date).Value = fechaInicio;

                    command.Parameters.Add("@fechaFinal", SqlDbType.Date).Value = fechaFinal;

                    using (var reader = command.ExecuteReader())
                    {
                        tablaReporte.Load(reader);
                    }
                }
            }

            return tablaReporte;
        }

        /*
         * Reporte 3, Datos de una factura según su ID
         */

        public DataSet ReportesDatosFactura (int idFactura)
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


                    }
                }
            }

            return dataSetFactura;
        }

        /*
         * Reporte 4: Productos que es necesario hacer pedido a proveedores
         */

        public DataTable ReporteProductosExistenciaMinima()
        {
            DataTable tablaReporte = new DataTable();

            using (var connection = _conexion.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("reporteProductosExistencia", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        tablaReporte.Load(reader);
                    }

                }
            }

            return tablaReporte;
        }


        public DataSet ReporteEstadoPedidos()
        {
            DataSet dataSetFactura = new DataSet();

            using (var connection = _conexion.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("estadoProductos", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    

                    using (var reader = command.ExecuteReader())
                    {

                        DataTable pendientes = new DataTable();
                        pendientes.Load(reader);
                        dataSetFactura.Tables.Add(pendientes);

                        DataTable entregados = new DataTable();
                        entregados.Load(reader);
                        dataSetFactura.Tables.Add(entregados);

                    }
                }
            }

            return dataSetFactura;
        }

        public IEnumerable<dynamic> ListarFacturas()
        {
            using (var conection = _conexion.GetConnection())
            {
                conection.Open();
                var resultado = conection.Query<dynamic>("select id_Factura  from Factura where Estado = 1");
                return resultado;
            }
        }

    }
}
