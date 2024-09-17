using System.Security.Cryptography;

namespace UI
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        private void customizeDesign()
        {
            panelMueblesSubMenu.Visible = false;
            panelVentasSubMenu.Visible = false;
            panelPedidosProveedorSubMenu.Visible = false;
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

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null){
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
    }
}
