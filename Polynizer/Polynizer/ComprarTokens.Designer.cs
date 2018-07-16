namespace Polynizer
{
    partial class ComprarTokens
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
            this.numTokensTB = new System.Windows.Forms.TextBox();
            this.comprarBTN = new System.Windows.Forms.Button();
            this.regresarBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la cantidad de Tokens que desea comprar";
            // 
            // numTokensTB
            // 
            this.numTokensTB.Location = new System.Drawing.Point(252, 118);
            this.numTokensTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numTokensTB.Name = "numTokensTB";
            this.numTokensTB.Size = new System.Drawing.Size(228, 22);
            this.numTokensTB.TabIndex = 1;
            this.numTokensTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comprarBTN
            // 
            this.comprarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprarBTN.Location = new System.Drawing.Point(252, 177);
            this.comprarBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comprarBTN.Name = "comprarBTN";
            this.comprarBTN.Size = new System.Drawing.Size(100, 54);
            this.comprarBTN.TabIndex = 2;
            this.comprarBTN.Text = "Comprar";
            this.comprarBTN.UseVisualStyleBackColor = true;
            // 
            // regresarBTN
            // 
            this.regresarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarBTN.Location = new System.Drawing.Point(381, 177);
            this.regresarBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.regresarBTN.Name = "regresarBTN";
            this.regresarBTN.Size = new System.Drawing.Size(100, 54);
            this.regresarBTN.TabIndex = 3;
            this.regresarBTN.Text = "Regresar";
            this.regresarBTN.UseVisualStyleBackColor = true;
            this.regresarBTN.Click += new System.EventHandler(this.regresarBTN_Click_1);
            // 
            // ComprarTokens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 277);
            this.Controls.Add(this.regresarBTN);
            this.Controls.Add(this.comprarBTN);
            this.Controls.Add(this.numTokensTB);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ComprarTokens";
            this.Text = "Comprar Tokens";
            this.Load += new System.EventHandler(this.ComprarTokens_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numTokensTB;
        private System.Windows.Forms.Button comprarBTN;
        private System.Windows.Forms.Button regresarBTN;
    }
}