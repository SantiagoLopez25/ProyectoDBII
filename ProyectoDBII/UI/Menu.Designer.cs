namespace UI
{
    partial class Menu
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
            panelGestion = new Panel();
            buttonCerrarSesion = new Button();
            btnEmpleados = new Button();
            buttonPermisos = new Button();
            buttonGestion = new Button();
            panelReportes = new Panel();
            button3 = new Button();
            button4 = new Button();
            buttonReporte2 = new Button();
            buttonReporte1 = new Button();
            buttonReportes = new Button();
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
            labelUsuario = new Label();
            panelChildForm = new Panel();
            panelSideMenu.SuspendLayout();
            panelGestion.SuspendLayout();
            panelReportes.SuspendLayout();
            panelMueblesSubMenu.SuspendLayout();
            panelPedidosProveedorSubMenu.SuspendLayout();
            panelVentasSubMenu.SuspendLayout();
            panelPlayer.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(11, 7, 17);
            panelSideMenu.Controls.Add(panelGestion);
            panelSideMenu.Controls.Add(buttonGestion);
            panelSideMenu.Controls.Add(panelReportes);
            panelSideMenu.Controls.Add(buttonReportes);
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
            panelSideMenu.Size = new Size(230, 98);
            panelSideMenu.TabIndex = 0;
            panelSideMenu.Paint += panelSideMenu_Paint;
            // 
            // panelGestion
            // 
            panelGestion.BackColor = Color.FromArgb(35, 32, 39);
            panelGestion.Controls.Add(buttonCerrarSesion);
            panelGestion.Controls.Add(btnEmpleados);
            panelGestion.Controls.Add(buttonPermisos);
            panelGestion.Dock = DockStyle.Top;
            panelGestion.Location = new Point(0, 987);
            panelGestion.Name = "panelGestion";
            panelGestion.Size = new Size(229, 120);
            panelGestion.TabIndex = 10;
            // 
            // buttonCerrarSesion
            // 
            buttonCerrarSesion.Dock = DockStyle.Top;
            buttonCerrarSesion.FlatAppearance.BorderSize = 0;
            buttonCerrarSesion.FlatStyle = FlatStyle.Flat;
            buttonCerrarSesion.ForeColor = Color.LightGray;
            buttonCerrarSesion.Location = new Point(0, 80);
            buttonCerrarSesion.Name = "buttonCerrarSesion";
            buttonCerrarSesion.Padding = new Padding(35, 0, 0, 0);
            buttonCerrarSesion.Size = new Size(229, 35);
            buttonCerrarSesion.TabIndex = 2;
            buttonCerrarSesion.Text = "Salir";
            buttonCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            buttonCerrarSesion.UseVisualStyleBackColor = true;
            buttonCerrarSesion.Click += buttonCerrarSesion_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.Dock = DockStyle.Top;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.ForeColor = Color.LightGray;
            btnEmpleados.Location = new Point(0, 40);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Padding = new Padding(35, 0, 0, 0);
            btnEmpleados.Size = new Size(229, 40);
            btnEmpleados.TabIndex = 1;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // buttonPermisos
            // 
            buttonPermisos.Dock = DockStyle.Top;
            buttonPermisos.FlatAppearance.BorderSize = 0;
            buttonPermisos.FlatStyle = FlatStyle.Flat;
            buttonPermisos.ForeColor = Color.LightGray;
            buttonPermisos.Location = new Point(0, 0);
            buttonPermisos.Name = "buttonPermisos";
            buttonPermisos.Padding = new Padding(35, 0, 0, 0);
            buttonPermisos.Size = new Size(229, 40);
            buttonPermisos.TabIndex = 0;
            buttonPermisos.Text = "Permisos";
            buttonPermisos.TextAlign = ContentAlignment.MiddleLeft;
            buttonPermisos.UseVisualStyleBackColor = true;
            buttonPermisos.Click += buttonPermisos_Click;
            // 
            // buttonGestion
            // 
            buttonGestion.Dock = DockStyle.Top;
            buttonGestion.FlatAppearance.BorderSize = 0;
            buttonGestion.FlatStyle = FlatStyle.Flat;
            buttonGestion.ForeColor = Color.Gainsboro;
            buttonGestion.Location = new Point(0, 942);
            buttonGestion.Name = "buttonGestion";
            buttonGestion.Padding = new Padding(10, 0, 0, 0);
            buttonGestion.Size = new Size(229, 45);
            buttonGestion.TabIndex = 9;
            buttonGestion.Text = "Gestion";
            buttonGestion.TextAlign = ContentAlignment.MiddleLeft;
            buttonGestion.UseVisualStyleBackColor = true;
            buttonGestion.Click += buttonGestion_Click;
            // 
            // panelReportes
            // 
            panelReportes.BackColor = Color.FromArgb(35, 32, 39);
            panelReportes.Controls.Add(button3);
            panelReportes.Controls.Add(button4);
            panelReportes.Controls.Add(buttonReporte2);
            panelReportes.Controls.Add(buttonReporte1);
            panelReportes.Dock = DockStyle.Top;
            panelReportes.Location = new Point(0, 771);
            panelReportes.Name = "panelReportes";
            panelReportes.Size = new Size(229, 171);
            panelReportes.TabIndex = 8;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.LightGray;
            button3.Location = new Point(0, 120);
            button3.Name = "button3";
            button3.Padding = new Padding(35, 0, 0, 0);
            button3.Size = new Size(229, 40);
            button3.TabIndex = 3;
            button3.Text = "Modelo";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.LightGray;
            button4.Location = new Point(0, 80);
            button4.Name = "button4";
            button4.Padding = new Padding(35, 0, 0, 0);
            button4.Size = new Size(229, 40);
            button4.TabIndex = 2;
            button4.Text = "Categoría";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // buttonReporte2
            // 
            buttonReporte2.Dock = DockStyle.Top;
            buttonReporte2.FlatAppearance.BorderSize = 0;
            buttonReporte2.FlatStyle = FlatStyle.Flat;
            buttonReporte2.ForeColor = Color.LightGray;
            buttonReporte2.Location = new Point(0, 40);
            buttonReporte2.Name = "buttonReporte2";
            buttonReporte2.Padding = new Padding(35, 0, 0, 0);
            buttonReporte2.Size = new Size(229, 40);
            buttonReporte2.TabIndex = 1;
            buttonReporte2.Text = "Reporte";
            buttonReporte2.TextAlign = ContentAlignment.MiddleLeft;
            buttonReporte2.UseVisualStyleBackColor = true;
            // 
            // buttonReporte1
            // 
            buttonReporte1.Dock = DockStyle.Top;
            buttonReporte1.FlatAppearance.BorderSize = 0;
            buttonReporte1.FlatStyle = FlatStyle.Flat;
            buttonReporte1.ForeColor = Color.LightGray;
            buttonReporte1.Location = new Point(0, 0);
            buttonReporte1.Name = "buttonReporte1";
            buttonReporte1.Padding = new Padding(35, 0, 0, 0);
            buttonReporte1.Size = new Size(229, 40);
            buttonReporte1.TabIndex = 0;
            buttonReporte1.Text = "Reportes";
            buttonReporte1.TextAlign = ContentAlignment.MiddleLeft;
            buttonReporte1.UseVisualStyleBackColor = true;
            buttonReporte1.Click += buttonReporte1_Click;
            // 
            // buttonReportes
            // 
            buttonReportes.Dock = DockStyle.Top;
            buttonReportes.FlatAppearance.BorderSize = 0;
            buttonReportes.FlatStyle = FlatStyle.Flat;
            buttonReportes.ForeColor = Color.Gainsboro;
            buttonReportes.Location = new Point(0, 726);
            buttonReportes.Name = "buttonReportes";
            buttonReportes.Padding = new Padding(10, 0, 0, 0);
            buttonReportes.Size = new Size(229, 45);
            buttonReportes.TabIndex = 7;
            buttonReportes.Text = "Reportes";
            buttonReportes.TextAlign = ContentAlignment.MiddleLeft;
            buttonReportes.UseVisualStyleBackColor = true;
            buttonReportes.Click += button2_Click;
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
            panelMueblesSubMenu.Size = new Size(229, 171);
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
            btnModelo.Size = new Size(229, 40);
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
            btnCategoría.Size = new Size(229, 40);
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
            btnMarca.Size = new Size(229, 40);
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
            btnMuebles.Size = new Size(229, 40);
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
            btnMueblesDesplegable.Size = new Size(229, 45);
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
            panelPedidosProveedorSubMenu.Size = new Size(229, 134);
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
            btnEstadoPedido.Size = new Size(229, 40);
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
            btnProveedores.Size = new Size(229, 40);
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
            btnPedidosProveedor.Size = new Size(229, 40);
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
            button1.Size = new Size(229, 45);
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
            panelVentasSubMenu.Size = new Size(229, 174);
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
            btnFacturas.Size = new Size(229, 40);
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
            btnClientes.Size = new Size(229, 40);
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
            btnEntregas.Size = new Size(229, 40);
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
            btnVentas.Size = new Size(229, 40);
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
            btnVentasDesplegable.Size = new Size(229, 45);
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
            panelLogo.Size = new Size(229, 112);
            panelLogo.TabIndex = 0;
            // 
            // panelPlayer
            // 
            panelPlayer.BackColor = Color.FromArgb(23, 21, 32);
            panelPlayer.Controls.Add(labelUsuario);
            panelPlayer.Dock = DockStyle.Bottom;
            panelPlayer.Location = new Point(250, 388);
            panelPlayer.Name = "panelPlayer";
            panelPlayer.Size = new Size(1132, 82);
            panelPlayer.TabIndex = 1;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.ForeColor = Color.Gainsboro;
            labelUsuario.Location = new Point(28, 32);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(53, 20);
            labelUsuario.TabIndex = 0;
            labelUsuario.Text = "label1";
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(32, 30, 45);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(250, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1132, 388);
            panelChildForm.TabIndex = 2;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 470);
            Controls.Add(panelChildForm);
            Controls.Add(panelPlayer);
            Controls.Add(panelSideMenu);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Menu";
            Load += Menu_Load;
            panelSideMenu.ResumeLayout(false);
            panelGestion.ResumeLayout(false);
            panelReportes.ResumeLayout(false);
            panelMueblesSubMenu.ResumeLayout(false);
            panelPedidosProveedorSubMenu.ResumeLayout(false);
            panelVentasSubMenu.ResumeLayout(false);
            panelPlayer.ResumeLayout(false);
            panelPlayer.PerformLayout();
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
        private Button btnMueblesDesplegable;
        private Panel panelPlayer;
        private Panel panelChildForm;
        private Panel panelReportes;
        private Button button3;
        private Button button4;
        private Button buttonReporte2;
        private Button buttonReporte1;
        private Button buttonReportes;
        private Panel panelMueblesSubMenu;
        private Button btnModelo;
        private Button btnCategoría;
        private Button btnMarca;
        private Button btnMuebles;
        private Panel panelGestion;
        private Button btnEmpleados;
        private Button buttonPermisos;
        private Button buttonGestion;
        private Label labelUsuario;
        private Button buttonCerrarSesion;
    }
}
