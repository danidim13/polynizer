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
            /*ToDo*/
            DataTable tabla = null;
            try
            {
                if(tipoFiltro == 0)
                {
                    //Filtro general
                    tabla = bd.ejecutarConsultaTabla("select P.CorreoUsuario, P.IDCancion, P.FechaRedimido, P.VersionProcesado from Procesa P");
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

        public SqlDataReader obtenerListaCanciones(int tipoFiltro, string filtro)
        {
            SqlDataReader datos = null;
            try
            {
                if (tipoFiltro == 0)
                {
                    //Filtro general
                    datos = bd.ejecutarConsulta("select distinct P.IDCancion from Procesa P");
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
    }
}
