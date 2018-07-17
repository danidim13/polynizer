namespace Polynizer
{
    partial class ListaUsuarios
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
            this.listaUsuariosDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.correosCB = new System.Windows.Forms.ComboBox();
            this.cambiarBTN = new System.Windows.Forms.Button();
            this.EliminarBTN = new System.Windows.Forms.Button();
            this.agregarLL = new System.Windows.Forms.LinkLabel();
            this.regresarBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios registrados";
            // 
            // listaUsuariosDGV
            // 
            this.listaUsuariosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaUsuariosDGV.Location = new System.Drawing.Point(35, 122);
            this.listaUsuariosDGV.Name = "listaUsuariosDGV";
            this.listaUsuariosDGV.ReadOnly = true;
            this.listaUsuariosDGV.Size = new System.Drawing.Size(601, 231);
            this.listaUsuariosDGV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Correo:";
            // 
            // correosCB
            // 
            this.correosCB.FormattingEnabled = true;
            this.correosCB.Location = new System.Drawing.Point(108, 75);
            this.correosCB.Name = "correosCB";
            this.correosCB.Size = new System.Drawing.Size(157, 21);
            this.correosCB.TabIndex = 3;
            this.correosCB.SelectedIndexChanged += new System.EventHandler(this.correosCB_SelectedIndexChanged);
            // 
            // cambiarBTN
            // 
            this.cambiarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambiarBTN.Location = new System.Drawing.Point(530, 61);
            this.cambiarBTN.Name = "cambiarBTN";
            this.cambiarBTN.Size = new System.Drawing.Size(106, 47);
            this.cambiarBTN.TabIndex = 4;
            this.cambiarBTN.Text = "Conceder administración";
            this.cambiarBTN.UseVisualStyleBackColor = true;
            this.cambiarBTN.Visible = false;
            this.cambiarBTN.Click += new System.EventHandler(this.cambiarBTN_Click);
            // 
            // EliminarBTN
            // 
            this.EliminarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBTN.Location = new System.Drawing.Point(271, 75);
            this.EliminarBTN.Name = "EliminarBTN";
            this.EliminarBTN.Size = new System.Drawing.Size(75, 23);
            this.EliminarBTN.TabIndex = 5;
            this.EliminarBTN.Text = "Eliminar";
            this.EliminarBTN.UseVisualStyleBackColor = true;
            this.EliminarBTN.Click += new System.EventHandler(this.EliminarBTN_Click);
            // 
            // agregarLL
            // 
            this.agregarLL.AutoSize = true;
            this.agregarLL.Location = new System.Drawing.Point(560, 9);
            this.agregarLL.Name = "agregarLL";
            this.agregarLL.Size = new System.Drawing.Size(96, 13);
            this.agregarLL.TabIndex = 6;
            this.agregarLL.TabStop = true;
            this.agregarLL.Text = "Agregar un usuario";
            this.agregarLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.agregarLL_LinkClicked);
            // 
            // regresarBTN
            // 
            this.regresarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarBTN.Location = new System.Drawing.Point(561, 359);
            this.regresarBTN.Name = "regresarBTN";
            this.regresarBTN.Size = new System.Drawing.Size(75, 29);
            this.regresarBTN.TabIndex = 8;
            this.regresarBTN.Text = "Regresar";
            this.regresarBTN.UseVisualStyleBackColor = true;
            this.regresarBTN.Click += new System.EventHandler(this.regresarBTN_Click);
            // 
            // ListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 400);
            this.Controls.Add(this.regresarBTN);
            this.Controls.Add(this.agregarLL);
            this.Controls.Add(this.EliminarBTN);
            this.Controls.Add(this.cambiarBTN);
            this.Controls.Add(this.correosCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaUsuariosDGV);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListaUsuarios";
            this.Text = "ListaUsuarios";
            this.Load += new System.EventHandler(this.ListaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listaUsuariosDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox correosCB;
        private System.Windows.Forms.Button cambiarBTN;
        private System.Windows.Forms.Button EliminarBTN;
        private System.Windows.Forms.LinkLabel agregarLL;
        private System.Windows.Forms.Button regresarBTN;
    }
}