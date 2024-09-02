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
    public partial class Marca : Form
    {
        public Marca()
        {
            InitializeComponent();
        }

        private void btnCrearMarca_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            panelEditar.Visible = false;
            panelEliminar.Visible = true;
        }

        private void Marca_Load(object sender, EventArgs e)
        {
            panelEditar.Visible = false;
            panelEliminar.Visible = false;
        }

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {
            panelEliminar.Visible = false;
            panelEditar.Visible = true;
        }
    }
}
