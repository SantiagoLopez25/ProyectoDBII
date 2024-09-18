using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Mueble.Categoria;

namespace UI
{
    public partial class Categoria : Form
    {
        private readonly IServiceCategoria _serviceCategoria;
        public Categoria()
        {
            InitializeComponent();
            _serviceCategoria = new ServiceCategoria();
        }

        private void btnCrearCategoria_Click(object sender, EventArgs e)
        {
            btnEditarCategoria.Enabled = false;
            btnEliminarCategoria.Enabled = false;
            _serviceCategoria.AgregarCategoria(
                txtCategoria.Text,
                Boolean.Parse(lblEstado.Text)
                );
            MessageBox.Show("Insertado correctamente");
            ClearData();
            btnEditarCategoria.Enabled = true;
            btnEliminarCategoria.Enabled = true;
            ListarCategorias();
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnCrearCategoria.Enabled = false;
                _serviceCategoria.EditarCategoria(
                Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                txtEditar.Text,
                Boolean.Parse(lblEstado.Text)
                );
                MessageBox.Show("Editado correctamente");
                ListarCategorias();
                ClearData();
            }
            else
                MessageBox.Show("Debe seleccionar un registro a editar");
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar el tipo de salón?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _serviceCategoria.EliminarCategoria(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    MessageBox.Show("Se ha eliminado correctamente el tipo de salón");
                    ListarCategorias();
                    ClearData();
                }
            }
            else
                MessageBox.Show("Debe seleccionar un registro a eliminar");
        }

        private void ListarCategorias()
        {
            dataGridView1.DataSource = _serviceCategoria.ListarCategorias();
        }

        void ClearData()
        {
            txtCategoria.Clear();
            lblId.Text = "";
            lblEstado.Text = "true";
            txtEditar.Clear();
            btnCrearCategoria.Enabled = true;
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            lblId.Visible = false;
            lblEstado.Visible = false;
            txtEditar.Hide();
            lblEstado.Text = "true";
            ListarCategorias();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtEditar.Show();
                btnEditarCategoria.Enabled = true;
                btnEliminarCategoria.Enabled = true;
                lblId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtEditar.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblEstado.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            btnEditarCategoria.Enabled = false;
            btnEliminarCategoria.Enabled = false;
            txtEditar.Hide();
            lblEstado.Text = "true";
        }
    }
}
