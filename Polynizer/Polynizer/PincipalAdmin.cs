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
    public partial class PincipalAdmin : Form
    {
        public PincipalAdmin()
        {
            InitializeComponent();

            SqlDataReader reader = Global.intermediaria.obtenerCampoEspecificoUsuario("Nombre");
            if (reader.Read())
            {
                this.labelNombre.Text = Convert.ToString(reader.GetValue(0));
            }
        }

        

        private void PincipalAdmin_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.canciones = new System.Windows.Forms.Button();
            this.Usuarios = new System.Windows.Forms.Button();
            this.Estadisticas = new System.Windows.Forms.Button();
            this.linkLabelCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.labelNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // canciones
            // 
            this.canciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canciones.Location = new System.Drawing.Point(29, 156);
            this.canciones.Name = "canciones";
            this.canciones.Size = new System.Drawing.Size(518, 67);
            this.canciones.TabIndex = 0;
            this.canciones.Text = "Canciones";
            this.canciones.UseVisualStyleBackColor = true;
            this.canciones.Click += new System.EventHandler(this.canciones_Click);
            // 
            // Usuarios
            // 
            this.Usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuarios.Location = new System.Drawing.Point(31, 83);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(518, 67);
            this.Usuarios.TabIndex = 1;
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.UseVisualStyleBackColor = true;
            this.Usuarios.Click += new System.EventHandler(this.Usuarios_Click);
            // 
            // Estadisticas
            // 
            this.Estadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estadisticas.Location = new System.Drawing.Point(29, 229);
            this.Estadisticas.Name = "Estadisticas";
            this.Estadisticas.Size = new System.Drawing.Size(518, 67);
            this.Estadisticas.TabIndex = 2;
            this.Estadisticas.Text = "Estadísticas";
            this.Estadisticas.UseVisualStyleBackColor = true;
            this.Estadisticas.Click += new System.EventHandler(this.Estadisticas_Click);
            // 
            // linkLabelCerrarSesion
            // 
            this.linkLabelCerrarSesion.AutoSize = true;
            this.linkLabelCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCerrarSesion.Location = new System.Drawing.Point(436, 32);
            this.linkLabelCerrarSesion.Name = "linkLabelCerrarSesion";
            this.linkLabelCerrarSesion.Size = new System.Drawing.Size(111, 20);
            this.linkLabelCerrarSesion.TabIndex = 4;
            this.linkLabelCerrarSesion.TabStop = true;
            this.linkLabelCerrarSesion.Text = "Cerrar sesión";
            this.linkLabelCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCerrarSesion_LinkClicked);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(28, 35);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(87, 25);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "Nombre";
            // 
            // PincipalAdmin
            // 
            this.ClientSize = new System.Drawing.Size(586, 401);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.linkLabelCerrarSesion);
            this.Controls.Add(this.Estadisticas);
            this.Controls.Add(this.Usuarios);
            this.Controls.Add(this.canciones);
            this.Name = "PincipalAdmin";
            this.Text = "Principal Administrador";
            this.Load += new System.EventHandler(this.PincipalAdmin_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

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

        private void linkLabelCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Global.login = new LoginWindow();
            Global.login.Show();
            this.Close();
        }
    }
}
