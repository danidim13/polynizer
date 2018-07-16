using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynizer
{
    public class Controlador
    {
        ClaseIntermediaria intermediaria;
        LoginWindow login;

        string correoUsuario;

        public Controlador(LoginWindow ventanaLogin)
        {
            intermediaria = new ClaseIntermediaria();
            login = ventanaLogin;
        }

        public ClaseIntermediaria GetIntermediaria()
        {
            return intermediaria;
        }

        public void SetCorreoUsuario(string correo)
        {
            correoUsuario = correo;
        }

        public string GetCorreoUsuario()
        {
            return correoUsuario;
        }
    }
}
