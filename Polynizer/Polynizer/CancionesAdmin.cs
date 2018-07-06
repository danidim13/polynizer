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
    public partial class CancionesAdmin : Form
    {
        public CancionesAdmin()
        {
            InitializeComponent();
            comboBoxFiltro.Items.Add("General");
            comboBoxFiltro.Items.Add("Usuario");
            comboBoxFiltro.Items.Add("Metadato");
        }
    }
}
