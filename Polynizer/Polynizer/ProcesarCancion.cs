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
    public partial class ProcesaCancion :Form
    {
        public ProcesaCancion()
        {
            //InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            byte esLink;
            //if (mp3.Checked)
            //{
            //    esLink = 0;
            //}
            //else if (link.Checked)
            //{
            //    esLink = 1;
            //}
            //procesaCancion(textoCancion.Text, esLink);

        }



        private void cancelar_Click(object sender, EventArgs e)
        {
            //Aqui se devuelve a la ventana de compras que aun no está implementada.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
