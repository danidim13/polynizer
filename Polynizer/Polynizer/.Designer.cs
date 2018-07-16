namespace Polynizer
{
    partial class ProcesaCancion
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
            this.mp3 = new System.Windows.Forms.RadioButton();
            this.link = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textoCancion = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mp3
            // 
            this.mp3.AutoSize = true;
            this.mp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mp3.Location = new System.Drawing.Point(116, 116);
            this.mp3.Name = "mp3";
            this.mp3.Size = new System.Drawing.Size(59, 24);
            this.mp3.TabIndex = 0;
            this.mp3.TabStop = true;
            this.mp3.Text = "MP3";
            this.mp3.UseVisualStyleBackColor = true;
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.link.Location = new System.Drawing.Point(116, 165);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(56, 24);
            this.link.TabIndex = 1;
            this.link.TabStop = true;
            this.link.Text = "Link";
            this.link.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(57, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Procesar canción.";
            // 
            // textoCancion
            // 
            this.textoCancion.Location = new System.Drawing.Point(116, 224);
            this.textoCancion.Name = "textoCancion";
            this.textoCancion.Size = new System.Drawing.Size(333, 20);
            this.textoCancion.TabIndex = 3;
            this.textoCancion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(565, 402);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 4;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(676, 402);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 5;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // ProcesaCancion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.textoCancion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.link);
            this.Controls.Add(this.mp3);
            this.Name = "ProcesaCancion";
            this.Text = "Procesar canción";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton mp3;
        private System.Windows.Forms.RadioButton link;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoCancion;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button cancelar;
    }
}