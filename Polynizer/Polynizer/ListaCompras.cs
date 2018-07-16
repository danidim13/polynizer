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
    public partial class ListaCompras : Form
    {
        public ListaCompras()
        {
            InitializeComponent();
            this.llenarListaCompras(listaComprasDGV);
        }


        private void llenarListaCompras(DataGridView dataGridView)
        {
            DataTable tabla = Global.intermediaria.obtenerCompras();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView.DataSource = bindingSource;
            for (int i = 0; i < listaComprasDGV.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 162;
            }
        }

        private void ListaCompras_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.usuarioPrincipal.Show();
        }
    }
}
