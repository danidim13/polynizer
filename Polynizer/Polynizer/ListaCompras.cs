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
        private bool continueRunning;

        public ListaCompras()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.llenarListaCompras();
            this.continueRunning = false;
        }


        private void llenarListaCompras()
        {
            DataTable tabla = Global.intermediaria.obtenerCompras();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            listaComprasDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            listaComprasDGV.DataSource = bindingSource;
            for (int i = 0; i < listaComprasDGV.ColumnCount; i++)
            {
                listaComprasDGV.Columns[i].Width = 162;
            }
        }

        private void ListaCompras_Load(object sender, EventArgs e)
        {

        }

        private void regresarBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.usuarioPrincipal = new UsuarioPrincipal();
            Global.usuarioPrincipal.Show();
            this.continueRunning = true;
            this.Close();
        }

        private void comprarTokensLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Global.usuarioComprarTokens = new ComprarTokens();
            Global.usuarioComprarTokens.Show();
            this.continueRunning = true;
            this.Close();
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
