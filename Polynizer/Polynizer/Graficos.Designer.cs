namespace Polynizer
{
    partial class Graficos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboBoxCharts = new System.Windows.Forms.ComboBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCharts
            // 
            this.comboBoxCharts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCharts.FormattingEnabled = true;
            this.comboBoxCharts.Items.AddRange(new object[] {
            "Canciones procesadas por usuario"});
            this.comboBoxCharts.Location = new System.Drawing.Point(50, 64);
            this.comboBoxCharts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCharts.Name = "comboBoxCharts";
            this.comboBoxCharts.Size = new System.Drawing.Size(247, 21);
            this.comboBoxCharts.TabIndex = 0;
            this.comboBoxCharts.SelectedIndexChanged += new System.EventHandler(this.comboBoxCharts_SelectedIndexChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(46, 18);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(101, 26);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Gráficos";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(50, 97);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(478, 206);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresar.Location = new System.Drawing.Point(446, 320);
            this.buttonRegresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(81, 26);
            this.buttonRegresar.TabIndex = 4;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // buttonExportar
            // 
            this.buttonExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportar.Location = new System.Drawing.Point(344, 320);
            this.buttonExportar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(81, 26);
            this.buttonExportar.TabIndex = 5;
            this.buttonExportar.Text = "Exportar";
            this.buttonExportar.UseVisualStyleBackColor = true;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // Graficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 366);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.comboBoxCharts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Graficos";
            this.Text = "Graficos";
            this.Load += new System.EventHandler(this.Graficos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCharts;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.Button buttonExportar;
    }
}