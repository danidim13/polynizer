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
        private RadioButton radioButtonMp3;
        private RadioButton radioButtonUrl;
        private Label labelTitulo;
        private TextBox textBoxArchivo;
        private Button buttonProcesar;
        private Button buttonCancelar;

        private byte[] mp3Hash;
        private string songUrl;

        private bool continueRunning;

        public ProcesaCancion()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.continueRunning = false;
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

        private void InitializeComponent()
        {
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.radioButtonMp3 = new System.Windows.Forms.RadioButton();
            this.radioButtonUrl = new System.Windows.Forms.RadioButton();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxArchivo = new System.Windows.Forms.TextBox();
            this.buttonProcesar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(305, 168);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(126, 45);
            this.buttonCancelar.TabIndex = 0;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonMp3
            // 
            this.radioButtonMp3.AutoSize = true;
            this.radioButtonMp3.Location = new System.Drawing.Point(64, 52);
            this.radioButtonMp3.Name = "radioButtonMp3";
            this.radioButtonMp3.Size = new System.Drawing.Size(46, 17);
            this.radioButtonMp3.TabIndex = 1;
            this.radioButtonMp3.TabStop = true;
            this.radioButtonMp3.Text = "Mp3";
            this.radioButtonMp3.UseVisualStyleBackColor = true;
            this.radioButtonMp3.CheckedChanged += new System.EventHandler(this.radioButtonMp3_CheckedChanged);
            // 
            // radioButtonUrl
            // 
            this.radioButtonUrl.AutoSize = true;
            this.radioButtonUrl.Location = new System.Drawing.Point(64, 79);
            this.radioButtonUrl.Name = "radioButtonUrl";
            this.radioButtonUrl.Size = new System.Drawing.Size(45, 17);
            this.radioButtonUrl.TabIndex = 2;
            this.radioButtonUrl.TabStop = true;
            this.radioButtonUrl.Text = "Link";
            this.radioButtonUrl.UseVisualStyleBackColor = true;
            this.radioButtonUrl.CheckedChanged += new System.EventHandler(this.radioButtonUrl_CheckedChanged);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(162, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(176, 24);
            this.labelTitulo.TabIndex = 3;
            this.labelTitulo.Text = "Procesar Canción";
            // 
            // textBoxArchivo
            // 
            this.textBoxArchivo.Location = new System.Drawing.Point(64, 123);
            this.textBoxArchivo.Name = "textBoxArchivo";
            this.textBoxArchivo.Size = new System.Drawing.Size(367, 20);
            this.textBoxArchivo.TabIndex = 4;
            this.textBoxArchivo.Click += new System.EventHandler(this.textBoxArchivo_Click);
            this.textBoxArchivo.TextChanged += new System.EventHandler(this.textBoxArchivo_TextChanged);
            // 
            // buttonProcesar
            // 
            this.buttonProcesar.Enabled = false;
            this.buttonProcesar.Location = new System.Drawing.Point(64, 168);
            this.buttonProcesar.Name = "buttonProcesar";
            this.buttonProcesar.Size = new System.Drawing.Size(126, 45);
            this.buttonProcesar.TabIndex = 5;
            this.buttonProcesar.Text = "Procesar";
            this.buttonProcesar.UseVisualStyleBackColor = true;
            this.buttonProcesar.Click += new System.EventHandler(this.buttonProcesar_Click);
            // 
            // ProcesaCancion
            // 
            this.ClientSize = new System.Drawing.Size(485, 253);
            this.Controls.Add(this.buttonProcesar);
            this.Controls.Add(this.textBoxArchivo);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.radioButtonUrl);
            this.Controls.Add(this.radioButtonMp3);
            this.Controls.Add(this.buttonCancelar);
            this.Name = "ProcesaCancion";
            this.Load += new System.EventHandler(this.ProcesaCancion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.usuarioPrincipal = new UsuarioPrincipal();
            Global.usuarioPrincipal.Show();
            this.continueRunning = true;
            this.Close();
        }

        private void ClearInputs()
        {
            this.buttonProcesar.Enabled = false;
            this.textBoxArchivo.Text = "";
            this.mp3Hash = null;
            this.songUrl = "";
        }

        private void SelectMp3()
        {
            string filename = "";

            OpenFileDialog openFileDialogMp3 = new OpenFileDialog();
            openFileDialogMp3.Filter = "Archivos Mp3 (*.mp3)|*.mp3|Todos los archivos|*.*";
            openFileDialogMp3.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            openFileDialogMp3.RestoreDirectory = true;

            if (openFileDialogMp3.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialogMp3.FileName;
                if(this.getMp3Hash(filename))
                {
                    this.textBoxArchivo.Text = filename;
                    this.buttonProcesar.Enabled = true;
                } else
                {
                    this.ClearInputs();
                }
            } else
            {
                this.ClearInputs();
            }


        }

        private bool getMp3Hash(string filename)
        {
            try
            {
                FileStream mp3FileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                using (BufferedStream stream = new BufferedStream(mp3FileStream, 1024 * 32))
                {
                    using (SHA256 sha = new SHA256Managed())
                    {
                        mp3Hash = sha.ComputeHash(stream);
                    }
                }
            } catch (Exception e)
            {
                Debug.Print(e.Message + e.StackTrace);
                return false;
            }

            Debug.Print("Filehash: " + BitConverter.ToString(mp3Hash));
            return true;
        }

        private void ProcesaCancion_Load(object sender, EventArgs e)
        {

        }

        private void textBoxArchivo_TextChanged(object sender, EventArgs e)
        {
            if (this.radioButtonUrl.Checked)
            {
                Uri uriResult;
                bool validLink = Uri.TryCreate(this.textBoxArchivo.Text, UriKind.Absolute, out uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
                if (validLink)
                {
                    this.songUrl = this.textBoxArchivo.Text;
                    this.buttonProcesar.Enabled = true;
                }
                else
                {
                    this.buttonProcesar.Enabled = false;
                    this.songUrl = "";
                }
            }
        }

        private void textBoxArchivo_Click(object sender, EventArgs e)
        {
            if(this.radioButtonMp3.Checked)
            {
                this.SelectMp3();
            }
        }

        private void radioButtonMp3_CheckedChanged(object sender, EventArgs e)
        {
            this.ClearInputs();
        }

        private void radioButtonUrl_CheckedChanged(object sender, EventArgs e)
        {
            this.ClearInputs();
        }

        private void buttonProcesar_Click(object sender, EventArgs e)
        {
            string warningMsg = "Los tokens no son reembolsables, está seguro que desea procesar esta canción?";
            DialogResult dialog = MessageBox.Show(warningMsg, "Procesar", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                bool success = false;
                if (this.radioButtonMp3.Checked)
                {
                    int id = Global.intermediaria.ProcesarCancion(this.mp3Hash);
                    if (id >= 0)
                    {

                        Global.intermediaria.agregarMetadato(id, "title", Path.GetFileName(this.textBoxArchivo.Text));
                        success = true;
                    }
                } else if (this.radioButtonUrl.Checked)
                {
                    if (Global.intermediaria.ProcesarCancion(this.songUrl) > 0)
                    {
                        success = true;
                    }
                }

                string resultMsg;
                if (success)
                {
                    resultMsg = "¡Cancion procesada con éxito!";
                } else
                {
                    resultMsg = "Hubo un error y no se pudo completar la operación. ¡Tranquilo/a, sus tokens no fueron usados!";
                }
                MessageBox.Show(resultMsg, "Procesar", MessageBoxButtons.OK);

            }
            else if (dialog == DialogResult.No)
            {

            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!this.continueRunning)
            {
                Global.ConfirmExit(ref e);
            }
        }
    }
}
