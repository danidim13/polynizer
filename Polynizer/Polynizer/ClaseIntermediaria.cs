using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Polynizer
{
   
    class ClaseIntermediaria
    {
        AccesoBaseDatos bd;

        public ClaseIntermediaria()
        {
            bd = new AccesoBaseDatos();
        }

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
                        tabla = bd.ejecutarConsultaTabla("select P.CorreoUsuario, P.IDCancion, P.FechaRedimido, P.VersionProcesado, M.Llave as TipoMetadato , M.Valor as ValorMetadato from Procesa P join Metadato M on P.IDCancion = M.IDCancion where P.CorreoUsuario like '%" + filtro +"%' or P.IDCancion like '%"+ filtro +"%' or M.Valor like '%"+ filtro +"%'");
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
                        datos = bd.ejecutarConsulta("select distinct P.IDCancion from Procesa P join Metadato M on P.IDCancion = M.IDCancion where P.CorreoUsuario like '%" + filtro + "%' or P.IDCancion like '%" + filtro + "%' or M.Valor like '%" + filtro + "%'");
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
        
        public bool login (string correo, string contraseña)
        {
            return bd.login(correo, contraseña);
        }

        public bool superUser (string correo)
        {
            return bd.superUser(correo);
        }

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

        public int agregarDispositivos(string correoUsuario, string IMEI1, string IMEI2)
        {
            String instruccion;
            if (IMEI2 != null)
            {
                 instruccion = "insert into Dispositivo (UUID,CorreoUsuario) values ('" + IMEI1 + "','" + correoUsuario + "'),('"+IMEI2+"','"+correoUsuario+"')";
            }
            else
            {
                 instruccion = "insert into Dispositivo (UUID,CorreoUsuario) values ('" + IMEI1 + "','" + correoUsuario + "')";
            }
            return bd.actualizarDatos(instruccion);
        }
    }
}
