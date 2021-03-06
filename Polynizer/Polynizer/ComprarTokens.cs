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
    public partial class ComprarTokens : Form
    {
        private bool continueRunning;

        public ComprarTokens()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.continueRunning = false;
        }

        private void comprarBTN_Click(object sender, EventArgs e)
        {
            if (numTokensTB.Text == "")
            {
                MessageBox.Show("Por favor, introduzca la cantidad de tokens que desea comprar.", "Comprar Tokens", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int i;
                if (!int.TryParse(numTokensTB.Text, out i))
                {
                    MessageBox.Show("Debe ingresar un número entero.", "ComprarTokens", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (i > 0)
                {
                    if (MessageBox.Show("Está seguro que desea comprar " + i + " tokens?", "Comprar Tokens", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (0 == Global.intermediaria.comprarTokens(i))
                        {
                            MessageBox.Show("¡Su compra fue exitosa!", "Comprar Tokens", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Hide();
                            Global.usuarioCompras = new ListaCompras();
                            Global.usuarioCompras.Show();
                            this.continueRunning = true;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error al procesar su compra.", "Comprar Tokens", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe ser un monto mayor que cero.", "ComprarTokens", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }

        private void regresarBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.usuarioCompras = new ListaCompras();
            Global.usuarioCompras.Show();
            this.continueRunning = true;
            this.Close();
        }

        private void ComprarTokens_Load(object sender, EventArgs e)
        {

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
