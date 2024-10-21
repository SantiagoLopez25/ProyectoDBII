using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Text;
using System.Windows.Forms;
using BLL.Venta;


namespace UI
{
    public partial class Venta : Form
    {
        private readonly IServiceVenta _serviceVenta;
        private int id_Mueble, cantidad_Mueble;
        private float precioVenta, TotalVenta;
        private string nombre_mueble;

        private int id_Cliente;
        //Dictionary<int, string, int, float> detalle;


        public Venta()
        {
            InitializeComponent();
            _serviceVenta = new ServiceVenta();
        }

        private void CargarTiposPago()
        {
            DataTable tiposPago = _serviceVenta.ListarTiposPago();

            comboBoxTipoPago.DataSource = tiposPago;

            comboBoxTipoPago.DisplayMember = "Nombre_TipoPago"; // Lo que se muestra en el ComboBox
            comboBoxTipoPago.ValueMember = "id_TipoPago"; // El valor asociado (id)
        }

        private void CargarTotal()
        {
            TotalVenta = 0;

            foreach (DataGridViewRow row in dataGridViewDetalle.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    // Suma el valor de la celda "Total", asegurándose de que sea un número
                    TotalVenta += float.Parse(row.Cells["Total"].Value.ToString());
                }
            }

            // Asigna la suma total al Label
            lblTotal.Text = TotalVenta.ToString("C2"); // Formato moneda con 2 decimales
        }

        private void ListarMuebles()
        {
            dataGridViewProductos.DataSource = _serviceVenta.ListarMuebles();
        }

        private void ListarVentas()
        {
            dataGridViewVentas.DataSource = _serviceVenta.ListarVentas();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            groupBoxListar.Visible = true;
            groupBoxCrear.Visible = false;
            groupBoxAccionesExtra.Visible = false;
            ClearData();
            ListarVentas();
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
                groupBoxAccionesExtra.Visible = true;
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
                groupBoxAccionesExtra.Visible = false;
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
            CargarTiposPago();
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

        private void dataGridViewProductos_SelectionChanged(object sender, EventArgs e)
        {
            btnAgregarMueble.Enabled = true;
            btnEliminarMueble.Enabled = false;
        }

        private void btnAgregarMueble_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewProductos.SelectedRows[0];
                id_Mueble = Convert.ToInt32((selectedRow.Cells[0].Value).ToString());
                nombre_mueble = selectedRow.Cells[1].Value.ToString();
                precioVenta = float.Parse(selectedRow.Cells[4].Value.ToString());
                cantidad_Mueble = Convert.ToInt32(txtCantidad.Text);
                float total = cantidad_Mueble * precioVenta;
                dataGridViewDetalle.Rows.Add(id_Mueble, nombre_mueble, cantidad_Mueble, total);
                txtCantidad.Text = "1";
            }
            else
                MessageBox.Show("Debe seleccionar un mueble a agregar");
        }

        private void btnEliminarMueble_Click(object sender, EventArgs e)
        {
            if (dataGridViewDetalle.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewDetalle.SelectedRows[0];
                dataGridViewDetalle.Rows.Remove(selectedRow);
            }
            else
                MessageBox.Show("Debe seleccionar un mueble a agregar");
        }

        private void dataGridViewDetalle_SelectionChanged(object sender, EventArgs e)
        {
            btnAgregarMueble.Enabled = false;
            btnEliminarMueble.Enabled = true;
        }

        private void btnCancelarVenta2_Click(object sender, EventArgs e)
        {
            groupBoxAgregarProductos.Visible = false;
            groupBoxCrear.Visible = false;
            groupBoxAccionesExtra.Visible = false;
            groupBoxListar.Visible = true;
        }

        private void txtNIT_Leave(object sender, EventArgs e)
        {
            string nit = txtNIT.Text;

            if (!string.IsNullOrEmpty(nit))
            {
                DataTable clienteData = _serviceVenta.BuscarNit(nit);

                if (clienteData.Rows.Count > 0)
                {
                    DataRow row = clienteData.Rows[0];
                    id_Cliente = Convert.ToInt32(row["id_Cliente"]);
                    txtNombreCliente.Text = row["Nombre_Cliente"].ToString();
                    txtDireccionFacturacion.Text = row["DireccionFacturacion"].ToString();
                    txtCorreo.Text = row["Correo"].ToString();
                    txtTelefono.Text = row["Telefono"].ToString();

                    txtNombreCliente.Enabled = false;
                    txtDireccionFacturacion.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtTelefono.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado.");
                    //LimpiarCamposCliente();
                }
            }
        }

        private void dataGridViewDetalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CargarTotal();
        }

        private void dataGridViewDetalle_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CargarTotal();
        }

        private void dataGridViewDetalle_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CargarTotal();
        }
    }
}
