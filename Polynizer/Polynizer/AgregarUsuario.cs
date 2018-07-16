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
        ClaseIntermediaria intermediaria;
        public AgregarUsuario()
        {
            InitializeComponent();
            intermediaria = new ClaseIntermediaria();
            llenarComboBoxPais();
        }

        private void llenarComboBoxPais()
        {
            SqlDataReader paises;
            paises = intermediaria.obtenerListaPaises();
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

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            bool admin;
            DateTime day = DateTime.Today;
            if(checkBoxAdministrador.Checked)
            {
                admin = true;
            }
            else
            {
                admin = false;
            }
            /*ToDo Revisar si están vacios*/
            bool resultado = intermediaria.agregarUsuario(textBoxCorreo.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerNacimiento.Value.ToString("yyyy-MM-dd"), day.ToString("yyyy-MM-dd"), comboBoxPais.Text, textBoxContraseñaUsuario.Text, admin);
            if(resultado)
            {
                
                if(textBoxIMEI1.Text != null && textBoxIMEI1.Text != "")
                {
                    if(textBoxIMEI2.Text != null && textBoxIMEI2.Text != "")
                    {
                        intermediaria.agregarDispositivos(textBoxCorreo.Text, textBoxIMEI1.Text, textBoxIMEI2.Text);
                        MessageBox.Show("El usuario fue agregado al sistema y se guardaron 2 dispositivos", "Agregar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        intermediaria.agregarDispositivos(textBoxCorreo.Text, textBoxIMEI1.Text, null);
                        MessageBox.Show("El usuario fue agregado al sistema y se guardaró 1 dispositivo", "Agregar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El usuario fue agregado al sistema (No se guardó ningún dispositivo)", "Agregar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                textBoxCorreo.Clear();
                textBoxNombre.Clear();
                textBoxApellido.Clear();
                textBoxContraseñaUsuario.Clear();
                textBoxIMEI1.Clear();
                textBoxIMEI2.Clear();
            }
            else
            {
                MessageBox.Show("El usuario ya existe en el sistema, no se generó ningún cambio", "Agregar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            /*ToDo Volver a ventana anterior*/
        }

    }
}
