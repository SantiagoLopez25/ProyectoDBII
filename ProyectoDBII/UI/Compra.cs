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
using BLL.Compra;

using DAL.Compra;
using static BLL.Compra.Modelos;



namespace UI
{
    public partial class Compra : Form
    {
        private readonly IServiceCompra _serviceCompra;
        private int id_Mueble, cantidad_Mueble;
        private float precioVenta, TotalCompra;
        private string nombre_mueble;

        private int cantidadPedida;

        private int idCompra;
        private int id_Usuario;

        //Dictionary<int, string, int, float> detalle;

        public void setIdUsuario(int id)
        {
            this.id_Usuario = id;
        }
        public Compra()
        {
            InitializeComponent();
            _serviceCompra = new ServiceCompra();
            comboBoxTipoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProveedores.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarTiposPago()
        {
            DataTable tiposPago = _serviceCompra.ListarTiposPago();

            comboBoxTipoPago.DataSource = tiposPago;

            comboBoxTipoPago.DisplayMember = "Nombre_TipoPago"; // Lo que se muestra en el ComboBox
            comboBoxTipoPago.ValueMember = "id_TipoPago"; // El valor asociado (id)
        }


        private void CargarTotal()
        {
            TotalCompra = 0;

            foreach (DataGridViewRow row in dataGridViewDetalle.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {

                    TotalCompra += float.Parse(row.Cells["Total"].Value.ToString());
                }
            }


            lblTotal.Text = TotalCompra.ToString("C2");

        }

        private void ListarMuebles()
        {
            dataGridViewProductos.DataSource = _serviceCompra.ListarMuebles();
        }

        private void ListarCompras()
        {
            dataGridViewCompras.DataSource = _serviceCompra.ListarCompras();
        }

        private void ListarProveedores()
        {
            DataTable proveedores = _serviceCompra.ListarProveedores();

            comboBoxProveedores.DataSource = proveedores;

            comboBoxProveedores.DisplayMember = "proveedor"; // Lo que se muestra en el ComboBox
            comboBoxProveedores.ValueMember = "id_Proveedor"; // El valor asociado (id)
        }


        private void btnEditarVenta_Click(object sender, EventArgs e)
        {

            if (dataGridViewCompras.SelectedRows.Count > 0)
            {
                /*groupCrear.Hide();
                groupEditar.Show();
                btnMostrarCrear.Enabled = false;
                _serviceCompra.EditarVenta(
                Convert.ToInt32(dataGridViewCompras.CurrentRow.Cells[0].Value),
                txtVentaEditar.Text,
                txtDireccionEditar.Text,
                txtTelefonoEditar.Text,
                txtTelExtraEditar.Text,
                txtCorreoEditar.Text,
                Boolean.Parse(lblEstado.Text)
                );*/
                MessageBox.Show("Editado correctamente");
                //ListarVentaes();
                //ClearData();
            }
            else
                MessageBox.Show("Debe seleccionar un registro a editar");

        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {

        }

        private void btnListarCompras_Click(object sender, EventArgs e)
        {
            groupBoxAccionesExtra.Visible = false;
            groupBoxListar.Visible = true;
        }


        private void btnMostrarAgrProductos_Click(object sender, EventArgs e)
        {
            groupBoxAgregarProductos.Visible = true;
            groupBoxAccionesExtra.Visible = false;
            groupBoxListar.Visible = false;
        }

        private void btnMostrarIngresoDato_Click(object sender, EventArgs e)
        {
            groupBoxAgregarProductos.Visible = false;
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
                cantidadPedida += cantidad_Mueble;
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

            LimpiarFormularioYListarCompras();

            groupBoxAgregarProductos.Visible = false;
            groupBoxAccionesExtra.Visible = false;
            groupBoxListar.Visible = true;
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

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            LimpiarFormularioYListarCompras();
            groupBoxAgregarProductos.Visible = false;
            groupBoxAccionesExtra.Visible = false;
            groupBoxListar.Visible = true;
        }

        private void LimpiarFormularioYListarCompras()
        {
            txtDescripcion.Clear();
            txtDescripcion.Enabled = true;

            dataGridViewDetalle.Rows.Clear();
            dataGridViewDetalle.Rows.Clear();

            comboBoxTipoPago.SelectedIndex = -1;

            lblTotal.Text = "0.00";
            TotalCompra = 0;

            groupBoxAgregarProductos.Visible = false;
            groupBoxAccionesExtra.Visible = false;
            groupBoxListar.Visible = true;

            ListarCompras();
        }

        private void panelCreate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Compra_Load(object sender, EventArgs e)
        {
            groupBoxListar.Visible = true;
            groupBoxAccionesExtra.Visible = false;

            LimpiarFormularioYListarCompras();

            ListarCompras();
        }

        private void btnMostrarAgregar_Click_1(object sender, EventArgs e)
        {
            groupBoxAgregarProductos.Visible = true;
            groupBoxAccionesExtra.Visible = false;
            groupBoxListar.Visible = false;

            ListarMuebles();
            ListarProveedores();
            CargarTiposPago();
        }

        private void btnCancelarCompra2_Click(object sender, EventArgs e)
        {
            LimpiarFormularioYListarCompras();
        }

        private void btnListarCompras_Click_2(object sender, EventArgs e)
        {
            LimpiarFormularioYListarCompras();

            groupBoxAgregarProductos.Visible = false;
            groupBoxAccionesExtra.Visible = false;
            groupBoxListar.Visible = true;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            try
            {
                List<DetalleCompraModel> detalles = new List<DetalleCompraModel>();
                foreach (DataGridViewRow row in dataGridViewDetalle.Rows)
                {
                    if (row.Cells["ID"].Value != null && row.Cells["cantidad"].Value != null)
                    {
                        DetalleCompraModel detalle = new DetalleCompraModel
                        {
                            Cantidad = Convert.ToInt32(row.Cells["cantidad"].Value),
                            IdMueble = Convert.ToInt32(row.Cells["ID"].Value)

                        };
                        detalles.Add(detalle);
                        //MessageBox.Show($"ID: {detalle.IdMueble}\nCantidad: {detalle.Cantidad}", "Detalle Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                //MessageBox.Show($"Total de detalles agregados: {detalles.Count}", "Detalles", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (detalles.LongCount() >= 1)
                {
                    int idTipoPagoSeleccionado = (int)comboBoxTipoPago.SelectedValue;
                    int idProveedorSeleccionado = (int)comboBoxProveedores.SelectedValue;

                    string resultado = _serviceCompra.GenerarCompra(txtDescripcion.Text, null, null, cantidadPedida, null, TotalCompra, true, 1, idTipoPagoSeleccionado, idProveedorSeleccionado, detalles);

                    MessageBox.Show(resultado, "Resultado del Pedido a Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (resultado.Equals("Compra registrada correctamente"))
                    {
                        LimpiarFormularioYListarCompras();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Está seguro de eliminar esta Compra?",
                "Confirmación",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );


            if (result == DialogResult.OK)
            {
                _serviceCompra.EliminarCompra(idCompra);

                LimpiarFormularioYListarCompras();

                groupBoxAgregarProductos.Visible = false;
                groupBoxAccionesExtra.Visible = false;
                groupBoxListar.Visible = true;
            }
        }

        private void dataGridViewCompras_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridViewCompras.SelectedRows.Count > 0)
            {
                groupBoxAccionesExtra.Visible = true;

                DataGridViewRow filaSeleccionada = dataGridViewCompras.SelectedRows[0];

                idCompra = Convert.ToInt32(filaSeleccionada.Cells[0].Value);

            }
            else
            {
                groupBoxAccionesExtra.Visible = false;

            }
        }
    }
}
