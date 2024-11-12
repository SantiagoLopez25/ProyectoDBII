using BLL.Permisos;
using BLL.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Reporte3 : Form
    {
        private ServiceReportes serviceReportes;
        public Reporte3()
        {
            InitializeComponent();
            serviceReportes = new ServiceReportes();
            llenarFacturas();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           DataSet ds = new DataSet();
           int idFactura = Convert.ToInt32( comboBoxIdFactura.Text.ToString());
           ds = serviceReportes.ReportesDatosFactura(idFactura);

            DataTable datosFactura = ds.Tables[0];
            DataTable detalle = ds.Tables[1];
            DataTable pago = ds.Tables[2];

           
            DataRow datos = datosFactura.Rows[0];
            labelSerie.Text = datos["id_Serie"].ToString();
            labelFecha.Text = datos["fechaFactura"].ToString();
            labelCliente.Text= datos["Nombre_Cliente"].ToString();
            labelDireccion.Text = datos["DireccionFacturacion"].ToString();
            labelUsuario.Text= datos["Nombre"].ToString();
            labelNit.Text = datos["Nit"].ToString();
            labelTotal.Text = datos["montoTotal"].ToString();
            labelSinDescuento.Text = datos["totalSinDescuento"].ToString();

            dataGridViewDetalleFactura.Columns.Clear();
            dataGridViewDetalleFactura.DataSource = null;
            dataGridViewDetalleFactura.DataSource = detalle;
            dataGridViewDetalleFactura.Refresh();

            dataGridViewMetodosPago.Columns.Clear();
            dataGridViewMetodosPago.DataSource = null;
            dataGridViewMetodosPago.DataSource = pago;
            dataGridViewMetodosPago.Refresh();

        }

        private void llenarFacturas()
        {
            comboBoxIdFactura.DataSource = serviceReportes.ListarFacturas();
            comboBoxIdFactura.DisplayMember = "id_Factura";
            comboBoxIdFactura.Refresh();
        }

        
    }
}
