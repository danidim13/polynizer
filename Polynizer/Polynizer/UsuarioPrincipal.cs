using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polynizer
{
    public partial class UsuarioPrincipal : Form
    {
        private bool continueRunning;

        public UsuarioPrincipal()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            ActulizarTextos();
            this.continueRunning = false;
        }

        private void UsuarioPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ActulizarTextos()
        {
            SqlDataReader reader = Global.intermediaria.obtenerCampoEspecificoUsuario("Nombre");
            if (reader.Read())
            {
                this.labelNombre.Text = Convert.ToString(reader.GetValue(0));
            }
            this.tokens = Global.intermediaria.tokensRestantes(Global.correoUsuario);
            this.labelTokens.Text = "Tokens: " + this.tokens.ToString();
        }

        private void linkLabelCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Global.login = new LoginWindow();
            Global.login.Show();
            this.continueRunning = true;
            this.Close();
        }

        private void buttonCompras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.usuarioCompras = new ListaCompras();
            Global.usuarioCompras.Show();
            this.continueRunning = true;
            this.Close();
        }

        private void buttonCanciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.usuarioCanciones = new CancionesUsuario();
            Global.usuarioCanciones.Show();
            this.continueRunning = true;
            this.Close();
        }

        private void buttonProcesarCancion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.usuarioProcesarCancion = new ProcesaCancion();
            Global.usuarioProcesarCancion.Show();
            this.continueRunning = true;
            this.Close();
        }

        private void linkLabelPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Global.usuarioVerPerfil = new UsuarioVerPerfil();
            Global.usuarioVerPerfil.Show();
            this.continueRunning = true;
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!this.continueRunning)
            {
                Global.ConfirmExit(ref e);
            }
        }
    }
}
