namespace Polynizer
{
    partial class ListaCompras
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
            this.listaComprasDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.regresarBTN = new System.Windows.Forms.Button();
            this.comprarTokensLL = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.listaComprasDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // listaComprasDGV
            // 
            this.listaComprasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaComprasDGV.Location = new System.Drawing.Point(26, 99);
            this.listaComprasDGV.Name = "listaComprasDGV";
            this.listaComprasDGV.Size = new System.Drawing.Size(530, 217);
            this.listaComprasDGV.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Compras realizadas";
            // 
            // regresarBTN
            // 
            this.regresarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarBTN.Location = new System.Drawing.Point(245, 354);
            this.regresarBTN.Name = "regresarBTN";
            this.regresarBTN.Size = new System.Drawing.Size(75, 26);
            this.regresarBTN.TabIndex = 4;
            this.regresarBTN.Text = "Regresar";
            this.regresarBTN.UseVisualStyleBackColor = true;
            this.regresarBTN.Click += new System.EventHandler(this.regresarBTN_Click);
            // 
            // comprarTokensLL
            // 
            this.comprarTokensLL.AutoSize = true;
            this.comprarTokensLL.Location = new System.Drawing.Point(471, 19);
            this.comprarTokensLL.Name = "comprarTokensLL";
            this.comprarTokensLL.Size = new System.Drawing.Size(85, 13);
            this.comprarTokensLL.TabIndex = 5;
            this.comprarTokensLL.TabStop = true;
            this.comprarTokensLL.Text = "Comprar Tokens";
            this.comprarTokensLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.comprarTokensLL_LinkClicked);
            // 
            // ListaCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 409);
            this.Controls.Add(this.comprarTokensLL);
            this.Controls.Add(this.regresarBTN);
            this.Controls.Add(this.listaComprasDGV);
            this.Controls.Add(this.label1);
            this.Name = "ListaCompras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.ListaCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaComprasDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listaComprasDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button regresarBTN;
        private System.Windows.Forms.LinkLabel comprarTokensLL;
    }
}