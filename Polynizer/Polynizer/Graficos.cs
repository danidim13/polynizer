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
    public partial class Graficos : Form
    {
        private bool continueRunning;

        private string[] xNombres = { };
        private int[] yValues = { };

        public Graficos()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.continueRunning = false;
            //this.Graficar();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.adminPrincipal = new PincipalAdmin();
            Global.adminPrincipal.Show();
            this.continueRunning = true;
            this.Close();
        }

        private void Graficos_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!this.continueRunning)
            {
                Global.ConfirmExit(ref e);
            }
        }

        private void comboBoxCharts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxCharts.SelectedIndex == 0)
            {
                var table = Global.intermediaria.obtenerCancionesPorUsuario();

                this.xNombres = new string[table.Rows.Count];
                this.yValues = new int[table.Rows.Count];

                int i = 0;
                foreach (DataRow row in table.Rows)
                {
                    this.xNombres[i] = row[0].ToString();
                    this.yValues[i] = Convert.ToInt32(row[1]);
                    i++;
                }
            }
            this.Graficar();
        }

        private void Graficar()
        {
            this.chart1.Series.Clear();

            for (int i = 0; i < this.xNombres.Length; i++)
            {
                var series = this.chart1.Series.Add(this.xNombres[i]);
                series.Points.Add(this.yValues[i]);
            }
            
        }
    }
}
