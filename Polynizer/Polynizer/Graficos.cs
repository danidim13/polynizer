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
    public partial class Graficos : Form
    {
        public Graficos()
        {
            InitializeComponent();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.adminPrincipal = new PincipalAdmin();
            Global.adminPrincipal.Show();
            this.Close();
        }

        private void Graficos_Load(object sender, EventArgs e)
        {

        }
    }
}
