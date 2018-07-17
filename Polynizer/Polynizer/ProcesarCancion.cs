using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;

namespace Polynizer
{
    public partial class ProcesaCancion :Form
    {
        private Button button1;

        public ProcesaCancion()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            byte esLink;
            //if (mp3.Checked)
            //{
            //    esLink = 0;
            //}
            //else if (link.Checked)
            //{
            //    esLink = 1;
            //}
            //procesaCancion(textoCancion.Text, esLink);

        }



        private void cancelar_Click(object sender, EventArgs e)
        {
            //Aqui se devuelve a la ventana de compras que aun no está implementada.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProcesaCancion
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button1);
            this.Name = "ProcesaCancion";
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogMp3 = new OpenFileDialog();
            openFileDialogMp3.Filter = "Archivos Mp3 (*.mp3)|*.mp3|Todos los archivos|*.*";
            openFileDialogMp3.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            openFileDialogMp3.RestoreDirectory = true;

            if (openFileDialogMp3.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialogMp3.FileName;
                FileStream mp3FileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);

                byte[] hash;

                using (BufferedStream stream = new BufferedStream(mp3FileStream, 1024*32))
                {
                    using (SHA256 sha = new SHA256Managed())
                    {
                        hash = sha.ComputeHash(stream);
                    }
                }

                Debug.Print("Filehash: " + BitConverter.ToString(hash));
                
            }
        }
    }
}
