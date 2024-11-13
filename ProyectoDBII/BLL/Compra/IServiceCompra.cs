using DAL.Compra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static BLL.Compra.Modelos;
using System.Data;

namespace BLL.Compra
{
    public interface IServiceCompra
    {
        DataTable ListarMuebles();
        DataTable ListarCompras();
        DataTable ListarTiposPago();
        DataTable ListarProveedores();
        public void EliminarCompra(int idCompra);

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
        );

    }
}
