﻿namespace Polynizer
{
    partial class LoginWindow
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
            this.labelTextoBienvenida = new System.Windows.Forms.Label();
            this.labelIngresarDatos = new System.Windows.Forms.Label();
            this.labelContactarAdmin = new System.Windows.Forms.Label();
            this.labelCorreoText = new System.Windows.Forms.Label();
            this.labelContraseñaText = new System.Windows.Forms.Label();
            this.textBoxCorreoUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseñaUsuario = new System.Windows.Forms.TextBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTextoBienvenida
            // 
            this.labelTextoBienvenida.AutoSize = true;
            this.labelTextoBienvenida.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelTextoBienvenida.Location = new System.Drawing.Point(44, 42);
            this.labelTextoBienvenida.Name = "labelTextoBienvenida";
            this.labelTextoBienvenida.Size = new System.Drawing.Size(605, 32);
            this.labelTextoBienvenida.TabIndex = 0;
            this.labelTextoBienvenida.Text = "Bienvenido al sistema de datos de Polynizer.";
            // 
            // labelIngresarDatos
            // 
            this.labelIngresarDatos.AutoSize = true;
            this.labelIngresarDatos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresarDatos.Location = new System.Drawing.Point(47, 102);
            this.labelIngresarDatos.Name = "labelIngresarDatos";
            this.labelIngresarDatos.Size = new System.Drawing.Size(388, 23);
            this.labelIngresarDatos.TabIndex = 1;
            this.labelIngresarDatos.Text = "Ingrese su correo de usuario y contraseña.";
            // 
            // labelContactarAdmin
            // 
            this.labelContactarAdmin.AutoSize = true;
            this.labelContactarAdmin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactarAdmin.Location = new System.Drawing.Point(15, 304);
            this.labelContactarAdmin.Name = "labelContactarAdmin";
            this.labelContactarAdmin.Size = new System.Drawing.Size(424, 16);
            this.labelContactarAdmin.TabIndex = 2;
            this.labelContactarAdmin.Text = "Para obtener una cuenta se debe contactar con un administrador.";
            // 
            // labelCorreoText
            // 
            this.labelCorreoText.AutoSize = true;
            this.labelCorreoText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreoText.Location = new System.Drawing.Point(47, 159);
            this.labelCorreoText.Name = "labelCorreoText";
            this.labelCorreoText.Size = new System.Drawing.Size(82, 24);
            this.labelCorreoText.TabIndex = 3;
            this.labelCorreoText.Text = "Correo:";
            // 
            // labelContraseñaText
            // 
            this.labelContraseñaText.AutoSize = true;
            this.labelContraseñaText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseñaText.Location = new System.Drawing.Point(47, 204);
            this.labelContraseñaText.Name = "labelContraseñaText";
            this.labelContraseñaText.Size = new System.Drawing.Size(126, 24);
            this.labelContraseñaText.TabIndex = 4;
            this.labelContraseñaText.Text = "Contraseña:";
            // 
            // textBoxCorreoUsuario
            // 
            this.textBoxCorreoUsuario.Location = new System.Drawing.Point(189, 159);
            this.textBoxCorreoUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCorreoUsuario.Name = "textBoxCorreoUsuario";
            this.textBoxCorreoUsuario.Size = new System.Drawing.Size(459, 22);
            this.textBoxCorreoUsuario.TabIndex = 5;
            // 
            // textBoxContraseñaUsuario
            // 
            this.textBoxContraseñaUsuario.Location = new System.Drawing.Point(189, 204);
            this.textBoxContraseñaUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxContraseñaUsuario.Name = "textBoxContraseñaUsuario";
            this.textBoxContraseñaUsuario.Size = new System.Drawing.Size(459, 22);
            this.textBoxContraseñaUsuario.TabIndex = 6;
            this.textBoxContraseñaUsuario.UseSystemPasswordChar = true;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(442, 267);
            this.buttonIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(100, 28);
            this.buttonIngresar.TabIndex = 7;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(549, 267);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(99, 28);
            this.buttonCerrar.TabIndex = 8;
            this.buttonCerrar.Text = "Salir";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 332);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.textBoxContraseñaUsuario);
            this.Controls.Add(this.textBoxCorreoUsuario);
            this.Controls.Add(this.labelContraseñaText);
            this.Controls.Add(this.labelCorreoText);
            this.Controls.Add(this.labelContactarAdmin);
            this.Controls.Add(this.labelIngresarDatos);
            this.Controls.Add(this.labelTextoBienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "LoginWindow";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextoBienvenida;
        private System.Windows.Forms.Label labelIngresarDatos;
        private System.Windows.Forms.Label labelContactarAdmin;
        private System.Windows.Forms.Label labelCorreoText;
        private System.Windows.Forms.Label labelContraseñaText;
        private System.Windows.Forms.TextBox textBoxCorreoUsuario;
        private System.Windows.Forms.TextBox textBoxContraseñaUsuario;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Button buttonCerrar;

    }
}

