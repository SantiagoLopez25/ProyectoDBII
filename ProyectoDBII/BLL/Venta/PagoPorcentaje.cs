using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Venta
{
    public class PagoPorcentaje
    {
        public int IdTipoPago { get; set; }
        public float PorcentajePago { get; set; }

        public PagoPorcentaje(int idTipoPago, float porcentajePago)
        {
            IdTipoPago = idTipoPago;
            PorcentajePago = porcentajePago;
        }
    }
}
