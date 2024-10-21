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
    }
}
