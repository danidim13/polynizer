﻿using System;
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
        ClaseIntermediaria intermediaria;
        public ListaCompras()
        {
            InitializeComponent();
            intermediaria = new ClaseIntermediaria();
            this.llenarListaCompras(listaComprasDGV);
        }


        private void llenarListaCompras(DataGridView dataGridView)
        {
            DataTable tabla = intermediaria.obtenerCompras();
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
    }
}
