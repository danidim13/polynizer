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
    public partial class AgregarUsuario : Form
    {

        /*
         * Constructor de la clase
         */
        public AgregarUsuario()
        {
            InitializeComponent();
            llenarComboBoxPais();
        }

        /*Metodo utilizado para que en el comboBox para seleccionar país se desplieguen todos los países existentes*/
        private void llenarComboBoxPais()
        {
            SqlDataReader paises;
            paises = Global.intermediaria.obtenerListaPaises();
            if (paises != null)
            {
                comboBoxPais.Items.Clear();
                comboBoxPais.Items.Add("Seleccione");
                while (paises.Read())
                {
                    comboBoxPais.Items.Add(paises.GetValue(0));
                }
            }
            else
            {
                comboBoxPais.Items.Clear();
                comboBoxPais.Items.Add("Mal");
            }
            comboBoxPais.SelectedIndex = 0;
        }

        /*Metodo utilizado para que al presionar el botón guardar se revise si la información ingresada es correcta y se guarde en la base de datos*/
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            bool admin;
            DateTime day = DateTime.Today;
            if (checkBoxAdministrador.Checked)
            {
                admin = true;
            }
            else
            {
                admin = false;
            }
            if (textBoxCorreo.Text == "" || textBoxNombre.Text == "" || textBoxApellido.Text == "" || comboBoxPais.Text == "Seleccione" || textBoxContraseñaUsuario.Text == "")
            {
                MessageBox.Show("Por favor ingresar todos los datos del usuario", "Agregar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool resultado = Global.intermediaria.agregarUsuario(textBoxCorreo.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerNacimiento.Value.ToString("yyyy-MM-dd"), day.ToString("yyyy-MM-dd"), comboBoxPais.Text, textBoxContraseñaUsuario.Text, admin);
                if (resultado)
                {
                    MessageBox.Show("El usuario fue agregado al sistema", "Agregar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxCorreo.Clear();
                    textBoxNombre.Clear();
                    textBoxApellido.Clear();
                    textBoxContraseñaUsuario.Clear();
                    comboBoxPais.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("El usuario ya existe en el sistema, no se generó ningún cambio", "Agregar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /*Metodo para volver a la pantalla anterior luego de presionar el botón cancelar*/
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            /*ToDo Volver a ventana anterior*/
            Global.adminListaUsuarios = new ListaUsuarios();
            Global.adminListaUsuarios.Show();
            this.Close();
        }

        private void labelAgregarUsuario_Click(object sender, EventArgs e)
        {
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
        }
    }
}
