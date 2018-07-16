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
            this.label1.Location = new System.Drawing.Point(312, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios registrados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listaUsuariosDGV
            // 
            this.listaUsuariosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaUsuariosDGV.Location = new System.Drawing.Point(45, 180);
            this.listaUsuariosDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaUsuariosDGV.Name = "listaUsuariosDGV";
            this.listaUsuariosDGV.Size = new System.Drawing.Size(801, 284);
            this.listaUsuariosDGV.TabIndex = 1;
            this.listaUsuariosDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaUsuariosDGV_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Correo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // correosCB
            // 
            this.correosCB.FormattingEnabled = true;
            this.correosCB.Location = new System.Drawing.Point(143, 122);
            this.correosCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.correosCB.Name = "correosCB";
            this.correosCB.Size = new System.Drawing.Size(208, 24);
            this.correosCB.TabIndex = 3;
            // 
            // EditarBTN
            // 
            this.EditarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarBTN.Location = new System.Drawing.Point(421, 122);
            this.EditarBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditarBTN.Name = "EditarBTN";
            this.EditarBTN.Size = new System.Drawing.Size(100, 28);
            this.EditarBTN.TabIndex = 4;
            this.EditarBTN.Text = "Editar";
            this.EditarBTN.UseVisualStyleBackColor = true;
            this.EditarBTN.Click += new System.EventHandler(this.EditarBTN_Click);
            // 
            // EliminarBTN
            // 
            this.EliminarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBTN.Location = new System.Drawing.Point(581, 122);
            this.EliminarBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EliminarBTN.Name = "EliminarBTN";
            this.EliminarBTN.Size = new System.Drawing.Size(100, 28);
            this.EliminarBTN.TabIndex = 5;
            this.EliminarBTN.Text = "Eliminar";
            this.EliminarBTN.UseVisualStyleBackColor = true;
            // 
            // agregarLL
            // 
            this.agregarLL.AutoSize = true;
            this.agregarLL.Location = new System.Drawing.Point(747, 11);
            this.agregarLL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.agregarLL.Name = "agregarLL";
            this.agregarLL.Size = new System.Drawing.Size(130, 17);
            this.agregarLL.TabIndex = 6;
            this.agregarLL.TabStop = true;
            this.agregarLL.Text = "Agregar un usuario";
            this.agregarLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // regresarLL
            // 
            this.regresarLL.AutoSize = true;
            this.regresarLL.Location = new System.Drawing.Point(16, 11);
            this.regresarLL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.regresarLL.Name = "regresarLL";
            this.regresarLL.Size = new System.Drawing.Size(67, 17);
            this.regresarLL.TabIndex = 7;
            this.regresarLL.TabStop = true;
            this.regresarLL.Text = "Regresar";
            this.regresarLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.regresarLL_LinkClicked);
            // 
            // ListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 492);
            this.Controls.Add(this.regresarLL);
            this.Controls.Add(this.agregarLL);
            this.Controls.Add(this.EliminarBTN);
            this.Controls.Add(this.EditarBTN);
            this.Controls.Add(this.correosCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaUsuariosDGV);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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