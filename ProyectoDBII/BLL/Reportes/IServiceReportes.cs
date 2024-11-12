
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.Reportes
{
    public interface IServiceReportes
    {
        public DataTable ReporteMetodosPago(DateOnly fechaInicio, DateOnly fechaFinal);

        public DataTable ReporteProductosMasVendidos(DateOnly fechaInicio, DateOnly fechaFinal);

        public DataSet ReportesDatosFactura(int idFactura);

        public DataTable ReporteProductosExistenciaMinima();

        public DataSet ReporteEstadoPedidos();

        public IEnumerable<dynamic> ListarFacturas();
    }
}
