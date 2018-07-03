namespace Polynizer
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
            this.SuspendLayout();
            // 
            // labelTextoBienvenida
            // 
            this.labelTextoBienvenida.AutoSize = true;
            this.labelTextoBienvenida.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextoBienvenida.Location = new System.Drawing.Point(50, 53);
            this.labelTextoBienvenida.Name = "labelTextoBienvenida";
            this.labelTextoBienvenida.Size = new System.Drawing.Size(699, 37);
            this.labelTextoBienvenida.TabIndex = 0;
            this.labelTextoBienvenida.Text = "Bienvenido al sistema de datos de Polynizer.";
            // 
            // labelIngresarDatos
            // 
            this.labelIngresarDatos.AutoSize = true;
            this.labelIngresarDatos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresarDatos.Location = new System.Drawing.Point(52, 127);
            this.labelIngresarDatos.Name = "labelIngresarDatos";
            this.labelIngresarDatos.Size = new System.Drawing.Size(471, 27);
            this.labelIngresarDatos.TabIndex = 1;
            this.labelIngresarDatos.Text = "Ingrese su correo de usuario y contraseña.";
            // 
            // labelContactarAdmin
            // 
            this.labelContactarAdmin.AutoSize = true;
            this.labelContactarAdmin.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactarAdmin.Location = new System.Drawing.Point(54, 351);
            this.labelContactarAdmin.Name = "labelContactarAdmin";
            this.labelContactarAdmin.Size = new System.Drawing.Size(459, 18);
            this.labelContactarAdmin.TabIndex = 2;
            this.labelContactarAdmin.Text = "Para obtener una cuenta se debe contactar con un administrador.";
            // 
            // labelCorreoText
            // 
            this.labelCorreoText.AutoSize = true;
            this.labelCorreoText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreoText.Location = new System.Drawing.Point(52, 199);
            this.labelCorreoText.Name = "labelCorreoText";
            this.labelCorreoText.Size = new System.Drawing.Size(98, 29);
            this.labelCorreoText.TabIndex = 3;
            this.labelCorreoText.Text = "Correo:";
            // 
            // labelContraseñaText
            // 
            this.labelContraseñaText.AutoSize = true;
            this.labelContraseñaText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseñaText.Location = new System.Drawing.Point(52, 256);
            this.labelContraseñaText.Name = "labelContraseñaText";
            this.labelContraseñaText.Size = new System.Drawing.Size(151, 29);
            this.labelContraseñaText.TabIndex = 4;
            this.labelContraseñaText.Text = "Contraseña:";
            // 
            // textBoxCorreoUsuario
            // 
            this.textBoxCorreoUsuario.Location = new System.Drawing.Point(213, 199);
            this.textBoxCorreoUsuario.Name = "textBoxCorreoUsuario";
            this.textBoxCorreoUsuario.Size = new System.Drawing.Size(515, 26);
            this.textBoxCorreoUsuario.TabIndex = 5;
            // 
            // textBoxContraseñaUsuario
            // 
            this.textBoxContraseñaUsuario.Location = new System.Drawing.Point(213, 256);
            this.textBoxContraseñaUsuario.Name = "textBoxContraseñaUsuario";
            this.textBoxContraseñaUsuario.Size = new System.Drawing.Size(515, 26);
            this.textBoxContraseñaUsuario.TabIndex = 6;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 419);
            this.Controls.Add(this.textBoxContraseñaUsuario);
            this.Controls.Add(this.textBoxCorreoUsuario);
            this.Controls.Add(this.labelContraseñaText);
            this.Controls.Add(this.labelCorreoText);
            this.Controls.Add(this.labelContactarAdmin);
            this.Controls.Add(this.labelIngresarDatos);
            this.Controls.Add(this.labelTextoBienvenida);
            this.Name = "LoginWindow";
            this.Text = "Login";
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
    }
}

