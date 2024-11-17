using BLL.Compra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ActualizarInventario : Form
    {
        private readonly IServiceCompra _serviceCompra;
        private int idCompra;
        private int id_Usuario;
        private string estado_Compra;


        public ActualizarInventario()
        {
            InitializeComponent();
            _serviceCompra = new ServiceCompra();
            ListarCompras();
        }

        private void dataGridViewCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListarCompras()
        {
            dataGridViewCompras.DataSource = _serviceCompra.ListarCompras();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (dataGridViewCompras.SelectedRows.Count > 0)
            {
                if (!estado_Compra.Equals("Recibido Completo"))
                {
                    string resultado = _serviceCompra.ActualizarCompraYCrearStock(idCompra, Convert.ToInt32(txtBoxCantidadRecibida.Text), null);

                    MessageBox.Show(resultado, "Resultado de la actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (resultado.Equals("Cantidad recibida actualizada, pero aún incompleta") || resultado.Equals("Compra actualizada y stock creado"))
                    {
                        
                    }
                }
                else
                {
                    MessageBox.Show("Esta compra ya está completada");
                }
            }
            else
                MessageBox.Show("Debe seleccionar un registro a editar");

            ListarCompras();
        }

        private void dataGridViewCompras_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCompras.SelectedRows.Count > 0)
            {

                groupBoxActualizar.Visible = true;

                DataGridViewRow filaSeleccionada = dataGridViewCompras.SelectedRows[0];

                idCompra = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
                estado_Compra = filaSeleccionada.Cells[7].Value.ToString();

            }

        }

        private void btnListarCompras_Click(object sender, EventArgs e)
        {
            ListarCompras();
        }
    }
}
