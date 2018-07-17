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
    public partial class PincipalAdmin : Form
    {
        public PincipalAdmin()
        {
            InitializeComponent();
        }

        

        private void PincipalAdmin_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.canciones = new System.Windows.Forms.Button();
            this.Usuarios = new System.Windows.Forms.Button();
            this.Estadisticas = new System.Windows.Forms.Button();
            this.CerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // canciones
            // 
            this.canciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.canciones.Location = new System.Drawing.Point(31, 172);
            this.canciones.Name = "canciones";
            this.canciones.Size = new System.Drawing.Size(134, 40);
            this.canciones.TabIndex = 0;
            this.canciones.Text = "Canciones";
            this.canciones.UseVisualStyleBackColor = true;
            this.canciones.Click += new System.EventHandler(this.canciones_Click);
            // 
            // Usuarios
            // 
            this.Usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Usuarios.Location = new System.Drawing.Point(31, 83);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(134, 40);
            this.Usuarios.TabIndex = 1;
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.UseVisualStyleBackColor = true;
            this.Usuarios.Click += new System.EventHandler(this.Usuarios_Click);
            // 
            // Estadisticas
            // 
            this.Estadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Estadisticas.Location = new System.Drawing.Point(31, 259);
            this.Estadisticas.Name = "Estadisticas";
            this.Estadisticas.Size = new System.Drawing.Size(134, 40);
            this.Estadisticas.TabIndex = 2;
            this.Estadisticas.Text = "Estadísticas";
            this.Estadisticas.UseVisualStyleBackColor = true;
            this.Estadisticas.Click += new System.EventHandler(this.Estadisticas_Click);
            // 
            // CerrarSesion
            // 
            this.CerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CerrarSesion.Location = new System.Drawing.Point(446, 23);
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Size = new System.Drawing.Size(103, 40);
            this.CerrarSesion.TabIndex = 3;
            this.CerrarSesion.Text = "Cerrar sesión";
            this.CerrarSesion.UseVisualStyleBackColor = true;
            this.CerrarSesion.Click += new System.EventHandler(this.CerrarSesion_Click);
            // 
            // PincipalAdmin
            // 
            this.ClientSize = new System.Drawing.Size(570, 401);
            this.Controls.Add(this.CerrarSesion);
            this.Controls.Add(this.Estadisticas);
            this.Controls.Add(this.Usuarios);
            this.Controls.Add(this.canciones);
            this.Name = "PincipalAdmin";
            this.Text = "Principal Administrador";
            this.Load += new System.EventHandler(this.PincipalAdmin_Load_1);
            this.ResumeLayout(false);

        }

        

        private void Usuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.adminListaUsuarios = new ListaUsuarios();
            Global.adminListaUsuarios.Show();
            this.Close();
        }

        private void canciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.adminCanciones = new CancionesAdmin();
            Global.adminCanciones.Show();
            this.Close();
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.login = new LoginWindow();
            Global.login.Show();
            this.Close();
        }

        private void Estadisticas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.adminGraficos = new Graficos();
            Global.adminGraficos.Show();
            this.Close();
        }

        private void PincipalAdmin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
