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

        /*
         * Constructor de la clase
         */ 
        public LoginWindow()
        {
            InitializeComponent();
            intermediaria = new ClaseIntermediaria();
        }

        /*Metodo que revisa si el usuario existe en la base de datos, tiene la contraseña correcta y si se debe iniciar en modo administrador o usuario*/
        /*Si el usuario es correcto crea la ventana correspondiente*/
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            if (textBoxCorreoUsuario.Text != "" && textBoxContraseñaUsuario.Text != "")
            {
                if (intermediaria.login(textBoxCorreoUsuario.Text,textBoxContraseñaUsuario.Text)==true)
                {
                    if(intermediaria.superUser(textBoxCorreoUsuario.Text)==true)
                    {
                        MessageBox.Show("Usuario Correcto, se iniciará seción como administrador", "Login", MessageBoxButtons.OK, MessageBoxIcon.None);
                        Global.setCorreoUsuario(textBoxCorreoUsuario.Text);
                        /*ToDo Iniciar ventana opciones admin*/
                    }
                    else
                    {
                        MessageBox.Show("Usuario Correcto, se iniciará seción como usuario", "Login", MessageBoxButtons.OK, MessageBoxIcon.None);
                        Global.setCorreoUsuario(textBoxCorreoUsuario.Text);
                        /*ToDo Iniciar ventana opciones usuario*/
                    }
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

        private void labelTextoBienvenida_Click(object sender, EventArgs e){}

        private void LoginWindow_Load(object sender, EventArgs e){}
    }
}
