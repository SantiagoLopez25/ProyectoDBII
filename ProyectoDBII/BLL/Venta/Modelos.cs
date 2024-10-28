using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Venta
{
    public class Modelos
    {
        public class ClienteModel
        {
            public int? IdCliente { get; set; }
            public string NombreCliente { get; set; }
            public string DireccionFacturacion { get; set; }
            public string Telefono { get; set; }
            public string Correo { get; set; }
            public string NIT { get; set; }
        }

        public class DireccionEntregaModel
        {
            public int? IdDireccionEntrega { get; set; }
            public string Direccion { get; set; }
            public string DescripcionEntrega { get; set; }
            public string TelefonoReferencia { get; set; }
            public DateTime FechaEntrega { get; set; }
            public TimeSpan HoraEntrega { get; set; }
        }

        public class DetalleFacturaModel
        {
            
            public int Cantidad { get; set; }

            public int IdMueble { get; set; }
        }

        public class PagoModel
        {
            public int IdTipoPago1 { get; set; }
            public int? IdTipoPago2 { get; set; }
            public int? IdTipoPago3 { get; set; }
            public float? PorcentajePago1 { get; set; }
            public float? PorcentajePago2 { get; set; }
            public float? PorcentajePago3 { get; set; }

            public override string ToString()
            {
                return $"Pago 1: Tipo {IdTipoPago1} - Porcentaje {PorcentajePago1}%\n" +
                       $"Pago 2: Tipo {IdTipoPago2?.ToString() ?? "N/A"} - Porcentaje {PorcentajePago2?.ToString() ?? "N/A"}%\n" +
                       $"Pago 3: Tipo {IdTipoPago3?.ToString() ?? "N/A"} - Porcentaje {PorcentajePago3?.ToString() ?? "N/A"}%";
            }
        }
    }
}
