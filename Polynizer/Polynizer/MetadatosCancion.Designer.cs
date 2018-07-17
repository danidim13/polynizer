namespace Polynizer
{
    partial class MetadatosCancion
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
            this.dataGridViewMetadatos = new System.Windows.Forms.DataGridView();
            this.labelMetadatosTitle = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.labelNumeroID = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMetadatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMetadatos
            // 
            this.dataGridViewMetadatos.AllowUserToAddRows = false;
            this.dataGridViewMetadatos.AllowUserToDeleteRows = false;
            this.dataGridViewMetadatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMetadatos.Location = new System.Drawing.Point(20, 86);
            this.dataGridViewMetadatos.Name = "dataGridViewMetadatos";
            this.dataGridViewMetadatos.ReadOnly = true;
            this.dataGridViewMetadatos.Size = new System.Drawing.Size(250, 307);
            this.dataGridViewMetadatos.TabIndex = 7;
            // 
            // labelMetadatosTitle
            // 
            this.labelMetadatosTitle.AutoSize = true;
            this.labelMetadatosTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetadatosTitle.Location = new System.Drawing.Point(15, 22);
            this.labelMetadatosTitle.Name = "labelMetadatosTitle";
            this.labelMetadatosTitle.Size = new System.Drawing.Size(261, 24);
            this.labelMetadatosTitle.TabIndex = 8;
            this.labelMetadatosTitle.Text = "Metadatos de la canción.";
            this.labelMetadatosTitle.Click += new System.EventHandler(this.labelMetadatosTitle_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(194, 408);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrar.TabIndex = 9;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // labelNumeroID
            // 
            this.labelNumeroID.AutoSize = true;
            this.labelNumeroID.Location = new System.Drawing.Point(17, 56);
            this.labelNumeroID.Name = "labelNumeroID";
            this.labelNumeroID.Size = new System.Drawing.Size(76, 13);
            this.labelNumeroID.TabIndex = 10;
            this.labelNumeroID.Text = "Número de ID:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(98, 56);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(10, 13);
            this.labelID.TabIndex = 11;
            this.labelID.Text = ".";
            // 
            // MetadatosCancion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 448);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelNumeroID);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.labelMetadatosTitle);
            this.Controls.Add(this.dataGridViewMetadatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MetadatosCancion";
            this.Text = "Metadatos";
            this.Load += new System.EventHandler(this.MetadatosCancion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMetadatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMetadatos;
        private System.Windows.Forms.Label labelMetadatosTitle;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Label labelNumeroID;
        private System.Windows.Forms.Label labelID;
    }
}