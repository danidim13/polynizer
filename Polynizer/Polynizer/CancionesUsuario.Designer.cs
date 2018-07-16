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
            this.Buscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvCanciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(73, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mis canciones.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(75, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filtro";
            // 
            // texFiltro
            // 
            this.texFiltro.Location = new System.Drawing.Point(144, 114);
            this.texFiltro.Name = "texFiltro";
            this.texFiltro.Size = new System.Drawing.Size(180, 20);
            this.texFiltro.TabIndex = 2;
            this.texFiltro.TextChanged += new System.EventHandler(this.texFiltro_TextChanged);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(358, 114);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 3;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(696, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvCanciones
            // 
            this.dgvCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanciones.Location = new System.Drawing.Point(78, 153);
            this.dgvCanciones.Name = "dgvCanciones";
            this.dgvCanciones.Size = new System.Drawing.Size(640, 302);
            this.dgvCanciones.TabIndex = 5;
            // 
            // CancionesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.dgvCanciones);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Buscar);
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
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvCanciones;
    }
}