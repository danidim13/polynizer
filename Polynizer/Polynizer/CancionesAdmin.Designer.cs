namespace Polynizer
{
    partial class CancionesAdmin
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
            this.labelCancionesProc = new System.Windows.Forms.Label();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridViewCanciones = new System.Windows.Forms.DataGridView();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.labelMetadato = new System.Windows.Forms.Label();
            this.comboBoxMetadato = new System.Windows.Forms.ComboBox();
            this.buttonVerMetadatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCanciones)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCancionesProc
            // 
            this.labelCancionesProc.AutoSize = true;
            this.labelCancionesProc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCancionesProc.Location = new System.Drawing.Point(38, 42);
            this.labelCancionesProc.Name = "labelCancionesProc";
            this.labelCancionesProc.Size = new System.Drawing.Size(580, 24);
            this.labelCancionesProc.TabIndex = 0;
            this.labelCancionesProc.Text = "Canciones procesadas por los usuarios de la aplicación.";
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Location = new System.Drawing.Point(40, 107);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(53, 13);
            this.labelFiltro.TabIndex = 1;
            this.labelFiltro.Text = "Filtrar por:";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(220, 103);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(115, 20);
            this.textBoxBuscar.TabIndex = 3;
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Location = new System.Drawing.Point(100, 103);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(115, 21);
            this.comboBoxFiltro.TabIndex = 4;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(340, 101);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 5;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dataGridViewCanciones
            // 
            this.dataGridViewCanciones.AllowUserToAddRows = false;
            this.dataGridViewCanciones.AllowUserToDeleteRows = false;
            this.dataGridViewCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCanciones.Location = new System.Drawing.Point(43, 138);
            this.dataGridViewCanciones.Name = "dataGridViewCanciones";
            this.dataGridViewCanciones.ReadOnly = true;
            this.dataGridViewCanciones.Size = new System.Drawing.Size(590, 275);
            this.dataGridViewCanciones.TabIndex = 6;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(558, 442);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 7;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // labelMetadato
            // 
            this.labelMetadato.AutoSize = true;
            this.labelMetadato.Location = new System.Drawing.Point(40, 448);
            this.labelMetadato.Name = "labelMetadato";
            this.labelMetadato.Size = new System.Drawing.Size(93, 13);
            this.labelMetadato.TabIndex = 8;
            this.labelMetadato.Text = "Ver metadatos de:";
            // 
            // comboBoxMetadato
            // 
            this.comboBoxMetadato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMetadato.FormattingEnabled = true;
            this.comboBoxMetadato.Location = new System.Drawing.Point(140, 445);
            this.comboBoxMetadato.Name = "comboBoxMetadato";
            this.comboBoxMetadato.Size = new System.Drawing.Size(179, 21);
            this.comboBoxMetadato.TabIndex = 9;
            // 
            // buttonVerMetadatos
            // 
            this.buttonVerMetadatos.Location = new System.Drawing.Point(323, 443);
            this.buttonVerMetadatos.Name = "buttonVerMetadatos";
            this.buttonVerMetadatos.Size = new System.Drawing.Size(75, 23);
            this.buttonVerMetadatos.TabIndex = 10;
            this.buttonVerMetadatos.Text = "Ver";
            this.buttonVerMetadatos.UseVisualStyleBackColor = true;
            this.buttonVerMetadatos.Click += new System.EventHandler(this.buttonVerMetadatos_Click);
            // 
            // CancionesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 486);
            this.Controls.Add(this.buttonVerMetadatos);
            this.Controls.Add(this.comboBoxMetadato);
            this.Controls.Add(this.labelMetadato);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.dataGridViewCanciones);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.labelCancionesProc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CancionesAdmin";
            this.Text = "Canciones Procesadas";
            this.Load += new System.EventHandler(this.CancionesAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCanciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCancionesProc;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridViewCanciones;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label labelMetadato;
        private System.Windows.Forms.ComboBox comboBoxMetadato;
        private System.Windows.Forms.Button buttonVerMetadatos;
    }
}