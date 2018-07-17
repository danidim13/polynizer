namespace Polynizer
{
    partial class UsuarioVerPerfil
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dispositivosDGV = new System.Windows.Forms.DataGridView();
            this.nombreTB = new System.Windows.Forms.TextBox();
            this.fechaNacTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.apellidoTB = new System.Windows.Forms.TextBox();
            this.paisTB = new System.Windows.Forms.TextBox();
            this.editarBTN = new System.Windows.Forms.Button();
            this.regresarBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dispositivosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mi perfil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(295, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de Nacimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(295, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "País:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dispositivos:";
            // 
            // dispositivosDGV
            // 
            this.dispositivosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dispositivosDGV.Location = new System.Drawing.Point(31, 260);
            this.dispositivosDGV.Name = "dispositivosDGV";
            this.dispositivosDGV.Size = new System.Drawing.Size(217, 77);
            this.dispositivosDGV.TabIndex = 7;
            // 
            // nombreTB
            // 
            this.nombreTB.Location = new System.Drawing.Point(103, 88);
            this.nombreTB.Name = "nombreTB";
            this.nombreTB.ReadOnly = true;
            this.nombreTB.Size = new System.Drawing.Size(145, 20);
            this.nombreTB.TabIndex = 8;
            // 
            // fechaNacTB
            // 
            this.fechaNacTB.Location = new System.Drawing.Point(464, 162);
            this.fechaNacTB.Name = "fechaNacTB";
            this.fechaNacTB.ReadOnly = true;
            this.fechaNacTB.Size = new System.Drawing.Size(145, 20);
            this.fechaNacTB.TabIndex = 9;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(464, 90);
            this.emailTB.Name = "emailTB";
            this.emailTB.ReadOnly = true;
            this.emailTB.Size = new System.Drawing.Size(145, 20);
            this.emailTB.TabIndex = 10;
            this.emailTB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // apellidoTB
            // 
            this.apellidoTB.Location = new System.Drawing.Point(103, 162);
            this.apellidoTB.Name = "apellidoTB";
            this.apellidoTB.ReadOnly = true;
            this.apellidoTB.Size = new System.Drawing.Size(145, 20);
            this.apellidoTB.TabIndex = 11;
            // 
            // paisTB
            // 
            this.paisTB.Location = new System.Drawing.Point(464, 239);
            this.paisTB.Name = "paisTB";
            this.paisTB.ReadOnly = true;
            this.paisTB.Size = new System.Drawing.Size(145, 20);
            this.paisTB.TabIndex = 12;
            // 
            // editarBTN
            // 
            this.editarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarBTN.Location = new System.Drawing.Point(453, 297);
            this.editarBTN.Name = "editarBTN";
            this.editarBTN.Size = new System.Drawing.Size(75, 40);
            this.editarBTN.TabIndex = 13;
            this.editarBTN.Text = "Editar";
            this.editarBTN.UseVisualStyleBackColor = true;
            // 
            // regresarBTN
            // 
            this.regresarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarBTN.Location = new System.Drawing.Point(534, 297);
            this.regresarBTN.Name = "regresarBTN";
            this.regresarBTN.Size = new System.Drawing.Size(75, 40);
            this.regresarBTN.TabIndex = 14;
            this.regresarBTN.Text = "Regresar";
            this.regresarBTN.UseVisualStyleBackColor = true;
            this.regresarBTN.Click += new System.EventHandler(this.regresarBTN_Click);
            // 
            // UsuarioVerPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 350);
            this.Controls.Add(this.regresarBTN);
            this.Controls.Add(this.editarBTN);
            this.Controls.Add(this.paisTB);
            this.Controls.Add(this.apellidoTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.fechaNacTB);
            this.Controls.Add(this.nombreTB);
            this.Controls.Add(this.dispositivosDGV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UsuarioVerPerfil";
            this.Text = "Mi perfil";
            this.Load += new System.EventHandler(this.UsuarioVerPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dispositivosDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dispositivosDGV;
        private System.Windows.Forms.TextBox nombreTB;
        private System.Windows.Forms.TextBox fechaNacTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox apellidoTB;
        private System.Windows.Forms.TextBox paisTB;
        private System.Windows.Forms.Button editarBTN;
        private System.Windows.Forms.Button regresarBTN;
    }
}