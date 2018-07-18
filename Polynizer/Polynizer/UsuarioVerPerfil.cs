using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Polynizer
{
    public partial class UsuarioVerPerfil : Form
    {
        private string nombre;
        private string apellido;
        private string email;
        private string fecha;
        private string pais;

        private bool continueRunning;

        public UsuarioVerPerfil()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            llenarTBs();
            llenarListaDispositivos();

            nombre = nombreTB.Text;
            apellido = apellidoTB.Text;
            email = emailTB.Text;
            fecha = fechaNacTB.Text;
            pais = paisTB.Text;

            this.continueRunning = false;

        }

        private void llenarTBs()
        {
            SqlDataReader campoActual = Global.intermediaria.obtenerCampoEspecificoUsuario("Nombre");
            if(campoActual.Read())nombreTB.Text = Convert.ToString(campoActual.GetValue(0));
            campoActual = Global.intermediaria.obtenerCampoEspecificoUsuario("Apellido");
            if (campoActual.Read()) apellidoTB.Text = Convert.ToString(campoActual.GetValue(0));
            campoActual = Global.intermediaria.obtenerCampoEspecificoUsuario("Correo");
            if (campoActual.Read()) emailTB.Text = Convert.ToString(campoActual.GetValue(0));
            campoActual = Global.intermediaria.obtenerCampoEspecificoUsuario("FechaNac");
            if (campoActual.Read())
            {
                string fecha = Convert.ToString(campoActual.GetValue(0));
                int endIndex = fecha.IndexOf(' ');
                fecha = fecha.Substring(0, endIndex);
                fechaNacTB.Text = fecha;
            }
            campoActual = Global.intermediaria.obtenerCampoEspecificoUsuario("NombrePais");
            if (campoActual.Read()) paisTB.Text = Convert.ToString(campoActual.GetValue(0));

        }

        private void llenarListaDispositivos()
        {
            DataTable tabla = Global.intermediaria.obtenerDispositivos();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            dispositivosDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dispositivosDGV.DataSource = bindingSource;
            for (int i = 0; i < dispositivosDGV.ColumnCount; i++)
            {
                dispositivosDGV.Columns[i].Width = 162;
            }
        }

        private void regresarBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.usuarioPrincipal = new UsuarioPrincipal();
            Global.usuarioPrincipal.Show();
            this.continueRunning = true;
            this.Close();
        }

        private void UsuarioVerPerfil_Load(object sender, EventArgs e)
        {

        }

        private void editarBTN_Click(object sender, EventArgs e)
        {
            nombreTB.ReadOnly = false;
            apellidoTB.ReadOnly = false;
            emailTB.ReadOnly = false;
            fechaNacTB.Hide();
            paisTB.ReadOnly = false;

            editarBTN.Hide();
            regresarBTN.Hide();
            cancelarBTN.Show();
            guardarBTN.Show();
            fechaDTP.Show();

            MessageBox.Show("Los campos se han habilitado para edición.", "Editar Datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void cancelarBTN_Click(object sender, EventArgs e)
        {
            //Devuelvo los valores a los originales.
            nombreTB.Text = nombre;
            apellidoTB.Text = apellido;
            emailTB.Text = email;
            fechaNacTB.Text = fecha;
            paisTB.Text = pais;

            nombreTB.ReadOnly = true;
            apellidoTB.ReadOnly = true;
            emailTB.ReadOnly = true;
            fechaNacTB.Show();
            paisTB.ReadOnly = true;

            editarBTN.Show();
            regresarBTN.Show();
            cancelarBTN.Hide();
            guardarBTN.Hide();
            fechaDTP.Hide();

        }

        private void guardarBTN_Click(object sender, EventArgs e)
        {
            nombreTB.ReadOnly = true;
            apellidoTB.ReadOnly = true;
            emailTB.ReadOnly = true;
            fechaNacTB.Show();
            paisTB.ReadOnly = true;

            editarBTN.Show();
            regresarBTN.Show();
            cancelarBTN.Hide();
            guardarBTN.Hide();
            fechaDTP.Hide();

            int errores = 0;

            if(nombre != nombreTB.Text)
            {
                if (0 != Global.intermediaria.actualizarCampoUsuario("Nombre", nombreTB.Text))
                {
                    MessageBox.Show("Hubo un error cambiando el nombre", "Editar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ++errores;
                }
                else
                {
                    nombre = nombreTB.Text;
                }
            }


            if (apellido != apellidoTB.Text)
            {
                if (0 != Global.intermediaria.actualizarCampoUsuario("Apellido", apellidoTB.Text))
                {
                    MessageBox.Show("Hubo un error cambiando el apellido", "Editar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ++errores;
                }
                else
                {
                    apellido = apellidoTB.Text;
                }
            }


            if (email != emailTB.Text)
            {
                if (0 != Global.intermediaria.actualizarCampoUsuario("Correo", emailTB.Text))
                {
                    MessageBox.Show("Hubo un error cambiando el correo", "Editar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ++errores;
                }
                else
                {
                    email = emailTB.Text;
                    Global.setCorreoUsuario(email);
                }
            }


            if (fecha != fechaDTP.Value.ToString("dd/MM/yyyy"))
            {
                if (0 != Global.intermediaria.actualizarCampoUsuario("FechaNac", fechaDTP.Value.ToString("yyyy-MM-dd")))
                {
                    MessageBox.Show("Hubo un error cambiando la fecha de nacimiento.", "Editar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ++errores;
                }
                else
                {
                    SqlDataReader campoActual = Global.intermediaria.obtenerCampoEspecificoUsuario("FechaNac");
                    if (campoActual.Read())
                    {
                        string laFecha = Convert.ToString(campoActual.GetValue(0));
                        int endIndex = laFecha.IndexOf(' ');
                        laFecha = laFecha.Substring(0, endIndex);
                        fechaNacTB.Text = laFecha;
                    }
                    fecha = fechaNacTB.Text;
                }
            }


            if (pais != paisTB.Text)
            {
                if (0 != Global.intermediaria.actualizarCampoUsuario("NombrePais", paisTB.Text))
                {
                    MessageBox.Show("Hubo un error cambiando el país.", "Editar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ++errores;
                }
                else
                {
                    pais = paisTB.Text;
                }

            }

            if(errores == 0)
            {
                MessageBox.Show("Los cambios fueron guardados exitosamente.", "Editar Datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }


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
