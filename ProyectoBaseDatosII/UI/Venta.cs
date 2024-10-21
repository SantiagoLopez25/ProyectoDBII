using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Venta;


namespace UI
{
    public partial class Venta : Form
    {
        private readonly IServiceVenta _serviceVenta;
        public Venta()
        {
            InitializeComponent();
            _serviceVenta = new ServiceVenta();
        }


        private void ListarMuebles()
        {
            dataGridViewProductos.DataSource = _serviceVenta.ListarMuebles();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            groupBoxListar.Visible = true;
            groupBoxCrear.Visible = false;
            groupBoxAccionesExtra.Visible = false;
            ClearData();
            //ListarVentaes();
        }

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            groupBoxListar.Visible = false;
            groupBoxCrear.Visible = true;
            groupBoxAccionesExtra.Visible = false;

            /*
             _serviceVenta.AgregarVenta(
                txtVenta.Text,
                txtDireccion.Text,
                txtTelefono.Text,
                txtTelExtra.Text,
                txtCorreo.Text,
                Boolean.Parse(lblEstado.Text)
                );
            MessageBox.Show("Insertado correctamente");
            ClearData();
            btnEditarVenta.Enabled = true;
            btnEliminarVenta.Enabled = true;
            ListarVentaes();
            */
        }


        void ClearData()
        {
            /* txtVenta.Clear();
             txtDireccion.Clear();
             txtTelefono.Clear();
             txtTelExtra.Clear();
             txtCorreo.Clear();
             lblId.Text = "";
             lblEstado.Text = "true";
             groupEditar.Hide();
             groupCrear.Show();
             btnMostrarCrear.Enabled = true;
             btnEditarVenta.Enabled = false;
             btnEliminarVenta.Enabled = false;*/
        }

        private void btnEditarVenta_Click(object sender, EventArgs e)
        {
            if (dataGridViewVentas.SelectedRows.Count > 0)
            {
                /*groupCrear.Hide();
                groupEditar.Show();
                btnMostrarCrear.Enabled = false;
                _serviceVenta.EditarVenta(
                Convert.ToInt32(dataGridViewVentaes.CurrentRow.Cells[0].Value),
                txtVentaEditar.Text,
                txtDireccionEditar.Text,
                txtTelefonoEditar.Text,
                txtTelExtraEditar.Text,
                txtCorreoEditar.Text,
                Boolean.Parse(lblEstado.Text)
                );*/
                MessageBox.Show("Editado correctamente");
                //ListarVentaes();
                ClearData();
            }
            else
                MessageBox.Show("Debe seleccionar un registro a editar");
        }

        private void dataGridViewVentaes_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewVentas.SelectedRows.Count > 0)
            {
                /*groupCrear.Hide();
                groupEditar.Show();
                btnMostrarCrear.Enabled = false;
                btnEditarVenta.Enabled = true;
                btnEliminarVenta.Enabled = true;

                DataGridViewRow selectedRow = dataGridViewVentas.SelectedRows[0];
                txtVentaEditar.Text = (selectedRow.Cells[1].Value).ToString();
                txtDireccionEditar.Text = (selectedRow.Cells[2].Value).ToString();
                txtTelefonoEditar.Text = (selectedRow.Cells[3].Value).ToString();
                txtTelExtraEditar.Text = (selectedRow.Cells[4].Value).ToString();
                txtCorreoEditar.Text = (selectedRow.Cells[5].Value).ToString();
                lblEstado.Text = (selectedRow.Cells[6].Value).ToString();*/
            }
            else
            {
                /*lblEstado.Text = "true";
                groupEditar.Hide();
                groupCrear.Show();
                btnMostrarCrear.Enabled = true;
                btnEditarVenta.Enabled = false;
                btnEliminarVenta.Enabled = false;*/
            }
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            if (dataGridViewVentas.SelectedRows.Count > 0)
            {
                /*groupCrear.Hide();
                groupEditar.Show();
                btnMostrarCrear.Enabled = false;
                _serviceVenta.EliminarVenta(
                Convert.ToInt32(dataGridViewVentaes.CurrentRow.Cells[0].Value)
                );
                MessageBox.Show("Eliminado correctamente");
                ListarVentaes();
                ClearData();*/
            }
            else
                MessageBox.Show("Debe seleccionar un registro a eliminar");
        }

        private void btnListarVentas_Click(object sender, EventArgs e)
        {
            groupBoxCrear.Visible = false;
            groupBoxAccionesExtra.Visible = false;
            groupBoxListar.Visible = true;
        }

        private void checkNuevaDirección_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNuevaDirección.Checked == true)
            {
                comboBoxDireccionesEntrega.Visible = false;
                txtNuevaDirección.Visible = true;
            }
            else
            {
                comboBoxDireccionesEntrega.Visible = true;
                txtNuevaDirección.Visible = false;
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarAgregar_Click(object sender, EventArgs e)
        {
            groupBoxAgregarProductos.Visible = true;
            groupBoxCrear.Visible = false;
            groupBoxAccionesExtra.Visible = false;
            groupBoxListar.Visible = false;

            ListarMuebles();
        }

        private void btnListarVentas_Click_1(object sender, EventArgs e)
        {
            groupBoxAgregarProductos.Visible = false;
            groupBoxCrear.Visible = false;
            groupBoxAccionesExtra.Visible = false;
            groupBoxListar.Visible = true;
        }

        private void btnMostrarDatosCliente_Click(object sender, EventArgs e)
        {
            groupBoxAgregarProductos.Visible = false;
            groupBoxCrear.Visible = true;
            groupBoxAccionesExtra.Visible = false;
            groupBoxListar.Visible = false;
        }

        private void btnMostrarAgrProductos_Click(object sender, EventArgs e)
        {
            groupBoxAgregarProductos.Visible = true;
            groupBoxCrear.Visible = false;
            groupBoxAccionesExtra.Visible = false;
            groupBoxListar.Visible = false;
        }

        private void btnMostrarIngresoDato_Click(object sender, EventArgs e)
        {
            groupBoxAgregarProductos.Visible = false;
            groupBoxCrear.Visible = true;
            groupBoxAccionesExtra.Visible = false;
            groupBoxListar.Visible = false;
        }


    }
}
