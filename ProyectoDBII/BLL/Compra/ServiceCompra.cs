using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Compra;

using static BLL.Compra.Modelos;


namespace BLL.Compra
{
    public class ServiceCompra : IServiceCompra
    {
        private readonly CompraRepository _compraDAL;

        public ServiceCompra()
        {
            _compraDAL = new CompraRepository();
        }

        // Método para listar productos disponibles para compra
        public DataTable ListarMuebles()
        {
            return _compraDAL.ListarMuebles();
        }

        // Método para listar todas las compras realizadas
        public DataTable ListarCompras()
        {
            return _compraDAL.ListarCompras();
        }

        // Método para listar los tipos de pago disponibles para compras
        public DataTable ListarTiposPago()
        {
            return _compraDAL.ListarTiposPago();
        }

        // Método para listar los proveedores registrados
        public DataTable ListarProveedores()
        {
            return _compraDAL.ListarProveedor();
        }

        public void EliminarCompra(int idCompra)
        {
            try
            {
                _compraDAL.EliminarCompra(idCompra);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error al eliminar la compra. \nError: {ex.Message}");
            }
        }

        public string ActualizarCompraYCrearStock(int idPedido, int cantidadRecibido, DateTime? fechaIngreso)
        {
            // Validación o lógica adicional (opcional)
            if (cantidadRecibido <= 0)
            {
                return "La cantidad recibida debe ser mayor que cero.";
            }

            // Llama al método de la capa DAL
            string resultado = _compraDAL.ActualizarCompraYCrearStock(idPedido, cantidadRecibido, fechaIngreso);

            return resultado;
        }

        // Método para generar una orden de compra
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
           List<DetalleCompraModel> detalle
       )
        {
            // Convertir detalle a DataTable
            DataTable detalleTable = ConvertirDetalleADataTable(detalle);

            // Llamar al método en DAL para ejecutar el procedimiento almacenado
            return _compraDAL.GenerarCompra(
                descripcion,
                fechaPedido,
                fechaRecibido,
                cantidadPedido,
                cantidadRecibido,
                totalPagar,
                estado,
                idEstadoPedido,
                idTipoPago,
                idProveedor,
                detalleTable
            );
        }

        private DataTable ConvertirDetalleADataTable(List<DetalleCompraModel> detalle)
        {
            // Crear y llenar el DataTable con los detalles de la compra
            var table = new DataTable();
            table.Columns.Add("cantidad", typeof(int));
            table.Columns.Add("id_mueble", typeof(int));

            foreach (var item in detalle)
            {
                var row = table.NewRow();
                row["cantidad"] = item.Cantidad;
                row["id_mueble"] = item.IdMueble;
                table.Rows.Add(row);
            }

            return table;
        }
    }
}
