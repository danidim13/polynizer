namespace Polynizer
{
    partial class UsuarioPrincipal
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonCompras = new System.Windows.Forms.Button();
            this.buttonCanciones = new System.Windows.Forms.Button();
            this.buttonProcesarCancion = new System.Windows.Forms.Button();
            this.linkLabelPerfil = new System.Windows.Forms.LinkLabel();
            this.linkLabelCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.labelTokens = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(12, 12);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(107, 29);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // buttonCompras
            // 
            this.buttonCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompras.Location = new System.Drawing.Point(12, 107);
            this.buttonCompras.Name = "buttonCompras";
            this.buttonCompras.Size = new System.Drawing.Size(521, 54);
            this.buttonCompras.TabIndex = 1;
            this.buttonCompras.Text = "Compras";
            this.buttonCompras.UseVisualStyleBackColor = true;
            // 
            // buttonCanciones
            // 
            this.buttonCanciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCanciones.Location = new System.Drawing.Point(12, 167);
            this.buttonCanciones.Name = "buttonCanciones";
            this.buttonCanciones.Size = new System.Drawing.Size(521, 54);
            this.buttonCanciones.TabIndex = 2;
            this.buttonCanciones.Text = "Mis Canciones";
            this.buttonCanciones.UseVisualStyleBackColor = true;
            // 
            // buttonProcesarCancion
            // 
            this.buttonProcesarCancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcesarCancion.Location = new System.Drawing.Point(12, 227);
            this.buttonProcesarCancion.Name = "buttonProcesarCancion";
            this.buttonProcesarCancion.Size = new System.Drawing.Size(521, 54);
            this.buttonProcesarCancion.TabIndex = 3;
            this.buttonProcesarCancion.Text = "Procesar Canción";
            this.buttonProcesarCancion.UseVisualStyleBackColor = true;
            // 
            // linkLabelPerfil
            // 
            this.linkLabelPerfil.AutoSize = true;
            this.linkLabelPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelPerfil.Location = new System.Drawing.Point(478, 12);
            this.linkLabelPerfil.Name = "linkLabelPerfil";
            this.linkLabelPerfil.Size = new System.Drawing.Size(55, 25);
            this.linkLabelPerfil.TabIndex = 4;
            this.linkLabelPerfil.TabStop = true;
            this.linkLabelPerfil.Text = "Perfil";
            // 
            // linkLabelCerrarSesion
            // 
            this.linkLabelCerrarSesion.AutoSize = true;
            this.linkLabelCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCerrarSesion.Location = new System.Drawing.Point(400, 48);
            this.linkLabelCerrarSesion.Name = "linkLabelCerrarSesion";
            this.linkLabelCerrarSesion.Size = new System.Drawing.Size(133, 25);
            this.linkLabelCerrarSesion.TabIndex = 5;
            this.linkLabelCerrarSesion.TabStop = true;
            this.linkLabelCerrarSesion.Text = "Cerrar Sesión";
            // 
            // labelTokens
            // 
            this.labelTokens.AutoSize = true;
            this.labelTokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTokens.Location = new System.Drawing.Point(17, 55);
            this.labelTokens.Name = "labelTokens";
            this.labelTokens.Size = new System.Drawing.Size(100, 20);
            this.labelTokens.TabIndex = 6;
            this.labelTokens.Text = "Tokens: ###";
            // 
            // UsuarioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 298);
            this.Controls.Add(this.labelTokens);
            this.Controls.Add(this.linkLabelCerrarSesion);
            this.Controls.Add(this.linkLabelPerfil);
            this.Controls.Add(this.buttonProcesarCancion);
            this.Controls.Add(this.buttonCanciones);
            this.Controls.Add(this.buttonCompras);
            this.Controls.Add(this.labelNombre);
            this.Name = "UsuarioPrincipal";
            this.Text = "UsuarioPrincipal";
            this.Load += new System.EventHandler(this.UsuarioPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonCompras;
        private System.Windows.Forms.Button buttonCanciones;
        private System.Windows.Forms.Button buttonProcesarCancion;
        private System.Windows.Forms.LinkLabel linkLabelPerfil;
        private System.Windows.Forms.LinkLabel linkLabelCerrarSesion;
        private System.Windows.Forms.Label labelTokens;
    }
}