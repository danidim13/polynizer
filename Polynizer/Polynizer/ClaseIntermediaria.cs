using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Polynizer
{
   
    /*Clase global en la que se almacena el correo del usuario con el que se inició la aplicación*/
    public static class Global
    {
        public const string VERSION = "0.0.2";
        public static string correoUsuario;

        public static LoginWindow login;

        public static UsuarioPrincipal usuarioPrincipal;
        public static UsuarioVerPerfil usuarioVerPerfil;
        public static CancionesUsuario usuarioCanciones;
        public static ListaCompras usuarioCompras;
        public static ComprarTokens usuarioComprarTokens;
        public static ProcesaCancion usuarioProcesarCancion;

        public static PincipalAdmin adminPrincipal;
        public static CancionesAdmin adminCanciones;
        public static ListaUsuarios adminListaUsuarios;
        public static Graficos adminGraficos;
        public static AgregarUsuario adminAgregarUsuario;

        public static ClaseIntermediaria intermediaria = new ClaseIntermediaria();


        public static LoginWindow StartApp()
        {
            login = new LoginWindow();
            /*
            usuarioPrincipal = new UsuarioPrincipal();
            usuarioVerPerfil = new UsuarioVerPerfil();
            usuarioCanciones = new CancionesUsuario();
            usuarioCompras = new ListaCompras();
            usuarioComprarTokens = new ComprarTokens();
            usuarioProcesarCancion = new ProcesaCancion();

            adminPrincipal = new PincipalAdmin();
            adminCanciones = new CancionesAdmin();
            adminListaUsuarios = new ListaUsuarios();
            adminGraficos = new Graficos();
            adminAgregarUsuario = new AgregarUsuario();
            */


            return login;
        }


        public static void setCorreoUsuario(string correo)
        {
            correoUsuario = correo;
        }
    }

    /*Clase que funciona como intermediaria entre la clase con acceso a la base de datos y las ventanas de la aplicación.*/
    public class ClaseIntermediaria
    {
        AccesoBaseDatos bd;

        /*
         * Constructor de la clase
         */ 
        public ClaseIntermediaria()
        {
            bd = new AccesoBaseDatos();
        }

        /*Actualiza un campo especifico del usuario que tiene la sesion activa*/
        public int actualizarCampoUsuario(string campo, string valor)
        {
            return bd.actualizarDatos("update Usuario Set " + campo + " = '" + valor + "' where Correo = '" + Global.correoUsuario + "'");
        }

        /*Devuelve el valor de un campo especifico del usuario con la sesion activa*/
        public SqlDataReader obtenerCampoEspecificoUsuario(string campo)
        {
            SqlDataReader valor = null;
            try
            {
                valor = bd.ejecutarConsulta("Select " + campo + " from Usuario where Correo = '" + Global.correoUsuario + "'");
            }
            catch (SqlException)
            {

            }
            return valor;
        }

        /*Elimina el usuario especificado por su correo.*/
        public int eliminarUsuario(string correo)
        {
            return bd.actualizarDatos("delete from Usuario where Correo = '" + correo + "'");
        }

        /* Devuelve una tabla con los dispositivos del usuario */
        public DataTable obtenerDispositivos()
        {
            DataTable tabla = null;
            try
            {
                tabla = bd.ejecutarConsultaTabla("select UUID As IMEI from Dispositivo where CorreoUsuario = '" + Global.correoUsuario + "'");
            }
            catch (SqlException)
            {

            }
            return tabla;
        }

        /*Devuelve una lista de todos los correos registrados */
        public SqlDataReader obtenerListaCorreos()
        {
            SqlDataReader lista = null;
            try
            {
                lista = bd.ejecutarConsulta("Select U.Correo from Usuario U");
            }
            catch (SqlException ex)
            {

            }
            return lista;
        }
        /*Devuelve una tabla de los usuarios filtrados por el correo. */
        public DataTable obtenerUsuarios(string correo)
        {
            DataTable tabla = null;
            try
            {
                if (correo == "")
                {
                    tabla = bd.ejecutarConsultaTabla("select U.Correo, U.Nombre, U.Apellido, U.FechaNac As FechaDeNacimiento, U.FechaIni As FechaDeInscripción, U.NombrePais As Pais, U.Superuser As Administrador from Usuario U");
                }
                else
                {
                    tabla = bd.ejecutarConsultaTabla("select U.Correo, U.Nombre, U.Apellido, U.FechaNac As FechaDeNacimiento, U.FechaIni As FechaDeInscripción, U.NombrePais As Pais, U.Superuser As Administrador from Usuario U where U.Correo = '" + correo + "'");
                }

            }
            catch (SqlException)
            {

            }
            return tabla;
        }

        /* Metodo que inserta en la tabla Compra una tupla asociada al correo del usuario actual con la cantidad de tokens pasados por parámetro.*/
        public int comprarTokens(int numTokens)
        {
            string fecha = DateTime.Now.ToString("yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
            string hora = DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            int result = bd.actualizarDatos("insert into Compra values ('" + Global.correoUsuario + "', '" + fecha + "', '" + hora + "', " + numTokens + ", 1)");
            return result;
        }

        public int agregarMetadato(int idCancion, string key, string value)
        {
            return bd.actualizarDatos("insert into Metadato values (" + idCancion.ToString() + ", '" + key + "', '" + value + "')");
        }

        /*Metodo que retorna las compras relacionadas al correo con el que se inició la aplicación.*/
        public DataTable obtenerCompras()
        {
            DataTable tabla = null;
            try
            {
                tabla = bd.ejecutarConsultaTabla("select C.NumTokens As TokensComprados, C.Fecha, C.Hora from Compra C where C.Correo = '" + Global.correoUsuario + "' Order by C.Fecha");
            }
            catch (SqlException)
            {

            }
            return tabla;
        }

        /*Metodo que retorna la lista de canciones con su información correspondiente.
          Recibe: el entero tipoFiltro, este puede tener como valor 0 si se usa el filtro general, 1 si se filtra por usuario, y 2 si es por metadatos.
                  un string filtro, este es utilizado para buscar esa string en el campo correspondiente, según el tipo de filtro utilizado.
          Retorna: un DataTable con las canciones y su información corerspondiente.*/
        public DataTable obtenerCanciones(int tipoFiltro, string filtro)
        {
            DataTable tabla = null;
            try
            {
                if(tipoFiltro == 0)
                {
                    //Filtro general
                    if(filtro == "" || filtro == null)
                    {
                        tabla = bd.ejecutarConsultaTabla("select P.CorreoUsuario, P.IDCancion, P.FechaRedimido, P.VersionProcesado from Procesa P");
                    }
                    else
                    {
                        tabla = bd.ejecutarConsultaTabla("select P.CorreoUsuario, P.IDCancion, P.FechaRedimido, P.VersionProcesado, M.Llave as TipoMetadato , M.Valor as ValorMetadato from Procesa P left outer join Metadato M on P.IDCancion = M.IDCancion where P.CorreoUsuario like '%" + filtro +"%' or P.IDCancion like '%"+ filtro +"%' or M.Valor like '%"+ filtro +"%' or M.Llave like '%"+ filtro + "%' or P.VersionProcesado like '%" + filtro + "%'");
                    }
                }
                else
                {
                    if(tipoFiltro==1)
                    {
                        //Filtro por Usuario
                        tabla = bd.ejecutarConsultaTabla("select P.CorreoUsuario, P.IDCancion, P.FechaRedimido, P.VersionProcesado from Procesa P where P.CorreoUsuario like '%" + filtro + "%'");
                    }
                    else
                    {
                        //Filtro por Metadato
                        tabla = bd.ejecutarConsultaTabla("select P.CorreoUsuario, P.IDCancion, P.FechaRedimido, P.VersionProcesado, M.Llave as TipoMetadato , M.Valor as ValorMetadato from Procesa P join Metadato M on P.IDCancion = M.IDCancion where M.Valor like '%" + filtro +"%'");
                    }
                }
            }
            catch (SqlException)
            {

            }
            return tabla;
        }

        /*Metodo utilizado para obtener todos los metadatos relacionados a una canción.
          Recibe: un string que debe ser el ID de la canción de la que se desea obtener los datos.
          Retorna: un DataTable con los metadatos correspondientes.*/
        public DataTable obtenerMetadatos(string IDCancion)
        {
            DataTable tabla = null;
            try
            {
                tabla = bd.ejecutarConsultaTabla("select M.Llave as Tipo, M.Valor as Valor from Metadato M where M.IDCancion = " + IDCancion + ";");
            }
            catch(SqlException ex)
            {

            }
            return tabla;
        }

        /*Metodo que retorna la lista de países.
          Retorna: un SqlDataReader con la lista de los países registrados en la base de datos.*/
        public SqlDataReader obtenerListaPaises()
        {
            SqlDataReader lista = null;
            try
            {
                lista = bd.ejecutarConsulta("Select distinct P.Nombre from Pais P");
            }
            catch (SqlException ex)
            {

            }
            return lista;
        }

        /*Metodo que retorna la lista de IDs de las canciones depentiendo del filtro utlilizado
          Recibe: el entero tipoFiltro, este puede tener como valor 0 si se usa el filtro general, 1 si se filtra por usuario, y 2 si es por metadatos.
                  un string filtro, este es utilizado para buscar esa string en el campo correspondiente, según el tipo de filtro utilizado. 
          Retorna: un SqlDataReader con la lista de IDs.*/
        public SqlDataReader obtenerListaCanciones(int tipoFiltro, string filtro)
        {
            SqlDataReader datos = null;
            try
            {
                if (tipoFiltro == 0)
                {
                    //Filtro general
                    if (filtro == "" || filtro == null)
                    {
                        datos = bd.ejecutarConsulta("select distinct P.IDCancion from Procesa P");
                    }
                    else
                    {
                        datos = bd.ejecutarConsulta("select distinct P.IDCancion from Procesa P left outer join Metadato M on P.IDCancion = M.IDCancion where P.CorreoUsuario like '%" + filtro + "%' or P.IDCancion like '%" + filtro + "%' or M.Valor like '%" + filtro + "%' or M.Llave like '%" + filtro + "%' or P.VersionProcesado like '%" + filtro + "%'");
                    }
                }
                else
                {
                    if (tipoFiltro == 1)
                    {
                        //Filtro por Usuario
                        datos = bd.ejecutarConsulta("select distinct P.IDCancion from Procesa P where P.CorreoUsuario like '%" + filtro + "%'");
                    }
                    else
                    {
                        //Filtro por Metadato
                        datos = bd.ejecutarConsulta("select distinct P.IDCancion from Procesa P join Metadato M on P.IDCancion = M.IDCancion where M.Valor like '%" + filtro + "%'");
                    }
                }
            }
            catch (SqlException ex)
            {

            }
            return datos;
        }
        
        /*Metodo que comprueba si los datos ingresados para iniciar sesión son correctos.
          Recibe: un string correo, este es el correo que se va a buscar en la base de datos.
                  un string contraseña, esta es la contraseña que se va a buscar en la base de datos.
          Retorna: verdadero si el usuario y contraseña son correctos.
                   falso si el usuario y/o contraseña son incorrectos.*/
        public bool login (string correo, string contraseña)
        {
            return bd.login(correo, contraseña);
        }

        /*Metodo que comprueba si el correo tiene permisos de administrador en la aplicación
          Recibe: un string correo, este es el correo del usuario que se desea verificar en la base de datos.\
          Retorna: verdadero si el correo tiene permisos de administrador, falso si el correo no tiene permisos de administrador.*/
        public bool superUser (string correo)
        {
            return bd.superUser(correo);
        }

        /*Metodo para agregar un usuario a la base de datos.
          Recibe: el correo, el nombre, el apellido, la fecha de nacimiento, la fecha de inicio en la aplicación, el país y la contraseña del usuario que se desea registrar, 
                  y superUser debe ser verdadero si el usuario va a tener permisos de administrador o falso si no.
          Retorna: verdadero si el usuario se agregó exitosamente, falso si no se agregó (ya existe un usuario con ese correo en la base de datos)*/
        public bool agregarUsuario(string correo, string nombre, string apellido, string fechaNac, string fechaIni, string pais, string password, bool superUser)
        {
            int resultado = bd.agregarUsuario(correo, nombre, apellido, fechaNac, fechaIni, pais, password, superUser);
            if(resultado == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public int agregarDispositivos(string correoUsuario, string IMEI1, string IMEI2)
        //{
        //    String instruccion;
        //    if (IMEI2 != null)
        //    {
        //         instruccion = "insert into Dispositivo (UUID,CorreoUsuario) values ('" + IMEI1 + "','" + correoUsuario + "'),('"+IMEI2+"','"+correoUsuario+"')";
        //    }
        //    else
        //    {
        //         instruccion = "insert into Dispositivo (UUID,CorreoUsuario) values ('" + IMEI1 + "','" + correoUsuario + "')";
        //    }
        //    return bd.actualizarDatos(instruccion);
        //}

        /*Mayquely*/
        public DataTable obtenerCancionesUsuario(string filtro)
        {

            DataTable tabla = null;
            try
            {

                tabla = bd.ejecutarConsultaTabla("Select p.IDCancion, m.Llave, m.Valor from metadato m join procesa p on m.IDCancion = p.IDCancion where m.llave like '%" + filtro + "%' and p.CorreoUsuario like '" + Global.correoUsuario + "'");

            }
            catch (SqlException ex)

            {

            }
            return tabla;
        }

        public int ProcesarCancion(string url)
        {
            int id = -1;
            if (bd.procesarCancion(url, ref id))
            {
                return id;
            }
            else
            {
                return -1;
            }
        }

        public int ProcesarCancion(byte[] hash)
        {
            int id = -1;
            if(bd.procesarCancion(hash, ref id))
            {
                return id;
            }
            else
            {
                return -1;
            }
        }

        public bool eliminarCancion(string IDCancion)
        {
            int resultado = 0;
            try
            {
                resultado = bd.actualizarDatos("delete from Cancion where ID ='" + IDCancion + "';");
            }
            catch (SqlException ex)
            {

            }
            if (resultado == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int tokensRestantes(string correo)
        {
            return bd.tokensRestantes(correo);
        }
    }
}
