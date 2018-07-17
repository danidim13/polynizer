namespace Polynizer
{
    partial class AgregarUsuario
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
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.labelPaís = new System.Windows.Forms.Label();
            this.labelAgregarUsuario = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelIndicaciones = new System.Windows.Forms.Label();
            this.dateTimePickerNacimiento = new System.Windows.Forms.DateTimePicker();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.checkBoxAdministrador = new System.Windows.Forms.CheckBox();
            this.labelContraseñaText = new System.Windows.Forms.Label();
            this.textBoxContraseñaUsuario = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(46, 133);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(64, 18);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.Location = new System.Drawing.Point(398, 133);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(57, 18);
            this.labelCorreo.TabIndex = 1;
            this.labelCorreo.Text = "Correo";
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaNacimiento.Location = new System.Drawing.Point(46, 193);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(154, 18);
            this.labelFechaNacimiento.TabIndex = 2;
            this.labelFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // labelPaís
            // 
            this.labelPaís.AutoSize = true;
            this.labelPaís.Font = new System.Drawing.Font("Arial", 12F);
            this.labelPaís.Location = new System.Drawing.Point(46, 251);
            this.labelPaís.Name = "labelPaís";
            this.labelPaís.Size = new System.Drawing.Size(39, 18);
            this.labelPaís.TabIndex = 3;
            this.labelPaís.Text = "País";
            // 
            // labelAgregarUsuario
            // 
            this.labelAgregarUsuario.AutoSize = true;
            this.labelAgregarUsuario.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgregarUsuario.Location = new System.Drawing.Point(45, 43);
            this.labelAgregarUsuario.Name = "labelAgregarUsuario";
            this.labelAgregarUsuario.Size = new System.Drawing.Size(223, 24);
            this.labelAgregarUsuario.TabIndex = 5;
            this.labelAgregarUsuario.Text = "Agregar a un usuario";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(49, 154);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(112, 20);
            this.textBoxNombre.TabIndex = 6;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(401, 154);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(244, 20);
            this.textBoxCorreo.TabIndex = 7;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(598, 346);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 10;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // labelIndicaciones
            // 
            this.labelIndicaciones.AutoSize = true;
            this.labelIndicaciones.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndicaciones.Location = new System.Drawing.Point(46, 76);
            this.labelIndicaciones.Name = "labelIndicaciones";
            this.labelIndicaciones.Size = new System.Drawing.Size(262, 16);
            this.labelIndicaciones.TabIndex = 12;
            this.labelIndicaciones.Text = "Ingrese la información del usuario a agregar.";
            // 
            // dateTimePickerNacimiento
            // 
            this.dateTimePickerNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNacimiento.Location = new System.Drawing.Point(49, 214);
            this.dateTimePickerNacimiento.Name = "dateTimePickerNacimiento";
            this.dateTimePickerNacimiento.Size = new System.Drawing.Size(244, 20);
            this.dateTimePickerNacimiento.TabIndex = 17;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(501, 346);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 18;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.Location = new System.Drawing.Point(50, 275);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(244, 21);
            this.comboBoxPais.TabIndex = 19;
            // 
            // checkBoxAdministrador
            // 
            this.checkBoxAdministrador.AutoSize = true;
            this.checkBoxAdministrador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdministrador.Location = new System.Drawing.Point(401, 275);
            this.checkBoxAdministrador.Name = "checkBoxAdministrador";
            this.checkBoxAdministrador.Size = new System.Drawing.Size(222, 22);
            this.checkBoxAdministrador.TabIndex = 20;
            this.checkBoxAdministrador.Text = "Privilegios de administrador";
            this.checkBoxAdministrador.UseVisualStyleBackColor = true;
            // 
            // labelContraseñaText
            // 
            this.labelContraseñaText.AutoSize = true;
            this.labelContraseñaText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseñaText.Location = new System.Drawing.Point(398, 193);
            this.labelContraseñaText.Name = "labelContraseñaText";
            this.labelContraseñaText.Size = new System.Drawing.Size(89, 18);
            this.labelContraseñaText.TabIndex = 21;
            this.labelContraseñaText.Text = "Contraseña";
            // 
            // textBoxContraseñaUsuario
            // 
            this.textBoxContraseñaUsuario.Location = new System.Drawing.Point(401, 225);
            this.textBoxContraseñaUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxContraseñaUsuario.Name = "textBoxContraseñaUsuario";
            this.textBoxContraseñaUsuario.Size = new System.Drawing.Size(244, 20);
            this.textBoxContraseñaUsuario.TabIndex = 22;
            this.textBoxContraseñaUsuario.UseSystemPasswordChar = true;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(181, 154);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(112, 20);
            this.textBoxApellido.TabIndex = 23;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(178, 133);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(65, 18);
            this.labelApellido.TabIndex = 24;
            this.labelApellido.Text = "Apellido";
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 390);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxContraseñaUsuario);
            this.Controls.Add(this.labelContraseñaText);
            this.Controls.Add(this.checkBoxAdministrador);
            this.Controls.Add(this.comboBoxPais);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dateTimePickerNacimiento);
            this.Controls.Add(this.labelIndicaciones);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelAgregarUsuario);
            this.Controls.Add(this.labelPaís);
            this.Controls.Add(this.labelFechaNacimiento);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AgregarUsuario";
            this.Text = "Agregar Usuario";
            this.Load += new System.EventHandler(this.AgregarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.Label labelPaís;
        private System.Windows.Forms.Label labelAgregarUsuario;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelIndicaciones;
        private System.Windows.Forms.DateTimePicker dateTimePickerNacimiento;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ComboBox comboBoxPais;
        private System.Windows.Forms.CheckBox checkBoxAdministrador;
        private System.Windows.Forms.Label labelContraseñaText;
        private System.Windows.Forms.TextBox textBoxContraseñaUsuario;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelApellido;
    }
}