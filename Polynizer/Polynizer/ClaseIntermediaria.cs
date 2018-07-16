using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
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
        //public DataTable obtenerListaCanciones(int tipoFiltro, string filtro)
        //{
        /*ToDo*/
        //    DataTable tabla = null;
        //    try
        //    {
        //        if(tipoFiltro == )
        //    }

        //}

          public bool login(string correo, string contraseña)
         {
           return bd.login(correo, contraseña);
          }

        // public bool procesaCancion ( String  txtCancion ,  bit tipo)
        //  {
        // String version = "0.0.1";
        //byte[32] FingerPrint = SHA256.computeHash( Convert.toByte(txtCancion));
        
        
        
         //      return bd.ProcesarCancion( correo, tipo, version, FingerPrint,  txtCancion  )
         //   }


         /* Metodo para obtener las canciones que el usuario ha procesado.
          * Recibe: un String con el nombre del filtro por el que se desea ver la lista 
          * Retorna: Una tabla con los datos de las canciones procesadas por el usuario
          */
         public DataTable obtenerCancionesUsuario ( string filtro)
          {

          DataTable tabla = null;
            try
              {

                tabla = bd.ejecutarConsultaTabla("Select p.IDCancion, m.Llave, m.Valor from metadato m join procesa p on m.IDCancion = p.IDCancion where m.llave like '%" + filtro + "%' and p.CorreoUsuario like 'danidiaza@gmail.com' ");//'%" + correo	+	"%'");

         } catch (SqlException ex)

             {

          }
         return tabla;
         }




    }

    internal class txtCancion
    {
    }
}
