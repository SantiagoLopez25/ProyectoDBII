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
            label2 = new Label();
            txtEditar = new TextBox();
            dataGridView1 = new DataGridView();
            lblId = new Label();
            lblEstado = new Label();
            btnEliminarMarca = new Button();
            btnEditarMarca = new Button();
            btnCrearMarca = new Button();
            panelCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Microsoft Sans Serif", 9F);
            txtMarca.Location = new Point(164, 32);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(214, 24);
            txtMarca.TabIndex = 0;
            txtMarca.Click += txtMarca_Click;
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
            label1.Size = new Size(54, 18);
            label1.TabIndex = 1;
            label1.Text = "Marca:";
            // 
            // panelCreate
            // 
            panelCreate.BackColor = Color.FromArgb(32, 30, 45);
            panelCreate.Controls.Add(label2);
            panelCreate.Controls.Add(txtEditar);
            panelCreate.Controls.Add(dataGridView1);
            panelCreate.Controls.Add(lblId);
            panelCreate.Controls.Add(lblEstado);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtMarca;
        private Label label1;
        private Panel panelCreate;
        private Button btnCrearMarca;
        private Button btnEditarMarca;
        private Button btnEliminarMarca;
        private Label lblId;
        private Label lblEstado;
        private Label label2;
        private TextBox txtEditar;
        private DataGridView dataGridView1;
    }
}