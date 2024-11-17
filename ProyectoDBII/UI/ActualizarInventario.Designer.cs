namespace UI
{
    partial class ActualizarInventario
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
            dataGridViewCompras = new DataGridView();
            groupBoxActualizar = new GroupBox();
            txtBoxCantidadRecibida = new TextBox();
            label6 = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            btnListarCompras = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompras).BeginInit();
            groupBoxActualizar.SuspendLayout();
            SuspendLayout();
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
            dataGridViewCompras.Location = new Point(79, 133);
            dataGridViewCompras.Margin = new Padding(12, 10, 12, 10);
            dataGridViewCompras.Name = "dataGridViewCompras";
            dataGridViewCompras.ReadOnly = true;
            dataGridViewCompras.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCompras.RowHeadersWidth = 51;
            dataGridViewCompras.Size = new Size(1206, 513);
            dataGridViewCompras.TabIndex = 4;
            dataGridViewCompras.CellContentClick += dataGridViewCompras_CellContentClick;
            dataGridViewCompras.SelectionChanged += dataGridViewCompras_SelectionChanged;
            // 
            // groupBoxActualizar
            // 
            groupBoxActualizar.Controls.Add(txtBoxCantidadRecibida);
            groupBoxActualizar.Controls.Add(label6);
            groupBoxActualizar.Controls.Add(iconButton2);
            groupBoxActualizar.Location = new Point(468, 36);
            groupBoxActualizar.Name = "groupBoxActualizar";
            groupBoxActualizar.Size = new Size(399, 59);
            groupBoxActualizar.TabIndex = 29;
            groupBoxActualizar.TabStop = false;
            // 
            // txtBoxCantidadRecibida
            // 
            txtBoxCantidadRecibida.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxCantidadRecibida.Location = new Point(182, 17);
            txtBoxCantidadRecibida.Name = "txtBoxCantidadRecibida";
            txtBoxCantidadRecibida.Size = new Size(63, 32);
            txtBoxCantidadRecibida.TabIndex = 64;
            txtBoxCantidadRecibida.Text = "1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(32, 30, 45);
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Microsoft Sans Serif", 10F);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(6, 22);
            label6.Name = "label6";
            label6.Size = new Size(177, 25);
            label6.TabIndex = 63;
            label6.Text = "Cantidad Recibida:";
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Edit;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(273, 16);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(120, 33);
            iconButton2.TabIndex = 27;
            iconButton2.Text = "Actualizar";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // btnListarCompras
            // 
            btnListarCompras.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            btnListarCompras.IconColor = Color.Black;
            btnListarCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnListarCompras.IconSize = 30;
            btnListarCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnListarCompras.Location = new Point(959, 54);
            btnListarCompras.Name = "btnListarCompras";
            btnListarCompras.Size = new Size(126, 33);
            btnListarCompras.TabIndex = 30;
            btnListarCompras.Text = "LISTAR";
            btnListarCompras.TextAlign = ContentAlignment.MiddleRight;
            btnListarCompras.UseVisualStyleBackColor = true;
            btnListarCompras.Click += btnListarCompras_Click;
            // 
            // ActualizarInventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1377, 714);
            Controls.Add(btnListarCompras);
            Controls.Add(groupBoxActualizar);
            Controls.Add(dataGridViewCompras);
            Name = "ActualizarInventario";
            Text = "ActualizarInventario";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCompras).EndInit();
            groupBoxActualizar.ResumeLayout(false);
            groupBoxActualizar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCompras;
        private GroupBox groupBoxActualizar;
        private TextBox txtBoxCantidadRecibida;
        private Label label6;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnListarCompras;
    }
}