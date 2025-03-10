namespace UI
{
    partial class Venta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            txtNIT = new TextBox();
            label1 = new Label();
            panelCreate = new Panel();
            btnMostrarAgregar = new FontAwesome.Sharp.IconButton();
            btnListarVentas = new FontAwesome.Sharp.IconButton();
            groupBoxAccionesExtra = new GroupBox();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnImprimir = new FontAwesome.Sharp.IconButton();
            groupBoxCrear = new GroupBox();
            checkNitExistente = new CheckBox();
            label16 = new Label();
            comboBoxSerieFactura = new ComboBox();
            lblPendientePago = new Label();
            label17 = new Label();
            btnEliminarTipoPago = new Button();
            btnAgregarTipoPago = new Button();
            btnCancelarVenta = new FontAwesome.Sharp.IconButton();
            btnCompletarVenta = new FontAwesome.Sharp.IconButton();
            dataGridViewPagos = new DataGridView();
            idTipoPago = new DataGridViewTextBoxColumn();
            nombreTipoPago = new DataGridViewTextBoxColumn();
            montoTipoPago = new DataGridViewTextBoxColumn();
            label20 = new Label();
            label19 = new Label();
            txtMontoPagar = new TextBox();
            comboBoxTipoPago = new ComboBox();
            label18 = new Label();
            lblDescuento = new Label();
            lblTotal = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            comboBoxMinutos = new ComboBox();
            comboBoxHora = new ComboBox();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            btnMostrarAgrProductos = new FontAwesome.Sharp.IconButton();
            txtDescripcion = new RichTextBox();
            label8 = new Label();
            label7 = new Label();
            txtTelefonoReferencia = new TextBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            checkNuevaDirección = new CheckBox();
            txtNombreCliente = new TextBox();
            label6 = new Label();
            label2 = new Label();
            txtCorreo = new TextBox();
            txtDireccionFacturacion = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBoxDireccionesEntrega = new ComboBox();
            txtNuevaDirección = new TextBox();
            groupBoxListar = new Panel();
            dataGridViewVentas = new DataGridView();
            groupBoxAgregarProductos = new GroupBox();
            btnEliminarMueble = new FontAwesome.Sharp.IconButton();
            btnAgregarMueble = new FontAwesome.Sharp.IconButton();
            dataGridViewProductos = new DataGridView();
            btnCancelarVenta2 = new FontAwesome.Sharp.IconButton();
            txtCantidad = new TextBox();
            label22 = new Label();
            btnMostrarDatosCliente = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            dataGridViewDetalle = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            panelCreate.SuspendLayout();
            groupBoxAccionesExtra.SuspendLayout();
            groupBoxCrear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPagos).BeginInit();
            groupBoxListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVentas).BeginInit();
            groupBoxAgregarProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalle).BeginInit();
            SuspendLayout();
            // 
            // txtNIT
            // 
            txtNIT.Font = new Font("Microsoft Sans Serif", 9F);
            txtNIT.Location = new Point(196, 33);
            txtNIT.Name = "txtNIT";
            txtNIT.Size = new Size(214, 28);
            txtNIT.TabIndex = 0;
            txtNIT.Leave += txtNIT_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(32, 30, 45);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 10F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(136, 35);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 1;
            label1.Text = "NIT:";
            // 
            // panelCreate
            // 
            panelCreate.BackColor = Color.FromArgb(32, 30, 45);
            panelCreate.Controls.Add(btnMostrarAgregar);
            panelCreate.Controls.Add(btnListarVentas);
            panelCreate.Controls.Add(groupBoxAccionesExtra);
            panelCreate.Controls.Add(groupBoxCrear);
            panelCreate.Controls.Add(groupBoxListar);
            panelCreate.Controls.Add(groupBoxAgregarProductos);
            panelCreate.Dock = DockStyle.Fill;
            panelCreate.Location = new Point(0, 0);
            panelCreate.Margin = new Padding(0);
            panelCreate.Name = "panelCreate";
            panelCreate.Size = new Size(1257, 622);
            panelCreate.TabIndex = 2;
            // 
            // btnMostrarAgregar
            // 
            btnMostrarAgregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnMostrarAgregar.IconColor = Color.Black;
            btnMostrarAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMostrarAgregar.IconSize = 30;
            btnMostrarAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnMostrarAgregar.Location = new Point(973, 34);
            btnMostrarAgregar.Name = "btnMostrarAgregar";
            btnMostrarAgregar.Size = new Size(126, 33);
            btnMostrarAgregar.TabIndex = 40;
            btnMostrarAgregar.Text = "AGREGAR";
            btnMostrarAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnMostrarAgregar.UseVisualStyleBackColor = true;
            btnMostrarAgregar.Click += btnMostrarAgregar_Click;
            // 
            // btnListarVentas
            // 
            btnListarVentas.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            btnListarVentas.IconColor = Color.Black;
            btnListarVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnListarVentas.IconSize = 30;
            btnListarVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnListarVentas.Location = new Point(1116, 34);
            btnListarVentas.Name = "btnListarVentas";
            btnListarVentas.Size = new Size(126, 33);
            btnListarVentas.TabIndex = 29;
            btnListarVentas.Text = "LISTAR";
            btnListarVentas.TextAlign = ContentAlignment.MiddleRight;
            btnListarVentas.UseVisualStyleBackColor = true;
            btnListarVentas.Click += btnListarVentas_Click_1;
            // 
            // groupBoxAccionesExtra
            // 
            groupBoxAccionesExtra.Controls.Add(btnEliminar);
            groupBoxAccionesExtra.Controls.Add(btnEditar);
            groupBoxAccionesExtra.Controls.Add(btnImprimir);
            groupBoxAccionesExtra.Location = new Point(505, 8);
            groupBoxAccionesExtra.Name = "groupBoxAccionesExtra";
            groupBoxAccionesExtra.Size = new Size(348, 59);
            groupBoxAccionesExtra.TabIndex = 22;
            groupBoxAccionesExtra.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 30;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(227, 18);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(106, 33);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 30;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(134, 18);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(87, 33);
            btnEditar.TabIndex = 26;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            btnImprimir.IconColor = Color.Black;
            btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnImprimir.IconSize = 30;
            btnImprimir.ImageAlign = ContentAlignment.MiddleLeft;
            btnImprimir.Location = new Point(22, 18);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(106, 33);
            btnImprimir.TabIndex = 25;
            btnImprimir.Text = "Imprimir";
            btnImprimir.TextAlign = ContentAlignment.MiddleRight;
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click_1;
            // 
            // groupBoxCrear
            // 
            groupBoxCrear.Controls.Add(checkNitExistente);
            groupBoxCrear.Controls.Add(label16);
            groupBoxCrear.Controls.Add(comboBoxSerieFactura);
            groupBoxCrear.Controls.Add(lblPendientePago);
            groupBoxCrear.Controls.Add(label17);
            groupBoxCrear.Controls.Add(btnEliminarTipoPago);
            groupBoxCrear.Controls.Add(btnAgregarTipoPago);
            groupBoxCrear.Controls.Add(btnCancelarVenta);
            groupBoxCrear.Controls.Add(btnCompletarVenta);
            groupBoxCrear.Controls.Add(dataGridViewPagos);
            groupBoxCrear.Controls.Add(label20);
            groupBoxCrear.Controls.Add(label19);
            groupBoxCrear.Controls.Add(txtMontoPagar);
            groupBoxCrear.Controls.Add(comboBoxTipoPago);
            groupBoxCrear.Controls.Add(label18);
            groupBoxCrear.Controls.Add(lblDescuento);
            groupBoxCrear.Controls.Add(lblTotal);
            groupBoxCrear.Controls.Add(label15);
            groupBoxCrear.Controls.Add(label14);
            groupBoxCrear.Controls.Add(label13);
            groupBoxCrear.Controls.Add(label12);
            groupBoxCrear.Controls.Add(comboBoxMinutos);
            groupBoxCrear.Controls.Add(comboBoxHora);
            groupBoxCrear.Controls.Add(label11);
            groupBoxCrear.Controls.Add(dateTimePicker1);
            groupBoxCrear.Controls.Add(label9);
            groupBoxCrear.Controls.Add(btnMostrarAgrProductos);
            groupBoxCrear.Controls.Add(txtDescripcion);
            groupBoxCrear.Controls.Add(label8);
            groupBoxCrear.Controls.Add(label7);
            groupBoxCrear.Controls.Add(txtTelefonoReferencia);
            groupBoxCrear.Controls.Add(label5);
            groupBoxCrear.Controls.Add(txtTelefono);
            groupBoxCrear.Controls.Add(checkNuevaDirección);
            groupBoxCrear.Controls.Add(txtNIT);
            groupBoxCrear.Controls.Add(label1);
            groupBoxCrear.Controls.Add(txtNombreCliente);
            groupBoxCrear.Controls.Add(label6);
            groupBoxCrear.Controls.Add(label2);
            groupBoxCrear.Controls.Add(txtCorreo);
            groupBoxCrear.Controls.Add(txtDireccionFacturacion);
            groupBoxCrear.Controls.Add(label3);
            groupBoxCrear.Controls.Add(label4);
            groupBoxCrear.Controls.Add(comboBoxDireccionesEntrega);
            groupBoxCrear.Controls.Add(txtNuevaDirección);
            groupBoxCrear.ForeColor = Color.Transparent;
            groupBoxCrear.Location = new Point(15, 74);
            groupBoxCrear.Margin = new Padding(0);
            groupBoxCrear.Name = "groupBoxCrear";
            groupBoxCrear.Size = new Size(1233, 539);
            groupBoxCrear.TabIndex = 18;
            groupBoxCrear.TabStop = false;
            groupBoxCrear.Visible = false;
            // 
            // checkNitExistente
            // 
            checkNitExistente.AutoSize = true;
            checkNitExistente.ForeColor = Color.White;
            checkNitExistente.Location = new Point(416, 34);
            checkNitExistente.Name = "checkNitExistente";
            checkNitExistente.Size = new Size(70, 29);
            checkNitExistente.TabIndex = 60;
            checkNitExistente.Text = "NIT";
            checkNitExistente.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(32, 30, 45);
            label16.FlatStyle = FlatStyle.Flat;
            label16.Font = new Font("Microsoft Sans Serif", 10F);
            label16.ForeColor = Color.Gainsboro;
            label16.Location = new Point(352, 188);
            label16.Name = "label16";
            label16.Size = new Size(135, 25);
            label16.TabIndex = 59;
            label16.Text = "Serie Factura:";
            // 
            // comboBoxSerieFactura
            // 
            comboBoxSerieFactura.FormattingEnabled = true;
            comboBoxSerieFactura.Items.AddRange(new object[] { "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18" });
            comboBoxSerieFactura.Location = new Point(473, 185);
            comboBoxSerieFactura.Name = "comboBoxSerieFactura";
            comboBoxSerieFactura.Size = new Size(116, 33);
            comboBoxSerieFactura.TabIndex = 58;
            // 
            // lblPendientePago
            // 
            lblPendientePago.AutoSize = true;
            lblPendientePago.BackColor = Color.FromArgb(32, 30, 45);
            lblPendientePago.FlatStyle = FlatStyle.Flat;
            lblPendientePago.Font = new Font("Microsoft Sans Serif", 10F);
            lblPendientePago.ForeColor = Color.Gainsboro;
            lblPendientePago.Location = new Point(450, 474);
            lblPendientePago.Name = "lblPendientePago";
            lblPendientePago.Size = new Size(86, 25);
            lblPendientePago.TabIndex = 57;
            lblPendientePago.Text = "cantidad";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.FromArgb(32, 30, 45);
            label17.FlatStyle = FlatStyle.Flat;
            label17.Font = new Font("Microsoft Sans Serif", 10F);
            label17.ForeColor = Color.Gainsboro;
            label17.Location = new Point(337, 474);
            label17.Name = "label17";
            label17.Size = new Size(104, 25);
            label17.TabIndex = 56;
            label17.Text = "PAGADO:";
            // 
            // btnEliminarTipoPago
            // 
            btnEliminarTipoPago.BackColor = Color.WhiteSmoke;
            btnEliminarTipoPago.ForeColor = Color.FromArgb(32, 30, 45);
            btnEliminarTipoPago.Location = new Point(115, 456);
            btnEliminarTipoPago.Margin = new Padding(0);
            btnEliminarTipoPago.Name = "btnEliminarTipoPago";
            btnEliminarTipoPago.Size = new Size(94, 29);
            btnEliminarTipoPago.TabIndex = 55;
            btnEliminarTipoPago.Text = "Eliminar";
            btnEliminarTipoPago.UseVisualStyleBackColor = false;
            btnEliminarTipoPago.Click += btnEliminarTipoPago_Click;
            // 
            // btnAgregarTipoPago
            // 
            btnAgregarTipoPago.BackColor = Color.WhiteSmoke;
            btnAgregarTipoPago.ForeColor = Color.FromArgb(32, 30, 45);
            btnAgregarTipoPago.Location = new Point(115, 416);
            btnAgregarTipoPago.Margin = new Padding(0);
            btnAgregarTipoPago.Name = "btnAgregarTipoPago";
            btnAgregarTipoPago.Size = new Size(94, 29);
            btnAgregarTipoPago.TabIndex = 54;
            btnAgregarTipoPago.Text = "Agregar";
            btnAgregarTipoPago.UseVisualStyleBackColor = false;
            btnAgregarTipoPago.Click += btnAgregarTipoPago_Click;
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.ForeColor = Color.Black;
            btnCancelarVenta.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelarVenta.IconColor = Color.Black;
            btnCancelarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelarVenta.IconSize = 30;
            btnCancelarVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarVenta.Location = new Point(1090, 430);
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.Size = new Size(137, 33);
            btnCancelarVenta.TabIndex = 53;
            btnCancelarVenta.Text = "CANCELAR";
            btnCancelarVenta.TextAlign = ContentAlignment.MiddleRight;
            btnCancelarVenta.UseVisualStyleBackColor = true;
            btnCancelarVenta.Click += btnCancelarVenta_Click;
            // 
            // btnCompletarVenta
            // 
            btnCompletarVenta.ForeColor = Color.Black;
            btnCompletarVenta.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnCompletarVenta.IconColor = Color.Black;
            btnCompletarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCompletarVenta.IconSize = 30;
            btnCompletarVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompletarVenta.Location = new Point(958, 430);
            btnCompletarVenta.Name = "btnCompletarVenta";
            btnCompletarVenta.Size = new Size(126, 33);
            btnCompletarVenta.TabIndex = 52;
            btnCompletarVenta.Text = "GUARDAR";
            btnCompletarVenta.TextAlign = ContentAlignment.MiddleRight;
            btnCompletarVenta.UseVisualStyleBackColor = true;
            btnCompletarVenta.Click += btnCompletarVenta_Click;
            // 
            // dataGridViewPagos
            // 
            dataGridViewPagos.AllowUserToAddRows = false;
            dataGridViewPagos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewPagos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewPagos.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPagos.Columns.AddRange(new DataGridViewColumn[] { idTipoPago, nombreTipoPago, montoTipoPago });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewPagos.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewPagos.GridColor = Color.FromArgb(32, 30, 45);
            dataGridViewPagos.Location = new Point(283, 267);
            dataGridViewPagos.Name = "dataGridViewPagos";
            dataGridViewPagos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewPagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewPagos.RowHeadersWidth = 51;
            dataGridViewPagos.Size = new Size(304, 148);
            dataGridViewPagos.TabIndex = 51;
            // 
            // idTipoPago
            // 
            idTipoPago.HeaderText = "ID";
            idTipoPago.MinimumWidth = 6;
            idTipoPago.Name = "idTipoPago";
            idTipoPago.ReadOnly = true;
            idTipoPago.Width = 58;
            // 
            // nombreTipoPago
            // 
            nombreTipoPago.HeaderText = "Tipo Pago";
            nombreTipoPago.MinimumWidth = 6;
            nombreTipoPago.Name = "nombreTipoPago";
            nombreTipoPago.ReadOnly = true;
            nombreTipoPago.Width = 112;
            // 
            // montoTipoPago
            // 
            montoTipoPago.HeaderText = "Monto";
            montoTipoPago.MinimumWidth = 6;
            montoTipoPago.Name = "montoTipoPago";
            montoTipoPago.ReadOnly = true;
            montoTipoPago.Width = 87;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.FromArgb(32, 30, 45);
            label20.FlatStyle = FlatStyle.Flat;
            label20.Font = new Font("Microsoft Sans Serif", 10F);
            label20.ForeColor = Color.Gainsboro;
            label20.Location = new Point(47, 379);
            label20.Name = "label20";
            label20.Size = new Size(65, 25);
            label20.TabIndex = 50;
            label20.Text = "TIPO:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.FromArgb(32, 30, 45);
            label19.FlatStyle = FlatStyle.Flat;
            label19.Font = new Font("Microsoft Sans Serif", 10F);
            label19.ForeColor = Color.Gainsboro;
            label19.Location = new Point(23, 330);
            label19.Name = "label19";
            label19.Size = new Size(94, 25);
            label19.TabIndex = 49;
            label19.Text = "MONTO:";
            // 
            // txtMontoPagar
            // 
            txtMontoPagar.Font = new Font("Microsoft Sans Serif", 9F);
            txtMontoPagar.Location = new Point(105, 328);
            txtMontoPagar.Name = "txtMontoPagar";
            txtMontoPagar.Size = new Size(148, 28);
            txtMontoPagar.TabIndex = 48;
            // 
            // comboBoxTipoPago
            // 
            comboBoxTipoPago.FormattingEnabled = true;
            comboBoxTipoPago.Location = new Point(105, 371);
            comboBoxTipoPago.Name = "comboBoxTipoPago";
            comboBoxTipoPago.Size = new Size(148, 33);
            comboBoxTipoPago.TabIndex = 47;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.FromArgb(32, 30, 45);
            label18.FlatStyle = FlatStyle.Flat;
            label18.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Gainsboro;
            label18.Location = new Point(196, 244);
            label18.Name = "label18";
            label18.Size = new Size(203, 25);
            label18.TabIndex = 46;
            label18.Text = "FORMAS DE PAGO";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.BackColor = Color.FromArgb(32, 30, 45);
            lblDescuento.FlatStyle = FlatStyle.Flat;
            lblDescuento.Font = new Font("Microsoft Sans Serif", 10F);
            lblDescuento.ForeColor = Color.Gainsboro;
            lblDescuento.Location = new Point(452, 503);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(0, 25);
            lblDescuento.TabIndex = 45;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.FromArgb(32, 30, 45);
            lblTotal.FlatStyle = FlatStyle.Flat;
            lblTotal.Font = new Font("Microsoft Sans Serif", 10F);
            lblTotal.ForeColor = Color.Gainsboro;
            lblTotal.Location = new Point(450, 443);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(86, 25);
            lblTotal.TabIndex = 44;
            lblTotal.Text = "cantidad";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(32, 30, 45);
            label15.FlatStyle = FlatStyle.Flat;
            label15.Font = new Font("Microsoft Sans Serif", 10F);
            label15.ForeColor = Color.Gainsboro;
            label15.Location = new Point(327, 503);
            label15.Name = "label15";
            label15.Size = new Size(144, 25);
            label15.TabIndex = 43;
            label15.Text = "DESCUENTO:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(32, 30, 45);
            label14.FlatStyle = FlatStyle.Flat;
            label14.Font = new Font("Microsoft Sans Serif", 10F);
            label14.ForeColor = Color.Gainsboro;
            label14.Location = new Point(299, 443);
            label14.Name = "label14";
            label14.Size = new Size(178, 25);
            label14.TabIndex = 42;
            label14.Text = "TOTAL A PAGAR:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(32, 30, 45);
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Microsoft Sans Serif", 10F);
            label13.ForeColor = Color.Gainsboro;
            label13.Location = new Point(967, 334);
            label13.Name = "label13";
            label13.Size = new Size(53, 25);
            label13.TabIndex = 41;
            label13.Text = "mins";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(32, 30, 45);
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Microsoft Sans Serif", 10F);
            label12.ForeColor = Color.Gainsboro;
            label12.Location = new Point(853, 334);
            label12.Name = "label12";
            label12.Size = new Size(39, 25);
            label12.TabIndex = 40;
            label12.Text = "hrs";
            // 
            // comboBoxMinutos
            // 
            comboBoxMinutos.FormattingEnabled = true;
            comboBoxMinutos.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
            comboBoxMinutos.Location = new Point(892, 323);
            comboBoxMinutos.Name = "comboBoxMinutos";
            comboBoxMinutos.Size = new Size(69, 33);
            comboBoxMinutos.TabIndex = 39;
            // 
            // comboBoxHora
            // 
            comboBoxHora.FormattingEnabled = true;
            comboBoxHora.Items.AddRange(new object[] { "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18" });
            comboBoxHora.Location = new Point(778, 323);
            comboBoxHora.Name = "comboBoxHora";
            comboBoxHora.Size = new Size(69, 33);
            comboBoxHora.TabIndex = 38;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(32, 30, 45);
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Microsoft Sans Serif", 10F);
            label11.ForeColor = Color.Gainsboro;
            label11.Location = new Point(658, 326);
            label11.Name = "label11";
            label11.Size = new Size(133, 25);
            label11.TabIndex = 37;
            label11.Text = "Hora Entrega:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(778, 286);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(306, 30);
            dateTimePicker1.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(32, 30, 45);
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Microsoft Sans Serif", 10F);
            label9.ForeColor = Color.Gainsboro;
            label9.Location = new Point(649, 291);
            label9.Name = "label9";
            label9.Size = new Size(146, 25);
            label9.TabIndex = 35;
            label9.Text = "Fecha Entrega:";
            // 
            // btnMostrarAgrProductos
            // 
            btnMostrarAgrProductos.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            btnMostrarAgrProductos.IconColor = Color.Black;
            btnMostrarAgrProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMostrarAgrProductos.IconSize = 30;
            btnMostrarAgrProductos.Location = new Point(12, 25);
            btnMostrarAgrProductos.Name = "btnMostrarAgrProductos";
            btnMostrarAgrProductos.Size = new Size(43, 30);
            btnMostrarAgrProductos.TabIndex = 24;
            btnMostrarAgrProductos.UseVisualStyleBackColor = true;
            btnMostrarAgrProductos.Click += btnMostrarAgrProductos_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(778, 115);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(449, 116);
            txtDescripcion.TabIndex = 33;
            txtDescripcion.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(32, 30, 45);
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Microsoft Sans Serif", 10F);
            label8.ForeColor = Color.Gainsboro;
            label8.Location = new Point(605, 118);
            label8.Name = "label8";
            label8.Size = new Size(193, 25);
            label8.TabIndex = 32;
            label8.Text = "Descripción Entrega:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(32, 30, 45);
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Microsoft Sans Serif", 10F);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(10, 188);
            label7.Name = "label7";
            label7.Size = new Size(220, 25);
            label7.TabIndex = 30;
            label7.Text = "Teléfono de Referencia:";
            // 
            // txtTelefonoReferencia
            // 
            txtTelefonoReferencia.Font = new Font("Microsoft Sans Serif", 9F);
            txtTelefonoReferencia.Location = new Point(196, 188);
            txtTelefonoReferencia.Name = "txtTelefonoReferencia";
            txtTelefonoReferencia.Size = new Size(126, 28);
            txtTelefonoReferencia.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(32, 30, 45);
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Microsoft Sans Serif", 10F);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(112, 154);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 28;
            label5.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Microsoft Sans Serif", 9F);
            txtTelefono.Location = new Point(196, 152);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(126, 28);
            txtTelefono.TabIndex = 27;
            // 
            // checkNuevaDirección
            // 
            checkNuevaDirección.AutoSize = true;
            checkNuevaDirección.ForeColor = Color.White;
            checkNuevaDirección.Location = new Point(1014, 71);
            checkNuevaDirección.Name = "checkNuevaDirección";
            checkNuevaDirección.Size = new Size(181, 29);
            checkNuevaDirección.TabIndex = 25;
            checkNuevaDirección.Text = "Nueva Dirección";
            checkNuevaDirección.UseVisualStyleBackColor = true;
            checkNuevaDirección.CheckedChanged += checkNuevaDirección_CheckedChanged;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Font = new Font("Microsoft Sans Serif", 9F);
            txtNombreCliente.Location = new Point(196, 73);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(214, 28);
            txtNombreCliente.TabIndex = 8;
            txtNombreCliente.Leave += txtNombreCliente_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(32, 30, 45);
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Microsoft Sans Serif", 10F);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(115, 115);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 15;
            label6.Text = "Correo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(32, 30, 45);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(115, 75);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 9;
            label2.Text = "Nombre:";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Microsoft Sans Serif", 9F);
            txtCorreo.Location = new Point(196, 113);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(214, 28);
            txtCorreo.TabIndex = 14;
            // 
            // txtDireccionFacturacion
            // 
            txtDireccionFacturacion.Font = new Font("Microsoft Sans Serif", 9F);
            txtDireccionFacturacion.Location = new Point(778, 29);
            txtDireccionFacturacion.Name = "txtDireccionFacturacion";
            txtDireccionFacturacion.Size = new Size(214, 28);
            txtDireccionFacturacion.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(32, 30, 45);
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Microsoft Sans Serif", 10F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(623, 70);
            label3.Name = "label3";
            label3.Size = new Size(172, 25);
            label3.TabIndex = 13;
            label3.Text = "Dirección Entrega:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(32, 30, 45);
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Microsoft Sans Serif", 10F);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(593, 29);
            label4.Name = "label4";
            label4.Size = new Size(206, 25);
            label4.TabIndex = 11;
            label4.Text = "Dirección Facturación:";
            // 
            // comboBoxDireccionesEntrega
            // 
            comboBoxDireccionesEntrega.FormattingEnabled = true;
            comboBoxDireccionesEntrega.Location = new Point(778, 66);
            comboBoxDireccionesEntrega.Name = "comboBoxDireccionesEntrega";
            comboBoxDireccionesEntrega.Size = new Size(214, 33);
            comboBoxDireccionesEntrega.TabIndex = 24;
            // 
            // txtNuevaDirección
            // 
            txtNuevaDirección.Font = new Font("Microsoft Sans Serif", 9F);
            txtNuevaDirección.Location = new Point(778, 70);
            txtNuevaDirección.Name = "txtNuevaDirección";
            txtNuevaDirección.Size = new Size(214, 28);
            txtNuevaDirección.TabIndex = 26;
            txtNuevaDirección.Visible = false;
            // 
            // groupBoxListar
            // 
            groupBoxListar.Controls.Add(dataGridViewVentas);
            groupBoxListar.Location = new Point(15, 74);
            groupBoxListar.Name = "groupBoxListar";
            groupBoxListar.Size = new Size(1233, 469);
            groupBoxListar.TabIndex = 20;
            // 
            // dataGridViewVentas
            // 
            dataGridViewVentas.AllowUserToAddRows = false;
            dataGridViewVentas.AllowUserToDeleteRows = false;
            dataGridViewVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewVentas.BackgroundColor = Color.FromArgb(32, 30, 45);
            dataGridViewVentas.BorderStyle = BorderStyle.None;
            dataGridViewVentas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewVentas.ColumnHeadersHeight = 29;
            dataGridViewVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewVentas.EnableHeadersVisualStyles = false;
            dataGridViewVentas.Location = new Point(12, 10);
            dataGridViewVentas.Margin = new Padding(12, 10, 12, 10);
            dataGridViewVentas.Name = "dataGridViewVentas";
            dataGridViewVentas.ReadOnly = true;
            dataGridViewVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewVentas.RowHeadersWidth = 51;
            dataGridViewVentas.Size = new Size(1206, 513);
            dataGridViewVentas.TabIndex = 3;
            dataGridViewVentas.SelectionChanged += dataGridViewVentaes_SelectionChanged;
            // 
            // groupBoxAgregarProductos
            // 
            groupBoxAgregarProductos.Controls.Add(btnEliminarMueble);
            groupBoxAgregarProductos.Controls.Add(btnAgregarMueble);
            groupBoxAgregarProductos.Controls.Add(dataGridViewProductos);
            groupBoxAgregarProductos.Controls.Add(btnCancelarVenta2);
            groupBoxAgregarProductos.Controls.Add(txtCantidad);
            groupBoxAgregarProductos.Controls.Add(label22);
            groupBoxAgregarProductos.Controls.Add(btnMostrarDatosCliente);
            groupBoxAgregarProductos.Controls.Add(label10);
            groupBoxAgregarProductos.Controls.Add(dataGridViewDetalle);
            groupBoxAgregarProductos.Location = new Point(15, 74);
            groupBoxAgregarProductos.Margin = new Padding(0);
            groupBoxAgregarProductos.Name = "groupBoxAgregarProductos";
            groupBoxAgregarProductos.Size = new Size(1233, 536);
            groupBoxAgregarProductos.TabIndex = 39;
            groupBoxAgregarProductos.TabStop = false;
            groupBoxAgregarProductos.Visible = false;
            // 
            // btnEliminarMueble
            // 
            btnEliminarMueble.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            btnEliminarMueble.IconColor = Color.Black;
            btnEliminarMueble.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarMueble.IconSize = 30;
            btnEliminarMueble.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarMueble.Location = new Point(565, 340);
            btnEliminarMueble.Name = "btnEliminarMueble";
            btnEliminarMueble.Size = new Size(132, 33);
            btnEliminarMueble.TabIndex = 57;
            btnEliminarMueble.Text = "ELIMINAR";
            btnEliminarMueble.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarMueble.UseVisualStyleBackColor = true;
            btnEliminarMueble.Click += btnEliminarMueble_Click;
            // 
            // btnAgregarMueble
            // 
            btnAgregarMueble.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            btnAgregarMueble.IconColor = Color.Black;
            btnAgregarMueble.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarMueble.IconSize = 30;
            btnAgregarMueble.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarMueble.Location = new Point(568, 154);
            btnAgregarMueble.Name = "btnAgregarMueble";
            btnAgregarMueble.Size = new Size(132, 33);
            btnAgregarMueble.TabIndex = 56;
            btnAgregarMueble.Text = "AGREGAR";
            btnAgregarMueble.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarMueble.UseVisualStyleBackColor = true;
            btnAgregarMueble.Click += btnAgregarMueble_Click;
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AllowUserToAddRows = false;
            dataGridViewProductos.AllowUserToDeleteRows = false;
            dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewProductos.BackgroundColor = Color.FromArgb(32, 30, 45);
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewProductos.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewProductos.Location = new Point(10, 93);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewProductos.RowHeadersWidth = 51;
            dataGridViewProductos.Size = new Size(529, 339);
            dataGridViewProductos.TabIndex = 55;
            dataGridViewProductos.SelectionChanged += dataGridViewProductos_SelectionChanged;
            // 
            // btnCancelarVenta2
            // 
            btnCancelarVenta2.ForeColor = Color.Black;
            btnCancelarVenta2.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelarVenta2.IconColor = Color.Black;
            btnCancelarVenta2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelarVenta2.IconSize = 30;
            btnCancelarVenta2.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarVenta2.Location = new Point(1081, 475);
            btnCancelarVenta2.Name = "btnCancelarVenta2";
            btnCancelarVenta2.Size = new Size(137, 33);
            btnCancelarVenta2.TabIndex = 54;
            btnCancelarVenta2.Text = "CANCELAR";
            btnCancelarVenta2.TextAlign = ContentAlignment.MiddleRight;
            btnCancelarVenta2.UseVisualStyleBackColor = true;
            btnCancelarVenta2.Click += btnCancelarVenta2_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantidad.Location = new Point(660, 193);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(39, 32);
            txtCantidad.TabIndex = 43;
            txtCantidad.Text = "1";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.FromArgb(32, 30, 45);
            label22.FlatStyle = FlatStyle.Flat;
            label22.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Gainsboro;
            label22.Location = new Point(565, 198);
            label22.Name = "label22";
            label22.Size = new Size(113, 25);
            label22.TabIndex = 42;
            label22.Text = "Cantidad:";
            // 
            // btnMostrarDatosCliente
            // 
            btnMostrarDatosCliente.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            btnMostrarDatosCliente.IconColor = Color.Black;
            btnMostrarDatosCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMostrarDatosCliente.IconSize = 30;
            btnMostrarDatosCliente.Location = new Point(12, 25);
            btnMostrarDatosCliente.Name = "btnMostrarDatosCliente";
            btnMostrarDatosCliente.Size = new Size(43, 30);
            btnMostrarDatosCliente.TabIndex = 40;
            btnMostrarDatosCliente.UseVisualStyleBackColor = true;
            btnMostrarDatosCliente.Click += btnMostrarDatosCliente_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(32, 30, 45);
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Gainsboro;
            label10.Location = new Point(512, 35);
            label10.Name = "label10";
            label10.Size = new Size(272, 25);
            label10.TabIndex = 35;
            label10.Text = "AGREGAR PRODUCTOS";
            // 
            // dataGridViewDetalle
            // 
            dataGridViewDetalle.AllowUserToAddRows = false;
            dataGridViewDetalle.AllowUserToDeleteRows = false;
            dataGridViewDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewDetalle.BackgroundColor = Color.FromArgb(32, 30, 45);
            dataGridViewDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetalle.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Cantidad, Total });
            dataGridViewDetalle.Location = new Point(726, 93);
            dataGridViewDetalle.Name = "dataGridViewDetalle";
            dataGridViewDetalle.ReadOnly = true;
            dataGridViewDetalle.RowHeadersWidth = 51;
            dataGridViewDetalle.Size = new Size(504, 331);
            dataGridViewDetalle.TabIndex = 34;
            dataGridViewDetalle.CellValueChanged += dataGridViewDetalle_CellValueChanged;
            dataGridViewDetalle.RowsAdded += dataGridViewDetalle_RowsAdded;
            dataGridViewDetalle.RowsRemoved += dataGridViewDetalle_RowsRemoved;
            dataGridViewDetalle.SelectionChanged += dataGridViewDetalle_SelectionChanged;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 67;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 117;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 127;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 92;
            // 
            // Venta
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 622);
            Controls.Add(panelCreate);
            Font = new Font("Microsoft Sans Serif", 10F);
            Name = "Venta";
            Text = "Venta";
            Load += Venta_Load;
            panelCreate.ResumeLayout(false);
            groupBoxAccionesExtra.ResumeLayout(false);
            groupBoxCrear.ResumeLayout(false);
            groupBoxCrear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPagos).EndInit();
            groupBoxListar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVentas).EndInit();
            groupBoxAgregarProductos.ResumeLayout(false);
            groupBoxAgregarProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNIT;
        private Label label1;
        private Panel panelCreate;
        private Button btnEliminarVenta;
        private Label lblId;
        private Label lblEstado;
        private Label label2;
        private TextBox txtNombreCliente;
        private DataGridView dataGridViewVentas;
        private Label label6;
        private TextBox txtCorreo;
        private Label label3;
        private Label label4;
        private TextBox txtDireccionFacturacion;
        private GroupBox groupBoxCrear;
        private Panel groupBoxListar;
        private CheckBox checkNuevaDirección;
        private ComboBox comboBoxDireccionesEntrega;
        private TextBox txtNuevaDirección;
        private RichTextBox txtDescripcion;
        private Label label8;
        private Label label7;
        private TextBox txtTelefonoReferencia;
        private Label label5;
        private TextBox txtTelefono;
        private GroupBox groupBoxAccionesExtra;
        private FontAwesome.Sharp.IconButton btnMostrarAgrProductos;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnListarVentas;
        private GroupBox groupBoxAgregarProductos;
        private Label label10;
        private DataGridView dataGridViewDetalle;
        private FontAwesome.Sharp.IconButton btnMostrarAgregar;
        private FontAwesome.Sharp.IconButton btnMostrarDatosCliente;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private Label label11;
        private Label label13;
        private Label label12;
        private ComboBox comboBoxMinutos;
        private ComboBox comboBoxHora;
        private Label label15;
        private Label label14;
        private Label lblDescuento;
        private Label lblTotal;
        private Label label20;
        private Label label19;
        private TextBox txtMontoPagar;
        private ComboBox comboBoxTipoPago;
        private Label label18;
        private DataGridView dataGridViewPagos;
        private FontAwesome.Sharp.IconButton btnCompletarVenta;
        private FontAwesome.Sharp.IconButton btnCancelarVenta2;
        private FontAwesome.Sharp.IconButton btnCancelarVenta;
        private FontAwesome.Sharp.IconButton btnEliminarMueble;
        private FontAwesome.Sharp.IconButton btnAgregarMueble;
        private DataGridView dataGridViewProductos;
        private TextBox txtCantidad;
        private Label label22;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Total;
        private Button btnAgregarTipoPago;
        private Button btnEliminarTipoPago;
        private DataGridViewTextBoxColumn idTipoPago;
        private DataGridViewTextBoxColumn nombreTipoPago;
        private DataGridViewTextBoxColumn montoTipoPago;
        private Label lblPendientePago;
        private Label label17;
        private Label label16;
        private ComboBox comboBoxSerieFactura;
        private CheckBox checkNitExistente;
    }
}