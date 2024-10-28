using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Persona.Empleado;

namespace UI
{
    public partial class Empleado : Form
    {
        private readonly IServiceEmpleado _serviceEmpleado;
        public Empleado()
        {
            InitializeComponent();
            _serviceEmpleado = new ServiceEmpleado();
        }


        private void ListarEmpleadoes()
        {
            dataGridViewEmpleadoes.DataSource = _serviceEmpleado.ListarEmpleado();
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            lblId.Visible = false;
            lblEstado.Visible = false;
            ClearData();
            ListarEmpleadoes();
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            btnEditarEmpleado.Enabled = false;
            btnEliminarEmpleado.Enabled = false;
            _serviceEmpleado.AgregarEmpleado(
                txtEmpleado.Text,
                txtTelefono.Text,
                txtCorreo.Text,
                Boolean.Parse(lblEstado.Text)
                );
            MessageBox.Show("Insertado correctamente");
            ClearData();
            btnEditarEmpleado.Enabled = true;
            btnEliminarEmpleado.Enabled = true;
            ListarEmpleadoes();
        }


        void ClearData()
        {
            txtEmpleado.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            lblId.Text = "";
            lblEstado.Text = "true";
            groupEditar.Hide();
            groupCrear.Show();
            btnCrearEmpleado.Enabled = true;
            btnEditarEmpleado.Enabled = false;
            btnEliminarEmpleado.Enabled = false;
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmpleadoes.SelectedRows.Count > 0)
            {
                groupCrear.Hide();
                groupEditar.Show();
                btnCrearEmpleado.Enabled = false;
                _serviceEmpleado.EditarEmpleado(
                Convert.ToInt32(dataGridViewEmpleadoes.CurrentRow.Cells[0].Value),
                txtEmpleadoEditar.Text,
                txtTelefonoEditar.Text,
                txtCorreoEditar.Text,
                Boolean.Parse(lblEstado.Text)
                );
                MessageBox.Show("Editado correctamente");
                ListarEmpleadoes();
                ClearData();
            }
            else
                MessageBox.Show("Debe seleccionar un registro a editar");
        }

        private void dataGridViewEmpleadoes_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEmpleadoes.SelectedRows.Count > 0)
            {
                groupCrear.Hide();
                groupEditar.Show();
                btnCrearEmpleado.Enabled = false;
                btnEditarEmpleado.Enabled = true;
                btnEliminarEmpleado.Enabled = true;

                DataGridViewRow selectedRow = dataGridViewEmpleadoes.SelectedRows[0];
                txtEmpleadoEditar.Text = (selectedRow.Cells[1].Value).ToString();
                txtTelefonoEditar.Text = (selectedRow.Cells[2].Value).ToString();
                txtCorreoEditar.Text = (selectedRow.Cells[3].Value).ToString();
                lblEstado.Text = (selectedRow.Cells[4].Value).ToString();
            }
            else
            {
                lblEstado.Text = "true";
                groupEditar.Hide();
                groupCrear.Show();
                btnCrearEmpleado.Enabled = true;
                btnEditarEmpleado.Enabled = false;
                btnEliminarEmpleado.Enabled = false;
            }
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmpleadoes.SelectedRows.Count > 0)
            {
                groupCrear.Hide();
                groupEditar.Show();
                btnCrearEmpleado.Enabled = false;
                _serviceEmpleado.EliminarEmpleado(
                Convert.ToInt32(dataGridViewEmpleadoes.CurrentRow.Cells[0].Value)
                );
                MessageBox.Show("Eliminado correctamente");
                ListarEmpleadoes();
                ClearData();
            }
            else
                MessageBox.Show("Debe seleccionar un registro a eliminar");
        }
    }
}
