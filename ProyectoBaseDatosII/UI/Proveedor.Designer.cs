namespace UI
{
    partial class Proveedor
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
            txtProveedor = new TextBox();
            label1 = new Label();
            panelCreate = new Panel();
            groupCrear = new GroupBox();
            txtDireccion = new TextBox();
            label6 = new Label();
            label2 = new Label();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtTelExtra = new TextBox();
            dataGridViewProveedores = new DataGridView();
            lblId = new Label();
            lblEstado = new Label();
            btnEliminarProveedor = new Button();
            btnEditarProveedor = new Button();
            btnCrearProveedor = new Button();
            groupEditar = new GroupBox();
            txtProveedorEditar = new TextBox();
            label8 = new Label();
            txtDireccionEditar = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtCorreoEditar = new TextBox();
            txtTelefonoEditar = new TextBox();
            label11 = new Label();
            label12 = new Label();
            txtTelExtraEditar = new TextBox();
            panelCreate.SuspendLayout();
            groupCrear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).BeginInit();
            groupEditar.SuspendLayout();
            SuspendLayout();
            // 
            // txtProveedor
            // 
            txtProveedor.Font = new Font("Microsoft Sans Serif", 9F);
            txtProveedor.Location = new Point(94, 50);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(214, 24);
            txtProveedor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(32, 30, 45);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 9F);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(7, 53);
            label1.Name = "label1";
            label1.Size = new Size(81, 18);
            label1.TabIndex = 1;
            label1.Text = "Proveedor:";
            // 
            // panelCreate
            // 
            panelCreate.BackColor = Color.FromArgb(32, 30, 45);
            panelCreate.Controls.Add(groupCrear);
            panelCreate.Controls.Add(dataGridViewProveedores);
            panelCreate.Controls.Add(lblId);
            panelCreate.Controls.Add(lblEstado);
            panelCreate.Controls.Add(btnEliminarProveedor);
            panelCreate.Controls.Add(btnEditarProveedor);
            panelCreate.Controls.Add(btnCrearProveedor);
            panelCreate.Controls.Add(groupEditar);
            panelCreate.Dock = DockStyle.Fill;
            panelCreate.Location = new Point(0, 0);
            panelCreate.Margin = new Padding(0);
            panelCreate.Name = "panelCreate";
            panelCreate.Size = new Size(920, 463);
            panelCreate.TabIndex = 2;
            // 
            // groupCrear
            // 
            groupCrear.Controls.Add(txtProveedor);
            groupCrear.Controls.Add(label1);
            groupCrear.Controls.Add(txtDireccion);
            groupCrear.Controls.Add(label6);
            groupCrear.Controls.Add(label2);
            groupCrear.Controls.Add(txtCorreo);
            groupCrear.Controls.Add(txtTelefono);
            groupCrear.Controls.Add(label3);
            groupCrear.Controls.Add(label4);
            groupCrear.Controls.Add(txtTelExtra);
            groupCrear.Location = new Point(15, 3);
            groupCrear.Margin = new Padding(0);
            groupCrear.Name = "groupCrear";
            groupCrear.Size = new Size(314, 263);
            groupCrear.TabIndex = 18;
            groupCrear.TabStop = false;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Microsoft Sans Serif", 9F);
            txtDireccion.Location = new Point(94, 90);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(214, 24);
            txtDireccion.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(32, 30, 45);
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Microsoft Sans Serif", 9F);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(7, 216);
            label6.Name = "label6";
            label6.Size = new Size(59, 18);
            label6.TabIndex = 15;
            label6.Text = "Correo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(32, 30, 45);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(7, 93);
            label2.Name = "label2";
            label2.Size = new Size(75, 18);
            label2.TabIndex = 9;
            label2.Text = "Dirección:";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Microsoft Sans Serif", 9F);
            txtCorreo.Location = new Point(94, 213);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(214, 24);
            txtCorreo.TabIndex = 14;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Microsoft Sans Serif", 9F);
            txtTelefono.Location = new Point(94, 130);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(214, 24);
            txtTelefono.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(32, 30, 45);
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(7, 174);
            label3.Name = "label3";
            label3.Size = new Size(74, 18);
            label3.TabIndex = 13;
            label3.Text = "Tel. Extra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(32, 30, 45);
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Microsoft Sans Serif", 9F);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(7, 133);
            label4.Name = "label4";
            label4.Size = new Size(70, 18);
            label4.TabIndex = 11;
            label4.Text = "Telefono:";
            // 
            // txtTelExtra
            // 
            txtTelExtra.Font = new Font("Microsoft Sans Serif", 9F);
            txtTelExtra.Location = new Point(94, 171);
            txtTelExtra.Name = "txtTelExtra";
            txtTelExtra.Size = new Size(214, 24);
            txtTelExtra.TabIndex = 12;
            // 
            // dataGridViewProveedores
            // 
            dataGridViewProveedores.AllowUserToAddRows = false;
            dataGridViewProveedores.AllowUserToDeleteRows = false;
            dataGridViewProveedores.BorderStyle = BorderStyle.None;
            dataGridViewProveedores.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewProveedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewProveedores.ColumnHeadersHeight = 29;
            dataGridViewProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewProveedores.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProveedores.EnableHeadersVisualStyles = false;
            dataGridViewProveedores.Location = new Point(344, 106);
            dataGridViewProveedores.Margin = new Padding(12, 10, 12, 10);
            dataGridViewProveedores.Name = "dataGridViewProveedores";
            dataGridViewProveedores.ReadOnly = true;
            dataGridViewProveedores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewProveedores.RowHeadersWidth = 51;
            dataGridViewProveedores.Size = new Size(555, 291);
            dataGridViewProveedores.TabIndex = 3;
            dataGridViewProveedores.SelectionChanged += dataGridViewProveedores_SelectionChanged;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(788, 76);
            lblId.Name = "lblId";
            lblId.Size = new Size(53, 20);
            lblId.TabIndex = 6;
            lblId.Text = "label2";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(742, 76);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(18, 20);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "1";
            // 
            // btnEliminarProveedor
            // 
            btnEliminarProveedor.BackColor = Color.FromArgb(32, 30, 45);
            btnEliminarProveedor.FlatStyle = FlatStyle.Flat;
            btnEliminarProveedor.ForeColor = Color.Gainsboro;
            btnEliminarProveedor.Location = new Point(742, 34);
            btnEliminarProveedor.Name = "btnEliminarProveedor";
            btnEliminarProveedor.Size = new Size(118, 29);
            btnEliminarProveedor.TabIndex = 4;
            btnEliminarProveedor.Text = "Eliminar";
            btnEliminarProveedor.UseVisualStyleBackColor = false;
            btnEliminarProveedor.Click += btnEliminarProveedor_Click;
            // 
            // btnEditarProveedor
            // 
            btnEditarProveedor.BackColor = Color.FromArgb(32, 30, 45);
            btnEditarProveedor.FlatStyle = FlatStyle.Flat;
            btnEditarProveedor.ForeColor = Color.Gainsboro;
            btnEditarProveedor.Location = new Point(577, 34);
            btnEditarProveedor.Name = "btnEditarProveedor";
            btnEditarProveedor.Size = new Size(118, 29);
            btnEditarProveedor.TabIndex = 2;
            btnEditarProveedor.Text = "Editar";
            btnEditarProveedor.UseVisualStyleBackColor = false;
            btnEditarProveedor.Click += btnEditarProveedor_Click;
            // 
            // btnCrearProveedor
            // 
            btnCrearProveedor.BackColor = Color.FromArgb(32, 30, 45);
            btnCrearProveedor.FlatStyle = FlatStyle.Flat;
            btnCrearProveedor.ForeColor = Color.Gainsboro;
            btnCrearProveedor.Location = new Point(418, 34);
            btnCrearProveedor.Name = "btnCrearProveedor";
            btnCrearProveedor.Size = new Size(118, 29);
            btnCrearProveedor.TabIndex = 2;
            btnCrearProveedor.Text = "Crear";
            btnCrearProveedor.UseVisualStyleBackColor = false;
            btnCrearProveedor.Click += btnCrearProveedor_Click;
            // 
            // groupEditar
            // 
            groupEditar.Controls.Add(txtProveedorEditar);
            groupEditar.Controls.Add(label8);
            groupEditar.Controls.Add(txtDireccionEditar);
            groupEditar.Controls.Add(label9);
            groupEditar.Controls.Add(label10);
            groupEditar.Controls.Add(txtCorreoEditar);
            groupEditar.Controls.Add(txtTelefonoEditar);
            groupEditar.Controls.Add(label11);
            groupEditar.Controls.Add(label12);
            groupEditar.Controls.Add(txtTelExtraEditar);
            groupEditar.Location = new Point(14, 3);
            groupEditar.Margin = new Padding(0);
            groupEditar.Name = "groupEditar";
            groupEditar.Size = new Size(314, 263);
            groupEditar.TabIndex = 19;
            groupEditar.TabStop = false;
            // 
            // txtProveedorEditar
            // 
            txtProveedorEditar.Font = new Font("Microsoft Sans Serif", 9F);
            txtProveedorEditar.Location = new Point(94, 50);
            txtProveedorEditar.Name = "txtProveedorEditar";
            txtProveedorEditar.Size = new Size(214, 24);
            txtProveedorEditar.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(32, 30, 45);
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Microsoft Sans Serif", 9F);
            label8.ForeColor = Color.Gainsboro;
            label8.Location = new Point(7, 53);
            label8.Name = "label8";
            label8.Size = new Size(81, 18);
            label8.TabIndex = 1;
            label8.Text = "Proveedor:";
            // 
            // txtDireccionEditar
            // 
            txtDireccionEditar.Font = new Font("Microsoft Sans Serif", 9F);
            txtDireccionEditar.Location = new Point(94, 90);
            txtDireccionEditar.Name = "txtDireccionEditar";
            txtDireccionEditar.Size = new Size(214, 24);
            txtDireccionEditar.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(32, 30, 45);
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Microsoft Sans Serif", 9F);
            label9.ForeColor = Color.Gainsboro;
            label9.Location = new Point(7, 216);
            label9.Name = "label9";
            label9.Size = new Size(59, 18);
            label9.TabIndex = 15;
            label9.Text = "Correo:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(32, 30, 45);
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Microsoft Sans Serif", 9F);
            label10.ForeColor = Color.Gainsboro;
            label10.Location = new Point(7, 93);
            label10.Name = "label10";
            label10.Size = new Size(75, 18);
            label10.TabIndex = 9;
            label10.Text = "Dirección:";
            // 
            // txtCorreoEditar
            // 
            txtCorreoEditar.Font = new Font("Microsoft Sans Serif", 9F);
            txtCorreoEditar.Location = new Point(94, 213);
            txtCorreoEditar.Name = "txtCorreoEditar";
            txtCorreoEditar.Size = new Size(214, 24);
            txtCorreoEditar.TabIndex = 14;
            // 
            // txtTelefonoEditar
            // 
            txtTelefonoEditar.Font = new Font("Microsoft Sans Serif", 9F);
            txtTelefonoEditar.Location = new Point(94, 130);
            txtTelefonoEditar.Name = "txtTelefonoEditar";
            txtTelefonoEditar.Size = new Size(214, 24);
            txtTelefonoEditar.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(32, 30, 45);
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Microsoft Sans Serif", 9F);
            label11.ForeColor = Color.Gainsboro;
            label11.Location = new Point(7, 174);
            label11.Name = "label11";
            label11.Size = new Size(74, 18);
            label11.TabIndex = 13;
            label11.Text = "Tel. Extra:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(32, 30, 45);
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Microsoft Sans Serif", 9F);
            label12.ForeColor = Color.Gainsboro;
            label12.Location = new Point(7, 133);
            label12.Name = "label12";
            label12.Size = new Size(70, 18);
            label12.TabIndex = 11;
            label12.Text = "Telefono:";
            // 
            // txtTelExtraEditar
            // 
            txtTelExtraEditar.Font = new Font("Microsoft Sans Serif", 9F);
            txtTelExtraEditar.Location = new Point(94, 171);
            txtTelExtraEditar.Name = "txtTelExtraEditar";
            txtTelExtraEditar.Size = new Size(214, 24);
            txtTelExtraEditar.TabIndex = 12;
            // 
            // Proveedor
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 463);
            Controls.Add(panelCreate);
            Font = new Font("Microsoft Sans Serif", 10F);
            Name = "Proveedor";
            Text = "Proveedor";
            Load += Proveedor_Load;
            panelCreate.ResumeLayout(false);
            panelCreate.PerformLayout();
            groupCrear.ResumeLayout(false);
            groupCrear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).EndInit();
            groupEditar.ResumeLayout(false);
            groupEditar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtProveedor;
        private Label label1;
        private Panel panelCreate;
        private Button btnCrearProveedor;
        private Button btnEditarProveedor;
        private Button btnEliminarProveedor;
        private Label lblId;
        private Label lblEstado;
        private Label label2;
        private TextBox txtDireccion;
        private DataGridView dataGridViewProveedores;
        private Label label6;
        private TextBox txtCorreo;
        private Label label3;
        private TextBox txtTelExtra;
        private Label label4;
        private TextBox txtTelefono;
        private GroupBox groupCrear;
        private GroupBox groupEditar;
        private TextBox txtProveedorEditar;
        private Label label8;
        private TextBox txtDireccionEditar;
        private Label label9;
        private Label label10;
        private TextBox txtCorreoEditar;
        private TextBox txtTelefonoEditar;
        private Label label11;
        private Label label12;
        private TextBox txtTelExtraEditar;
    }
}