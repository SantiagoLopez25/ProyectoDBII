namespace UI
{
    partial class Reporte5
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
            btnListarVentas = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btnListarVentas
            // 
            btnListarVentas.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            btnListarVentas.IconColor = Color.Black;
            btnListarVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnListarVentas.IconSize = 30;
            btnListarVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnListarVentas.Location = new Point(27, 132);
            btnListarVentas.Name = "btnListarVentas";
            btnListarVentas.Size = new Size(174, 41);
            btnListarVentas.TabIndex = 47;
            btnListarVentas.Text = "LISTAR";
            btnListarVentas.TextAlign = ContentAlignment.MiddleRight;
            btnListarVentas.UseVisualStyleBackColor = true;
            btnListarVentas.Click += btnListarVentas_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(32, 30, 45);
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(27, 52);
            label3.Name = "label3";
            label3.Size = new Size(440, 32);
            label3.TabIndex = 46;
            label3.Text = "Estado de los productos vendidos";
            label3.Click += label3_Click;
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
            dataGridView1.Location = new Point(27, 307);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(563, 331);
            dataGridView1.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(32, 30, 45);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft Sans Serif", 10F);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(27, 247);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 48;
            label2.Text = "Pendientes";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(619, 307);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(563, 331);
            dataGridView2.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(32, 30, 45);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 10F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(619, 247);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 50;
            label1.Text = "Entregados";
            // 
            // Reporte5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1194, 685);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(label2);
            Controls.Add(btnListarVentas);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Name = "Reporte5";
            Text = "Reporte5";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnListarVentas;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label2;
        private DataGridView dataGridView2;
        private Label label1;
    }
}