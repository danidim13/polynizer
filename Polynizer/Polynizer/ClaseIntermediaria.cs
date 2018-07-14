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

        //public DataTable obtenerListaCanciones(int tipoFiltro, string filtro)
        //{
            /*ToDo*/
        //    DataTable tabla = null;
        //    try
        //    {
        //        if(tipoFiltro == )
        //    }

        //}
        
        public bool login (string correo, string contraseña)
        {
            return bd.login(correo, contraseña);
        }

    }
}
