using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Compra;

namespace UI
{
    public partial class Proveedor : Form
    {
        private readonly IServiceProveedor _serviceProveedor;
        public Proveedor()
        {
            InitializeComponent();
            _serviceProveedor = new ServiceProveedor();
        }


        //Para

        private void ListarProveedores()
        {
            dataGridViewProveedores.DataSource = _serviceProveedor.ListarProveedor();
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            lblId.Visible = false;
            lblEstado.Visible = false;
            ClearData();
            ListarProveedores();
        }

        private void btnCrearProveedor_Click(object sender, EventArgs e)
        {
            btnEditarProveedor.Enabled = false;
            btnEliminarProveedor.Enabled = false;
            _serviceProveedor.AgregarProveedor(
                txtProveedor.Text,
                txtDireccion.Text,
                txtTelefono.Text,
                txtTelExtra.Text,
                txtCorreo.Text,
                Boolean.Parse(lblEstado.Text)
                );
            MessageBox.Show("Insertado correctamente");
            ClearData();
            btnEditarProveedor.Enabled = true;
            btnEliminarProveedor.Enabled = true;
            ListarProveedores();
        }


        void ClearData()
        {
            txtProveedor.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtTelExtra.Clear();
            txtCorreo.Clear();
            lblId.Text = "";
            lblEstado.Text = "true";
            groupEditar.Hide();
            groupCrear.Show();
            btnCrearProveedor.Enabled = true;
            btnEditarProveedor.Enabled = false;
            btnEliminarProveedor.Enabled = false;
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            if (dataGridViewProveedores.SelectedRows.Count > 0)
            {
                groupCrear.Hide();
                groupEditar.Show();
                btnCrearProveedor.Enabled = false;
                _serviceProveedor.EditarProveedor(
                Convert.ToInt32(dataGridViewProveedores.CurrentRow.Cells[0].Value),
                txtProveedorEditar.Text,
                txtDireccionEditar.Text,
                txtTelefonoEditar.Text,
                txtTelExtraEditar.Text,
                txtCorreoEditar.Text,
                Boolean.Parse(lblEstado.Text)
                );
                MessageBox.Show("Editado correctamente");
                ListarProveedores();
                ClearData();
            }
            else
                MessageBox.Show("Debe seleccionar un registro a editar");
        }

        private void dataGridViewProveedores_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProveedores.SelectedRows.Count > 0)
            {
                groupCrear.Hide();
                groupEditar.Show();
                btnCrearProveedor.Enabled = false;
                btnEditarProveedor.Enabled = true;
                btnEliminarProveedor.Enabled = true;

                DataGridViewRow selectedRow = dataGridViewProveedores.SelectedRows[0];
                txtProveedorEditar.Text = (selectedRow.Cells[1].Value).ToString();
                txtDireccionEditar.Text = (selectedRow.Cells[2].Value).ToString();
                txtTelefonoEditar.Text = (selectedRow.Cells[3].Value).ToString();
                txtTelExtraEditar.Text = (selectedRow.Cells[4].Value).ToString();
                txtCorreoEditar.Text = (selectedRow.Cells[5].Value).ToString();
                lblEstado.Text = (selectedRow.Cells[6].Value).ToString();
            }
            else
            {
                lblEstado.Text = "true";
                groupEditar.Hide();
                groupCrear.Show();
                btnCrearProveedor.Enabled = true;
                btnEditarProveedor.Enabled = false;
                btnEliminarProveedor.Enabled = false;
            }
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (dataGridViewProveedores.SelectedRows.Count > 0)
            {
                groupCrear.Hide();
                groupEditar.Show();
                btnCrearProveedor.Enabled = false;
                _serviceProveedor.EliminarProveedor(
                Convert.ToInt32(dataGridViewProveedores.CurrentRow.Cells[0].Value)
                );
                MessageBox.Show("Eliminado correctamente");
                ListarProveedores();
                ClearData();
            }
            else
                MessageBox.Show("Debe seleccionar un registro a eliminar");
        }
    }
}
