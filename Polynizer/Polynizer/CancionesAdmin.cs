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
    public partial class CancionesAdmin : Form
    {
        ClaseIntermediaria intermediaria;

        public CancionesAdmin()
        {
            InitializeComponent();
            intermediaria = new ClaseIntermediaria();
            comboBoxFiltro.Items.Clear();
            comboBoxFiltro.Items.Add("General");
            comboBoxFiltro.Items.Add("Correo");
            comboBoxFiltro.Items.Add("Metadato");
            comboBoxFiltro.SelectedIndex = 0;
            llenarTabla(dataGridViewCanciones, 0, null);
            llenarComboBoxMetadatos();
        }

        private void llenarTabla(DataGridView dataGridView, int tipoFiltro, string filtro)
        {
            DataTable tabla = intermediaria.obtenerCanciones(tipoFiltro, filtro);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView.DataSource = bindingSource;
            for (int i = 0; i < dataGridViewCanciones.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 100;
            }
        }

        private void llenarComboBoxMetadatos()
        {
            SqlDataReader datos;
            if (comboBoxFiltro.Text == "General")
            {
                datos = intermediaria.obtenerListaCanciones(0, textBoxBuscar.Text);
            }
            else
            {
                if (comboBoxFiltro.Text == "Correo")
                {
                    datos = intermediaria.obtenerListaCanciones(1, textBoxBuscar.Text);
                }
                else
                {
                    datos = intermediaria.obtenerListaCanciones(2, textBoxBuscar.Text);
                }
            }

            if(datos != null)
            {
                comboBoxMetadato.Items.Clear();
                comboBoxMetadato.Items.Add("Seleccione el ID de la canción");
                while (datos.Read())
                {
                    comboBoxMetadato.Items.Add(datos.GetValue(0));
                }
            }
            else
            {
                comboBoxMetadato.Items.Clear();
                comboBoxMetadato.Items.Add("Seleccione el ID de la canción");
            }
            comboBoxMetadato.SelectedIndex = 0;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text == "" && comboBoxFiltro.Text != "General")
            {
                MessageBox.Show("Por favor, introduzca los datos para la búsqueda", "Busqueda Canciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(comboBoxFiltro.Text == "General")
                {
                    llenarTabla(dataGridViewCanciones, 0, textBoxBuscar.Text);
                }
                else
                {
                    if(comboBoxFiltro.Text == "Correo")
                    {
                        llenarTabla(dataGridViewCanciones, 1, textBoxBuscar.Text);
                    }
                    else
                    {
                        llenarTabla(dataGridViewCanciones, 2, textBoxBuscar.Text);
                    }
                }
            }
            llenarComboBoxMetadatos();
        }

        private void buttonVerMetadatos_Click(object sender, EventArgs e)
        {
            if(comboBoxMetadato.Text == "Seleccione el ID de la canción")
            {
                MessageBox.Show("Por favor, seleccione una opción", "Ver Metadatos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MetadatosCancion metadatos = new MetadatosCancion(comboBoxMetadato.Text);//,controladorAplicacion);
                metadatos.Show();
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            /*ToDo Volver a pantalla previa*/
        }

        private void CancionesAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
