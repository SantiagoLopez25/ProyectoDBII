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
        public  int id_Usuario;
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
                DataTable tabla = loginService.InicioDeSesion(user, password);
                string respuesta =  tabla.Rows[0]["Rol"].ToString();
                int idUsuario = Convert.ToInt32(tabla.Rows[0]["IdUsuario"].ToString());
                

                if (respuesta == "Administrador")
                {
                    Menu menu = new Menu();
                    menu.setPrivileges(respuesta, textBoxUsuario.Text, idUsuario);
                    menu.ShowDialog();
                    id_Usuario = 1;
                    this.Hide();
                }
                else if (respuesta == "Vendedor")
                {
                    Menu menu = new Menu();
                    menu.setPrivileges(respuesta, textBoxUsuario.Text, idUsuario);
                    menu.ShowDialog();
                    id_Usuario = 4;
                    this.Hide();
                }
                else if (respuesta == "Bodeguero")
                {
                    Menu menu = new Menu();
                    menu.setPrivileges(respuesta, textBoxUsuario.Text, idUsuario);
                    menu.ShowDialog();
                    id_Usuario = 2;
                    this.Hide();
                }
                else if (respuesta == "Gerente")
                {
                    Menu menu = new Menu();
                    menu.setPrivileges(respuesta, textBoxUsuario.Text, idUsuario);
                    menu.ShowDialog();
                    id_Usuario = 5;
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
