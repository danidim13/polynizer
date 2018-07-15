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
            this.buttonAceptar = new System.Windows.Forms.Button();
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
            this.dataGridViewMetadatos.Location = new System.Drawing.Point(26, 96);
            this.dataGridViewMetadatos.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMetadatos.Name = "dataGridViewMetadatos";
            this.dataGridViewMetadatos.ReadOnly = true;
            this.dataGridViewMetadatos.Size = new System.Drawing.Size(333, 388);
            this.dataGridViewMetadatos.TabIndex = 7;
            // 
            // labelMetadatosTitle
            // 
            this.labelMetadatosTitle.AutoSize = true;
            this.labelMetadatosTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetadatosTitle.Location = new System.Drawing.Point(20, 27);
            this.labelMetadatosTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMetadatosTitle.Name = "labelMetadatosTitle";
            this.labelMetadatosTitle.Size = new System.Drawing.Size(339, 32);
            this.labelMetadatosTitle.TabIndex = 8;
            this.labelMetadatosTitle.Text = "Metadatos de la canción.";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(259, 502);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(100, 28);
            this.buttonAceptar.TabIndex = 9;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // labelNumeroID
            // 
            this.labelNumeroID.AutoSize = true;
            this.labelNumeroID.Location = new System.Drawing.Point(23, 71);
            this.labelNumeroID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumeroID.Name = "labelNumeroID";
            this.labelNumeroID.Size = new System.Drawing.Size(99, 17);
            this.labelNumeroID.TabIndex = 10;
            this.labelNumeroID.Text = "Número de ID:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(130, 71);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(12, 17);
            this.labelID.TabIndex = 11;
            this.labelID.Text = ".";
            // 
            // MetadatosCancion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 551);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelNumeroID);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.labelMetadatosTitle);
            this.Controls.Add(this.dataGridViewMetadatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MetadatosCancion";
            this.Text = "Metadatos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMetadatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMetadatos;
        private System.Windows.Forms.Label labelMetadatosTitle;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label labelNumeroID;
        private System.Windows.Forms.Label labelID;
    }
}