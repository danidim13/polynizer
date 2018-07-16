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
    public partial class UsuarioVerPerfil : Form
    {
        public UsuarioVerPerfil()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void regresarBTN_Click(object sender, EventArgs e)
        {
            Global.usuarioPrincipal = new UsuarioPrincipal();
            Global.usuarioPrincipal.Show();
            this.Close();
        }
    }
}
