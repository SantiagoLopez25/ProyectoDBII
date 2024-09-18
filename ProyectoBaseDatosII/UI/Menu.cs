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

            }
            else if (privilegio == "Bodeguero")
            {
                btnVentasDesplegable.Visible = false;
                buttonPermisos.Visible = false;
                button1.Visible = false;


            }
            else if (privilegio == "Vendedor")
            {
                buttonPermisos.Visible = false;
                buttonReportes.Visible = false;
                button1.Visible = false;


            }

            else if (privilegio == "Gerente")
            {
                buttonPermisos.Visible = false;
                btnMueblesDesplegable.Visible = false;
                btnVentasDesplegable.Visible = false;

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
            //ABRIR CRU DE VENTAS
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

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            Login login = new Login();
            login.Show();
            this.Dispose();
        }


        #endregion

        #region Reportes

        private void button2_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReportes);
        }

        private void buttonReporte1_Click(object sender, EventArgs e)
        {
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
    }
}
