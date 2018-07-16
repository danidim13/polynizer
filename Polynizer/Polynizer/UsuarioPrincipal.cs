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
    public partial class UsuarioPrincipal : Form
    {
        public UsuarioPrincipal()
        {
            InitializeComponent();
        }

        private void UsuarioPrincipal_Load(object sender, EventArgs e)
        {

        }


        private void linkLabelCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Global.login = new LoginWindow();
            Global.login.Show();
            this.Close();
        }

        private void buttonCompras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.usuarioCompras = new ListaCompras();
            Global.usuarioCompras.Show();
            this.Close();
        }

        private void buttonCanciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.usuarioCanciones = new CancionesUsuario();
            Global.usuarioCanciones.Show();
            this.Close();
        }

        private void buttonProcesarCancion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.usuarioProcesarCancion = new ProcesaCancion();
            Global.usuarioProcesarCancion.Show();
            this.Close();
        }

        private void linkLabelPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Global.usuarioVerPerfil = new UsuarioVerPerfil();
            Global.usuarioVerPerfil.Show();
            this.Close();
        }
    }
}
