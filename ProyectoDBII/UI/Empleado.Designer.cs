namespace UI
{
    partial class Empleado
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
            txtEmpleado = new TextBox();
            label1 = new Label();
            panelCreate = new Panel();
            groupCrear = new GroupBox();
            label6 = new Label();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            label4 = new Label();
            dataGridViewEmpleadoes = new DataGridView();
            lblId = new Label();
            lblEstado = new Label();
            btnEliminarEmpleado = new Button();
            btnEditarEmpleado = new Button();
            btnCrearEmpleado = new Button();
            groupEditar = new GroupBox();
            txtEmpleadoEditar = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtCorreoEditar = new TextBox();
            txtTelefonoEditar = new TextBox();
            label12 = new Label();
            panelCreate.SuspendLayout();
            groupCrear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpleadoes).BeginInit();
            groupEditar.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmpleado
            // 
            txtEmpleado.Font = new Font("Microsoft Sans Serif", 9F);
            txtEmpleado.Location = new Point(94, 50);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(214, 24);
            txtEmpleado.TabIndex = 0;
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
            label1.Size = new Size(79, 18);
            label1.TabIndex = 1;
            label1.Text = "Empleado:";
            // 
            // panelCreate
            // 
            panelCreate.BackColor = Color.FromArgb(32, 30, 45);
            panelCreate.Controls.Add(dataGridViewEmpleadoes);
            panelCreate.Controls.Add(lblId);
            panelCreate.Controls.Add(lblEstado);
            panelCreate.Controls.Add(btnEliminarEmpleado);
            panelCreate.Controls.Add(btnEditarEmpleado);
            panelCreate.Controls.Add(btnCrearEmpleado);
            panelCreate.Controls.Add(groupEditar);
            panelCreate.Controls.Add(groupCrear);
            panelCreate.Dock = DockStyle.Fill;
            panelCreate.Location = new Point(0, 0);
            panelCreate.Margin = new Padding(0);
            panelCreate.Name = "panelCreate";
            panelCreate.Size = new Size(920, 463);
            panelCreate.TabIndex = 2;
            // 
            // groupCrear
            // 
            groupCrear.Controls.Add(txtEmpleado);
            groupCrear.Controls.Add(label1);
            groupCrear.Controls.Add(label6);
            groupCrear.Controls.Add(txtCorreo);
            groupCrear.Controls.Add(txtTelefono);
            groupCrear.Controls.Add(label4);
            groupCrear.Location = new Point(15, 3);
            groupCrear.Margin = new Padding(0);
            groupCrear.Name = "groupCrear";
            groupCrear.Size = new Size(314, 263);
            groupCrear.TabIndex = 18;
            groupCrear.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(32, 30, 45);
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Microsoft Sans Serif", 9F);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(6, 127);
            label6.Name = "label6";
            label6.Size = new Size(59, 18);
            label6.TabIndex = 15;
            label6.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Microsoft Sans Serif", 9F);
            txtCorreo.Location = new Point(93, 124);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(214, 24);
            txtCorreo.TabIndex = 14;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Microsoft Sans Serif", 9F);
            txtTelefono.Location = new Point(94, 87);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(214, 24);
            txtTelefono.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(32, 30, 45);
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Microsoft Sans Serif", 9F);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(7, 90);
            label4.Name = "label4";
            label4.Size = new Size(70, 18);
            label4.TabIndex = 11;
            label4.Text = "Telefono:";
            // 
            // dataGridViewEmpleadoes
            // 
            dataGridViewEmpleadoes.AllowUserToAddRows = false;
            dataGridViewEmpleadoes.AllowUserToDeleteRows = false;
            dataGridViewEmpleadoes.BorderStyle = BorderStyle.None;
            dataGridViewEmpleadoes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewEmpleadoes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewEmpleadoes.ColumnHeadersHeight = 29;
            dataGridViewEmpleadoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewEmpleadoes.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewEmpleadoes.EnableHeadersVisualStyles = false;
            dataGridViewEmpleadoes.Location = new Point(344, 106);
            dataGridViewEmpleadoes.Margin = new Padding(12, 10, 12, 10);
            dataGridViewEmpleadoes.Name = "dataGridViewEmpleadoes";
            dataGridViewEmpleadoes.ReadOnly = true;
            dataGridViewEmpleadoes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewEmpleadoes.RowHeadersWidth = 51;
            dataGridViewEmpleadoes.Size = new Size(555, 291);
            dataGridViewEmpleadoes.TabIndex = 3;
            dataGridViewEmpleadoes.SelectionChanged += dataGridViewEmpleadoes_SelectionChanged;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(807, 76);
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
            // btnEliminarEmpleado
            // 
            btnEliminarEmpleado.BackColor = Color.FromArgb(32, 30, 45);
            btnEliminarEmpleado.FlatStyle = FlatStyle.Flat;
            btnEliminarEmpleado.ForeColor = Color.Gainsboro;
            btnEliminarEmpleado.Location = new Point(742, 34);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(118, 29);
            btnEliminarEmpleado.TabIndex = 4;
            btnEliminarEmpleado.Text = "Eliminar";
            btnEliminarEmpleado.UseVisualStyleBackColor = false;
            btnEliminarEmpleado.Click += btnEliminarEmpleado_Click;
            // 
            // btnEditarEmpleado
            // 
            btnEditarEmpleado.BackColor = Color.FromArgb(32, 30, 45);
            btnEditarEmpleado.FlatStyle = FlatStyle.Flat;
            btnEditarEmpleado.ForeColor = Color.Gainsboro;
            btnEditarEmpleado.Location = new Point(577, 34);
            btnEditarEmpleado.Name = "btnEditarEmpleado";
            btnEditarEmpleado.Size = new Size(118, 29);
            btnEditarEmpleado.TabIndex = 2;
            btnEditarEmpleado.Text = "Editar";
            btnEditarEmpleado.UseVisualStyleBackColor = false;
            btnEditarEmpleado.Click += btnEditarEmpleado_Click;
            // 
            // btnCrearEmpleado
            // 
            btnCrearEmpleado.BackColor = Color.FromArgb(32, 30, 45);
            btnCrearEmpleado.FlatStyle = FlatStyle.Flat;
            btnCrearEmpleado.ForeColor = Color.Gainsboro;
            btnCrearEmpleado.Location = new Point(418, 34);
            btnCrearEmpleado.Name = "btnCrearEmpleado";
            btnCrearEmpleado.Size = new Size(118, 29);
            btnCrearEmpleado.TabIndex = 2;
            btnCrearEmpleado.Text = "Crear";
            btnCrearEmpleado.UseVisualStyleBackColor = false;
            btnCrearEmpleado.Click += btnCrearEmpleado_Click;
            // 
            // groupEditar
            // 
            groupEditar.Controls.Add(txtEmpleadoEditar);
            groupEditar.Controls.Add(label8);
            groupEditar.Controls.Add(label9);
            groupEditar.Controls.Add(txtCorreoEditar);
            groupEditar.Controls.Add(txtTelefonoEditar);
            groupEditar.Controls.Add(label12);
            groupEditar.Location = new Point(14, 3);
            groupEditar.Margin = new Padding(0);
            groupEditar.Name = "groupEditar";
            groupEditar.Size = new Size(314, 263);
            groupEditar.TabIndex = 19;
            groupEditar.TabStop = false;
            // 
            // txtEmpleadoEditar
            // 
            txtEmpleadoEditar.Font = new Font("Microsoft Sans Serif", 9F);
            txtEmpleadoEditar.Location = new Point(94, 50);
            txtEmpleadoEditar.Name = "txtEmpleadoEditar";
            txtEmpleadoEditar.Size = new Size(214, 24);
            txtEmpleadoEditar.TabIndex = 0;
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
            label8.Size = new Size(79, 18);
            label8.TabIndex = 1;
            label8.Text = "Empleado:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(32, 30, 45);
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Microsoft Sans Serif", 9F);
            label9.ForeColor = Color.Gainsboro;
            label9.Location = new Point(7, 128);
            label9.Name = "label9";
            label9.Size = new Size(59, 18);
            label9.TabIndex = 15;
            label9.Text = "Correo:";
            // 
            // txtCorreoEditar
            // 
            txtCorreoEditar.Font = new Font("Microsoft Sans Serif", 9F);
            txtCorreoEditar.Location = new Point(94, 125);
            txtCorreoEditar.Name = "txtCorreoEditar";
            txtCorreoEditar.Size = new Size(214, 24);
            txtCorreoEditar.TabIndex = 14;
            // 
            // txtTelefonoEditar
            // 
            txtTelefonoEditar.Font = new Font("Microsoft Sans Serif", 9F);
            txtTelefonoEditar.Location = new Point(95, 88);
            txtTelefonoEditar.Name = "txtTelefonoEditar";
            txtTelefonoEditar.Size = new Size(214, 24);
            txtTelefonoEditar.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(32, 30, 45);
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Microsoft Sans Serif", 9F);
            label12.ForeColor = Color.Gainsboro;
            label12.Location = new Point(8, 91);
            label12.Name = "label12";
            label12.Size = new Size(70, 18);
            label12.TabIndex = 11;
            label12.Text = "Telefono:";
            // 
            // Empleado
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 463);
            Controls.Add(panelCreate);
            Font = new Font("Microsoft Sans Serif", 10F);
            Name = "Empleado";
            Text = "Empleado";
            Load += Empleado_Load;
            panelCreate.ResumeLayout(false);
            panelCreate.PerformLayout();
            groupCrear.ResumeLayout(false);
            groupCrear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpleadoes).EndInit();
            groupEditar.ResumeLayout(false);
            groupEditar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtEmpleado;
        private Label label1;
        private Panel panelCreate;
        private Button btnCrearEmpleado;
        private Button btnEditarEmpleado;
        private Button btnEliminarEmpleado;
        private Label lblId;
        private Label lblEstado;
        private DataGridView dataGridViewEmpleadoes;
        private Label label6;
        private TextBox txtCorreo;
        private Label label4;
        private TextBox txtTelefono;
        private GroupBox groupCrear;
        private GroupBox groupEditar;
        private TextBox txtEmpleadoEditar;
        private Label label8;
        private Label label9;
        private TextBox txtCorreoEditar;
        private TextBox txtTelefonoEditar;
        private Label label12;
    }
}