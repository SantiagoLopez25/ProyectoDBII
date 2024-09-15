using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Mueble;

namespace UI
{
    public partial class Marca : Form
    {
        private readonly IServiceMarca _serviceMarca;
        public Marca()
        {
            InitializeComponent();
            _serviceMarca = new ServiceMarca();
        }

        private void btnCrearMarca_Click(object sender, EventArgs e)
        {
            btnEditarMarca.Enabled = false;
            btnEliminarMarca.Enabled = false;
            _serviceMarca.AgregarMarca(
                txtMarca.Text,
                Boolean.Parse(lblEstado.Text)
                );
            MessageBox.Show("Insertado correctamente");
            ClearData();
            btnEditarMarca.Enabled = true;
            btnEliminarMarca.Enabled = true;
            ListarMarcas();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar el tipo de salón?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _serviceMarca.EliminarMarca(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    MessageBox.Show("Se ha eliminado correctamente el tipo de salón");
                    ListarMarcas();
                    ClearData();
                }
            }
            else
                MessageBox.Show("Debe seleccionar un registro a eliminar");
        }
        private void ListarMarcas()
        {
            dataGridView1.DataSource = _serviceMarca.ListarMarcas();
        }
 
        private void Marca_Load(object sender, EventArgs e)
        {
            lblId.Visible = false;
            lblEstado.Visible = false;
            txtEditar.Hide();
            lblEstado.Text = "true";
            ListarMarcas();
        }

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnCrearMarca.Enabled = false;
                _serviceMarca.EditarMarca(
                Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                txtEditar.Text,
                Boolean.Parse(lblEstado.Text)
                );
                MessageBox.Show("Editado correctamente");
                ListarMarcas();
                ClearData();
            }
            else
                MessageBox.Show("Debe seleccionar un registro a editar");
        }

        
        void ClearData()
        {
            txtMarca.Clear();
            lblId.Text = "";
            lblEstado.Text = "true";
            txtEditar.Clear();
            btnCrearMarca.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtEditar.Show();
                btnEditarMarca.Enabled = true;
                btnEliminarMarca.Enabled = true;
                lblId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtEditar.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblEstado.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void txtMarca_Click(object sender, EventArgs e)
        {
            btnEditarMarca.Enabled = false;
            btnEliminarMarca.Enabled = false;
            txtEditar.Hide();
            lblEstado.Text = "true";
        }
    }
}
