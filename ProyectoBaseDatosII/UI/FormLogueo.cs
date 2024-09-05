using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Login;

namespace UI
{
    public partial class FormLogueo : Form
    {
        private LoginService loginService;
        public FormLogueo()
        {
            InitializeComponent();
            loginService = new LoginService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBoxUsuario.Text;
            string password = textBoxPassword.Text;
            string respueseta = loginService.inicioSesion(user, password);
            MessageBox.Show(respueseta);

        }
    }
}
