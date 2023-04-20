using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class Login : Form
    {
        Controlador cn = new Controlador();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtContraseña.Text;

           

            if (usuario.Trim() == "" || password.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña.");

            }
            else
            {
                cn.verificarusuario(usuario, password);
            }
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
