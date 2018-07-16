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
        ClaseIntermediaria intermediaria;

        public MetadatosCancion(string IDCancion)
        {
            InitializeComponent();
            intermediaria = new ClaseIntermediaria();
            labelID.Text = IDCancion;
            llenarTabla(IDCancion);
        }

        private void llenarTabla(string IDCancion)
        {
            DataTable tabla = intermediaria.obtenerMetadatos(IDCancion);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            dataGridViewMetadatos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridViewMetadatos.DataSource = bindingSource;
            for(int i = 0; i < dataGridViewMetadatos.ColumnCount; i++)
            {
                dataGridViewMetadatos.Columns[i].Width = 100;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelMetadatosTitle_Click(object sender, EventArgs e)
        {

        }

        private void MetadatosCancion_Load(object sender, EventArgs e)
        {

        }
    }
}
