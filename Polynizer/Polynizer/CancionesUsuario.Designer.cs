namespace Polynizer
{
    partial class CancionesUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texFiltro = new System.Windows.Forms.TextBox();
            this.buscarBTN = new System.Windows.Forms.Button();
            this.regresarBTN = new System.Windows.Forms.Button();
            this.dgvCanciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mis canciones.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filtro:";
            // 
            // texFiltro
            // 
            this.texFiltro.Location = new System.Drawing.Point(61, 106);
            this.texFiltro.Name = "texFiltro";
            this.texFiltro.Size = new System.Drawing.Size(180, 20);
            this.texFiltro.TabIndex = 2;
            // 
            // buscarBTN
            // 
            this.buscarBTN.Location = new System.Drawing.Point(260, 104);
            this.buscarBTN.Name = "buscarBTN";
            this.buscarBTN.Size = new System.Drawing.Size(75, 23);
            this.buscarBTN.TabIndex = 3;
            this.buscarBTN.Text = "Buscar";
            this.buscarBTN.UseVisualStyleBackColor = true;
            this.buscarBTN.Click += new System.EventHandler(this.buscarBTN_Click);
            // 
            // regresarBTN
            // 
            this.regresarBTN.Location = new System.Drawing.Point(577, 474);
            this.regresarBTN.Name = "regresarBTN";
            this.regresarBTN.Size = new System.Drawing.Size(75, 23);
            this.regresarBTN.TabIndex = 4;
            this.regresarBTN.Text = "Regresar";
            this.regresarBTN.UseVisualStyleBackColor = true;
            this.regresarBTN.Click += new System.EventHandler(this.regresarBTN_Click);
            // 
            // dgvCanciones
            // 
            this.dgvCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanciones.Location = new System.Drawing.Point(12, 145);
            this.dgvCanciones.Name = "dgvCanciones";
            this.dgvCanciones.ReadOnly = true;
            this.dgvCanciones.Size = new System.Drawing.Size(640, 302);
            this.dgvCanciones.TabIndex = 5;
            // 
            // CancionesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 532);
            this.Controls.Add(this.dgvCanciones);
            this.Controls.Add(this.regresarBTN);
            this.Controls.Add(this.buscarBTN);
            this.Controls.Add(this.texFiltro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CancionesUsuario";
            this.Text = "Canciones usuario";
            this.Load += new System.EventHandler(this.CancionesUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texFiltro;
        private System.Windows.Forms.Button buscarBTN;
        private System.Windows.Forms.Button regresarBTN;
        private System.Windows.Forms.DataGridView dgvCanciones;
    }
}