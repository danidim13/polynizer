using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Polynizer
{
    public partial class ListaUsuarios : Form
    {
        public ListaUsuarios()
        {
            InitializeComponent();
            correosCB.Items.Add("Todos");
            llenarComboBoxCorreos();
            llenarListaUsuarios("");
        }

        private void llenarComboBoxCorreos()
        {
            SqlDataReader correos;
            correos = Global.intermediaria.obtenerListaCorreos();
            if (correos != null)
            {          
                while (correos.Read())
                {
                    correosCB.Items.Add(correos.GetValue(0));
                }
            }

            correosCB.SelectedIndex = 0;
        }

        private void llenarListaUsuarios(string correo)
        {
            DataTable tabla = null;
            if(correosCB.Text == "Todos")
            {
                tabla = Global.intermediaria.obtenerUsuarios("");
            }
            else
            {
                tabla = Global.intermediaria.obtenerUsuarios(correo);
            }
                       
            if(tabla != null)
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = tabla;
                listaUsuariosDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                listaUsuariosDGV.DataSource = bindingSource;
                for (int i = 0; i < listaUsuariosDGV.ColumnCount; i++)
                {
                    listaUsuariosDGV.Columns[i].Width = 162;
                }
            }
            else
            {
                listaUsuariosDGV.DataSource = null;
            }
            
        }

        private void ListaUsuarios_Load(object sender, EventArgs e)
        {

        }


        private void EditarBTN_Click(object sender, EventArgs e)
        {

        }

        private void agregarLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Global.adminAgregarUsuario = new AgregarUsuario();
            Global.adminAgregarUsuario.Show();
            this.Close();
        }

        private void regresarLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Global.adminPrincipal = new PincipalAdmin();
            Global.adminPrincipal.Show();
            this.Close();
        }

        private void correosCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarListaUsuarios(correosCB.Text);
        }

        private void EliminarBTN_Click(object sender, EventArgs e)
        {
            if(correosCB.Text == "Todos" || correosCB.Text == "")
            {
                if(listaUsuariosDGV.DataSource == null)
                {
                    MessageBox.Show("No hay usuarios para eliminar.", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un usuario de la lista.", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (MessageBox.Show("Está seguro que desea eliminar al usuario " + correosCB.Text + "?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (0 == Global.intermediaria.eliminarUsuario(correosCB.Text))
                    {
                        MessageBox.Show("¡El usuario fue eliminado exitosamente!", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        correosCB.SelectedIndex = 0;

                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al intentar eliminar el usuario.", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
