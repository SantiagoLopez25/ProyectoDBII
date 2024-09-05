using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Permisos;

namespace UI
{
    public partial class FormPermisos : Form
    {
        private PermisosService permisosService;
        int id_usuario;
        public FormPermisos()
        {
            InitializeComponent();
            permisosService = new PermisosService();
        }

        private void FormPermisos_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            llenarUsuarios();
            llenarRoles();

        }

        private void llenarRoles()
        {
            comboBox1.DataSource = permisosService.ListaRoles();
            comboBox1.DisplayMember = "nombre_rol";
            comboBox1.Refresh();
        }

        private void llenarUsuarios()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = permisosService.ListaUsuarios();
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int seleccionado = comboBox1.SelectedIndex +1;
            
            string respuesta = permisosService.cambioPermiso(id_usuario,seleccionado);
            MessageBox.Show(respuesta);
            llenarUsuarios();
            button1.Enabled=false;
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id_usuario = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                labelUsuario.Text = "ID usuario: " + id_usuario.ToString();
                button1.Enabled = true;

            }
        }
    }
}
