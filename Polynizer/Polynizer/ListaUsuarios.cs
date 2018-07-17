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
    public partial class ListaUsuarios : Form
    {
        public ListaUsuarios()
        {
            InitializeComponent();
        }

        private void ListaUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void listaUsuariosDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void EditarBTN_Click(object sender, EventArgs e)
        {

        }

        private void agregarLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Global.adminAgregarUsuario = new AgregarUsuario();
            Global.adminAgregarUsuario.Show();
            this.Close();
        }

        private void regresarLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Global.adminPrincipal = new PincipalAdmin();
            Global.adminPrincipal.Show();
            this.Close();
        }

        private void correosCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EliminarBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
