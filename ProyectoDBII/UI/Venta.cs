﻿using System;
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

using DAL.Venta;
using static BLL.Venta.Modelos;



namespace UI
{
    public partial class Venta : Form
    {
        private readonly IServiceVenta _serviceVenta;
        private int id_Mueble, cantidad_Mueble;
        private float precioVenta, TotalVenta;
        private string nombre_mueble;

        private List<PagoPorcentaje> listaPagosPorcentaje = new List<PagoPorcentaje>();

        private int idcliente;

        private int idFactura;
        private int idUsuario;

        //Dictionary<int, string, int, float> detalle;

        public void setIdUsuario(int id)
        {
            idUsuario = id;
        }
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


        private void CargarDireccionesEntrega(int id_Cliente)
        {
            DataTable direccionesEntrega = _serviceVenta.BuscarDireccionesEntregaCliente(id_Cliente);

            comboBoxDireccionesEntrega.DataSource = direccionesEntrega;
            comboBoxDireccionesEntrega.DisplayMember = "Direccion";
            comboBoxDireccionesEntrega.ValueMember = "ID";
        }

        private void CargarTotal()
        {
            TotalVenta = 0;

            foreach (DataGridViewRow row in dataGridViewDetalle.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {

                    TotalVenta += float.Parse(row.Cells["Total"].Value.ToString());
                }
            }


            lblTotal.Text = TotalVenta.ToString("C2");

        }

        private void ListarMuebles()
        {
            dataGridViewProductos.DataSource = _serviceVenta.ListarMuebles();
        }

        private void ListarVentas()
        {
            dataGridViewVentas.DataSource = _serviceVenta.ListarVentas();
        }


        private void ListarSeriesFactura()
        {
            DataTable seriesFacturas = _serviceVenta.ListarSeriesFacturas();
            comboBoxSerieFactura.DataSource = seriesFacturas;
            comboBoxSerieFactura.DisplayMember = "id_Serie";
            comboBoxSerieFactura.ValueMember = "id_Serie";
        }


        private void Venta_Load(object sender, EventArgs e)
        {
            groupBoxListar.Visible = true;
            groupBoxCrear.Visible = false;
            groupBoxAccionesExtra.Visible = false;

            LimpiarFormularioYListarVentas();

            ListarVentas();
        }

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            groupBoxListar.Visible = false;
            groupBoxCrear.Visible = true;
            groupBoxAccionesExtra.Visible = false;


        }


        private void limpiarDatosCliente()
        {
            txtNIT.Clear();
            txtNIT.Enabled = true;

            txtNombreCliente.Clear();
            txtNombreCliente.Enabled = true;

            txtDireccionFacturacion.Clear();
            txtDireccionFacturacion.Enabled = true;

            txtCorreo.Clear();
            txtCorreo.Enabled = true;

            txtTelefono.Clear();
            txtTelefono.Enabled = true;

            txtTelefonoReferencia.Clear();
            txtTelefonoReferencia.Enabled = true;

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
                //ClearData();
            }
            else
                MessageBox.Show("Debe seleccionar un registro a editar");

        }

        private void dataGridViewVentaes_SelectionChanged(object sender, EventArgs e)
        {


            if (dataGridViewVentas.SelectedRows.Count > 0)
            {
                groupBoxAccionesExtra.Visible = true;

                DataGridViewRow filaSeleccionada = dataGridViewVentas.SelectedRows[0];

                idFactura = Convert.ToInt32(filaSeleccionada.Cells[0].Value);





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

            }
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {

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

            LimpiarFormularioYListarVentas();

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

            ListarSeriesFactura();

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

            LimpiarFormularioYListarVentas();

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
                    idcliente = Convert.ToInt32(row["id_Cliente"]);
                    txtNombreCliente.Text = row["Nombre_Cliente"].ToString();
                    txtDireccionFacturacion.Text = row["DireccionFacturacion"].ToString();
                    txtCorreo.Text = row["Correo"].ToString();
                    txtTelefono.Text = row["Telefono"].ToString();

                    CargarDireccionesEntrega(idcliente);

                    txtNombreCliente.Enabled = false;
                    checkNuevaDirección.Checked = false;
                    txtDireccionFacturacion.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtTelefono.Enabled = false;
                    checkNitExistente.Checked = true;
                }
            }
            else if ((txtNIT.Text == "") || (checkNitExistente.Checked == false))
            {
                MessageBox.Show("Cliente no encontrado.");
                checkNuevaDirección.Checked = true;
                limpiarDatosCliente();
                txtNombreCliente.Enabled = true;
                txtDireccionFacturacion.Enabled = true;
                checkNuevaDirección.Checked = true;
                txtCorreo.Enabled = true;
                txtTelefono.Enabled = true;
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

        private void btnAgregarTipoPago_Click(object sender, EventArgs e)
        {
            decimal monto = 0;
            if (decimal.TryParse(txtMontoPagar.Text, out monto))
            {
                int cantidadPagosAgregados = dataGridViewPagos.Rows.Count;

                if (listaPagosPorcentaje.Count >= 3)
                {
                    MessageBox.Show("Solo puedes agregar hasta 3 pagos en total para esta venta.");
                    return;
                }
                else if (CalcularSumaPagos() >= TotalVenta)
                {
                    MessageBox.Show("No se puede pagar más del total de la venta");
                    return;
                }

                float porcentaje = (float)(((float)monto / TotalVenta) * 100);

                // Guardar el valor actual del tipo de pago y monto
                string tipoPagoTexto = comboBoxTipoPago.Text; // Guardar el nombre del tipo de pago actual
                int tipoPagoId = (int)comboBoxTipoPago.SelectedValue; // Guardar el ID del tipo de pago actual
                decimal montoPago = monto; // Guardar el monto actual

                // Agregar el nuevo tipo de pago y su porcentaje a la lista
                listaPagosPorcentaje.Add(new PagoPorcentaje(tipoPagoId, (float)montoPago));

                // Actualizar el PagoModel
                PagoModel pagoModel = AsignarPagosDesdeLista(listaPagosPorcentaje);

                // Actualizar la interfaz (DataGridView, etc.)
                dataGridViewPagos.Rows.Add(tipoPagoId, tipoPagoTexto, montoPago.ToString(), porcentaje);

                // Recalcular montos y porcentajes totales
                //CalcularSumaPagos();

                // Llamar a la función para recalcular y guardar los porcentajes
                CalcularYGuardarPorcentajes();
                CalcularSumaPagos();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un monto válido.");
            }
        }
        private float CalcularSumaPagos()
        {
            float sumaTotal = 0;

            foreach (DataGridViewRow row in dataGridViewPagos.Rows)
            {
                if (row.Cells["montoTipoPago"].Value != null)
                {
                    sumaTotal += float.Parse(row.Cells["montoTipoPago"].Value.ToString());
                }
            }

            lblPendientePago.Text = sumaTotal.ToString("C2");

            return sumaTotal;
        }
        private void CalcularYGuardarPorcentajes()
        {
            listaPagosPorcentaje.Clear();
            foreach (DataGridViewRow row in dataGridViewPagos.Rows)
            {
                if (row.Cells["montoTipoPago"].Value != null && row.Cells["idTipoPago"].Value != null)
                {
                    int idTipoPago = Convert.ToInt32(row.Cells["idTipoPago"].Value);
                    float montoPago = float.Parse(row.Cells["montoTipoPago"].Value.ToString());
                    float porcentaje = (montoPago / TotalVenta) * 100;
                    listaPagosPorcentaje.Add(new PagoPorcentaje(idTipoPago, montoPago));
                }
            }
        }

        private void btnEliminarTipoPago_Click(object sender, EventArgs e)
        {
            if (dataGridViewPagos.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int rowIndex = dataGridViewPagos.SelectedRows[0].Index;

                // Eliminar el pago correspondiente de la lista
                listaPagosPorcentaje.RemoveAt(rowIndex);

                // Eliminar la fila seleccionada del DataGridView
                dataGridViewPagos.Rows.RemoveAt(rowIndex);

                // Recalcular los porcentajes y actualizar la lista
                CalcularYGuardarPorcentajes();

                // Recalcular montos totales
                CalcularSumaPagos();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un tipo de pago para eliminar.");
            }
        }

        private TimeSpan calcularHora()
        {
            int horas = Convert.ToInt32(comboBoxHora.SelectedItem);
            int minutos = Convert.ToInt32(comboBoxMinutos.SelectedItem);

            TimeSpan horaSeleccionada = new TimeSpan(horas, minutos, 0);


            string horaFormateada = horaSeleccionada.ToString(@"hh\:mm");
            return horaSeleccionada;
        }

        private PagoModel AsignarPagosDesdeLista(List<PagoPorcentaje> listaPagos)
        {
            PagoModel pagoModel = new PagoModel();

            int cantidadPagos = listaPagos.Count;

            if (cantidadPagos > 0)
            {
                pagoModel.IdTipoPago1 = listaPagos[0].IdTipoPago;
                pagoModel.PorcentajePago1 = (int)(listaPagos[0].PorcentajePago);
            }

            if (cantidadPagos > 1)
            {
                pagoModel.IdTipoPago2 = listaPagos[1].IdTipoPago;
                pagoModel.PorcentajePago2 = (int)(listaPagos[1].PorcentajePago);
            }

            if (cantidadPagos > 2)
            {
                pagoModel.IdTipoPago3 = listaPagos[2].IdTipoPago;
                pagoModel.PorcentajePago3 = (int)(listaPagos[2].PorcentajePago);
            }

            return pagoModel;
        }

        private List<PagoPorcentaje> ObtenerListaPagosPorcentaje()
        {
            return listaPagosPorcentaje;
        }

        private void btnCompletarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                List<DetalleFacturaModel> detalles = new List<DetalleFacturaModel>();
                ClienteModel cliente;
                foreach (DataGridViewRow row in dataGridViewDetalle.Rows)
                {
                    if (row.Cells["ID"].Value != null && row.Cells["cantidad"].Value != null)
                    {
                        DetalleFacturaModel detalle = new DetalleFacturaModel
                        {
                            Cantidad = Convert.ToInt32(row.Cells["cantidad"].Value),
                            IdMueble = Convert.ToInt32(row.Cells["ID"].Value)

                        };
                        detalles.Add(detalle);
                        //MessageBox.Show($"ID: {detalle.IdMueble}\nCantidad: {detalle.Cantidad}", "Detalle Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                //MessageBox.Show($"Total de detalles agregados: {detalles.Count}", "Detalles", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if ((txtNIT.Text != "CF") || (txtNIT.Text != ""))
                {

                    if (checkNitExistente.Checked == false)
                    {
                        cliente = new ClienteModel
                        {
                            IdCliente = null,
                            NombreCliente = txtNombreCliente.Text,
                            DireccionFacturacion = txtDireccionFacturacion.Text,
                            Telefono = txtTelefono.Text,
                            Correo = txtCorreo.Text,
                            NIT = txtNIT.Text
                        };
                    }
                    else
                    {
                        cliente = new ClienteModel
                        {
                            IdCliente = idcliente,
                            NombreCliente = txtNombreCliente.Text,
                            DireccionFacturacion = txtDireccionFacturacion.Text,
                            Telefono = txtTelefono.Text,
                            Correo = txtCorreo.Text,
                            NIT = txtNIT.Text
                        };
                    }

                    /*MessageBox.Show($"Cliente:\nID: {cliente.IdCliente}\nNombre: {cliente.NombreCliente}\nDirección: {cliente.DireccionFacturacion}\nTeléfono: {cliente.Telefono}\nCorreo: {cliente.Correo}\nNIT: {cliente.NIT}",
                    "Información del Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

                    DateTime fechaEntrega = dateTimePicker1.Value.Date;

                    DireccionEntregaModel direccionEntrega;
                    if (!checkNuevaDirección.Checked)
                    {
                        direccionEntrega = new DireccionEntregaModel
                        {
                            IdDireccionEntrega = Convert.ToInt32(comboBoxDireccionesEntrega.SelectedValue),
                            Direccion = "",
                            DescripcionEntrega = txtDescripcion.Text,
                            TelefonoReferencia = txtTelefonoReferencia.Text,
                            FechaEntrega = fechaEntrega,
                            HoraEntrega = calcularHora()
                        };
                    }
                    else
                    {
                        direccionEntrega = new DireccionEntregaModel
                        {
                            IdDireccionEntrega = 0,
                            Direccion = txtNuevaDirección.Text,
                            DescripcionEntrega = txtDescripcion.Text,
                            TelefonoReferencia = txtTelefonoReferencia.Text,
                            FechaEntrega = fechaEntrega,
                            HoraEntrega = calcularHora()
                        };
                    }


                    /*MessageBox.Show($"Dirección de Entrega:\nID: {direccionEntrega.IdDireccionEntrega}\nDescripción: {direccionEntrega.DescripcionEntrega}\nTeléfono Referencia: {direccionEntrega.TelefonoReferencia}\nFecha Entrega: {direccionEntrega.FechaEntrega}\nHora Entrega: {direccionEntrega.HoraEntrega}",
                    "Información de Dirección de Entrega", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

                    PagoModel pagos = AsignarPagosDesdeLista(listaPagosPorcentaje);
                    /*MessageBox.Show($"Pago 1: Tipo {pagos.IdTipoPago1} - Porcentaje {pagos.PorcentajePago1}%\n" +
                    $"Pago 2: Tipo {pagos.IdTipoPago2?.ToString() ?? "N/A"} - Porcentaje {pagos.PorcentajePago2?.ToString() ?? "N/A"}%\n" +
                    $"Pago 3: Tipo {pagos.IdTipoPago3?.ToString() ?? "N/A"} - Porcentaje {pagos.PorcentajePago3?.ToString() ?? "N/A"}%",
                    "Información de Pagos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);*/


                    string serieFactura = comboBoxSerieFactura.Text;
                    //MessageBox.Show("Serie Factura: " + serieFactura, "Serie Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    int id_Usuario = idUsuario;
                    //MessageBox.Show("IdUsuario: " + idUsuario);

                    string resultado = _serviceVenta.GenerarFactura(detalles, serieFactura, cliente, direccionEntrega, pagos, id_Usuario);

                    MessageBox.Show(resultado, "Resultado de la Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (resultado.Equals("Se ha guardado correctamente la factura"))
                    {
                        LimpiarFormularioYListarVentas();
                    }
                }
                else
                {
                    cliente = new ClienteModel
                    {
                        IdCliente = 0,
                        NombreCliente = txtNombreCliente.Text,
                        DireccionFacturacion = txtDireccionFacturacion.Text,
                        Telefono = txtTelefono.Text,
                        Correo = txtCorreo.Text,
                        NIT = txtNIT.Text
                    };

                    /*MessageBox.Show($"Cliente:\nID: {cliente.IdCliente}\nNombre: {cliente.NombreCliente}\nDirección: {cliente.DireccionFacturacion}\nTeléfono: {cliente.Telefono}\nCorreo: {cliente.Correo}\nNIT: {cliente.NIT}",
                    "Información del Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

                    DateTime fechaEntrega = dateTimePicker1.Value.Date;

                    DireccionEntregaModel direccionEntrega;
                    if (!checkNuevaDirección.Checked)
                    {
                        direccionEntrega = new DireccionEntregaModel
                        {
                            IdDireccionEntrega = Convert.ToInt32(comboBoxDireccionesEntrega.SelectedValue),
                            Direccion = "",
                            DescripcionEntrega = txtDescripcion.Text,
                            TelefonoReferencia = txtTelefonoReferencia.Text,
                            FechaEntrega = fechaEntrega,
                            HoraEntrega = calcularHora()
                        };
                    }
                    else
                    {
                        direccionEntrega = new DireccionEntregaModel
                        {
                            IdDireccionEntrega = 0,
                            Direccion = txtNuevaDirección.Text,
                            DescripcionEntrega = txtDescripcion.Text,
                            TelefonoReferencia = txtTelefonoReferencia.Text,
                            FechaEntrega = fechaEntrega,
                            HoraEntrega = calcularHora()
                        };
                    }

                    /*MessageBox.Show($"Dirección de Entrega:\nID: {direccionEntrega.IdDireccionEntrega}\nDescripción: {direccionEntrega.DescripcionEntrega}\nTeléfono Referencia: {direccionEntrega.TelefonoReferencia}\nFecha Entrega: {direccionEntrega.FechaEntrega}\nHora Entrega: {direccionEntrega.HoraEntrega}",
                    "Información de Dirección de Entrega", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

                    PagoModel pagos = AsignarPagosDesdeLista(listaPagosPorcentaje);
                    /*MessageBox.Show($"Pago 1: Tipo {pagos.IdTipoPago1} - Porcentaje {pagos.PorcentajePago1}%\n" +
                    $"Pago 2: Tipo {pagos.IdTipoPago2?.ToString() ?? "N/A"} - Porcentaje {pagos.PorcentajePago2?.ToString() ?? "N/A"}%\n" +
                    $"Pago 3: Tipo {pagos.IdTipoPago3?.ToString() ?? "N/A"} - Porcentaje {pagos.PorcentajePago3?.ToString() ?? "N/A"}%",
                    "Información de Pagos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);*/


                    string serieFactura = comboBoxSerieFactura.Text;
                    //MessageBox.Show("Serie Factura: " + serieFactura, "Serie Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    int idUsuario = 4;
                    //MessageBox.Show("IdUsuario: "+idUsuario);
                    string resultado = _serviceVenta.GenerarFactura(detalles, serieFactura, cliente, direccionEntrega, pagos, idUsuario);

                    MessageBox.Show(resultado, "Resultado de la Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (resultado.Equals("Se ha guardado correctamente la factura"))
                    {
                        LimpiarFormularioYListarVentas();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            LimpiarFormularioYListarVentas();
            groupBoxAgregarProductos.Visible = false;
            groupBoxCrear.Visible = false;
            groupBoxAccionesExtra.Visible = false;
            groupBoxListar.Visible = true;
        }

        private void LimpiarFormularioYListarVentas()
        {
            txtNIT.Clear();
            txtNIT.Enabled = true;

            txtNombreCliente.Clear();
            txtNombreCliente.Enabled = true;

            txtDireccionFacturacion.Clear();
            txtDireccionFacturacion.Enabled = true;

            txtCorreo.Clear();
            txtCorreo.Enabled = true;

            txtTelefono.Clear();
            txtTelefono.Enabled = true;

            txtMontoPagar.Clear();
            txtMontoPagar.Enabled = true;

            txtTelefonoReferencia.Clear();
            txtTelefonoReferencia.Enabled = true;

            txtDescripcion.Clear();
            txtDescripcion.Enabled = true;

            dataGridViewDetalle.Rows.Clear();
            dataGridViewDetalle.Rows.Clear();

            comboBoxTipoPago.SelectedIndex = -1;
            comboBoxDireccionesEntrega.SelectedIndex = -1;
            comboBoxSerieFactura.SelectedIndex = -1;
            comboBoxHora.SelectedIndex = -1;
            comboBoxMinutos.SelectedIndex = -1;

            lblTotal.Text = "0.00";
            lblPendientePago.Text = "0.00";
            TotalVenta = 0;
            idcliente = 0;

            groupBoxCrear.Visible = false;
            groupBoxAgregarProductos.Visible = false;
            groupBoxAccionesExtra.Visible = false;
            groupBoxListar.Visible = true;

            ListarVentas();
        }

        private void txtNombreCliente_Leave(object sender, EventArgs e)
        {
            string nombreCliente = txtNombreCliente.Text;

            if (!string.IsNullOrEmpty(nombreCliente) && (txtNIT.Text == ""))
            {
                DataTable clienteData = _serviceVenta.BuscarClientePorNombre(nombreCliente);

                if (clienteData.Rows.Count > 0)
                {

                    DataTable direccionesEntrega = _serviceVenta.BuscarDireccionesEntregaClientePorNombre(nombreCliente);

                    DataRow row = clienteData.Rows[0];
                    idcliente = Convert.ToInt32(row["id_Cliente"]);
                    txtNombreCliente.Text = row["Nombre_Cliente"].ToString();
                    txtDireccionFacturacion.Text = row["DireccionFacturacion"].ToString();
                    txtCorreo.Text = row["Correo"].ToString();
                    txtTelefono.Text = row["Telefono"].ToString();
                    txtNIT.Text = row["NIT"].ToString();

                    comboBoxDireccionesEntrega.DataSource = direccionesEntrega;
                    comboBoxDireccionesEntrega.DisplayMember = "Direccion";
                    comboBoxDireccionesEntrega.ValueMember = "ID";

                    checkNuevaDirección.Checked = false;

                    txtNIT.Enabled = false;
                    checkNuevaDirección.Checked = false;
                    txtDireccionFacturacion.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtTelefono.Enabled = false;
                }
                else
                {
                    checkNuevaDirección.Checked = true;
                }
            }
            else if (checkNitExistente.Checked == false)
            {
                checkNuevaDirección.Checked = true;
                //limpiarDatosCliente();

            }
        }



        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            DataSet dataSet;



            dataSet = _serviceVenta.DatosImprimir(idFactura);

            // dataSet.WriteXml("C:\\Users\\marco\\Downloads\\prueba.xml");

            DataTable encabezado = dataSet.Tables[0];

            string carpeta = @"..\..\..\..\..\facturas\";


            string noFactura = encabezado.Rows[0]["id_Factura"].ToString();

            string nombreArchivo = carpeta + "facutraNo" + noFactura + ".PDF";

            GenerarPDF pdf = new GenerarPDF();
            pdf.ImprimirFacturaPDF(dataSet, nombreArchivo);

            MessageBox.Show("PDF de la factura generado");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show(
                "¿Está seguro de anular esta factura?",
                "Confirmación",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );


            if (result == DialogResult.OK)
            {
                _serviceVenta.AnularFactura(idFactura);

                LimpiarFormularioYListarVentas();

                groupBoxAgregarProductos.Visible = false;
                groupBoxCrear.Visible = false;
                groupBoxAccionesExtra.Visible = false;
                groupBoxListar.Visible = true;
            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(idUsuario.ToString());
        }
    }
}
