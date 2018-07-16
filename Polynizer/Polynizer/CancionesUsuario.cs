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
    public partial class CancionesUsuario : Form
    {
        ClaseIntermediaria claseInter;
        public CancionesUsuario()
        {
            InitializeComponent();
            claseInter = new ClaseIntermediaria();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Boton de buscar.
        private void button1_Click(object sender, EventArgs e)
        {
            claseInter.obtenerCancionesUsuario(texFiltro.Text);
            this.llenarTabla(dgvCanciones);
        }

        //Metodo para llenar el DataGridView con los datos de las canciones procesadas.

        private void llenarTabla(DataGridView dataGridView)
        {
            DataTable tabla = claseInter.obtenerCancionesUsuario(texFiltro.Text);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource  = tabla;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView.DataSource = bindingSource;

            for (int i=0;i < dgvCanciones.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 100;
            }

        }

        private void texFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Regresa a perfil
        }

        private void CancionesUsuario_Load(object sender, EventArgs e)
        {
            llenarTabla(dgvCanciones);
        }
    }

}
