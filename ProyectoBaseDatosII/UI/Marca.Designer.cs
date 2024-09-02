namespace UI
{
    partial class Marca
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
            txtMarca = new TextBox();
            label1 = new Label();
            panelCreate = new Panel();
            btnEliminarMarca = new Button();
            panelEditar = new Panel();
            dataGridView1 = new DataGridView();
            btnEditarMarca = new Button();
            btnCrearMarca = new Button();
            btnGuardar = new Button();
            panelEliminar = new Panel();
            dataGridView2 = new DataGridView();
            btnGuardarEditado = new Button();
            panelCreate.SuspendLayout();
            panelEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Microsoft Sans Serif", 9F);
            txtMarca.Location = new Point(164, 32);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(214, 24);
            txtMarca.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(32, 30, 45);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 9F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(70, 35);
            label1.Name = "label1";
            label1.Size = new Size(50, 18);
            label1.TabIndex = 1;
            label1.Text = "Marca";
            // 
            // panelCreate
            // 
            panelCreate.BackColor = Color.FromArgb(32, 30, 45);
            panelCreate.Controls.Add(panelEditar);
            panelCreate.Controls.Add(panelEliminar);
            panelCreate.Controls.Add(btnEliminarMarca);
            panelCreate.Controls.Add(btnEditarMarca);
            panelCreate.Controls.Add(btnCrearMarca);
            panelCreate.Controls.Add(label1);
            panelCreate.Controls.Add(txtMarca);
            panelCreate.Dock = DockStyle.Fill;
            panelCreate.Location = new Point(0, 0);
            panelCreate.Margin = new Padding(0);
            panelCreate.Name = "panelCreate";
            panelCreate.Size = new Size(920, 463);
            panelCreate.TabIndex = 2;
            // 
            // btnEliminarMarca
            // 
            btnEliminarMarca.BackColor = Color.FromArgb(32, 30, 45);
            btnEliminarMarca.FlatStyle = FlatStyle.Flat;
            btnEliminarMarca.ForeColor = Color.Gainsboro;
            btnEliminarMarca.Location = new Point(762, 32);
            btnEliminarMarca.Name = "btnEliminarMarca";
            btnEliminarMarca.Size = new Size(118, 29);
            btnEliminarMarca.TabIndex = 4;
            btnEliminarMarca.Text = "Eliminar";
            btnEliminarMarca.UseVisualStyleBackColor = false;
            btnEliminarMarca.Click += btnEliminarMarca_Click;
            // 
            // panelEditar
            // 
            panelEditar.Controls.Add(btnGuardarEditado);
            panelEditar.Controls.Add(dataGridView1);
            panelEditar.Location = new Point(59, 108);
            panelEditar.Margin = new Padding(0);
            panelEditar.Name = "panelEditar";
            panelEditar.Size = new Size(474, 307);
            panelEditar.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 10);
            dataGridView1.Margin = new Padding(12, 10, 12, 10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(262, 287);
            dataGridView1.TabIndex = 3;
            // 
            // btnEditarMarca
            // 
            btnEditarMarca.BackColor = Color.FromArgb(32, 30, 45);
            btnEditarMarca.FlatStyle = FlatStyle.Flat;
            btnEditarMarca.ForeColor = Color.Gainsboro;
            btnEditarMarca.Location = new Point(611, 31);
            btnEditarMarca.Name = "btnEditarMarca";
            btnEditarMarca.Size = new Size(118, 29);
            btnEditarMarca.TabIndex = 2;
            btnEditarMarca.Text = "Editar";
            btnEditarMarca.UseVisualStyleBackColor = false;
            btnEditarMarca.Click += btnEditarMarca_Click;
            // 
            // btnCrearMarca
            // 
            btnCrearMarca.BackColor = Color.FromArgb(32, 30, 45);
            btnCrearMarca.FlatStyle = FlatStyle.Flat;
            btnCrearMarca.ForeColor = Color.Gainsboro;
            btnCrearMarca.Location = new Point(462, 31);
            btnCrearMarca.Name = "btnCrearMarca";
            btnCrearMarca.Size = new Size(118, 29);
            btnCrearMarca.TabIndex = 2;
            btnCrearMarca.Text = "Crear";
            btnCrearMarca.UseVisualStyleBackColor = false;
            btnCrearMarca.Click += btnCrearMarca_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(32, 30, 45);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.Gainsboro;
            btnGuardar.Location = new Point(289, 116);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(118, 29);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // panelEliminar
            // 
            panelEliminar.Controls.Add(dataGridView2);
            panelEliminar.Controls.Add(btnGuardar);
            panelEliminar.Location = new Point(70, 108);
            panelEliminar.Margin = new Padding(0);
            panelEliminar.Name = "panelEliminar";
            panelEliminar.Size = new Size(474, 307);
            panelEliminar.TabIndex = 4;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 10);
            dataGridView2.Margin = new Padding(12, 10, 12, 10);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(262, 287);
            dataGridView2.TabIndex = 3;
            // 
            // btnGuardarEditado
            // 
            btnGuardarEditado.BackColor = Color.FromArgb(32, 30, 45);
            btnGuardarEditado.FlatStyle = FlatStyle.Flat;
            btnGuardarEditado.ForeColor = Color.Gainsboro;
            btnGuardarEditado.Location = new Point(315, 135);
            btnGuardarEditado.Name = "btnGuardarEditado";
            btnGuardarEditado.Size = new Size(118, 29);
            btnGuardarEditado.TabIndex = 5;
            btnGuardarEditado.Text = "Guardar";
            btnGuardarEditado.UseVisualStyleBackColor = false;
            // 
            // Marca
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 463);
            Controls.Add(panelCreate);
            Font = new Font("Microsoft Sans Serif", 10F);
            Name = "Marca";
            Text = "Marca";
            Load += Marca_Load;
            panelCreate.ResumeLayout(false);
            panelCreate.PerformLayout();
            panelEditar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelEliminar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtMarca;
        private Label label1;
        private Panel panelCreate;
        private Button btnCrearMarca;
        private Panel panelEditar;
        private DataGridView dataGridView1;
        private Button btnEditarMarca;
        private Button btnEliminarMarca;
        private Panel panelEliminar;
        private DataGridView dataGridView2;
        private Button btnGuardar;
        private Button btnGuardarEditado;
    }
}