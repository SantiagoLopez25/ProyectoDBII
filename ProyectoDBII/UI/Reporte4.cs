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
    public partial class Reporte4 : Form
    {
        ServiceReportes serviceReportes;
        public Reporte4()
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
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = serviceReportes.ReporteProductosExistenciaMinima();
            dataGridView1.Refresh();
        }
    }
}
