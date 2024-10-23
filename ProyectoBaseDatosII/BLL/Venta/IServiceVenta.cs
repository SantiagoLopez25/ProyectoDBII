using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static BLL.Venta.Modelos;


namespace BLL.Venta
{
    public interface IServiceVenta
    {
        DataTable ListarMuebles();
        DataTable ListarVentas();
        DataTable BuscarNit(string nit);
        DataTable ListarTiposPago();

        DataTable ListarSeriesFacturas();
        DataTable BuscarDireccionesEntregaCliente(int id_Cliente);
        DataTable BuscarClientePorNombre(string nombreCliente);
        DataTable BuscarDireccionesEntregaClientePorNombre(string nombreCliente);
        public string GenerarFactura(
            List<DetalleFacturaModel> detalle,
            string serie,
            ClienteModel cliente,
            DireccionEntregaModel direccionEntrega,
            PagoModel pagos,
            int idUsuario
        );

        DataSet DatosImprimir(int idFactura);

    }
}
