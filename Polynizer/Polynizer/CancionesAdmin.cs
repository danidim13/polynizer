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

        /*
         * Costructor de la clase
         * Se inicia el comboBox del tipo de filtro, y se llena la tabla con el filtro general.
         */ 
        public CancionesAdmin()
        {
            InitializeComponent();
            comboBoxFiltro.Items.Clear();
            comboBoxFiltro.Items.Add("General");
            comboBoxFiltro.Items.Add("Correo");
            comboBoxFiltro.Items.Add("Metadato");
            comboBoxFiltro.SelectedIndex = 0;
            llenarTabla(0, null);
            llenarComboBoxMetadatos();
        }

        /*Metodo encargado de llenar la tabla de canciones dependiendo del filtro utilizado.
          Recibe: el entero tipoFiltro, este puede tener como valor 0 si se usa el filtro general, 1 si se filtra por usuario, y 2 si es por metadatos.
                  un string filtro, este es utilizado para buscar esa string en el campo correspondiente, según el tipo de filtro utilizado.*/
        private void llenarTabla(int tipoFiltro, string filtro)
        {
            DataTable tabla = Global.intermediaria.obtenerCanciones(tipoFiltro, filtro);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            dataGridViewCanciones.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridViewCanciones.DataSource = bindingSource;
            for (int i = 0; i < dataGridViewCanciones.ColumnCount; i++)
            {
                dataGridViewCanciones.Columns[i].Width = 100;
            }
        }

        /*Metodo que se utiliza para actualizar los valores del comboBox utilizado para mostrar los metadatos, este muestra la lista de IDs disponibles.*/
        private void llenarComboBoxMetadatos()
        {
            SqlDataReader datos;
            if (comboBoxFiltro.Text == "General")
            {
                datos = Global.intermediaria.obtenerListaCanciones(0, textBoxBuscar.Text);
            }
            else
            {
                if (comboBoxFiltro.Text == "Correo")
                {
                    datos = Global.intermediaria.obtenerListaCanciones(1, textBoxBuscar.Text);
                }
                else
                {
                    datos = Global.intermediaria.obtenerListaCanciones(2, textBoxBuscar.Text);
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

        /*Metodo encargado de actualizar los resultados de la tabla dependiendo del filtro seleccionado y también actualiza el comboBox con los IDs de los resultados.*/
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
                    llenarTabla(0, textBoxBuscar.Text);
                }
                else
                {
                    if(comboBoxFiltro.Text == "Correo")
                    {
                        llenarTabla(1, textBoxBuscar.Text);
                    }
                    else
                    {
                        llenarTabla(2, textBoxBuscar.Text);
                    }
                }
            }
            llenarComboBoxMetadatos();
        }

        /*Muestra la ventana con los metadatos dependiendo del ID seleccionado en el comboBox.*/
        private void buttonVerMetadatos_Click(object sender, EventArgs e)
        {
            if(comboBoxMetadato.Text == "Seleccione el ID de la canción")
            {
                MessageBox.Show("Por favor, seleccione una opción.", "Ver Metadatos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(Global.intermediaria.cantidadMetadatosCancion(comboBoxMetadato.Text) > 0)
                {
                    MetadatosCancion metadatos = new MetadatosCancion(comboBoxMetadato.Text);
                    metadatos.Show();
                }
                else
                {
                    MessageBox.Show("La canción seleccionada no tiene metadatos asociados.", "Ver Metadatos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            /*ToDo Volver a pantalla previa*/
            this.Hide();
            Global.adminPrincipal = new PincipalAdmin();
            Global.adminPrincipal.Show();
            this.Close();
        }

        private void CancionesAdmin_Load(object sender, EventArgs e){}


        /*Metodo que elimina canciones*/
        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            if (comboBoxMetadato.Text == "Seleccione el ID de la canción")
            {
                MessageBox.Show("Por favor, seleccione una opción", "Eliminar Canción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Está seguro que desea eliminar la canción " + comboBoxMetadato.Text + "?", "Eliminar Canción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool resultado = Global.intermediaria.eliminarCancion(comboBoxMetadato.Text);
                    if (resultado)
                    {
                        MessageBox.Show("Se eliminó la canción exitosamente", "Eliminar Canción", MessageBoxButtons.OK, MessageBoxIcon.None);
                        if (comboBoxFiltro.Text == "General")
                        {
                            llenarTabla(0, textBoxBuscar.Text);
                        }
                        else
                        {
                            if (comboBoxFiltro.Text == "Correo")
                            {
                                llenarTabla(1, textBoxBuscar.Text);
                            }
                            else
                            {
                                llenarTabla(2, textBoxBuscar.Text);
                            }
                        }
                        llenarComboBoxMetadatos();
                    }
                    else
                    {
                        MessageBox.Show("No se eliminó la canción debido a que esta fue procesada por un usuario", "Eliminar Canción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
