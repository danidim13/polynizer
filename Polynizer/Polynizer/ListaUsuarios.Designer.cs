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
            this.EditarBTN = new System.Windows.Forms.Button();
            this.EliminarBTN = new System.Windows.Forms.Button();
            this.agregarLL = new System.Windows.Forms.LinkLabel();
            this.regresarLL = new System.Windows.Forms.LinkLabel();
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listaUsuariosDGV
            // 
            this.listaUsuariosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaUsuariosDGV.Location = new System.Drawing.Point(34, 146);
            this.listaUsuariosDGV.Name = "listaUsuariosDGV";
            this.listaUsuariosDGV.Size = new System.Drawing.Size(601, 231);
            this.listaUsuariosDGV.TabIndex = 1;
            this.listaUsuariosDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaUsuariosDGV_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Correo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // correosCB
            // 
            this.correosCB.FormattingEnabled = true;
            this.correosCB.Location = new System.Drawing.Point(107, 99);
            this.correosCB.Name = "correosCB";
            this.correosCB.Size = new System.Drawing.Size(157, 21);
            this.correosCB.TabIndex = 3;
            // 
            // EditarBTN
            // 
            this.EditarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarBTN.Location = new System.Drawing.Point(316, 99);
            this.EditarBTN.Name = "EditarBTN";
            this.EditarBTN.Size = new System.Drawing.Size(75, 23);
            this.EditarBTN.TabIndex = 4;
            this.EditarBTN.Text = "Editar";
            this.EditarBTN.UseVisualStyleBackColor = true;
            this.EditarBTN.Click += new System.EventHandler(this.EditarBTN_Click);
            // 
            // EliminarBTN
            // 
            this.EliminarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBTN.Location = new System.Drawing.Point(436, 99);
            this.EliminarBTN.Name = "EliminarBTN";
            this.EliminarBTN.Size = new System.Drawing.Size(75, 23);
            this.EliminarBTN.TabIndex = 5;
            this.EliminarBTN.Text = "Eliminar";
            this.EliminarBTN.UseVisualStyleBackColor = true;
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
            this.agregarLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // regresarLL
            // 
            this.regresarLL.AutoSize = true;
            this.regresarLL.Location = new System.Drawing.Point(12, 9);
            this.regresarLL.Name = "regresarLL";
            this.regresarLL.Size = new System.Drawing.Size(50, 13);
            this.regresarLL.TabIndex = 7;
            this.regresarLL.TabStop = true;
            this.regresarLL.Text = "Regresar";
            // 
            // ListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 400);
            this.Controls.Add(this.regresarLL);
            this.Controls.Add(this.agregarLL);
            this.Controls.Add(this.EliminarBTN);
            this.Controls.Add(this.EditarBTN);
            this.Controls.Add(this.correosCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaUsuariosDGV);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button EditarBTN;
        private System.Windows.Forms.Button EliminarBTN;
        private System.Windows.Forms.LinkLabel agregarLL;
        private System.Windows.Forms.LinkLabel regresarLL;
    }
}