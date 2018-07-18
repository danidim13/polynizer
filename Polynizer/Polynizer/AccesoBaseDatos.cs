/*Esta clase es la misma clase que se utilizó en el laboratorio del curso para establecer la conexión con la base de datos, con algunos metodos nuevos para diferentes tipos de consultas*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Polynizer
{
    class AccesoBaseDatos
    {
        /*Para conectarse a la base de datos desde la ecci.*/
        String conexion = "Data Source=10.1.4.55; Initial Catalog=DB_INTELLECT; Integrated Security=SSPI";

        /*Para conectarse a la base de datos desde una conexión remota.*/
        //string conexion = "Data Source=10.1.4.55;User ID=x; Password=x; Initial Catalog=DB_INTELLECT; Integrated Security=false";
        
        /**
         * Constructor de la clase
         */
        public AccesoBaseDatos(){
        }

        /**
         * Permite ejecutar una consulta SQL, los datos son devueltos en un SqlDataReader
         * Recibe: La consulta sql a ejecutar
         * Modifica: Obtiene las tuplas que corresponden a la consulta recibida
         * Retorna: El datareader con los resultados de la ejecución de la consulta
         */
        public SqlDataReader ejecutarConsulta(String consulta)
        {
            //Prepara una nueva conexión a la bd y la abre
            SqlConnection sqlConnection = new SqlConnection(conexion);
            sqlConnection.Open();

            SqlDataReader datos = null;
            SqlCommand comando = null;

            try
            {
                //Ejecuta la consulta sql recibida por parámetro y la carga en un datareader
                comando = new SqlCommand(consulta, sqlConnection);
                datos = comando.ExecuteReader();
            }
            catch (SqlException ex)
            {

            }
            return datos;
        }

        /**
         * Permite ejecutar una consulta SQL, los datos son devueltos en un DataTable
         * * Recibe: La consulta sql a ejecutar
         * Modifica: Obtiene las tuplas que corresponden a la consulta recibida
         * Retorna: El datatable con los resultados de la ejecución de la consulta
         */
        public DataTable ejecutarConsultaTabla(String consulta)
        {
            //Prepara una nueva conexión a la bd y la abre
            SqlConnection sqlConnection = new SqlConnection(conexion);
            sqlConnection.Open();

            SqlCommand comando = new SqlCommand(consulta, sqlConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();

            dataAdapter.Fill(table);
			
			return table;
        }

        /**
         * Método para ejecutar un insert, update o delete
         * Recibe: la sentencia sql a ejecutar
         * Modifica: realiza el cambio en la base de datos de acuerdo al tipo de sentencia sql
         * Retorna: el tipo de error que generó la consulta o cero si la ejecución fue exitosa
         */
        public int actualizarDatos(String consulta)
        {
            int error = 0;

            //Prepara una nueva conexión a la bd y la abre
            SqlConnection sqlConnection = new SqlConnection(conexion);
            sqlConnection.Open();

            SqlCommand cons = new SqlCommand(consulta, sqlConnection);

            try
            {
                //Ejecuta la consulta sql recibida por parámetro
                cons.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                error = e.Number;
                Debug.WriteLine("Error: " + error);
            }

            finally
            {
                sqlConnection.Close();
            }

            return error;
        }

        /**
         * Método para llamar al procedimiento almacenado que permite agregar un nuevo usuario
         * Recibe: el usuario y la contraseña del nuevo usuario así como la cédula del estudiante a quién se asocia ese usuario
         * Modifica: Agrega en la base de datos un nuevo 
         * Retorna: 1 si se pudo guardar el nuevo usuario, un número diferente a cero que corresponde al número de error
         * si no se pudo insertar
         */
        public int agregarUsuario(string correo, string nombre, string apellido, string fechaNac, string fechaIni, string pais, string password, bool superUser)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                /*El sqlCommand recibe como primer parámetro el nombre del procedimiento almacenado, 
                 * de segundo parámetro recibe el sqlConnection
                */
                using (SqlCommand cmd = new SqlCommand("AgregarUsuario", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = correo;
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                        cmd.Parameters.Add("@apellido", SqlDbType.VarChar).Value = apellido;
                        cmd.Parameters.Add("@fechaNac", SqlDbType.VarChar).Value = fechaNac;
                        cmd.Parameters.Add("@fechaIni", SqlDbType.VarChar).Value = fechaIni;
                        cmd.Parameters.Add("@pais", SqlDbType.VarChar).Value = pais;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                        cmd.Parameters.Add("@superUser", SqlDbType.VarChar).Value = superUser;


                        //se prepara el parámetro de retorno del procedimiento almacenado
                        cmd.Parameters.Add("@resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;

                        /*Se abre la conexión*/
                        con.Open();

                        /*Se ejecuta el procedimiento almacenado*/
                        cmd.ExecuteNonQuery();

                        /*Se convierte en un valor entero lo que se devuelve el procedimiento*/
                        return Convert.ToInt32(cmd.Parameters["@resultado"].Value);
                        
                    }
                    catch (SqlException ex)
                    {
                        /*Se capta el número de error si no se pudo insertar*/
                        error = ex.Number;
                        return error;
                    }
                }
            }

        }

        public int cantidadMetadatos(string IDCancion)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                /*El sqlCommand recibe como primer parámetro el nombre del procedimiento almacenado, 
                 * de segundo parámetro recibe el sqlConnection
                */
                using (SqlCommand cmd = new SqlCommand("CantidadMetadatosCancion", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@IDCancion", SqlDbType.VarChar).Value = IDCancion;

                        //se prepara el parámetro de retorno del procedimiento almacenado
                        cmd.Parameters.Add("@Cantidad", SqlDbType.Bit).Direction = ParameterDirection.Output;

                        /*Se abre la conexión*/
                        con.Open();

                        /*Se ejecuta el procedimiento almacenado*/
                        cmd.ExecuteNonQuery();

                        /*Se convierte en un valor entero lo que se devuelve el procedimiento*/
                        return Convert.ToInt32(cmd.Parameters["@Cantidad"].Value);

                    }
                    catch (SqlException ex)
                    {
                        /*Se capta el número de error si no se pudo insertar*/
                        error = ex.Number;
                        return error;
                    }
                }
            }
        }

        /**
         * Método para llamar al procedimiento almacenado para comprobar que un usuario está en la base de datos
         * Recibe: El usuario y contraseña que se desea verificar que está en la base de datos
         * Modifica: Busca el usuario con esa contraseña en la base de datos
         * Retorna: true si está en la base de datos, false sino
         */
        public bool login(string correo, string contraseña)
        {

            using (SqlConnection con = new SqlConnection(conexion))
            {
                con.Open();
                string salt;
                byte[] usalt;
                byte[] hash;

                using (SqlCommand cmd = new SqlCommand("getSalt", con))
                {

                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@CorreoLogin", SqlDbType.VarChar).Value = correo;
                        cmd.Parameters.Add("@salt", SqlDbType.UniqueIdentifier).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();
                        salt = cmd.Parameters["@salt"].Value.ToString().ToUpper();
                    }
                    catch (SqlException ex)
                    {
                        return false;
                    }

                }

                Debug.Print("Got Salt:" + salt);

                using (SHA512 sha = new SHA512Managed())
                {
                    var salted = Encoding.Unicode.GetBytes(String.Concat(contraseña,salt)); 
                    hash = sha.ComputeHash(salted);
                }
                Debug.Print("PWD hash:" + BitConverter.ToString(hash));

                using (SqlCommand cmd = new SqlCommand("SafeLogin", con))
                {
                    try
                    {
                        /*El sqlCommand recibe como primer parámetro el nombre del procedimiento almacenado, 
                         * de segundo parámetro recibe el sqlConnection
                        */
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@CorreoLogin", SqlDbType.VarChar).Value = correo;
                        cmd.Parameters.Add("@pwdHash", SqlDbType.Binary).Value = hash;

                        //se prepara el parámetro de retorno del procedimiento almacenado
                        cmd.Parameters.Add("@enDB", SqlDbType.Bit).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();

                        //Se convierte en un valor entero lo que se devuelve el procedimiento
                        int value = Convert.ToInt32(cmd.Parameters["@enDB"].Value);

                        //Si el procedimiento devuelve 1 es que si se encuentra en la BD//
                        if (value == 1)
                        {
                            return true;
                        }

                        //Si devuelve 0 es que no se encuentra en la BD
                        else
                        {
                            return false;
                        }
                    }
                    catch (SqlException ex)
                    {
                        return false;
                    }

                }

            }

        }

        public bool procesarCancion(string url, ref int id)
        {
            return this.ProcesarCancion(true, url, null, ref id);
        }
        public bool procesarCancion(byte[] hash, ref int id)
        {
            return this.ProcesarCancion(false, "", hash, ref id);
        }

        private bool ProcesarCancion(bool isLink, string url, byte[] hash, ref int id)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("ProcesarCancion", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = Global.correoUsuario;
                        cmd.Parameters.Add("@version", SqlDbType.VarChar).Value = Global.VERSION;
                        cmd.Parameters.Add("@error", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@idCancion", SqlDbType.Int).Direction = ParameterDirection.Output;

                        if (isLink)
                        {
                            cmd.Parameters.Add("@isLink", SqlDbType.Bit).Value = true;
                            cmd.Parameters.Add("@urlLink", SqlDbType.NVarChar).Value = url;
                            cmd.Parameters.Add("@mp3Fingerprint", SqlDbType.Binary).Value = new byte[32];

                        } else
                        {
                            cmd.Parameters.Add("@isLink", SqlDbType.Bit).Value = false;
                            cmd.Parameters.Add("@urlLink", SqlDbType.NVarChar).Value = "";
                            cmd.Parameters.Add("@mp3Fingerprint", SqlDbType.Binary).Value = hash;
                        }

                        con.Open();
                        cmd.ExecuteNonQuery();

                        int errorCode = Convert.ToInt32(cmd.Parameters["@error"].Value);
                        id = Convert.ToInt32(cmd.Parameters["@idCancion"].Value);
                        Debug.Print("Procesar cancion: " + errorCode.ToString() + ", " + id.ToString());
                        if (errorCode == 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    } catch (SqlException e)
                    {
                        Debug.Print(e.Message + e.StackTrace);
                        return false;
                    }
                }
            }
            
        }

        public int tokensRestantes(string correo)
        {
            int tokens = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("TokensRestantes", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = correo;
                        cmd.Parameters.Add("@cantidad", SqlDbType.Int).Direction = ParameterDirection.Output;

                        con.Open();
                        cmd.ExecuteNonQuery();

                        tokens = Convert.ToInt32(cmd.Parameters["@cantidad"].Value);
                    }
                    catch (SqlException e)
                    {
                        return 0;
                    }
                }
            }
            return tokens;
        }

        /** 
         * Metodo que verifica si el correo utilizado para iniciar sesión tiene permisos de administrador
         * Recibe: El correo del usuario a verificar
         * Modifica: Busca el bit de supUser en la base de datos
         * Retorna: true si el usuario tiene permisos de administrador
         */
        public bool superUser(string correo)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("superUser", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@CorreoLogin", SqlDbType.VarChar).Value = correo;
                        //cmd.Parameters.Add("@PasswordLogin", SqlDbType.VarChar).Value = contraseña;

                        //se prepara el parámetro de retorno del procedimiento almacenado
                        cmd.Parameters.Add("@supUser", SqlDbType.Bit).Direction = ParameterDirection.Output;

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        /*Se convierte en un valor entero lo que se devuelve el procedimiento*/
                        int value = Convert.ToInt32(cmd.Parameters["@supUser"].Value);

                        /*Si el procedimiento devuelve 1 es que si se encuentra en la BD*/
                        if (value == 1)
                        {
                            return true;
                        }

                        /*Si devuelve 0 es que no se encuentra en la BD*/
                        else
                        {
                            return false;
                        }

                    }
                    catch (SqlException ex)
                    {
                        return false;
                    }
                }
            }
        }

    }
}
