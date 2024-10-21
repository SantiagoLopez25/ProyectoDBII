using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DAL.Venta
{
    public class RepositoryVenta
    {
        private readonly Conexion _conexion;

        public RepositoryVenta()
        {
            _conexion = new Conexion();
        }

        public DataTable ListarMuebles()
        {
            DataTable tablaMuebles = new DataTable();

            using (var connection = _conexion.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("ListarMuebles", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        tablaMuebles.Load(reader);
                    }
                }
            }

            return tablaMuebles;
        }

    }
}
