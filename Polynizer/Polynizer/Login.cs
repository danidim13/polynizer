using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polynizer
{
    public partial class LoginWindow : Form
    {
        ClaseIntermediaria intermediaria;
        public LoginWindow()
        {
            InitializeComponent();
            intermediaria = new ClaseIntermediaria();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            if (textBoxCorreoUsuario.Text != "" && textBoxContraseñaUsuario.Text != "")
            {
                if (intermediaria.login(textBoxCorreoUsuario.Text,textBoxContraseñaUsuario.Text)==true)
                {
                    MessageBox.Show("Usuario Correcto", "Login", MessageBoxButtons.OK, MessageBoxIcon.None);
                    /*ToDo consultar si es admin y mostrar las ventanas de inicio*/
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta, por favor vuelva a intentar", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduzca los datos para el inicio de sesión", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
