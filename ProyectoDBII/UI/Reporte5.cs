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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UI
{
    public partial class Reporte5 : Form
    {
        ServiceReportes serviceReportes;
        public Reporte5()
        {
            InitializeComponent();
            serviceReportes = new ServiceReportes();
            listar();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnListarVentas_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void listar()
        {
            DataSet ds = new DataSet();

            ds = serviceReportes.ReporteEstadoPedidos();

            DataTable pendientes = ds.Tables[0];
            DataTable entregados = ds.Tables[1];

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pendientes;
            dataGridView1.Refresh();

            dataGridView2.Columns.Clear();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = entregados;
            dataGridView2.Refresh();

        }
    }
}
