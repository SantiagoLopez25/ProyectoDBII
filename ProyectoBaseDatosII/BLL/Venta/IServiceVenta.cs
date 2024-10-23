using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Venta
{
    public interface IServiceVenta
    {
        DataTable ListarMuebles();
        DataTable ListarVentas();
        DataTable BuscarNit(string nit);
        DataTable ListarTiposPago();

        DataSet DatosImprimir(int idFactura);
    }
}
