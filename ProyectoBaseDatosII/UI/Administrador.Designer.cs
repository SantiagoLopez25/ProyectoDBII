namespace UI
{
    partial class Administrador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSideMenu = new Panel();
            panelMueblesSubMenu = new Panel();
            btnModelo = new Button();
            btnCategoría = new Button();
            btnMarca = new Button();
            btnMuebles = new Button();
            btnMueblesDesplegable = new Button();
            panelPedidosProveedorSubMenu = new Panel();
            btnEstadoPedido = new Button();
            btnProveedores = new Button();
            btnPedidosProveedor = new Button();
            button1 = new Button();
            panelVentasSubMenu = new Panel();
            btnFacturas = new Button();
            btnClientes = new Button();
            btnEntregas = new Button();
            btnVentas = new Button();
            btnVentasDesplegable = new Button();
            panelLogo = new Panel();
            panelPlayer = new Panel();
            panelChildForm = new Panel();
            panelSideMenu.SuspendLayout();
            panelMueblesSubMenu.SuspendLayout();
            panelPedidosProveedorSubMenu.SuspendLayout();
            panelVentasSubMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(11, 7, 17);
            panelSideMenu.Controls.Add(panelMueblesSubMenu);
            panelSideMenu.Controls.Add(btnMueblesDesplegable);
            panelSideMenu.Controls.Add(panelPedidosProveedorSubMenu);
            panelSideMenu.Controls.Add(button1);
            panelSideMenu.Controls.Add(panelVentasSubMenu);
            panelSideMenu.Controls.Add(btnVentasDesplegable);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(250, 592);
            panelSideMenu.TabIndex = 0;
            panelSideMenu.Paint += panelSideMenu_Paint;
            // 
            // panelMueblesSubMenu
            // 
            panelMueblesSubMenu.BackColor = Color.FromArgb(35, 32, 39);
            panelMueblesSubMenu.Controls.Add(btnModelo);
            panelMueblesSubMenu.Controls.Add(btnCategoría);
            panelMueblesSubMenu.Controls.Add(btnMarca);
            panelMueblesSubMenu.Controls.Add(btnMuebles);
            panelMueblesSubMenu.Dock = DockStyle.Top;
            panelMueblesSubMenu.Location = new Point(0, 555);
            panelMueblesSubMenu.Name = "panelMueblesSubMenu";
            panelMueblesSubMenu.Size = new Size(224, 171);
            panelMueblesSubMenu.TabIndex = 6;
            // 
            // btnModelo
            // 
            btnModelo.Dock = DockStyle.Top;
            btnModelo.FlatAppearance.BorderSize = 0;
            btnModelo.FlatStyle = FlatStyle.Flat;
            btnModelo.ForeColor = Color.LightGray;
            btnModelo.Location = new Point(0, 120);
            btnModelo.Name = "btnModelo";
            btnModelo.Padding = new Padding(35, 0, 0, 0);
            btnModelo.Size = new Size(224, 40);
            btnModelo.TabIndex = 3;
            btnModelo.Text = "Modelo";
            btnModelo.TextAlign = ContentAlignment.MiddleLeft;
            btnModelo.UseVisualStyleBackColor = true;
            btnModelo.Click += btnModelo_Click;
            // 
            // btnCategoría
            // 
            btnCategoría.Dock = DockStyle.Top;
            btnCategoría.FlatAppearance.BorderSize = 0;
            btnCategoría.FlatStyle = FlatStyle.Flat;
            btnCategoría.ForeColor = Color.LightGray;
            btnCategoría.Location = new Point(0, 80);
            btnCategoría.Name = "btnCategoría";
            btnCategoría.Padding = new Padding(35, 0, 0, 0);
            btnCategoría.Size = new Size(224, 40);
            btnCategoría.TabIndex = 2;
            btnCategoría.Text = "Categoría";
            btnCategoría.TextAlign = ContentAlignment.MiddleLeft;
            btnCategoría.UseVisualStyleBackColor = true;
            btnCategoría.Click += btnCategoría_Click;
            // 
            // btnMarca
            // 
            btnMarca.Dock = DockStyle.Top;
            btnMarca.FlatAppearance.BorderSize = 0;
            btnMarca.FlatStyle = FlatStyle.Flat;
            btnMarca.ForeColor = Color.LightGray;
            btnMarca.Location = new Point(0, 40);
            btnMarca.Name = "btnMarca";
            btnMarca.Padding = new Padding(35, 0, 0, 0);
            btnMarca.Size = new Size(224, 40);
            btnMarca.TabIndex = 1;
            btnMarca.Text = "Marcas";
            btnMarca.TextAlign = ContentAlignment.MiddleLeft;
            btnMarca.UseVisualStyleBackColor = true;
            btnMarca.Click += btnMarca_Click;
            // 
            // btnMuebles
            // 
            btnMuebles.Dock = DockStyle.Top;
            btnMuebles.FlatAppearance.BorderSize = 0;
            btnMuebles.FlatStyle = FlatStyle.Flat;
            btnMuebles.ForeColor = Color.LightGray;
            btnMuebles.Location = new Point(0, 0);
            btnMuebles.Name = "btnMuebles";
            btnMuebles.Padding = new Padding(35, 0, 0, 0);
            btnMuebles.Size = new Size(224, 40);
            btnMuebles.TabIndex = 0;
            btnMuebles.Text = "Muebles";
            btnMuebles.TextAlign = ContentAlignment.MiddleLeft;
            btnMuebles.UseVisualStyleBackColor = true;
            btnMuebles.Click += btnMuebles_Click;
            // 
            // btnMueblesDesplegable
            // 
            btnMueblesDesplegable.Dock = DockStyle.Top;
            btnMueblesDesplegable.FlatAppearance.BorderSize = 0;
            btnMueblesDesplegable.FlatStyle = FlatStyle.Flat;
            btnMueblesDesplegable.ForeColor = Color.Gainsboro;
            btnMueblesDesplegable.Location = new Point(0, 510);
            btnMueblesDesplegable.Name = "btnMueblesDesplegable";
            btnMueblesDesplegable.Padding = new Padding(10, 0, 0, 0);
            btnMueblesDesplegable.Size = new Size(224, 45);
            btnMueblesDesplegable.TabIndex = 5;
            btnMueblesDesplegable.Text = "Muebles";
            btnMueblesDesplegable.TextAlign = ContentAlignment.MiddleLeft;
            btnMueblesDesplegable.UseVisualStyleBackColor = true;
            btnMueblesDesplegable.Click += btnMueblesDesplegable_Click;
            // 
            // panelPedidosProveedorSubMenu
            // 
            panelPedidosProveedorSubMenu.BackColor = Color.FromArgb(35, 32, 39);
            panelPedidosProveedorSubMenu.Controls.Add(btnEstadoPedido);
            panelPedidosProveedorSubMenu.Controls.Add(btnProveedores);
            panelPedidosProveedorSubMenu.Controls.Add(btnPedidosProveedor);
            panelPedidosProveedorSubMenu.Dock = DockStyle.Top;
            panelPedidosProveedorSubMenu.Location = new Point(0, 376);
            panelPedidosProveedorSubMenu.Name = "panelPedidosProveedorSubMenu";
            panelPedidosProveedorSubMenu.Size = new Size(224, 134);
            panelPedidosProveedorSubMenu.TabIndex = 4;
            // 
            // btnEstadoPedido
            // 
            btnEstadoPedido.Dock = DockStyle.Top;
            btnEstadoPedido.FlatAppearance.BorderSize = 0;
            btnEstadoPedido.FlatStyle = FlatStyle.Flat;
            btnEstadoPedido.ForeColor = Color.LightGray;
            btnEstadoPedido.Location = new Point(0, 80);
            btnEstadoPedido.Name = "btnEstadoPedido";
            btnEstadoPedido.Padding = new Padding(35, 0, 0, 0);
            btnEstadoPedido.Size = new Size(224, 40);
            btnEstadoPedido.TabIndex = 2;
            btnEstadoPedido.Text = "Estado Pedido";
            btnEstadoPedido.TextAlign = ContentAlignment.MiddleLeft;
            btnEstadoPedido.UseVisualStyleBackColor = true;
            btnEstadoPedido.Click += btnEstadoPedido_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Dock = DockStyle.Top;
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.ForeColor = Color.LightGray;
            btnProveedores.Location = new Point(0, 40);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Padding = new Padding(35, 0, 0, 0);
            btnProveedores.Size = new Size(224, 40);
            btnProveedores.TabIndex = 1;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextAlign = ContentAlignment.MiddleLeft;
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnPedidosProveedor
            // 
            btnPedidosProveedor.Dock = DockStyle.Top;
            btnPedidosProveedor.FlatAppearance.BorderSize = 0;
            btnPedidosProveedor.FlatStyle = FlatStyle.Flat;
            btnPedidosProveedor.ForeColor = Color.LightGray;
            btnPedidosProveedor.Location = new Point(0, 0);
            btnPedidosProveedor.Name = "btnPedidosProveedor";
            btnPedidosProveedor.Padding = new Padding(35, 0, 0, 0);
            btnPedidosProveedor.Size = new Size(224, 40);
            btnPedidosProveedor.TabIndex = 0;
            btnPedidosProveedor.Text = "Pedidos";
            btnPedidosProveedor.TextAlign = ContentAlignment.MiddleLeft;
            btnPedidosProveedor.UseVisualStyleBackColor = true;
            btnPedidosProveedor.Click += btnPedidosProveedor_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gainsboro;
            button1.Location = new Point(0, 331);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(224, 45);
            button1.TabIndex = 3;
            button1.Text = "Pedidos Proveedor";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelVentasSubMenu
            // 
            panelVentasSubMenu.BackColor = Color.FromArgb(35, 32, 39);
            panelVentasSubMenu.Controls.Add(btnFacturas);
            panelVentasSubMenu.Controls.Add(btnClientes);
            panelVentasSubMenu.Controls.Add(btnEntregas);
            panelVentasSubMenu.Controls.Add(btnVentas);
            panelVentasSubMenu.Dock = DockStyle.Top;
            panelVentasSubMenu.Location = new Point(0, 157);
            panelVentasSubMenu.Name = "panelVentasSubMenu";
            panelVentasSubMenu.Size = new Size(224, 174);
            panelVentasSubMenu.TabIndex = 2;
            // 
            // btnFacturas
            // 
            btnFacturas.Dock = DockStyle.Top;
            btnFacturas.FlatAppearance.BorderSize = 0;
            btnFacturas.FlatStyle = FlatStyle.Flat;
            btnFacturas.ForeColor = Color.LightGray;
            btnFacturas.Location = new Point(0, 120);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Padding = new Padding(35, 0, 0, 0);
            btnFacturas.Size = new Size(224, 40);
            btnFacturas.TabIndex = 3;
            btnFacturas.Text = "Facturas";
            btnFacturas.TextAlign = ContentAlignment.MiddleLeft;
            btnFacturas.UseVisualStyleBackColor = true;
            btnFacturas.Click += btnFacturas_Click;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.ForeColor = Color.LightGray;
            btnClientes.Location = new Point(0, 80);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(35, 0, 0, 0);
            btnClientes.Size = new Size(224, 40);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnEntregas
            // 
            btnEntregas.Dock = DockStyle.Top;
            btnEntregas.FlatAppearance.BorderSize = 0;
            btnEntregas.FlatStyle = FlatStyle.Flat;
            btnEntregas.ForeColor = Color.LightGray;
            btnEntregas.Location = new Point(0, 40);
            btnEntregas.Name = "btnEntregas";
            btnEntregas.Padding = new Padding(35, 0, 0, 0);
            btnEntregas.Size = new Size(224, 40);
            btnEntregas.TabIndex = 1;
            btnEntregas.Text = "Entregas";
            btnEntregas.TextAlign = ContentAlignment.MiddleLeft;
            btnEntregas.UseVisualStyleBackColor = true;
            btnEntregas.Click += btnEntregas_Click;
            // 
            // btnVentas
            // 
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.ForeColor = Color.LightGray;
            btnVentas.Location = new Point(0, 0);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new Padding(35, 0, 0, 0);
            btnVentas.Size = new Size(224, 40);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "Venta";
            btnVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnVentasDesplegable
            // 
            btnVentasDesplegable.Dock = DockStyle.Top;
            btnVentasDesplegable.FlatAppearance.BorderSize = 0;
            btnVentasDesplegable.FlatStyle = FlatStyle.Flat;
            btnVentasDesplegable.ForeColor = Color.Gainsboro;
            btnVentasDesplegable.Location = new Point(0, 112);
            btnVentasDesplegable.Name = "btnVentasDesplegable";
            btnVentasDesplegable.Padding = new Padding(10, 0, 0, 0);
            btnVentasDesplegable.Size = new Size(224, 45);
            btnVentasDesplegable.TabIndex = 1;
            btnVentasDesplegable.Text = "Ventas";
            btnVentasDesplegable.TextAlign = ContentAlignment.MiddleLeft;
            btnVentasDesplegable.UseVisualStyleBackColor = true;
            btnVentasDesplegable.Click += btnVentasDesplegable_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(224, 112);
            panelLogo.TabIndex = 0;
            // 
            // panelPlayer
            // 
            panelPlayer.BackColor = Color.FromArgb(23, 21, 32);
            panelPlayer.Dock = DockStyle.Bottom;
            panelPlayer.Location = new Point(250, 510);
            panelPlayer.Name = "panelPlayer";
            panelPlayer.Size = new Size(938, 82);
            panelPlayer.TabIndex = 1;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(32, 30, 45);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(250, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(938, 510);
            panelChildForm.TabIndex = 2;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 592);
            Controls.Add(panelChildForm);
            Controls.Add(panelPlayer);
            Controls.Add(panelSideMenu);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Administrador";
            Text = "Administrador";
            panelSideMenu.ResumeLayout(false);
            panelMueblesSubMenu.ResumeLayout(false);
            panelPedidosProveedorSubMenu.ResumeLayout(false);
            panelVentasSubMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelLogo;
        private Panel panelVentasSubMenu;
        private Button btnVentas;
        private Button btnVentasDesplegable;
        private Button btnClientes;
        private Button btnEntregas;
        private Panel panelPedidosProveedorSubMenu;
        private Button btnEstadoPedido;
        private Button btnProveedores;
        private Button btnPedidosProveedor;
        private Button button1;
        private Button btnFacturas;
        private Panel panelMueblesSubMenu;
        private Button btnCategoría;
        private Button btnMarca;
        private Button btnMuebles;
        private Button btnMueblesDesplegable;
        private Button btnModelo;
        private Panel panelPlayer;
        private Panel panelChildForm;
    }
}
