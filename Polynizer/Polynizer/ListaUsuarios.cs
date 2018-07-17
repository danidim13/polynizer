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
                cambiarBTN.Hide();
            }
            else
            {
                tabla = Global.intermediaria.obtenerUsuarios(correo);
                cambiarBTN.Show();
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


        private void cambiarBTN_Click(object sender, EventArgs e)
        {
            SqlDataReader campoActual = Global.intermediaria.obtenerCampoEspecificoOtroUsuario("Superuser", correosCB.Text);
            if (campoActual.Read())
            {
                if(Convert.ToString(campoActual.GetValue(0)) == "True")
                {
                    if(MessageBox.Show("El usuario " + correosCB.Text + " es administrador, ¿seguro que desea removerle sus derechos de administrador?", "Cambio de permisos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (0 == Global.intermediaria.actualizarCampoOtroUsuario("Superuser", "0", correosCB.Text))
                        {
                            MessageBox.Show("Permiso de administrador revocado satisfactoriamente.", "Cambio de permisos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            if(correosCB.Text == Global.correoUsuario)
                            {
                                MessageBox.Show("Sus permisos han sido cambiados, por favor ingrese de nuevo a la aplicación.", "Cambio de permisos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                this.Hide();
                                Global.login = new LoginWindow();
                                Global.login.Show();
                                this.Close();
                            }
                            else
                            {
                                correosCB.SelectedIndex = 0;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error revocando el permiso de administrador.", "Cambio de permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("El usuario " + correosCB.Text + " no es administrador, ¿seguro que desea concederle permisos de administrador?", "Cambio de permisos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (0 == Global.intermediaria.actualizarCampoOtroUsuario("Superuser", "1", correosCB.Text))
                        {
                            MessageBox.Show("Permiso de administrador concedido satisfactoriamente.", "Cambio de permisos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            if (correosCB.Text == Global.correoUsuario)
                            {
                                MessageBox.Show("Sus permisos han sido cambiados, por favor ingrese de nuevo a la aplicación.", "Cambio de permisos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                this.Hide();
                                Global.login = new LoginWindow();
                                Global.login.Show();
                                this.Close();
                            }
                            else
                            {
                                correosCB.SelectedIndex = 0;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error concediendo el permiso de administrador.", "Cambio de permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
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
            SqlDataReader campoActual = Global.intermediaria.obtenerCampoEspecificoOtroUsuario("Superuser", correosCB.Text);
            if (campoActual.Read())
            {
                if (Convert.ToString(campoActual.GetValue(0)) == "True")
                {
                    cambiarBTN.Text = "Revocar administración";
                }
                else
                {
                    cambiarBTN.Text = "Conceder administración";
                }
            }

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
                if (MessageBox.Show("¿Está seguro que desea eliminar al usuario " + correosCB.Text + "?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (0 == Global.intermediaria.eliminarUsuario(correosCB.Text))
                    {
                        MessageBox.Show("¡El usuario fue eliminado exitosamente!", "Eliminar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if (correosCB.Text == Global.correoUsuario)
                        {
                            MessageBox.Show("Ha eliminado su propia cuenta, si esto fue un error, o desea crear otra cuentra, contáctese con el administrador.", "Cambio de permisos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Hide();
                            Global.login = new LoginWindow();
                            Global.login.Show();
                            this.Close();
                        }
                        else
                        {
                            correosCB.SelectedIndex = 0;
                        }
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
