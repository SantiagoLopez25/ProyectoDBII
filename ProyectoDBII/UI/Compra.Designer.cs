namespace UI
{
    partial class Compra
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
            panelCreate = new Panel();
            btnMostrarAgregar = new FontAwesome.Sharp.IconButton();
            btnListarCompras = new FontAwesome.Sharp.IconButton();
            groupBoxAccionesExtra = new GroupBox();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            groupBoxListar = new Panel();
            dataGridViewCompras = new DataGridView();
            groupBoxAgregarProductos = new GroupBox();
            label3 = new Label();
            comboBoxProveedores = new ComboBox();
            txtDescripcion = new RichTextBox();
            label5 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            comboBoxTipoPago = new ComboBox();
            label2 = new Label();
            lblTotal = new Label();
            label4 = new Label();
            btnEliminarMueble = new FontAwesome.Sharp.IconButton();
            btnAgregarMueble = new FontAwesome.Sharp.IconButton();
            dataGridViewProductos = new DataGridView();
            btnCancelarCompra2 = new FontAwesome.Sharp.IconButton();
            txtCantidad = new TextBox();
            label22 = new Label();
            label10 = new Label();
            dataGridViewDetalle = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            panelCreate.SuspendLayout();
            groupBoxAccionesExtra.SuspendLayout();
            groupBoxListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompras).BeginInit();
            groupBoxAgregarProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalle).BeginInit();
            SuspendLayout();
            // 
            // panelCreate
            // 
            panelCreate.BackColor = Color.FromArgb(32, 30, 45);
            panelCreate.Controls.Add(btnMostrarAgregar);
            panelCreate.Controls.Add(btnListarCompras);
            panelCreate.Controls.Add(groupBoxAccionesExtra);
            panelCreate.Controls.Add(groupBoxListar);
            panelCreate.Controls.Add(groupBoxAgregarProductos);
            panelCreate.Dock = DockStyle.Fill;
            panelCreate.Location = new Point(0, 0);
            panelCreate.Margin = new Padding(0);
            panelCreate.Name = "panelCreate";
            panelCreate.Size = new Size(1414, 742);
            panelCreate.TabIndex = 2;
            panelCreate.Paint += panelCreate_Paint;
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
            btnMostrarAgregar.Click += btnMostrarAgregar_Click_1;
            // 
            // btnListarCompras
            // 
            btnListarCompras.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            btnListarCompras.IconColor = Color.Black;
            btnListarCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnListarCompras.IconSize = 30;
            btnListarCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnListarCompras.Location = new Point(1116, 34);
            btnListarCompras.Name = "btnListarCompras";
            btnListarCompras.Size = new Size(126, 33);
            btnListarCompras.TabIndex = 29;
            btnListarCompras.Text = "LISTAR";
            btnListarCompras.TextAlign = ContentAlignment.MiddleRight;
            btnListarCompras.UseVisualStyleBackColor = true;
            btnListarCompras.Click += btnListarCompras_Click_2;
            // 
            // groupBoxAccionesExtra
            // 
            groupBoxAccionesExtra.Controls.Add(btnEliminar);
            groupBoxAccionesExtra.Location = new Point(527, 8);
            groupBoxAccionesExtra.Name = "groupBoxAccionesExtra";
            groupBoxAccionesExtra.Size = new Size(156, 59);
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
            btnEliminar.Location = new Point(28, 20);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(106, 33);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // groupBoxListar
            // 
            groupBoxListar.Controls.Add(dataGridViewCompras);
            groupBoxListar.Location = new Point(15, 74);
            groupBoxListar.Name = "groupBoxListar";
            groupBoxListar.Size = new Size(1390, 645);
            groupBoxListar.TabIndex = 20;
            // 
            // dataGridViewCompras
            // 
            dataGridViewCompras.AllowUserToAddRows = false;
            dataGridViewCompras.AllowUserToDeleteRows = false;
            dataGridViewCompras.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCompras.BackgroundColor = Color.FromArgb(32, 30, 45);
            dataGridViewCompras.BorderStyle = BorderStyle.None;
            dataGridViewCompras.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCompras.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCompras.ColumnHeadersHeight = 29;
            dataGridViewCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCompras.EnableHeadersVisualStyles = false;
            dataGridViewCompras.Location = new Point(12, 10);
            dataGridViewCompras.Margin = new Padding(12, 10, 12, 10);
            dataGridViewCompras.Name = "dataGridViewCompras";
            dataGridViewCompras.ReadOnly = true;
            dataGridViewCompras.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCompras.RowHeadersWidth = 51;
            dataGridViewCompras.Size = new Size(1206, 513);
            dataGridViewCompras.TabIndex = 3;
            dataGridViewCompras.SelectionChanged += dataGridViewCompras_SelectionChanged_1;
            // 
            // groupBoxAgregarProductos
            // 
            groupBoxAgregarProductos.Controls.Add(label3);
            groupBoxAgregarProductos.Controls.Add(comboBoxProveedores);
            groupBoxAgregarProductos.Controls.Add(txtDescripcion);
            groupBoxAgregarProductos.Controls.Add(label5);
            groupBoxAgregarProductos.Controls.Add(iconButton1);
            groupBoxAgregarProductos.Controls.Add(label1);
            groupBoxAgregarProductos.Controls.Add(comboBoxTipoPago);
            groupBoxAgregarProductos.Controls.Add(label2);
            groupBoxAgregarProductos.Controls.Add(lblTotal);
            groupBoxAgregarProductos.Controls.Add(label4);
            groupBoxAgregarProductos.Controls.Add(btnEliminarMueble);
            groupBoxAgregarProductos.Controls.Add(btnAgregarMueble);
            groupBoxAgregarProductos.Controls.Add(dataGridViewProductos);
            groupBoxAgregarProductos.Controls.Add(btnCancelarCompra2);
            groupBoxAgregarProductos.Controls.Add(txtCantidad);
            groupBoxAgregarProductos.Controls.Add(label22);
            groupBoxAgregarProductos.Controls.Add(label10);
            groupBoxAgregarProductos.Controls.Add(dataGridViewDetalle);
            groupBoxAgregarProductos.Location = new Point(15, 74);
            groupBoxAgregarProductos.Margin = new Padding(0);
            groupBoxAgregarProductos.Name = "groupBoxAgregarProductos";
            groupBoxAgregarProductos.Size = new Size(1390, 645);
            groupBoxAgregarProductos.TabIndex = 39;
            groupBoxAgregarProductos.TabStop = false;
            groupBoxAgregarProductos.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(32, 30, 45);
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(82, 418);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 68;
            label3.Text = "Descripción:";
            // 
            // comboBoxProveedores
            // 
            comboBoxProveedores.FormattingEnabled = true;
            comboBoxProveedores.Location = new Point(205, 415);
            comboBoxProveedores.Name = "comboBoxProveedores";
            comboBoxProveedores.Size = new Size(231, 28);
            comboBoxProveedores.TabIndex = 67;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(205, 484);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(446, 120);
            txtDescripcion.TabIndex = 66;
            txtDescripcion.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(32, 30, 45);
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(82, 484);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 64;
            label5.Text = "Descripción:";
            // 
            // iconButton1
            // 
            iconButton1.ForeColor = Color.Black;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(1057, 596);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(126, 33);
            iconButton1.TabIndex = 63;
            iconButton1.Text = "GUARDAR";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(32, 30, 45);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 10F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(972, 444);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 62;
            label1.Text = "TIPO:";
            // 
            // comboBoxTipoPago
            // 
            comboBoxTipoPago.FormattingEnabled = true;
            comboBoxTipoPago.Location = new Point(1030, 441);
            comboBoxTipoPago.Name = "comboBoxTipoPago";
            comboBoxTipoPago.Size = new Size(197, 28);
            comboBoxTipoPago.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(32, 30, 45);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(1084, 375);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 60;
            label2.Text = "FORMAS DE PAGO";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.FromArgb(32, 30, 45);
            lblTotal.FlatStyle = FlatStyle.Flat;
            lblTotal.Font = new Font("Microsoft Sans Serif", 10F);
            lblTotal.ForeColor = Color.Gainsboro;
            lblTotal.Location = new Point(1030, 489);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(72, 20);
            lblTotal.TabIndex = 59;
            lblTotal.Text = "cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(32, 30, 45);
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Microsoft Sans Serif", 10F);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(877, 486);
            label4.Name = "label4";
            label4.Size = new Size(147, 20);
            label4.TabIndex = 58;
            label4.Text = "TOTAL A PAGAR:";
            // 
            // btnEliminarMueble
            // 
            btnEliminarMueble.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            btnEliminarMueble.IconColor = Color.Black;
            btnEliminarMueble.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarMueble.IconSize = 30;
            btnEliminarMueble.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarMueble.Location = new Point(649, 259);
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
            btnAgregarMueble.Location = new Point(649, 129);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewProductos.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProductos.Location = new Point(10, 93);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProductos.RowHeadersWidth = 51;
            dataGridViewProductos.Size = new Size(560, 236);
            dataGridViewProductos.TabIndex = 55;
            dataGridViewProductos.SelectionChanged += dataGridViewProductos_SelectionChanged;
            // 
            // btnCancelarCompra2
            // 
            btnCancelarCompra2.ForeColor = Color.Black;
            btnCancelarCompra2.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelarCompra2.IconColor = Color.Black;
            btnCancelarCompra2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelarCompra2.IconSize = 30;
            btnCancelarCompra2.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarCompra2.Location = new Point(1237, 596);
            btnCancelarCompra2.Name = "btnCancelarCompra2";
            btnCancelarCompra2.Size = new Size(137, 33);
            btnCancelarCompra2.TabIndex = 54;
            btnCancelarCompra2.Text = "CANCELAR";
            btnCancelarCompra2.TextAlign = ContentAlignment.MiddleRight;
            btnCancelarCompra2.UseVisualStyleBackColor = true;
            btnCancelarCompra2.Click += btnCancelarCompra2_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantidad.Location = new Point(741, 168);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(39, 28);
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
            label22.Location = new Point(646, 173);
            label22.Name = "label22";
            label22.Size = new Size(89, 20);
            label22.TabIndex = 42;
            label22.Text = "Cantidad:";
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
            label10.Size = new Size(227, 20);
            label10.TabIndex = 35;
            label10.Text = "SOLICITAR PRODUCTOS";
            // 
            // dataGridViewDetalle
            // 
            dataGridViewDetalle.AllowUserToAddRows = false;
            dataGridViewDetalle.AllowUserToDeleteRows = false;
            dataGridViewDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewDetalle.BackgroundColor = Color.FromArgb(32, 30, 45);
            dataGridViewDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetalle.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Cantidad, Total });
            dataGridViewDetalle.Location = new Point(861, 93);
            dataGridViewDetalle.Name = "dataGridViewDetalle";
            dataGridViewDetalle.ReadOnly = true;
            dataGridViewDetalle.RowHeadersWidth = 51;
            dataGridViewDetalle.Size = new Size(467, 236);
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
            ID.Width = 55;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 97;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 104;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 75;
            // 
            // Compra
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 742);
            Controls.Add(panelCreate);
            Font = new Font("Microsoft Sans Serif", 10F);
            Name = "Compra";
            Text = "Compra";
            Load += Compra_Load;
            panelCreate.ResumeLayout(false);
            groupBoxAccionesExtra.ResumeLayout(false);
            groupBoxListar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompras).EndInit();
            groupBoxAgregarProductos.ResumeLayout(false);
            groupBoxAgregarProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalle).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelCreate;
        private Button btnEliminarCompra;
        private Label lblId;
        private Label lblEstado;
        private DataGridView dataGridViewCompras;
        private Panel groupBoxListar;
        private GroupBox groupBoxAccionesExtra;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnListarCompras;
        private GroupBox groupBoxAgregarProductos;
        private Label label10;
        private DataGridView dataGridViewDetalle;
        private FontAwesome.Sharp.IconButton btnMostrarAgregar;
        private FontAwesome.Sharp.IconButton btnCancelarCompra2;
        private FontAwesome.Sharp.IconButton btnEliminarMueble;
        private FontAwesome.Sharp.IconButton btnAgregarMueble;
        private DataGridView dataGridViewProductos;
        private TextBox txtCantidad;
        private Label label22;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Total;
        private RichTextBox txtDescripcion;
        private Label label5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label1;
        private ComboBox comboBoxTipoPago;
        private Label label2;
        private Label lblTotal;
        private Label label4;
        private Label label3;
        private ComboBox comboBoxProveedores;
    }
}