namespace UI
{
    partial class Reporte1
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
            btnBuscar = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dateTimePickerFechaI = new DateTimePicker();
            dateTimePickerFechaF = new DateTimePicker();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 30;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(657, 113);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(201, 49);
            btnBuscar.TabIndex = 28;
            btnBuscar.Text = "Generar Reporte";
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(32, 30, 45);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(56, 93);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 30;
            label2.Text = "Fecha Inicio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(32, 30, 45);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 10F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(56, 160);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 32;
            label1.Text = "Fecha Final";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(56, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(492, 331);
            dataGridView1.TabIndex = 33;
            // 
            // dateTimePickerFechaI
            // 
            dateTimePickerFechaI.Location = new Point(196, 93);
            dateTimePickerFechaI.Name = "dateTimePickerFechaI";
            dateTimePickerFechaI.Size = new Size(352, 31);
            dateTimePickerFechaI.TabIndex = 34;
            // 
            // dateTimePickerFechaF
            // 
            dateTimePickerFechaF.Location = new Point(196, 160);
            dateTimePickerFechaF.Name = "dateTimePickerFechaF";
            dateTimePickerFechaF.Size = new Size(352, 31);
            dateTimePickerFechaF.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(32, 30, 45);
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(56, 27);
            label3.Name = "label3";
            label3.Size = new Size(547, 32);
            label3.TabIndex = 36;
            label3.Text = "Métodos de pago que más dinero generan";
            // 
            // Reporte1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(902, 597);
            Controls.Add(label3);
            Controls.Add(dateTimePickerFechaF);
            Controls.Add(dateTimePickerFechaI);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Name = "Reporte1";
            Text = "Reporte1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBuscar;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePickerFechaI;
        private DateTimePicker dateTimePickerFechaF;
        private Label label3;
    }
}