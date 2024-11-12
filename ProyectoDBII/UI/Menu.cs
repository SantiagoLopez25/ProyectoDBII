using iTextSharp.text;
using System.Security.Cryptography;

namespace UI
{
    public partial class Menu : Form
    {
        private string privilegio;

        public Menu()
        {

            InitializeComponent();
            customizeDesign();
        }

        public void setPrivileges(string privilegio, string usuario)
        {
            labelUsuario.Text = usuario + " - " + privilegio;
            this.privilegio = privilegio;
            this.Text = privilegio;

            if (privilegio == "Administrador")
            {
                Venta venta = new Venta();
                venta.setIdUsuario(1);
            }
            else if (privilegio == "Bodeguero")
            {
                btnVentasDesplegable.Visible = false;
                buttonPermisos.Visible = false;
                button1.Visible = false;
                btnEmpleados.Visible = false;


            }
            else if (privilegio == "Vendedor")
            {
                buttonPermisos.Visible = false;
                buttonReportes.Visible = false;
                button1.Visible = false;
                btnEmpleados.Visible = false;
                Venta venta = new Venta();
                venta.setIdUsuario(4);


            }

            else if (privilegio == "Gerente")
            {
                buttonPermisos.Visible = false;
                btnMueblesDesplegable.Visible = false;
                btnVentasDesplegable.Visible = false;
                btnEmpleados.Visible = false;
            }


        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        private void customizeDesign()
        {
            panelMueblesSubMenu.Visible = false;
            panelVentasSubMenu.Visible = false;
            panelPedidosProveedorSubMenu.Visible = false;
            panelGestion.Visible = false;
            panelReportes.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelMueblesSubMenu.Visible == true)
            {
                panelMueblesSubMenu.Visible = false;
            }
            if (panelVentasSubMenu.Visible == true)
            {
                panelVentasSubMenu.Visible = false;
            }
            if (panelPedidosProveedorSubMenu.Visible == true)
            {
                panelPedidosProveedorSubMenu.Visible = false;
            }
            if (panelGestion.Visible == true)
            {
                panelGestion.Visible = false;
            }
            if (panelReportes.Visible == true)
            {
                panelReportes.Visible = false;
            }

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #region Ventas
        private void btnVentasDesplegable_Click(object sender, EventArgs e)
        {
            showSubMenu(panelVentasSubMenu);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            openChildForm(new Venta());
            this.Text = "Venta";
            hideSubMenu();
        }

        private void btnEntregas_Click(object sender, EventArgs e)
        {
            //ABRIR FORM CRU DE ENTREGAS
            hideSubMenu();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //ABRIR FORM CRU DE CLIENTES
            hideSubMenu();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            //ABRIR FORM DE FACTURAS
        }
        #endregion
        #region Pedidos Proveedores
        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPedidosProveedorSubMenu);
        }

        private void btnPedidosProveedor_Click(object sender, EventArgs e)
        {
            //ABRIR FORM DE PEDIDOS DE PROVEEDOR
            hideSubMenu();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            //ABRIR FORM DE PROVEEDORES
            openChildForm(new Proveedor());
            this.Text = "Proveedores";
            hideSubMenu();
        }

        private void btnEstadoPedido_Click(object sender, EventArgs e)
        {
            //ABRIR FORM DE ESTADO DE PEDIDO 
            hideSubMenu();
        }
        #endregion
        #region Muebles
        private void btnMueblesDesplegable_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMueblesSubMenu);
        }

        private void btnMuebles_Click(object sender, EventArgs e)
        {
            //ABRIR FORM DE CRU DE MUEBLES
            hideSubMenu();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            //ABRIR FORM DE CRU DE MARCA
            openChildForm(new Marca());
            this.Text = "Marcas";
            hideSubMenu();
        }

        private void btnCategoría_Click(object sender, EventArgs e)
        {
            //ABRIR FORM DE CRU DE CATEGORIA
            openChildForm(new Categoria());
            this.Text = "Categorias";
            hideSubMenu();
        }

        private void btnModelo_Click(object sender, EventArgs e)
        {
            //ABRIR FORM DE CRU DE MODELO
            hideSubMenu();
        }
        #endregion

        #region Gestion

        private void buttonGestion_Click(object sender, EventArgs e)
        {
            showSubMenu(panelGestion);
        }

        private void buttonPermisos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            this.Text = "Permisos";
            openChildForm(new FormPermisos());

        }




        #endregion

        #region Reportes

        private void button2_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReportes);
        }

        private void buttonReporte1_Click(object sender, EventArgs e)
        {

            openChildForm(new Reporte1());
            this.Text = "Reporte 1";
            hideSubMenu();

        }

        private void buttonReporte2_Click(object sender, EventArgs e)
        {
            openChildForm(new Reporte2());
            this.Text = "Reporte 2";
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Reporte3());
            this.Text = "Reporte 3";
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Reporte4());
            this.Text = "Reporte 4";
            hideSubMenu();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Reporte5());
            this.Text = "Reporte 5";
            hideSubMenu();
        }



        #endregion

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            Login login = new Login();
            login.Show();
            this.Dispose();
            Application.Exit();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            this.Text = "Empleados";
            openChildForm(new Empleado());
        }

        
    }
}
