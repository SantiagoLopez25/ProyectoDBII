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
    public partial class Reporte2 : Form
    {
        private ServiceReportes serviceReportes;
        public Reporte2()
        {
            InitializeComponent();
            serviceReportes = new ServiceReportes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateOnly fechaI = DateOnly.Parse(dateTimePickerFechaI.Text);

            DateOnly fechaF = DateOnly.Parse(dateTimePickerFechaF.Text);

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = serviceReportes.ReporteProductosMasVendidos(fechaI, fechaF);
            dataGridView1.Refresh();
        }
    }
}
