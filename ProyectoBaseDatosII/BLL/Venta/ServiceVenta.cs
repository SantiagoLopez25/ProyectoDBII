using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Compra;
using DAL.Venta;

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
    }
}
