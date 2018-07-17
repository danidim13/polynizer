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
        private Label labelTituloC;
        private Label labelArtistaC;
        private TextBox textBoxTitulo;
        private TextBox textBoxArtista;
        private Label labelOpcionales;
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
            this.labelTituloC = new System.Windows.Forms.Label();
            this.labelArtistaC = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxArtista = new System.Windows.Forms.TextBox();
            this.labelOpcionales = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(305, 267);
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
            this.textBoxArchivo.Location = new System.Drawing.Point(64, 113);
            this.textBoxArchivo.Name = "textBoxArchivo";
            this.textBoxArchivo.Size = new System.Drawing.Size(367, 20);
            this.textBoxArchivo.TabIndex = 4;
            this.textBoxArchivo.Click += new System.EventHandler(this.textBoxArchivo_Click);
            this.textBoxArchivo.TextChanged += new System.EventHandler(this.textBoxArchivo_TextChanged);
            // 
            // buttonProcesar
            // 
            this.buttonProcesar.Enabled = false;
            this.buttonProcesar.Location = new System.Drawing.Point(64, 267);
            this.buttonProcesar.Name = "buttonProcesar";
            this.buttonProcesar.Size = new System.Drawing.Size(126, 45);
            this.buttonProcesar.TabIndex = 5;
            this.buttonProcesar.Text = "Procesar";
            this.buttonProcesar.UseVisualStyleBackColor = true;
            this.buttonProcesar.Click += new System.EventHandler(this.buttonProcesar_Click);
            // 
            // labelTituloC
            // 
            this.labelTituloC.AutoSize = true;
            this.labelTituloC.Location = new System.Drawing.Point(60, 193);
            this.labelTituloC.Name = "labelTituloC";
            this.labelTituloC.Size = new System.Drawing.Size(38, 13);
            this.labelTituloC.TabIndex = 6;
            this.labelTituloC.Text = "Título:";
            // 
            // labelArtistaC
            // 
            this.labelArtistaC.AutoSize = true;
            this.labelArtistaC.Location = new System.Drawing.Point(229, 193);
            this.labelArtistaC.Name = "labelArtistaC";
            this.labelArtistaC.Size = new System.Drawing.Size(39, 13);
            this.labelArtistaC.TabIndex = 7;
            this.labelArtistaC.Text = "Artista:";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(63, 209);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(143, 20);
            this.textBoxTitulo.TabIndex = 8;
            // 
            // textBoxArtista
            // 
            this.textBoxArtista.Location = new System.Drawing.Point(232, 209);
            this.textBoxArtista.Name = "textBoxArtista";
            this.textBoxArtista.Size = new System.Drawing.Size(143, 20);
            this.textBoxArtista.TabIndex = 9;
            // 
            // labelOpcionales
            // 
            this.labelOpcionales.AutoSize = true;
            this.labelOpcionales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpcionales.Location = new System.Drawing.Point(61, 170);
            this.labelOpcionales.Name = "labelOpcionales";
            this.labelOpcionales.Size = new System.Drawing.Size(197, 16);
            this.labelOpcionales.TabIndex = 10;
            this.labelOpcionales.Text = "Datos opcionales de la canción";
            // 
            // ProcesaCancion
            // 
            this.ClientSize = new System.Drawing.Size(485, 339);
            this.Controls.Add(this.labelOpcionales);
            this.Controls.Add(this.textBoxArtista);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.labelArtistaC);
            this.Controls.Add(this.labelTituloC);
            this.Controls.Add(this.buttonProcesar);
            this.Controls.Add(this.textBoxArchivo);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.radioButtonUrl);
            this.Controls.Add(this.radioButtonMp3);
            this.Controls.Add(this.buttonCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
            if (this.radioButtonMp3.Checked)
            {
                this.textBoxArchivo.Text = "Haz click aquí para seleccionar un archivo.";
            }

        }

        private void radioButtonUrl_CheckedChanged(object sender, EventArgs e)
        {
            this.ClearInputs();
            if (this.radioButtonUrl.Checked)
            {
                this.textBoxArchivo.Text = "Ingrese un URL.";
            }
        }

        private void buttonProcesar_Click(object sender, EventArgs e)
        {
            string warningMsg = "Para procesar una canción debe usar un token. ¿Está seguro que desea procesar esta canción? Los tokens no son reembolsables.";
            DialogResult dialog = MessageBox.Show(warningMsg, "Procesar", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                bool success = false;
                if (this.radioButtonMp3.Checked)
                {
                    int id = Global.intermediaria.ProcesarCancion(this.mp3Hash);
                    if (id >= 0)
                    {
                        if (textBoxTitulo.Text != "" && textBoxTitulo.Text != null)
                        {
                            Global.intermediaria.agregarMetadato(id, "title", textBoxTitulo.Text);
                        }
                        else
                        {
                            Global.intermediaria.agregarMetadato(id, "title", Path.GetFileName(this.textBoxArchivo.Text));
                        }
                        if (textBoxArtista.Text != "" && textBoxArtista.Text != null)
                        {
                            Global.intermediaria.agregarMetadato(id, "artist", textBoxArtista.Text);
                        }
                        
                        success = true;
                    }
                } else if (this.radioButtonUrl.Checked)
                {
                    int id = Global.intermediaria.ProcesarCancion(this.songUrl);
                    if (id > 0)
                    {
                        if (textBoxTitulo.Text != "" && textBoxTitulo.Text != null)
                        {
                            Global.intermediaria.agregarMetadato(id, "title", textBoxTitulo.Text);
                        }
                        if(textBoxArtista.Text != "" && textBoxArtista.Text != null)
                        {
                            Global.intermediaria.agregarMetadato(id, "artist", textBoxArtista.Text);
                        }
                        success = true;
                    }
                }

                string resultMsg;
                if (success)
                {
                    resultMsg = "¡Cancion procesada con éxito!";
                } else
                {
                    //resultMsg = "Hubo un error y no se pudo completar la operación. ¡Tranquilo/a, sus tokens no fueron usados!";
                    resultMsg = "Lo sentimos, no le quedan suficientes Tokens para procesar esta canción. Si desea adquirir más Tokens puede utilizar la ventana de compras.";
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
