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
    public partial class Login : Form
    {
        private LoginService loginService;
        public Login()
        {
            InitializeComponent();
            loginService = new LoginService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBoxUsuario.Text;
            string password = textBoxPassword.Text;

            if (user == "")
            {
                MessageBox.Show("El usuario es requerido");
            }
            else if (password == "")
            {
                MessageBox.Show("La contraseña es requerida");
            }

            else
            {
                
                string respuesta = loginService.inicioSesion(user, password);
                if (respuesta == "Administrador")
                {
                    Administrador admin = new Administrador();
                    admin.Show();
                    this.Hide();
                }

                else if (respuesta == "0")
                {
                    MessageBox.Show("Credenciales incorrectas");
                }
               
            }

           

        }
    }
}
