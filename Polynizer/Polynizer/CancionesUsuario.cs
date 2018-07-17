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
        private bool continueRunning;

        public CancionesUsuario()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.continueRunning = false;
        }

        //Boton de buscar.
        private void buscarBTN_Click(object sender, EventArgs e)
        {
            Global.intermediaria.obtenerCancionesUsuario(texFiltro.Text);
            this.llenarTabla(dgvCanciones);
        }

        //Metodo para llenar el DataGridView con los datos de las canciones procesadas.

        private void llenarTabla(DataGridView dataGridView)
        {
            DataTable tabla = Global.intermediaria.obtenerCancionesUsuario(texFiltro.Text);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource  = tabla;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView.DataSource = bindingSource;

            for (int i=0;i < dgvCanciones.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 100;
            }

        }

        private void regresarBTN_Click(object sender, EventArgs e)
        {
            //Regresa a perfil
            this.Hide();
            Global.usuarioPrincipal = new UsuarioPrincipal();
            Global.usuarioPrincipal.Show();
            this.continueRunning = true;
            this.Close();
        }

        private void CancionesUsuario_Load(object sender, EventArgs e)
        {
            llenarTabla(dgvCanciones);
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
