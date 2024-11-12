using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Reportes;

namespace BLL.Reportes
{
    public class ServiceReportes: IServiceReportes
    {
        private readonly RepositoryReportes _reporteDAL;
        public ServiceReportes()
        {
            _reporteDAL = new RepositoryReportes();
        }

        public DataTable ReporteMetodosPago(DateOnly fechaInicio, DateOnly fechaFinal)
        {
            return _reporteDAL.ReporteMetodosPago(fechaInicio, fechaFinal);
        }


        public DataTable ReporteProductosMasVendidos(DateOnly fechaInicio, DateOnly fechaFinal)
        {
            return _reporteDAL.ReporteProductosMasVendidos(fechaInicio, fechaFinal);
        }

        public DataSet ReportesDatosFactura(int idFactura)
        {
            return _reporteDAL.ReportesDatosFactura(idFactura);
        }

        public DataTable ReporteProductosExistenciaMinima()
        {
            return _reporteDAL.ReporteProductosExistenciaMinima();
        }


        public DataSet ReporteEstadoPedidos()
        {
            return _reporteDAL.ReporteEstadoPedidos();
        }

        public IEnumerable<dynamic> ListarFacturas()
        {
            return _reporteDAL.ListarFacturas();
        }



    }
}
