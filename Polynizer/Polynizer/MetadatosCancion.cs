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
    public partial class MetadatosCancion : Form
    {

        /*
         * Constructor de la clase
         * Recibe el ID de la canción para la cual debe mostrar los metadatos.
         * Llena la tabla con los metadatos de la respectiva canción.
         */
        public MetadatosCancion(string IDCancion)
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            labelID.Text = IDCancion;
            llenarTabla(IDCancion);
        }

        /*Metodo utilizado para llenar la tabla con metadatos de la canción indicada.
          Recibe el ID de la canción.*/
        private void llenarTabla(string IDCancion)
        {
            DataTable tabla = Global.intermediaria.obtenerMetadatos(IDCancion);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            dataGridViewMetadatos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridViewMetadatos.DataSource = bindingSource;
            for(int i = 0; i < dataGridViewMetadatos.ColumnCount; i++)
            {
                dataGridViewMetadatos.Columns[i].Width = 100;
            }
        }

        /* Metodo que cierra la ventana al hacer click en el botón aceptar.*/
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelMetadatosTitle_Click(object sender, EventArgs e){}

        private void MetadatosCancion_Load(object sender, EventArgs e){}
    }
}
