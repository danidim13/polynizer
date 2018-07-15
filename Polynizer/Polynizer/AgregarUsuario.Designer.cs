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
            this.labelDispositivos = new System.Windows.Forms.Label();
            this.labelAgregarUsuario = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelIndicaciones = new System.Windows.Forms.Label();
            this.textBoxIMEI1 = new System.Windows.Forms.TextBox();
            this.textBoxIMEI2 = new System.Windows.Forms.TextBox();
            this.labelIMEI1 = new System.Windows.Forms.Label();
            this.labelIMEI2 = new System.Windows.Forms.Label();
            this.dateTimePickerNacimiento = new System.Windows.Forms.DateTimePicker();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.checkBoxAdministrador = new System.Windows.Forms.CheckBox();
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
            this.labelPaís.Location = new System.Drawing.Point(398, 193);
            this.labelPaís.Name = "labelPaís";
            this.labelPaís.Size = new System.Drawing.Size(39, 18);
            this.labelPaís.TabIndex = 3;
            this.labelPaís.Text = "País";
            // 
            // labelDispositivos
            // 
            this.labelDispositivos.AutoSize = true;
            this.labelDispositivos.Font = new System.Drawing.Font("Arial", 12F);
            this.labelDispositivos.Location = new System.Drawing.Point(46, 290);
            this.labelDispositivos.Name = "labelDispositivos";
            this.labelDispositivos.Size = new System.Drawing.Size(94, 18);
            this.labelDispositivos.TabIndex = 4;
            this.labelDispositivos.Text = "Dispositivos";
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
            this.textBoxNombre.Size = new System.Drawing.Size(244, 20);
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
            this.buttonGuardar.Location = new System.Drawing.Point(589, 399);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 10;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
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
            // textBoxIMEI1
            // 
            this.textBoxIMEI1.Location = new System.Drawing.Point(169, 320);
            this.textBoxIMEI1.Name = "textBoxIMEI1";
            this.textBoxIMEI1.Size = new System.Drawing.Size(151, 20);
            this.textBoxIMEI1.TabIndex = 13;
            // 
            // textBoxIMEI2
            // 
            this.textBoxIMEI2.Location = new System.Drawing.Point(169, 346);
            this.textBoxIMEI2.Name = "textBoxIMEI2";
            this.textBoxIMEI2.Size = new System.Drawing.Size(151, 20);
            this.textBoxIMEI2.TabIndex = 14;
            // 
            // labelIMEI1
            // 
            this.labelIMEI1.AutoSize = true;
            this.labelIMEI1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIMEI1.Location = new System.Drawing.Point(46, 323);
            this.labelIMEI1.Name = "labelIMEI1";
            this.labelIMEI1.Size = new System.Drawing.Size(114, 14);
            this.labelIMEI1.TabIndex = 15;
            this.labelIMEI1.Text = "IMEI del dispositivo #1 ";
            // 
            // labelIMEI2
            // 
            this.labelIMEI2.AutoSize = true;
            this.labelIMEI2.Location = new System.Drawing.Point(46, 349);
            this.labelIMEI2.Name = "labelIMEI2";
            this.labelIMEI2.Size = new System.Drawing.Size(117, 13);
            this.labelIMEI2.TabIndex = 16;
            this.labelIMEI2.Text = "IMEI del dispositivo #2 ";
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
            this.buttonCancelar.Location = new System.Drawing.Point(492, 399);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 18;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.Location = new System.Drawing.Point(401, 217);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(244, 21);
            this.comboBoxPais.TabIndex = 19;
            // 
            // checkBoxAdministrador
            // 
            this.checkBoxAdministrador.AutoSize = true;
            this.checkBoxAdministrador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdministrador.Location = new System.Drawing.Point(401, 344);
            this.checkBoxAdministrador.Name = "checkBoxAdministrador";
            this.checkBoxAdministrador.Size = new System.Drawing.Size(222, 22);
            this.checkBoxAdministrador.TabIndex = 20;
            this.checkBoxAdministrador.Text = "Privilegios de administrador";
            this.checkBoxAdministrador.UseVisualStyleBackColor = true;
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.checkBoxAdministrador);
            this.Controls.Add(this.comboBoxPais);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dateTimePickerNacimiento);
            this.Controls.Add(this.labelIMEI2);
            this.Controls.Add(this.labelIMEI1);
            this.Controls.Add(this.textBoxIMEI2);
            this.Controls.Add(this.textBoxIMEI1);
            this.Controls.Add(this.labelIndicaciones);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelAgregarUsuario);
            this.Controls.Add(this.labelDispositivos);
            this.Controls.Add(this.labelPaís);
            this.Controls.Add(this.labelFechaNacimiento);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AgregarUsuario";
            this.Text = "Agregar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.Label labelPaís;
        private System.Windows.Forms.Label labelDispositivos;
        private System.Windows.Forms.Label labelAgregarUsuario;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelIndicaciones;
        private System.Windows.Forms.TextBox textBoxIMEI1;
        private System.Windows.Forms.TextBox textBoxIMEI2;
        private System.Windows.Forms.Label labelIMEI1;
        private System.Windows.Forms.Label labelIMEI2;
        private System.Windows.Forms.DateTimePicker dateTimePickerNacimiento;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ComboBox comboBoxPais;
        private System.Windows.Forms.CheckBox checkBoxAdministrador;
    }
}