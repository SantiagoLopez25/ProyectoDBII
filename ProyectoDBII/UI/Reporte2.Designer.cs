namespace UI
{
    partial class Reporte2
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
            label3 = new Label();
            dateTimePickerFechaF = new DateTimePicker();
            dateTimePickerFechaI = new DateTimePicker();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(32, 30, 45);
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(11, -42);
            label3.Name = "label3";
            label3.Size = new Size(547, 32);
            label3.TabIndex = 43;
            label3.Text = "Métodos de pago que más dinero generan";
            // 
            // dateTimePickerFechaF
            // 
            dateTimePickerFechaF.Location = new Point(208, 167);
            dateTimePickerFechaF.Name = "dateTimePickerFechaF";
            dateTimePickerFechaF.Size = new Size(352, 31);
            dateTimePickerFechaF.TabIndex = 42;
            // 
            // dateTimePickerFechaI
            // 
            dateTimePickerFechaI.Location = new Point(208, 100);
            dateTimePickerFechaI.Name = "dateTimePickerFechaI";
            dateTimePickerFechaI.Size = new Size(352, 31);
            dateTimePickerFechaI.TabIndex = 41;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(68, 237);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(522, 331);
            dataGridView1.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(32, 30, 45);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 10F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(68, 167);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 39;
            label1.Text = "Fecha Final";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(32, 30, 45);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(68, 100);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 38;
            label2.Text = "Fecha Inicio";
            // 
            // btnBuscar
            // 
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 30;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(654, 121);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(199, 49);
            btnBuscar.TabIndex = 37;
            btnBuscar.Text = "Generar Reporte";
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(32, 30, 45);
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(68, 33);
            label4.Name = "label4";
            label4.Size = new Size(484, 32);
            label4.TabIndex = 44;
            label4.Text = "Productos que más ingresos generan";
            // 
            // Reporte2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(880, 653);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePickerFechaF);
            Controls.Add(dateTimePickerFechaI);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Name = "Reporte2";
            Text = "Reporte2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private DateTimePicker dateTimePickerFechaF;
        private DateTimePicker dateTimePickerFechaI;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private Label label4;
    }
}