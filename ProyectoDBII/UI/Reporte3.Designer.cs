namespace UI
{
    partial class Reporte3
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
            label4 = new Label();
            label2 = new Label();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            dataGridViewMetodosPago = new DataGridView();
            dataGridViewDetalleFactura = new DataGridView();
            comboBoxIdFactura = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            labelSerie = new Label();
            labelTotal = new Label();
            labelCliente = new Label();
            labelDireccion = new Label();
            labelNit = new Label();
            labelFecha = new Label();
            labelSinDescuento = new Label();
            labelUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMetodosPago).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalleFactura).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(32, 30, 45);
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(83, 33);
            label4.Name = "label4";
            label4.Size = new Size(191, 32);
            label4.TabIndex = 51;
            label4.Text = "Datos Factura";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(32, 30, 45);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(83, 120);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 46;
            label2.Text = "No Factura";
            // 
            // btnBuscar
            // 
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 30;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(923, 103);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(177, 49);
            btnBuscar.TabIndex = 45;
            btnBuscar.Text = "Buscar Factura";
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dataGridViewMetodosPago
            // 
            dataGridViewMetodosPago.AllowUserToAddRows = false;
            dataGridViewMetodosPago.AllowUserToDeleteRows = false;
            dataGridViewMetodosPago.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewMetodosPago.BorderStyle = BorderStyle.None;
            dataGridViewMetodosPago.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewMetodosPago.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewMetodosPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMetodosPago.Location = new Point(721, 183);
            dataGridViewMetodosPago.Name = "dataGridViewMetodosPago";
            dataGridViewMetodosPago.RowHeadersWidth = 62;
            dataGridViewMetodosPago.Size = new Size(379, 303);
            dataGridViewMetodosPago.TabIndex = 52;
            // 
            // dataGridViewDetalleFactura
            // 
            dataGridViewDetalleFactura.AllowUserToAddRows = false;
            dataGridViewDetalleFactura.AllowUserToDeleteRows = false;
            dataGridViewDetalleFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDetalleFactura.BorderStyle = BorderStyle.None;
            dataGridViewDetalleFactura.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewDetalleFactura.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewDetalleFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetalleFactura.Location = new Point(83, 560);
            dataGridViewDetalleFactura.Name = "dataGridViewDetalleFactura";
            dataGridViewDetalleFactura.RowHeadersWidth = 62;
            dataGridViewDetalleFactura.Size = new Size(1017, 262);
            dataGridViewDetalleFactura.TabIndex = 53;
            // 
            // comboBoxIdFactura
            // 
            comboBoxIdFactura.ForeColor = Color.Black;
            comboBoxIdFactura.FormattingEnabled = true;
            comboBoxIdFactura.Location = new Point(223, 112);
            comboBoxIdFactura.Name = "comboBoxIdFactura";
            comboBoxIdFactura.Size = new Size(182, 33);
            comboBoxIdFactura.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(32, 30, 45);
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Microsoft Sans Serif", 10F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(83, 202);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 55;
            label3.Text = "Serie: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(32, 30, 45);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 10F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(360, 202);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 56;
            label1.Text = "Fecha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(32, 30, 45);
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Microsoft Sans Serif", 10F);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(83, 325);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 57;
            label5.Text = "Cliente:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(32, 30, 45);
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Microsoft Sans Serif", 10F);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(83, 400);
            label6.Name = "label6";
            label6.Size = new Size(99, 25);
            label6.TabIndex = 58;
            label6.Text = "Dirección:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(32, 30, 45);
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Microsoft Sans Serif", 10F);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(83, 266);
            label7.Name = "label7";
            label7.Size = new Size(62, 25);
            label7.TabIndex = 59;
            label7.Text = "Total:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(32, 30, 45);
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Microsoft Sans Serif", 10F);
            label8.ForeColor = Color.Gainsboro;
            label8.Location = new Point(360, 266);
            label8.Name = "label8";
            label8.Size = new Size(188, 25);
            label8.TabIndex = 60;
            label8.Text = "Total sin descuento:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(32, 30, 45);
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Microsoft Sans Serif", 10F);
            label9.ForeColor = Color.Gainsboro;
            label9.Location = new Point(83, 461);
            label9.Name = "label9";
            label9.Size = new Size(41, 25);
            label9.TabIndex = 61;
            label9.Text = "Nit:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(32, 30, 45);
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Microsoft Sans Serif", 10F);
            label10.ForeColor = Color.Gainsboro;
            label10.Location = new Point(360, 461);
            label10.Name = "label10";
            label10.Size = new Size(85, 25);
            label10.TabIndex = 62;
            label10.Text = "Usuario:";
            // 
            // labelSerie
            // 
            labelSerie.AutoSize = true;
            labelSerie.BackColor = Color.FromArgb(32, 30, 45);
            labelSerie.FlatStyle = FlatStyle.Flat;
            labelSerie.Font = new Font("Microsoft Sans Serif", 10F);
            labelSerie.ForeColor = Color.Gainsboro;
            labelSerie.Location = new Point(158, 202);
            labelSerie.Name = "labelSerie";
            labelSerie.Size = new Size(69, 25);
            labelSerie.TabIndex = 63;
            labelSerie.Text = "Serie: ";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.BackColor = Color.FromArgb(32, 30, 45);
            labelTotal.FlatStyle = FlatStyle.Flat;
            labelTotal.Font = new Font("Microsoft Sans Serif", 10F);
            labelTotal.ForeColor = Color.Gainsboro;
            labelTotal.Location = new Point(158, 266);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(69, 25);
            labelTotal.TabIndex = 64;
            labelTotal.Text = "Serie: ";
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.BackColor = Color.FromArgb(32, 30, 45);
            labelCliente.FlatStyle = FlatStyle.Flat;
            labelCliente.Font = new Font("Microsoft Sans Serif", 10F);
            labelCliente.ForeColor = Color.Gainsboro;
            labelCliente.Location = new Point(180, 325);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(69, 25);
            labelCliente.TabIndex = 65;
            labelCliente.Text = "Serie: ";
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.BackColor = Color.FromArgb(32, 30, 45);
            labelDireccion.FlatStyle = FlatStyle.Flat;
            labelDireccion.Font = new Font("Microsoft Sans Serif", 10F);
            labelDireccion.ForeColor = Color.Gainsboro;
            labelDireccion.Location = new Point(188, 400);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(69, 25);
            labelDireccion.TabIndex = 66;
            labelDireccion.Text = "Serie: ";
            // 
            // labelNit
            // 
            labelNit.AutoSize = true;
            labelNit.BackColor = Color.FromArgb(32, 30, 45);
            labelNit.FlatStyle = FlatStyle.Flat;
            labelNit.Font = new Font("Microsoft Sans Serif", 10F);
            labelNit.ForeColor = Color.Gainsboro;
            labelNit.Location = new Point(130, 461);
            labelNit.Name = "labelNit";
            labelNit.Size = new Size(69, 25);
            labelNit.TabIndex = 67;
            labelNit.Text = "Serie: ";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.BackColor = Color.FromArgb(32, 30, 45);
            labelFecha.FlatStyle = FlatStyle.Flat;
            labelFecha.Font = new Font("Microsoft Sans Serif", 10F);
            labelFecha.ForeColor = Color.Gainsboro;
            labelFecha.Location = new Point(439, 202);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(69, 25);
            labelFecha.TabIndex = 68;
            labelFecha.Text = "Serie: ";
            // 
            // labelSinDescuento
            // 
            labelSinDescuento.AutoSize = true;
            labelSinDescuento.BackColor = Color.FromArgb(32, 30, 45);
            labelSinDescuento.FlatStyle = FlatStyle.Flat;
            labelSinDescuento.Font = new Font("Microsoft Sans Serif", 10F);
            labelSinDescuento.ForeColor = Color.Gainsboro;
            labelSinDescuento.Location = new Point(554, 266);
            labelSinDescuento.Name = "labelSinDescuento";
            labelSinDescuento.Size = new Size(69, 25);
            labelSinDescuento.TabIndex = 69;
            labelSinDescuento.Text = "Serie: ";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.BackColor = Color.FromArgb(32, 30, 45);
            labelUsuario.FlatStyle = FlatStyle.Flat;
            labelUsuario.Font = new Font("Microsoft Sans Serif", 10F);
            labelUsuario.ForeColor = Color.Gainsboro;
            labelUsuario.Location = new Point(451, 461);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(69, 25);
            labelUsuario.TabIndex = 70;
            labelUsuario.Text = "Serie: ";
            // 
            // Reporte3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1156, 878);
            Controls.Add(labelUsuario);
            Controls.Add(labelSinDescuento);
            Controls.Add(labelFecha);
            Controls.Add(labelNit);
            Controls.Add(labelDireccion);
            Controls.Add(labelCliente);
            Controls.Add(labelTotal);
            Controls.Add(labelSerie);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(comboBoxIdFactura);
            Controls.Add(dataGridViewDetalleFactura);
            Controls.Add(dataGridViewMetodosPago);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Name = "Reporte3";
            Text = "Reporte3";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMetodosPago).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalleFactura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private DateTimePicker dateTimePickerFechaF;
        private DateTimePicker dateTimePickerFechaI;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private DataGridView dataGridViewMetodosPago;
        private DataGridView dataGridViewDetalleFactura;
        private ComboBox comboBoxIdFactura;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label labelSerie;
        private Label labelTotal;
        private Label labelCliente;
        private Label labelDireccion;
        private Label labelNit;
        private Label labelFecha;
        private Label labelSinDescuento;
        private Label labelUsuario;
    }
}