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
                //var table = Global.intermediaria.obtenerCancionesPorUsuario();
            }
            this.Graficar();
        }

        private void Graficar()
        {
            this.chart1.Series.Clear();
            var serie1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Canciones",
                //Color = System.Drawing.Color.Blue,
                //IsXValueIndexed = true,
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
            };

            //this.chart1.Series.Add(serie1);

            string[] nombres = { "user1", "user2" };
            int[] canciones = { 5, 6 };

            for (int i = 0; i < nombres.Length; i++)
            {
                var series = this.chart1.Series.Add(nombres[i]);
                series.Points.Add(canciones[i]);
            }
            
        }
    }
}
