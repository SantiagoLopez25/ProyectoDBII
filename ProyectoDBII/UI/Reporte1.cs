using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Permisos;
using BLL.Reportes;

namespace UI
{
    public partial class Reporte1 : Form
    {
        private ServiceReportes serviceReportes;
        public Reporte1()
        {
            InitializeComponent();
            serviceReportes = new ServiceReportes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DateOnly fechaI = DateOnly.Parse( dateTimePickerFechaI.Text);

            DateOnly fechaF = DateOnly.Parse(dateTimePickerFechaF.Text);

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = serviceReportes.ReporteMetodosPago(fechaI, fechaF);
            dataGridView1.Refresh();
        }
    }
}
