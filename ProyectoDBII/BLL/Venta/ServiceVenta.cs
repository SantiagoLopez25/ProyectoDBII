using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Compra;
using DAL.Venta;

using static BLL.Venta.Modelos;


namespace BLL.Venta
{
    public class ServiceVenta : IServiceVenta
    {
        private readonly RepositoryVenta _ventaDAL;
        public ServiceVenta()
        {
            _ventaDAL = new RepositoryVenta();
        }

        
        public DataTable ListarMuebles()
        {
            return _ventaDAL.ListarMuebles();
        }

        public DataTable ListarVentas()
        {
            return _ventaDAL.ListarVentas();
        }
        public DataTable BuscarNit(string nit)
        {
            return _ventaDAL.BuscarNit(nit);
        }
        public DataTable ListarTiposPago()
        {
            return _ventaDAL.ListarTiposPago();
        }

        public DataTable ListarSeriesFacturas()
        {
            return _ventaDAL.ListarSeriesFacturas();
        }
        public DataTable BuscarDireccionesEntregaCliente(int id_Cliente)
        {
            return _ventaDAL.BuscarDireccionesEntregaCliente(id_Cliente);
        }
        public DataTable BuscarClientePorNombre(string nombreCliente)
        {
            return _ventaDAL.BuscarClientePorNombre(nombreCliente);
        }
        public DataTable BuscarDireccionesEntregaClientePorNombre(string nombreCliente)
        {
            return _ventaDAL.BuscarDireccionesEntregaClientePorNombre(nombreCliente);
        }

        public string GenerarFactura(List<DetalleFacturaModel> detalle, string serie, ClienteModel cliente,
        DireccionEntregaModel direccionEntrega, PagoModel pagos, int idUsuario)
        {
            // Convertir el detalle a DataTable para enviarlo a DAL
            DataTable detalleTable = ConvertirDetalleADataTable(detalle);

            // Delegar la llamada al método en la capa DAL, donde ya se maneja la transacción
            return _ventaDAL.GenerarFactura(
                detalleTable,
                serie,
                cliente.IdCliente,
                cliente.NombreCliente,
                cliente.DireccionFacturacion,
                cliente.Telefono,
                cliente.Correo,
                cliente.NIT,
                direccionEntrega.IdDireccionEntrega,
                direccionEntrega.Direccion,
                direccionEntrega.DescripcionEntrega,
                direccionEntrega.TelefonoReferencia,
                direccionEntrega.FechaEntrega,
                direccionEntrega.HoraEntrega,
                pagos.IdTipoPago1,
                pagos.IdTipoPago2,
                pagos.IdTipoPago3,
                pagos.PorcentajePago1,
                pagos.PorcentajePago2,
                pagos.PorcentajePago3,
                idUsuario
            );
        }

        private DataTable ConvertirDetalleADataTable(List<DetalleFacturaModel> detalle)
        {
            // Aquí se convierte el detalle en DataTable para mandarlo al procedimiento almacenado
            var table = new DataTable();
            table.Columns.Add("cantidad", typeof(int));
            table.Columns.Add("id_Mueble", typeof(int));

            foreach (var item in detalle)
            {
                var row = table.NewRow();
                row["cantidad"] = item.Cantidad;
                row["id_Mueble"] = item.IdMueble;
                table.Rows.Add(row);
            }

            return table;
        }

        public DataSet DatosImprimir(int idFactura)
        {
            return _ventaDAL.DatosImprimir(idFactura);

        }

        public void AnularFactura(int idFactura)
        {
            _ventaDAL.AnularFactura(idFactura);
        }
    }
}
