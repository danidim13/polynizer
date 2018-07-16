using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Configuration;
// Namespace de acceso a base de datos
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

/*Cambiar el namespace para que funcione!!*/
namespace Polynizer
{
    class AccesoBaseDatos
    {
        /*En Initial Catalog se agrega la base de datos propia. Intregated Security es para utilizar Windows Authentication*/
        //String conexion = "Data Source=10.1.4.55; Initial Catalog=gaudyblanco; Integrated Security=SSPI";

        /*En Initial Catalog se agrega la base de datos propia. Intregated Security = false es para utilizar SQL SERVER Authentication*/
        string conexion = "Data Source=10.1.4.55;User ID=x; Password=x; Initial Catalog=DB_INTELLECT; Integrated Security=false";
        /*CAMBIAR PASSWORD Y USER*/
        
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
         * Método para ejecutar un insert, update o 
         * Recibe: la sentencia sql a 
         * Modifica: realiza el cambio en la base de datos de acuerdo al tipo de sentencia 
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
         * Método para llamar al procedimiento almacenado que permite agregar un nuevo 
         * Recibe: el usuario y la contraseña del nuevo usuario así como la cédula del estudiante a quién se asocia ese 
         * Modifica: Agrega en la base de datos un nuevo 
         * Retorna: 1 si se pudo guardar el nuevo usuario, un número diferente a cero que corresponde al número de 
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

                        //Se ejecuta el procedimiento almacenado
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

        /**
         * Método para llamar al procedimiento almacenado para comprobar que un usuario está en la base de datos
         * Recibe: El usuario y contraseña que se desea verificar que está en la base de datos
         * Modifica: Busca el usuario con esa contraseña en la base de 
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

        /** 
         * Metodo que verifica si el correo utilizado para iniciar sesión tiene permisos de administrador
         * Recibe: El correo del usuario a verificar
         * Modifica: Busca el bit de supUser en la base de datos
         * Retorna: true si el usuario tiene permisos de administrador
         */
        public bool superUser (string correo)
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
