﻿namespace Polynizer
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
            this.labelNombre.Location = new System.Drawing.Point(9, 10);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(85, 24);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // buttonCompras
            // 
            this.buttonCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompras.Location = new System.Drawing.Point(9, 87);
            this.buttonCompras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCompras.Name = "buttonCompras";
            this.buttonCompras.Size = new System.Drawing.Size(391, 44);
            this.buttonCompras.TabIndex = 1;
            this.buttonCompras.Text = "Compras";
            this.buttonCompras.UseVisualStyleBackColor = true;
            this.buttonCompras.Click += new System.EventHandler(this.buttonCompras_Click);
            // 
            // buttonCanciones
            // 
            this.buttonCanciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCanciones.Location = new System.Drawing.Point(9, 136);
            this.buttonCanciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCanciones.Name = "buttonCanciones";
            this.buttonCanciones.Size = new System.Drawing.Size(391, 44);
            this.buttonCanciones.TabIndex = 2;
            this.buttonCanciones.Text = "Mis Canciones";
            this.buttonCanciones.UseVisualStyleBackColor = true;
            this.buttonCanciones.Click += new System.EventHandler(this.buttonCanciones_Click);
            // 
            // buttonProcesarCancion
            // 
            this.buttonProcesarCancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcesarCancion.Location = new System.Drawing.Point(9, 184);
            this.buttonProcesarCancion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonProcesarCancion.Name = "buttonProcesarCancion";
            this.buttonProcesarCancion.Size = new System.Drawing.Size(391, 44);
            this.buttonProcesarCancion.TabIndex = 3;
            this.buttonProcesarCancion.Text = "Procesar Canción";
            this.buttonProcesarCancion.UseVisualStyleBackColor = true;
            this.buttonProcesarCancion.Click += new System.EventHandler(this.buttonProcesarCancion_Click);
            // 
            // linkLabelPerfil
            // 
            this.linkLabelPerfil.AutoSize = true;
            this.linkLabelPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelPerfil.Location = new System.Drawing.Point(358, 10);
            this.linkLabelPerfil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelPerfil.Name = "linkLabelPerfil";
            this.linkLabelPerfil.Size = new System.Drawing.Size(44, 20);
            this.linkLabelPerfil.TabIndex = 4;
            this.linkLabelPerfil.TabStop = true;
            this.linkLabelPerfil.Text = "Perfil";
            this.linkLabelPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPerfil_LinkClicked);
            // 
            // linkLabelCerrarSesion
            // 
            this.linkLabelCerrarSesion.AutoSize = true;
            this.linkLabelCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCerrarSesion.Location = new System.Drawing.Point(300, 39);
            this.linkLabelCerrarSesion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelCerrarSesion.Name = "linkLabelCerrarSesion";
            this.linkLabelCerrarSesion.Size = new System.Drawing.Size(106, 20);
            this.linkLabelCerrarSesion.TabIndex = 5;
            this.linkLabelCerrarSesion.TabStop = true;
            this.linkLabelCerrarSesion.Text = "Cerrar Sesión";
            this.linkLabelCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCerrarSesion_LinkClicked);
            // 
            // labelTokens
            // 
            this.labelTokens.AutoSize = true;
            this.labelTokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTokens.Location = new System.Drawing.Point(13, 45);
            this.labelTokens.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTokens.Name = "labelTokens";
            this.labelTokens.Size = new System.Drawing.Size(87, 17);
            this.labelTokens.TabIndex = 6;
            this.labelTokens.Text = "Tokens: ###";
            // 
            // UsuarioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 242);
            this.Controls.Add(this.labelTokens);
            this.Controls.Add(this.linkLabelCerrarSesion);
            this.Controls.Add(this.linkLabelPerfil);
            this.Controls.Add(this.buttonProcesarCancion);
            this.Controls.Add(this.buttonCanciones);
            this.Controls.Add(this.buttonCompras);
            this.Controls.Add(this.labelNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
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

        private int tokens;
    }
}