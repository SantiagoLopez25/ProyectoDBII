namespace UI
{
    partial class Reporte4
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
            dataGridView1 = new DataGridView();
            btnListarVentas = new FontAwesome.Sharp.IconButton();
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
            label3.Location = new Point(64, 22);
            label3.Name = "label3";
            label3.Size = new Size(645, 32);
            label3.TabIndex = 43;
            label3.Text = "Productos que su existencia es menor a la mínima";
            label3.Click += label3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1277, 331);
            dataGridView1.TabIndex = 40;
            // 
            // btnListarVentas
            // 
            btnListarVentas.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            btnListarVentas.IconColor = Color.Black;
            btnListarVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnListarVentas.IconSize = 30;
            btnListarVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnListarVentas.Location = new Point(64, 104);
            btnListarVentas.Name = "btnListarVentas";
            btnListarVentas.Size = new Size(138, 41);
            btnListarVentas.TabIndex = 44;
            btnListarVentas.Text = "LISTAR";
            btnListarVentas.TextAlign = ContentAlignment.MiddleRight;
            btnListarVentas.UseVisualStyleBackColor = true;
            btnListarVentas.Click += btnListarVentas_Click;
            // 
            // Reporte4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1338, 607);
            Controls.Add(btnListarVentas);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Name = "Reporte4";
            Text = "Reporte4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btnListarVentas;
    }
}