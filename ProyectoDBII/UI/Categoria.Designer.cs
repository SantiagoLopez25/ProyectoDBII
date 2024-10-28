namespace UI
{
    partial class Categoria
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
            txtCategoria = new TextBox();
            label1 = new Label();
            panelCreate = new Panel();
            label2 = new Label();
            txtEditar = new TextBox();
            dataGridView1 = new DataGridView();
            lblId = new Label();
            lblEstado = new Label();
            btnEliminarCategoria = new Button();
            btnEditarCategoria = new Button();
            btnCrearCategoria = new Button();
            panelCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtCategoria
            // 
            txtCategoria.Font = new Font("Microsoft Sans Serif", 9F);
            txtCategoria.Location = new Point(164, 32);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(214, 24);
            txtCategoria.TabIndex = 0;
            txtCategoria.TextChanged += txtCategoria_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(32, 30, 45);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 9F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(86, 35);
            label1.Name = "label1";
            label1.Size = new Size(76, 18);
            label1.TabIndex = 1;
            label1.Text = "Categoria:";
            // 
            // panelCreate
            // 
            panelCreate.BackColor = Color.FromArgb(32, 30, 45);
            panelCreate.Controls.Add(label2);
            panelCreate.Controls.Add(txtEditar);
            panelCreate.Controls.Add(dataGridView1);
            panelCreate.Controls.Add(lblId);
            panelCreate.Controls.Add(lblEstado);
            panelCreate.Controls.Add(btnEliminarCategoria);
            panelCreate.Controls.Add(btnEditarCategoria);
            panelCreate.Controls.Add(btnCrearCategoria);
            panelCreate.Controls.Add(label1);
            panelCreate.Controls.Add(txtCategoria);
            panelCreate.Dock = DockStyle.Fill;
            panelCreate.Location = new Point(0, 0);
            panelCreate.Margin = new Padding(0);
            panelCreate.Name = "panelCreate";
            panelCreate.Size = new Size(920, 463);
            panelCreate.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(32, 30, 45);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(90, 88);
            label2.Name = "label2";
            label2.Size = new Size(50, 18);
            label2.TabIndex = 9;
            label2.Text = "Editar:";
            // 
            // txtEditar
            // 
            txtEditar.Font = new Font("Microsoft Sans Serif", 9F);
            txtEditar.Location = new Point(164, 85);
            txtEditar.Name = "txtEditar";
            txtEditar.Size = new Size(214, 24);
            txtEditar.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(164, 137);
            dataGridView1.Margin = new Padding(12, 10, 12, 10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(532, 287);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(817, 127);
            lblId.Name = "lblId";
            lblId.Size = new Size(53, 20);
            lblId.TabIndex = 6;
            lblId.Text = "label2";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(817, 85);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(18, 20);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "1";
            // 
            // btnEliminarCategoria
            // 
            btnEliminarCategoria.BackColor = Color.FromArgb(32, 30, 45);
            btnEliminarCategoria.FlatStyle = FlatStyle.Flat;
            btnEliminarCategoria.ForeColor = Color.Gainsboro;
            btnEliminarCategoria.Location = new Point(762, 32);
            btnEliminarCategoria.Name = "btnEliminarCategoria";
            btnEliminarCategoria.Size = new Size(118, 29);
            btnEliminarCategoria.TabIndex = 4;
            btnEliminarCategoria.Text = "Eliminar";
            btnEliminarCategoria.UseVisualStyleBackColor = false;
            btnEliminarCategoria.Click += btnEliminarCategoria_Click;
            // 
            // btnEditarCategoria
            // 
            btnEditarCategoria.BackColor = Color.FromArgb(32, 30, 45);
            btnEditarCategoria.FlatStyle = FlatStyle.Flat;
            btnEditarCategoria.ForeColor = Color.Gainsboro;
            btnEditarCategoria.Location = new Point(611, 31);
            btnEditarCategoria.Name = "btnEditarCategoria";
            btnEditarCategoria.Size = new Size(118, 29);
            btnEditarCategoria.TabIndex = 2;
            btnEditarCategoria.Text = "Editar";
            btnEditarCategoria.UseVisualStyleBackColor = false;
            btnEditarCategoria.Click += btnEditarCategoria_Click;
            // 
            // btnCrearCategoria
            // 
            btnCrearCategoria.BackColor = Color.FromArgb(32, 30, 45);
            btnCrearCategoria.FlatStyle = FlatStyle.Flat;
            btnCrearCategoria.ForeColor = Color.Gainsboro;
            btnCrearCategoria.Location = new Point(462, 31);
            btnCrearCategoria.Name = "btnCrearCategoria";
            btnCrearCategoria.Size = new Size(118, 29);
            btnCrearCategoria.TabIndex = 2;
            btnCrearCategoria.Text = "Crear";
            btnCrearCategoria.UseVisualStyleBackColor = false;
            btnCrearCategoria.Click += btnCrearCategoria_Click;
            // 
            // Categoria
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 463);
            Controls.Add(panelCreate);
            Font = new Font("Microsoft Sans Serif", 10F);
            Name = "Categoria";
            Text = "Categoria";
            Load += Categoria_Load;
            panelCreate.ResumeLayout(false);
            panelCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtCategoria;
        private Label label1;
        private Panel panelCreate;
        private Button btnCrearCategoria;
        private Button btnEditarCategoria;
        private Button btnEliminarCategoria;
        private Label lblId;
        private Label lblEstado;
        private Label label2;
        private TextBox txtEditar;
        private DataGridView dataGridView1;
    }
}